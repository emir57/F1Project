using System.Threading.Tasks;
using f1project.webui.EmailServices;
using f1project.webui.Identity;
using f1project.webui.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace f1project.webui.Controllers
{
    public class AccountController : Controller
    {
        UserManager<User> _userManager;
        SignInManager<User> _signInManager;
        IEmailSender _emailSender;
        IConfiguration _configuration;
        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, IEmailSender emailSender, IConfiguration configuration)
        {
            this._configuration = configuration;
            this._emailSender = emailSender;
            this._userManager = userManager;
            this._signInManager = signInManager;
        }
        public IActionResult Login(string message, string alert)
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            if (!string.IsNullOrEmpty(message) && !string.IsNullOrEmpty(alert))
            {
                ViewBag.message = message;
                ViewBag.alert = alert;
            }
            var model = new LoginViewModel();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl = null)
        {
            returnUrl = returnUrl ?? "/";
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user == null)
                {
                    ModelState.AddModelError("", "Böyle Bir Kullanıcı Yok.");
                    return View(model);
                }

                var result = await _signInManager.PasswordSignInAsync(user, model.Password, false, true);
                if (!result.Succeeded)
                {
                    ModelState.AddModelError("Password", "Parola yanlış");
                    return View(model);
                }
                if (user.EmailConfirmed == false)
                {
                    ModelState.AddModelError("", "Lütfen E-postanızı Doğrulayınız.");
                    return View(model);
                }
                return Redirect(returnUrl);
            }
            ModelState.AddModelError("", "Bilinmeyen bir hata!");
            return View(model);
        }

        public IActionResult Register()
        {
            var model = new RegisterViewModel();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = new User()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                UserName = model.UserName,
                IsSubscribe = model.IsSubscribe,
            };
            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                string token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                var findUser = await _userManager.FindByEmailAsync(user.Email);
                string siteUrl = _configuration["siteUrl"];
                var url = Url.Action("ConfirmEmail", "Account", new
                {
                    @a = findUser.Id,
                    @b = token
                });
                await _emailSender.SendEmailAsync(findUser.Email, $"Merhaba {findUser.FirstName} {findUser.LastName} F1 Project Hesabınızı Doğrulayın", $"Hesabınızı doğrulamak için lütfen <a href='{siteUrl}/{url}'>Tıklayınız.</a>");
                return RedirectToAction(nameof(Login));
            }
            ModelState.AddModelError("", "Kullanıcı oluşturulurken hata meydana geldi");
            return View(model);

        }
        public async Task<IActionResult> ConfirmEmail(string a, string b)
        {
            var user = await _userManager.FindByIdAsync(a);
            if (user == null)
            {
                Redirect("/");
            }
            if (user.EmailConfirmed == true)
            {
                ViewBag.alert = "success";
                ViewBag.message = "Hesabınız zaten doğrulanmış.";
                return View();
            }

            var result = await _userManager.ConfirmEmailAsync(user, b);

            if (result.Succeeded)
            {
                ViewBag.alert = "success";
                ViewBag.message = "Hesabınız başarılı bir şekilde doğrulandı.";
                return View();
            }
            ViewBag.alert = "danger";
            ViewBag.message = "Hesabınız doğrulanamadı.";

            return View();
        }

        public IActionResult ForgotPassword()
        {
            var model = new ForgotPasswordEmailViewModel();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordEmailViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user == null)
                {
                    ModelState.AddModelError("", "Bu epostaya ait kullanıcı bulunamadı");
                    return View(model);
                }
                string token = await _userManager.GeneratePasswordResetTokenAsync(user);
                string siteUrl = _configuration["siteUrl"];
                string url = Url.Action("ResetPassword", "Account", new
                {
                    @a = user.Id,
                    @b = token
                });
                await _emailSender.SendEmailAsync(user.Email, $"Merhaba {user.FirstName} {user.LastName} Şifrenizi sıfırlayın", $"Şifrenizi sıfırlamak için lütfen <a href='{siteUrl}/{url}'>tıklayınız</a>");
                ViewBag.message = "E-postanıza gelen bağlantı ile şifrenizi sıfırlayabilirsiniz.";
                ViewBag.alert = "alert alert-success";
                return View(model);
            }
            return View(model);
        }

        public IActionResult ResetPassword(string a, string b)
        {
            var model = new ForgotPasswordViewModel()
            {
                userId = a,
                token = b
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> ResetPassword(ForgotPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByIdAsync(model.userId);
                var result = await _userManager.ResetPasswordAsync(user, model.token, model.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction(nameof(Login), new { @message = "Şifre Sıfırlama başarıyla gerçekleştirildi", @alert = "alert alert-success" });
                }
            }
            ModelState.AddModelError("", "Geçersiz İşlem");
            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home", new { @message = "Başarıyla Çıkış Yapıldı", @alert = "alert alert-warning alert-dismissible fade show" });
        }
        [Authorize]
        public IActionResult Managed(string message, string alert)
        {
            ViewBag.message = message;
            ViewBag.alert = alert;

            return View();
        }
        
        [Authorize]
        public PartialViewResult ChangePassword(string message, string alert)
        {
            ViewBag.message = message;
            ViewBag.alert = alert;
            var model = new ChangePassWordViewModel();
            return PartialView("_ChangePassword",model);
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePassWordViewModel model)
        {
            var userId = _userManager.GetUserId(User);
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByIdAsync(userId);
                var result = await _userManager.ChangePasswordAsync(user, model.OldPassword, model.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction(nameof(Managed), new { @message = "Şifre Değiştirme Başarılı", @alert = "alert alert-success" });
                }
                else
                {
                    return RedirectToAction(nameof(Managed), new { @message = "Eski Şifreniz girdiğinizle uyuşmuyor", @alert = "alert alert-danger" });
                }
            }
            return RedirectToAction(nameof(ChangePassword), new { @message = "Şifre Değiştirilemedi", @alert = "alert alert-danger" });
        }
        [Authorize]
        public async Task<PartialViewResult> ChangeProfileSettings()
        {
            var user = await _userManager.GetUserAsync(User);
            var model = new ChangePofileViewModel()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                ProfileDescription = user.ProfileDescription
            };
            return PartialView("_ChangeProfileSettings",model);
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> ChangeProfileSettings(ChangePofileViewModel model)
        {
            var userId = _userManager.GetUserId(User);
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByIdAsync(userId);
                user.FirstName = model.FirstName;
                user.LastName = model.LastName;
                user.ProfileDescription = model.ProfileDescription;
                var result = await _userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction(nameof(Managed), new { @message = "Bilgiler başarıyla güncellendi.", @alert = "alert alert-success" });
                }
            }
            return RedirectToAction(nameof(Managed), new { @message = "Bilgileri güncellerken bir hata meydana geldi.", @alert = "alert alert-danger" });
        }

        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
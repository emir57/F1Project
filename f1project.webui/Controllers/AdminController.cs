using System.Linq;
using System.Threading.Tasks;
using f1project.business.Abstract;
using f1project.webui.Identity;
using f1project.webui.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace f1project.webui.Controllers
{   
    [Authorize(Roles ="Admin")]
    public class AdminController : Controller
    {
        IPostService _postService;
        IF1TeamService _f1TeamService;
        IF1DriverService _f1DriverService;
        UserManager<User> _userManager;
        RoleManager<IdentityRole> _roleManager;
        ApplicationContext _userContext;
        public AdminController(IPostService postService, IF1TeamService f1TeamService, IF1DriverService f1DriverService, UserManager<User> userManager,ApplicationContext userContext,RoleManager<IdentityRole> roleManager)
        {
            this._roleManager = roleManager;
            this._userContext = userContext;
            this._userManager = userManager;
            this._postService = postService;
            this._f1TeamService = f1TeamService;
            this._f1DriverService = f1DriverService;
        }
        public async Task<IActionResult> GetUsers(string message,string alert)
        {
            ViewBag.message = message;
            ViewBag.alert = alert;
            var users = await _userContext.Users.Select(a=>new User{
                Id = a.Id,
                FirstName = a.FirstName,
                LastName = a.LastName,
                ProfileDescription = a.ProfileDescription,
                UserName = a.UserName,
                Email = a.Email,
                EmailConfirmed = a.EmailConfirmed
            }).ToListAsync();
            
            return View(users);
        }
        public async Task<IActionResult> GetUser(string Id)
        {
            ViewBag.roles = _roleManager.Roles.Select(a=>a.Name);
            var user = await _userManager.FindByIdAsync(Id);
            var model = new UserViewModel(){
                Id = Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                ProfileDescription = user.ProfileDescription,
                Email = user.Email,
                EmailConfirmed = user.EmailConfirmed,
                IsSubscribe = user.IsSubscribe,
                UserRoles = await _userManager.GetRolesAsync(user)
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> GetUser(UserViewModel model,string[] selectedRoles)
        {
            
            if(ModelState.IsValid)
            {
                var user = await _userManager.FindByIdAsync(model.Id);
                user.FirstName = model.FirstName;
                user.LastName = model.LastName;
                user.ProfileDescription = model.ProfileDescription;
                user.Email = model.Email;
                user.EmailConfirmed = model.EmailConfirmed;
                user.IsSubscribe = model.IsSubscribe;
                var result = await _userManager.UpdateAsync(user);
                if(result.Succeeded)
                {
                    var userRoles = await _userManager.GetRolesAsync(user);
                    selectedRoles = selectedRoles?? new string[]{};
                    await _userManager.AddToRolesAsync(user,selectedRoles.Except(userRoles).ToArray<string>());
                    await _userManager.RemoveFromRolesAsync(user,userRoles.Except(selectedRoles).ToArray<string>());
                    return RedirectToAction(nameof(GetUsers),new{@message=$"Başarıyla güncellendi {user.Email}",@alert="alert alert-success"});
                }
            }
            return View(model);
        }
        public IActionResult Roles()
        {
            var roles = _roleManager.Roles;
            return View(roles);
        }
        public async Task<IActionResult> GetRole(string name)
        {
            var role = await _roleManager.FindByNameAsync(name);
            var model = new RoleViewModel(){
                Name = role.Name,
                Users = await _userManager.GetUsersInRoleAsync(name)
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> GetRole(RoleViewModel model)
        {
            var role = await _roleManager.FindByNameAsync(model.Name);
            if(!ModelState.IsValid)
            {
                return View(model);
            }
            role.Name = model.Name;
            await _roleManager.UpdateAsync(role);
            ViewBag.message = "Başarıyla Kaydedildi";
            return View(model);
        }
        public IActionResult AddRole()
        {
            var model = new RoleViewModel();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> AddRole(RoleViewModel model)
        {
            if(ModelState.IsValid)
            {
                var result = await _roleManager.CreateAsync(new IdentityRole{Name=model.Name});
                if(result.Succeeded)
                {
                    return RedirectToAction(nameof(Roles));
                }
                return View(model);
            }
            return View(model);
        }
    }
}
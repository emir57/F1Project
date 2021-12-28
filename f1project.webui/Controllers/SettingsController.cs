using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using f1project.business.Abstract;
using f1project.entity.Concrete;
using f1project.webui.Identity;
using f1project.webui.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;

namespace f1project.webui.Controllers
{
    [Authorize(Roles = "Admin,Editör")]
    public class SettingsController : Controller
    {
        IPostService _postService;
        IF1TeamService _f1TeamService;
        IF1DriverService _f1DriverService;
        ICountryService _countryService;
        UserManager<User> _userManager;
        public SettingsController(IPostService postService, IF1TeamService f1TeamService, IF1DriverService f1DriverService, UserManager<User> userManager, ICountryService countryService)
        {
            this._countryService = countryService;
            this._userManager = userManager;
            this._postService = postService;
            this._f1TeamService = f1TeamService;
            this._f1DriverService = f1DriverService;
        }
        public async Task<IActionResult> GetCountries(string message, string alert)
        {
            ViewBag.message = message;
            ViewBag.alert = alert;

            var countries = await _countryService.GetAll();
            return View(countries);
        }
        public async Task<IActionResult> GetCountry(int id)
        {
            var country = await _countryService.GetById(id);
            return View(country);
        }
        [HttpPost]
        public async Task<IActionResult> GetCountry(Country model, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                var country = await _countryService.GetById(model.CountryId);
                if (country == null)
                {
                    return RedirectToAction(nameof(GetCountries), new { @message = $"güncellenecek ülke bulunamadı", @alert = "alert alert-danger" });
                }
                country.CountryName = model.CountryName;
                if (file == null)
                {
                    country.CountryImageUrl = model.CountryImageUrl;
                }
                else
                {
                    string ex = Path.GetExtension(file.FileName);
                    string name = Guid.NewGuid() + ex;
                    string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/" + name);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                        country.CountryImageUrl = name;
                    }
                }
                await _countryService.Update(country);
                return RedirectToAction(nameof(GetCountries), new { @message = $"{model.CountryName} başarıyla güncellendi.", @alert = "alert alert-success" });
            }
            ModelState.AddModelError("", "güncellenirken hata oluştu.");
            return View(model);
            //return RedirectToAction(nameof(GetCountries),new{@message=$"",@alert="alert alert-danger"});
        }

        public async Task<IActionResult> GetTeams(string message, string alert)
        {
            ViewBag.message = message;
            ViewBag.alert = alert;

            var teams = await _f1TeamService.GetAll();
            return View(teams);
        }
        public async Task<IActionResult> GetTeam(int id)
        {
            if (id == 0)
            {
                return RedirectToAction(nameof(GetTeams));
            }
            var team = await _f1TeamService.GetById(id);
            var teamModel = new TeamViewModel
            {
                Id = team.TeamId,
                Name = team.Name,
                Founder = team.Founder,
                FoundationYear = team.FoundationYear,
                TeamBoss = team.TeamBoss,
                TeamImageUrl = team.TeamImageUrl
            };
            return View(teamModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> GetTeam(TeamViewModel model, IFormFile file)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Geçersiz istek");
                return View(model);
            }
            var team = await _f1TeamService.GetById(model.Id);

            team.Name = model.Name;
            team.Founder = model.Founder;
            team.FoundationYear = model.FoundationYear;
            team.TeamBoss = model.TeamBoss;

            if (file == null)
            {
                team.TeamImageUrl = model.TeamImageUrl;
            }
            else
            {
                string ex = Path.GetExtension(file.FileName);
                string name = Guid.NewGuid() + ex;
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/", name);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
                team.TeamImageUrl = name;
            }

            await _f1TeamService.Update(team);

            return RedirectToAction(nameof(GetTeam), new { @id = model.Id });

        }

        public async Task<IActionResult> GetDrivers(string message, string alert)
        {
            ViewBag.message = message;
            ViewBag.alert = alert;

            var drivers = await _f1DriverService.GetAll();
            return View(drivers);
        }
        public async Task<IActionResult> GetDriver(int id, string message, string alert)
        {
            ViewBag.message = message;
            ViewBag.alert = alert;

            var driver = await _f1DriverService.GetById(id);
            driver.Team = await _f1TeamService.GetById(driver.TeamId);
            ViewBag.countries = await _countryService.GetAll();
            ViewBag.teams = await _f1TeamService.GetAll();
            if (id == 0 || driver == null)
            {
                return RedirectToAction(nameof(GetDrivers));
            }
            return View(driver);
        }
        [HttpPost]
        public async Task<IActionResult> GetDriver(F1Driver model, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                var driver = await _f1DriverService.GetById(model.DriverId);
                if (driver == null)
                {
                    return RedirectToAction(nameof(GetDrivers));
                }
                driver.DriverName = model.DriverName;
                driver.DriverSurname = model.DriverSurname;
                driver.DateOfBirth = model.DateOfBirth;
                driver.DriverNumber = model.DriverNumber;
                driver.CountryId = model.CountryId;
                driver.TeamId = model.TeamId;
                if (file == null)
                {
                    driver.DriverImageUrl = model.DriverImageUrl;
                }
                else
                {
                    string ex = Path.GetExtension(file.FileName);
                    string name = Guid.NewGuid() + ex;
                    string directory = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/", name);
                    using (var stream = new FileStream(directory, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                    driver.DriverImageUrl = name;
                }
                await _f1DriverService.Update(driver);

            }

            return RedirectToAction(nameof(GetDriver), new { @id = model.DriverId, @message = "Başarıyla Güncellendi", @alert = "alert alert-success" });
        }

        public async Task<IActionResult> GetPosts(string message, string alert)
        {
            ViewBag.message = message;
            ViewBag.alert = alert;
            var posts = await _postService.GetAll();
            return View(posts);
        }
        [HttpGet]
        public IActionResult AddPost(int id)
        {
            var model = new PostModel();
            string[] imagesPath = Directory.GetFiles(Directory.GetCurrentDirectory()+"/wwwroot/images/");
            List<FileModel> imagesList = new List<FileModel>();
            foreach (var imagePath in imagesPath)
            {
                imagesList.Add(new FileModel{FileName=Path.GetFileName(imagePath)});
            }
            model.Images=imagesList;
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> AddPost(PostModel model, IFormFile ImageTitleUrl)
        {
            if (ModelState.IsValid)
            {
                string ImageTitleName="";
                if (ImageTitleUrl != null)
                {
                    string ex = Path.GetExtension(ImageTitleUrl.FileName);
                    ImageTitleName = Guid.NewGuid() + ex;
                    string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/" + ImageTitleName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await ImageTitleUrl.CopyToAsync(stream);
                    }
                }
                else
                {
                    ModelState.AddModelError("ImageTitleUrl","Başlık Resmi Boş olamaz");
                    return View(model);
                }
                var post = new Post
                {
                    Title = model.Title,
                    BodyText = model.BodyText,
                    ImageTitleUrl = ImageTitleName,
                    SharingDateTime = DateTime.Now
                };
                await _postService.Create(post);
                return RedirectToAction(nameof(GetPost), new { @id = post.PostId, @message = $"{model.Title} başarıyla eklendi. Sağ taraftan pilot/pilotlar veya takım/takımlar seçerek kategorize edebilirsiniz.", @alert = "alert alert-success" });
            }
            ModelState.AddModelError("", "Geçersiz İşlem.");
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> GetPost(int id, string message, string alert)
        {
            ViewBag.message = message;
            ViewBag.alert = alert;
            var post = await _postService.GetById(id);
            var postDriver = await _postService.GetPostWithDrivers(id);
            var postTeam = await _postService.GetPostWithTeams(id);
            ViewBag.getdrivers = await _f1DriverService.GetAll();
            ViewBag.getteams = await _f1TeamService.GetAll();
            
            string[] imagesPath = Directory.GetFiles(Directory.GetCurrentDirectory()+"/wwwroot/images/");
            List<FileModel> imagesList = new List<FileModel>();
            foreach (var imagePath in imagesPath)
            {
                imagesList.Add(new FileModel{FileName=Path.GetFileName(imagePath)});
            }
            var model = new PostModel
            {
                PostId = post.PostId,
                Title = post.Title.ToUpper(),
                BodyText = post.BodyText,
                ImageTitleUrl = post.ImageTitleUrl,
                SelectedDrivers = postDriver.PostsDrivers.Select(a => a.Driver).ToList(),
                SelectedTeams = postTeam.PostsTeams.Select(a => a.Team).ToList(),
                Images = imagesList
            };
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> GetPost(PostModel model, int[] teamIds, int[] driverIds, IFormFile ImageTitleUrlFile)
        {
            if (ModelState.IsValid)
            {
                var post = await _postService.GetById(model.PostId);


                post.ImageTitleUrl = model.ImageTitleUrl;

                if (ImageTitleUrlFile != null)
                {
                    string ex = Path.GetExtension(ImageTitleUrlFile.FileName);
                    string name = Guid.NewGuid() + ex;
                    string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/" + name);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await ImageTitleUrlFile.CopyToAsync(stream);
                        GC.SuppressFinalize(stream);
                    }
                    post.ImageTitleUrl = name;
                }


                await _postService.Update(post, driverIds, teamIds);
                return RedirectToAction(nameof(GetPost), new { @id = post.PostId, @message = $"{model.Title} başarıyla güncellendi.", @alert = "alert alert-success" });
            }
            ModelState.AddModelError("", "Geçersiz İşlem.");
            return View(model);

        }


        //Add
        public IActionResult AddTeam(string message, string alert)
        {
            ViewBag.message = message;
            ViewBag.alert = alert;

            var model = new F1Team();

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> AddTeam(F1Team model, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                if (file != null)
                {
                    string ex = Path.GetExtension(file.FileName);
                    string name = Guid.NewGuid() + ex;
                    string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/" + name);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                        model.TeamImageUrl = name;
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Lütfen resim yükleyiniz");
                    return View(model);
                }
                await _f1TeamService.Create(model);
                return RedirectToAction("GetTeams", "Settings", new { @message = $"{model.Name.ToUpper()} takımı başarıyla eklendi", @alert = "alert alert-success" });
            }
            return View(new { @message = "Takım Eklenirken bir hata meydana geldi", @alert = "alert alert-danger" });
        }

        public async Task<IActionResult> AddDriver(string message, string alert)
        {
            ViewBag.message = message;
            ViewBag.alert = alert;

            ViewBag.countries = await _countryService.GetAll();
            ViewBag.teams = await _f1TeamService.GetAll();
            var model = new F1Driver();

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> AddDriver(F1Driver model, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                if (file != null)
                {
                    string ex = Path.GetExtension(file.FileName);
                    string name = Guid.NewGuid() + ex;
                    string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/" + name);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                        model.DriverImageUrl = name;
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Lütfen Fotoğraf Yükleyiniz.");
                    return View(model);
                }
                await _f1DriverService.Create(model);
                return RedirectToAction("GetDrivers", "Settings", new { @message = $"{model.DriverName.ToUpper()} {model.DriverSurname.ToUpper()} sürücü başarıyla eklendi", @alert = "alert alert-success" });
            }
            return View(new { @message = "Sürücü Eklenirken bir hata meydana geldi", @alert = "alert alert-danger" });
        }

        //Delete
        public async Task<IActionResult> DeleteTeam(int id)
        {
            System.Console.WriteLine(id);
            var team = await _f1TeamService.GetById(id);
            if (team == null)
            {
                return RedirectToAction(nameof(GetTeams), new { @message = "Hatalı işlem", @alert = "alert alert-danger" });
            }
            await _f1TeamService.Delete(team);
            return RedirectToAction(nameof(GetTeams), new { @message = $"{team.Name.ToUpper()} takım başarıyla silindi", @alert = "alert alert-success" });
        }
        public async Task<IActionResult> DeleteDriver(int id)
        {
            var driver = await _f1DriverService.GetById(id);
            if (driver == null)
            {
                return RedirectToAction(nameof(GetDrivers), new { @message = "Hatalı işlem", @alert = "alert alert-danger" });
            }
            await _f1DriverService.Delete(driver);
            return RedirectToAction(nameof(GetDrivers), new { @message = $"{driver.DriverName.ToUpper()} {driver.DriverSurname.ToUpper()} sürücü başarıyla silindi", @alert = "alert alert-success" });
        }
        public async Task<IActionResult> DeleteCountry(int id)
        {
            var country = await _countryService.GetById(id);
            if (country == null)
            {
                return RedirectToAction(nameof(GetCountries), new { @message = "Hatalı işlem", @alert = "alert alert-danger" });
            }
            await _countryService.Delete(country);
            return RedirectToAction(nameof(GetCountries), new { @message = $"{country.CountryName.ToUpper()} ülkesi başarıyla silindi", @alert = "alert alert-success" });
        }
        public async Task<IActionResult> DeletePost(int id)
        {
            var post = await _postService.GetById(id);
            if (post == null)
            {
                return RedirectToAction("/");
            }
            await _postService.Delete(post);
            return RedirectToAction("/");
        }
    

        //image
        public IActionResult Images(string message,string alert)
        {
            ViewBag.message = message;
            ViewBag.alert = alert;

            string[] imagesPath = Directory.GetFiles(Directory.GetCurrentDirectory()+"/wwwroot/images/");
            List<FileModel> files = new List<FileModel>();
            foreach (var filepath in imagesPath)
            {
                files.Add(new FileModel{FileName=Path.GetFileName(filepath)});
            }
            return View(files);
        }
        //upload image
        [HttpPost]
        public async Task<IActionResult> Images(IFormFile file)
        {
            if(file==null)
            {
                return RedirectToAction("Images",new{@message="Resim Boş olamaz",@alert="alert alert-danger"});
            }
            string ex = Path.GetExtension(file.FileName);
            string name = Guid.NewGuid()+ex;
            string path = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/images/"+name);
            using(var stream = new FileStream(path,FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            return RedirectToAction("Images",new{@message="Başarıyla Yüklendi.",@alert="alert alert-success"});
        }
        
        public IActionResult DeleteImage(string name)
        {
            System.Console.WriteLine(name);
            if(!string.IsNullOrEmpty(name))
            {
                string path = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/images/"+name);
                // string[] files = Directory.GetFiles(Directory.GetCurrentDirectory(),"/wwwroot/images/");
                if(System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                    return RedirectToAction("Images",new{@message="Başarıyla silindi.",@alert="alert alert-success"});
                }
                else
                {
                    return RedirectToAction("Images",new{@message="Resim bulunamadı",@alert="alert alert-danger"});
                }
            }
            return RedirectToAction("Images",new{@message="Dosya Adı Boş olamaz",@alert="alert alert-danger"});
        }
    }
}
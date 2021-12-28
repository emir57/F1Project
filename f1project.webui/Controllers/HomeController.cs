using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using f1project.webui.Models;
using f1project.data.Abstract;
using f1project.business.Abstract;
using f1project.business.Concrete;
using Microsoft.AspNetCore.Http;
using System.IO;
using f1project.entity.Concrete;
using Microsoft.AspNetCore.Identity;
using f1project.webui.Identity;

namespace f1project.webui.Controllers
{
    public class HomeController : Controller
    {
        ICountryService _countryService;
        IF1TeamService _teamService;
        IF1DriverService _pilotService;
        IPostService _postService;
        UserManager<User> _userManager;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ICountryService countryService, IF1TeamService teamService, IF1DriverService pilotService, IPostService postService, UserManager<User> userManager)
        {
            this._userManager = userManager;
            this._postService = postService;
            this._pilotService = pilotService;
            this._countryService = countryService;
            this._teamService = teamService;

            _logger = logger;
        }

        public async Task<IActionResult> Index(string message, string alert)
        {
            if (User.Identity.IsAuthenticated)
            {
                var currentUser = await _userManager.GetUserAsync(User);
                ViewBag.Name = currentUser.FirstName.ToUpper();
                ViewBag.Surname = currentUser.LastName.ToUpper();
            }

            ViewBag.message = message;
            ViewBag.alert = alert;

            var posts = await _postService.GetAll();
            return View(posts);
        }
        [HttpPost]
        public async Task<IActionResult> UploadImg(IFormFile fileU)
        {
            if (fileU.Length > 0)
            {
                var ex = Path.GetExtension(fileU.FileName);
                var name = Guid.NewGuid() + ex;
                var directory = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/", name);
                using (var stream = new FileStream(directory, FileMode.Create))
                {
                    await fileU.CopyToAsync(stream);
                }
            }
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Pilots()
        {
            var pilots = await _pilotService.GetAllWithCountries();
            return View(pilots);
        }
        public async Task<IActionResult> Pilot(int id)
        {
            var pilot = await _pilotService.GetById(id);
            ViewBag.id = id;
            return View();
        }
        public async Task<IActionResult> Teams()
        {
            var teams = await _teamService.GetAll();
            return View(teams);
        }
        public async Task<IActionResult> Team(int id)
        {
            var team = await _teamService.GetTeamWithPilots(id);
            var drivers = await _pilotService.GetAllWithCountries(a => a.TeamId == id);
            var model = new GetTeamViewModel()
            {
                Id = team.TeamId,
                Name = team.Name,
                Founder = team.Founder,
                FoundationYear = team.FoundationYear,
                TeamBoss = team.TeamBoss,
                TeamImageUrl = team.TeamImageUrl,
                Drivers = drivers
            };
            return View(model);
        }
        public async Task<IActionResult> Post(int id)
        {
            var post = await _postService.GetById(id);
            return View(post);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

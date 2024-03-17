using Microsoft.AspNetCore.Mvc;
using MvcProject.Models;
using System.Diagnostics;

namespace MvcProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet, Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet, Route("/privacy")]
        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet, Route("/about")]
        public IActionResult About()
        {
            return View();
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true), HttpGet]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

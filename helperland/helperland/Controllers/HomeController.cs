using helperland.Models;
using helperland.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace helperland.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Become_a_helper()
        {
            return View();
        }

        public IActionResult Faq()
        {
            return View();
        }
        public IActionResult Price()
        {
            return View();
        }
    
        public IActionResult About()
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
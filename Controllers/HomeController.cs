using Microsoft.AspNetCore.Mvc;
using PRN_ProjectClient.Models;
using System.Diagnostics;

namespace PRN_ProjectClient.Controllers
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
    }
}

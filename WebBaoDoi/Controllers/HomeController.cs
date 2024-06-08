using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.Mail;
using WebBaoDoi.Areas.Identity.Data;
using WebBaoDoi.Models;

namespace WebBaoDoi.Controllers
{
    public class HomeController : Controller
    {
        private DBContextSample _application;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, DBContextSample application)
        {
            _logger = logger;
            _application = application;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "Manage")]

        public IActionResult Email()
        {
            return View();
        }

        public IActionResult Student()
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

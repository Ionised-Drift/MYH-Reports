using Microsoft.AspNetCore.Mvc;
using MYH_Reports.Models;
using System.Diagnostics;

namespace MYH_Reports.Controllers
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

        public IActionResult Estimates()
        {
            return View();
        }

        public IActionResult Invoices() 
        {
            return View();
        }

        public IActionResult Reports()
        {
            return View();
        }


        //ToDo - Delete this after others are working.
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
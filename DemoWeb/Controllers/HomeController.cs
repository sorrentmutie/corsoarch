using DemoLibreria;
using DemoLibreria.Interfaces;
using DemoWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DemoWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMessageWriter writer;
        private readonly NorthwindContext context;
        private Worker? worker;

        public HomeController(ILogger<HomeController> logger, IMessageWriter writer, NorthwindContext context)
        {
            _logger = logger;
            this.writer = writer;
            this.context = context;
            worker = new Worker(writer);
           // this.a = a;
        }

        public IActionResult Index()
        {
            return View();
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

using DemoLibreria;
using DemoLibreria.Interfaces;
using DemoWeb.Data;
using DemoWeb.Interfaces;
using DemoWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DemoWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMessageWriter writer;
        private readonly ICategoriesData categoriesData;
        private readonly IData<Category, CategoriaDTO, int> genericData;
        private Worker? worker;

        public HomeController(ILogger<HomeController> logger, IMessageWriter writer, 
            // ICategoriesData categoriesData,
            IData<Category, CategoriaDTO, int> genericData)
        {
            _logger = logger;
            this.writer = writer;
           // this.categoriesData = categoriesData;
            this.genericData = genericData;
            worker = new Worker(writer);
           // this.a = a;
        }

        public IActionResult Index()
        {
            //var categories = categoriesData.EstraiCategorie();
            var data = genericData.Get();
            return View(data);
        }

        public IActionResult Privacy()
        {
            // categoriesData.AddCategory(new Category { CategoryName = "New Category" });
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

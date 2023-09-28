using Microsoft.AspNetCore.Mvc;
using MVC_Project.Models;
using System.Diagnostics;

namespace MVC_Project.Controllers
{
    public class HomeController : Controller
    {
        // my code

        public IActionResult DisplayItems()
        {
            List<ItemModel> items = new List<ItemModel>()
            {
                new ItemModel(1, "Apple", 2.0m),
                new ItemModel(2, "Bread", 8.0m),
                new ItemModel(3, "Fish", 20.0m),
                new ItemModel(4, "Yogurt", 4.0m)
            };
            ViewData["List"] = items;
            return View();
        }


        // auto generated

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
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
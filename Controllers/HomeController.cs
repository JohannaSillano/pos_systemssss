using Microsoft.AspNetCore.Mvc;
using pos_system.Models;

namespace pos_system.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Sample Product List
            List<Product> products = new List<Product>
            {
                new Product { Id = 1, Name = "Apple", Amount = 100 },
                new Product { Id = 2, Name = "Banana", Amount = 50 },
                new Product { Id = 3, Name = "Orange", Amount = 80 }
            };

            ViewBag.Products = products;
            return View();
        }
    }
}

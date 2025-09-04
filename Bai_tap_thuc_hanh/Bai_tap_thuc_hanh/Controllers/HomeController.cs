using System.Diagnostics;
using Bai_tap_thuc_hanh.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bai_tap_thuc_hanh.Controllers
{
    public class HomeController : Controller
    {
        protected Product product = new Product();

        public IActionResult Index()
        {
            var products = product.GetProductsList();
            return View(products);
        }

    }
}

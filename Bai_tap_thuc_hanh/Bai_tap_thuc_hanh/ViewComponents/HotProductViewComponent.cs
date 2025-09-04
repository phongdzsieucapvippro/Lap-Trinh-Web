using Bai_tap_thuc_hanh.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bai_tap_thuc_hanh.ViewComponents
{
    public class HotProductViewComponent : ViewComponent
    {
        protected Product product = new Product();
        public IViewComponentResult Invoke()
        {
            var hotProducts = product.GetProductsList();
            return View(hotProducts);
        }
    }
}
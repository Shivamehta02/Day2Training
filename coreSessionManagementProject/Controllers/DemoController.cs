using coreSessionManagementProject.Helpers;
using coreSessionManagementProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace coreSessionManagementProject.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            Product product = new Product()
            { Id = 101, Name = "Product One", Price = 500 };

            SessionHelper.SetObjectAsJson(HttpContext.Session, "product", product);

            List<Product> products = new List<Product>()
            {
                new Product() { Id = 101, Name = "Product Two", Price = 500 },
                new Product() { Id = 101, Name = "Product Three", Price = 501 },
                new Product() { Id = 101, Name = "Product Four", Price = 502 },
                new Product() { Id = 101, Name = "Product Five", Price = 503 }
            };

            SessionHelper.SetObjectAsJson(HttpContext.Session, "products", products);


            return View("Index");
        }
    }
}

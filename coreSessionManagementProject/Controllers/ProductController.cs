using coreSessionManagementProject.Data;
using Microsoft.AspNetCore.Mvc;

namespace coreSessionManagementProject.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            ProductModel model = new ProductModel();
            ViewBag.products = model.findAll();
            return View();
        }
    }
}

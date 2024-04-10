using Microsoft.AspNetCore.Mvc;

namespace MvcWebApp.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

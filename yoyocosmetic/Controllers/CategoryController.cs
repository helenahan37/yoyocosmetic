using Microsoft.AspNetCore.Mvc;

namespace yoyocosmetic.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using yoyocosmetic.Data;
using yoyocosmetic.Models;

namespace yoyocosmetic.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
            
        {
            List<Category> objCategory = _db.Categories.ToList();
            return View(objCategory);
        }

        public IActionResult create()
        {
            return View();
        }
    }
}

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
        [HttpPost]
        public IActionResult create(Category obj)
        {
          if(obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "Name and Display Order can not be the same");
            }
            if (obj.Name!=null && obj.Name.ToLower() == "test")
            {
                ModelState.AddModelError("", "Test in an invalid value");
            }

            if (ModelState.IsValid) { 
            _db.Categories.Add(obj);
            _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
            
        }
    }
}

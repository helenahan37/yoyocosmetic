using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using yoyocosmeRazor_Temp.Data;
using yoyocosmeRazor_Temp.Models;
using static System.Collections.Specialized.BitVector32;

namespace yoyocosmeRazor_Temp.Pages.Categories
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public Category Category { get; set; }

        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (Category.Name == Category.DisplayOrder.ToString())
            {
                ModelState.AddModelError("Category.Name", "Name and Display Order cannot be the same.");
            }
            if (Category.Name != null && Category.Name.ToLower() == "test")
            {
                ModelState.AddModelError("Category.Name", "Test is an invalid value.");
            }

            if (ModelState.IsValid)
            {
                _db.Categories.Add(Category);
                _db.SaveChanges();
                TempData["success"] = "Category has been created successfully.";
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}

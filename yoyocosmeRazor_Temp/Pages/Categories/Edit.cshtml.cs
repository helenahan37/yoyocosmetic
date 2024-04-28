using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using yoyocosmeRazor_Temp.Data;
using yoyocosmeRazor_Temp.Models;

namespace yoyocosmeRazor_Temp.Pages.Categories
{
    [BindProperties]

    public class EditModel : PageModel
    {

        private readonly ApplicationDbContext _db;
        public Category Category { get; set; }
        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet(int? id)
        {
            if(id != null && id != 0)
            {
                Category = _db.Categories.Find(id);
            }
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
                _db.Categories.Update(Category);
                _db.SaveChanges();
                TempData["success"] = "Category updated successfully";
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}

using Book_List_using_Razor_Page.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace Book_List_using_Razor_Page.Pages.BookListPages
{
    public class EditModel : PageModel
    {
        private readonly BookDbContext _db;
        public EditModel(BookDbContext db )
        {
            _db = db;   
        }
        [BindProperty]
        public Book Book { get; set; }
        public void OnGet(int? id)
        {
            Book=_db.Books.Find(id);
        }

        public async Task<IActionResult> OnPost()
        {
             if(ModelState.IsValid)
            {
                _db.Books.Update(Book);
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");   
            }
            else
                return RedirectToPage(Book);  
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Book_List_using_Razor_Page.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Book_List_using_Razor_Page.Pages.BookListPages
{
    public class IndexModel : PageModel
    {
        private readonly BookDbContext _db;
        public IndexModel(BookDbContext db)
        {
            _db = db;
        }
        public IEnumerable<Book> Books { get; set; }

        public async Task OnGet()
        {
            Books = await _db.Books.ToListAsync();
        }

        public async Task<IActionResult> OnPostDelete(int id)
        {
            var book =  _db.Books.Find(id);
            if(book == null)
            {
                return NotFound();
            }
            _db.Books.Remove(book);
            await _db.SaveChangesAsync();
            return RedirectToPage("Index");
        }

    }
}

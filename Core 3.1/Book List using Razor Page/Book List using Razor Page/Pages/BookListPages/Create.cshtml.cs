using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Book_List_using_Razor_Page.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Book_List_using_Razor_Page.Pages.BookListPages
{
    public class CreateModel : PageModel
    {
        private readonly BookDbContext _db;
        public CreateModel(BookDbContext db)
        {
            _db = db;
        }
        [BindProperty]
        public Book Book { get; set; }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                await _db.AddAsync(Book);
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            else
                return Page();
        }
    }
}

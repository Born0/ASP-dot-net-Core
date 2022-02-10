using BookList_MVC_Core3._1_.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookList_MVC_Core3._1_.Controllers
{
    public class BookController1 : Controller
    {
        private readonly BookListDbContext _db;
        public BookController1(BookListDbContext db)
        {
            _db = db;
        }
        // GET: BookController1
        public ActionResult Index()
        {
            var books = _db.Books;
            return View();
        }

        // GET: BookController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BookController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BookController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BookController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BookController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BookController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BookController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

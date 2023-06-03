using LitLounge.Models;
using LitLounge.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LitLounge.Controllers
{
    public class BookController : Controller
    {
        DataContext context;
        public BookController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Search(string? bookName, string? genre)
        {
            ViewBag.Genres = context.Genres.ToList();
            SearchViewModel model = new SearchViewModel()
            {
                BookName = bookName,
                Genre = genre ?? "Any"
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Search(SearchViewModel model)
        {
            ViewBag.Genres = context.Genres.ToList();
            if (!ModelState.IsValid)
                return View(model);

            List<Book> books = context.Books.Include(x => x.Genre).Include(x => x.Author).ToList();

            if (!String.IsNullOrEmpty(model.BookName))
                books = books.Where(x => x.Name.ToLower().Contains(model.BookName.ToLower())).ToList();
            if (!String.IsNullOrEmpty(model.Author))
                books = books.Where(x => x.Author.Name.ToLower().Contains(model.Author.ToLower())).ToList();
            if (!String.IsNullOrEmpty(model.ISBN))
                books = books.Where(x => x.Isbn.Contains(model.ISBN)).ToList();
            if (model.Genre != "Any")
                books = books.Where(x => x.Genre.Name.Contains(model.Genre)).ToList();
            if (model.PagesFrom != 0)
                books = books.Where(x => x.Pages > model.PagesFrom).ToList();
            if (model.PagesTo != 0)
                books = books.Where(x => x.Pages < model.PagesTo).ToList();
            if (model.YearFrom != 0)
                books = books.Where(x => x.PublishingYear > model.YearFrom).ToList();
            if (model.YearTo != 0)
                books = books.Where(x => x.Pages < model.YearTo).ToList();

            model.Books = books;
            return View(model);
        }

    }
}

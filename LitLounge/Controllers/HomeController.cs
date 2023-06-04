using LitLounge.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace LitLounge.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private DataContext context;

        public HomeController(ILogger<HomeController> logger, DataContext context)
        {
            this.context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Book> books = new List<Book>();
            int count = (context.Books.Count() > 7) ? 7 : context.Books.Count();
            books.AddRange(context.Books.Include(x => x.Category).ToList().GetRange(0, count));
            ViewBag.MainPageBooks = books;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
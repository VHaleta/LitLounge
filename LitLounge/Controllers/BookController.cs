using Microsoft.AspNetCore.Mvc;

namespace LitLounge.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

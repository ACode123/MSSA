using Microsoft.AspNetCore.Mvc;

namespace Assignment_12._2.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Titles = new string[] { "Book1", "Book2", "Book3", "UselessBook" };
            return View();
        }
        public IActionResult Details(string Title)
        {
            ViewBag.SelectedBook = Title;
            return View();
        }
        public IActionResult GetImage(string Title)
        {
            return File($@"\Images\{Title.ToLower()}.jpg", "image/jpeg");
        }
    }
}

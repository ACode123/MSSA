using Microsoft.AspNetCore.Mvc;

namespace Assignment12._1.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

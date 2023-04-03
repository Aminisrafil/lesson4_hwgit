using Microsoft.AspNetCore.Mvc;

namespace lesson4_backend.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

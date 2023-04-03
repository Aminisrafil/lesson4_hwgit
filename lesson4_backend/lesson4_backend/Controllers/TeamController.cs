using lesson4_backend.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace lesson4_backend.Controllers
{
    public class TeamController : Controller
    {
        private readonly DataContext _context;
        public TeamController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.Teams.ToList();
            return View(data);
        }
        public IActionResult Detail(int id)
        {
            var tm = _context.Teams.Find(id);

            if (tm == null) return View("Error");

            return View(tm);
        }
    }
}

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission06_Jeffries.Models;

namespace Mission06_Jeffries.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext temp)
        {
            _context = temp;
        }

        // Home Page
        public IActionResult Index()
        {
            return View();
        }

        // About Page
        public IActionResult About()
        {
            return View();
        }

        // GET: Add Movie Form
        [HttpGet]
        public IActionResult AddMovie()
        {
            return View();
        }

        // POST: Save New Movie to Database
        [HttpPost]
        public IActionResult AddMovie(Movies movie)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(movie);
                _context.SaveChanges();
                return RedirectToAction("MovieList"); // Redirect after saving
            }

            return View("Confirmation");
        }
    }
}
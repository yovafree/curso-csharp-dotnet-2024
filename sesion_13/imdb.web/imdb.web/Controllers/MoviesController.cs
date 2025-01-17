using imdb.web.Models;
using Microsoft.AspNetCore.Mvc;

namespace imdb.web.Controllers
{
    public class MoviesController : Controller
    {
        public readonly AppDBContext _context;
        public MoviesController(AppDBContext appDBContext) {
            _context = appDBContext;
        }
        public IActionResult Index(string searchString)
        {

            var movies = _context.Movies.AsQueryable();


            ViewData["CurrentFilter"] = searchString;

            if (!string.IsNullOrEmpty(searchString)) {
                movies = movies.Where(x => x.Title.ToLower().Contains(searchString.ToLower()));
            }

            return View(movies.ToList());
        }


        public IActionResult Details(int id) { 
            var movie = _context.Movies.Where(m => m.Id == id).FirstOrDefault();

            return View(movie);
        }
    }
}

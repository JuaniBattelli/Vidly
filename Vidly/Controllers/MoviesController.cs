using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private MyDbContext _context;

        public MoviesController()
        {
            _context = new MyDbContext();
        }
        public IActionResult Index(int? pageIndex, string sortBy)
        {
            var movies = _context.Movies.ToList();

            return View(movies);
        }

        public IActionResult Details(int id)
        {
            //SingleOrDefault devuelve un valor default (null en este caso) si no encuentra coincidencia
            var movie = _context.Movies.ToList().SingleOrDefault(c => c.Id == id);

            //En caso de ser null error 404.
            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }
    }
}

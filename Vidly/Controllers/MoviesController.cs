using Microsoft.AspNetCore.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        //Attribute Routing
        [Route("Movies/ByReleaseDate/{year:int:regex(\\d{{4}})}/{month:int:regex(\\d{{2}}):range(1, 12)}")]
        public IActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
        public IActionResult Edit(int id)
        {
            return Content("id=" + id);
        }
        //movies
        public IActionResult Index(int? pageIndex, string sortBy)
        {
            var movies = new List<Movie>{
                new Movie { Name = "Star Wars"},
                new Movie { Name = "Matrix"}
            };

                return View(movies);
        }
    }
}

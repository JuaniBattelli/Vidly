using Microsoft.AspNetCore.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        /*public IActionResult Random()
        {
            var movie = new Movie() { Name = "Star Wars" };

            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1"},
                new Customer { Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };


            return View(viewModel);
            //return Content("Content");
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }*/


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
            if(!pageIndex.HasValue) {
                pageIndex = 1;
            }

            if(String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";

            }
                return Content(String.Format("pageIndex=" + pageIndex + "&sortBy=" + sortBy));
        }
    }
}

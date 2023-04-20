using Microsoft.AspNetCore.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {

        private MyDbContext _context;

        public CustomersController()
        {
            _context = new MyDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [Route("Customers")]
        public IActionResult Index()
        {
            var customers = _context.Customers.ToList();

            return View(customers);
        }

        public IActionResult Details(int id)
        {
            //SingleOrDefault devuelve un valor default (null en este caso) si no encuentra coincidencia
            var customer = _context.Customers.ToList().SingleOrDefault(c => c.Id == id);

            //En caso de ser null error 404.
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

    }
}

using Microsoft.AspNetCore.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        //Lista hardcodeada de customers para testear
        List<Customer> customers = new List<Customer>
            {
                new Customer { Name = "Pepe Argento", Id = 1},
                new Customer { Name = "Robert Smith", Id = 2}
            };

        [Route("Customers")]
        public IActionResult Index()
        {
            var viewModel = new CustomersViewModel { Customers = customers };

            return View(viewModel);
        }

        public IActionResult Details(int id)
        {
            //SingleOrDefault devuelve un valor default (null en este caso) si no encuentra coincidencia
            var customer = customers.SingleOrDefault(c => c.Id == id);

            //En caso de ser null error 404.
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

    }
}

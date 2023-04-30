using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Vidly.Models;
using AutoMapper;

namespace Vidly.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private MyDbContext _context;

        public CustomersController()
        {
            _context = new MyDbContext();
        }

        // GET /api/customers
        [HttpGet]
        public IEnumerable<Customer> GetCustomers()
        {
            return _context.Customers.ToList();
        }

        // GET /api/customers/1
        [HttpGet("{id}")]
        public IActionResult GetCustomer(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return NotFound(); // Devuelve una respuesta 404 Not Found

            return Ok(customer); // Devuelve una respuesta 200 OK con el objeto Customer
        }

        // POST /api/customers
        [HttpPost]
        public IActionResult CreateCustomer(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _context.Customers.Add(customer);
            _context.SaveChanges();

            return NoContent();
        }

        //PUT /api/customers/1
        [HttpPut("{id:int}")]
        public IActionResult UpdateCustomer(int id, Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerInDb == null)
            {
                return NotFound();
            }

            customerInDb.Name = customer.Name;
            customerInDb.Birthday = customer.Birthday;
            customerInDb.isSubscribedToNewsletter = customer.isSubscribedToNewsletter;
            customerInDb.MembershipTypeId = customer.MembershipTypeId;

            _context.SaveChanges();

            return NoContent();
        }

        // DELETE /api/customers/1
        [HttpDelete("{id:int}")]
        public IActionResult DeleteCustomer(int id)
        {
            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerInDb == null)
            {
                return NotFound();
            }

            _context.Customers.Remove(customerInDb);
            _context.SaveChanges();

            return NoContent();
        }
    }
}

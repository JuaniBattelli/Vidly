using System.Data.Entity;
namespace Vidly.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        
        public DbSet<Customer> Customers { get; set; }

    }
}

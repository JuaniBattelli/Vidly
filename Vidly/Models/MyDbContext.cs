﻿using System.Data.Entity;
namespace Vidly.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        
        public DbSet<Customer> Customers { get; set; }

        public DbSet<MembershipType> MembershipTypes { get; set; }

        public DbSet<Genre> Genres { get; set; }

    }
}

using SolarCoffee.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace SolarCoffee.Data
{
    public class SolarDbContext : IdentityDbContext
    {
        public SolarDbContext() {}

        public SolarDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) {}
        
        public virtual DbSet<Customer> Customers { get; set; }

        public virtual DbSet<CustomerAddress> CustomerAddresses { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Customer_details.Models;

namespace Customer_details.Data
{
    public class Customer_detailsContext : DbContext
    {
        public Customer_detailsContext (DbContextOptions<Customer_detailsContext> options)
            : base(options)
        {
        }

        public DbSet<Customer_details.Models.Customer> Customer { get; set; } = default!;
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOrderingApplication.Models
{
    //This is the the place where i have connected to the data base.
    public class PizzaContext : DbContext
    {
        //This will help us in the connection to the data base.
        public PizzaContext(DbContextOptions options) : base(options)
        {

        }

        //These are the table in my project.
        //This is Pizza Details Table.
        public DbSet<PizzaDetails> PizzaDetails { get; set; }

        //This is order Details Tabale.
        public DbSet<OrderDetails> OrderDetails { get; set; }
    }
}

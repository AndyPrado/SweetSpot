using Microsoft.EntityFrameworkCore;
using SweetSpot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SweetSpot
{
    public class MyDbContext : DbContext
    {
        //DbSets
        public DbSet<Product> Products { get; set; }
        public DbSet<Ingredients> Ingredients { get; set; }
    }
}

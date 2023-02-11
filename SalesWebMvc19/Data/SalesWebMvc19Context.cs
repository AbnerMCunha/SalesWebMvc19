using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc19.Models;

namespace SalesWebMvc19.Models
{
    public class SalesWebMvc19Context : DbContext
    {
        public SalesWebMvc19Context (DbContextOptions<SalesWebMvc19Context> options)
            : base(options)
        {
        }

        public DbSet<SalesWebMvc19.Models.Department> Department { get; set; }
        public DbSet<SalesWebMvc19.Models.Seller> Seller { get; set; }
        public DbSet<SalesWebMvc19.Models.SalesRecord> SalesRecord { get; set; }
    }
}

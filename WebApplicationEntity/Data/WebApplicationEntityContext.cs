using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationEntity.Models;

namespace WebApplicationEntity.Data
{
    public class WebApplicationEntityContext : DbContext
    {
        public WebApplicationEntityContext (DbContextOptions<WebApplicationEntityContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}

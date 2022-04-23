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

        public DbSet<WebApplicationEntity.Models.Department> Department { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceCatalogue.Model
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

       

        public DbSet<SystemAsset> SystemAsset { get; set; }

        public DbSet<AppRole> AppRole { get; set; }

        public DbSet<ServerAsset> ServerAsset { get; set; }

       

       
    }

    
}

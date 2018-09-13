using Microsoft.EntityFrameworkCore;
using PirisWebApp.Models.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PirisWebApp.Models.Database
{
    public class VGGContext : DbContext
    { 
        public VGGContext(DbContextOptions<VGGContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }
    }
}

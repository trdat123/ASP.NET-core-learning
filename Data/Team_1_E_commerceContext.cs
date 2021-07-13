using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Team_1_E_commerce.Models;

namespace Team_1_E_commerce.Data
{
    public class Team_1_E_commerceContext : DbContext
    {
        public Team_1_E_commerceContext (DbContextOptions<Team_1_E_commerceContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Team_1_E_commerce.Models.Product> Product { get; set; }
        public DbSet<Team_1_E_commerce.Models.Category> Category { get; set; }

    }
}

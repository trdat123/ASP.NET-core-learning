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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CartProduct>()
                .HasOne(c => c.Cart)
                .WithMany(cp => cp.CartProducts)
                .HasForeignKey(ci => ci.CartId);
            
            modelBuilder.Entity<CartProduct>()
                .HasOne(p => p.Product)
                .WithMany(cp => cp.CartProducts)
                .HasForeignKey(pi => pi.ProductId);
        }

        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<CartProduct> CartProducts { get; set; }

    }
}

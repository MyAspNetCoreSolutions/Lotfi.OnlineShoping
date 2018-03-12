using JetBrains.Annotations;
using Lotfi.OnlineShoping.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lotfi.OnlineShoping.Infrastructure.DataAccess
{
    public class MyShopContext : DbContext
    {
        public MyShopContext(DbContextOptions<MyShopContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Peyment> Peyments { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<Peyment>().ToTable("Peyment");
            modelBuilder.Entity<Product>().ToTable("Product");
        }

        #region Commented Code
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{

        //    optionsBuilder.UseSqlServer("Server=.\\BAMDAD-LOTFI; Initial Catalog=MyShop; Integrated Security=true", b => b.MigrationsAssembly("Lotfi.DataAccessLayer"));
        //    base.OnConfiguring(optionsBuilder); 
        //} 
        #endregion

    }
}

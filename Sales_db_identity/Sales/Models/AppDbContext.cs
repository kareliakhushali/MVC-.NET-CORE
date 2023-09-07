﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sales.Models
{
    public class AppDbContext:IdentityDbContext
    {
   public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category() { Id = 1, Name = "Soap" },
                new Category() { Id = 2, Name = "Shampoo" },
               new Category() { Id = 3, Name = "Body Spray" });

            modelBuilder.Entity<Product>().HasData(
                new Product() { Id = 1, Name = "Lux",CatId=1,Qty=10,Rate=50 },
                new Product() { Id = 2, Name = "Dove", CatId = 1, Qty = 12, Rate = 55 },
               new Product() { Id = 3, Name = "Santoor", CatId = 2, Qty = 10, Rate =105 },
              new Product() { Id = 4, Name = "Nyle" , CatId = 2, Qty = 15, Rate = 200 }
              );
        }

    }
}

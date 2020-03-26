using ToyZoneApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToyZoneApp.Context
{
    public abstract class BaseContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=S\\SQLEXPRESS;initial catalog=ToyZoneDb;Integrated Security=True;MultipleActiveResultSets=True;App=EntityFramework");
        }

        public DbSet<Categorys> Categorys{ get; set; }
        public DbSet<Customers> Customers{ get; set; }
        public DbSet<OrdersDetails> OrdersDetails{ get; set; }
        public DbSet<Orders> Orders{ get; set; }
        public DbSet<ProductsDetails> ProductsDetails{ get; set; }
        public DbSet<Products> Products{ get; set; }
    
    }
}

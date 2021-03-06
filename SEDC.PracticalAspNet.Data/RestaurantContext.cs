﻿using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using SEDC.PractialAspNet.WebDemo.Models;
using SEDC.PracticalAspNet.Data.Models;

namespace SEDC.PracticalAspNet.Data
{
    public class RestaurantContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public Database Database => base.Database;
        public int SaveChanges()
        {
            return base.SaveChanges();
        }
        //configuration manager can be used to avoid hardcoding the name of the ConnectionString
        //public RestaurantContext()
        //    : base($"name={ConfigurationManager.AppSettings["ConnectionStringName"]}")
        //{
        //}

        public RestaurantContext()
            : base("name=RestaurantConnection")
        {
        }

        public static RestaurantContext Create()
        {
            return new RestaurantContext();
        }
    }
}
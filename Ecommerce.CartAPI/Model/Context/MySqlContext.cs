﻿using Microsoft.EntityFrameworkCore;

namespace Ecommerce.CartAPI.Model.Context
{
    public class MySqlContext : DbContext
    {
        public MySqlContext(){}
        public MySqlContext(DbContextOptions<MySqlContext> options) 
        : base(options) {}

        public DbSet<CartHeader> CartHeader { get; set; }
        public DbSet<Product> Products{ get; set; }
        public DbSet<CartDetail> CartDetails { get; set; }

    }
}
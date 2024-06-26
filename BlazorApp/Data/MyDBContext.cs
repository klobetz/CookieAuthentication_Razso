﻿using BlazorApp.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Data
{
    public class MyDBContext : DbContext

    {
        public MyDBContext(DbContextOptions<MyDBContext> options):base (options) { }
        public DbSet<User> Users { get; set; }        
    }
}

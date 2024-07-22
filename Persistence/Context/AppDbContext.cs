﻿using CleanArchit.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchit.Persistence.Context
{
    public class AppDbContext: DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { 
        }
        public DbSet<User> Users { get; set; }
    }
}

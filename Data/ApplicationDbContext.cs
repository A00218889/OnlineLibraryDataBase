﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace OnlineLibrary.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Book { get; set; }
        public DbSet<OnlineAccess> OnlineAccess { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(GetBook());
            modelBuilder.Entity<OnlineAccess>().HasData(GetOnlineAccess());
            base.OnModelCreating(modelBuilder);
        }

        private static IEnumerable<Book> GetBook()
        {
            return new List<Book>();
        }

        private static IEnumerable<OnlineAccess> GetOnlineAccess()
        {
            return new List<OnlineAccess>();
        }
    }
}
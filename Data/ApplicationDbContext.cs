using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace OnlineLibrary.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        internal object OnlineAccess;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Book> Book { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(GetBooks());
            base.OnModelCreating(modelBuilder);
        }

        private Book[] GetBooks()
        {
            throw new NotImplementedException();
        }

        private static IEnumerable<OnlineAccess> GetOnlineAccess()
        {
            return new List<OnlineAccess>();    
        }

    }
}
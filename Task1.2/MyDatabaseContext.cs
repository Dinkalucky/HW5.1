using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Task1._2;

namespace Task5._2
{
    internal class MyDatabaseContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Error> Errors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasAlternateKey(p => new { p.Id, p.ProductAlterId });
            modelBuilder.Ignore<Error>();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Product;");
        }
    }
}

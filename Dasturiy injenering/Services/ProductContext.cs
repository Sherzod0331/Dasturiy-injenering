using Dasturiy_injenering.Models;
using Microsoft.EntityFrameworkCore;

namespace Dasturiy_injenering.Services
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=SHERZOD\\SHERZOD;Database=ProductDB;Trusted_Connection=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Product>().Property(p => p.Image).HasColumnType("image");
            base.OnModelCreating(modelBuilder);
        }
    }


}
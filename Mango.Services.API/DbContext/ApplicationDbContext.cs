using Mango.Services.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.ProductAPI
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Samosa",
                Price = 15,
                Description = "Praesent scelerisque, mi sed ultrices condimentum.",
                ImageUrl = "",
                CategoryName = "Appetize"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "Paneer Tikka",
                Price = 15,
                Description = "Praesent scelerisque, mi sed ultrices condimentum.",
                ImageUrl = "",
                CategoryName = "Appetize"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "Sweet Pie",
                Price = 15,
                Description = "Praesent scelerisque, mi sed ultrices condimentum.",
                ImageUrl = "",
                CategoryName = "Appetize"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "Pay bhaji",
                Price = 15,
                Description = "Praesent scelerisque, mi sed ultrices condimentum.",
                ImageUrl = "",
                CategoryName = "Appetize"
            });
        }
    }
}

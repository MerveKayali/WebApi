using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ProductsAPI.Models
{
    public class ProductsContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public ProductsContext(DbContextOptions<ProductsContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Data (Varsayılan veriler eklemek için)
            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, ProductName = "IPhone 14", Price = 40000, IsActive = true },
                new Product { ProductId = 2, ProductName = "IPhone 15", Price = 50000, IsActive = true },
                new Product { ProductId = 3, ProductName = "IPhone 16", Price = 60000, IsActive = true },
                new Product { ProductId = 4, ProductName = "IPhone 17", Price = 70000, IsActive = true }
            );
        }
    }

}
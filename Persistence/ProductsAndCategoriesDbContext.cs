using Microsoft.EntityFrameworkCore;
using Products_and_Categories.Models;

namespace Products_and_Categories.Persistence
{
    public class ProductsAndCategoriesDbContext: DbContext
    {
        public DbSet<Product> Products { get; set; } 
        public DbSet<Category> Categories { get; set; }     
        public DbSet<ProductCategory> ProductCategory { get; set; } 

        public ProductsAndCategoriesDbContext(DbContextOptions<ProductsAndCategoriesDbContext> options)
            : base(options)
        {
            
        }
        
    }
}
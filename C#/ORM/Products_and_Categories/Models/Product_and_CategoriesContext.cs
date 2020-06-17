using Microsoft.EntityFrameworkCore;

namespace Products_and_Categories.Models
{
    public class Products_and_CategoriesContext : DbContext
    {
        public Products_and_CategoriesContext(DbContextOptions options) : base(options) { }

        public DbSet<Product> Product {get;set;}
        public DbSet<Categories> Categories {get;set;}
        public DbSet<Associations> Associations {get;set;}
    }
}
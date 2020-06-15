using Microsoft.EntityFrameworkCore;

namespace Chefs_N_Dishes.Models
{
    public class Chefs_N_DishesContext : DbContext
    {
        public Chefs_N_DishesContext(DbContextOptions options) : base(options) {}

        public DbSet<Dishes> Dishes {get;set;}
        public DbSet<Chef> Chefs {get;set;}
    }
}
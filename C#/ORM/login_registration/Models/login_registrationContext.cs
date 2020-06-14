using Microsoft.EntityFrameworkCore;

namespace login_registration.Models
{
    public class login_registrationContext : DbContext
    {
        public login_registrationContext(DbContextOptions options) : base(options) {}

        public DbSet<User> Users {get;set;}
    }
}
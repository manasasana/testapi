using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace testapi.Authentication
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<LoginModel>().ToTable("Login");
            builder.Entity<RegisterModel>().ToTable("Register");
            builder.Entity<Response>().ToTable("Response");
            builder.Entity<UserRoles>().ToTable("UserRoles");
        }

        
    }
}
    
using LoginAuthentication.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace LoginAuthentication.Context
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base( options) { }
        
        DbSet<User> Users { get; set; } 
        DbSet<Authentication> Authentications { get; set; }
        DbSet<PasswordRecovery> PasswordRecoveries { get; set; }
    }
}

using LoginAuthentication.Models;
using Microsoft.EntityFrameworkCore;
namespace LoginAuthentication.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base( options) { }
        


    }
}

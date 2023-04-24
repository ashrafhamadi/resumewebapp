using ASP_Project.Model;
using Microsoft.EntityFrameworkCore;

namespace ASP_Project.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<UserInfo> UserInfo { get; set; }
    }
}

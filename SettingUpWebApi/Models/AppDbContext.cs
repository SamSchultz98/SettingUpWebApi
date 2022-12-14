using Microsoft.EntityFrameworkCore;

namespace SettingUpWebApi.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Users> Users { get; set; }




        public AppDbContext(DbContextOptions<AppDbContext> Options) : base(Options) { }
        protected override void OnModelCreating(ModelBuilder builder) { }
    }
}

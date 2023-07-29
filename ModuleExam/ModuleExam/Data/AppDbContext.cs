using Microsoft.EntityFrameworkCore;

namespace ModuleExam.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Shop> Shops { get; set; }
    }
}

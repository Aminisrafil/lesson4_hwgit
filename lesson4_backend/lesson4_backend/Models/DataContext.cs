using Microsoft.EntityFrameworkCore;

namespace lesson4_backend.Models
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Team> Teams { get; set; }
    }
}

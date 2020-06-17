using Microsoft.EntityFrameworkCore;

namespace assignment_3.Data
{
    public class StoreDbContext: DbContext

    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options)
            : base(options)
        {
            
        }
        // Each DB set maps to a table in the database
        public DbSet<Models.Post> Posts { get; set; }
    }
}
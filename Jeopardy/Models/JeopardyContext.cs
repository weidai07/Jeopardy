using Microsoft.EntityFrameworkCore;

namespace Jeopardy.Models
{
    public class JeopardyContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Question> Questions { get; set; }

        public JeopardyContext(DbContextOptions options) : base(options) {}
    }
}
using Microsoft.EntityFrameworkCore;

namespace expence_Tracer.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Transaction> Transactions { get; set; }

        public DbSet<Category> Categorys { get; set; }

    }
}

using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        // DbSet<T> represents a table in the DB of type T
        public DbSet<Activity> Activities { get; set; }
    }
}
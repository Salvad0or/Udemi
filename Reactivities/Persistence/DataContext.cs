
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext() { }
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        DbSet<Active> Activity { get; set; }

    }
}
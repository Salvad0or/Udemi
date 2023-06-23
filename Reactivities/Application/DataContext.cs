
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Application
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        DbSet<Active> Activity { get; set; }

    }
}
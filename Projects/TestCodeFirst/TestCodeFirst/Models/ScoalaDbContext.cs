using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace TestCodeFirst.Models
{
    public class ScoalaDbContext : DbContext
    {
        public ScoalaDbContext(DbContextOptions<ScoalaDbContext> options) : base(options)
        {
            
        }

        public DbSet<Elev> Elevi {  get; set; } 

    }
}

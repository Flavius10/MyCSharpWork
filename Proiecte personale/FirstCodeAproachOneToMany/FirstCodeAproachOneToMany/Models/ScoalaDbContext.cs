using Microsoft.EntityFrameworkCore;

namespace FirstCodeAproachOneToMany.Models
{
    public class ScoalaDbContext : DbContext
    {
        public ScoalaDbContext(DbContextOptions<ScoalaDbContext> options):
            base(options)
        {
            
        }

        public DbSet<Elev> Elevi { get; set; }
        public DbSet<Clasa> Clase { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Clasa>()
                .HasMany(e => e.Elevi)
                .WithOne(c => c.Clasa)
                .HasForeignKey(c => c.ClasaID)
                .IsRequired();
        }
    }
}

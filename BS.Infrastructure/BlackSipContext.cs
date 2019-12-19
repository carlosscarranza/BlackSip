using BS.Domain;
using Microsoft.EntityFrameworkCore;

namespace BS.Infrastructure
{
    public partial class BlackSipContext : DbContext
    {
        public BlackSipContext()
        {
        }

        public BlackSipContext(DbContextOptions<BlackSipContext> options)
            : base(options)
        {
        }

        public virtual DbSet<SiteMenu> SiteMenu { get; set; }
        public virtual DbSet<Visitante> Visitante { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost;Database=BlackSip;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SiteMenu>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Url).HasMaxLength(50);
            });

            modelBuilder.Entity<Visitante>(entity =>
            {
                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);
            });
        }
    }
}

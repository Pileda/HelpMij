using BeerhallEF.Migrations;
using BeerhallEF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BeerhallEF.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Brewer> Brewers { get; set; }
        public DbSet<Beer> Beers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionstring =
                @"Server=localhost\SQLEXPRESS01;Database=Beerhall;Integrated Security=True;";
            optionsBuilder.UseSqlServer(connectionstring);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brewer>(MapBrewer);
            modelBuilder.Entity<Beer>(MapBeer);
        }

        private void MapBeer(EntityTypeBuilder<Beer> obj)
        {
            obj.ToTable("Beer");

            obj.Property(t => t.Name)
                .HasMaxLength(100)
                .IsRequired();
        }

        private static void MapBrewer(EntityTypeBuilder<Brewer> obj)
        {
            obj.ToTable("Brewer");

            obj.HasKey(t => t.BrewerId);

            obj.Property(t => t.Name)
                .HasColumnName("BrewerName")
                .IsRequired()
                .HasMaxLength(100);

            obj.Property(t => t.ContactEmail)
                .HasMaxLength(100);

            obj.Property(t => t.Street)
                .HasMaxLength(100);

            obj.HasMany(t => t.Beers)
                .WithOne()
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade)
                .HasForeignKey(t => t.BrewerId);
        }
    }
}

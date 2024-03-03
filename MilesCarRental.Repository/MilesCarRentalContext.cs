using Microsoft.EntityFrameworkCore;
using MilesCarRental.Models;

namespace MilesCarRental.Repository;

public partial class MilesCarRentalContext : DbContext
{
    public MilesCarRentalContext()
    {
    }

    public MilesCarRentalContext(DbContextOptions<MilesCarRentalContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Car> Cars { get; set; }

    public virtual DbSet<Location> Locations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Car>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Brand)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Color)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Line)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Plate)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.PickUpLocation).WithMany(p => p.CarPickUpLocations)
                .HasForeignKey(d => d.PickUpLocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cars_PickUpLocations");

            entity.HasOne(d => d.ReturnLocation).WithMany(p => p.CarReturnLocations)
                .HasForeignKey(d => d.ReturnLocationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cars_ReturnLocations");
        });

        modelBuilder.Entity<Location>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Address)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Latitude).HasColumnType("decimal(10, 7)");
            entity.Property(e => e.Longitude).HasColumnType("decimal(10, 7)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
using Microsoft.EntityFrameworkCore;
using Trupanion.Test.QaLib.Database.GeographyDbo;
using Utilities.ConnectionStringManager.Base;
using Utilities.Constants.Enum;

namespace Database.Trupanion.Context;

public partial class GeographyDboContext : DbContext
{
    public GeographyDboContext()
    {
    }

    public GeographyDboContext(DbContextOptions<GeographyDboContext> options)
        : base(options)
    {
    }

    public virtual DbSet<GeographyDboCountry> Countries { get; set; }
    public virtual DbSet<GeographyDboPostalCode> PostalCodes { get; set; }
    public virtual DbSet<GeographyDboState> States { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(ConnectionString.TrupanionConnectionString(SqlDatabase.geography), options => options.EnableRetryOnFailure().CommandTimeout(60));
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<GeographyDboCountry>(entity =>
        {
            entity.ToTable("Country");

            entity.Property(e => e.CountryCode)
                .HasMaxLength(4)
                .IsUnicode(false);

            entity.Property(e => e.Currency)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.CurrencySymbol)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<GeographyDboPostalCode>(entity =>
        {
            entity.ToTable("PostalCode");

            entity.HasIndex(e => new { e.PostalCode, e.StateId }, "uk_postalcode_id_state")
                .IsUnique();

            entity.Property(e => e.Lat).HasColumnType("numeric(18, 15)");

            entity.Property(e => e.Lon).HasColumnType("numeric(18, 15)");

            entity.Property(e => e.PostalCode)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PostalCode");
        });

        modelBuilder.Entity<GeographyDboState>(entity =>
        {
            entity.ToTable("State");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SetupFee).HasColumnType("smallmoney");

            entity.Property(e => e.StateCode)
                .IsRequired()
                .HasMaxLength(3)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

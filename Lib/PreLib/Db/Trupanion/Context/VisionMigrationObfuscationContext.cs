using Microsoft.EntityFrameworkCore;
using Database.Trupanion.Entity.VisionMigration.Obfuscation;
using Utilities.ConnectionStringManager.Base;
using Utilities.Constants.Enum;

namespace Database.Trupanion.Context;

public partial class VisionMigrationObfuscationContext : DbContext
{
    public VisionMigrationObfuscationContext()
    {
    }

    public VisionMigrationObfuscationContext(DbContextOptions<VisionMigrationObfuscationContext> options)
        : base(options)
    {
    }

    public virtual DbSet<VmObfuscationFirstName> FirstNames { get; set; }
    public virtual DbSet<VmObfuscationLastName> LastNames { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(ConnectionString.TrupanionConnectionString(SqlDatabase.visionmigration), options => options.EnableRetryOnFailure().CommandTimeout(60));
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<VmObfuscationFirstName>(entity =>
        {
            entity.ToTable("FirstName", "Obfuscation");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Gender)
                .IsRequired()
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength(true);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50);
        });

        modelBuilder.Entity<VmObfuscationLastName>(entity =>
        {
            entity.ToTable("LastName", "Obfuscation");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
using Microsoft.EntityFrameworkCore;
using Database.Trupanion.Entity.TestData.ProductVersion;
using Utilities.ConnectionStringManager.Base;
using Utilities.Constants.Enum;

namespace Database.Trupanion.Context;

public partial class TestDataProductVersionContext : DbContext
{
    public TestDataProductVersionContext()
    {
    }

    public TestDataProductVersionContext(DbContextOptions<TestDataProductVersionContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TestDataProductVersionStateVersion> StateVersions { get; set; }
    public virtual DbSet<TestDataProductVersionVersionState> VersionStates { get; set; }
    public virtual DbSet<TestDataProductVersionVersionValue> VersionValues { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(ConnectionString.TrupanionConnectionString(SqlDatabase.testdata), options => options.EnableRetryOnFailure().CommandTimeout(60));
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<TestDataProductVersionStateVersion>(entity =>
        {
            entity.ToTable("StateVersion", "ProductVersion");

            entity.HasOne(d => d.VersionValue)
                .WithMany(p => p.StateVersions)
                .HasForeignKey(d => d.VersionValueId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_productversion_stateversion_versionid");
        });

        modelBuilder.Entity<TestDataProductVersionVersionState>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("VersionState", "ProductVersion");

            entity.Property(e => e.State).HasMaxLength(3);

            entity.Property(e => e.Version)
                .IsRequired()
                .HasMaxLength(10);
        });

        modelBuilder.Entity<TestDataProductVersionVersionValue>(entity =>
        {
            entity.ToTable("VersionValue", "ProductVersion");

            entity.Property(e => e.Version)
                .IsRequired()
                .HasMaxLength(10);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
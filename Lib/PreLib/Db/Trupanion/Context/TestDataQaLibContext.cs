using Microsoft.EntityFrameworkCore;
using Database.Trupanion.Entity.TestData.QaLib;
using Utilities.ConnectionStringManager.Base;
using Utilities.Constants.Enum;

namespace Database.Trupanion.Context;

public partial class TestDataQaLibContext : DbContext
{
    public TestDataQaLibContext()
    {
    }

    public TestDataQaLibContext(DbContextOptions<TestDataQaLibContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TestDataQaLibKeyValueConfiguration> KeyValueConfigurations { get; set; }
    public virtual DbSet<TestDataQaLibOwnerFromEnrollmentEvent> OwnerFromEnrollmentEvents { get; set; }
    public virtual DbSet<TestDataQaLibOwnerIdMinMax> OwnerIdMinMaxes { get; set; }
    public virtual DbSet<TestDataQaLibPendingEnrollment> PendingEnrollments { get; set; }
    public virtual DbSet<TestDataQaLibTestOwner> TestOwners { get; set; }

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

        modelBuilder.Entity<TestDataQaLibKeyValueConfiguration>(entity =>
        {
            entity.ToTable("KeyValueConfiguration", "QALib");

            entity.Property(e => e.ConfigKey)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.ConfigValue)
                .IsRequired()
                .HasMaxLength(2000);
        });

        modelBuilder.Entity<TestDataQaLibOwnerFromEnrollmentEvent>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OwnerFromEnrollmentEvent", "QALib");

            entity.Property(e => e.EmailAddress)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TestDataQaLibOwnerIdMinMax>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OwnerIdMinMax", "QALib");
        });

        modelBuilder.Entity<TestDataQaLibPendingEnrollment>(entity =>
        {
            entity.ToTable("PendingEnrollment", "QALib");

            entity.Property(e => e.EmailAddress)
                .IsRequired()
                .HasMaxLength(200)
                .HasColumnName("EMailAddress");

            entity.Property(e => e.Enrolled).HasColumnType("datetime");

            entity.Property(e => e.Inserted).HasColumnType("datetime");
        });

        modelBuilder.Entity<TestDataQaLibTestOwner>(entity =>
        {
            entity.ToTable("TestOwner", "QALib");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");

            entity.Property(e => e.DeletedOn).HasColumnType("datetime");

            entity.Property(e => e.ExternalId)
                .HasMaxLength(100)
                .IsFixedLength(true);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
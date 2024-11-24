using Microsoft.EntityFrameworkCore;
using Database.Trupanion.Entity.TestData.TestHarness;
using Utilities.ConnectionStringManager.Base;
using Utilities.Constants.Enum;

namespace Database.Trupanion.Context;

public partial class TestDataTestHarnessContext : DbContext
{
    public TestDataTestHarnessContext()
    {
    }

    public TestDataTestHarnessContext(DbContextOptions<TestDataTestHarnessContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TestDataTestHarnessLog> Logs { get; set; }
    public virtual DbSet<TestDataTestHarnessTest> Tests { get; set; }
    public virtual DbSet<TestDataTestHarnessTestList> TestLists { get; set; }
    public virtual DbSet<TestDataTestHarnessTestResult> TestResults { get; set; }
    public virtual DbSet<TestDataTestHarnessTestStatus> TestStatuses { get; set; }

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

        modelBuilder.Entity<TestDataTestHarnessLog>(entity =>
        {
            entity.ToTable("Log", "TestHarness");

            entity.Property(e => e.Date).HasColumnType("datetime");

            entity.Property(e => e.Exception).IsRequired();

            entity.Property(e => e.Level)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(e => e.Logger)
                .IsRequired()
                .HasMaxLength(255);

            entity.Property(e => e.Message).IsRequired();

            entity.Property(e => e.Thread)
                .IsRequired()
                .HasMaxLength(20);
        });

        modelBuilder.Entity<TestDataTestHarnessTest>(entity =>
        {
            entity.ToTable("Test", "TestHarness");

            entity.Property(e => e.CommandLineParams).HasMaxLength(1024);

            entity.Property(e => e.FirstRun).HasColumnType("datetime");

            entity.Property(e => e.LastRun).HasColumnType("datetime");

            entity.Property(e => e.OneTimeCommandLine).HasMaxLength(1024);

            entity.Property(e => e.TestName)
                .IsRequired()
                .HasMaxLength(80);

            entity.Property(e => e.TestPath)
                .IsRequired()
                .HasMaxLength(1024);
        });

        modelBuilder.Entity<TestDataTestHarnessTestList>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("TestList", "TestHarness");

            entity.Property(e => e.CommandLineParams).HasMaxLength(1024);

            entity.Property(e => e.FirstRun).HasColumnType("datetime");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.Property(e => e.LastRun).HasColumnType("datetime");

            entity.Property(e => e.OneTimeCommandLine).HasMaxLength(1024);

            entity.Property(e => e.TestName)
                .IsRequired()
                .HasMaxLength(80);

            entity.Property(e => e.TestPath)
                .IsRequired()
                .HasMaxLength(1024);
        });

        modelBuilder.Entity<TestDataTestHarnessTestResult>(entity =>
        {
            entity.ToTable("TestResult", "TestHarness");

            entity.Property(e => e.ResultName)
                .IsRequired()
                .HasMaxLength(20);
        });

        modelBuilder.Entity<TestDataTestHarnessTestStatus>(entity =>
        {
            entity.ToTable("TestStatus", "TestHarness");

            entity.Property(e => e.StatusName)
                .IsRequired()
                .HasMaxLength(20);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
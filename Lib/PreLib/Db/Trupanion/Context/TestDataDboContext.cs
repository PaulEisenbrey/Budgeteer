using Microsoft.EntityFrameworkCore;
using Database.Trupanion.Entity.TestData.Dbo;
using Utilities.ConnectionStringManager.Base;
using Utilities.Constants.Enum;

namespace Database.Trupanion.Context;

public partial class TestDataDboContext : DbContext
{
    public TestDataDboContext()
    {
    }

    public TestDataDboContext(DbContextOptions<TestDataDboContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TestDataDboGetPolicyVersion> GetPolicyVersions { get; set; }
    public virtual DbSet<TestDataDboGetWaitingPeriod> GetWaitingPeriods { get; set; }
    public virtual DbSet<TestDataDboGetZipsAndClinic> GetZipsAndClinics { get; set; }
    public virtual DbSet<TestDataDboMajorStateProvincesWithZip> MajorStateProvincesWithZips { get; set; }
    public virtual DbSet<TestDataDboWorkflowProcessTest> WorkflowProcessTests { get; set; }

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

        modelBuilder.Entity<TestDataDboGetPolicyVersion>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("GetPolicyVersion");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TestDataDboGetWaitingPeriod>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("GetWaitingPeriods");

            entity.Property(e => e.EffectiveFrom).HasColumnType("date");
        });

        modelBuilder.Entity<TestDataDboGetZipsAndClinic>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("GetZipsAndClinics");

            entity.Property(e => e.ClinicName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.StateCode)
                .IsRequired()
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength(true);

            entity.Property(e => e.Zipcode)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TestDataDboMajorStateProvincesWithZip>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MajorStateProvincesWithZip");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.Property(e => e.StateCode)
                .IsRequired()
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength(true);

            entity.Property(e => e.StateName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Zip)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TestDataDboWorkflowProcessTest>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("WorkflowProcessTests");

            entity.Property(e => e.ActionType)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.InitialLoadType)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.Name).IsRequired();

            entity.Property(e => e.ProcessStatus).HasMaxLength(100);

            entity.Property(e => e.TaskResolution).HasMaxLength(100);

            entity.Property(e => e.TaskStatus).HasMaxLength(100);

            entity.Property(e => e.TaskType)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.Test).IsRequired();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
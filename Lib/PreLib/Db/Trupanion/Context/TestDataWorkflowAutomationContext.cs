using Microsoft.EntityFrameworkCore;
using Database.TestData.TestDataWorkflowAutomation;
using Utilities.ConnectionStringManager.Base;
using Utilities.Constants.Enum;

namespace Database.Trupanion.Context;

public partial class TestDataWorkflowAutomationContext : DbContext
{
    public TestDataWorkflowAutomationContext()
    {
    }

    public TestDataWorkflowAutomationContext(DbContextOptions<TestDataWorkflowAutomationContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TestDataWorkflowAutomationAction> Actions { get; set; }
    public virtual DbSet<TestDataWorkflowAutomationActionType> ActionTypes { get; set; }
    public virtual DbSet<TestDataWorkflowAutomationInitialLoadType> InitialLoadTypes { get; set; }
    public virtual DbSet<TestDataWorkflowAutomationProcessResult> ProcessResults { get; set; }
    public virtual DbSet<TestDataWorkflowAutomationResolution> Resolutions { get; set; }
    public virtual DbSet<TestDataWorkflowAutomationTaskResolution> TaskResolutions { get; set; }
    public virtual DbSet<TestDataWorkflowAutomationTaskStatus> TaskStatuses { get; set; }
    public virtual DbSet<TestDataWorkflowAutomationTaskType> TaskTypes { get; set; }
    public virtual DbSet<TestDataWorkflowAutomationTest> Tests { get; set; }
    public virtual DbSet<TestDataWorkflowAutomationTestSection> TestSections { get; set; }
    public virtual DbSet<TestDataWorkflowAutomationTestStep> TestSteps { get; set; }

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

        modelBuilder.Entity<TestDataWorkflowAutomationAction>(entity =>
        {
            entity.ToTable("Action", "WorkflowAutomation");

            entity.HasOne(d => d.ActionType)
                .WithMany(p => p.Actions)
                .HasForeignKey(d => d.ActionTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_action_actiontype");

            entity.HasOne(d => d.TaskType)
                .WithMany(p => p.Actions)
                .HasForeignKey(d => d.TaskTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_action_tasktype");
        });

        modelBuilder.Entity<TestDataWorkflowAutomationActionType>(entity =>
        {
            entity.ToTable("ActionType", "WorkflowAutomation");

            entity.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<TestDataWorkflowAutomationInitialLoadType>(entity =>
        {
            entity.ToTable("InitialLoadType", "WorkflowAutomation");

            entity.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<TestDataWorkflowAutomationProcessResult>(entity =>
        {
            entity.ToTable("ProcessResult", "WorkflowAutomation");

            entity.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<TestDataWorkflowAutomationResolution>(entity =>
        {
            entity.ToTable("Resolution", "WorkflowAutomation");

            entity.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<TestDataWorkflowAutomationTaskResolution>(entity =>
        {
            entity.ToTable("TaskResolution", "WorkflowAutomation");

            entity.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<TestDataWorkflowAutomationTaskStatus>(entity =>
        {
            entity.ToTable("TaskStatus", "WorkflowAutomation");

            entity.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<TestDataWorkflowAutomationTaskType>(entity =>
        {
            entity.ToTable("TaskType", "WorkflowAutomation");

            entity.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<TestDataWorkflowAutomationTest>(entity =>
        {
            entity.ToTable("Test", "WorkflowAutomation");

            entity.Property(e => e.Description).IsRequired();

            entity.Property(e => e.IsSuccessModeTest)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.HasOne(d => d.TestSection)
                .WithMany(p => p.Tests)
                .HasForeignKey(d => d.TestSectionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_test_testsection");
        });

        modelBuilder.Entity<TestDataWorkflowAutomationTestSection>(entity =>
        {
            entity.ToTable("TestSection", "WorkflowAutomation");

            entity.Property(e => e.Description).IsRequired();

            entity.Property(e => e.Name).IsRequired();

            entity.HasOne(d => d.InitialLoadType)
                .WithMany(p => p.TestSections)
                .HasForeignKey(d => d.InitialLoadTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_testsection_initialloadtype");
        });

        modelBuilder.Entity<TestDataWorkflowAutomationTestStep>(entity =>
        {
            entity.ToTable("TestStep", "WorkflowAutomation");

            entity.Property(e => e.IsSuccessModeStep)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.HasOne(d => d.Action)
                .WithMany(p => p.TestSteps)
                .HasForeignKey(d => d.ActionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_teststep_action");

            entity.HasOne(d => d.Test)
                .WithMany(p => p.TestSteps)
                .HasForeignKey(d => d.TestId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_teststep_test");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
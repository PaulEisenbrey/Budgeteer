using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using Database.Trupanion.Entity.TestData.WorkflowSystemTest;
using Utilities.ConnectionStringManager.Base;
using Utilities.Constants.Enum;

namespace Database.Trupanion.Context;

public partial class TestDataWorkflowSystemTestContext : DbContext
{
    public TestDataWorkflowSystemTestContext()
    {
    }

    public TestDataWorkflowSystemTestContext(DbContextOptions<TestDataWorkflowSystemTestContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TestDataWorkflowSystemTestTestDefinition> TestDefinitions { get; set; }
    public virtual DbSet<TestDataWorkflowSystemTestTestDefinitionStep> TestDefinitionSteps { get; set; }
    public virtual DbSet<TestDataWorkflowSystemTestTestInstance> TestInstances { get; set; }
    public virtual DbSet<TestDataWorkflowSystemTestTestInstanceDetail> TestInstanceDetails { get; set; }
    public virtual DbSet<TestDataWorkflowSystemTestUserMockType> UserMockTypes { get; set; }
    public virtual DbSet<TestDataWorkflowSystemTestWorkflowOwnerName> WorkflowOwnerNames { get; set; }

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

        modelBuilder.Entity<TestDataWorkflowSystemTestTestDefinition>(entity =>
        {
            entity.ToTable("TestDefinition", "WorkflowSystemTest");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            entity.HasOne(d => d.UserMockType)
                .WithMany(p => p.TestDefinitions)
                .HasForeignKey(d => d.UserMockTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_test_usermockId");
        });

        modelBuilder.Entity<TestDataWorkflowSystemTestTestDefinitionStep>(entity =>
        {
            entity.ToTable("TestDefinitionStep", "WorkflowSystemTest");

            entity.HasOne(d => d.TestDefinition)
                .WithMany(p => p.TestDefinitionSteps)
                .HasForeignKey(d => d.TestDefinitionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_testdefinitionstep_testId");
        });

        modelBuilder.Entity<TestDataWorkflowSystemTestTestInstance>(entity =>
        {
            entity.ToTable("TestInstance", "WorkflowSystemTest");

            entity.Property(e => e.RunDate).HasColumnType("datetime");

            entity.HasOne(d => d.TestDefinition)
                .WithMany(p => p.TestInstances)
                .HasForeignKey(d => d.TestDefinitionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_testinstance_testId");
        });

        modelBuilder.Entity<TestDataWorkflowSystemTestTestInstanceDetail>(entity =>
        {
            entity.ToTable("TestInstanceDetail", "WorkflowSystemTest");

            entity.Property(e => e.StartTime).HasColumnType("datetime");

            entity.HasOne(d => d.TestDefinitionStep)
                .WithMany(p => p.TestInstanceDetails)
                .HasForeignKey(d => d.TestDefinitionStepId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_resultdetail_teststepId");

            entity.HasOne(d => d.TestInstance)
                .WithMany(p => p.TestInstanceDetails)
                .HasForeignKey(d => d.TestInstanceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_testinstancedetail_resultHeaderId");
        });

        modelBuilder.Entity<TestDataWorkflowSystemTestUserMockType>(entity =>
        {
            entity.ToTable("UserMockType", "WorkflowSystemTest");

            entity.HasIndex(e => e.EntityId, "uk_entityid")
                .IsUnique();

            entity.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(200);
        });

        modelBuilder.Entity<TestDataWorkflowSystemTestWorkflowOwnerName>(entity =>
        {
            entity.ToTable("WorkflowOwnerName", "WorkflowSystemTest");

            entity.Property(e => e.NameField).IsRequired();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

}
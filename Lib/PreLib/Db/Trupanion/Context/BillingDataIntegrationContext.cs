using Microsoft.EntityFrameworkCore;
using Database.Trupanion.Entity.Billing.DataIntegration;
using Utilities.ConnectionStringManager.Base;
using Utilities.Constants.Enum;

namespace Database.Trupanion.Context;

public partial class BillingDataIntegrationContext : DbContext
{
    public BillingDataIntegrationContext()
    {
    }

    public BillingDataIntegrationContext(DbContextOptions<BillingDataIntegrationContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BillingDataIntegrationBatch> Batches { get; set; }
    public virtual DbSet<BillingDataIntegrationChargeback> Chargebacks { get; set; }
    public virtual DbSet<BillingDataIntegrationFailedPayment> FailedPayments { get; set; }
    public virtual DbSet<BillingDataIntegrationJob> Jobs { get; set; }
    public virtual DbSet<BillingDataIntegrationUpdatedAccountBalance> UpdatedAccountBalances { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(ConnectionString.TrupanionConnectionString(SqlDatabase.billing), options => options.EnableRetryOnFailure().CommandTimeout(60));
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<BillingDataIntegrationBatch>(entity =>
        {
            entity.ToTable("Batch", "DataIntegration");

            entity.HasIndex(e => e.ExternalId, "uk_batch_externalid")
                .IsUnique();

            entity.Property(e => e.ExternalId)
                .IsRequired()
                .HasMaxLength(32)
                .IsUnicode(false);

            entity.Property(e => e.FileId)
                .HasMaxLength(32)
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Job)
                .WithMany(p => p.Batches)
                .HasForeignKey(d => d.JobId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_batch_jobid");
        });

        modelBuilder.Entity<BillingDataIntegrationChargeback>(entity =>
        {
            entity.ToTable("Chargeback", "DataIntegration");

            entity.Property(e => e.AccountBalance).HasColumnType("smallmoney");

            entity.Property(e => e.AccountId)
                .IsRequired()
                .HasMaxLength(40);

            entity.Property(e => e.DefaultPaymentMethodId).HasMaxLength(40);

            entity.Property(e => e.ProcessInstanceId).HasDefaultValueSql("((-1))");

            entity.Property(e => e.Processed)
                .IsRequired()
                .HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<BillingDataIntegrationFailedPayment>(entity =>
        {
            entity.ToTable("FailedPayment", "DataIntegration");

            entity.Property(e => e.AccountBalance).HasColumnType("smallmoney");

            entity.Property(e => e.AccountId)
                .IsRequired()
                .HasMaxLength(40);

            entity.Property(e => e.DefaultPaymentMethodId).HasMaxLength(40);

            entity.Property(e => e.ProcessInstanceId).HasDefaultValueSql("((-1))");

            entity.Property(e => e.Processed)
                .IsRequired()
                .HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<BillingDataIntegrationJob>(entity =>
        {
            entity.ToTable("Job", "DataIntegration");

            entity.HasIndex(e => e.ExternalId, "uk_job_externalid")
                .IsUnique();

            entity.Property(e => e.ExternalId)
                .IsRequired()
                .HasMaxLength(32)
                .IsUnicode(false);

            entity.Property(e => e.Project)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(e => e.TenantId).HasMaxLength(50);
        });

        modelBuilder.Entity<BillingDataIntegrationUpdatedAccountBalance>(entity =>
        {
            entity.ToTable("UpdatedAccountBalance", "DataIntegration");

            entity.Property(e => e.AccountBalance).HasColumnType("smallmoney");

            entity.Property(e => e.AccountId)
                .IsRequired()
                .HasMaxLength(40);

            entity.Property(e => e.DefaultPaymentMethodId).HasMaxLength(40);

            entity.Property(e => e.ProcessInstanceId).HasDefaultValueSql("((-1))");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
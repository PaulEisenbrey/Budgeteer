using Microsoft.EntityFrameworkCore;
using Database.Trupanion.Entity.VisionMigration.Billing;
using Utilities.ConnectionStringManager.Base;
using Utilities.Constants.Enum;

namespace Database.Trupanion.Context;

public partial class VisionMigrationBillingContext : DbContext
{
    public VisionMigrationBillingContext()
    {
    }

    public VisionMigrationBillingContext(DbContextOptions<VisionMigrationBillingContext> options)
        : base(options)
    {
    }

    public virtual DbSet<VMBillingCustomerPaymentMethodMap> CustomerPaymentMethodMaps { get; set; }
    public virtual DbSet<VMBillingMigrationResult> MigrationResults { get; set; }

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

        modelBuilder.Entity<VMBillingCustomerPaymentMethodMap>(entity =>
        {
            entity.HasKey(e => e.CustomerId)
                .HasName("pk_stagingCustomerPaymentMethodMap");

            entity.ToTable("CustomerPaymentMethodMap", "Billing");

            entity.Property(e => e.CustomerId).ValueGeneratedNever();

            entity.Property(e => e.PaymentMethodId)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VMBillingMigrationResult>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("MigrationResult", "Billing");

            entity.Property(e => e.AccountId)
                .IsRequired()
                .HasMaxLength(40);

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.Property(e => e.MigrationStatus).IsRequired();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
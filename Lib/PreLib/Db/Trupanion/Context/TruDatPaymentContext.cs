using Microsoft.EntityFrameworkCore;
using Database.TestData.TruDatPayment;
using Utilities.ConnectionStringManager.Base;
using Utilities.Constants.Enum;

namespace Database.Trupanion.Context;

public partial class TruDatPaymentContext : DbContext
{
    public TruDatPaymentContext()
    {
    }

    public TruDatPaymentContext(DbContextOptions<TruDatPaymentContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TruDataPaymentAccount> Accounts { get; set; }
    public virtual DbSet<TruDataPaymentCheck> Checks { get; set; }
    public virtual DbSet<TruDataPaymentCheckPrintHistory> CheckPrintHistories { get; set; }
    public virtual DbSet<TruDataPaymentClaimPaymentPreference> ClaimPaymentPreferences { get; set; }
    public virtual DbSet<TruDataPaymentEntityPayment> EntityPayments { get; set; }
    public virtual DbSet<TruDataPaymentEntityPaymentGroup> EntityPaymentGroups { get; set; }
    public virtual DbSet<TruDataPaymentPaymentAttempt> PaymentAttempts { get; set; }
    public virtual DbSet<TruDataPaymentPaymentAttemptOrder> PaymentAttemptOrders { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(ConnectionString.TrupanionConnectionString(SqlDatabase.trudat), options => options.EnableRetryOnFailure().CommandTimeout(60));
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<TruDataPaymentAccount>(entity =>
        {
            entity.ToTable("Account", "Payment");

            entity.Property(e => e.AccountNumber)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TruDataPaymentCheck>(entity =>
        {
            entity.ToTable("Check", "Payment");

            entity.HasIndex(e => e.EntityPaymentGroupId, "ix_paymentcheck_epg");

            entity.HasIndex(e => e.Inserted, "ix_paymentcheck_inserted_id_epgrpid_statusid");

            entity.HasIndex(e => e.EntityPaymentGroupId, "ix_paymentcheckentitypaymentgroup");

            entity.HasIndex(e => new { e.StatusId, e.EntityPaymentGroupId }, "ix_pc_entitypaymentgroupid");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Memo)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TruDataPaymentCheckPrintHistory>(entity =>
        {
            entity.ToTable("CheckPrintHistory", "Payment");

            entity.HasIndex(e => e.CheckId, "ix_checkprinthistory_checkid");

            entity.Property(e => e.PrintDate)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Check)
                .WithMany(p => p.CheckPrintHistories)
                .HasForeignKey(d => d.CheckId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_checkprinthistory_check");
        });

        modelBuilder.Entity<TruDataPaymentClaimPaymentPreference>(entity =>
        {
            entity.ToTable("ClaimPaymentPreference", "Payment");

            entity.HasIndex(e => e.ClaimId, "ix_paymentclaimpaymentpreference_cid");

            entity.HasIndex(e => e.ClaimId, "uk_claimpaymentpreference_claimid")
                .IsUnique();

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TruDataPaymentEntityPayment>(entity =>
        {
            entity.ToTable("EntityPayment", "Payment");

            entity.HasIndex(e => e.EntityPaymentGroupId, "ix_paymententitypayement_epgroupid_entityid");

            entity.HasIndex(e => e.EntityPaymentGroupId, "ix_paymententitypayement_epgroupid_id_entityid");

            entity.HasIndex(e => new { e.EntityTypeId, e.EntityId }, "ix_paymententitypayment_etypeid_eid");

            entity.HasIndex(e => e.StatusId, "ix_paymententitypayment_sid");

            entity.HasIndex(e => new { e.StatusId, e.EntityPaymentGroupId }, "ix_paymententitypayment_sid_eid");

            entity.Property(e => e.Amount).HasColumnType("money");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Name).IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.EntityPaymentGroup)
                .WithMany(p => p.EntityPayments)
                .HasForeignKey(d => d.EntityPaymentGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_epayment_epgroup");
        });

        modelBuilder.Entity<TruDataPaymentEntityPaymentGroup>(entity =>
        {
            entity.ToTable("EntityPaymentGroup", "Payment");

            entity.HasIndex(e => new { e.EntityTypeId, e.EntityId }, "ix_entitypaymentgroupentities");

            entity.HasIndex(e => e.EntityTypeId, "ix_paymentenitypaymentgroup_etypeid_id");

            entity.Property(e => e.DateCancelled).HasColumnType("datetime");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.ScheduledPaymentDate).HasColumnType("datetime");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Account)
                .WithMany(p => p.EntityPaymentGroups)
                .HasForeignKey(d => d.AccountId)
                .HasConstraintName("fk_entitypaymentgroup_accountId");
        });

        modelBuilder.Entity<TruDataPaymentPaymentAttempt>(entity =>
        {
            entity.ToTable("PaymentAttempt", "Payment");

            entity.HasIndex(e => new { e.InsertedDate, e.Id }, "idx_paymentattempt_inserteddate");

            entity.HasIndex(e => new { e.StatusId, e.Inserted }, "ix_paymentattempt_status");

            entity.HasIndex(e => e.Inserted, "ix_paymentpaymentattempt_inserted");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.InsertedDate).HasColumnType("date");

            entity.Property(e => e.Message)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.PaymentAmount).HasColumnType("smallmoney");

            entity.Property(e => e.RefNum)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TruDataPaymentPaymentAttemptOrder>(entity =>
        {
            entity.HasKey(e => new { e.PaymentAttemptId, e.EntityPaymentGroupId })
                .HasName("pk_paymentpaymentattemptorder_pid_oid");

            entity.ToTable("PaymentAttemptOrder", "Payment");

            entity.HasIndex(e => e.EntityPaymentGroupId, "ix_paymentattemptorder_epgid");

            entity.HasIndex(e => e.EntityPaymentGroupId, "ix_paymentpaymentattemptorder_epgid");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.PaymentAmount).HasColumnType("smallmoney");

            entity.Property(e => e.PaymentMethodLast4)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength(true);

            entity.HasOne(d => d.EntityPaymentGroup)
                .WithMany(p => p.PaymentAttemptOrders)
                .HasForeignKey(d => d.EntityPaymentGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_entitypaymentgroup_paymentpaymentattemptorder");

            entity.HasOne(d => d.PaymentAttempt)
                .WithMany(p => p.PaymentAttemptOrders)
                .HasForeignKey(d => d.PaymentAttemptId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_paymentpaymentattempt_paymentpaymentattemptorder");
        });

        OnModelCreatingPartial(modelBuilder);
    }
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
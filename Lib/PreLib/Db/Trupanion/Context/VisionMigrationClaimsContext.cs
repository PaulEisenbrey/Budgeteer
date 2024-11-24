using Microsoft.EntityFrameworkCore;
using Database.TestData.VisionMigrationClaims;
using Database.Trupanion.Entity.VisionMigration.Claims;
using Utilities.ConnectionStringManager.Base;
using Utilities.Constants.Enum;

namespace Database.Trupanion.Context;

public partial class VisionMigrationClaimsContext : DbContext
{
    public VisionMigrationClaimsContext()
    {
    }

    public VisionMigrationClaimsContext(DbContextOptions<VisionMigrationClaimsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<VMClaimsBatchFile> BatchFiles { get; set; }
    public virtual DbSet<VMClaimsClaimDocSync> ClaimDocSyncs { get; set; }
    public virtual DbSet<VMClaimsClaimDocSyncGroup> ClaimDocSyncGroups { get; set; }
    public virtual DbSet<VMClaimsClaimDocSyncGroupOwner> ClaimDocSyncGroupOwners { get; set; }
    public virtual DbSet<VMClaimsPaymentAccount> PaymentAccounts { get; set; }
    public virtual DbSet<VMClaimsPetPolicyMilestoneDate> PetPolicyMilestoneDates { get; set; }
    public virtual DbSet<VMClaimsPetPolicyMilestoneDateCurrentChangeTrackingVersion> PetPolicyMilestoneDateCurrentChangeTrackingVersions { get; set; }
    public virtual DbSet<VMClaimsPetSyncFailure> PetSyncFailures { get; set; }
    public virtual DbSet<VMClaimsSegmentOwnerDocStage> SegmentOwnerDocStages { get; set; }
    public virtual DbSet<VMClaimsSharedCustomerRequestCurrentChangeTrackingVersion> SharedCustomerRequestCurrentChangeTrackingVersions { get; set; }
    public virtual DbSet<VMClaimsSharedCustomerRequestCurrentChangeTrackingVersionComm> SharedCustomerRequestCurrentChangeTrackingVersionComms { get; set; }
    public virtual DbSet<VMClaimsSharedCustomerRequestDatum> SharedCustomerRequestData { get; set; }
    public virtual DbSet<VMClaimsSharedEntityRequestCurrentChangeTrackingVersionClaim> SharedEntityRequestCurrentChangeTrackingVersionClaims { get; set; }
    public virtual DbSet<VMClaimsSharedPaymentAccountRequestCurrentChangeTrackingVersion> SharedPaymentAccountRequestCurrentChangeTrackingVersions { get; set; }
    public virtual DbSet<VMClaimsSharedPaymentAccountRequestDatum> SharedPaymentAccountRequestData { get; set; }
    public virtual DbSet<VMClaimsSharedPetRequestCurrentChangeTrackingVersionTrudat> SharedPetRequestCurrentChangeTrackingVersionTrudats { get; set; }
    public virtual DbSet<VMClaimsSharedPetRequestCurrentChangeTrackingVersionVisionMigration> SharedPetRequestCurrentChangeTrackingVersionVisionMigrations { get; set; }
    public virtual DbSet<VMClaimsSharedPetRequestDatum> SharedPetRequestData { get; set; }
    public virtual DbSet<VMClaimsSharedPolicyTermRequestCurrentChangeTrackingVersion> SharedPolicyTermRequestCurrentChangeTrackingVersions { get; set; }
    public virtual DbSet<VMClaimsSharedPolicyTermRequestCurrentChangeTrackingVersionTrudat> SharedPolicyTermRequestCurrentChangeTrackingVersionTrudats { get; set; }
    public virtual DbSet<VMClaimsSharedPolicyTermRequestDatum> SharedPolicyTermRequestData { get; set; }
    public virtual DbSet<VMClaimsSyncExcludedPolicy> SyncExcludedPolicies { get; set; }
    public virtual DbSet<VMClaimsSyncLog> SyncLogs { get; set; }
    public virtual DbSet<VMClaimsVisionClaimSyncExportCurrentChangeTrackingVersion> VisionClaimSyncExportCurrentChangeTrackingVersions { get; set; }
    public virtual DbSet<VMClaimsVisionClaimSyncQueue> VisionClaimSyncQueues { get; set; }
    public virtual DbSet<VMClaimsVisionFile> VisionFiles { get; set; }
    public virtual DbSet<VMClaimsVisionIdentity> VisionIdentities { get; set; }
    public virtual DbSet<VMClaimsWaitingPeriodDataCurrentChangeTrackingVersion> WaitingPeriodDataCurrentChangeTrackingVersions { get; set; }
    public virtual DbSet<VMClaimsWaitingPeriodDatum> WaitingPeriodData { get; set; }

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

        modelBuilder.Entity<VMClaimsBatchFile>(entity =>
        {
            entity.ToTable("BatchFile", "Claims");

            entity.Property(e => e.DocumentType).HasMaxLength(50);

            entity.Property(e => e.ExternalDocUrl).HasMaxLength(400);

            entity.Property(e => e.ExternalId)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FileName)
                .IsRequired()
                .HasMaxLength(200);

            entity.Property(e => e.SearchField).HasMaxLength(2000);
        });

        modelBuilder.Entity<VMClaimsClaimDocSync>(entity =>
        {
            entity.ToTable("ClaimDocSync", "Claims");

            entity.HasIndex(e => new { e.Priority, e.CreateDate, e.ClaimId, e.ExternalDocUrl, e.SyncStatusId }, "IDX_ClaimDocSync");

            entity.HasIndex(e => e.ClaimId, "ix_claimdocsync_claimId")
                .HasFillFactor((byte)70);

            entity.Property(e => e.DocumentType).HasMaxLength(50);

            entity.Property(e => e.ExternalDocUrl).HasMaxLength(400);

            entity.Property(e => e.ExternalId)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FileName)
                .IsRequired()
                .HasMaxLength(200);

            entity.Property(e => e.Hash).HasMaxLength(50);

            entity.Property(e => e.Message)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SearchField).HasMaxLength(2000);
        });

        modelBuilder.Entity<VMClaimsClaimDocSyncGroup>(entity =>
        {
            entity.ToTable("ClaimDocSyncGroup", "Claims");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<VMClaimsClaimDocSyncGroupOwner>(entity =>
        {
            entity.HasKey(e => new { e.OwnerId, e.GroupId })
                .HasName("PK_claimdocsyncgroupOwner");

            entity.ToTable("ClaimDocSyncGroupOwner", "Claims");

            entity.HasOne(d => d.Group)
                .WithMany(p => p.ClaimDocSyncGroupOwners)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_claimdocsyncgroup_groupid");
        });

        modelBuilder.Entity<VMClaimsPaymentAccount>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PaymentAccount", "Claims");

            entity.Property(e => e.AccountNumber)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AccountType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.BankName)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.NameOnAccount).HasMaxLength(255);

            entity.Property(e => e.RoutingNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VMClaimsPetPolicyMilestoneDate>(entity =>
        {
            entity.HasKey(e => new { e.PetPolicyId, e.MilestoneDate })
                .HasName("pk_claimsPetPolicyMilestoneDate");

            entity.ToTable("PetPolicyMilestoneDate", "Claims");

            entity.Property(e => e.MilestoneDate).HasColumnType("date");

            entity.Property(e => e.Reason).HasMaxLength(100);
        });

        modelBuilder.Entity<VMClaimsPetPolicyMilestoneDateCurrentChangeTrackingVersion>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("PetPolicyMilestoneDateCurrentChangeTrackingVersion", "Claims");
        });

        modelBuilder.Entity<VMClaimsPetSyncFailure>(entity =>
        {
            entity.HasKey(e => e.PetId);

            entity.ToTable("PetSyncFailure", "Claims");

            entity.HasIndex(e => e.MarkForRetry, "IX_PetSyncFailure_MarkForRetry");

            entity.HasIndex(e => new { e.OwnerId, e.SegmentId }, "IX_PetSyncFailure_OwnerId_SegmentId");

            entity.Property(e => e.PetId).ValueGeneratedNever();

            entity.Property(e => e.ErrorMessage).IsRequired();

            entity.Property(e => e.MarkForRetry)
                .IsRequired()
                .HasDefaultValueSql("(CONVERT([bit],(0)))");

            entity.Property(e => e.SegmentId).HasDefaultValueSql("((2))");
        });

        modelBuilder.Entity<VMClaimsSegmentOwnerDocStage>(entity =>
        {
            entity.HasKey(e => new { e.OwnerId, e.SegmentId })
                .HasName("PK_SegmentOwner");

            entity.ToTable("SegmentOwnerDocStage", "Claims");
        });

        modelBuilder.Entity<VMClaimsSharedCustomerRequestCurrentChangeTrackingVersion>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("SharedCustomerRequestCurrentChangeTrackingVersion", "Claims");
        });

        modelBuilder.Entity<VMClaimsSharedCustomerRequestCurrentChangeTrackingVersionComm>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("SharedCustomerRequestCurrentChangeTrackingVersion_Comms", "Claims");
        });

        modelBuilder.Entity<VMClaimsSharedCustomerRequestDatum>(entity =>
        {
            entity.ToTable("SharedCustomerRequestData", "Claims");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Payload).IsRequired();
        });

        modelBuilder.Entity<VMClaimsSharedEntityRequestCurrentChangeTrackingVersionClaim>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("SharedEntityRequestCurrentChangeTrackingVersion_Claims", "Claims");
        });

        modelBuilder.Entity<VMClaimsSharedPaymentAccountRequestCurrentChangeTrackingVersion>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("SharedPaymentAccountRequestCurrentChangeTrackingVersion", "Claims");
        });

        modelBuilder.Entity<VMClaimsSharedPaymentAccountRequestDatum>(entity =>
        {
            entity.ToTable("SharedPaymentAccountRequestData", "Claims");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Payload).IsRequired();
        });

        modelBuilder.Entity<VMClaimsSharedPetRequestCurrentChangeTrackingVersionTrudat>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("SharedPetRequestCurrentChangeTrackingVersion_Trudat", "Claims");
        });

        modelBuilder.Entity<VMClaimsSharedPetRequestCurrentChangeTrackingVersionVisionMigration>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("SharedPetRequestCurrentChangeTrackingVersion_VisionMigration", "Claims");
        });

        modelBuilder.Entity<VMClaimsSharedPetRequestDatum>(entity =>
        {
            entity.ToTable("SharedPetRequestData", "Claims");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Payload).IsRequired();
        });

        modelBuilder.Entity<VMClaimsSharedPolicyTermRequestCurrentChangeTrackingVersion>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("SharedPolicyTermRequestCurrentChangeTrackingVersion", "Claims");
        });

        modelBuilder.Entity<VMClaimsSharedPolicyTermRequestCurrentChangeTrackingVersionTrudat>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("SharedPolicyTermRequestCurrentChangeTrackingVersion_Trudat", "Claims");
        });

        modelBuilder.Entity<VMClaimsSharedPolicyTermRequestDatum>(entity =>
        {
            entity.HasKey(e => new { e.PetPolicyId, e.ProductCode, e.StartDate, e.EndDate })
                .HasName("pk_claimsSharedPolicyTermRequestData");

            entity.ToTable("SharedPolicyTermRequestData", "Claims");

            entity.HasIndex(e => e.Ref, "uk_claimsSharedPolicyTermRequestData_fef")
                .IsUnique();

            entity.Property(e => e.ProductCode).HasMaxLength(10);

            entity.Property(e => e.StartDate).HasColumnType("date");

            entity.Property(e => e.EndDate).HasColumnType("date");

            entity.Property(e => e.CoInsuranceLimit).HasColumnType("decimal(18, 2)");

            entity.Property(e => e.ConditionLimit).HasColumnType("decimal(18, 2)");

            entity.Property(e => e.FixedExcessLimit).HasColumnType("decimal(18, 2)");

            entity.Property(e => e.Ref).HasDefaultValueSql("(newid())");

            entity.Property(e => e.SectionLimit).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<VMClaimsSyncExcludedPolicy>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("SyncExcludedPolicies", "Claims");

            entity.HasIndex(e => e.OwnerId, "ix_syncexcludedpolicies_owi");

            entity.HasIndex(e => new { e.OwnerId, e.Reason }, "uk_syncexcludedpolicies_owi_r")
                .IsUnique();

            entity.Property(e => e.ChangeUserId).HasDefaultValueSql("((1))");

            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.PolicyNumber)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Reason)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VMClaimsSyncLog>(entity =>
        {
            entity.ToTable("SyncLog", "Claims");

            entity.Property(e => e.Level).IsRequired();

            entity.Property(e => e.Message).IsRequired();
        });

        modelBuilder.Entity<VMClaimsVisionClaimSyncExportCurrentChangeTrackingVersion>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("VisionClaimSyncExportCurrentChangeTrackingVersion", "Claims");
        });

        modelBuilder.Entity<VMClaimsVisionClaimSyncQueue>(entity =>
        {
            entity.ToTable("VisionClaimSyncQueue", "Claims");

            entity.HasIndex(e => new { e.Priority, e.Id }, "ix_claimsVisionClaimSyncQueue_Pri_Id");

            entity.HasIndex(e => e.Id1, "ix_claimsVisionClaimSyncQueue_id");

            entity.Property(e => e.Id).HasColumnName("_Id");

            entity.Property(e => e.CustomerPayload).IsRequired();

            entity.Property(e => e.Id1).HasColumnName("Id");

            entity.Property(e => e.PaymentPayload).IsRequired();

            entity.Property(e => e.PetPayload).IsRequired();

            entity.Property(e => e.Priority).HasColumnName("_Priority");

            entity.Property(e => e.QueuedOn).HasColumnName("_QueuedOn");
        });

        modelBuilder.Entity<VMClaimsVisionFile>(entity =>
        {
            entity.ToTable("VisionFile", "Claims");

            entity.Property(e => e.Description).HasMaxLength(200);

            entity.Property(e => e.ExternalDocUrl).HasMaxLength(4000);

            entity.Property(e => e.FileName)
                .IsRequired()
                .HasMaxLength(200);
        });

        modelBuilder.Entity<VMClaimsVisionIdentity>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("VisionIdentities", "Claims");

            entity.HasIndex(e => new { e.CustomerId, e.PetId, e.BatchId }, "ix_customer_pet_batch");
        });

        modelBuilder.Entity<VMClaimsWaitingPeriodDataCurrentChangeTrackingVersion>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("WaitingPeriodDataCurrentChangeTrackingVersion", "Claims");
        });

        modelBuilder.Entity<VMClaimsWaitingPeriodDatum>(entity =>
        {
            entity.HasKey(e => new { e.PetPolicyId, e.ConditionType })
                .HasName("pk_claimsWaitingPeriodData_ppid_ct");

            entity.ToTable("WaitingPeriodData", "Claims");

            entity.Property(e => e.ConditionType).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
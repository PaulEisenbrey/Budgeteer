using Microsoft.EntityFrameworkCore;
using Database.Trupanion.Entity.TruDat.PolicyAdmin;
using Utilities.ConnectionStringManager.Base;
using Utilities.Constants.Enum;

namespace Database.Trupanion.Context;

public partial class TruDatPolicyAdminContext : DbContext
{
    public TruDatPolicyAdminContext()
    {
    }

    public TruDatPolicyAdminContext(DbContextOptions<TruDatPolicyAdminContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TruDatPolicyAdminNextNotificationUpdate042022> NextNotificationUpdate042022s { get; set; }
    public virtual DbSet<TruDatPolicyAdminPendingPetPolicyChange> PendingPetPolicyChanges { get; set; }
    public virtual DbSet<TruDatPolicyAdminPendingPolicyChange> PendingPolicyChanges { get; set; }
    public virtual DbSet<TruDatPolicyAdminPendingPolicyholderChange> PendingPolicyholderChanges { get; set; }
    public virtual DbSet<TruDatPolicyAdminPetPolicy> PetPolicies { get; set; }
    public virtual DbSet<TruDatPolicyAdminPetPolicyDatum> PetPolicyData { get; set; }
    public virtual DbSet<TruDatPolicyAdminPetPolicyRateSegmentation> PetPolicyRateSegmentations { get; set; }
    public virtual DbSet<TruDatPolicyAdminPetPolicyRenewalSchedulingFailure> PetPolicyRenewalSchedulingFailures { get; set; }
    public virtual DbSet<TruDatPolicyAdminPetPolicyRevision> PetPolicyRevisions { get; set; }
    public virtual DbSet<TruDatPolicyAdminPetPolicyRevisionApplicationFailure> PetPolicyRevisionApplicationFailures { get; set; }
    public virtual DbSet<TruDatPolicyAdminPolicy> Policies { get; set; }
    public virtual DbSet<TruDatPolicyAdminPolicyDatum> PolicyData { get; set; }
    public virtual DbSet<TruDatPolicyAdminPolicyNumber> PolicyNumbers { get; set; }
    public virtual DbSet<TruDatPolicyAdminPolicyHolder> Policyholders { get; set; }
    public virtual DbSet<TruDatPolicyAdminPolicyholderDatum> PolicyholderData { get; set; }
    public virtual DbSet<TruDatPolicyAdminPolicyholderSearchIndex> PolicyholderSearchIndices { get; set; }
    public virtual DbSet<TruDatPolicyAdminPrivacyPolicyNotificationCutover> PrivacyPolicyNotificationCutovers { get; set; }
    public virtual DbSet<TruDatPolicyAdminRateAdjustmentCutover> RateAdjustmentCutovers { get; set; }
    public virtual DbSet<TruDatPolicyAdminRateAdjustmentCutoverProductSpecific> RateAdjustmentCutoverProductSpecifics { get; set; }

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

        modelBuilder.Entity<TruDatPolicyAdminNextNotificationUpdate042022>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("NextNotificationUpdate042022", "PolicyAdmin");

            entity.Property(e => e.NewNotificationDate).HasColumnType("date");
        });

        modelBuilder.Entity<TruDatPolicyAdminPendingPetPolicyChange>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_policyadminpetpolicychange_id")
                .IsClustered(false);

            entity.ToTable("PendingPetPolicyChange", "PolicyAdmin");

            entity.HasIndex(e => e.CreatedOn, "ix_policyadminpendingpetpolicychanges_createdon");

            entity.HasIndex(e => e.ModifiedOn, "ix_policyadminpendingpetpolicychanges_modifiedon");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.CoinsurancePercentage).HasColumnType("decimal(4, 2)");

            entity.Property(e => e.DateOfBirth).HasColumnType("date");

            entity.Property(e => e.Deductible).HasColumnType("smallmoney");

            entity.Property(e => e.PetName).HasMaxLength(100);

            entity.Property(e => e.PolicyNumber)
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.PolicyholderIsoAlpha3CountryCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength(true);

            entity.Property(e => e.PolicyholderPostalCode).HasMaxLength(20);

            entity.Property(e => e.PolicyholderStateCode).HasMaxLength(3);

            entity.Property(e => e.Premium).HasColumnType("smallmoney");

            entity.Property(e => e.PremiumTaxAmount).HasColumnType("smallmoney");

            entity.Property(e => e.TagNumber).HasMaxLength(50);
        });

        modelBuilder.Entity<TruDatPolicyAdminPendingPolicyChange>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_policyadminpendingpolicychange_id")
                .IsClustered(false);

            entity.ToTable("PendingPolicyChange", "PolicyAdmin");

            entity.HasIndex(e => e.CreatedOn, "ix_policyadminpendingpolicychange_createdon");

            entity.HasIndex(e => e.ModifiedOn, "ix_policyadminpendingpolicychange_modifiedon");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.PolicyNumber).HasMaxLength(40);
        });

        modelBuilder.Entity<TruDatPolicyAdminPendingPolicyholderChange>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_policyadminpendingpolicyholderchange_id")
                .IsClustered(false);

            entity.ToTable("PendingPolicyholderChange", "PolicyAdmin");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Address1).HasMaxLength(100);

            entity.Property(e => e.Address2).HasMaxLength(100);

            entity.Property(e => e.City).HasMaxLength(100);

            entity.Property(e => e.IsoAlpha3CountryCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength(true);

            entity.Property(e => e.LanguagePreference)
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.PostalCode).HasMaxLength(20);

            entity.Property(e => e.StateCode).HasMaxLength(3);
        });

        modelBuilder.Entity<TruDatPolicyAdminPetPolicy>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PetPolicy", "PolicyAdmin");

            entity.Property(e => e.CancellationDate).HasColumnType("datetime");

            entity.Property(e => e.CoinsurancePercentage).HasColumnType("decimal(5, 2)");

            entity.Property(e => e.DateOfBirth).HasColumnType("smalldatetime");

            entity.Property(e => e.DecPageDocumentId).HasMaxLength(100);

            entity.Property(e => e.Deductible).HasColumnType("smallmoney");

            entity.Property(e => e.DefaultCertificateConversionPremium).HasColumnType("smallmoney");

            entity.Property(e => e.Fees).IsRequired();

            entity.Property(e => e.LanguagePreference)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.PendingRateAdjustmentDate).HasColumnType("date");

            entity.Property(e => e.PetName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PolicyDate).HasColumnType("datetime");

            entity.Property(e => e.PolicyNumber)
                .IsRequired()
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.PolicyTermExpirationDate).HasColumnType("datetime");

            entity.Property(e => e.PolicyTermNotificationDate).HasColumnType("datetime");

            entity.Property(e => e.PolicyTermStartDate).HasColumnType("datetime");

            entity.Property(e => e.PolicyholderIsoAlpha3CountryCode)
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.PolicyholderPostalCode)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PolicyholderStateCode)
                .IsRequired()
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.Premium).HasColumnType("smallmoney");

            entity.Property(e => e.PremiumCalculationNeighborhoodName).HasMaxLength(250);

            entity.Property(e => e.PremiumCalculationRegionName).HasMaxLength(50);

            entity.Property(e => e.PremiumTaxAmount).HasColumnType("smallmoney");

            entity.Property(e => e.PriceTermExpirationDate).HasColumnType("datetime");

            entity.Property(e => e.PriceTermNotificationDate).HasColumnType("datetime");

            entity.Property(e => e.PriceTermStartDate).HasColumnType("datetime");

            entity.Property(e => e.TagNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatPolicyAdminPetPolicyDatum>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_policyadminpetpolicydata_id")
                .IsClustered(false);

            entity.ToTable("PetPolicyData", "PolicyAdmin");

            entity.HasIndex(e => e.NextNotificationDate, "ix_policyadminpetpolicydata_nextnotificationdate");

            entity.HasIndex(e => e.PolicyTermNotificationDate, "ix_policyadminpetpolicydata_policytermnotificationdate");

            entity.HasIndex(e => e.PriceTermNotificationDate, "ix_policyadminpetpolicydata_pricetermnotificationdate");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Characteristics).IsRequired();

            entity.Property(e => e.DecPageDocumentId).HasMaxLength(100);

            entity.Property(e => e.DefaultCertificateConversionPremium).HasColumnType("smallmoney");

            entity.Property(e => e.Fees).IsRequired();

            entity.Property(e => e.PremiumCalculationNeighborhoodName).HasMaxLength(250);

            entity.Property(e => e.PremiumCalculationRegionName).HasMaxLength(50);

            entity.Property(e => e.PremiumTaxAmount).HasColumnType("smallmoney");
        });

        modelBuilder.Entity<TruDatPolicyAdminPetPolicyRateSegmentation>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_policyadminratesegmentation_id")
                .IsClustered(false);

            entity.ToTable("PetPolicyRateSegmentation", "PolicyAdmin");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.AgeAtEnrollment)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Breed)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.City)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CurrentPolicyVersion)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.EffectiveDate).HasColumnType("date");

            entity.Property(e => e.EmailAddress)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FullName)
                .IsRequired()
                .HasMaxLength(201)
                .IsUnicode(false);

            entity.Property(e => e.LastYearsRateAfter).HasColumnType("smallmoney");

            entity.Property(e => e.LastYearsRateBefore).HasColumnType("smallmoney");

            entity.Property(e => e.LastYearsRateChange).HasColumnType("decimal(18, 0)");

            entity.Property(e => e.LoyaltySavings).HasColumnType("smallmoney");

            entity.Property(e => e.NewPolicyVersion)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.NewRate).HasColumnType("smallmoney");

            entity.Property(e => e.NotificationDate).HasColumnType("date");

            entity.Property(e => e.OldRate).HasColumnType("smallmoney");

            entity.Property(e => e.PercentChangeInRate).HasColumnType("decimal(18, 0)");

            entity.Property(e => e.PetName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PolicyNumber)
                .IsRequired()
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.PrimaryPhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.State)
                .IsRequired()
                .HasMaxLength(3)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatPolicyAdminPetPolicyRenewalSchedulingFailure>(entity =>
        {
            entity.ToTable("PetPolicyRenewalSchedulingFailure", "PolicyAdmin");

            entity.HasIndex(e => e.CreatedOn, "ix_policyAdminPetPolicyRenewalSchedulingFailure_createdOn");

            entity.HasIndex(e => e.PetPolicyId, "ix_policyAdminPetPolicyRenewalSchedulingFailure_petPolicyId");

            entity.HasIndex(e => e.ModifiedOn, "ix_policyAdminPetPolicyRenewalSchedulingFailuree_modifiedOn");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.ExceptionType).HasMaxLength(200);
        });

        modelBuilder.Entity<TruDatPolicyAdminPetPolicyRevision>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_policyadminpetpolicyrevision_id")
                .IsClustered(false);

            entity.ToTable("PetPolicyRevision", "PolicyAdmin");

            entity.HasIndex(e => e.CreatedOn, "ix_policyadminpetpolicyrevision_createdon");

            entity.HasIndex(e => new { e.IsApplied, e.ApplicationDate }, "ix_policyadminpetpolicyrevision_isapplied_applicationdate");

            entity.HasIndex(e => e.ModifiedOn, "ix_policyadminpetpolicyrevision_modifiedon");

            entity.HasIndex(e => e.PetPolicyId, "ix_policyadminpetpolicyrevision_petpolicyid");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.CancellationDate).HasColumnType("date");

            entity.Property(e => e.Characteristics).IsRequired();

            entity.Property(e => e.CoinsurancePercentage).HasColumnType("decimal(5, 2)");

            entity.Property(e => e.DateOfBirth).HasColumnType("date");

            entity.Property(e => e.DecPageDocumentId)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.Deductible).HasColumnType("smallmoney");

            entity.Property(e => e.DefaultCertificateConversionPremium).HasColumnType("smallmoney");

            entity.Property(e => e.Fees).IsRequired();

            entity.Property(e => e.LanguagePreference)
                .IsRequired()
                .HasMaxLength(10);

            entity.Property(e => e.OptionalEndorsements).IsRequired();

            entity.Property(e => e.PetName)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.PolicyNumber)
                .IsRequired()
                .HasMaxLength(40);

            entity.Property(e => e.PolicyholderIsoAlpha3CountryCode)
                .IsRequired()
                .HasMaxLength(3)
                .IsFixedLength(true);

            entity.Property(e => e.PolicyholderPostalCode)
                .IsRequired()
                .HasMaxLength(10);

            entity.Property(e => e.PolicyholderStateCode)
                .IsRequired()
                .HasMaxLength(3);

            entity.Property(e => e.Premium).HasColumnType("smallmoney");

            entity.Property(e => e.PremiumCalculationNeighborhoodName).HasMaxLength(100);

            entity.Property(e => e.PremiumCalculationRegionName).HasMaxLength(100);

            entity.Property(e => e.PremiumTaxAmount).HasColumnType("smallmoney");

            entity.Property(e => e.RevisionReason)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.TagNumber).HasMaxLength(50);

            entity.Property(e => e.TaxItems).IsRequired();
        });

        modelBuilder.Entity<TruDatPolicyAdminPetPolicyRevisionApplicationFailure>(entity =>
        {
            entity.ToTable("PetPolicyRevisionApplicationFailure", "PolicyAdmin");

            entity.HasIndex(e => e.CreatedOn, "ix_policyAdminPetPolicyRevisionApplicationFailure_createdOn");

            entity.HasIndex(e => e.ModifiedOn, "ix_policyAdminPetPolicyRevisionApplicationFailure_modifiedOn");

            entity.HasIndex(e => e.PetPolicyId, "ix_policyAdminPetPolicyRevisionApplicationFailure_petPolicyId");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.ExceptionType).HasMaxLength(200);
        });

        modelBuilder.Entity<TruDatPolicyAdminPolicy>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("Policy", "PolicyAdmin");

            entity.Property(e => e.PolicyNumber)
                .IsRequired()
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatPolicyAdminPolicyDatum>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_policyadminpolicydata_id")
                .IsClustered(false);

            entity.ToTable("PolicyData", "PolicyAdmin");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.AlternatePolicyholders).IsRequired();

            entity.Property(e => e.Fees)
                .IsRequired()
                .HasColumnName("fees")
                .HasDefaultValueSql("('[]')");
        });

        modelBuilder.Entity<TruDatPolicyAdminPolicyNumber>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_policyadminpolicynumber_id")
                .IsClustered(false);

            entity.ToTable("PolicyNumber", "PolicyAdmin");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.BasePolicyNumber)
                .IsRequired()
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatPolicyAdminPolicyHolder>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("Policyholder", "PolicyAdmin");

            entity.Property(e => e.Address1).HasMaxLength(100);

            entity.Property(e => e.Address2).HasMaxLength(100);

            entity.Property(e => e.AlternatePhoneNumber).HasMaxLength(50);

            entity.Property(e => e.City).HasMaxLength(100);

            entity.Property(e => e.EmailAddress).HasMaxLength(100);

            entity.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.IsoAlpha3CountryCode)
                .HasMaxLength(4)
                .IsUnicode(false);

            entity.Property(e => e.LanguagePreference)
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.PostalCode).HasMaxLength(20);

            entity.Property(e => e.PrimaryPhoneNumber).HasMaxLength(50);

            entity.Property(e => e.StateCode).HasMaxLength(3);
        });

        modelBuilder.Entity<TruDatPolicyAdminPolicyholderDatum>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_policyadminpolicyholder_id")
                .IsClustered(false);

            entity.ToTable("PolicyholderData", "PolicyAdmin");

            entity.HasIndex(e => e.EmailAddress, "ix_policyadmin_policyholder_emailaddress");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Address1).HasMaxLength(100);

            entity.Property(e => e.Address2).HasMaxLength(100);

            entity.Property(e => e.AlternatePhoneNumber).HasMaxLength(20);

            entity.Property(e => e.Characteristics).IsRequired();

            entity.Property(e => e.City).HasMaxLength(100);

            entity.Property(e => e.EmailAddress).HasMaxLength(100);

            entity.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.IsoAlpha3CountryCode)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength(true);

            entity.Property(e => e.LanguagePreference)
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.PostalCode).HasMaxLength(20);

            entity.Property(e => e.PrimaryPhoneNumber).HasMaxLength(20);

            entity.Property(e => e.StateCode).HasMaxLength(3);
        });

        modelBuilder.Entity<TruDatPolicyAdminPolicyholderSearchIndex>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PolicyholderSearchIndex", "PolicyAdmin");

            entity.Property(e => e.AlternatePhoneNumber)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.EmailAddress)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PolicyNumber)
                .IsRequired()
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.PostalCode)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PrimaryPhoneNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatPolicyAdminPrivacyPolicyNotificationCutover>(entity =>
        {
            entity.HasKey(e => e.StateId)
                .HasName("pk_policyadminprivacypolicynotificationcutover");

            entity.ToTable("PrivacyPolicyNotificationCutover", "PolicyAdmin");

            entity.Property(e => e.StateId).ValueGeneratedNever();
        });

        modelBuilder.Entity<TruDatPolicyAdminRateAdjustmentCutover>(entity =>
        {
            entity.HasKey(e => e.StateId)
                .HasName("pk_PolicyAdminRateAdjustmentCutover");

            entity.ToTable("RateAdjustmentCutover", "PolicyAdmin");

            entity.HasIndex(e => e.StateId, "NonClusteredIndex[ix_sid]");

            entity.Property(e => e.StateId).ValueGeneratedNever();
        });

        modelBuilder.Entity<TruDatPolicyAdminRateAdjustmentCutoverProductSpecific>(entity =>
        {
            entity.HasKey(e => new { e.StateId, e.ProductId })
                .HasName("pk_PolicyAdminRateAdjustmentCutoverProductSpecific");

            entity.ToTable("RateAdjustmentCutoverProductSpecific", "PolicyAdmin");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
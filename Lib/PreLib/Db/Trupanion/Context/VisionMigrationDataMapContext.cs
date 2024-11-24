using Microsoft.EntityFrameworkCore;
using Database.Trupanion.Entity.VisionMigration.DataMap;
using Utilities.ConnectionStringManager.Base;
using Utilities.Constants.Enum;

namespace Database.Trupanion.Context;

public partial class VisionMigrationDataMapContext : DbContext
{
    public VisionMigrationDataMapContext()
    {
    }

    public VisionMigrationDataMapContext(DbContextOptions<VisionMigrationDataMapContext> options)
        : base(options)
    {
    }

    public virtual DbSet<VmDataMapAdditionalBenefitToPolicySection> AdditionalBenefitToPolicySections { get; set; }
    public virtual DbSet<VmDataMapCancelReasonMap> CancelReasonMaps { get; set; }
    public virtual DbSet<VmDataMapConditionAilmentLocationMap> ConditionAilmentLocationMaps { get; set; }
    public virtual DbSet<VmDataMapConditionAilmentMap> ConditionAilmentMaps { get; set; }
    public virtual DbSet<VmDataMapContentItemToVisionFile> ContentItemToVisionFiles { get; set; }
    public virtual DbSet<VmDataMapDmsToVisionFile> DmsToVisionFiles { get; set; }
    public virtual DbSet<VmDataMapEmailRequestToVisionFile> EmailRequestToVisionFiles { get; set; }
    public virtual DbSet<VmDataMapExclusionToDeduction> ExclusionToDeductions { get; set; }
    public virtual DbSet<VmDataMapExclusionToDeductionExpanded> ExclusionToDeductionExpandeds { get; set; }
    public virtual DbSet<VmDataMapExclusionToRejectionExpanded> ExclusionToRejectionExpandeds { get; set; }
    public virtual DbSet<VmDataMapPaymentStatus> PaymentStatuses { get; set; }
    public virtual DbSet<VmDataMapPolicyCoveragePackageToProductCode> PolicyCoveragePackageToProductCodes { get; set; }
    public virtual DbSet<VmDataMapPolicyVersionToProductCode> PolicyVersionToProductCodes { get; set; }
    public virtual DbSet<VmDataMapProductPricingPriceEngineToVisionRatingMap> ProductPricingPriceEngineToVisionRatingMaps { get; set; }
    public virtual DbSet<VmDataMapProductVersionToProductCode> ProductVersionToProductCodes { get; set; }
    public virtual DbSet<VmDataMapTrudatPriceEngineVersionToVisionRatingMap> TrudatPriceEngineVersionToVisionRatingMaps { get; set; }
    public virtual DbSet<VmDataMapZuoraAccount> ZuoraAccounts { get; set; }
    public virtual DbSet<VmDataMapZuoraAccountMetadatum> ZuoraAccountMetadata { get; set; }

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

        modelBuilder.Entity<VmDataMapAdditionalBenefitToPolicySection>(entity =>
        {
            entity.HasKey(e => e.AdditionalBenefitId)
                .HasName("PK_exclusion_Deduction");

            entity.ToTable("AdditionalBenefitToPolicySection", "DataMap");

            entity.Property(e => e.AdditionalBenefitId).ValueGeneratedNever();

            entity.Property(e => e.Description).HasMaxLength(512);
        });

        modelBuilder.Entity<VmDataMapCancelReasonMap>(entity =>
        {
            entity.HasKey(e => new { e.TrudatCancelReasonId, e.TrudatCountryId })
                .HasName("pk_dataMapCancelReasonMap");

            entity.ToTable("CancelReasonMap", "DataMap");

            entity.Property(e => e.PolicyLifecycleBrandCode)
                .IsRequired()
                .HasMaxLength(10);

            entity.Property(e => e.PolicyLifecyclePolicyCancellationReasonsName)
                .IsRequired()
                .HasMaxLength(200);

            entity.Property(e => e.TrudatCancelReasonName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VmDataMapConditionAilmentLocationMap>(entity =>
        {
            entity.HasKey(e => new { e.ConditionId, e.LocationId })
                .HasName("PK_conditionlocationid");

            entity.ToTable("ConditionAilmentLocationMap", "DataMap");

            entity.Property(e => e.ConditionName)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.FirstCause)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.VenOmCode)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VmDataMapConditionAilmentMap>(entity =>
        {
            entity.HasKey(e => e.ConditionId)
                .HasName("PK_conditionid");

            entity.ToTable("ConditionAilmentMap", "DataMap");

            entity.Property(e => e.ConditionId).ValueGeneratedNever();

            entity.Property(e => e.ConditionName)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.FirstCause)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.VenOmCode)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VmDataMapContentItemToVisionFile>(entity =>
        {
            entity.ToTable("ContentItemToVisionFile", "DataMap");

            entity.HasIndex(e => e.ContentItemId, "IX_ContentItemToVisionFile_ContentItemId");

            entity.Property(e => e.FileName)
                .IsRequired()
                .HasMaxLength(255);
        });

        modelBuilder.Entity<VmDataMapDmsToVisionFile>(entity =>
        {
            entity.ToTable("DmsToVisionFile", "DataMap");

            entity.HasIndex(e => e.DmsDocumentId, "IX_DmsToVisionFile_DmsDocumentId");

            entity.HasIndex(e => e.FileName, "IX_DmsToVisionFile_FileName");

            entity.Property(e => e.DmsDocumentId)
                .IsRequired()
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.FileName)
                .IsRequired()
                .HasMaxLength(255);
        });

        modelBuilder.Entity<VmDataMapEmailRequestToVisionFile>(entity =>
        {
            entity.ToTable("EmailRequestToVisionFile", "DataMap");

            entity.HasIndex(e => e.EmailRequestId, "IX_EmailRequestToVisionFile_EmailRequestId");

            entity.Property(e => e.FileName)
                .IsRequired()
                .HasMaxLength(255);
        });

        modelBuilder.Entity<VmDataMapExclusionToDeduction>(entity =>
        {
            entity.ToTable("ExclusionToDeduction", "DataMap");
        });

        modelBuilder.Entity<VmDataMapExclusionToDeductionExpanded>(entity =>
        {
            entity.ToTable("ExclusionToDeductionExpanded", "DataMap");

            entity.Property(e => e.Description).HasMaxLength(2000);

            entity.Property(e => e.DescriptionLong).HasMaxLength(2000);

            entity.Property(e => e.ProductCode).HasMaxLength(50);

            entity.Property(e => e.ProductName).HasMaxLength(512);
        });

        modelBuilder.Entity<VmDataMapExclusionToRejectionExpanded>(entity =>
        {
            entity.ToTable("ExclusionToRejectionExpanded", "DataMap");

            entity.Property(e => e.Description).HasMaxLength(2000);

            entity.Property(e => e.DescriptionLong).HasMaxLength(2000);

            entity.Property(e => e.ProductCode).HasMaxLength(50);

            entity.Property(e => e.ProductName).HasMaxLength(512);
        });

        modelBuilder.Entity<VmDataMapPaymentStatus>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("PaymentStatus", "DataMap");
        });

        modelBuilder.Entity<VmDataMapPolicyCoveragePackageToProductCode>(entity =>
        {
            entity.HasKey(e => new { e.TrudatPolicyCoveragePackageId, e.CountryId })
                .HasName("pk_dataMapPolicyCoveragePackageToProductCode");

            entity.ToTable("PolicyCoveragePackageToProductCode", "DataMap");

            entity.Property(e => e.VisionProductCode)
                .IsRequired()
                .HasMaxLength(10);
        });

        modelBuilder.Entity<VmDataMapPolicyVersionToProductCode>(entity =>
        {
            entity.HasKey(e => new { e.TrudatPolicyVersionId, e.CountryId })
                .HasName("pk_dataMapPolicyVersionToProductCode");

            entity.ToTable("PolicyVersionToProductCode", "DataMap");

            entity.Property(e => e.VisionProductCode)
                .IsRequired()
                .HasMaxLength(10);
        });

        modelBuilder.Entity<VmDataMapProductPricingPriceEngineToVisionRatingMap>(entity =>
        {
            entity.HasKey(e => e.ProductPricingPriceEngineId)
                .HasName("pk_productPricingPriceEngineToVisionRatingMap");

            entity.ToTable("ProductPricingPriceEngineToVisionRatingMap", "DataMap");

            entity.Property(e => e.ProductPricingPriceEngineId).ValueGeneratedNever();

            entity.Property(e => e.ProductPricingPriceEngineName)
                .IsRequired()
                .HasMaxLength(400);

            entity.Property(e => e.VisionRatingName)
                .IsRequired()
                .HasMaxLength(400);
        });

        modelBuilder.Entity<VmDataMapProductVersionToProductCode>(entity =>
        {
            entity.HasKey(e => new { e.ProductId, e.ProductVersionNumber, e.CountryId })
                .HasName("pk_dataMapProductVersionToProductCode");

            entity.ToTable("ProductVersionToProductCode", "DataMap");

            entity.Property(e => e.ProductVersionNumber).HasMaxLength(100);

            entity.Property(e => e.VisionProductCode)
                .IsRequired()
                .HasMaxLength(10);
        });

        modelBuilder.Entity<VmDataMapTrudatPriceEngineVersionToVisionRatingMap>(entity =>
        {
            entity.HasKey(e => e.TrudatPriceEngineVersionId)
                .HasName("pk_trudatPriceEngineVersionToVisionRatingMap");

            entity.ToTable("TrudatPriceEngineVersionToVisionRatingMap", "DataMap");

            entity.Property(e => e.TrudatPriceEngineVersionId).ValueGeneratedNever();

            entity.Property(e => e.TrudatPriceEngineVersionName)
                .IsRequired()
                .HasMaxLength(400);

            entity.Property(e => e.VisionRatingName)
                .IsRequired()
                .HasMaxLength(400);
        });

        modelBuilder.Entity<VmDataMapZuoraAccount>(entity =>
        {
            entity.HasKey(e => e.AccountId)
                .HasName("pk_datamapZuoraAccount");

            entity.ToTable("ZuoraAccount", "DataMap");

            entity.Property(e => e.AccountId).ValueGeneratedNever();
        });

        modelBuilder.Entity<VmDataMapZuoraAccountMetadatum>(entity =>
        {
            entity.ToTable("ZuoraAccountMetadata", "DataMap");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
using Microsoft.EntityFrameworkCore;
using Database.Trupanion.Entity.Product.Dbo;
using Utilities.ConnectionStringManager.Base;
using Utilities.Constants.Enum;

namespace Database.Trupanion.Context;

public partial class ProductDboContext : DbContext
{
    public ProductDboContext()
    {
    }

    public ProductDboContext(DbContextOptions<ProductDboContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ProductDboApproval> Approvals { get; set; }
    public virtual DbSet<ProductDboApprovalForm> ApprovalForms { get; set; }
    public virtual DbSet<ProductDboApprovalStatus> ApprovalStatuses { get; set; }
    public virtual DbSet<ProductDboBrand> Brands { get; set; }
    public virtual DbSet<ProductDboBrandCountry> BrandCountries { get; set; }
    public virtual DbSet<ProductDboCharacteristic> Characteristics { get; set; }
    public virtual DbSet<ProductDboCharacteristicSubjectType> CharacteristicSubjectTypes { get; set; }
    public virtual DbSet<ProductDboCharacteristicToProductFactorInstanceMap> CharacteristicToProductFactorInstanceMaps { get; set; }
    public virtual DbSet<ProductDboCharacteristicToProductVersionMap> CharacteristicToProductVersionMaps { get; set; }
    public virtual DbSet<ProductDboCharacteristicType> CharacteristicTypes { get; set; }
    public virtual DbSet<ProductDboCharity> Charities { get; set; }
    public virtual DbSet<ProductDboCoinsuranceToProductFactorInstanceMap> CoinsuranceToProductFactorInstanceMaps { get; set; }
    public virtual DbSet<ProductDboCondition> Conditions { get; set; }
    public virtual DbSet<ProductDboConditionEffect> ConditionEffects { get; set; }
    public virtual DbSet<ProductDboConditionOperator> ConditionOperators { get; set; }
    public virtual DbSet<ProductDboConditionProductFactor> ConditionProductFactors { get; set; }
    public virtual DbSet<ProductDboConditionProductFactorInstance> ConditionProductFactorInstances { get; set; }
    public virtual DbSet<ProductDboCountryToCountryProductFactorInstanceMap> CountryToCountryProductFactorInstanceMaps { get; set; }
    public virtual DbSet<ProductDboCoverage> Coverages { get; set; }
    public virtual DbSet<ProductDboCoverageEffect> CoverageEffects { get; set; }
    public virtual DbSet<ProductDboCoverageText> CoverageTexts { get; set; }
    public virtual DbSet<ProductDboCoverageWaitingPeriod> CoverageWaitingPeriods { get; set; }
    public virtual DbSet<ProductDboDeductibleToProductFactorInstanceMap> DeductibleToProductFactorInstanceMaps { get; set; }
    public virtual DbSet<ProductDboDisclosure> Disclosures { get; set; }
    public virtual DbSet<ProductDboDurationType> DurationTypes { get; set; }
    public virtual DbSet<ProductDboEndorsement> Endorsements { get; set; }
    public virtual DbSet<ProductDboEndorsementCondition> EndorsementConditions { get; set; }
    public virtual DbSet<ProductDboEndorsementForm> EndorsementForms { get; set; }
    public virtual DbSet<ProductDboEndorsementPlan> EndorsementPlans { get; set; }
    public virtual DbSet<ProductDboEndorsementPlanForm> EndorsementPlanForms { get; set; }
    public virtual DbSet<ProductDboEventType> EventTypes { get; set; }
    public virtual DbSet<ProductDboFeeTrigger> FeeTriggers { get; set; }
    public virtual DbSet<ProductDboFeeType> FeeTypes { get; set; }
    public virtual DbSet<ProductDboForm> Forms { get; set; }
    public virtual DbSet<ProductDboFormCondition> FormConditions { get; set; }
    public virtual DbSet<ProductDboFormDeliveryMethod> FormDeliveryMethods { get; set; }
    public virtual DbSet<ProductDboFormDeliveryTrigger> FormDeliveryTriggers { get; set; }
    public virtual DbSet<ProductDboFormLanguage> FormLanguages { get; set; }
    public virtual DbSet<ProductDboFormTemplate> FormTemplates { get; set; }
    public virtual DbSet<ProductDboFormType> FormTypes { get; set; }
    public virtual DbSet<ProductDboOrganizationType> OrganizationTypes { get; set; }
    public virtual DbSet<ProductDboPlan> Plans { get; set; }
    public virtual DbSet<ProductDboPlanCondition> PlanConditions { get; set; }
    public virtual DbSet<ProductDboPlanCoverage> PlanCoverages { get; set; }
    public virtual DbSet<ProductDboPlanDisclosure> PlanDisclosures { get; set; }
    public virtual DbSet<ProductDboPlanFee> PlanFees { get; set; }
    public virtual DbSet<ProductDboPlanRule> PlanRules { get; set; }
    public virtual DbSet<ProductDboPlanTransition> PlanTransitions { get; set; }
    public virtual DbSet<ProductDboPostalCodeToGeoRegionProductFactorInstanceMap> PostalCodeToGeoRegionProductFactorInstanceMaps { get; set; }
    public virtual DbSet<ProductDboPremiumCalculation> PremiumCalculations { get; set; }
    public virtual DbSet<ProductDboPremiumCalculationFailure> PremiumCalculationFailures { get; set; }
    public virtual DbSet<ProductDboProduct> Products { get; set; }
    public virtual DbSet<ProductDboProductCertificateIssuingOrganizationType> ProductCertificateIssuingOrganizationTypes { get; set; }
    public virtual DbSet<ProductDboProductFactor> ProductFactors { get; set; }
    public virtual DbSet<ProductDboProductFactorInstance> ProductFactorInstances { get; set; }
    public virtual DbSet<ProductDboProductVersion> ProductVersions { get; set; }
    public virtual DbSet<ProductDboProductVersionProductFactor> ProductVersionProductFactors { get; set; }
    public virtual DbSet<ProductDboRegulatoryAgency> RegulatoryAgencies { get; set; }
    public virtual DbSet<ProductDboRegulatoryAgencyCultureSpecific> RegulatoryAgencyCultureSpecifics { get; set; }
    public virtual DbSet<ProductDboRegulatoryAgencyState> RegulatoryAgencyStates { get; set; }
    public virtual DbSet<ProductDboRelatedCoverage> RelatedCoverages { get; set; }
    public virtual DbSet<ProductDboRelatedCoverageType> RelatedCoverageTypes { get; set; }
    public virtual DbSet<ProductDboRule> Rules { get; set; }
    public virtual DbSet<ProductDboStateToStateProductFactorInstanceMap> StateToStateProductFactorInstanceMaps { get; set; }
    public virtual DbSet<ProductDboUnderwriter> Underwriters { get; set; }
    public virtual DbSet<ProductDboWaitingPeriod> WaitingPeriods { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(ConnectionString.TrupanionConnectionString(SqlDatabase.product), options => options.EnableRetryOnFailure().CommandTimeout(60));
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<ProductDboApproval>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dboapproval")
                .IsClustered(false);

            entity.ToTable("Approval");

            entity.HasIndex(e => e.ApprovalStatusId, "ix_dboapproval_approvalstatusid");

            entity.HasIndex(e => new { e.NewBusinessEffectiveDate, e.NewBusinessExpirationDate, e.ApprovalStatusId }, "ix_dboapproval_nbeff_nbexp_astsid");

            entity.HasIndex(e => e.RegulatoryAgencyId, "ix_dboapproval_regulatoryagencyid");

            entity.HasIndex(e => e.Name, "uix_dboapproval_name")
                .IsUnique()
                .HasFilter("([Name] IS NOT NULL)");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.BrandId).HasDefaultValueSql("('4B3D78B8-1D1A-4C38-9C7D-5BA3CCDE8A7A')");

            entity.Property(e => e.ConfigurationHash)
                .HasMaxLength(64)
                .IsUnicode(false);

            entity.Property(e => e.Name).HasMaxLength(100);

            entity.HasOne(d => d.ApprovalStatus)
                .WithMany(p => p.Approvals)
                .HasForeignKey(d => d.ApprovalStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dboapproval_approvalstatus");

            entity.HasOne(d => d.Brand)
                .WithMany(p => p.Approvals)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("fk_dboapproval_brand");

            entity.HasOne(d => d.RegulatoryAgency)
                .WithMany(p => p.Approvals)
                .HasForeignKey(d => d.RegulatoryAgencyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dboapproval_regulatoryagency");
        });

        modelBuilder.Entity<ProductDboApprovalForm>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dboapprovalform")
                .IsClustered(false);

            entity.ToTable("ApprovalForm");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Approval)
                .WithMany(p => p.ApprovalForms)
                .HasForeignKey(d => d.ApprovalId)
                .HasConstraintName("fk_dboapprovalform_dboapproval");

            entity.HasOne(d => d.Form)
                .WithMany(p => p.ApprovalForms)
                .HasForeignKey(d => d.FormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dboapprovalform_dboform");

            entity.HasOne(d => d.Template)
                .WithMany(p => p.InverseTemplate)
                .HasForeignKey(d => d.TemplateId)
                .HasConstraintName("fk_dboapprovalform_dbotemplate");
        });

        modelBuilder.Entity<ProductDboApprovalStatus>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dboapprovalstatus")
                .IsClustered(false);

            entity.ToTable("ApprovalStatus");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<ProductDboBrand>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dbobrand_id")
                .IsClustered(false);

            entity.ToTable("Brand");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.DefaultLanguageCode)
                .IsRequired()
                .HasMaxLength(8);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<ProductDboBrandCountry>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dbobrandcountry_id")
                .IsClustered(false);

            entity.ToTable("BrandCountry");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.IsoAlpha3CountryCode)
                .IsRequired()
                .HasMaxLength(3)
                .IsFixedLength(true);

            entity.HasOne(d => d.Brand)
                .WithMany(p => p.BrandCountries)
                .HasForeignKey(d => d.BrandId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dbobrandcountry_brand");
        });

        modelBuilder.Entity<ProductDboCharacteristic>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dbocharacteristic_id")
                .IsClustered(false);

            entity.ToTable("Characteristic");

            entity.HasIndex(e => e.CharacteristicTypeId, "ix_dbocharacteristic_Id_name");

            entity.HasIndex(e => new { e.CharacteristicTypeId, e.IsoAlpha3CountryCode, e.PostalCode }, "ix_dbocharacteristic_ctid_ia3cc_pc");

            entity.HasIndex(e => new { e.CharacteristicTypeId, e.IsoAlpha3CountryCode, e.StateCode, e.PostalCode }, "ix_dbocharacteristic_ctid_ia3cc_sc_pc");

            entity.HasIndex(e => e.SortOrder, "ix_dbocharacteristic_sortorder");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.IsoAlpha3CountryCode)
                .HasMaxLength(3)
                .IsFixedLength(true);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.PostalCode).HasMaxLength(20);

            entity.Property(e => e.StateCode).HasMaxLength(3);

            entity.HasOne(d => d.CharacteristicType)
                .WithMany(p => p.Characteristics)
                .HasForeignKey(d => d.CharacteristicTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dbocharacteristic_characteristictype");
        });

        modelBuilder.Entity<ProductDboCharacteristicSubjectType>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dbocharacteristicsubjecttype_id")
                .IsClustered(false);

            entity.ToTable("CharacteristicSubjectType");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<ProductDboCharacteristicToProductFactorInstanceMap>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("CharacteristicToProductFactorInstanceMap");

            entity.HasIndex(e => e.CharacteristicId, "ix_dboCharacteristicToProductFactorInstanceMap_cid");

            entity.HasIndex(e => e.ProductFactorInstanceId, "ix_dboCharacteristicToProductFactorInstanceMap_pfiid");

            entity.HasIndex(e => e.ProductVersionId, "ix_dboCharacteristicToProductFactorInstanceMap_pvid");

            entity.HasIndex(e => new { e.CharacteristicId, e.ProductFactorInstanceId }, "ux_dboCharacteristicToProductFactorInstanceMap")
                .IsUnique()
                .HasFilter("([ProductVersionId] IS NULL)");

            entity.HasIndex(e => new { e.CharacteristicId, e.ProductFactorInstanceId, e.ProductVersionId }, "ux_dboCharacteristicToProductFactorInstanceToProductVersionMap")
                .IsUnique()
                .HasFilter("([ProductVersionId] IS NOT NULL)");

            entity.HasOne(d => d.Characteristic)
                .WithMany()
                .HasForeignKey(d => d.CharacteristicId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dbocharacteristictoproductfactormap_characteristic");

            entity.HasOne(d => d.ProductFactorInstance)
                .WithMany()
                .HasForeignKey(d => d.ProductFactorInstanceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dbocharacteristictoproductfactormap_productfactorinstance");

            entity.HasOne(d => d.ProductVersion)
                .WithMany()
                .HasForeignKey(d => d.ProductVersionId)
                .HasConstraintName("fk_dbocharacteristictoproductfactormap_productversionid");
        });

        modelBuilder.Entity<ProductDboCharacteristicToProductVersionMap>(entity =>
        {
            entity.HasKey(e => new { e.CharacteristicId, e.ProductVersionId })
                .HasName("pk_dbocharacteristictoproductversionmap")
                .IsClustered(false);

            entity.ToTable("CharacteristicToProductVersionMap");

            entity.HasIndex(e => e.ProductVersionId, "ix_dboCharacteristicToProductVersionMap");

            entity.HasOne(d => d.Characteristic)
                .WithMany(p => p.CharacteristicToProductVersionMaps)
                .HasForeignKey(d => d.CharacteristicId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dbocharacteristictoproductversionmap_characteristic");

            entity.HasOne(d => d.ProductVersion)
                .WithMany(p => p.CharacteristicToProductVersionMaps)
                .HasForeignKey(d => d.ProductVersionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dbocharacteristictoproductversionmap_productversion");
        });

        modelBuilder.Entity<ProductDboCharacteristicType>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dbocharacteristictype_id")
                .IsClustered(false);

            entity.ToTable("CharacteristicType");

            entity.HasIndex(e => new { e.Name, e.BrandId }, "uk_dbocharacteristictype_name_brandid")
                .IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.BrandId).HasDefaultValueSql("('4B3D78B8-1D1A-4C38-9C7D-5BA3CCDE8A7A')");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            entity.HasOne(d => d.Brand)
                .WithMany(p => p.CharacteristicTypes)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("fk_dbocharacteristictype_brand");

            entity.HasOne(d => d.SubjectType)
                .WithMany(p => p.CharacteristicTypes)
                .HasForeignKey(d => d.SubjectTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dbocharacteristictype_characteristicsubjecttype");
        });

        modelBuilder.Entity<ProductDboCharity>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dbocharity_id")
                .IsClustered(false);

            entity.ToTable("Charity");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.BrandId).HasDefaultValueSql("('4B3D78B8-1D1A-4C38-9C7D-5BA3CCDE8A7A')");

            entity.Property(e => e.IsoAlpha3CountryCode)
                .IsRequired()
                .HasMaxLength(3)
                .IsFixedLength(true);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            entity.HasOne(d => d.Brand)
                .WithMany(p => p.Charities)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("fk_dbocharity_brand");
        });

        modelBuilder.Entity<ProductDboCoinsuranceToProductFactorInstanceMap>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dbocoinsurancetoproductfactorinstancemap_id")
                .IsClustered(false);

            entity.ToTable("CoinsuranceToProductFactorInstanceMap");

            entity.HasIndex(e => e.Coinsurance, "ix_dboCoinsuranceToProductFactorInstanceMap_ded");

            entity.HasIndex(e => e.ProductFactorInstanceId, "ix_dboCoinsuranceToProductFactorInstanceMap_pfiid");

            entity.HasIndex(e => new { e.ProductFactorId, e.ProductFactorInstanceId, e.Coinsurance }, "uk_dbocoinsurancetoproductfactorinstancemap_pfid_pfiid_ddl")
                .IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Coinsurance).HasColumnType("smallmoney");

            entity.HasOne(d => d.ProductFactorInstance)
                .WithMany(p => p.CoinsuranceToProductFactorInstanceMaps)
                .HasForeignKey(d => d.ProductFactorInstanceId)
                .HasConstraintName("fk_dbocoinsurancetoproductfactorinstancemap_productfactorinstance");
        });

        modelBuilder.Entity<ProductDboCondition>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dbocondition_id")
                .IsClustered(false);

            entity.ToTable("Condition");

            entity.HasIndex(e => e.ConditionEffectId, "ix_dbocondition_conditioneffectid");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Description).IsRequired();

            entity.HasOne(d => d.ConditionEffect)
                .WithMany(p => p.Conditions)
                .HasForeignKey(d => d.ConditionEffectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dbocondition_conditioneffect");
        });

        modelBuilder.Entity<ProductDboConditionEffect>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dboconditioneffect_id")
                .IsClustered(false);

            entity.ToTable("ConditionEffect");

            entity.HasIndex(e => e.Name, "uk_dboconditioneffect_name")
                .IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<ProductDboConditionOperator>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dboconditionoperator_id")
                .IsClustered(false);

            entity.ToTable("ConditionOperator");

            entity.HasIndex(e => e.Name, "uk_dboconditionoperator_name")
                .IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<ProductDboConditionProductFactor>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dboconditionproductfactor_id")
                .IsClustered(false);

            entity.ToTable("ConditionProductFactor");

            entity.HasIndex(e => e.ConditionId, "ix_dboconditionproductfactor_conditionid");

            entity.HasIndex(e => e.ConditionOperatorId, "ix_dboconditionproductfactor_conditionoperatorid");

            entity.HasIndex(e => e.ProductFactorId, "ix_dboconditionproductfactor_productfactorid");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Condition)
                .WithMany(p => p.ConditionProductFactors)
                .HasForeignKey(d => d.ConditionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dboconditionproductfactor_condition");

            entity.HasOne(d => d.ConditionOperator)
                .WithMany(p => p.ConditionProductFactors)
                .HasForeignKey(d => d.ConditionOperatorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dboconditionproductfactor_conditionoeprator");

            entity.HasOne(d => d.ProductFactor)
                .WithMany(p => p.ConditionProductFactors)
                .HasForeignKey(d => d.ProductFactorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dboconditionproductfactor_productfactor");
        });

        modelBuilder.Entity<ProductDboConditionProductFactorInstance>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dboconditionproductfactorinstance_id")
                .IsClustered(false);

            entity.ToTable("ConditionProductFactorInstance");

            entity.HasIndex(e => e.ConditionProductFactorId, "ix_dboconditionproductfactorinstance_conditionproductfactorid");

            entity.HasIndex(e => e.ProductFactorInstanceId, "ix_dboconditionproductfactorinstance_productfactorinstanceid");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.ConditionProductFactor)
                .WithMany(p => p.ConditionProductFactorInstances)
                .HasForeignKey(d => d.ConditionProductFactorId)
                .HasConstraintName("fk_dboconditionproductfactorinstance_conditionproductfactor");

            entity.HasOne(d => d.ProductFactorInstance)
                .WithMany(p => p.ConditionProductFactorInstances)
                .HasForeignKey(d => d.ProductFactorInstanceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dboconditionproductfactorinstance_productfactorinstance");
        });

        modelBuilder.Entity<ProductDboCountryToCountryProductFactorInstanceMap>(entity =>
        {
            entity.HasKey(e => e.IsoAlpha3CountryCode)
                .HasName("pk_dbocountrytocountryproductfactorinstancemap");

            entity.ToTable("CountryToCountryProductFactorInstanceMap");

            entity.HasIndex(e => new { e.IsoAlpha3CountryCode, e.ProductFactorInstanceId }, "uk_dbocountrytocountryproductfactorinstancemap_ia3cc_pfii")
                .IsUnique();

            entity.Property(e => e.IsoAlpha3CountryCode)
                .HasMaxLength(3)
                .IsFixedLength(true);

            entity.HasOne(d => d.ProductFactorInstance)
                .WithMany(p => p.CountryToCountryProductFactorInstanceMaps)
                .HasForeignKey(d => d.ProductFactorInstanceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dbocountrytocountryproductfactorinstancemap_productfactorinstance");
        });

        modelBuilder.Entity<ProductDboCoverage>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dbocoverage")
                .IsClustered(false);

            entity.ToTable("Coverage");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Approval)
                .WithMany(p => p.Coverages)
                .HasForeignKey(d => d.ApprovalId)
                .HasConstraintName("fk_dbocoverage_dboapproval");

            entity.HasOne(d => d.CoverageEffect)
                .WithMany(p => p.Coverages)
                .HasForeignKey(d => d.CoverageEffectId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dbocoverage_coverageeffect");

            entity.HasOne(d => d.Endorsement)
                .WithMany(p => p.Coverages)
                .HasForeignKey(d => d.EndorsementId)
                .HasConstraintName("fk_dbocoverage_dboendorsement");

            entity.HasOne(d => d.Parent)
                .WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .HasConstraintName("fk_dbocoverage_dboparent");

            entity.HasOne(d => d.Template)
                .WithMany(p => p.InverseTemplate)
                .HasForeignKey(d => d.TemplateId)
                .HasConstraintName("fk_dbocoverage_dbotemplate");
        });

        modelBuilder.Entity<ProductDboCoverageEffect>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dbocoverageeffect")
                .IsClustered(false);

            entity.ToTable("CoverageEffect");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<ProductDboCoverageText>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dbocoveragetext")
                .IsClustered(false);

            entity.ToTable("CoverageText");

            entity.HasIndex(e => e.CoverageId, "ix_dboCoverageText_coverageId");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            entity.HasOne(d => d.Approval)
                .WithMany(p => p.CoverageTexts)
                .HasForeignKey(d => d.ApprovalId)
                .HasConstraintName("fk_dbocoveragetext_dboapproval");

            entity.HasOne(d => d.Coverage)
                .WithMany(p => p.CoverageTexts)
                .HasForeignKey(d => d.CoverageId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_dbocoveragetext_dbocoverage");

            entity.HasOne(d => d.FormLanguage)
                .WithMany(p => p.CoverageTexts)
                .HasForeignKey(d => d.FormLanguageId)
                .HasConstraintName("fk_dbocoveragetext_dboformlanguage");

            entity.HasOne(d => d.Template)
                .WithMany(p => p.InverseTemplate)
                .HasForeignKey(d => d.TemplateId)
                .HasConstraintName("fk_dbocoveragetext_dbotemplate");
        });

        modelBuilder.Entity<ProductDboCoverageWaitingPeriod>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dbocoveragewaitingperiod")
                .IsClustered(false);

            entity.ToTable("CoverageWaitingPeriod");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Approval)
                .WithMany(p => p.CoverageWaitingPeriods)
                .HasForeignKey(d => d.ApprovalId)
                .HasConstraintName("fk_dbocoveragewaitingperiod_dboapproval");

            entity.HasOne(d => d.Coverage)
                .WithMany(p => p.CoverageWaitingPeriods)
                .HasForeignKey(d => d.CoverageId)
                .HasConstraintName("fk_dbocoveragewaitingperiod_dbocoverage");

            entity.HasOne(d => d.Template)
                .WithMany(p => p.InverseTemplate)
                .HasForeignKey(d => d.TemplateId)
                .HasConstraintName("fk_dbocoveragewaitingperiod_dbotemplate");

            entity.HasOne(d => d.WaitingPeriod)
                .WithMany(p => p.CoverageWaitingPeriods)
                .HasForeignKey(d => d.WaitingPeriodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dbocoveragewaitingperiod_dbowaitingperiod");
        });

        modelBuilder.Entity<ProductDboDeductibleToProductFactorInstanceMap>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dbodeductibletoproductfactorinstancemap_id")
                .IsClustered(false);

            entity.ToTable("DeductibleToProductFactorInstanceMap");

            entity.HasIndex(e => e.Deductible, "ix_dboDeductibleToProductFactorInstanceMap_ded");

            entity.HasIndex(e => e.ProductFactorInstanceId, "ix_dboDeductibleToProductFactorInstanceMap_pfiid");

            entity.HasIndex(e => new { e.ProductFactorId, e.ProductFactorInstanceId, e.Deductible }, "uk_dbodeductibletoproductfactorinstancemap_pfid_pfiid_ddl")
                .IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Deductible).HasColumnType("smallmoney");

            entity.HasOne(d => d.ProductFactorInstance)
                .WithMany(p => p.DeductibleToProductFactorInstanceMaps)
                .HasForeignKey(d => d.ProductFactorInstanceId)
                .HasConstraintName("fk_dbodeductibletoproductfactorinstancemap_productfactorinstance");
        });

        modelBuilder.Entity<ProductDboDisclosure>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_disclosure_id")
                .IsClustered(false);

            entity.ToTable("Disclosure");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Content).IsRequired();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(250);
        });

        modelBuilder.Entity<ProductDboDurationType>(entity =>
        {
            entity.ToTable("DurationType");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<ProductDboEndorsement>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dboendorsement_id")
                .IsClustered(false);

            entity.ToTable("Endorsement");

            entity.HasIndex(e => e.PriceFactorId, "ix_dboendorsement_pfid");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<ProductDboEndorsementCondition>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dboendorsementcondition_id")
                .IsClustered(false);

            entity.ToTable("EndorsementCondition");

            entity.HasIndex(e => e.ConditionId, "ix_dboendorsementcondition_conditionid");

            entity.HasIndex(e => e.EndorsementId, "ix_dboendorsementcondition_endorsementid");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Condition)
                .WithMany(p => p.EndorsementConditions)
                .HasForeignKey(d => d.ConditionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dboendorsementcondition_condition");

            entity.HasOne(d => d.Endorsement)
                .WithMany(p => p.EndorsementConditions)
                .HasForeignKey(d => d.EndorsementId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dboendorsementcondition_endorsement");
        });

        modelBuilder.Entity<ProductDboEndorsementForm>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dboendorsementform")
                .IsClustered(false);

            entity.ToTable("EndorsementForm");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Approval)
                .WithMany(p => p.EndorsementForms)
                .HasForeignKey(d => d.ApprovalId)
                .HasConstraintName("FK__Endorseme__Appro__28A2FA0E");

            entity.HasOne(d => d.Endorsement)
                .WithMany(p => p.EndorsementForms)
                .HasForeignKey(d => d.EndorsementId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dboendorsementform_dboendorsement");

            entity.HasOne(d => d.Form)
                .WithMany(p => p.EndorsementForms)
                .HasForeignKey(d => d.FormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dboendorsementform_dboform");

            entity.HasOne(d => d.Template)
                .WithMany(p => p.InverseTemplate)
                .HasForeignKey(d => d.TemplateId)
                .HasConstraintName("fk_dboendorsementform_dbotemplate");
        });

        modelBuilder.Entity<ProductDboEndorsementPlan>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dboendorsementplan")
                .IsClustered(false);

            entity.ToTable("EndorsementPlan");

            entity.HasIndex(e => e.ApprovalId, "ix_dboendorsementplan_approvalid");

            entity.HasIndex(e => e.CreatedOn, "ix_dboendorsementplan_createdon");

            entity.HasIndex(e => e.EndorsementId, "ix_dboendorsementplan_endorsementid");

            entity.HasIndex(e => e.ModifiedOn, "ix_dboendorsementplan_modifiedon");

            entity.HasIndex(e => e.PlanId, "ix_dboendorsementplan_planid");

            entity.HasIndex(e => e.TemplateId, "ix_dboendorsementplan_templateid");

            entity.HasIndex(e => new { e.ApprovalId, e.EndorsementId, e.PlanId }, "uk_endorsementplan_apid_enid_plid")
                .IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.CreatedOn).HasDefaultValueSql("(getdate())");

            entity.Property(e => e.ModifiedOn).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Approval)
                .WithMany(p => p.EndorsementPlans)
                .HasForeignKey(d => d.ApprovalId)
                .HasConstraintName("fk_dboendorsementplan_approval");

            entity.HasOne(d => d.Endorsement)
                .WithMany(p => p.EndorsementPlans)
                .HasForeignKey(d => d.EndorsementId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dboendorsementplan_endorsement");

            entity.HasOne(d => d.Plan)
                .WithMany(p => p.EndorsementPlans)
                .HasForeignKey(d => d.PlanId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dboendorsementplan_plan");

            entity.HasOne(d => d.Template)
                .WithMany(p => p.InverseTemplate)
                .HasForeignKey(d => d.TemplateId)
                .HasConstraintName("fk_dboendorsementplan_endorsementplan");
        });

        modelBuilder.Entity<ProductDboEndorsementPlanForm>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dboendorsementplanform")
                .IsClustered(false);

            entity.ToTable("EndorsementPlanForm");

            entity.HasIndex(e => e.EndorsementPlanId, "ix_dboEndorsementPlanForm_endorsementPlanId");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Approval)
                .WithMany(p => p.EndorsementPlanForms)
                .HasForeignKey(d => d.ApprovalId)
                .HasConstraintName("fk_dboendorsementplanform_dboapproval");

            entity.HasOne(d => d.EndorsementPlan)
                .WithMany(p => p.EndorsementPlanForms)
                .HasForeignKey(d => d.EndorsementPlanId)
                .HasConstraintName("fk_dboendorsementplanform_dboendorsementplan");

            entity.HasOne(d => d.Form)
                .WithMany(p => p.EndorsementPlanForms)
                .HasForeignKey(d => d.FormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dboendorsementplanform_dboform");

            entity.HasOne(d => d.Template)
                .WithMany(p => p.InverseTemplate)
                .HasForeignKey(d => d.TemplateId)
                .HasConstraintName("fk_dboendorsementplanform_dbotemplate");
        });

        modelBuilder.Entity<ProductDboEventType>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dboeventtype_id")
                .IsClustered(false);

            entity.ToTable("EventType");

            entity.HasIndex(e => e.Name, "uk_dboeventtype_name")
                .IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<ProductDboFeeTrigger>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dbofeetrigger_id")
                .IsClustered(false);

            entity.ToTable("FeeTrigger");

            entity.HasIndex(e => new { e.EventTypeId, e.FeeTypeId }, "uk_dbofeetrigger_etid_ftid")
                .IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.EventType)
                .WithMany(p => p.FeeTriggers)
                .HasForeignKey(d => d.EventTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dbofeetrigger_eventtype");

            entity.HasOne(d => d.FeeType)
                .WithMany(p => p.FeeTriggers)
                .HasForeignKey(d => d.FeeTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dbofeetrigger_feetype");
        });

        modelBuilder.Entity<ProductDboFeeType>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dbofeetype_id")
                .IsClustered(false);

            entity.ToTable("FeeType");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<ProductDboForm>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dboform")
                .IsClustered(false);

            entity.ToTable("Form");

            entity.HasIndex(e => e.ProductVersionId, "ix_dboForm_ProductVersionId");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.VersionNumber)
                .IsRequired()
                .HasMaxLength(100);

            entity.HasOne(d => d.Approval)
                .WithMany(p => p.Forms)
                .HasForeignKey(d => d.ApprovalId)
                .HasConstraintName("fk_dboform_dboapproval");

            entity.HasOne(d => d.FormType)
                .WithMany(p => p.Forms)
                .HasForeignKey(d => d.FormTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dboform_dboformtype");

            entity.HasOne(d => d.ProductVersion)
                .WithMany(p => p.Forms)
                .HasForeignKey(d => d.ProductVersionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dboform_dboproductversion");

            entity.HasOne(d => d.Template)
                .WithMany(p => p.InverseTemplate)
                .HasForeignKey(d => d.TemplateId)
                .HasConstraintName("fk_dboform_dbotemplate");
        });

        modelBuilder.Entity<ProductDboFormCondition>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dbofromcondition_id")
                .IsClustered(false);

            entity.ToTable("FormCondition");

            entity.HasIndex(e => e.ApprovalId, "ix_dboformcondition_approvalid");

            entity.HasIndex(e => e.FormId, "ix_dboformcondition_planid");

            entity.HasIndex(e => e.ConditionId, "ix_dbofromcondition_conditionid");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.CreatedOn).HasDefaultValueSql("(getdate())");

            entity.Property(e => e.ModifiedOn).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Approval)
                .WithMany(p => p.FormConditions)
                .HasForeignKey(d => d.ApprovalId)
                .HasConstraintName("fk_dbofromcondition_approval");

            entity.HasOne(d => d.Condition)
                .WithMany(p => p.FormConditions)
                .HasForeignKey(d => d.ConditionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dbofromcondition_condition");

            entity.HasOne(d => d.Form)
                .WithMany(p => p.FormConditions)
                .HasForeignKey(d => d.FormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dboformcondition_form");

            entity.HasOne(d => d.Template)
                .WithMany(p => p.InverseTemplate)
                .HasForeignKey(d => d.TemplateId)
                .HasConstraintName("fk_dboformcondition_dbotemplate");
        });

        modelBuilder.Entity<ProductDboFormDeliveryMethod>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_formdeliverymethod")
                .IsClustered(false);

            entity.ToTable("FormDeliveryMethod");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<ProductDboFormDeliveryTrigger>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dboformdeliverytrigger")
                .IsClustered(false);

            entity.ToTable("FormDeliveryTrigger");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Approval)
                .WithMany(p => p.FormDeliveryTriggers)
                .HasForeignKey(d => d.ApprovalId)
                .HasConstraintName("FK__FormDeliv__Appro__29971E47");

            entity.HasOne(d => d.EventType)
                .WithMany(p => p.FormDeliveryTriggers)
                .HasForeignKey(d => d.EventTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dboformdeliverytrigger_dboeventtype");

            entity.HasOne(d => d.FormDeliveryMethod)
                .WithMany(p => p.FormDeliveryTriggers)
                .HasForeignKey(d => d.FormDeliveryMethodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dboformdeliverytrigger_dboformdeliverymethod");

            entity.HasOne(d => d.Form)
                .WithMany(p => p.FormDeliveryTriggers)
                .HasForeignKey(d => d.FormId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dboformdeliverytrigger_dboform");

            entity.HasOne(d => d.Plan)
                .WithMany(p => p.FormDeliveryTriggers)
                .HasForeignKey(d => d.PlanId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dboformdeliverytrigger_dboplan");

            entity.HasOne(d => d.Template)
                .WithMany(p => p.InverseTemplate)
                .HasForeignKey(d => d.TemplateId)
                .HasConstraintName("fk_dboformdeliverytrigger_dbotemplate");
        });

        modelBuilder.Entity<ProductDboFormLanguage>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dboformlanguage")
                .IsClustered(false);

            entity.ToTable("FormLanguage");

            entity.HasIndex(e => e.FormId, "ix_dboFormLanguage_formId");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.DmsDocumentId)
                .IsRequired()
                .HasMaxLength(40);

            entity.Property(e => e.LanguageCode)
                .IsRequired()
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.VersionNumber).HasMaxLength(100);

            entity.HasOne(d => d.Approval)
                .WithMany(p => p.FormLanguages)
                .HasForeignKey(d => d.ApprovalId)
                .HasConstraintName("fk_dboformlanguage_dboapproval");

            entity.HasOne(d => d.Form)
                .WithMany(p => p.FormLanguages)
                .HasForeignKey(d => d.FormId)
                .HasConstraintName("fk_dboformlanguage_dboform");

            entity.HasOne(d => d.Template)
                .WithMany(p => p.InverseTemplate)
                .HasForeignKey(d => d.TemplateId)
                .HasConstraintName("fk_dboformlanguage_dbotemplate");
        });

        modelBuilder.Entity<ProductDboFormTemplate>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dboformtemplate")
                .IsClustered(false);

            entity.ToTable("FormTemplate");

            entity.HasIndex(e => e.FormId, "ix_dboFormTemplate_formId");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.LanguageCode)
                .IsRequired()
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.VersionNumber).HasMaxLength(100);

            entity.HasOne(d => d.Approval)
                .WithMany(p => p.FormTemplates)
                .HasForeignKey(d => d.ApprovalId)
                .HasConstraintName("fk_dboformtemplate_dboapproval");

            entity.HasOne(d => d.Form)
                .WithMany(p => p.FormTemplates)
                .HasForeignKey(d => d.FormId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_dboformtemplate_dboform");

            entity.HasOne(d => d.Template)
                .WithMany(p => p.InverseTemplate)
                .HasForeignKey(d => d.TemplateId)
                .HasConstraintName("fk_dboformtemplate_dbotemplate");
        });

        modelBuilder.Entity<ProductDboFormType>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_formtype")
                .IsClustered(false);

            entity.ToTable("FormType");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<ProductDboOrganizationType>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_organizationtype_id")
                .IsClustered(false);

            entity.ToTable("OrganizationType");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50);
        });

        modelBuilder.Entity<ProductDboPlan>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dboplan")
                .IsClustered(false);

            entity.ToTable("Plan");

            entity.HasIndex(e => e.ApprovalId, "ix_dboplan_approvalid");

            entity.HasIndex(e => e.CreatedOn, "ix_dboplan_createdon");

            entity.HasIndex(e => e.ModifiedOn, "ix_dboplan_modifiedon");

            entity.HasIndex(e => e.PriceEngineId, "ix_dboplan_priceengineid");

            entity.HasIndex(e => e.ProductVersionId, "ix_dboplan_productversionid");

            entity.HasIndex(e => e.TemplateId, "ix_dboplan_templateid");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.AccidentWaitingPeriodDays).HasDefaultValueSql("((30))");

            entity.Property(e => e.AdvertisedCoinsuranceValues).IsRequired();

            entity.Property(e => e.AdvertisedDeductibleValues).IsRequired();

            entity.Property(e => e.CreatedOn).HasDefaultValueSql("(getdate())");

            entity.Property(e => e.DisclosureTemplateDefinitionName).HasMaxLength(100);

            entity.Property(e => e.IllnessWaitingPeriodDays).HasDefaultValueSql("((5))");

            entity.Property(e => e.IsAutomaticallyRenewing)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.ModifiedOn).HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.PolicyTermDuration).HasDefaultValueSql("((1))");

            entity.Property(e => e.PolicyTermDurationTypeId).HasDefaultValueSql("('5D74646D-5961-4A15-BB44-91DC495A62A1')");

            entity.HasOne(d => d.Approval)
                .WithMany(p => p.Plans)
                .HasForeignKey(d => d.ApprovalId)
                .HasConstraintName("fk_dboplan_approval");

            entity.HasOne(d => d.PolicyTermDurationType)
                .WithMany(p => p.PlanPolicyTermDurationTypes)
                .HasForeignKey(d => d.PolicyTermDurationTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dboplan_policytermdurationtypeid");

            entity.HasOne(d => d.PriceTermDurationType)
                .WithMany(p => p.PlanPriceTermDurationTypes)
                .HasForeignKey(d => d.PriceTermDurationTypeId)
                .HasConstraintName("fk_dboplan_pricetermdurationtypeid");

            entity.HasOne(d => d.ProductVersion)
                .WithMany(p => p.Plans)
                .HasForeignKey(d => d.ProductVersionId)
                .HasConstraintName("fk_dboplan_productversionid");

            entity.HasOne(d => d.Template)
                .WithMany(p => p.InverseTemplate)
                .HasForeignKey(d => d.TemplateId)
                .HasConstraintName("fk_dboplan_plan");
        });

        modelBuilder.Entity<ProductDboPlanCondition>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dboplancondition_id")
                .IsClustered(false);

            entity.ToTable("PlanCondition");

            entity.HasIndex(e => e.ApprovalId, "ix_dboplancondition_approvalid");

            entity.HasIndex(e => e.ConditionId, "ix_dboplancondition_conditionid");

            entity.HasIndex(e => e.CreatedOn, "ix_dboplancondition_createdon");

            entity.HasIndex(e => e.ModifiedOn, "ix_dboplancondition_modifiedon");

            entity.HasIndex(e => e.PlanId, "ix_dboplancondition_planid");

            entity.HasIndex(e => e.TemplateId, "ix_dboplancondition_templateid");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.CreatedOn).HasDefaultValueSql("(getdate())");

            entity.Property(e => e.ModifiedOn).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Approval)
                .WithMany(p => p.PlanConditions)
                .HasForeignKey(d => d.ApprovalId)
                .HasConstraintName("fk_dboplancondition_approval");

            entity.HasOne(d => d.Condition)
                .WithMany(p => p.PlanConditions)
                .HasForeignKey(d => d.ConditionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dboplancondition_condition");

            entity.HasOne(d => d.Plan)
                .WithMany(p => p.PlanConditions)
                .HasForeignKey(d => d.PlanId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dboplancondition_plan");

            entity.HasOne(d => d.Template)
                .WithMany(p => p.InverseTemplate)
                .HasForeignKey(d => d.TemplateId)
                .HasConstraintName("fk_dboplancondition_plancondition");
        });

        modelBuilder.Entity<ProductDboPlanCoverage>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dboplancoverage")
                .IsClustered(false);

            entity.ToTable("PlanCoverage");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Approval)
                .WithMany(p => p.PlanCoverages)
                .HasForeignKey(d => d.ApprovalId)
                .HasConstraintName("fk_dboplancoverage_dboapproval");

            entity.HasOne(d => d.Coverage)
                .WithMany(p => p.PlanCoverages)
                .HasForeignKey(d => d.CoverageId)
                .HasConstraintName("fk_dboplancoverage_dbocoverage");

            entity.HasOne(d => d.Plan)
                .WithMany(p => p.PlanCoverages)
                .HasForeignKey(d => d.PlanId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dboplancoverage_dboparent");

            entity.HasOne(d => d.Template)
                .WithMany(p => p.InverseTemplate)
                .HasForeignKey(d => d.TemplateId)
                .HasConstraintName("fk_dboplancoverage_dbotemplate");
        });

        modelBuilder.Entity<ProductDboPlanDisclosure>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_plandisclosure_id")
                .IsClustered(false);

            entity.ToTable("PlanDisclosure");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Disclosure)
                .WithMany(p => p.PlanDisclosures)
                .HasForeignKey(d => d.DisclosureId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_plandisclosure_disclosure");
        });

        modelBuilder.Entity<ProductDboPlanFee>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dboplanfee")
                .IsClustered(false);

            entity.ToTable("PlanFee");

            entity.HasIndex(e => e.ApprovalId, "ix_dboplanfee_approvalid");

            entity.HasIndex(e => e.CreatedOn, "ix_dboplanfee_createdon");

            entity.HasIndex(e => e.ModifiedOn, "ix_dboplanfee_modifiedon");

            entity.HasIndex(e => e.PlanId, "ix_dboplanfee_planid");

            entity.HasIndex(e => e.PriceEngineId, "ix_dboplanfee_priceengineid");

            entity.HasIndex(e => e.TemplateId, "ix_dboplanfee_templateid");

            entity.HasIndex(e => new { e.PlanId, e.FeeTypeId }, "uk_dboplanfee_pid_ftid")
                .IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.CreatedOn).HasDefaultValueSql("(getdate())");

            entity.Property(e => e.ModifiedOn).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Approval)
                .WithMany(p => p.PlanFees)
                .HasForeignKey(d => d.ApprovalId)
                .HasConstraintName("fk_dboplanfee_approval");

            entity.HasOne(d => d.FeeType)
                .WithMany(p => p.PlanFees)
                .HasForeignKey(d => d.FeeTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dboplanfee_feetype");

            entity.HasOne(d => d.Plan)
                .WithMany(p => p.PlanFees)
                .HasForeignKey(d => d.PlanId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dboplanfee_plan");

            entity.HasOne(d => d.Template)
                .WithMany(p => p.InverseTemplate)
                .HasForeignKey(d => d.TemplateId)
                .HasConstraintName("fk_dboplanfee_planfee");
        });

        modelBuilder.Entity<ProductDboPlanRule>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dboplanrule")
                .IsClustered(false);

            entity.ToTable("PlanRule");

            entity.HasIndex(e => e.PlanId, "ix_dboPlanRule_PlanId");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Approval)
                .WithMany(p => p.PlanRules)
                .HasForeignKey(d => d.ApprovalId)
                .HasConstraintName("fk_dboplanrule_approval");

            entity.HasOne(d => d.Plan)
                .WithMany(p => p.PlanRules)
                .HasForeignKey(d => d.PlanId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dboplanrule_plan");

            entity.HasOne(d => d.Rule)
                .WithMany(p => p.PlanRules)
                .HasForeignKey(d => d.RuleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dboplanrule_rule");

            entity.HasOne(d => d.Template)
                .WithMany(p => p.InverseTemplate)
                .HasForeignKey(d => d.TemplateId)
                .HasConstraintName("fk_dboplanrule_planrule");
        });

        modelBuilder.Entity<ProductDboPlanTransition>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dboplantransition")
                .IsClustered(false);

            entity.ToTable("PlanTransition");

            entity.HasIndex(e => e.ApprovalId, "ix_dboplantransition_approvalid");

            entity.HasIndex(e => e.CreatedOn, "ix_dboplantransition_createdon");

            entity.HasIndex(e => e.FromPlanId, "ix_dboplantransition_fromplanid");

            entity.HasIndex(e => e.ModifiedOn, "ix_dboplantransition_modifiedon");

            entity.HasIndex(e => e.TemplateId, "ix_dboplantransition_templateid");

            entity.HasIndex(e => e.ToPlanId, "ix_dboplantransition_toplanid");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.CreatedOn).HasDefaultValueSql("(getdate())");

            entity.Property(e => e.ModifiedOn).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Approval)
                .WithMany(p => p.PlanTransitions)
                .HasForeignKey(d => d.ApprovalId)
                .HasConstraintName("fk_dboplantransition_approval");

            entity.HasOne(d => d.FromPlan)
                .WithMany(p => p.PlanTransitionFromPlans)
                .HasForeignKey(d => d.FromPlanId)
                .HasConstraintName("fk_dboplantransition_fromplan");

            entity.HasOne(d => d.Template)
                .WithMany(p => p.InverseTemplate)
                .HasForeignKey(d => d.TemplateId)
                .HasConstraintName("fk_dboplantransition_plantransition");

            entity.HasOne(d => d.ToPlan)
                .WithMany(p => p.PlanTransitionToPlans)
                .HasForeignKey(d => d.ToPlanId)
                .HasConstraintName("fk_dboplantransition_toplan");
        });

        modelBuilder.Entity<ProductDboPostalCodeToGeoRegionProductFactorInstanceMap>(entity =>
        {
            entity.HasKey(e => new { e.IsoAlpha3CountryCode, e.PostalCode, e.ProductFactorInstanceId })
                .HasName("pk_dbopostalcodegeoregionproductfactorinstancemap");

            entity.ToTable("PostalCodeToGeoRegionProductFactorInstanceMap");

            entity.Property(e => e.IsoAlpha3CountryCode)
                .HasMaxLength(3)
                .IsFixedLength(true);

            entity.Property(e => e.PostalCode).HasMaxLength(20);

            entity.HasOne(d => d.ProductFactorInstance)
                .WithMany(p => p.PostalCodeToGeoRegionProductFactorInstanceMaps)
                .HasForeignKey(d => d.ProductFactorInstanceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dbopostalcodegeoregionproductfactorinstancemap_productfactorinstance");
        });

        modelBuilder.Entity<ProductDboPremiumCalculation>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dbopremiumcalculation_id")
                .IsClustered(false);

            entity.ToTable("PremiumCalculation");

            entity.HasIndex(e => e.CreatedOn, "ix_dbopremiumcalculation_createdon");

            entity.HasIndex(e => e.Id, "ix_dbopremiumcalculation_id");

            entity.HasIndex(e => e.PriceEngineId, "ix_dbopremiumcalculation_priceengineid");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Characteristics).IsRequired();

            entity.Property(e => e.CoinsurancePercent).HasColumnType("decimal(19, 5)");

            entity.Property(e => e.CreatedOn).HasDefaultValueSql("(sysutcdatetime())");

            entity.Property(e => e.DeductibleAmount).HasColumnType("decimal(19, 5)");

            entity.Property(e => e.IsoAlpha3CountryCode)
                .IsRequired()
                .HasMaxLength(3)
                .IsFixedLength(true);

            entity.Property(e => e.Log).IsRequired();

            entity.Property(e => e.PostalCode)
                .IsRequired()
                .HasMaxLength(20);

            entity.Property(e => e.SelectedEndorsements).IsRequired();

            entity.Property(e => e.StateCode)
                .IsRequired()
                .HasMaxLength(3);

            entity.Property(e => e.Value).HasColumnType("decimal(19, 5)");
        });

        modelBuilder.Entity<ProductDboPremiumCalculationFailure>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dbopremiumcalculationfailure_id")
                .IsClustered(false);

            entity.ToTable("PremiumCalculationFailure");

            entity.HasIndex(e => e.CreatedOn, "ix_dbopremiumcalculationfailure_createdon");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Characteristics).IsRequired();

            entity.Property(e => e.CoinsurancePercent).HasColumnType("decimal(19, 2)");

            entity.Property(e => e.CreatedOn).HasDefaultValueSql("(sysutcdatetime())");

            entity.Property(e => e.DeductibleAmount).HasColumnType("decimal(19, 2)");

            entity.Property(e => e.IsoAlpha3CountryCode)
                .IsRequired()
                .HasMaxLength(3)
                .IsFixedLength(true);

            entity.Property(e => e.Log).IsRequired();

            entity.Property(e => e.PostalCode)
                .IsRequired()
                .HasMaxLength(20);

            entity.Property(e => e.ProductFactorInstance).IsRequired();

            entity.Property(e => e.SelectedEndorsements).IsRequired();

            entity.Property(e => e.StateCode)
                .IsRequired()
                .HasMaxLength(3);

            entity.Property(e => e.Value).HasColumnType("decimal(19, 3)");
        });

        modelBuilder.Entity<ProductDboProduct>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dboproduct_id")
                .IsClustered(false);

            entity.ToTable("Product");

            entity.HasIndex(e => e.BrandId, "ix_dboproduct_brandid");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            entity.HasOne(d => d.Brand)
                .WithMany(p => p.Products)
                .HasForeignKey(d => d.BrandId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dboproduct_brand");
        });

        modelBuilder.Entity<ProductDboProductCertificateIssuingOrganizationType>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_productcertificateissuingorganizationtype_id")
                .IsClustered(false);

            entity.ToTable("ProductCertificateIssuingOrganizationType");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.OrganizationType)
                .WithMany(p => p.ProductCertificateIssuingOrganizationTypes)
                .HasForeignKey(d => d.OrganizationTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_productcertificateissuingorganizationtype_organizationtype");

            entity.HasOne(d => d.Product)
                .WithMany(p => p.ProductCertificateIssuingOrganizationTypes)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_productcertificateissuingorganizationtype_product");
        });

        modelBuilder.Entity<ProductDboProductFactor>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dboproductfactor")
                .IsClustered(false);

            entity.ToTable("ProductFactor");

            entity.HasIndex(e => e.SystemName, "uk_dboproductfactor_systemname")
                .IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.DisplayName)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.SystemName)
                .IsRequired()
                .HasMaxLength(100);

            entity.HasOne(d => d.Parent)
                .WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .HasConstraintName("fk_dboproductfactor_productfactor");
        });

        modelBuilder.Entity<ProductDboProductFactorInstance>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dboproductfactorinstance")
                .IsClustered(false);

            entity.ToTable("ProductFactorInstance");

            entity.HasIndex(e => e.ParentId, "ix_dboproductfactorinstance_parentid");

            entity.HasIndex(e => e.ProductFactorId, "ix_dboproductfactorinstance_productfactorid");

            entity.HasIndex(e => new { e.InstanceName, e.ProductFactorId }, "uk_productfactorinstance_inme_pfid")
                .IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.InstanceName)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.Score).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.Parent)
                .WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .HasConstraintName("fk_dboproductfactorinstance_productfactorinstance");

            entity.HasOne(d => d.ProductFactor)
                .WithMany(p => p.ProductFactorInstances)
                .HasForeignKey(d => d.ProductFactorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dboproductfactorinstance_productfactor");
        });

        modelBuilder.Entity<ProductDboProductVersion>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dboproductversion")
                .IsClustered(false);

            entity.ToTable("ProductVersion");

            entity.HasIndex(e => e.ApprovalId, "ix_dboproductversion_approvalid");

            entity.HasIndex(e => e.CreatedOn, "ix_dboproductversion_createdon");

            entity.HasIndex(e => e.ModifiedOn, "ix_dboproductversion_modifiedon");

            entity.HasIndex(e => e.ProductId, "ix_dboproductversion_productid");

            entity.HasIndex(e => e.TemplateId, "ix_dboproductversion_templateid");

            entity.HasIndex(e => e.UnderwriterId, "ix_dboproductversion_underwriterid");

            entity.HasIndex(e => e.ApprovalId, "ux_dboproductversion_approvalid")
                .IsUnique()
                .HasFilter("([ApprovalId] IS NOT NULL)");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.CreatedOn).HasDefaultValueSql("(getdate())");

            entity.Property(e => e.ModifiedOn).HasDefaultValueSql("(getdate())");

            entity.Property(e => e.RateCapPercentage).HasColumnType("decimal(4, 2)");

            entity.Property(e => e.VersionName)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.VersionNumber)
                .IsRequired()
                .HasMaxLength(100);

            entity.HasOne(d => d.Approval)
                .WithOne(p => p.ProductVersion)
                .HasForeignKey<ProductDboProductVersion>(d => d.ApprovalId)
                .HasConstraintName("fk_dboproductversion_approval");

            entity.HasOne(d => d.Product)
                .WithMany(p => p.ProductVersions)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dboproductversion_product");

            entity.HasOne(d => d.Template)
                .WithMany(p => p.InverseTemplate)
                .HasForeignKey(d => d.TemplateId)
                .HasConstraintName("fk_dboproductversion_template");

            entity.HasOne(d => d.Underwriter)
                .WithMany(p => p.ProductVersions)
                .HasForeignKey(d => d.UnderwriterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dboproductversion_underwriter");
        });

        modelBuilder.Entity<ProductDboProductVersionProductFactor>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dboproductversionproductfactor")
                .IsClustered(false);

            entity.ToTable("ProductVersionProductFactor");

            entity.HasIndex(e => new { e.ProductVersionId, e.ProductFactorId }, "uk_dboProductVersionProductFactor_pvid_pfid")
                .IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.ProductFactor)
                .WithMany(p => p.ProductVersionProductFactors)
                .HasForeignKey(d => d.ProductFactorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dboproductversionproductfactor_productfactor");

            entity.HasOne(d => d.ProductVersion)
                .WithMany(p => p.ProductVersionProductFactors)
                .HasForeignKey(d => d.ProductVersionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dboproductversionproductfactor_productversion");
        });

        modelBuilder.Entity<ProductDboRegulatoryAgency>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dboregulatoryagency_id")
                .IsClustered(false);

            entity.ToTable("RegulatoryAgency");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(200);

            entity.Property(e => e.ShortName)
                .HasMaxLength(7)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ProductDboRegulatoryAgencyCultureSpecific>(entity =>
        {
            entity.ToTable("RegulatoryAgencyCultureSpecific");

            entity.HasIndex(e => new { e.MasterId, e.LanguageCode }, "uk_dboregulatoryagencyculturespecific_mid_lc")
                .IsUnique();

            entity.Property(e => e.LanguageCode)
                .IsRequired()
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(200);

            entity.Property(e => e.ShortName)
                .HasMaxLength(7)
                .IsUnicode(false);

            entity.HasOne(d => d.Master)
                .WithMany(p => p.RegulatoryAgencyCultureSpecifics)
                .HasForeignKey(d => d.MasterId)
                .HasConstraintName("FK__Regulator__Maste__2A8B4280");
        });

        modelBuilder.Entity<ProductDboRegulatoryAgencyState>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dboregulatoryagencystate_id")
                .IsClustered(false);

            entity.ToTable("RegulatoryAgencyState");

            entity.HasIndex(e => e.RegulatoryAgencyId, "ix_dboregulatoryagencystate_regulatoryagencyid");

            entity.HasIndex(e => new { e.IsoAlpha3CountryCode, e.StateCode }, "uk_dboregulatoryagencystate_ia3cc_ia2sc")
                .IsUnique();

            entity.HasIndex(e => new { e.RegulatoryAgencyId, e.IsoAlpha3CountryCode, e.StateCode }, "uk_dboregulatoryagencystate_raid_ia3cc_ia2sc")
                .IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.IsoAlpha3CountryCode)
                .IsRequired()
                .HasMaxLength(3)
                .IsFixedLength(true);

            entity.Property(e => e.StateCode)
                .IsRequired()
                .HasMaxLength(3);

            entity.HasOne(d => d.RegulatoryAgency)
                .WithMany(p => p.RegulatoryAgencyStates)
                .HasForeignKey(d => d.RegulatoryAgencyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dboregulatoryagencystate_regulatoryagency");
        });

        modelBuilder.Entity<ProductDboRelatedCoverage>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dborelatedcoverage")
                .IsClustered(false);

            entity.ToTable("RelatedCoverage");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Approval)
                .WithMany(p => p.RelatedCoverages)
                .HasForeignKey(d => d.ApprovalId)
                .HasConstraintName("fk_dborelatedcoverage_dboapproval");

            entity.HasOne(d => d.Coverage)
                .WithMany(p => p.RelatedCoverageCoverages)
                .HasForeignKey(d => d.CoverageId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dborelatedcoverage_dbocoverage1");

            entity.HasOne(d => d.RelatedCoverageNavigation)
                .WithMany(p => p.RelatedCoverageRelatedCoverageNavigations)
                .HasForeignKey(d => d.RelatedCoverageId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dborelatedcoverage_dbocoverage2");

            entity.HasOne(d => d.RelatedCoverageType)
                .WithMany(p => p.RelatedCoverages)
                .HasForeignKey(d => d.RelatedCoverageTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dborelatedcoverage_dborelatedcoveragetype");

            entity.HasOne(d => d.Template)
                .WithMany(p => p.InverseTemplate)
                .HasForeignKey(d => d.TemplateId)
                .HasConstraintName("fk_dborelatedcoverage_dbotemplate");
        });

        modelBuilder.Entity<ProductDboRelatedCoverageType>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dborelatedcoveragetype")
                .IsClustered(false);

            entity.ToTable("RelatedCoverageType");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<ProductDboRule>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dborule")
                .IsClustered(false);

            entity.ToTable("Rule");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Description).IsRequired();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<ProductDboStateToStateProductFactorInstanceMap>(entity =>
        {
            entity.HasKey(e => new { e.IsoAlpha3CountryCode, e.StateCode })
                .HasName("pk_dbostatetostateproductfactorinstancemap")
                .IsClustered(false);

            entity.ToTable("StateToStateProductFactorInstanceMap");

            entity.HasIndex(e => new { e.IsoAlpha3CountryCode, e.StateCode, e.ProductFactorInstanceId }, "uk_dbostatetostateproductfactorinstancemap_ia3cc_ia2sc_pfii")
                .IsUnique();

            entity.Property(e => e.IsoAlpha3CountryCode)
                .HasMaxLength(3)
                .IsFixedLength(true);

            entity.Property(e => e.StateCode).HasMaxLength(3);

            entity.HasOne(d => d.ProductFactorInstance)
                .WithMany(p => p.StateToStateProductFactorInstanceMaps)
                .HasForeignKey(d => d.ProductFactorInstanceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dbostatetostateproductfactorinstancemap_productfactorinstance");
        });

        modelBuilder.Entity<ProductDboUnderwriter>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dbounderwriter")
                .IsClustered(false);

            entity.ToTable("Underwriter");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.IsoAlpha3CountryCode)
                .IsRequired()
                .HasMaxLength(3)
                .IsFixedLength(true);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<ProductDboWaitingPeriod>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dbowaitingperiod")
                .IsClustered(false);

            entity.ToTable("WaitingPeriod");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Name).HasMaxLength(100);

            entity.HasOne(d => d.Approval)
                .WithMany(p => p.WaitingPeriods)
                .HasForeignKey(d => d.ApprovalId)
                .HasConstraintName("fk_dbowaitingperiod_dboapproval");

            entity.HasOne(d => d.Coverage)
                .WithMany(p => p.WaitingPeriods)
                .HasForeignKey(d => d.CoverageId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dbowaitingperiod_dbocoverage");

            entity.HasOne(d => d.Template)
                .WithMany(p => p.InverseTemplate)
                .HasForeignKey(d => d.TemplateId)
                .HasConstraintName("fk_dbowaitingperiod_dbotemplate");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
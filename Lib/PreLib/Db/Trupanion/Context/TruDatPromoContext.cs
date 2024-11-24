using Microsoft.EntityFrameworkCore;
using Database.Trupanion.Entity.TruDat.Promo;
using Utilities.ConnectionStringManager.Base;
using Utilities.Constants.Enum;

namespace Database.Trupanion.Context;

public partial class TruDatPromoContext : DbContext
{
    public TruDatPromoContext()
    {
    }

    public TruDatPromoContext(DbContextOptions<TruDatPromoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TruDatPromoBanner> Banners { get; set; }
    public virtual DbSet<TruDatPromoCampaign> Campaigns { get; set; }
    public virtual DbSet<TruDatPromoCampaignInstance> CampaignInstances { get; set; }
    public virtual DbSet<TruDatPromoCampaignInstanceAssociation> CampaignInstanceAssociations { get; set; }
    public virtual DbSet<TruDatPromoCampaignInstanceCategory> CampaignInstanceCategories { get; set; }
    public virtual DbSet<TruDatPromoCampaignInstanceConfiguration> CampaignInstanceConfigurations { get; set; }
    public virtual DbSet<TruDatPromoCampaignInstanceEffectDiscount> CampaignInstanceEffectDiscounts { get; set; }
    public virtual DbSet<TruDatPromoCampaignInstanceEffectTrial> CampaignInstanceEffectTrials { get; set; }
    public virtual DbSet<TruDatPromoCampaignInstanceEffectWp> CampaignInstanceEffectWps { get; set; }
    public virtual DbSet<TruDatPromoCampaignInstanceSummary> CampaignInstanceSummaries { get; set; }
    public virtual DbSet<TruDatPromoCampaignInstanceValidation> CampaignInstanceValidations { get; set; }
    public virtual DbSet<TruDatPromoCampaignInstanceValidationDatum> CampaignInstanceValidationData { get; set; }
    public virtual DbSet<TruDatPromoCampaignRequiredAssociation> CampaignRequiredAssociations { get; set; }
    public virtual DbSet<TruDatPromoCategory> Categories { get; set; }
    public virtual DbSet<TruDatPromoConfiguration> Configurations { get; set; }
    public virtual DbSet<TruDatPromoDiscountTarget> DiscountTargets { get; set; }
    public virtual DbSet<TruDatPromoDiscountType> DiscountTypes { get; set; }
    public virtual DbSet<TruDatPromoEffect> Effects { get; set; }
    public virtual DbSet<TruDatPromoTempflcert> Tempflcerts { get; set; }
    public virtual DbSet<TruDatPromoValidation> Validations { get; set; }
    public virtual DbSet<TruDatPromoValidationDatum> ValidationData { get; set; }
    public virtual DbSet<TruDatPromoValidationRequiredDatum> ValidationRequiredData { get; set; }
    public virtual DbSet<TruDatPromoWidget> Widgets { get; set; }

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

        modelBuilder.Entity<TruDatPromoBanner>(entity =>
        {
            entity.ToTable("Banner", "Promo");

            entity.Property(e => e.ImgAlt)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.ImgSrc)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.PageSection)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TruDatPromoCampaign>(entity =>
        {
            entity.ToTable("Campaign", "Promo");

            entity.HasIndex(e => e.Active, "ix_promocampaign_act");

            entity.HasIndex(e => e.AssociateId, "ix_promocampaign_aid");

            entity.HasIndex(e => new { e.AssociateId, e.Name }, "uk_promocampaign_assid_name")
                .IsUnique();

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.Description).IsUnicode(false);

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TruDatPromoCampaignInstance>(entity =>
        {
            entity.ToTable("CampaignInstance", "Promo");

            entity.HasIndex(e => e.CampaignId, "ix_promocampaigninstance_cid");

            entity.HasIndex(e => e.CampaignCode, "uk_promocampaigninstance_code")
                .IsUnique();

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.CampaignCode)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Campaign)
                .WithMany(p => p.CampaignInstances)
                .HasForeignKey(d => d.CampaignId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_promocampaign_promocampaigninstance");
        });

        modelBuilder.Entity<TruDatPromoCampaignInstanceAssociation>(entity =>
        {
            entity.ToTable("CampaignInstanceAssociation", "Promo");

            entity.HasIndex(e => e.CampaignInstanceId, "ix_promocampaigninstance_ciid");

            entity.HasIndex(e => new { e.CampaignInstanceId, e.EntityTypeId, e.EntityId }, "uk_promocampaigninstanceassociation_ciid_etid_eid")
                .IsUnique();

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.CampaignInstance)
                .WithMany(p => p.CampaignInstanceAssociations)
                .HasForeignKey(d => d.CampaignInstanceId)
                .HasConstraintName("fk_promocampaigninstance_promocampaigninstanceassociation");
        });

        modelBuilder.Entity<TruDatPromoCampaignInstanceCategory>(entity =>
        {
            entity.ToTable("CampaignInstanceCategory", "Promo");

            entity.HasIndex(e => new { e.CampaignInstanceId, e.CategoryId }, "uk_campaigninstancecategory_ciid")
                .IsUnique();

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.CampaignInstance)
                .WithMany(p => p.CampaignInstanceCategories)
                .HasForeignKey(d => d.CampaignInstanceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_promocampaigninstancecategory_campaigninstance");

            entity.HasOne(d => d.Category)
                .WithMany(p => p.CampaignInstanceCategories)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_promocampaigninstancecategory_category");
        });

        modelBuilder.Entity<TruDatPromoCampaignInstanceConfiguration>(entity =>
        {
            entity.ToTable("CampaignInstanceConfiguration", "Promo");

            entity.HasIndex(e => e.CampaignInstanceId, "ix_promocampaigninstanceconfiguration_cid");

            entity.HasIndex(e => new { e.ConfigId, e.ConfigInt }, "ix_promocampaigninstanceconfiguration_cid_cint");

            entity.HasIndex(e => e.ConfigId, "ix_promocampaigninstanceconfiguration_conid");

            entity.HasIndex(e => new { e.CampaignInstanceId, e.ConfigId }, "uk_promocampaigninstanceconfiguration_ciid_cid")
                .IsUnique();

            entity.Property(e => e.ConfigDate).HasColumnType("datetime");

            entity.Property(e => e.ConfigString).IsUnicode(false);

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.CampaignInstance)
                .WithMany(p => p.CampaignInstanceConfigurations)
                .HasForeignKey(d => d.CampaignInstanceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_promocampaign_promocampaigninstanceconfiguration");

            entity.HasOne(d => d.Config)
                .WithMany(p => p.CampaignInstanceConfigurations)
                .HasForeignKey(d => d.ConfigId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_promoconfiguration_promocampaigninstanceconfiguration");
        });

        modelBuilder.Entity<TruDatPromoCampaignInstanceEffectDiscount>(entity =>
        {
            entity.ToTable("CampaignInstanceEffectDiscount", "Promo");

            entity.HasIndex(e => new { e.CampaignInstanceId, e.DiscountTargetId }, "uk_promocampaigninstanceeffectdiscount_ciid_tar")
                .IsUnique();

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.CampaignInstance)
                .WithMany(p => p.CampaignInstanceEffectDiscounts)
                .HasForeignKey(d => d.CampaignInstanceId)
                .HasConstraintName("fk_promocampaigninstance_promocampaigninstanceeffectdiscount");

            entity.HasOne(d => d.DiscountTarget)
                .WithMany(p => p.CampaignInstanceEffectDiscounts)
                .HasForeignKey(d => d.DiscountTargetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_promodiscounttarget_promocampaigninstanceeffectdiscount");

            entity.HasOne(d => d.DiscountType)
                .WithMany(p => p.CampaignInstanceEffectDiscounts)
                .HasForeignKey(d => d.DiscountTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_promodiscounttype_promocampaigninstanceeffectdiscount");
        });

        modelBuilder.Entity<TruDatPromoCampaignInstanceEffectTrial>(entity =>
        {
            entity.ToTable("CampaignInstanceEffectTrial", "Promo");

            entity.HasIndex(e => e.CampaignInstanceId, "ix_promocampaigninstanceeffecttrial_cid");

            entity.HasIndex(e => e.CampaignInstanceId, "uk_campaigninstanceid_ciid")
                .IsUnique();

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.CampaignInstance)
                .WithOne(p => p.CampaignInstanceEffectTrial)
                .HasForeignKey<TruDatPromoCampaignInstanceEffectTrial>(d => d.CampaignInstanceId)
                .HasConstraintName("fk_promocampaigninstance_promocampaigninstanceeffecttrial");
        });

        modelBuilder.Entity<TruDatPromoCampaignInstanceEffectWp>(entity =>
        {
            entity.ToTable("CampaignInstanceEffectWP", "Promo");

            entity.HasIndex(e => e.CampaignInstanceId, "uk_promocampaigninstanceeffectwp_ciid")
                .IsUnique();

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.CampaignInstance)
                .WithOne(p => p.CampaignInstanceEffectWp)
                .HasForeignKey<TruDatPromoCampaignInstanceEffectWp>(d => d.CampaignInstanceId)
                .HasConstraintName("fk_promocampaigninstance_promocampaigninstanceeffectwp");
        });

        modelBuilder.Entity<TruDatPromoCampaignInstanceSummary>(entity =>
        {
            entity.HasKey(e => e.CampaignInstanceId)
                .HasName("pk_promocampaigninstancesummary_cid");

            entity.ToTable("CampaignInstanceSummary", "Promo");

            entity.Property(e => e.CampaignInstanceId).ValueGeneratedNever();

            entity.Property(e => e.CampaignCode)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CampaignName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Category)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PremiumDiscountPercent).HasColumnType("numeric(4, 2)");

            entity.Property(e => e.ProgramGeneral)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ProgramSpecific)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.RowChecksum)
                .HasMaxLength(8000)
                .HasComputedColumnSql("(hashbytes('md5',(((((((((((([ProgramGeneral]+[ProgramSpecific])+[CampaignName])+[CampaignCode])+CONVERT([varchar](1),[HasSetupFeeDiscount],(0)))+[SetupFeeDiscountAmount])+CONVERT([varchar](1),[HasPremiumDiscount],(0)))+CONVERT([varchar](10),[PremiumDiscountPercent],(0)))+CONVERT([varchar](1),[HasWaitingPeriodModification],(0)))+CONVERT([varchar](10),[WaitingPeriodAccident],(0)))+CONVERT([varchar](10),[WaitingPeriodIllness],(0)))+CONVERT([varchar](1),[HasTrialPeriod],(0)))+CONVERT([varchar](10),[TrialNumberOfDays],(0)))+isnull([Category],'')))", true);

            entity.Property(e => e.SetupFeeDiscountAmount)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatPromoCampaignInstanceValidation>(entity =>
        {
            entity.ToTable("CampaignInstanceValidation", "Promo");

            entity.HasIndex(e => e.ValidationId, "ix_promocampaigninstancevalidation_vid");

            entity.HasIndex(e => new { e.CampaignInstanceId, e.ValidationId }, "uk_promocampaigninstancevalidation_ciid_vid")
                .IsUnique();

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.CampaignInstance)
                .WithMany(p => p.CampaignInstanceValidations)
                .HasForeignKey(d => d.CampaignInstanceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_promocampaigninstance_promocampaigninstancevalidation");

            entity.HasOne(d => d.Validation)
                .WithMany(p => p.CampaignInstanceValidations)
                .HasForeignKey(d => d.ValidationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_promovalidation_promocampaigninstancevalidation");
        });

        modelBuilder.Entity<TruDatPromoCampaignInstanceValidationDatum>(entity =>
        {
            entity.ToTable("CampaignInstanceValidationData", "Promo");

            entity.HasIndex(e => new { e.ValidationId, e.ValidationDataId }, "ix_promocampaigninstancevalidationdata_vid_vdid");

            entity.HasIndex(e => new { e.CampaignInstanceId, e.ValidationId, e.ValidationDataId }, "uk_promocampaigninstancevalidationdata_ciid_vid_vdid")
                .IsUnique();

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.ValidationDate).HasColumnType("datetime");

            entity.Property(e => e.ValidationString).IsUnicode(false);

            entity.HasOne(d => d.CampaignInstance)
                .WithMany(p => p.CampaignInstanceValidationData)
                .HasForeignKey(d => d.CampaignInstanceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_promocampaigninstance_promocampaigninstancevalidationdata");

            entity.HasOne(d => d.ValidationData)
                .WithMany(p => p.CampaignInstanceValidationData)
                .HasForeignKey(d => d.ValidationDataId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_promovalidationdata_campaigninstancevalidationdata");

            entity.HasOne(d => d.Validation)
                .WithMany(p => p.CampaignInstanceValidationData)
                .HasForeignKey(d => d.ValidationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_promovalidation_promocampaigninstancevalidationdata");
        });

        modelBuilder.Entity<TruDatPromoCampaignRequiredAssociation>(entity =>
        {
            entity.ToTable("CampaignRequiredAssociation", "Promo");

            entity.HasIndex(e => new { e.CampaignId, e.EntityTypeId }, "uk_promocampaignrequiredassociation_ciid_etid")
                .IsUnique();

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Campaign)
                .WithMany(p => p.CampaignRequiredAssociations)
                .HasForeignKey(d => d.CampaignId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_promocampaign_promocampaignrequiredassociation");
        });

        modelBuilder.Entity<TruDatPromoCategory>(entity =>
        {
            entity.ToTable("Category", "Promo");

            entity.HasIndex(e => e.Name, "uk_promocategory_nme")
                .IsUnique();

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TruDatPromoConfiguration>(entity =>
        {
            entity.ToTable("Configuration", "Promo");

            entity.HasIndex(e => e.Name, "uk_promoconfiguration_nme")
                .IsUnique();

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatPromoDiscountTarget>(entity =>
        {
            entity.ToTable("DiscountTarget", "Promo");

            entity.HasIndex(e => e.Name, "uk_promodiscounttarget_nme")
                .IsUnique();

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TruDatPromoDiscountType>(entity =>
        {
            entity.ToTable("DiscountType", "Promo");

            entity.HasIndex(e => e.Name, "uk_promodiscounttype_nme")
                .IsUnique();

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TruDatPromoEffect>(entity =>
        {
            entity.ToTable("Effect", "Promo");

            entity.HasIndex(e => e.Name, "uk_promoeffect_nme")
                .IsUnique();

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TruDatPromoTempflcert>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("tempflcert", "Promo");

            entity.Property(e => e.NewCampaignCode)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatPromoValidation>(entity =>
        {
            entity.ToTable("Validation", "Promo");

            entity.HasIndex(e => e.Name, "uk_promovalidation_nme")
                .IsUnique();

            entity.Property(e => e.Description)
                .IsRequired()
                .IsUnicode(false);

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.IobjectValidationImplClass)
                .IsRequired()
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("IObjectValidationImplClass");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TruDatPromoValidationDatum>(entity =>
        {
            entity.ToTable("ValidationData", "Promo");

            entity.HasIndex(e => e.Name, "uk_promovalidationdata_nme")
                .IsUnique();

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatPromoValidationRequiredDatum>(entity =>
        {
            entity.ToTable("ValidationRequiredData", "Promo");

            entity.HasIndex(e => new { e.ValidationId, e.ValidationDataId }, "uk_promovalidationrequireddata_vid_vdid")
                .IsUnique();

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.ValidationData)
                .WithMany(p => p.ValidationRequiredData)
                .HasForeignKey(d => d.ValidationDataId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_promovalidationdata_promovalidationrequireddata");

            entity.HasOne(d => d.Validation)
                .WithMany(p => p.ValidationRequiredData)
                .HasForeignKey(d => d.ValidationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_promovalidation_promovalidationrequireddata");
        });

        modelBuilder.Entity<TruDatPromoWidget>(entity =>
        {
            entity.ToTable("Widget", "Promo");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.ObjectUrl)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.PageSection)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
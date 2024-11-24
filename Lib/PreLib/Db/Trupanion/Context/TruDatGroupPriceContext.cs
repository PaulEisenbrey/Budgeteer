using Microsoft.EntityFrameworkCore;
using Database.Trupanion.Entity.TruDat.GroupPrice;
using Utilities.ConnectionStringManager.Base;
using Utilities.Constants.Enum;

namespace Database.Trupanion.Context;

public partial class TruDatGroupPriceContext : DbContext
{
    public TruDatGroupPriceContext()
    {
    }

    public TruDatGroupPriceContext(DbContextOptions<TruDatGroupPriceContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TruDatGroupPriceAgeGroup> AgeGroups { get; set; }
    public virtual DbSet<TruDatGroupPriceAgeGroupAge> AgeGroupAges { get; set; }
    public virtual DbSet<TruDatGroupPriceAgeGroupConfiguration> AgeGroupConfigurations { get; set; }
    public virtual DbSet<TruDatGroupPriceAgeGroupFactor> AgeGroupFactors { get; set; }
    public virtual DbSet<TruDatGroupPriceEngineVersion> EngineVersions { get; set; }
    public virtual DbSet<TruDatGroupPriceEngineVersionAgeGroup> EngineVersionAgeGroups { get; set; }
    public virtual DbSet<TruDatGroupPriceEngineVersionConfiguration> EngineVersionConfigurations { get; set; }
    public virtual DbSet<TruDatGroupPriceEngineVersionModel> EngineVersionModels { get; set; }
    public virtual DbSet<TruDatGroupPriceEngineVersionModelState> EngineVersionModelStates { get; set; }
    public virtual DbSet<TruDatGroupPriceEngineVersionPremium> EngineVersionPremia { get; set; }
    public virtual DbSet<TruDatGroupPriceGroupBenefitsAccount> GroupBenefitsAccounts { get; set; }
    public virtual DbSet<TruDatGroupPricePolicyVersionImplementation> PolicyVersionImplementations { get; set; }
    public virtual DbSet<TruDatGroupPricePolicyVersionImplementationDeductible> PolicyVersionImplementationDeductibles { get; set; }
    public virtual DbSet<TruDatGroupPricePolicyVersionImplementationRider> PolicyVersionImplementationRiders { get; set; }
    public virtual DbSet<TruDatGroupPricePolicyVersionImplementationWorkingPet> PolicyVersionImplementationWorkingPets { get; set; }

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

        modelBuilder.Entity<TruDatGroupPriceAgeGroup>(entity =>
        {
            entity.ToTable("AgeGroup", "GroupPrice");

            entity.HasIndex(e => e.Name, "uk_grouppriceagegroup_name")
                .IsUnique();

            entity.HasIndex(e => e.UniqueId, "uk_grouppriceagegroup_uniqueid")
                .IsUnique();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(512)
                .IsUnicode(false);

            entity.Property(e => e.UniqueId).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<TruDatGroupPriceAgeGroupAge>(entity =>
        {
            entity.ToTable("AgeGroupAge", "GroupPrice");

            entity.HasIndex(e => e.AgeId, "ix_grouppriceagegroupage_ageId");

            entity.HasIndex(e => e.AgeGroupId, "ix_grouppriceagegroupage_agegroupid");

            entity.HasIndex(e => new { e.AgeGroupId, e.AgeId }, "uk_grouppriceagegroupage_grouppriceagegroupfactorid_ageid")
                .IsUnique();

            entity.HasOne(d => d.AgeGroup)
                .WithMany(p => p.AgeGroupAges)
                .HasForeignKey(d => d.AgeGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_grouppriceagegroupage_grouppriceagegroup_agegroupId");
        });

        modelBuilder.Entity<TruDatGroupPriceAgeGroupConfiguration>(entity =>
        {
            entity.ToTable("AgeGroupConfiguration", "GroupPrice");

            entity.HasIndex(e => e.Name, "uk_grouppriceagegroupconfiguration_name")
                .IsUnique();

            entity.HasIndex(e => e.UniqueId, "uk_grouppriceagegroupconfiguration_uniqueid")
                .IsUnique();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(512)
                .IsUnicode(false);

            entity.Property(e => e.UniqueId).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<TruDatGroupPriceAgeGroupFactor>(entity =>
        {
            entity.ToTable("AgeGroupFactor", "GroupPrice");

            entity.HasIndex(e => e.AgeGroupId, "ix_grouppriceagegroupfactor_grouppriceagegroupId");

            entity.HasIndex(e => e.GroupPriceAgeGroupConfigurationId, "ix_grouppriceagegroupfactor_grouppriceagegroupconfigurationId");

            entity.HasIndex(e => e.SpecieId, "ix_grouppriceagegroupfactor_specieid");

            entity.HasOne(d => d.AgeGroup)
                .WithMany(p => p.AgeGroupFactors)
                .HasForeignKey(d => d.AgeGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_grouppriceagegroupfactor_grouppriceagegroup_agegroupId");

            entity.HasOne(d => d.GroupPriceAgeGroupConfiguration)
                .WithMany(p => p.AgeGroupFactors)
                .HasForeignKey(d => d.GroupPriceAgeGroupConfigurationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_grouppriceagegroupfactor_grouppriceagegroupconfiguration_grouppriceagegroupconfigurationId");
        });

        modelBuilder.Entity<TruDatGroupPriceEngineVersion>(entity =>
        {
            entity.ToTable("EngineVersion", "GroupPrice");

            entity.HasIndex(e => e.EngineVersionConfigurationId, "ix_grouppriceengineversion_engineversionconfigurationid");

            entity.HasIndex(e => e.Name, "uk_grouppriceengineversion_name")
                .IsUnique();

            entity.HasIndex(e => e.UniqueId, "uk_grouppriceengineversion_uniqueid")
                .IsUnique();

            entity.Property(e => e.Comments)
                .HasMaxLength(1024)
                .IsUnicode(false);

            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(512)
                .IsUnicode(false);

            entity.Property(e => e.UniqueId).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.EngineVersionConfiguration)
                .WithMany(p => p.EngineVersions)
                .HasForeignKey(d => d.EngineVersionConfigurationId)
                .HasConstraintName("fk_grouppriceratecard_grouppriceengineversionconfiguration_engineversionconfigurationid");
        });

        modelBuilder.Entity<TruDatGroupPriceEngineVersionAgeGroup>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EngineVersionAgeGroup", "GroupPrice");

            entity.Property(e => e.AgeYearFrom).HasColumnType("numeric(4, 2)");

            entity.Property(e => e.AgeYearTo).HasColumnType("numeric(4, 2)");
        });

        modelBuilder.Entity<TruDatGroupPriceEngineVersionConfiguration>(entity =>
        {
            entity.ToTable("EngineVersionConfiguration", "GroupPrice");

            entity.HasIndex(e => e.GroupPriceEngineVersionModelId, "ix_grouppriceengineversionbase_engineversionmodelId");

            entity.HasIndex(e => e.GroupPricePolicyVersionImplementationId, "ix_grouppriceengineversionconfiguration_grouppricepolicyversionimplementationid");

            entity.HasIndex(e => e.Name, "uk_grouppriceengineversionconfiguration_name")
                .IsUnique();

            entity.HasIndex(e => e.UniqueId, "uk_grouppriceengineversionconfiguration_uniqueid")
                .IsUnique();

            entity.Property(e => e.Comments)
                .HasMaxLength(1024)
                .IsUnicode(false);

            entity.Property(e => e.DeductibleAvgPremiumList)
                .HasMaxLength(1012)
                .IsUnicode(false);

            entity.Property(e => e.DeductibleList)
                .HasMaxLength(1012)
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(512)
                .IsUnicode(false);

            entity.Property(e => e.UniqueId).HasDefaultValueSql("(newid())");

            entity.Property(e => e.UseCurrentAge).HasDefaultValueSql("((0))");

            entity.HasOne(d => d.GroupPriceEngineVersionModel)
                .WithMany(p => p.EngineVersionConfigurations)
                .HasForeignKey(d => d.GroupPriceEngineVersionModelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_groupengineversionbase_grouppriceengineversionconfiguration_engineversionmodelId");

            entity.HasOne(d => d.GroupPricePolicyVersionImplementation)
                .WithMany(p => p.EngineVersionConfigurations)
                .HasForeignKey(d => d.GroupPricePolicyVersionImplementationId)
                .HasConstraintName("fk_grouppriceengineversionconfiguration_grouppricepolicyversionimplementation_grouppricepolicyversionimplementationid");
        });

        modelBuilder.Entity<TruDatGroupPriceEngineVersionModel>(entity =>
        {
            entity.ToTable("EngineVersionModel", "GroupPrice");

            entity.HasIndex(e => e.AgeGroupConfigurationId, "ix_grouppriceengineversionmodel_agegroupconfigurationId");

            entity.HasIndex(e => e.Name, "uk_grouppriceengineversionmodel_name")
                .IsUnique();

            entity.HasIndex(e => e.UniqueId, "uk_grouppriceengineversionmodel_uniqueid")
                .IsUnique();

            entity.Property(e => e.Comments)
                .HasMaxLength(1024)
                .IsUnicode(false);

            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(512)
                .IsUnicode(false);

            entity.Property(e => e.UniqueId).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.AgeGroupConfiguration)
                .WithMany(p => p.EngineVersionModels)
                .HasForeignKey(d => d.AgeGroupConfigurationId)
                .HasConstraintName("fk_grouppriceengineversionmodel_grouppriceagegroupconfiguration_agegroupconfigurationId");
        });

        modelBuilder.Entity<TruDatGroupPriceEngineVersionModelState>(entity =>
        {
            entity.ToTable("EngineVersionModelState", "GroupPrice");

            entity.HasIndex(e => new { e.GroupPriceEngineVersionModelId, e.StateId }, "uk_grouppriceengineversionstate_vid_sid")
                .IsUnique();

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.GroupPriceEngineVersionModel)
                .WithMany(p => p.EngineVersionModelStates)
                .HasForeignKey(d => d.GroupPriceEngineVersionModelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_priceengineversion_grouppriceengineversionmodelstate");
        });

        modelBuilder.Entity<TruDatGroupPriceEngineVersionPremium>(entity =>
        {
            entity.ToTable("EngineVersionPremium", "GroupPrice");

            entity.HasIndex(e => e.AgeGroupId, "ix_grouppriceengineversionpremium_agegroupid");

            entity.HasIndex(e => e.GroupPriceEngineVersionId, "ix_grouppriceengineversionpremium_grouppriceengineversionid");

            entity.HasIndex(e => e.PolicyVersionImplementationDeductibleId, "ix_grouppriceengineversionpremium_policyversionimplementationdeductibleid");

            entity.HasIndex(e => e.SpecieId, "ix_grouppriceengineversionpremium_speciedId");

            entity.Property(e => e.Premium).HasColumnType("smallmoney");

            entity.HasOne(d => d.AgeGroup)
                .WithMany(p => p.EngineVersionPremia)
                .HasForeignKey(d => d.AgeGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_grouppriceengineversionpremium_agegroup_agegroupid");

            entity.HasOne(d => d.GroupPriceEngineVersion)
                .WithMany(p => p.EngineVersionPremia)
                .HasForeignKey(d => d.GroupPriceEngineVersionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_grouppriceengineversionpremium_grouppriceengineversion_groupriceengineversionid");

            entity.HasOne(d => d.PolicyVersionImplementationDeductible)
                .WithMany(p => p.EngineVersionPremia)
                .HasForeignKey(d => d.PolicyVersionImplementationDeductibleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_grouppriceengineversionpremium_grouppricepolicyversionimplementationdeductible_policyversionimplementationdeductibleid");
        });

        modelBuilder.Entity<TruDatGroupPriceGroupBenefitsAccount>(entity =>
        {
            entity.ToTable("GroupBenefitsAccount", "GroupPrice");

            entity.HasIndex(e => e.CorporateAccountId, "ix_grouppricegroupbefitsaccount_corporateaccountid");

            entity.HasIndex(e => e.GroupPriceEngineVersionId, "ix_grouppricegroupbefitsaccount_engineversionid");

            entity.HasIndex(e => e.PolicyVersionImplementationId, "ix_grouppricegroupbefitsaccount_policyversionimplementationid");

            entity.HasIndex(e => e.UniqueId, "uk_groupbenefitsaccount_uniqueid")
                .IsUnique();

            entity.Property(e => e.GroupId)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PolicyCancelationDate).HasColumnType("datetime");

            entity.Property(e => e.PolicyInceptionDate).HasColumnType("datetime");

            entity.Property(e => e.UniqueId).HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.GroupPriceEngineVersion)
                .WithMany(p => p.GroupBenefitsAccounts)
                .HasForeignKey(d => d.GroupPriceEngineVersionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_grouppricegroupbefitsaccount_grouppriceengineversion_grouppriceengineversionid");

            entity.HasOne(d => d.PolicyVersionImplementation)
                .WithMany(p => p.GroupBenefitsAccounts)
                .HasForeignKey(d => d.PolicyVersionImplementationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_grouppricegroupbefitsaccount_grouppricepolicyversionimplementation_policyversionimplementationid");
        });

        modelBuilder.Entity<TruDatGroupPricePolicyVersionImplementation>(entity =>
        {
            entity.ToTable("PolicyVersionImplementation", "GroupPrice");

            entity.HasIndex(e => e.CoveragePolicyVersionId, "ix_grouppricegroupbefitsaccount_policyversionid");

            entity.HasIndex(e => e.Name, "uk_grouppricepolicyversionimplementation_name")
                .IsUnique();

            entity.HasIndex(e => e.UniqueId, "uk_grouppricepolicyversionimplementation_uniqueid")
                .IsUnique();

            entity.Property(e => e.Comments)
                .IsRequired()
                .HasMaxLength(1012)
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(512)
                .IsUnicode(false);

            entity.Property(e => e.UniqueId).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<TruDatGroupPricePolicyVersionImplementationDeductible>(entity =>
        {
            entity.ToTable("PolicyVersionImplementationDeductible", "GroupPrice");

            entity.HasIndex(e => e.CoverageDeductibleId, "ix_grouppricepolicyversionimplementationdeductible_coveragedeductibleid");

            entity.HasIndex(e => e.PolicyVersionImplementationId, "ix_grouppricepolicyversionimplementationdeductible_policyversionimplementationid");

            entity.HasOne(d => d.PolicyVersionImplementation)
                .WithMany(p => p.PolicyVersionImplementationDeductibles)
                .HasForeignKey(d => d.PolicyVersionImplementationId)
                .HasConstraintName("fk_grouppricepolicyversionimplementationdeductible_grouppricepolicyversionimplementation_policyversionimplementationid");
        });

        modelBuilder.Entity<TruDatGroupPricePolicyVersionImplementationRider>(entity =>
        {
            entity.ToTable("PolicyVersionImplementationRider", "GroupPrice");

            entity.HasIndex(e => e.CoveragePolicyPackageId, "ix_grouppricepolicyversionimplementationrider_coveragepolicypackageid");

            entity.HasIndex(e => e.PolicyVersionImplementationId, "ix_grouppricepolicyversionimplementationrider_policyversionimplementationid");

            entity.HasOne(d => d.PolicyVersionImplementation)
                .WithMany(p => p.PolicyVersionImplementationRiders)
                .HasForeignKey(d => d.PolicyVersionImplementationId)
                .HasConstraintName("fk_grouppricepolicyversionimplementationrider_grouppricepolicyversionimplementation_policyversionimplementationid");
        });

        modelBuilder.Entity<TruDatGroupPricePolicyVersionImplementationWorkingPet>(entity =>
        {
            entity.ToTable("PolicyVersionImplementationWorkingPet", "GroupPrice");

            entity.HasIndex(e => e.PolicyVersionImplementationId, "ix_grouppricepolicyversionimplementationworkingpet_policyversionimplementationid");

            entity.HasOne(d => d.PolicyVersionImplementation)
                .WithMany(p => p.PolicyVersionImplementationWorkingPets)
                .HasForeignKey(d => d.PolicyVersionImplementationId)
                .HasConstraintName("fk_grouppricepolicyversionimplementationworkingpet_policyversionimplementationid");
        });

        OnModelCreatingPartial(modelBuilder);
    }
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
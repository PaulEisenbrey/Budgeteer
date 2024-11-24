using Microsoft.EntityFrameworkCore;
using Database.Trupanion.Entity.TruDat.Coverage;
using Utilities.ConnectionStringManager.Base;
using Utilities.Constants.Enum;

namespace Database.Trupanion.Context;

public partial class TruDatCoverageContext : DbContext
{
    public TruDatCoverageContext()
    {
    }

    public TruDatCoverageContext(DbContextOptions<TruDatCoverageContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TruDatCoverageEntityPolicyDocument> EntityPolicyDocuments { get; set; }
    public virtual DbSet<TruDatCoverageEntityType> EntityTypes { get; set; }
    public virtual DbSet<TruDatCoverageEntityWaitingPeriod> EntityWaitingPeriods { get; set; }
    public virtual DbSet<TruDatCoverageGroupPolicyVersionState> GroupPolicyVersionStates { get; set; }
    public virtual DbSet<TruDatCoveragePetPolicyCoverageEntity> PetPolicyCoverageEntities { get; set; }
    public virtual DbSet<TruDatCoveragePetPolicyCoverageEntityImport> PetPolicyCoverageEntityImports { get; set; }
    public virtual DbSet<TruDatCoveragePetPolicyDeductibleEffective> PetPolicyDeductibleEffectives { get; set; }
    public virtual DbSet<TruDatCoveragePolicy> Policies { get; set; }
    public virtual DbSet<TruDatCoveragePolicyCoinsurance> PolicyCoinsurances { get; set; }
    public virtual DbSet<TruDatCoveragePolicyCoverageItem> PolicyCoverageItems { get; set; }
    public virtual DbSet<TruDatCoveragePolicyCoveragePackage> PolicyCoveragePackages { get; set; }
    public virtual DbSet<TruDatCoveragePolicyCoveragePackageItem> PolicyCoveragePackageItems { get; set; }
    public virtual DbSet<TruDatCoveragePolicyDeductible> PolicyDeductibles { get; set; }
    public virtual DbSet<TruDatCoveragePolicyDocument> PolicyDocuments { get; set; }
    public virtual DbSet<TruDatCoveragePolicyDocumentInventory> PolicyDocumentInventories { get; set; }
    public virtual DbSet<TruDatCoveragePolicyVersion> PolicyVersions { get; set; }
    public virtual DbSet<TruDatCoveragePolicyVersionCoverageItem> PolicyVersionCoverageItems { get; set; }
    public virtual DbSet<TruDatCoveragePolicyVersionCoveragePackage> PolicyVersionCoveragePackages { get; set; }
    public virtual DbSet<TruDatCoveragePolicyVersionState> PolicyVersionStates { get; set; }
    public virtual DbSet<TruDatCoveragePolicyVersionWorkingPet> PolicyVersionWorkingPets { get; set; }
    public virtual DbSet<TruDatCoverageTracingBehavior> TracingBehaviors { get; set; }
    public virtual DbSet<TruDatCoverageWaitingPeriodType> WaitingPeriodTypes { get; set; }

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

        modelBuilder.Entity<TruDatCoverageEntityPolicyDocument>(entity =>
        {
            entity.ToTable("EntityPolicyDocument", "Coverage");

            entity.HasIndex(e => new { e.EntityTypeId3, e.EntityId3 }, "ix_coveragepolicydocumentinventory_entitytypeid_effectiveto_id");

            entity.HasIndex(e => new { e.PolicyDocumentId, e.EntityTypeId, e.EntityId, e.EntityTypeId2, e.EntityId2, e.EntityTypeId3, e.EntityId3 }, "uk_entitypolicydocument_pdid_etid_eid_etid2_eid2_etid3_eid3")
                .IsUnique();

            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

            entity.HasOne(d => d.EntityType)
                .WithMany(p => p.EntityPolicyDocumentEntityTypes)
                .HasForeignKey(d => d.EntityTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_entitypolicydocument_entitytype");

            entity.HasOne(d => d.EntityTypeId2Navigation)
                .WithMany(p => p.EntityPolicyDocumentEntityTypeId2Navigations)
                .HasForeignKey(d => d.EntityTypeId2)
                .HasConstraintName("fk_entitypolicydocument_entitytype2");

            entity.HasOne(d => d.EntityTypeId3Navigation)
                .WithMany(p => p.EntityPolicyDocumentEntityTypeId3Navigations)
                .HasForeignKey(d => d.EntityTypeId3)
                .HasConstraintName("fk_entitypolicydocument_entitytype3");

            entity.HasOne(d => d.PolicyDocument)
                .WithMany(p => p.EntityPolicyDocuments)
                .HasForeignKey(d => d.PolicyDocumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_entitypolicydocument_policydocument");
        });

        modelBuilder.Entity<TruDatCoverageEntityType>(entity =>
        {
            entity.ToTable("EntityType", "Coverage");

            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

            entity.Property(e => e.SchemaName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TableName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatCoverageEntityWaitingPeriod>(entity =>
        {
            entity.ToTable("EntityWaitingPeriod", "Coverage");

            entity.HasIndex(e => new { e.EntityTypeId, e.EntityUniqueId }, "ix_coverageEntityWaitingPeriod")
                .HasFilter("([EntityUniqueId] IS NOT NULL)");

            entity.HasIndex(e => new { e.WaitingPeriodTypeId, e.EntityTypeId }, "ix_coverageEntityWaitingPeriod_wptid_etid");

            entity.HasIndex(e => new { e.EntityTypeId, e.EntityId }, "ix_entitywaitingperiod_etid_eid");

            entity.HasIndex(e => new { e.WaitingPeriodTypeId, e.EntityTypeId, e.EntityId, e.EntityUniqueId }, "uk_entitywaitingperiod_wpt_etid_ed")
                .IsUnique();

            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

            entity.HasOne(d => d.EntityType)
                .WithMany(p => p.EntityWaitingPeriods)
                .HasForeignKey(d => d.EntityTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_entitywaitingperiod_entitytype");

            entity.HasOne(d => d.WaitingPeriodType)
                .WithMany(p => p.EntityWaitingPeriods)
                .HasForeignKey(d => d.WaitingPeriodTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_entitywaitingperiod_waitingperiodtype");
        });

        modelBuilder.Entity<TruDatCoverageGroupPolicyVersionState>(entity =>
        {
            entity.ToTable("GroupPolicyVersionState", "Coverage");

            entity.HasIndex(e => new { e.PolicyVersionId, e.StateId }, "uk_coverage_grouppolicyversionstate_pvid_sid")
                .IsUnique();

            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.EffectiveFrom).HasColumnType("date");

            entity.Property(e => e.EffectiveTo).HasColumnType("date");

            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

            entity.HasOne(d => d.PolicyVersion)
                .WithMany(p => p.GroupPolicyVersionStates)
                .HasForeignKey(d => d.PolicyVersionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_grouppolicyversionstate_policyversion");
        });

        modelBuilder.Entity<TruDatCoveragePetPolicyCoverageEntity>(entity =>
        {
            entity.ToTable("PetPolicyCoverageEntity", "Coverage");

            entity.HasIndex(e => e.EffectiveFrom, "ix_coveragepetpolicycoverageentity_effectivefrom");

            entity.HasIndex(e => new { e.EntityTypeId, e.EffectiveTo, e.Id }, "ix_coveragepetpolicycoverageentity_entitytypeid_effectiveto_id");

            entity.HasIndex(e => e.EntityTypeId, "ix_coveragepetpolicycoverageentity_etid");

            entity.HasIndex(e => new { e.PetPolicyId, e.EntityTypeId, e.EntityId, e.EffectiveFrom }, "uk_petpolicycoverageentity_ppid_etid_eid_efrom")
                .IsUnique();

            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.EffectiveFrom).HasColumnType("date");

            entity.Property(e => e.EffectiveTo).HasColumnType("date");

            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

            entity.HasOne(d => d.EntityType)
                .WithMany(p => p.PetPolicyCoverageEntities)
                .HasForeignKey(d => d.EntityTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_petpolicycoverageentity_entitytype");
        });

        modelBuilder.Entity<TruDatCoveragePetPolicyCoverageEntityImport>(entity =>
        {
            entity.ToTable("PetPolicyCoverageEntityImport", "Coverage");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");

            entity.Property(e => e.EffectiveFrom).HasColumnType("date");

            entity.Property(e => e.EffectiveTo).HasColumnType("date");

            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<TruDatCoveragePetPolicyDeductibleEffective>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PetPolicyDeductibleEffective", "Coverage");

            entity.Property(e => e.Deductible).HasColumnType("smallmoney");

            entity.Property(e => e.EffectiveFrom).HasColumnType("date");

            entity.Property(e => e.EffectiveTo).HasColumnType("date");

            entity.Property(e => e.Inserted).HasColumnType("datetime");

            entity.Property(e => e.Updated).HasColumnType("datetime");
        });

        modelBuilder.Entity<TruDatCoveragePolicy>(entity =>
        {
            entity.ToTable("Policy", "Coverage");

            entity.HasIndex(e => e.Name, "uk_policy_nme")
                .IsUnique();

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.CoinsurancePercentage).HasColumnType("numeric(6, 4)");

            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.MaxDeductible).HasColumnType("smallmoney");

            entity.Property(e => e.MaximumLifetimeBenefitsPayment).HasColumnType("smallmoney");

            entity.Property(e => e.MinDeductible).HasColumnType("smallmoney");

            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatCoveragePolicyCoinsurance>(entity =>
        {
            entity.ToTable("PolicyCoinsurance", "Coverage");

            entity.HasIndex(e => e.CoinsurancePercentage, "uk_policycoinsurance_coinsurancepercentage")
                .IsUnique();

            entity.Property(e => e.CoinsurancePercentage).HasColumnType("decimal(5, 2)");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");

            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<TruDatCoveragePolicyCoverageItem>(entity =>
        {
            entity.ToTable("PolicyCoverageItem", "Coverage");

            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatCoveragePolicyCoveragePackage>(entity =>
        {
            entity.ToTable("PolicyCoveragePackage", "Coverage");

            entity.HasIndex(e => e.EndorsementUniqueId, "uc_policycoveragepackage_endorsementuid")
                .IsUnique();

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Description)
                .IsRequired()
                .IsUnicode(false);

            entity.Property(e => e.EndorsementUniqueId).HasDefaultValueSql("(newid())");

            entity.Property(e => e.HideDuringEnrollment).HasDefaultValueSql("((0))");

            entity.Property(e => e.MarketingName)
                .IsRequired()
                .IsUnicode(false);

            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

            entity.Property(e => e.PolicyDocumentHref)
                .HasMaxLength(1024)
                .IsUnicode(false);

            entity.Property(e => e.RegulatoryName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatCoveragePolicyCoveragePackageItem>(entity =>
        {
            entity.ToTable("PolicyCoveragePackageItem", "Coverage");

            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

            entity.HasOne(d => d.PolicyCoverageItem)
                .WithMany(p => p.PolicyCoveragePackageItems)
                .HasForeignKey(d => d.PolicyCoverageItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_policycoveragepackageitem_policycoverageitem");

            entity.HasOne(d => d.PolicyCoveragePackage)
                .WithMany(p => p.PolicyCoveragePackageItems)
                .HasForeignKey(d => d.PolicyCoveragePackageId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_policycoveragepackageitem_policycoveragepackage");
        });

        modelBuilder.Entity<TruDatCoveragePolicyDeductible>(entity =>
        {
            entity.ToTable("PolicyDeductible", "Coverage");

            entity.HasIndex(e => e.Deductible, "uk_policydeductible_deductible")
                .IsUnique();

            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Deductible).HasColumnType("smallmoney");

            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<TruDatCoveragePolicyDocument>(entity =>
        {
            entity.ToTable("PolicyDocument", "Coverage");

            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.DisplayName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatCoveragePolicyDocumentInventory>(entity =>
        {
            entity.ToTable("PolicyDocumentInventory", "Coverage");

            entity.HasIndex(e => new { e.PolicyDocumentId, e.PolicyVersionId, e.EntityTypeId, e.EntityId }, "uk_policydocumentinventory_pdid_pvid_etid_eid")
                .IsUnique();

            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.DmsdocumentId)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("DMSDocumentId");

            entity.Property(e => e.DmsfileId)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("DMSFileId");

            entity.Property(e => e.DocumentName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.DocumentVersion)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

            entity.HasOne(d => d.EntityType)
                .WithMany(p => p.PolicyDocumentInventories)
                .HasForeignKey(d => d.EntityTypeId)
                .HasConstraintName("fk_policydocumentinventory_entitytype");

            entity.HasOne(d => d.PolicyDocument)
                .WithMany(p => p.PolicyDocumentInventories)
                .HasForeignKey(d => d.PolicyDocumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_policydocumentinventory_policydocument");

            entity.HasOne(d => d.PolicyVersion)
                .WithMany(p => p.PolicyDocumentInventories)
                .HasForeignKey(d => d.PolicyVersionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_policydocumentinventory_policydocumentinventory");
        });

        modelBuilder.Entity<TruDatCoveragePolicyVersion>(entity =>
        {
            entity.ToTable("PolicyVersion", "Coverage");

            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.DateEffective).HasColumnType("datetime");

            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PolicyPath)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Policy)
                .WithMany(p => p.PolicyVersions)
                .HasForeignKey(d => d.PolicyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_policyversion_policy");
        });

        modelBuilder.Entity<TruDatCoveragePolicyVersionCoverageItem>(entity =>
        {
            entity.ToTable("PolicyVersionCoverageItem", "Coverage");

            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

            entity.HasOne(d => d.PolicyCoverageItem)
                .WithMany(p => p.PolicyVersionCoverageItems)
                .HasForeignKey(d => d.PolicyCoverageItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_policyversioncoverageitem_policycoverageitem");

            entity.HasOne(d => d.PolicyVersion)
                .WithMany(p => p.PolicyVersionCoverageItems)
                .HasForeignKey(d => d.PolicyVersionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_policyversioncoverageitem_policyversion");
        });

        modelBuilder.Entity<TruDatCoveragePolicyVersionCoveragePackage>(entity =>
        {
            entity.ToTable("PolicyVersionCoveragePackage", "Coverage");

            entity.HasIndex(e => e.PolicyVersionId, "ix_coveragepolicyversioncoveragepackage_policypackageid");

            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.FixedCost).HasColumnType("smallmoney");

            entity.Property(e => e.IsDecPageVisible).HasDefaultValueSql("((1))");

            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

            entity.Property(e => e.PreferredName)
                .HasMaxLength(256)
                .IsUnicode(false);

            entity.HasOne(d => d.PolicyPackage)
                .WithMany(p => p.PolicyVersionCoveragePackages)
                .HasForeignKey(d => d.PolicyPackageId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_policyversioncoveragepackage_policycoveragepackage");

            entity.HasOne(d => d.PolicyVersion)
                .WithMany(p => p.PolicyVersionCoveragePackages)
                .HasForeignKey(d => d.PolicyVersionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_policyversioncoveragepackage_policyversion");
        });

        modelBuilder.Entity<TruDatCoveragePolicyVersionState>(entity =>
        {
            entity.ToTable("PolicyVersionState", "Coverage");

            entity.HasIndex(e => e.StateId, "ix_coverage_policyversionstate_sid");

            entity.HasIndex(e => new { e.PolicyVersionId, e.StateId }, "uk_coverage_policyversionstate_pvid_sid")
                .IsUnique();

            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.EffectiveFrom).HasColumnType("date");

            entity.Property(e => e.EffectiveTo).HasColumnType("date");

            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

            entity.HasOne(d => d.PolicyVersion)
                .WithMany(p => p.PolicyVersionStates)
                .HasForeignKey(d => d.PolicyVersionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_policyversionstate_policyversion");
        });

        modelBuilder.Entity<TruDatCoveragePolicyVersionWorkingPet>(entity =>
        {
            entity.ToTable("PolicyVersionWorkingPet", "Coverage");

            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.DecPageVisible).HasDefaultValueSql("((0))");

            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

            entity.HasOne(d => d.PolicyVersion)
                .WithMany(p => p.PolicyVersionWorkingPets)
                .HasForeignKey(d => d.PolicyVersionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_policyversionworkingpet_policyversion");
        });

        modelBuilder.Entity<TruDatCoverageTracingBehavior>(entity =>
        {
            entity.HasKey(e => e.Enabled)
                .HasName("pk_tracingbehavior");

            entity.ToTable("TracingBehavior", "Coverage");
        });

        modelBuilder.Entity<TruDatCoverageWaitingPeriodType>(entity =>
        {
            entity.ToTable("WaitingPeriodType", "Coverage");

            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
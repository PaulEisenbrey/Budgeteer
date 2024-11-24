using Microsoft.EntityFrameworkCore;
using Database.Trupanion.Entity.VisionMigration.PolicyLifecycleCore;
using Utilities.ConnectionStringManager.Base;
using Utilities.Constants.Enum;

namespace Database.Trupanion.Context;

public partial class VisionMigrationLifecycleCoreContext : DbContext
{
    public VisionMigrationLifecycleCoreContext()
    {
    }

    public VisionMigrationLifecycleCoreContext(DbContextOptions<VisionMigrationLifecycleCoreContext> options)
        : base(options)
    {
    }

    public virtual DbSet<VmPLCCoverageTerm> CoverageTerms { get; set; }
    public virtual DbSet<VmPLCPetPolicyMilestoneDate> PetPolicyMilestoneDates { get; set; }
    public virtual DbSet<VmPLCPetPolicyMilestoneDateType> PetPolicyMilestoneDateTypes { get; set; }
    public virtual DbSet<VmPLCPolicy> Policies { get; set; }
    public virtual DbSet<VmPLCPolicyPricingPeriod> PolicyPricingPeriods { get; set; }
    public virtual DbSet<VmPLCPolicyTerm> PolicyTerms { get; set; }
    public virtual DbSet<VmPLCPolicyTermAddOnProductCoverOption> PolicyTermAddOnProductCoverOptions { get; set; }
    public virtual DbSet<VmPLCPolicyTermPolicyTermAddOn> PolicyTermPolicyTermAddOns { get; set; }
    public virtual DbSet<VmPLCPolicyYear> PolicyYears { get; set; }
    public virtual DbSet<VmPLCVet> Vets { get; set; }
    public virtual DbSet<VmPLCVetHistory> VetHistories { get; set; }
    public virtual DbSet<VmPLCWrittenPremium> WrittenPremia { get; set; }
    public virtual DbSet<VmPLCWrittenPremiumTax> WrittenPremiumTaxes { get; set; }

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

        modelBuilder.Entity<VmPLCCoverageTerm>(entity =>
        {
            entity.ToTable("CoverageTerms", "PolicyLifecycleCore");

            entity.Property(e => e.CustomerId).HasColumnName("_CustomerId");

            entity.Property(e => e.EndDate).HasColumnType("date");

            entity.Property(e => e.PetPolicyId).HasColumnName("_PetPolicyId");

            entity.Property(e => e.StartDate).HasColumnType("date");

            entity.HasOne(d => d.PolicyYear)
                .WithMany(p => p.CoverageTerms)
                .HasForeignKey(d => d.PolicyYearId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_coverageTerms_PolicyYears_PolicyYearId");
        });

        modelBuilder.Entity<VmPLCPetPolicyMilestoneDate>(entity =>
        {
            entity.HasKey(e => new { e.PetPolicyId, e.MilestoneDate })
                .HasName("pk_PolicyLifecycleCorePetPolicyMilestoneDate");

            entity.ToTable("PetPolicyMilestoneDate", "PolicyLifecycleCore");

            entity.Property(e => e.MilestoneDate).HasColumnType("date");

            entity.HasOne(d => d.Type)
                .WithMany(p => p.PetPolicyMilestoneDates)
                .HasForeignKey(d => d.TypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_PolicyLifecycleCorePetPolicyMilestoneDate_PetPolicyMilestoneDateType_TypeId");
        });

        modelBuilder.Entity<VmPLCPetPolicyMilestoneDateType>(entity =>
        {
            entity.ToTable("PetPolicyMilestoneDateType", "PolicyLifecycleCore");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(200);
        });

        modelBuilder.Entity<VmPLCPolicy>(entity =>
        {
            entity.ToTable("Policies", "PolicyLifecycleCore");

            entity.HasIndex(e => e.CustomerId, "ix_policyLifecycleCorePolicies_customerId");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.InceptionDate).HasColumnType("date");

            entity.Property(e => e.TermsDate).HasColumnType("date");
        });

        modelBuilder.Entity<VmPLCPolicyPricingPeriod>(entity =>
        {
            entity.ToTable("PolicyPricingPeriods", "PolicyLifecycleCore");

            entity.Property(e => e.CustomerId).HasColumnName("_CustomerId");

            entity.Property(e => e.EndDate).HasColumnType("date");

            entity.Property(e => e.PetPolicyId).HasColumnName("_PetPolicyId");

            entity.Property(e => e.StartDate).HasColumnType("date");
        });

        modelBuilder.Entity<VmPLCPolicyTerm>(entity =>
        {
            entity.ToTable("PolicyTerms", "PolicyLifecycleCore");

            entity.HasIndex(e => e.CoverageTermId, "ix_PolicyLifecycleCorePolicyTerms_CoverageTermId");

            entity.HasIndex(e => e.PolicyId, "ix_PolicyLifecycleCorePolicyTerms_PolicyId");

            entity.HasIndex(e => e.CustomerId, "ix_policyLifecycleCorePolicyTerms_CustomerId");

            entity.HasIndex(e => e.PetPolicyId, "ix_policyLifecycleCorePolicyTerms_PetPolicyId");

            entity.HasIndex(e => new { e.PetPolicyId, e.StartDate }, "ix_policyLifecycleCorePolicyTerms_ppid_startDate");

            entity.Property(e => e.CoInsurance).HasColumnType("decimal(18, 2)");

            entity.Property(e => e.CustomerId).HasColumnName("_CustomerId");

            entity.Property(e => e.DiscountedPeriodicalPremium).HasColumnType("decimal(18, 2)");

            entity.Property(e => e.EndDate).HasColumnType("date");

            entity.Property(e => e.Excess).HasColumnType("decimal(18, 2)");

            entity.Property(e => e.Limit).HasColumnType("decimal(18, 2)");

            entity.Property(e => e.PetPolicyId).HasColumnName("_PetPolicyId");

            entity.Property(e => e.ProductCode).IsRequired();

            entity.Property(e => e.StartDate).HasColumnType("date");

            entity.HasOne(d => d.CoverageTerm)
                .WithMany(p => p.PolicyTerms)
                .HasForeignKey(d => d.CoverageTermId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Policy)
                .WithMany(p => p.PolicyTerms)
                .HasForeignKey(d => d.PolicyId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<VmPLCPolicyTermAddOnProductCoverOption>(entity =>
        {
            entity.ToTable("PolicyTermAddOnProductCoverOptions", "PolicyLifecycleCore");

            entity.Property(e => e.CoInsurance).HasColumnType("decimal(18, 2)");

            entity.Property(e => e.CustomerId).HasColumnName("_CustomerId");

            entity.Property(e => e.DiscountedPeriodicalPremium).HasColumnType("decimal(18, 2)");

            entity.Property(e => e.Excess).HasColumnType("decimal(18, 2)");

            entity.Property(e => e.Limit).HasColumnType("decimal(18, 2)");

            entity.Property(e => e.PetPolicyId).HasColumnName("_PetPolicyId");

            entity.Property(e => e.ProductCode)
                .IsRequired()
                .HasMaxLength(255);

            entity.Property(e => e.ProductCoverOptionsId).HasDefaultValueSql("(NEXT VALUE FOR [PolicyLifecycleCore].[PolicyTermAddOnProductCoverOptionsIdSequence])");
        });

        modelBuilder.Entity<VmPLCPolicyTermPolicyTermAddOn>(entity =>
        {
            entity.ToTable("PolicyTermPolicyTermAddOn", "PolicyLifecycleCore");

            entity.Property(e => e.CustomerId).HasColumnName("_CustomerId");

            entity.Property(e => e.PetPolicyId).HasColumnName("_PetPolicyId");

            entity.HasOne(d => d.AddOns)
                .WithMany(p => p.PolicyTermPolicyTermAddOns)
                .HasForeignKey(d => d.AddOnsId)
                .HasConstraintName("fk_PolicyTermPolicyTermAddOn_PolicyTermAddOns_AddOnsId");

            entity.HasOne(d => d.PolicyTerms)
                .WithMany(p => p.PolicyTermPolicyTermAddOns)
                .HasForeignKey(d => d.PolicyTermsId)
                .HasConstraintName("fk_PolicyTermPolicyTermAddOn_PolicyTerms_PolicyTermsId");
        });

        modelBuilder.Entity<VmPLCPolicyYear>(entity =>
        {
            entity.ToTable("PolicyYears", "PolicyLifecycleCore");

            entity.Property(e => e.CustomerId).HasColumnName("_CustomerId");

            entity.Property(e => e.EndDate).HasColumnType("date");

            entity.Property(e => e.PetPolicyId).HasColumnName("_PetPolicyId");

            entity.Property(e => e.StartDate).HasColumnType("date");
        });

        modelBuilder.Entity<VmPLCVet>(entity =>
        {
            entity.ToTable("Vet", "PolicyLifecycleCore");

            entity.HasIndex(e => e.ClinicId, "ix_policyLifecycleCoreVet_clinicId");

            entity.HasIndex(e => e.CountryId, "ix_policyLifecycleCoreVet_countryId");

            entity.HasIndex(e => e.CustomerId, "ix_policyLifecycleCoreVet_customerId");

            entity.HasIndex(e => e.PetPolicyId, "ix_policyLifecycleCoreVet_petPolicyId");

            entity.Property(e => e.Address1).HasMaxLength(100);

            entity.Property(e => e.Address2).HasMaxLength(100);

            entity.Property(e => e.Address3).HasMaxLength(100);

            entity.Property(e => e.ClinicId).HasColumnName("_ClinicId");

            entity.Property(e => e.Country).HasMaxLength(55);

            entity.Property(e => e.CountryId).HasColumnName("_CountryId");

            entity.Property(e => e.CustomerId).HasColumnName("_CustomerId");

            entity.Property(e => e.Email).HasMaxLength(254);

            entity.Property(e => e.LanguageTagId)
                .IsRequired()
                .HasMaxLength(5);

            entity.Property(e => e.PetPolicyId).HasColumnName("_PetPolicyId");

            entity.Property(e => e.PhoneNumber).HasMaxLength(26);

            entity.Property(e => e.PostalCode).HasMaxLength(10);

            entity.Property(e => e.PracticeName).HasMaxLength(1000);

            entity.Property(e => e.RegionCounty).HasMaxLength(30);

            entity.Property(e => e.TownCity).HasMaxLength(60);
        });

        modelBuilder.Entity<VmPLCVetHistory>(entity =>
        {
            entity.ToTable("VetHistory", "PolicyLifecycleCore");

            entity.HasIndex(e => e.CountryId, "ix_policyLifecycleCoreVetHistory_countryId");

            entity.HasIndex(e => e.CustomerId, "ix_policyLifecycleCoreVetHistory_customerId");

            entity.Property(e => e.CountryId).HasColumnName("_CountryId");

            entity.Property(e => e.CustomerId).HasColumnName("_CustomerId");

            entity.Property(e => e.PetId).HasColumnName("_PetId");
        });

        modelBuilder.Entity<VmPLCWrittenPremium>(entity =>
        {
            entity.ToTable("WrittenPremium", "PolicyLifecycleCore");

            entity.Property(e => e.CustomerId).HasColumnName("_CustomerId");

            entity.Property(e => e.FullTermPremium).HasColumnType("decimal(18, 2)");

            entity.Property(e => e.PetPolicyId).HasColumnName("_PetPolicyId");

            entity.Property(e => e.PremiumAdjustment).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<VmPLCWrittenPremiumTax>(entity =>
        {
            entity.ToTable("WrittenPremiumTax", "PolicyLifecycleCore");

            entity.Property(e => e.AdjustmentAmount).HasColumnType("decimal(18, 2)");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

            entity.Property(e => e.CustomerId).HasColumnName("_CustomerId");

            entity.Property(e => e.Name).IsRequired();

            entity.Property(e => e.PetPolicyId).HasColumnName("_PetPolicyId");

            entity.Property(e => e.Rate).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.WrittenPremium)
                .WithMany(p => p.WrittenPremiumTaxes)
                .HasForeignKey(d => d.WrittenPremiumId)
                .HasConstraintName("fk_writtenPremiumTax_WrittenPremium_WrittenPremiumId");
        });

        modelBuilder.HasSequence<int>("PolicyTermAddOnProductCoverOptionsIdSequence", "PolicyLifecycleCore");

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
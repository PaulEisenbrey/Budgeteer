using Microsoft.EntityFrameworkCore;
using Database.Trupanion.Entity.TestData.PricingFactor;
using Utilities.ConnectionStringManager.Base;
using Utilities.Constants.Enum;

namespace Database.Trupanion.Context;

public partial class TestDataPricingFactorContext : DbContext
{
    public TestDataPricingFactorContext()
    {
    }

    public TestDataPricingFactorContext(DbContextOptions<TestDataPricingFactorContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TestDataPricingFactorAffinityGroup> AffinityGroups { get; set; }
    public virtual DbSet<TestDataPricingFactorAgeFactor> AgeFactors { get; set; }
    public virtual DbSet<TestDataPricingFactorBreedFactor> BreedFactors { get; set; }
    public virtual DbSet<TestDataPricingFactorCoInsurance> CoInsurances { get; set; }
    public virtual DbSet<TestDataPricingFactorDeductibleFactor> DeductibleFactors { get; set; }
    public virtual DbSet<TestDataPricingFactorEmployeeBenefitFactor> EmployeeBenefits { get; set; }
    public virtual DbSet<TestDataPricingFactorExamFeeFactor> ExamFees { get; set; }
    public virtual DbSet<TestDataPricingFactorExpenseRateFactor> ExpenseRates { get; set; }
    public virtual DbSet<TestDataPricingFactorFoodFactor> Foods { get; set; }
    public virtual DbSet<TestDataPricingFactorGenderFactor> GenderFactors { get; set; }
    public virtual DbSet<TestDataPricingFactorGeo> Geos { get; set; }
    public virtual DbSet<TestDataPricingFactorHospital> Hospitals { get; set; }
    public virtual DbSet<TestDataPricingFactorLimitedCoverage> LimitedCoverages { get; set; }
    public virtual DbSet<TestDataPricingFactorRateCard> RateCards { get; set; }
    public virtual DbSet<TestDataPricingFactorRateCardState> RateCardStates { get; set; }
    public virtual DbSet<TestDataPricingFactorRiderA> RiderAs { get; set; }
    public virtual DbSet<TestDataPricingFactorRiderB> RiderBs { get; set; }
    public virtual DbSet<TestDataPricingFactorSpayNeuter> SpayNeuters { get; set; }
    public virtual DbSet<TestDataPricingFactorState> States { get; set; }
    public virtual DbSet<TestDataPricingFactorStateHeader> StateHeaders { get; set; }
    public virtual DbSet<TestDataPricingFactorStateTrend> StateTrends { get; set; }
    public virtual DbSet<TestDataPricingFactorVcaWellnessDiscount> VcaWellnessDiscounts { get; set; }
    public virtual DbSet<TestDataPricingFactorWaitingPeriod> WaitingPeriods { get; set; }
    public virtual DbSet<TestDataPricingFactorWebLinkPartner> WebLinkPartners { get; set; }
    public virtual DbSet<TestDataPricingFactorWorkingGroup> WorkingGroups { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(ConnectionString.TrupanionConnectionString(SqlDatabase.testdata), options => options.EnableRetryOnFailure().CommandTimeout(60));
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<TestDataPricingFactorAffinityGroup>(entity =>
        {
            entity.ToTable("AffinityGroup", "PricingFactor");

            entity.HasOne(d => d.RateCardState)
                .WithMany(p => p.AffinityGroups)
                .HasForeignKey(d => d.RateCardStateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_affinitygroup_ratecardstate");
        });

        modelBuilder.Entity<TestDataPricingFactorAgeFactor>(entity =>
        {
            entity.ToTable("AgeFactor", "PricingFactor");

            entity.HasIndex(e => new { e.RateCardStateId, e.AgeVal }, "ci_pricingfactor_breedfactor_ratecardstateid_agefactor");

            entity.HasOne(d => d.RateCardState)
                .WithMany(p => p.AgeFactors)
                .HasForeignKey(d => d.RateCardStateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_agefactor_ratecardstate");
        });

        modelBuilder.Entity<TestDataPricingFactorBreedFactor>(entity =>
        {
            entity.ToTable("BreedFactor", "PricingFactor");

            entity.HasIndex(e => new { e.RateCardStateId, e.BreedId }, "ci_pricingfactor_breedfactor_ratecardstateid_breedid");

            entity.HasIndex(e => new { e.RateCardStateId, e.BreedRollup }, "ci_pricingfactor_breedfactor_ratecardstateid_breedrollup");

            entity.Property(e => e.BreedRollup)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            entity.HasOne(d => d.RateCardState)
                .WithMany(p => p.BreedFactors)
                .HasForeignKey(d => d.RateCardStateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_breedfactor_ratecardstate");
        });

        modelBuilder.Entity<TestDataPricingFactorCoInsurance>(entity =>
        {
            entity.ToTable("CoInsurance", "PricingFactor");

            entity.Property(e => e.CoInsuranceRate)
                .IsRequired()
                .HasMaxLength(100);

            entity.HasOne(d => d.RateCardState)
                .WithMany(p => p.CoInsurances)
                .HasForeignKey(d => d.RateCardStateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_coinsurance_ratecardstate");
        });

        modelBuilder.Entity<TestDataPricingFactorDeductibleFactor>(entity =>
        {
            entity.ToTable("DeductibleFactor", "PricingFactor");

            entity.Property(e => e.ActiveDate).HasColumnType("datetime");

            entity.Property(e => e.RateCardStateId).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<TestDataPricingFactorEmployeeBenefitFactor>(entity =>
        {
            entity.ToTable("EmployeeBenefit", "PricingFactor");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            entity.HasOne(d => d.RateCardState)
                .WithMany(p => p.EmployeeBenefits)
                .HasForeignKey(d => d.RateCardStateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_employeebenefit_ratecardstate");
        });

        modelBuilder.Entity<TestDataPricingFactorExamFeeFactor>(entity =>
        {
            entity.ToTable("ExamFee", "PricingFactor");

            entity.HasOne(d => d.RateCardState)
                .WithMany(p => p.ExamFees)
                .HasForeignKey(d => d.RateCardStateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_examfee_ratecardstate");
        });

        modelBuilder.Entity<TestDataPricingFactorExpenseRateFactor>(entity =>
        {
            entity.ToTable("ExpenseRate", "PricingFactor");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            entity.HasOne(d => d.RateCardState)
                .WithMany(p => p.ExpenseRates)
                .HasForeignKey(d => d.RateCardStateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_expenserate_ratecardstate");
        });

        modelBuilder.Entity<TestDataPricingFactorFoodFactor>(entity =>
        {
            entity.ToTable("Food", "PricingFactor");

            entity.HasOne(d => d.RateCardState)
                .WithMany(p => p.Foods)
                .HasForeignKey(d => d.RateCardStateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_food_ratecardstate");
        });

        modelBuilder.Entity<TestDataPricingFactorGenderFactor>(entity =>
        {
            entity.ToTable("GenderFactor", "PricingFactor");

            entity.HasOne(d => d.RateCardState)
                .WithMany(p => p.GenderFactors)
                .HasForeignKey(d => d.RateCardStateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_genderfactor_ratecardstate");
        });

        modelBuilder.Entity<TestDataPricingFactorGeo>(entity =>
        {
            entity.ToTable("Geo", "PricingFactor");

            entity.HasIndex(e => new { e.RateCardStateId, e.ZipCode }, "<Name of Missing Index, sysname,>");

            entity.Property(e => e.ProvinceOrZip)
                .IsRequired()
                .HasMaxLength(20);

            entity.Property(e => e.RegionDetailName).HasMaxLength(100);

            entity.Property(e => e.RegionName)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.State)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.UpdatedGroup).HasColumnType("decimal(18, 0)");

            entity.Property(e => e.ZipCode)
                .IsRequired()
                .HasMaxLength(10);

            entity.HasOne(d => d.RateCardState)
                .WithMany(p => p.Geos)
                .HasForeignKey(d => d.RateCardStateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_Geo_ratecardstate");
        });

        modelBuilder.Entity<TestDataPricingFactorHospital>(entity =>
        {
            entity.ToTable("Hospital", "PricingFactor");

            entity.Property(e => e.GeoRegion)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.HospitalName)
                .IsRequired()
                .HasMaxLength(100);

            entity.HasOne(d => d.RateCardState)
                .WithMany(p => p.Hospitals)
                .HasForeignKey(d => d.RateCardStateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_hospital_ratecardstate");
        });

        modelBuilder.Entity<TestDataPricingFactorLimitedCoverage>(entity =>
        {
            entity.ToTable("LimitedCoverage", "PricingFactor");

            entity.HasOne(d => d.RateCardState)
                .WithMany(p => p.LimitedCoverages)
                .HasForeignKey(d => d.RateCardStateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_limitedcoverage_ratecardstate");
        });

        modelBuilder.Entity<TestDataPricingFactorRateCard>(entity =>
        {
            entity.ToTable("RateCard", "PricingFactor");

            entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.PublishDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TestDataPricingFactorRateCardState>(entity =>
        {
            entity.ToTable("RateCardState", "PricingFactor");

            entity.Property(e => e.EffectiveDate)
                .HasColumnType("datetime")
                .HasColumnName("EFfectiveDate");

            entity.Property(e => e.IsLegacy)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.HasOne(d => d.RateCard)
                .WithMany(p => p.RateCardStates)
                .HasForeignKey(d => d.RateCardId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ratecardstate_ratecard");
        });

        modelBuilder.Entity<TestDataPricingFactorRiderA>(entity =>
        {
            entity.ToTable("RiderA", "PricingFactor");

            entity.HasOne(d => d.RateCardState)
                .WithMany(p => p.RiderAs)
                .HasForeignKey(d => d.RateCardStateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ridera_ratecardstate");
        });

        modelBuilder.Entity<TestDataPricingFactorRiderB>(entity =>
        {
            entity.ToTable("RiderB", "PricingFactor");

            entity.HasOne(d => d.RateCardState)
                .WithMany(p => p.RiderBs)
                .HasForeignKey(d => d.RateCardStateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_riderb_ratecardstate");
        });

        modelBuilder.Entity<TestDataPricingFactorSpayNeuter>(entity =>
        {
            entity.ToTable("SpayNeuter", "PricingFactor");

            entity.HasOne(d => d.RateCardState)
                .WithMany(p => p.SpayNeuters)
                .HasForeignKey(d => d.RateCardStateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_spayneuter_ratecardstate");
        });

        modelBuilder.Entity<TestDataPricingFactorState>(entity =>
        {
            entity.ToTable("State", "PricingFactor");

            entity.Property(e => e.Code).HasMaxLength(10);

            entity.Property(e => e.CountryCode).HasDefaultValueSql("((1))");

            entity.Property(e => e.IsLegacy)
                .IsRequired()
                .HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<TestDataPricingFactorStateHeader>(entity =>
        {
            entity.ToTable("StateHeader", "PricingFactor");

            entity.Property(e => e.BaseEffectiveDate).HasColumnType("datetime");

            entity.HasOne(d => d.RateCardState)
                .WithMany(p => p.StateHeaders)
                .HasForeignKey(d => d.RateCardStateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_stateheader_ratecardstate");
        });

        modelBuilder.Entity<TestDataPricingFactorStateTrend>(entity =>
        {
            entity.ToTable("StateTrend", "PricingFactor");

            entity.HasOne(d => d.RateCardState)
                .WithMany(p => p.StateTrends)
                .HasForeignKey(d => d.RateCardStateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_statetrend_ratecardstate");
        });

        modelBuilder.Entity<TestDataPricingFactorVcaWellnessDiscount>(entity =>
        {
            entity.ToTable("VcaWellnessDiscount", "PricingFactor");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            entity.HasOne(d => d.RateCardState)
                .WithMany(p => p.VcaWellnessDiscounts)
                .HasForeignKey(d => d.RateCardStateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_vcawellnessdiscount_ratecardstate");
        });

        modelBuilder.Entity<TestDataPricingFactorWaitingPeriod>(entity =>
        {
            entity.ToTable("WaitingPeriod", "PricingFactor");

            entity.HasOne(d => d.RateCardState)
                .WithMany(p => p.WaitingPeriods)
                .HasForeignKey(d => d.RateCardStateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_waitingperiod_ratecardstate");
        });

        modelBuilder.Entity<TestDataPricingFactorWebLinkPartner>(entity =>
        {
            entity.ToTable("WebLinkPartner", "PricingFactor");

            entity.HasOne(d => d.RateCardState)
                .WithMany(p => p.WebLinkPartners)
                .HasForeignKey(d => d.RateCardStateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_weblinktrend_ratecardstate");
        });

        modelBuilder.Entity<TestDataPricingFactorWorkingGroup>(entity =>
        {
            entity.ToTable("WorkingGroup", "PricingFactor");

            entity.HasOne(d => d.RateCardState)
                .WithMany(p => p.WorkingGroups)
                .HasForeignKey(d => d.RateCardStateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_workinggroup_ratecardstate");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
using Microsoft.EntityFrameworkCore;
using Database.Trupanion.Entity.TestData.PolicyTesting;
using Utilities.ConnectionStringManager.Base;
using Utilities.Constants.Enum;

namespace Database.Trupanion.Context;

public partial class TestDataPolicyTestingContext : DbContext
{
    public TestDataPolicyTestingContext()
    {
    }

    public TestDataPolicyTestingContext(DbContextOptions<TestDataPolicyTestingContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TestDataPolicyTestingAutomatedScenarioResult> AutomatedScenarioResults { get; set; }
    public virtual DbSet<TestDataPolicyTestingPriceScenarioResult> PriceScenarioResults { get; set; }
    public virtual DbSet<TestDataPolicyTestingPricecheckResult> PricecheckResults { get; set; }
    public virtual DbSet<TestDataPolicyTestingPricecheckResultFactor> PricecheckResultFactors { get; set; }
    public virtual DbSet<TestDataPolicyTestingPricecheckScenario> PricecheckScenarios { get; set; }
    public virtual DbSet<TestDataPolicyTestingPricecheckScenarioParent> PricecheckScenarioParents { get; set; }
    public virtual DbSet<TestDataPolicyTestingScenarioResult> ScenarioResults { get; set; }
    public virtual DbSet<TestDataPolicyTestingState> States { get; set; }
    public virtual DbSet<TestDataPolicyTestingStateColumnOffset> StateColumnOffsets { get; set; }
    public virtual DbSet<TestDataPolicyTestingZipcodeWithCountryId> ZipcodeWithCountryIds { get; set; }

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

        modelBuilder.Entity<TestDataPolicyTestingAutomatedScenarioResult>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("AutomatedScenarioResult", "PolicyTesting");

            entity.Property(e => e.Deductible).HasColumnType("smallmoney");

            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

            entity.Property(e => e.ProdFactorSource).HasMaxLength(10);

            entity.Property(e => e.ProdRiderBfactor).HasColumnName("ProdRiderBFactor");

            entity.Property(e => e.RateCardPremium).HasColumnType("smallmoney");

            entity.Property(e => e.ResultMessage).HasMaxLength(500);

            entity.Property(e => e.RunDate).HasColumnType("datetime");

            entity.Property(e => e.SprocPremium).HasColumnType("smallmoney");

            entity.Property(e => e.TestFactorSource).HasMaxLength(10);

            entity.Property(e => e.TestRiderBfactor).HasColumnName("TestRiderBFactor");

            entity.Property(e => e.ZipCode)
                .IsRequired()
                .HasMaxLength(10);
        });

        modelBuilder.Entity<TestDataPolicyTestingPriceScenarioResult>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PriceScenarioResults", "PolicyTesting");

            entity.Property(e => e.Code).HasMaxLength(3);

            entity.Property(e => e.Engineversion).HasColumnName("engineversion");

            entity.Property(e => e.FactorSource)
                .IsRequired()
                .HasMaxLength(10);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.RateCardPremium).HasColumnType("smallmoney");

            entity.Property(e => e.RunDate).HasColumnType("datetime");

            entity.Property(e => e.SprocPremium).HasColumnType("smallmoney");
        });

        modelBuilder.Entity<TestDataPolicyTestingPricecheckResult>(entity =>
        {
            entity.ToTable("PricecheckResult", "PolicyTesting");

            entity.Property(e => e.Breed).HasMaxLength(200);

            entity.Property(e => e.BreedId).HasDefaultValueSql("((0))");

            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

            entity.Property(e => e.RateCardPremium).HasColumnType("smallmoney");

            entity.Property(e => e.ResultMessage).HasMaxLength(500);

            entity.Property(e => e.SprocPremium).HasColumnType("smallmoney");

            entity.Property(e => e.SystemError).HasMaxLength(2000);

            entity.HasOne(d => d.PricecheckScenario)
                .WithMany(p => p.PricecheckResults)
                .HasForeignKey(d => d.PricecheckScenarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pricecheckresult_pricecheckscenario");
        });

        modelBuilder.Entity<TestDataPolicyTestingPricecheckResultFactor>(entity =>
        {
            entity.ToTable("PricecheckResultFactor", "PolicyTesting");

            entity.Property(e => e.FactorSource)
                .IsRequired()
                .HasMaxLength(10);

            entity.Property(e => e.RiderBfactor).HasColumnName("RiderBFactor");

            entity.HasOne(d => d.PricecheckResult)
                .WithMany(p => p.PricecheckResultFactors)
                .HasForeignKey(d => d.PricecheckResultId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pricecheckresultfactor_pricecheckresult");
        });

        modelBuilder.Entity<TestDataPolicyTestingPricecheckScenario>(entity =>
        {
            entity.ToTable("PricecheckScenario", "PolicyTesting");

            entity.Property(e => e.Deductible).HasColumnType("smallmoney");

            entity.Property(e => e.PolicyDate).HasColumnType("datetime");

            entity.Property(e => e.PromoCode)
                .IsRequired()
                .HasMaxLength(40);

            entity.Property(e => e.RunDate).HasColumnType("datetime");

            entity.Property(e => e.ZipCode)
                .IsRequired()
                .HasMaxLength(10);
        });

        modelBuilder.Entity<TestDataPolicyTestingPricecheckScenarioParent>(entity =>
        {
            entity.ToTable("PricecheckScenarioParent", "PolicyTesting");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TestDataPolicyTestingScenarioResult>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ScenarioResult", "PolicyTesting");

            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

            entity.Property(e => e.RateCardPremium).HasColumnType("smallmoney");

            entity.Property(e => e.ResultMessage).HasMaxLength(500);

            entity.Property(e => e.RunDate).HasColumnType("datetime");

            entity.Property(e => e.SprocPremium).HasColumnType("smallmoney");
        });

        modelBuilder.Entity<TestDataPolicyTestingState>(entity =>
        {
            entity.ToTable("State", "PolicyTesting");

            entity.Property(e => e.Code).HasMaxLength(3);

            entity.Property(e => e.CountryCode).HasDefaultValueSql("((1))");

            entity.Property(e => e.IsLegacy)
                .IsRequired()
                .HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<TestDataPolicyTestingStateColumnOffset>(entity =>
        {
            entity.ToTable("StateColumnOffset", "PolicyTesting");

            entity.Property(e => e.State)
                .IsRequired()
                .HasMaxLength(40);
        });

        modelBuilder.Entity<TestDataPolicyTestingZipcodeWithCountryId>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ZipcodeWithCountryId", "PolicyTesting");

            entity.Property(e => e.Id)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.PlaceName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.StateCode)
                .IsRequired()
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.StateName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Zipcode)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
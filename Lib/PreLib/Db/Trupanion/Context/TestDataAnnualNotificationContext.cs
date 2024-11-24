using Microsoft.EntityFrameworkCore;
using Database.Trupanion.Entity.TestData.AnnualNotification;
using Utilities.ConnectionStringManager.Base;
using Utilities.Constants.Enum;

namespace Database.Trupanion.Context;

public partial class TestDataAnnualNotificationContext : DbContext
{
    public TestDataAnnualNotificationContext()
    {
    }

    public TestDataAnnualNotificationContext(DbContextOptions<TestDataAnnualNotificationContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TestDataAnnualNotificationAddress> Addresses { get; set; }
    public virtual DbSet<TestDataAnnualNotificationAddressType> AddressTypes { get; set; }
    public virtual DbSet<TestDataAnnualNotificationAmenditoryEndorsementState> AmenditoryEndorsementStates { get; set; }
    public virtual DbSet<TestDataAnnualNotificationConfiguration> Configurations { get; set; }
    public virtual DbSet<TestDataAnnualNotificationPet> Pets { get; set; }
    public virtual DbSet<TestDataAnnualNotificationPolicyInfo> PolicyInfos { get; set; }
    public virtual DbSet<TestDataAnnualNotificationRateAdjustmentMonitorLog> RateAdjustmentMonitorLogs { get; set; }
    public virtual DbSet<TestDataAnnualNotificationRateAdjustmentState> RateAdjustmentStates { get; set; }
    public virtual DbSet<TestDataAnnualNotificationScenario> Scenarios { get; set; }
    public virtual DbSet<TestDataAnnualNotificationScenarioAndPetToPolicy> ScenarioAndPetToPolicies { get; set; }
    public virtual DbSet<TestDataAnnualNotificationTestInstance> TestInstances { get; set; }
    public virtual DbSet<TestDataAnnualNotificationTestParent> TestParents { get; set; }
    public virtual DbSet<TestDataAnnualNotificationTestScenario> TestScenarios { get; set; }
    public virtual DbSet<TestDataAnnualNotificationTestScenario1> TestScenarios1 { get; set; }
    public virtual DbSet<TestDataAnnualNotificationTransform> Transforms { get; set; }

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

        modelBuilder.Entity<TestDataAnnualNotificationAddress>(entity =>
        {
            entity.ToTable("Address", "AnnualNotification");

            entity.Property(e => e.Address1)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("address1");

            entity.Property(e => e.Address2)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("address2");

            entity.Property(e => e.AddressTypeId).HasColumnName("addressTypeId");

            entity.Property(e => e.City)
                .IsRequired()
                .HasMaxLength(60)
                .HasColumnName("city");

            entity.Property(e => e.StateAbbr)
                .IsRequired()
                .HasMaxLength(5)
                .HasColumnName("stateAbbr");

            entity.Property(e => e.ZipCode)
                .IsRequired()
                .HasMaxLength(15)
                .HasColumnName("zipCode");
        });

        modelBuilder.Entity<TestDataAnnualNotificationAddressType>(entity =>
        {
            entity.ToTable("AddressType", "AnnualNotification");

            entity.Property(e => e.AddressType1)
                .HasMaxLength(20)
                .HasColumnName("addressType");

            entity.Property(e => e.AddresstypeId).HasColumnName("addresstypeId");
        });

        modelBuilder.Entity<TestDataAnnualNotificationAmenditoryEndorsementState>(entity =>
        {
            entity.ToTable("AmenditoryEndorsementState", "AnnualNotification");

            entity.Property(e => e.StateCode)
                .IsRequired()
                .HasMaxLength(10);
        });

        modelBuilder.Entity<TestDataAnnualNotificationConfiguration>(entity =>
        {
            entity.ToTable("Configuration", "AnnualNotification");

            entity.Property(e => e.ConfigName).HasMaxLength(40);

            entity.Property(e => e.ConfigValue).HasMaxLength(40);
        });

        modelBuilder.Entity<TestDataAnnualNotificationPet>(entity =>
        {
            entity.ToTable("Pet", "AnnualNotification");

            entity.Property(e => e.Age).HasColumnName("age");

            entity.Property(e => e.Breed)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("breed");

            entity.Property(e => e.Gender).HasColumnName("gender");

            entity.Property(e => e.IsBreeding).HasColumnName("isBreeding");

            entity.Property(e => e.IsSpayed).HasColumnName("isSpayed");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(60)
                .HasColumnName("name");

            entity.Property(e => e.Species)
                .IsRequired()
                .HasMaxLength(3)
                .HasColumnName("species");
        });

        modelBuilder.Entity<TestDataAnnualNotificationPolicyInfo>(entity =>
        {
            entity.ToTable("PolicyInfo", "AnnualNotification");

            entity.Property(e => e.Deductible).HasColumnName("deductible");

            entity.Property(e => e.HasRiderA).HasColumnName("hasRiderA");

            entity.Property(e => e.HasRiderB).HasColumnName("hasRiderB");

            entity.Property(e => e.IsWorkingPet).HasColumnName("isWorkingPet");

            entity.Property(e => e.Premium)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("premium");

            entity.Property(e => e.PromoCode)
                .HasMaxLength(20)
                .HasColumnName("promoCode");
        });

        modelBuilder.Entity<TestDataAnnualNotificationRateAdjustmentMonitorLog>(entity =>
        {
            entity.ToTable("RateAdjustmentMonitorLog", "AnnualNotification");

            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

            entity.Property(e => e.ErrorMessage).HasMaxLength(800);

            entity.Property(e => e.RunDate).HasColumnType("datetime");

            entity.HasOne(d => d.CurrentState)
                .WithMany(p => p.RateAdjustmentMonitorLogs)
                .HasForeignKey(d => d.CurrentStateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_annualnotification_rateadjustmentstate");
        });

        modelBuilder.Entity<TestDataAnnualNotificationRateAdjustmentState>(entity =>
        {
            entity.ToTable("RateAdjustmentState", "AnnualNotification");

            entity.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<TestDataAnnualNotificationScenario>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("Scenarios", "AnnualNotification");

            entity.Property(e => e.Address1)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("address1");

            entity.Property(e => e.Address2)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("address2");

            entity.Property(e => e.AddressId).HasColumnName("addressId");

            entity.Property(e => e.Breed)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("breed");

            entity.Property(e => e.City)
                .IsRequired()
                .HasMaxLength(60)
                .HasColumnName("city");

            entity.Property(e => e.Deductible).HasColumnName("deductible");

            entity.Property(e => e.FName)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("fName");

            entity.Property(e => e.Gender).HasColumnName("gender");

            entity.Property(e => e.HasRiderA).HasColumnName("hasRiderA");

            entity.Property(e => e.HasRiderB).HasColumnName("hasRiderB");

            entity.Property(e => e.IsWorkingPet).HasColumnName("isWorkingPet");

            entity.Property(e => e.LName)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("lName");

            entity.Property(e => e.PetName)
                .IsRequired()
                .HasMaxLength(60);

            entity.Property(e => e.PolicyDay).HasColumnName("policyDay");

            entity.Property(e => e.PolicyMonth).HasColumnName("policyMonth");

            entity.Property(e => e.Species)
                .IsRequired()
                .HasMaxLength(3)
                .HasColumnName("species");

            entity.Property(e => e.StateAbbr)
                .IsRequired()
                .HasMaxLength(5)
                .HasColumnName("stateAbbr");

            entity.Property(e => e.TransformName)
                .HasMaxLength(50)
                .HasColumnName("transformName");

            entity.Property(e => e.YearsToAge).HasColumnName("yearsToAge");

            entity.Property(e => e.ZipCode)
                .IsRequired()
                .HasMaxLength(15)
                .HasColumnName("zipCode");
        });

        modelBuilder.Entity<TestDataAnnualNotificationScenarioAndPetToPolicy>(entity =>
        {
            entity.ToTable("ScenarioAndPetToPolicy", "AnnualNotification");
        });

        modelBuilder.Entity<TestDataAnnualNotificationTestInstance>(entity =>
        {
            entity.ToTable("TestInstance", "AnnualNotification");

            entity.HasOne(d => d.TestParent)
                .WithMany(p => p.TestInstances)
                .HasForeignKey(d => d.TestParentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_testinstance_testparent");
        });

        modelBuilder.Entity<TestDataAnnualNotificationTestParent>(entity =>
        {
            entity.ToTable("TestParent", "AnnualNotification");

            entity.Property(e => e.CompletionDate).HasColumnType("datetime");

            entity.Property(e => e.RunDate).HasColumnType("datetime");

            entity.Property(e => e.StateAbbr)
                .IsRequired()
                .HasMaxLength(3);
        });

        modelBuilder.Entity<TestDataAnnualNotificationTestScenario>(entity =>
        {
            entity.ToTable("TestScenario", "AnnualNotification");

            entity.Property(e => e.AddressId).HasColumnName("addressId");

            entity.Property(e => e.FName)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("fName");

            entity.Property(e => e.LName)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("lName");

            entity.Property(e => e.PolicyDay).HasColumnName("policyDay");

            entity.Property(e => e.PolicyMonth).HasColumnName("policyMonth");

            entity.Property(e => e.Premium)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("premium");

            entity.Property(e => e.TransformId).HasColumnName("transformId");

            entity.Property(e => e.YearsToAge).HasColumnName("yearsToAge");
        });

        modelBuilder.Entity<TestDataAnnualNotificationTestScenario1>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("TestScenarios", "AnnualNotification");

            entity.Property(e => e.Address1)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("address1");

            entity.Property(e => e.Address2)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("address2");

            entity.Property(e => e.AddressId).HasColumnName("addressId");

            entity.Property(e => e.Age).HasColumnName("age");

            entity.Property(e => e.Breed)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("breed");

            entity.Property(e => e.City)
                .IsRequired()
                .HasMaxLength(60)
                .HasColumnName("city");

            entity.Property(e => e.Deductible).HasColumnName("deductible");

            entity.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.Gender).HasColumnName("gender");

            entity.Property(e => e.HasRiderA).HasColumnName("hasRiderA");

            entity.Property(e => e.HasRiderB).HasColumnName("hasRiderB");

            entity.Property(e => e.IsBreeding).HasColumnName("isBreeding");

            entity.Property(e => e.IsSpayed).HasColumnName("isSpayed");

            entity.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.PetName).HasMaxLength(70);

            entity.Property(e => e.PolicyDay).HasColumnName("policyDay");

            entity.Property(e => e.PolicyInfoId).HasColumnName("policyInfoId");

            entity.Property(e => e.PolicyMonth).HasColumnName("policyMonth");

            entity.Property(e => e.Premium)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("premium");

            entity.Property(e => e.Species)
                .IsRequired()
                .HasMaxLength(3)
                .HasColumnName("species");

            entity.Property(e => e.StateAbbr)
                .IsRequired()
                .HasMaxLength(5)
                .HasColumnName("stateAbbr");

            entity.Property(e => e.TransformId).HasColumnName("transformId");

            entity.Property(e => e.TransformName)
                .HasMaxLength(50)
                .HasColumnName("transformName");

            entity.Property(e => e.YearsToAge).HasColumnName("yearsToAge");

            entity.Property(e => e.ZipCode)
                .IsRequired()
                .HasMaxLength(15)
                .HasColumnName("zipCode");
        });

        modelBuilder.Entity<TestDataAnnualNotificationTransform>(entity =>
        {
            entity.ToTable("Transform", "AnnualNotification");

            entity.Property(e => e.TransformName)
                .HasMaxLength(50)
                .HasColumnName("transformName");

            entity.Property(e => e.TransformVal).HasColumnName("transformVal");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
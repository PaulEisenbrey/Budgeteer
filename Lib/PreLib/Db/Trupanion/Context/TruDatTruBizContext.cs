using Microsoft.EntityFrameworkCore;
using Database.Trupanion.Entity.TruDat.TruBiz;
using Utilities.ConnectionStringManager.Base;
using Utilities.Constants.Enum;

namespace Database.Trupanion.Context;

public partial class TruDatTruBizContext : DbContext
{
    public TruDatTruBizContext()
    {
    }

    public TruDatTruBizContext(DbContextOptions<TruDatTruBizContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TruDatTruBizAdditionalBenefit> AdditionalBenefits { get; set; }
    public virtual DbSet<TruDatTruBizCampaignInstanceUrlReferrer> CampaignInstanceUrlReferrers { get; set; }
    public virtual DbSet<TruDatTruBizCancelReason> CancelReasons { get; set; }
    public virtual DbSet<TruDatTruBizCharityByCountry> CharityByCountries { get; set; }
    public virtual DbSet<TruDatTruBizClaimConditionForPolicy> ClaimConditionForPolicies { get; set; }
    public virtual DbSet<TruDatTruBizCorporatePet> CorporatePets { get; set; }
    public virtual DbSet<TruDatTruBizCorporatePolicyholder> CorporatePolicyholders { get; set; }
    public virtual DbSet<TruDatTruBizHowDidYouHearAboutU> HowDidYouHearAboutUs { get; set; }
    public virtual DbSet<TruDatTruBizLegacyPolicyHolderBillingInfo> LegacyPolicyHolderBillingInfos { get; set; }
    public virtual DbSet<TruDatTruBizMedicalRecordsClinicPet> MedicalRecordsClinicPets { get; set; }
    public virtual DbSet<TruDatTruBizOwner> Owners { get; set; }
    public virtual DbSet<TruDatTruBizOwnerPetPolicyHospital> OwnerPetPolicyHospitals { get; set; }
    public virtual DbSet<TruDatTruBizOwnerPromo> OwnerPromos { get; set; }
    public virtual DbSet<TruDatTruBizPet> Pets { get; set; }
    public virtual DbSet<TruDatTruBizPetPolicy> PetPolicies { get; set; }
    public virtual DbSet<TruDatTruBizPetPolicyCoverage> PetPolicyCoverages { get; set; }
    public virtual DbSet<TruDatTruBizPetsOwner> PetsOwners { get; set; }
    public virtual DbSet<TruDatTruBizPolicyCoverageItem> PolicyCoverageItems { get; set; }
    public virtual DbSet<TruDatTruBizPolicyCoveragePackage> PolicyCoveragePackages { get; set; }
    public virtual DbSet<TruDatTruBizPolicyCoveragePackageVersion> PolicyCoveragePackageVersions { get; set; }
    public virtual DbSet<TruDatTruBizPolicyOption> PolicyOptions { get; set; }
    public virtual DbSet<TruDatTruBizPolicyVersionState> PolicyVersionStates { get; set; }
    public virtual DbSet<TruDatTruBizWaivereason> Waivereasons { get; set; }

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

        modelBuilder.Entity<TruDatTruBizAdditionalBenefit>(entity =>
        {
            entity.ToTable("AdditionalBenefit", "Claim");

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TruDatTruBizCampaignInstanceUrlReferrer>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("CampaignInstanceUrlReferrer", "trubiz");

            entity.Property(e => e.CampaignCode)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UrlReferrer).IsUnicode(false);
        });

        modelBuilder.Entity<TruDatTruBizCancelReason>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("CancelReason", "trubiz");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.Property(e => e.Inserted).HasColumnType("datetime");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Updated).HasColumnType("datetime");
        });

        modelBuilder.Entity<TruDatTruBizCharityByCountry>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("CharityByCountry", "trubiz");

            entity.Property(e => e.Charityid).HasColumnName("charityid");

            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<TruDatTruBizClaimConditionForPolicy>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ClaimConditionForPolicy", "trubiz");

            entity.Property(e => e.AmountPaidOut).HasColumnType("smallmoney");

            entity.Property(e => e.BreedName)
                .HasMaxLength(8000)
                .IsUnicode(false);

            entity.Property(e => e.ClaimOpenDate).HasColumnType("datetime");

            entity.Property(e => e.ConditionName)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.DateOfLoss).HasColumnType("smalldatetime");

            entity.Property(e => e.Diagnosis)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.PetName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PolicyNumber)
                .IsRequired()
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.TotalClaimed).HasColumnType("smallmoney");
        });

        modelBuilder.Entity<TruDatTruBizCorporatePet>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("CorporatePet", "trubiz");

            entity.Property(e => e.Deductible).HasColumnType("smallmoney");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatTruBizCorporatePolicyholder>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("CorporatePolicyholder", "trubiz");

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
        });

        modelBuilder.Entity<TruDatTruBizHowDidYouHearAboutU>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("HowDidYouHearAboutUs", "trubiz");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.Property(e => e.Inserted).HasColumnType("datetime");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Updated).HasColumnType("datetime");
        });

        modelBuilder.Entity<TruDatTruBizLegacyPolicyHolderBillingInfo>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("LegacyPolicyHolderBillingInfo", "trubiz");

            entity.Property(e => e.AdjustmentDate).HasColumnType("date");

            entity.Property(e => e.BillingPastDue).HasColumnType("datetime");

            entity.Property(e => e.NextBillingDate).HasColumnType("datetime");

            entity.Property(e => e.PaymentMethod)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.PaymentMethodId).HasColumnName("PaymentMethodID");

            entity.Property(e => e.TotalPremium).HasColumnType("money");
        });

        modelBuilder.Entity<TruDatTruBizMedicalRecordsClinicPet>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MedicalRecordsClinicPets", "trubiz");

            entity.Property(e => e.BreedName)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.DateOfBirth).HasColumnType("smalldatetime");

            entity.Property(e => e.EnrollmentDate).HasColumnType("datetime");

            entity.Property(e => e.EnrollmentStatus)
                .IsRequired()
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.Gender)
                .IsRequired()
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength(true);

            entity.Property(e => e.IsVip).HasColumnName("IsVIP");

            entity.Property(e => e.OwnerFirstName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.OwnerId).HasColumnName("OwnerID");

            entity.Property(e => e.OwnerLastName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PawPrintStatus)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PetName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PolicyNumber)
                .IsRequired()
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Promo)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.SecondaryOwnerFirstName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SecondaryOwnerLastName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Species)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatTruBizOwner>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("Owner", "trubiz");

            entity.Property(e => e.AlternateFirstName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AlternateLastName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BillingPastDue).HasColumnType("datetime");

            entity.Property(e => e.BillingPastDueAmount).HasColumnType("smallmoney");

            entity.Property(e => e.CellPhone)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CharityValue).HasColumnType("smallmoney");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");

            entity.Property(e => e.EmailAddress)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.EmployeeId)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FaxNumber)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.HomePhone)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Language)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

            entity.Property(e => e.PaymentFailedDate).HasColumnType("datetime");

            entity.Property(e => e.PaymentFailedDefaultPaymentMethodId).HasMaxLength(40);

            entity.Property(e => e.PolicyHolderUntil).HasColumnType("datetime");

            entity.Property(e => e.PolicyNumber)
                .IsRequired()
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SecondaryEmailAddress)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Vip).HasColumnName("VIP");

            entity.Property(e => e.WorkExtension)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.WorkPhone)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatTruBizOwnerPetPolicyHospital>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OwnerPetPolicyHospital", "trubiz");

            entity.Property(e => e.AddressLine1)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AddressLine2)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.City)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.DateOfBirth).HasColumnType("smalldatetime");

            entity.Property(e => e.EmailAddress)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Gender)
                .IsRequired()
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength(true);

            entity.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PetName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PetPolicyNumber)
                .IsRequired()
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PolicyDate).HasColumnType("datetime");

            entity.Property(e => e.PolicyNumber)
                .IsRequired()
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.PostalCode)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StateCode)
                .IsRequired()
                .HasMaxLength(3)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatTruBizOwnerPromo>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OwnerPromo", "trubiz");

            entity.Property(e => e.PromoCode)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatTruBizPet>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("Pet", "trubiz");

            entity.Property(e => e.AdoptionDate).HasColumnType("date");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");

            entity.Property(e => e.DateOfBirth).HasColumnType("smalldatetime");

            entity.Property(e => e.Edcdate)
                .HasColumnType("smalldatetime")
                .HasColumnName("EDCDate");

            entity.Property(e => e.Gender)
                .IsRequired()
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength(true);

            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SpayedNeuteredDate).HasColumnType("date");

            entity.Property(e => e.StatusChangeDate).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<TruDatTruBizPetPolicy>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PetPolicy", "trubiz");

//            entity.Property(e => e.CancelDate).HasColumnType("datetime");
//
//            entity.Property(e => e.CancelNote)
//                .HasMaxLength(400)
//                .IsUnicode(false);

            entity.Property(e => e.CoinsurancePercentage).HasColumnType("decimal(5, 2)");

//            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
//
//            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
//
//            entity.Property(e => e.PetExamDate).HasColumnType("date");

//            entity.Property(e => e.PetRequireTreatmentDesc)
//                .HasMaxLength(500)
//                .IsUnicode(false);
//
//            entity.Property(e => e.PolicyDate).HasColumnType("datetime");
//
//            entity.Property(e => e.PolicyNumber)
//                .IsRequired()
//                .HasMaxLength(40)
//                .IsUnicode(false);
//
//            entity.Property(e => e.PolicyPaidThru).HasColumnType("datetime");

//            entity.Property(e => e.PromoCode)
//                .HasMaxLength(50)
//                .IsUnicode(false);
//
//            entity.Property(e => e.PromoReferenceNumber)
//                .HasMaxLength(500)
//                .IsUnicode(false);
//
//            entity.Property(e => e.TagNumber)
//                .HasMaxLength(50)
//                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatTruBizPetPolicyCoverage>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PetPolicyCoverage", "trubiz");

            entity.Property(e => e.Cost).HasColumnType("smallmoney");

            entity.Property(e => e.EffectiveFrom).HasColumnType("date");

            entity.Property(e => e.EffectiveTo).HasColumnType("date");

            entity.Property(e => e.PreferredName)
                .HasMaxLength(256)
                .IsUnicode(false);

            entity.Property(e => e.RegulatoryName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatTruBizPetsOwner>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PetsOwner", "trubiz");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TruDatTruBizPolicyCoverageItem>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PolicyCoverageItem", "trubiz");

            entity.Property(e => e.EffectiveFrom).HasColumnType("date");

            entity.Property(e => e.EffectiveTo).HasColumnType("date");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatTruBizPolicyCoveragePackage>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PolicyCoveragePackage", "trubiz");

            entity.Property(e => e.Description)
                .IsRequired()
                .IsUnicode(false);

            entity.Property(e => e.MarketingName)
                .IsRequired()
                .IsUnicode(false);

            entity.Property(e => e.PolicyDocumentHref)
                .HasMaxLength(1024)
                .IsUnicode(false);

            entity.Property(e => e.PreferredName)
                .HasMaxLength(256)
                .IsUnicode(false);

            entity.Property(e => e.RegulatoryName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatTruBizPolicyCoveragePackageVersion>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PolicyCoveragePackageVersion", "trubiz");

            entity.Property(e => e.Description)
                .IsRequired()
                .IsUnicode(false);

            entity.Property(e => e.MarketingName)
                .IsRequired()
                .IsUnicode(false);

            entity.Property(e => e.PolicyDocumentHref)
                .HasMaxLength(1024)
                .IsUnicode(false);

            entity.Property(e => e.PreferredName)
                .HasMaxLength(256)
                .IsUnicode(false);

            entity.Property(e => e.RegulatoryName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatTruBizPolicyOption>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PolicyOptions", "trubiz");

            entity.Property(e => e.Description)
                .IsRequired()
                .IsUnicode(false);

            entity.Property(e => e.DisplayName)
                .IsRequired()
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PolicyDocumentHref)
                .HasMaxLength(8000)
                .IsUnicode(false);

            entity.Property(e => e.PreferredName)
                .IsRequired()
                .HasMaxLength(256)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatTruBizPolicyVersionState>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PolicyVersionState", "trubiz");

            entity.Property(e => e.EffectiveFrom).HasColumnType("date");

            entity.Property(e => e.EffectiveTo).HasColumnType("date");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TruDatTruBizWaivereason>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("Waivereason", "trubiz");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");

            entity.Property(e => e.ListDescription)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ListValue)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

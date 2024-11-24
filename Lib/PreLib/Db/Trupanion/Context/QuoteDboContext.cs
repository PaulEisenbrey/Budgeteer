using Microsoft.EntityFrameworkCore;

using Database.Trupanion.Entity.Quote.Dbo;
using Utilities.ConnectionStringManager.Base;
using Utilities.Constants.Enum;

namespace Database.TestData.QuoteDbo;

public partial class QuoteDboContext : DbContext
{
    public QuoteDboContext()
    {
    }

    public QuoteDboContext(DbContextOptions<QuoteDboContext> options)
        : base(options)
    {
    }

    public virtual DbSet<QuoteDboAge> Ages { get; set; }
    public virtual DbSet<QuoteDboAttributionType> AttributionTypes { get; set; }
    public virtual DbSet<QuoteDboBreedAlias> BreedAliases { get; set; }
    public virtual DbSet<QuoteDboCharity> Charities { get; set; }
    public virtual DbSet<QuoteDboEndorsementCharacteristic> EndorsementCharacteristics { get; set; }
    public virtual DbSet<QuoteDboEnrollmentPetCharacteristic> EnrollmentPetCharacteristics { get; set; }
    public virtual DbSet<QuoteDboEnrollmentPetEndorsement> EnrollmentPetEndorsements { get; set; }
    public virtual DbSet<QuoteDboEnrollmentPolicyholderCharacteristic> EnrollmentPolicyholderCharacteristics { get; set; }
    public virtual DbSet<QuoteDboEnrollmentRequest> EnrollmentRequests { get; set; }
    public virtual DbSet<QuoteDboEnrollmentRequestAttribution> EnrollmentRequestAttributions { get; set; }
    public virtual DbSet<QuoteDboEnrollmentRequestFee> EnrollmentRequestFees { get; set; }
    public virtual DbSet<QuoteDboEnrollmentRequestPet> EnrollmentRequestPets { get; set; }
    public virtual DbSet<QuoteDboEnrollmentRequestPetFee> EnrollmentRequestPetFees { get; set; }
    public virtual DbSet<QuoteDboEnrollmentRequestSecondaryHospital> EnrollmentRequestSecondaryHospitals { get; set; }
    public virtual DbSet<QuoteDboEnrollmentRequestType> EnrollmentRequestTypes { get; set; }
    public virtual DbSet<QuoteDboExpiredOffer> ExpiredOffers { get; set; }
    public virtual DbSet<QuoteDboInactiveBreed> InactiveBreeds { get; set; }
    public virtual DbSet<QuoteDboIssuedCertificate> IssuedCertificates { get; set; }
    public virtual DbSet<QuoteDboIssuedCertificateAttribution> IssuedCertificateAttributions { get; set; }
    public virtual DbSet<QuoteDboIssuedCertificateType> IssuedCertificateTypes { get; set; }
    public virtual DbSet<QuoteDboPetCharacteristic> PetCharacteristics { get; set; }
    public virtual DbSet<QuoteDboPetCharacteristicType> PetCharacteristicTypes { get; set; }
    public virtual DbSet<QuoteDboQuote> Quotes { get; set; }
    public virtual DbSet<QuoteDboQuotePet> QuotePets { get; set; }
    public virtual DbSet<QuoteDboQuoteSecondaryHospital> QuoteSecondaryHospitals { get; set; }
    public virtual DbSet<QuoteDboReferral> Referrals { get; set; }
    public virtual DbSet<QuoteDboSecondaryHospital> SecondaryHospitals { get; set; }
    public virtual DbSet<QuoteDboSelectedPolicyOption> SelectedPolicyOptions { get; set; }
    public virtual DbSet<QuoteDboSelectedWorkingPet> SelectedWorkingPets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(ConnectionString.TrupanionConnectionString(SqlDatabase.quote), options => options.EnableRetryOnFailure().CommandTimeout(60));
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<QuoteDboAge>(entity =>
        {
            entity.ToTable("Age");

            entity.HasIndex(e => e.PetCharacteristicId, "ix_dboage_petcharacteristicid");

            entity.Property(e => e.AgeYearFrom).HasColumnType("numeric(4, 2)");

            entity.Property(e => e.AgeYearTo).HasColumnType("numeric(4, 2)");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(250);

            entity.HasOne(d => d.PetCharacteristic)
                .WithMany(p => p.Ages)
                .HasForeignKey(d => d.PetCharacteristicId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dboage_dbopetcharacteristic");
        });

        modelBuilder.Entity<QuoteDboAttributionType>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dboattributiontype_id")
                .IsClustered(false);

            entity.ToTable("AttributionType");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(250);
        });

        modelBuilder.Entity<QuoteDboBreedAlias>(entity =>
        {
            entity.ToTable("BreedAlias");

            entity.HasIndex(e => e.PetCharacteristicId, "ix_dbobreedalias_petcharacteristicid");

            entity.HasIndex(e => e.Alias, "ix_dbobreedalies_alias");

            entity.Property(e => e.Alias)
                .IsRequired()
                .HasMaxLength(250);

            entity.HasOne(d => d.PetCharacteristic)
                .WithMany(p => p.BreedAliases)
                .HasForeignKey(d => d.PetCharacteristicId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dbobreedalias_dbopetcharacteristic");
        });

        modelBuilder.Entity<QuoteDboCharity>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dbo_charity_id")
                .IsClustered(false);

            entity.ToTable("Charity");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.DefaultDonation).HasColumnType("smallmoney");

            entity.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(512)
                .IsUnicode(false);

            entity.Property(e => e.LogoName)
                .IsRequired()
                .HasMaxLength(150)
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Url)
                .IsRequired()
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("URL");
        });

        modelBuilder.Entity<QuoteDboEndorsementCharacteristic>(entity =>
        {
            entity.ToTable("EndorsementCharacteristic");

            entity.HasIndex(e => e.IntId, "ix_dbo_endorsement_intid");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.MarketingName).IsRequired();

            entity.Property(e => e.RegulatoryName)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<QuoteDboEnrollmentPetCharacteristic>(entity =>
        {
            entity.ToTable("EnrollmentPetCharacteristic");

            entity.HasIndex(e => e.PetId, "ix_enrollmentpetcharacteristic_petid");

            entity.HasIndex(e => e.PetId, "ix_enrollmentpetendorsement_petid");

            entity.HasOne(d => d.Pet)
                .WithMany(p => p.EnrollmentPetCharacteristics)
                .HasForeignKey(d => d.PetId)
                .HasConstraintName("fk_enrollmentpetcharacteristic_pet_id");
        });

        modelBuilder.Entity<QuoteDboEnrollmentPetEndorsement>(entity =>
        {
            entity.ToTable("EnrollmentPetEndorsement");

            entity.Property(e => e.Cost).HasColumnType("smallmoney");

            entity.HasOne(d => d.Pet)
                .WithMany(p => p.EnrollmentPetEndorsements)
                .HasForeignKey(d => d.PetId)
                .HasConstraintName("fk_enrollmentpet_endorsement_id");
        });

        modelBuilder.Entity<QuoteDboEnrollmentPolicyholderCharacteristic>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dboenrollmentpolicyholdercharacteristic_id")
                .IsClustered(false);

            entity.ToTable("EnrollmentPolicyholderCharacteristic");

            entity.HasIndex(e => e.EnrollmentRequestId, "ix_enrollmentpolicyholdercharacteristic_enrollmentid");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.EnrollmentRequest)
                .WithMany(p => p.EnrollmentPolicyholderCharacteristics)
                .HasForeignKey(d => d.EnrollmentRequestId)
                .HasConstraintName("fk_enrollmentpolicyholdercharacteristic_enrollment_id");
        });

        modelBuilder.Entity<QuoteDboEnrollmentRequest>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dboenrollment_id")
                .IsClustered(false);

            entity.ToTable("EnrollmentRequest");

            entity.HasIndex(e => e.CreatedOn, "ix_enrollment_createdon");

            entity.HasIndex(e => e.EmailAddress, "ix_enrollment_emailaddress");

            entity.HasIndex(e => e.IssuedCertificateId, "ix_enrollment_issuedcertificateid");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Address1).HasMaxLength(250);

            entity.Property(e => e.Address2).HasMaxLength(250);

            entity.Property(e => e.AlternatePhoneNumber).HasMaxLength(20);

            entity.Property(e => e.City).HasMaxLength(250);

            entity.Property(e => e.EmailAddress).HasMaxLength(250);

            entity.Property(e => e.FirstName).HasMaxLength(250);

            entity.Property(e => e.IsoAlpha3CountryCode)
                .IsRequired()
                .HasMaxLength(3)
                .IsFixedLength(true);

            entity.Property(e => e.LanguagePreference).HasMaxLength(50);

            entity.Property(e => e.LastName).HasMaxLength(250);

            entity.Property(e => e.Partner).HasMaxLength(250);

            entity.Property(e => e.Password).HasMaxLength(250);

            entity.Property(e => e.PolicyNumber).HasMaxLength(250);

            entity.Property(e => e.PostalCode).HasMaxLength(20);

            entity.Property(e => e.PrimaryPhoneNumber).HasMaxLength(20);

            entity.Property(e => e.PromoCode).HasMaxLength(250);

            entity.Property(e => e.ReferralOther).HasMaxLength(250);

            entity.Property(e => e.Salt).HasMaxLength(250);

            entity.Property(e => e.Source).HasMaxLength(250);

            entity.Property(e => e.StateCode).HasMaxLength(3);

            entity.HasOne(d => d.RequestType)
                .WithMany(p => p.EnrollmentRequests)
                .HasForeignKey(d => d.RequestTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dboenrollmentrequest_requesttypeid");
        });

        modelBuilder.Entity<QuoteDboEnrollmentRequestAttribution>(entity =>
        {
            entity.HasKey(e => new { e.EnrollmentRequestId, e.AttributionTypeId })
                .HasName("pk_dboenrollmentrequestattribution_enrollmentrequestid_attributiontypeid")
                .IsClustered(false);

            entity.ToTable("EnrollmentRequestAttribution");

            entity.Property(e => e.Data).IsRequired();

            entity.HasOne(d => d.AttributionType)
                .WithMany(p => p.EnrollmentRequestAttributions)
                .HasForeignKey(d => d.AttributionTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dboenrollmentrequestattribution_attributiontypeid");

            entity.HasOne(d => d.EnrollmentRequest)
                .WithMany(p => p.EnrollmentRequestAttributions)
                .HasForeignKey(d => d.EnrollmentRequestId)
                .HasConstraintName("fk_dboenrollmentrequestattribution_enrollmentrequestid");
        });

        modelBuilder.Entity<QuoteDboEnrollmentRequestFee>(entity =>
        {
            entity.ToTable("EnrollmentRequestFee");

            entity.HasIndex(e => e.EnrollmentRequestId, "ix_enrollment_fee_enrollmentrequestid");

            entity.Property(e => e.Amount).HasColumnType("smallmoney");

            entity.Property(e => e.Discount).HasColumnType("smallmoney");

            entity.Property(e => e.TaxAmount).HasColumnType("smallmoney");

            entity.HasOne(d => d.EnrollmentRequest)
                .WithMany(p => p.EnrollmentRequestFees)
                .HasForeignKey(d => d.EnrollmentRequestId)
                .HasConstraintName("fk_dboenrollment_fee_enrollmentrequestid");
        });

        modelBuilder.Entity<QuoteDboEnrollmentRequestPet>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_enrollmentpet_id")
                .IsClustered(false);

            entity.ToTable("EnrollmentRequestPet");

            entity.HasIndex(e => e.EnrollmentId, "ix_enrollmentpet_enrollmentid");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.CoinsurancePercentage).HasColumnType("decimal(19, 5)");

            entity.Property(e => e.Deductible).HasColumnType("smallmoney");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(250);

            entity.Property(e => e.PetPolicyNumber)
                .IsRequired()
                .HasMaxLength(250);

            entity.Property(e => e.PremiumAmount).HasColumnType("smallmoney");

            entity.Property(e => e.PremiumTaxAmount).HasColumnType("smallmoney");

            entity.HasOne(d => d.Enrollment)
                .WithMany(p => p.EnrollmentRequestPets)
                .HasForeignKey(d => d.EnrollmentId)
                .HasConstraintName("fk_enrollmentPet_enrollment_id");
        });

        modelBuilder.Entity<QuoteDboEnrollmentRequestPetFee>(entity =>
        {
            entity.ToTable("EnrollmentRequestPetFee");

            entity.HasIndex(e => e.PetId, "ix_enrollment_fee_petid");

            entity.Property(e => e.Amount).HasColumnType("smallmoney");

            entity.Property(e => e.Discount).HasColumnType("smallmoney");

            entity.Property(e => e.TaxAmount).HasColumnType("smallmoney");

            entity.HasOne(d => d.Pet)
                .WithMany(p => p.EnrollmentRequestPetFees)
                .HasForeignKey(d => d.PetId)
                .HasConstraintName("fk_dboenrollment_fee_petid");
        });

        modelBuilder.Entity<QuoteDboEnrollmentRequestSecondaryHospital>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_enrollmentrequest_secondaryhospital_id")
                .IsClustered(false);

            entity.ToTable("EnrollmentRequestSecondaryHospital");

            entity.HasIndex(e => e.EnrollmentRequestPetId, "ix_enrollmentrequest_secondaryhospital_enrollmentrequestpet_id");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Name).HasMaxLength(100);

            entity.HasOne(d => d.EnrollmentRequestPet)
                .WithMany(p => p.EnrollmentRequestSecondaryHospitals)
                .HasForeignKey(d => d.EnrollmentRequestPetId)
                .HasConstraintName("fk_enrollmentrequest_secondaryhospital_enrollmentrequestpet_id");
        });

        modelBuilder.Entity<QuoteDboEnrollmentRequestType>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_enrollmentrequesttype_id")
                .IsClustered(false);

            entity.ToTable("EnrollmentRequestType");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<QuoteDboExpiredOffer>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ExpiredOffer");

            entity.Property(e => e.AttributionData).IsRequired();

            entity.Property(e => e.EmailAddress)
                .IsRequired()
                .HasMaxLength(250);

            entity.Property(e => e.LastName).HasMaxLength(250);

            entity.Property(e => e.PetName)
                .IsRequired()
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<QuoteDboInactiveBreed>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dboinactivebreed_id")
                .IsClustered(false);

            entity.ToTable("InactiveBreed");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.NewName)
                .IsRequired()
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<QuoteDboIssuedCertificate>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dboissuedcertificate_id")
                .IsClustered(false);

            entity.ToTable("IssuedCertificate");

            entity.HasIndex(e => new { e.EmailAddress, e.PetName }, "ix_issuedcertificate_emailaddress_petname");

            entity.HasIndex(e => e.HospitalUniqueId, "ix_issuedcertificate_hospitaluniqueid");

            entity.HasIndex(e => e.IssuedCertificateTypeId, "ix_issuedcertificate_issuedcertificatetypeid");

            entity.HasIndex(e => e.OrganizationId, "ix_issuedcertificate_organizationid");

            entity.HasIndex(e => e.BreedPetCharacteristicId, "ix_issuedcertificate_petcharacteristicid");

            entity.HasIndex(e => e.PetPolicyId, "ix_issuedcertificate_petpolicyid");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Address1).HasMaxLength(250);

            entity.Property(e => e.Address2).HasMaxLength(250);

            entity.Property(e => e.AlternatePhoneNumber).HasMaxLength(20);

            entity.Property(e => e.AttendingDvm).HasMaxLength(255);

            entity.Property(e => e.City).HasMaxLength(250);

            entity.Property(e => e.EmailAddress)
                .IsRequired()
                .HasMaxLength(250);

            entity.Property(e => e.FirstName).HasMaxLength(250);

            entity.Property(e => e.IsoAlpha3CountryCode).HasMaxLength(3);

            entity.Property(e => e.LastName).HasMaxLength(250);

            entity.Property(e => e.PatientId).HasMaxLength(50);

            entity.Property(e => e.PetGender)
                .HasMaxLength(150)
                .IsUnicode(false);

            entity.Property(e => e.PetName)
                .IsRequired()
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.PetSpecies)
                .HasMaxLength(150)
                .IsUnicode(false);

            entity.Property(e => e.PostalCode).HasMaxLength(20);

            entity.Property(e => e.PrimaryPhoneNumber).HasMaxLength(20);

            entity.Property(e => e.PromoCode).HasMaxLength(250);

            entity.Property(e => e.SignedBy).HasMaxLength(255);

            entity.Property(e => e.Source)
                .IsRequired()
                .HasMaxLength(250);

            entity.Property(e => e.StateCode).HasMaxLength(3);

            entity.HasOne(d => d.IssuedCertificateType)
                .WithMany(p => p.IssuedCertificates)
                .HasForeignKey(d => d.IssuedCertificateTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_issuedcertificatetype_issuedcertificatetypeid");
        });

        modelBuilder.Entity<QuoteDboIssuedCertificateAttribution>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_issuedcertificateattribution_id")
                .IsClustered(false);

            entity.ToTable("IssuedCertificateAttribution");

            entity.HasIndex(e => new { e.IssuedCertificateId, e.AttributionTypeId }, "unq_issuedcertificateattribution_issuedcertificateid_attributiontypeid")
                .IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Data).IsRequired();

            entity.HasOne(d => d.AttributionType)
                .WithMany(p => p.IssuedCertificateAttributions)
                .HasForeignKey(d => d.AttributionTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_issuedcertificateattribution_attributiontypeid");

            entity.HasOne(d => d.IssuedCertificate)
                .WithMany(p => p.IssuedCertificateAttributions)
                .HasForeignKey(d => d.IssuedCertificateId)
                .HasConstraintName("fk_issuedcertificateattribution_issuedcertificateid");
        });

        modelBuilder.Entity<QuoteDboIssuedCertificateType>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_issuedcertificatetype_id")
                .IsClustered(false);

            entity.ToTable("IssuedCertificateType");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(500);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<QuoteDboPetCharacteristic>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dbopetcharacteristic_id")
                .IsClustered(false);

            entity.ToTable("PetCharacteristic");

            entity.HasIndex(e => e.Name, "ix_dbopetcharacteristic_name");

            entity.HasIndex(e => e.PetCharacteristicTypeId, "ix_dbopetcharacteristictype_id");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(250);

            entity.HasOne(d => d.PetCharacteristicType)
                .WithMany(p => p.PetCharacteristics)
                .HasForeignKey(d => d.PetCharacteristicTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_dbopetcharacteristic_dbopetcharacteristictype");
        });

        modelBuilder.Entity<QuoteDboPetCharacteristicType>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dbopetspecies_id")
                .IsClustered(false);

            entity.ToTable("PetCharacteristicType");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(250);
        });

        modelBuilder.Entity<QuoteDboQuote>(entity =>
        {
            entity.ToTable("Quote");

            entity.HasIndex(e => e.EmailAddress, "ix_quote_emailaddress");

            entity.HasIndex(e => e.ReferenceNumber, "ix_quote_referencenumber");

            entity.Property(e => e.Address1).HasMaxLength(250);

            entity.Property(e => e.Address2).HasMaxLength(250);

            entity.Property(e => e.AlternatePhoneNumber).HasMaxLength(20);

            entity.Property(e => e.CampaignCode).HasMaxLength(50);

            entity.Property(e => e.CampaignCodeReferenceNumber).HasMaxLength(50);

            entity.Property(e => e.City).HasMaxLength(250);

            entity.Property(e => e.EmailAddress).HasMaxLength(250);

            entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

            entity.Property(e => e.IsoAlpha3CountryCode)
                .HasMaxLength(3)
                .IsFixedLength(true);

            entity.Property(e => e.OwnerFirstName).HasMaxLength(250);

            entity.Property(e => e.OwnerLastName).HasMaxLength(250);

            entity.Property(e => e.Partner).HasMaxLength(250);

            entity.Property(e => e.PostalCode).HasMaxLength(20);

            entity.Property(e => e.PrimaryPhoneNumber).HasMaxLength(20);

            entity.Property(e => e.QuoteUrl).HasMaxLength(4000);

            entity.Property(e => e.ShortenedQuoteUrl).HasMaxLength(4000);

            entity.Property(e => e.Source).HasMaxLength(250);

            entity.Property(e => e.StateCode).HasMaxLength(3);

            entity.Property(e => e.Tag).HasMaxLength(100);

            entity.Property(e => e.WebSalesReferenceNumber).HasMaxLength(250);

            entity.HasOne(d => d.ParentQuote)
                .WithMany(p => p.InverseParentQuote)
                .HasForeignKey(d => d.ParentQuoteId)
                .HasConstraintName("fk_quote_quote_parentquoteid");
        });

        modelBuilder.Entity<QuoteDboQuotePet>(entity =>
        {
            entity.ToTable("QuotePet");

            entity.HasIndex(e => e.QuoteId, "ix_quotepet_quoteid");

            entity.Property(e => e.CampaignCode).HasMaxLength(50);

            entity.Property(e => e.CampaignCodeReferenceNumber).HasMaxLength(50);

            entity.Property(e => e.CoinsurancePercent).HasColumnType("decimal(19, 5)");

            entity.Property(e => e.Deductible).HasColumnType("smallmoney");

            entity.Property(e => e.Gender).HasMaxLength(250);

            entity.Property(e => e.Name).HasMaxLength(100);

            entity.Property(e => e.Premium).HasColumnType("smallmoney");

            entity.Property(e => e.Species).HasMaxLength(250);

            entity.HasOne(d => d.Quote)
                .WithMany(p => p.QuotePets)
                .HasForeignKey(d => d.QuoteId)
                .HasConstraintName("fk_quotepet_quote_id");
        });

        modelBuilder.Entity<QuoteDboQuoteSecondaryHospital>(entity =>
        {
            entity.ToTable("QuoteSecondaryHospital");

            entity.Property(e => e.Name).HasMaxLength(100);

            entity.HasOne(d => d.QuotePet)
                .WithMany(p => p.QuoteSecondaryHospitals)
                .HasForeignKey(d => d.QuotePetId)
                .HasConstraintName("fk_quote_secondaryhospital_pet_id");
        });

        modelBuilder.Entity<QuoteDboReferral>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dbo_referral_id")
                .IsClustered(false);

            entity.ToTable("Referral");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.IntId).ValueGeneratedOnAdd();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<QuoteDboSecondaryHospital>(entity =>
        {
            entity.ToTable("SecondaryHospital");

            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.EnrollmentRequestPet)
                .WithMany(p => p.SecondaryHospitals)
                .HasForeignKey(d => d.EnrollmentRequestPetId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_secondaryhospital_enrollmentrequestpet_id");

            entity.HasOne(d => d.QuotePet)
                .WithMany(p => p.SecondaryHospitals)
                .HasForeignKey(d => d.QuotePetId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_secondaryhospital_quotepet_id");
        });

        modelBuilder.Entity<QuoteDboSelectedPolicyOption>(entity =>
        {
            entity.ToTable("SelectedPolicyOption");

            entity.HasIndex(e => e.QuotePetId, "ix_selectedpolicyoption_quotepetid");

            entity.Property(e => e.Cost).HasColumnType("smallmoney");

            entity.Property(e => e.Name).HasMaxLength(100);

            entity.HasOne(d => d.QuotePet)
                .WithMany(p => p.SelectedPolicyOptions)
                .HasForeignKey(d => d.QuotePetId)
                .HasConstraintName("fk_selectedpolicyoption_quotepet");
        });

        modelBuilder.Entity<QuoteDboSelectedWorkingPet>(entity =>
        {
            entity.ToTable("SelectedWorkingPet");

            entity.HasIndex(e => e.QuotePetId, "ix_selectedworkingpet_quotepetid");

            entity.HasOne(d => d.QuotePet)
                .WithMany(p => p.SelectedWorkingPets)
                .HasForeignKey(d => d.QuotePetId)
                .HasConstraintName("fk_selectedworkingpet_quotepet");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

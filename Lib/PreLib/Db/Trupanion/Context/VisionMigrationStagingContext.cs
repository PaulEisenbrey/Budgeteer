using Microsoft.EntityFrameworkCore;
using Database.Trupanion.Entity.VisionMigration.Staging;
using Utilities.ConnectionStringManager.Base;
using Utilities.Constants.Enum;

namespace Database.Trupanion.Context;

public partial class VisionMigrationStagingContext : DbContext
{
    public VisionMigrationStagingContext()
    {
    }

    public VisionMigrationStagingContext(DbContextOptions<VisionMigrationStagingContext> options)
        : base(options)
    {
    }

    public virtual DbSet<VmStagingAlertNote> AlertNotes { get; set; }
    public virtual DbSet<VmStagingClaim> Claims { get; set; }
    public virtual DbSet<VmStagingClaimCondition> ClaimConditions { get; set; }
    public virtual DbSet<VmStagingClaimConditionLegacy> ClaimConditionLegacies { get; set; }
    public virtual DbSet<VmStagingClaimEmail> ClaimEmails { get; set; }
    public virtual DbSet<VmStagingClaimItem> ClaimItems { get; set; }
    public virtual DbSet<VmStagingClaimItemLegacy> ClaimItemLegacies { get; set; }
    public virtual DbSet<VmStagingClaimLegacy> ClaimLegacies { get; set; }
    public virtual DbSet<VmStagingClaimPayment> ClaimPayments { get; set; }
    public virtual DbSet<VmStagingClaimPaymentLegacy> ClaimPaymentLegacies { get; set; }
    public virtual DbSet<VmStagingClaimQueue> ClaimQueues { get; set; }
    public virtual DbSet<VmStagingClaimVersion> ClaimVersions { get; set; }
    public virtual DbSet<VmStagingClaimVersionQueue> ClaimVersionQueues { get; set; }
    public virtual DbSet<VmStagingCoverageSummary> CoverageSummaries { get; set; }
    public virtual DbSet<VmStagingCustomer> Customers { get; set; }
    public virtual DbSet<VmStagingCustomerAddress> CustomerAddresses { get; set; }
    public virtual DbSet<VmStagingCustomerQueue> CustomerQueues { get; set; }
    public virtual DbSet<VmStagingEligibleCondition> EligibleConditions { get; set; }
    public virtual DbSet<VmStagingFileQueue> FileQueues { get; set; }
    public virtual DbSet<VmStagingHospitalInvoiceLine> HospitalInvoiceLines { get; set; }
    public virtual DbSet<VmStagingInvoice> Invoices { get; set; }
    public virtual DbSet<VmStagingInvoiceFile> InvoiceFiles { get; set; }
    public virtual DbSet<VmStagingInvoiceLine2> InvoiceLine2s { get; set; }
    public virtual DbSet<VmStagingInvoiceMaybe> InvoiceMaybes { get; set; }
    public virtual DbSet<VmStagingLogError> LogErrors { get; set; }
    public virtual DbSet<VmStagingNote> Notes { get; set; }
    public virtual DbSet<VmStagingPaymentAccount> PaymentAccounts { get; set; }
    public virtual DbSet<VmStagingPaymentAttempt> PaymentAttempts { get; set; }
    public virtual DbSet<VmStagingPaymentInstruction> PaymentInstructions { get; set; }
    public virtual DbSet<VmStagingPaymentInstructionOld> PaymentInstructionOlds { get; set; }
    public virtual DbSet<VmStagingPet> Pets { get; set; }
    public virtual DbSet<VmStagingPetQueue> PetQueues { get; set; }
    public virtual DbSet<VmStagingPolicy> Policies { get; set; }
    public virtual DbSet<VmStagingPolicyCancellationReasonsKeyMap> PolicyCancellationReasonsKeyMaps { get; set; }
    public virtual DbSet<VmStagingPolicyDocumentMap> PolicyDocumentMaps { get; set; }
    public virtual DbSet<VmStagingPolicyTerm> PolicyTerms { get; set; }
    public virtual DbSet<VmStagingPreExistingCondition> PreExistingConditions { get; set; }
    public virtual DbSet<VmStagingPreExistingConditionFlat> PreExistingConditionFlats { get; set; }
    public virtual DbSet<VmStagingPreExistingConditionHead> PreExistingConditionHeads { get; set; }
    public virtual DbSet<VmStagingQuillInvoiceLine> QuillInvoiceLines { get; set; }
    public virtual DbSet<VmStagingSystemDeduction> SystemDeductions { get; set; }
    public virtual DbSet<VmStagingSystemDeductionLegacy> SystemDeductionLegacies { get; set; }
    public virtual DbSet<VmStagingUserDeduction> UserDeductions { get; set; }
    public virtual DbSet<VmStagingUserDeductionLegacy> UserDeductionLegacies { get; set; }
    public virtual DbSet<VmStagingUserMap> UserMaps { get; set; }

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

        modelBuilder.Entity<VmStagingAlertNote>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("AlertNote", "Staging");

            entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

            entity.Property(e => e.Details).IsRequired();

            entity.Property(e => e.Title)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.UpdatedDateTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<VmStagingClaim>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("Claim", "Staging");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

            entity.Property(e => e.DateOfDeath).HasColumnType("smalldatetime");

            entity.Property(e => e.DateOfLoss).HasColumnType("date");

            entity.Property(e => e.FnolDescription).HasMaxLength(2000);

            entity.Property(e => e.Reference).HasMaxLength(100);

            entity.Property(e => e.TotalPaid).HasColumnType("decimal(18, 2)");

            entity.Property(e => e.TreatmentEndDate).HasColumnType("date");

            entity.Property(e => e.TreatmentStartDate).HasColumnType("date");
        });

        modelBuilder.Entity<VmStagingClaimCondition>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ClaimCondition", "Staging");

            entity.Property(e => e.ManualRejectionReasonComment).HasMaxLength(2000);

            entity.Property(e => e.SuggestedAmount).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<VmStagingClaimConditionLegacy>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ClaimConditionLegacy", "Staging");

            entity.Property(e => e.ManualRejectionReasonComment).HasMaxLength(500);

            entity.Property(e => e.SuggestedAmount).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<VmStagingClaimEmail>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ClaimEmail", "Staging");

            entity.Property(e => e.ActionDateTime).HasColumnType("datetime");

            entity.Property(e => e.SearchField).HasMaxLength(255);

            entity.Property(e => e.Value).HasMaxLength(200);
        });

        modelBuilder.Entity<VmStagingClaimItem>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ClaimItem", "Staging");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

            entity.Property(e => e.IneligibleAmount).HasColumnType("decimal(18, 2)");

            entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");

            entity.Property(e => e.TreatmentEndDate).HasColumnType("smalldatetime");

            entity.Property(e => e.TreatmentStartDate).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<VmStagingClaimItemLegacy>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ClaimItemLegacy", "Staging");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

            entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");

            entity.Property(e => e.TreatmentEndDate).HasColumnType("smalldatetime");

            entity.Property(e => e.TreatmentStartDate).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<VmStagingClaimLegacy>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ClaimLegacy", "Staging");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

            entity.Property(e => e.DateOfLoss).HasColumnType("date");

            entity.Property(e => e.FnolDescription).HasMaxLength(2000);

            entity.Property(e => e.Reference).HasMaxLength(100);

            entity.Property(e => e.TotalPaid).HasColumnType("decimal(18, 2)");

            entity.Property(e => e.TreatmentEndDate).HasColumnType("date");

            entity.Property(e => e.TreatmentStartDate).HasColumnType("date");
        });

        modelBuilder.Entity<VmStagingClaimPayment>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ClaimPayment", "Staging");

            entity.Property(e => e.Comment).HasMaxLength(2000);

            entity.Property(e => e.Gross).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<VmStagingClaimPaymentLegacy>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ClaimPaymentLegacy", "Staging");

            entity.Property(e => e.Comment).HasMaxLength(2000);

            entity.Property(e => e.Gross).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<VmStagingClaimQueue>(entity =>
        {
            entity.HasKey(e => e.ClaimId)
                .HasName("pk_stagingclaimqueue_cid");

            entity.ToTable("ClaimQueue", "Staging");

            entity.Property(e => e.ClaimId).ValueGeneratedNever();
        });

        modelBuilder.Entity<VmStagingClaimVersion>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ClaimVersion", "Staging");

            entity.Property(e => e.AdjusterComment).IsUnicode(false);

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

            entity.Property(e => e.DateOfDeath).HasColumnType("smalldatetime");

            entity.Property(e => e.DateOfLoss).HasColumnType("date");

            entity.Property(e => e.FnolDescription)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.Reference).HasMaxLength(100);

            entity.Property(e => e.TotalPaid).HasColumnType("decimal(18, 2)");

            entity.Property(e => e.TreatmentEndDate).HasColumnType("date");

            entity.Property(e => e.TreatmentStartDate).HasColumnType("date");
        });

        modelBuilder.Entity<VmStagingClaimVersionQueue>(entity =>
        {
            entity.HasKey(e => new { e.ClaimId, e.AssessmentDataId })
                .HasName("pk_claimversionqueue_cid_adId");

            entity.ToTable("ClaimVersionQueue", "Staging");
        });

        modelBuilder.Entity<VmStagingCoverageSummary>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("CoverageSummary", "Staging");

            entity.Property(e => e.ActionDateTime).HasColumnType("datetime");

            entity.Property(e => e.ExtRef).HasMaxLength(30);

            entity.Property(e => e.FileName).HasMaxLength(200);

            entity.Property(e => e.SearchField).HasMaxLength(2000);

            entity.Property(e => e.Value).HasMaxLength(2000);
        });

        modelBuilder.Entity<VmStagingCustomer>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("Customer", "Staging");

            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FirstName).HasMaxLength(50);

            entity.Property(e => e.Language).HasMaxLength(50);

            entity.Property(e => e.LastName).HasMaxLength(50);

            entity.Property(e => e.MobileNumber)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VmStagingCustomerAddress>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("CustomerAddress", "Staging");

            entity.Property(e => e.Country).HasMaxLength(55);

            entity.Property(e => e.PostalCode).HasMaxLength(10);

            entity.Property(e => e.RegionCounty).HasMaxLength(30);

            entity.Property(e => e.TownCity).HasMaxLength(60);
        });

        modelBuilder.Entity<VmStagingCustomerQueue>(entity =>
        {
            entity.HasKey(e => e.OwnerId)
                .HasName("pk_stagingcustomerqueue_ownerid");

            entity.ToTable("CustomerQueue", "Staging");

            entity.Property(e => e.OwnerId).ValueGeneratedNever();
        });

        modelBuilder.Entity<VmStagingEligibleCondition>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EligibleCondition", "Staging");

            entity.Property(e => e.Comments).HasMaxLength(2000);

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            entity.Property(e => e.DiagnosisDate).HasColumnType("date");

            entity.Property(e => e.DocumentCommentary).HasMaxLength(2000);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<VmStagingFileQueue>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("FileQueue", "Staging");

            entity.Property(e => e.ExternalDocUrl).HasMaxLength(400);

            entity.Property(e => e.FileName)
                .IsRequired()
                .HasMaxLength(200);

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.Property(e => e.SearchField).HasMaxLength(2000);

            entity.Property(e => e.Value).HasMaxLength(2000);
        });

        modelBuilder.Entity<VmStagingHospitalInvoiceLine>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("HospitalInvoiceLine", "Staging");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

            entity.Property(e => e.Date).HasColumnType("datetime");

            entity.Property(e => e.Description).HasMaxLength(2000);

            entity.Property(e => e.PetName).IsUnicode(false);

            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<VmStagingInvoice>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("Invoice", "Staging");

            entity.Property(e => e.CustomerName).HasMaxLength(200);

            entity.Property(e => e.InvoiceDate).HasColumnType("smalldatetime");

            entity.Property(e => e.InvoiceNumber).HasMaxLength(64);

            entity.Property(e => e.OcrinvoiceId).HasColumnName("OCRInvoiceId");

            entity.Property(e => e.VendorName).HasMaxLength(64);
        });

        modelBuilder.Entity<VmStagingInvoiceFile>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("InvoiceFile", "Staging");

            entity.Property(e => e.CreateDate).HasColumnType("datetime");

            entity.Property(e => e.ExternalDocUrl).HasMaxLength(4000);

            entity.Property(e => e.FileName).HasMaxLength(200);
        });

        modelBuilder.Entity<VmStagingInvoiceLine2>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("InvoiceLine2", "Staging");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

            entity.Property(e => e.Date).HasColumnType("datetime");

            entity.Property(e => e.Description).HasMaxLength(2000);

            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<VmStagingInvoiceMaybe>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("Invoice_maybe", "Staging");

            entity.Property(e => e.CustomerName).HasMaxLength(200);

            entity.Property(e => e.InvoiceDate).HasColumnType("smalldatetime");

            entity.Property(e => e.InvoiceNumber).HasMaxLength(64);

            entity.Property(e => e.OcrinvoiceId).HasColumnName("OCRInvoiceId");

            entity.Property(e => e.VendorName).HasMaxLength(64);
        });

        modelBuilder.Entity<VmStagingLogError>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("LogError", "Staging");

            entity.Property(e => e.Error).HasMaxLength(200);

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.Property(e => e.MoreInfo).HasMaxLength(2000);
        });

        modelBuilder.Entity<VmStagingNote>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("Note", "Staging");

            entity.Property(e => e.Title).HasMaxLength(100);
        });

        modelBuilder.Entity<VmStagingPaymentAccount>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PaymentAccount", "Staging");

            entity.Property(e => e.AccountName).HasMaxLength(100);

            entity.Property(e => e.AccountNumber).HasMaxLength(17);

            entity.Property(e => e.BankName).HasMaxLength(100);

            entity.Property(e => e.Payee).HasMaxLength(100);

            entity.Property(e => e.SortCode).HasMaxLength(10);
        });

        modelBuilder.Entity<VmStagingPaymentAttempt>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PaymentAttempt", "Staging");

            entity.Property(e => e.AccountName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AccountNumber).HasMaxLength(10);

            entity.Property(e => e.BrandCode)
                .IsRequired()
                .HasMaxLength(6)
                .IsUnicode(false);

            entity.Property(e => e.ChequeAddress1)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ChequeAddress2)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ChequeAddressCity)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ChequeAddressRegion)
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.ChequeAddressee)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ChequeCountry)
                .HasMaxLength(4)
                .IsUnicode(false);

            entity.Property(e => e.ChequePostalCode)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GatewayReason).HasMaxLength(256);

            entity.Property(e => e.GatewayReasonCode).HasMaxLength(64);

            entity.Property(e => e.Gross).HasColumnType("decimal(18, 2)");

            entity.Property(e => e.InstitutionNumber).HasMaxLength(64);

            entity.Property(e => e.PaymentAttemptDateTime).HasColumnType("datetime");

            entity.Property(e => e.RoutingNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VmStagingPaymentInstruction>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PaymentInstruction", "Staging");

            entity.Property(e => e.AccountName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AccountNumber).HasMaxLength(10);

            entity.Property(e => e.BrandCode)
                .IsRequired()
                .HasMaxLength(6)
                .IsUnicode(false);

            entity.Property(e => e.ChequeAddress1)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ChequeAddress2)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ChequeAddressee)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ChequeCity)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ChequeCountry)
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.ChequePostalCode)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ChequeRegion)
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.DateTimeReceived).HasColumnType("datetime");

            entity.Property(e => e.DateTimeUpdated).HasColumnType("datetime");

            entity.Property(e => e.Gross).HasColumnType("decimal(18, 2)");

            entity.Property(e => e.PolicyId).HasMaxLength(40);

            entity.Property(e => e.SortCode)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TransactionDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<VmStagingPaymentInstructionOld>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PaymentInstruction_old", "Staging");

            entity.Property(e => e.AccountName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AccountNumber)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BrandCode)
                .IsRequired()
                .HasMaxLength(6)
                .IsUnicode(false);

            entity.Property(e => e.ChequeAddress1)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ChequeAddress2)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ChequeAddressee)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ChequeCity)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ChequeCountry)
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.ChequePostalCode)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ChequeRegion)
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.DateTimeReceived).HasColumnType("datetime");

            entity.Property(e => e.DateTimeUpdated).HasColumnType("datetime");

            entity.Property(e => e.Gross).HasColumnType("decimal(18, 2)");

            entity.Property(e => e.PolicyId)
                .IsRequired()
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SortCode)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TransactionDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<VmStagingPet>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("Pet", "Staging");

            entity.Property(e => e.BirthDate).HasColumnType("smalldatetime");

            entity.Property(e => e.DateOfDeath).HasColumnType("datetime");

            entity.Property(e => e.MicrochipNumber).HasMaxLength(100);

            entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

            entity.Property(e => e.Name).HasMaxLength(100);

            entity.Property(e => e.PurchaseAdoptionDate).HasColumnType("date");

            entity.Property(e => e.PurchasePrice).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<VmStagingPetQueue>(entity =>
        {
            entity.HasKey(e => e.PetId)
                .HasName("pk_stagingpetqueue_petid");

            entity.ToTable("PetQueue", "Staging");

            entity.Property(e => e.PetId).ValueGeneratedNever();
        });

        modelBuilder.Entity<VmStagingPolicy>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("Policy", "Staging");

            entity.Property(e => e.InceptionDate).HasColumnType("date");

            entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

            entity.Property(e => e.Premium).HasColumnType("numeric(18, 0)");

            entity.Property(e => e.PromoCode).HasMaxLength(50);

            entity.Property(e => e.Reference).HasMaxLength(100);

            entity.Property(e => e.TermsDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<VmStagingPolicyCancellationReasonsKeyMap>(entity =>
        {
            entity.HasKey(e => e.TrudatCancelReasonId)
                .HasName("pk_stagingPolicyCancellationReasonsKeyMap");

            entity.ToTable("PolicyCancellationReasonsKeyMap", "Staging");

            entity.Property(e => e.TrudatCancelReasonId).ValueGeneratedNever();

            entity.Property(e => e.PolicyLifecyclePolicyCancellationReasonsName)
                .IsRequired()
                .HasMaxLength(200);

            entity.Property(e => e.TrudatCancelReasonName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VmStagingPolicyDocumentMap>(entity =>
        {
            entity.ToTable("PolicyDocumentMap", "Staging");

            entity.Property(e => e.DocumentName).IsRequired();

            entity.Property(e => e.FilePath).IsRequired();

            entity.Property(e => e.PolicyPath).IsRequired();
        });

        modelBuilder.Entity<VmStagingPolicyTerm>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PolicyTerm", "Staging");

            entity.Property(e => e.EndDate).HasColumnType("date");

            entity.Property(e => e.ExtRef)
                .HasMaxLength(14)
                .IsUnicode(false);

            entity.Property(e => e.StartDate).HasColumnType("date");

            entity.Property(e => e.YearEndDate).HasColumnType("datetime");

            entity.Property(e => e.YearStartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<VmStagingPreExistingCondition>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PreExistingCondition", "Staging");

            entity.Property(e => e.Comments).HasMaxLength(2000);

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            entity.Property(e => e.DiagnosisDate).HasColumnType("date");

            entity.Property(e => e.DocumentCommentary).HasMaxLength(2000);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<VmStagingPreExistingConditionFlat>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PreExistingConditionFlat", "Staging");

            entity.Property(e => e.Comments).HasMaxLength(2000);

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            entity.Property(e => e.DiagnosisDate).HasColumnType("date");

            entity.Property(e => e.DocumentCommentary).HasMaxLength(2000);

            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<VmStagingPreExistingConditionHead>(entity =>
        {
            entity.ToTable("PreExistingConditionHead", "Staging");

            entity.Property(e => e.Comments).HasMaxLength(2000);

            entity.Property(e => e.DiagnosisDate).HasColumnType("date");

            entity.Property(e => e.DocumentCommentary).HasMaxLength(2000);

            entity.Property(e => e.ExtRef)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VmStagingQuillInvoiceLine>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("QuillInvoiceLine", "Staging");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

            entity.Property(e => e.Date).HasColumnType("datetime");

            entity.Property(e => e.Description).HasMaxLength(2000);

            entity.Property(e => e.PetName)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<VmStagingSystemDeduction>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SystemDeduction", "Staging");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

            entity.Property(e => e.DeductionType).HasMaxLength(128);
        });

        modelBuilder.Entity<VmStagingSystemDeductionLegacy>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SystemDeductionLegacy", "Staging");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

            entity.Property(e => e.DeductionType).HasMaxLength(128);
        });

        modelBuilder.Entity<VmStagingUserDeduction>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("UserDeduction", "Staging");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

            entity.Property(e => e.ExclusionGroupName)
                .IsRequired()
                .HasMaxLength(6)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VmStagingUserDeductionLegacy>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("UserDeductionLegacy", "Staging");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<VmStagingUserMap>(entity =>
        {
            entity.HasKey(e => e.LegacyUserId)
                .HasName("pk_stagingUserMap");

            entity.ToTable("UserMap", "Staging");

            entity.Property(e => e.LegacyUserId).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
using Microsoft.EntityFrameworkCore;
using Database.Trupanion.Entity.Billing.Dbo;
using Utilities.ConnectionStringManager.Base;
using Utilities.Constants.Enum;

namespace Database.Trupanion.Context;

public partial class BillingDboContext : DbContext
{
    public BillingDboContext()
    {
    }

    public BillingDboContext(DbContextOptions<BillingDboContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BillingDboAccount> Accounts { get; set; }
    public virtual DbSet<BillingDboAccountPolicyholder> AccountPolicyholders { get; set; }
    public virtual DbSet<BillingDboAccountType> AccountTypes { get; set; }
    public virtual DbSet<BillingDboBankAccount> BankAccounts { get; set; }
    public virtual DbSet<BillingDboBankAccountType> BankAccountTypes { get; set; }
    public virtual DbSet<BillingDboChargeType> ChargeTypes { get; set; }
    public virtual DbSet<BillingDboCharity> Charities { get; set; }
    public virtual DbSet<BillingDboCountry> Countries { get; set; }
    public virtual DbSet<BillingDboEntityIdToEntityType> EntityIdToEntityTypes { get; set; }
    public virtual DbSet<BillingDboExternalRequestLog> ExternalRequestLogs { get; set; }
    public virtual DbSet<BillingDboInvoiceTemplate> InvoiceTemplates { get; set; }
    public virtual DbSet<BillingDboJobRun> JobRuns { get; set; }
    public virtual DbSet<BillingDboJobType> JobTypes { get; set; }
    public virtual DbSet<BillingDboPartnerConfiguration> PartnerConfigurations { get; set; }
    public virtual DbSet<BillingDboPaymentMethodSnapshot> PaymentMethodSnapshots { get; set; }
    public virtual DbSet<BillingDboPaymentMethodType> PaymentMethodTypes { get; set; }
    public virtual DbSet<BillingDboPaymentReschedulingRequest> PaymentReschedulingRequests { get; set; }
    public virtual DbSet<BillingDboPaymentReschedulingRequestStatus> PaymentReschedulingRequestStatuses { get; set; }
    public virtual DbSet<BillingDboPendingAccount> PendingAccounts { get; set; }
    public virtual DbSet<BillingDboPendingPaymentMethod> PendingPaymentMethods { get; set; }
    public virtual DbSet<BillingDboPolicyholderLegacySetupFeePaid> PolicyholderLegacySetupFeePaids { get; set; }
    public virtual DbSet<BillingDboState> States { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(ConnectionString.TrupanionConnectionString(SqlDatabase.billing), options => options.EnableRetryOnFailure().CommandTimeout(60));
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<BillingDboAccount>(entity =>
        {
            entity.ToTable("Account");

            entity.HasIndex(e => e.PolicyGroupId, "IX_Account_PolicyGroupId");

            entity.HasIndex(e => new { e.AccountTypeId, e.PolicyGroupId }, "ix_account_accounttypeid_policygroupid")
                .IsUnique()
                .HasFilter("([PolicyGroupId] IS NOT NULL)");

            entity.HasIndex(e => e.PartyId, "ix_account_partyid")
                .IsUnique()
                .HasFilter("([PartyId] IS NOT NULL)");

            entity.HasIndex(e => e.PolicyId, "ix_account_policyid")
                .IsUnique()
                .HasFilter("([PolicyId] IS NOT NULL)");

            entity.HasIndex(e => e.ExternalId, "uk_account_externalid")
                .IsUnique();

            entity.Property(e => e.BillingPastDue).HasColumnType("date");

            entity.Property(e => e.BillingPastDueAmount).HasColumnType("smallmoney");

            entity.Property(e => e.ExternalId)
                .IsRequired()
                .HasMaxLength(40);

            entity.Property(e => e.InvoiceOwnerId).HasMaxLength(40);

            entity.Property(e => e.PaymentFailedDefaultPaymentMethodId).HasMaxLength(40);

            entity.HasOne(d => d.AccountType)
                .WithMany(p => p.Accounts)
                .HasForeignKey(d => d.AccountTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_account_accounttype");

            entity.HasOne(d => d.InvoiceOwner)
                .WithMany(p => p.InverseInvoiceOwner)
                .HasPrincipalKey(p => p.ExternalId)
                .HasForeignKey(d => d.InvoiceOwnerId)
                .HasConstraintName("fk_account_invoiceownerId");

            entity.HasOne(d => d.NonReferencedCreditMethodType)
                .WithMany(p => p.Accounts)
                .HasForeignKey(d => d.NonReferencedCreditMethodTypeId)
                .HasConstraintName("fk_account_paymentmethodtype");
        });

        modelBuilder.Entity<BillingDboAccountPolicyholder>(entity =>
        {
            entity.ToTable("AccountPolicyholder");

            entity.HasIndex(e => e.AccountId, "ix_accountpolicyholder_accountid");

            entity.HasIndex(e => e.AccountTypeId, "ix_accountpolicyholder_accounttypeid");

            entity.HasIndex(e => new { e.AccountId, e.PolicyholderId, e.PolicyholderUniqueId }, "uk_accountpolicyholder_acctid_polhid")
                .IsUnique();

            entity.HasIndex(e => new { e.AccountTypeId, e.PolicyholderId }, "uk_accountpolicyholder_accttypeid_polhid")
                .IsUnique();

            entity.HasOne(d => d.Account)
                .WithMany(p => p.AccountPolicyholders)
                .HasForeignKey(d => d.AccountId)
                .HasConstraintName("fk_accountpolicyholder_account");

            entity.HasOne(d => d.AccountType)
                .WithMany(p => p.AccountPolicyholders)
                .HasForeignKey(d => d.AccountTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_accountpolicyholder_accounttype");
        });

        modelBuilder.Entity<BillingDboAccountType>(entity =>
        {
            entity.ToTable("AccountType");

            entity.HasIndex(e => e.Name, "uk_accounttype_name")
                .IsUnique();

            entity.Property(e => e.ExternalId)
                .IsRequired()
                .HasMaxLength(10)
                .IsFixedLength(true);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(10)
                .IsFixedLength(true);
        });

        modelBuilder.Entity<BillingDboBankAccount>(entity =>
        {
            entity.ToTable("BankAccount");

            entity.HasIndex(e => e.AccountId, "uix_bankaccount_accountid")
                .IsUnique()
                .HasFilter("([AccountId] IS NOT NULL)");

            entity.HasIndex(e => e.Uniqueid, "uix_bankaccount_uniqueid")
                .IsUnique()
                .HasFilter("([UniqueId] IS NOT NULL)");

            entity.Property(e => e.AchAbaCode)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AchAccountName).HasMaxLength(250);

            entity.Property(e => e.AchAccountNumber)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AchAccountNumberLast4)
                .IsRequired()
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength(true);

            entity.Property(e => e.AchBankCode)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AchBankName)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.Uniqueid)
                .HasColumnName("uniqueid")
                .HasDefaultValueSql("(newid())");

            entity.HasOne(d => d.Account)
                .WithOne(p => p.BankAccount)
                .HasForeignKey<BillingDboBankAccount>(d => d.AccountId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_bankaccount_account");

            entity.HasOne(d => d.AchAccountType)
                .WithMany(p => p.BankAccounts)
                .HasForeignKey(d => d.AchAccountTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bankaccount_bankaccounttype");
        });

        modelBuilder.Entity<BillingDboBankAccountType>(entity =>
        {
            entity.ToTable("BankAccountType");

            entity.HasIndex(e => e.UniqueId, "ix_bankaccounttype_uid");

            entity.HasIndex(e => e.Name, "uk_bankaccounttype_name")
                .IsUnique();

            entity.HasIndex(e => e.UniqueId, "uk_bankaccounttype_uid")
                .IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(10);

            entity.Property(e => e.UniqueId).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<BillingDboChargeType>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_charetype_id")
                .IsClustered(false);

            entity.ToTable("ChargeType");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<BillingDboCharity>(entity =>
        {
            entity.ToTable("Charity");
        });

        modelBuilder.Entity<BillingDboCountry>(entity =>
        {
            entity.ToTable("Country");

            entity.Property(e => e.IsoAlpha3Code)
                .IsRequired()
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(32);
        });

        modelBuilder.Entity<BillingDboEntityIdToEntityType>(entity =>
        {
            entity.ToTable("EntityIdToEntityType");

            entity.HasIndex(e => new { e.EntityId, e.EntityTypeId }, "ix_entityidtoentitytype_entityid_entitytypeid")
                .IsUnique();
        });

        modelBuilder.Entity<BillingDboExternalRequestLog>(entity =>
        {
            entity.ToTable("ExternalRequestLog");

            entity.HasIndex(e => e.ObjectId, "IX_AccountExternalRequestLog_ObjectId");

            entity.Property(e => e.CreatedOn).HasDefaultValueSql("(getutcdate())");

            entity.Property(e => e.ObjectId)
                .IsRequired()
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Payload).IsRequired();
        });

        modelBuilder.Entity<BillingDboInvoiceTemplate>(entity =>
        {
            entity.ToTable("InvoiceTemplate");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('N/A')")
                .IsFixedLength(true);

            entity.Property(e => e.InvoiceTemplateId)
                .IsRequired()
                .HasMaxLength(40);

            entity.Property(e => e.TenantId).HasMaxLength(100);

            entity.HasOne(d => d.AccountType)
                .WithMany(p => p.InvoiceTemplates)
                .HasForeignKey(d => d.AccountTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_invoicetemplate_accounttype_id");
        });

        modelBuilder.Entity<BillingDboJobRun>(entity =>
        {
            entity.ToTable("JobRun");

            entity.Property(e => e.MachineName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BillingDboJobType>(entity =>
        {
            entity.ToTable("JobType");

            entity.HasIndex(e => e.Name, "uk_jobtype_name")
                .IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BillingDboPartnerConfiguration>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.TenantId })
                .HasName("pk_partner_id");

            entity.ToTable("PartnerConfiguration");

            entity.Property(e => e.TenantId)
                .HasMaxLength(100)
                .HasDefaultValueSql("('13408')");

            entity.Property(e => e.PaymentGatewayName)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<BillingDboPaymentMethodSnapshot>(entity =>
        {
            entity.ToTable("PaymentMethodSnapshot");

            entity.HasIndex(e => e.PaymentMethodId, "ix_paymentmethodsnapshot");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.AccountId)
                .IsRequired()
                .HasMaxLength(40);

            entity.Property(e => e.BankCity).HasMaxLength(70);

            entity.Property(e => e.BankCode).HasMaxLength(18);

            entity.Property(e => e.BankName).HasMaxLength(80);

            entity.Property(e => e.BankPostalCode).HasMaxLength(20);

            entity.Property(e => e.BankStreetAddress).HasMaxLength(60);

            entity.Property(e => e.BankTransferAccountName).HasMaxLength(60);

            entity.Property(e => e.BankTransferAccountNumber).HasMaxLength(30);

            entity.Property(e => e.BankTransferAccountNumberLast4)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength(true);

            entity.Property(e => e.City).HasMaxLength(80);

            entity.Property(e => e.Country).HasMaxLength(50);

            entity.Property(e => e.FirstName).HasMaxLength(30);

            entity.Property(e => e.LastName).HasMaxLength(70);

            entity.Property(e => e.PaymentMethodId)
                .IsRequired()
                .HasMaxLength(40);

            entity.Property(e => e.PostalCode).HasMaxLength(20);

            entity.Property(e => e.State).HasMaxLength(70);

            entity.Property(e => e.StreetAddress).HasMaxLength(100);

            entity.Property(e => e.Type)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Account)
                .WithMany(p => p.PaymentMethodSnapshots)
                .HasPrincipalKey(p => p.ExternalId)
                .HasForeignKey(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_paymentmethodsnaphot_account");
        });

        modelBuilder.Entity<BillingDboPaymentMethodType>(entity =>
        {
            entity.ToTable("PaymentMethodType");

            entity.HasIndex(e => e.UniqueId, "uk_paymentmethodtype_uid")
                .IsUnique();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.UniqueId).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<BillingDboPaymentReschedulingRequest>(entity =>
        {
            entity.ToTable("PaymentReschedulingRequest");

            entity.HasIndex(e => e.CreatedOn, "IX_PaymentReschedulingRequest_ReceivedOn");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");

            entity.Property(e => e.OriginalReceivedOn).HasColumnType("datetime");

            entity.Property(e => e.RequestedDate).HasColumnType("date");

            entity.Property(e => e.RescheduledOn).HasColumnType("datetime");

            entity.HasOne(d => d.Account)
                .WithMany(p => p.PaymentReschedulingRequests)
                .HasForeignKey(d => d.AccountId)
                .HasConstraintName("fk_paymentreschedulingrequest_account");

            entity.HasOne(d => d.StatusNavigation)
                .WithMany(p => p.PaymentReschedulingRequests)
                .HasForeignKey(d => d.Status)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_paymentreschedulingrequest_paymentreschedulingrequeststatus");
        });

        modelBuilder.Entity<BillingDboPaymentReschedulingRequestStatus>(entity =>
        {
            entity.ToTable("PaymentReschedulingRequestStatus");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BillingDboPendingAccount>(entity =>
        {
            entity.ToTable("PendingAccount");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Payload).IsRequired();
        });

        modelBuilder.Entity<BillingDboPendingPaymentMethod>(entity =>
        {
            entity.ToTable("PendingPaymentMethod");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.AccountId).HasMaxLength(40);

            entity.Property(e => e.AccountName).HasMaxLength(100);

            entity.Property(e => e.BankAccountNumber).HasMaxLength(50);

            entity.Property(e => e.BankAccountNumberLast4)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength(true);

            entity.Property(e => e.BankCity).HasMaxLength(70);

            entity.Property(e => e.BankCode).HasMaxLength(18);

            entity.Property(e => e.BankName).HasMaxLength(100);

            entity.Property(e => e.BankPostalCode).HasMaxLength(20);

            entity.Property(e => e.BankRoutingNumber)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.BankStreetAddress).HasMaxLength(60);

            entity.Property(e => e.City).HasMaxLength(80);

            entity.Property(e => e.Country).HasMaxLength(50);

            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength(true);

            entity.Property(e => e.FirstName).HasMaxLength(30);

            entity.Property(e => e.LastName).HasMaxLength(70);

            entity.Property(e => e.PostalCode).HasMaxLength(20);

            entity.Property(e => e.SecondTokenId).HasMaxLength(255);

            entity.Property(e => e.State).HasMaxLength(70);

            entity.Property(e => e.StreetAddress).HasMaxLength(100);

            entity.Property(e => e.TokenId).HasMaxLength(255);

            entity.HasOne(d => d.BankAccountType)
                .WithMany(p => p.PendingPaymentMethods)
                .HasPrincipalKey(p => p.UniqueId)
                .HasForeignKey(d => d.BankAccountTypeId)
                .HasConstraintName("fk_pendingpaymentmethod_bankaccounttype");

            entity.HasOne(d => d.PaymentMethodType)
                .WithMany(p => p.PendingPaymentMethods)
                .HasPrincipalKey(p => p.UniqueId)
                .HasForeignKey(d => d.PaymentMethodTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pendingpaymentmethod_paymentmethodtype");
        });

        modelBuilder.Entity<BillingDboPolicyholderLegacySetupFeePaid>(entity =>
        {
            entity.ToTable("PolicyholderLegacySetupFeePaid");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<BillingDboState>(entity =>
        {
            entity.ToTable("State");

            entity.Property(e => e.Code)
                .IsRequired()
                .HasMaxLength(3);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(40);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
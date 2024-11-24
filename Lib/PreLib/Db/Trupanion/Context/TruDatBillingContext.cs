using Microsoft.EntityFrameworkCore;
using Database.Trupanion.Entity.TruDat.Claim;
using Utilities.ConnectionStringManager.Base;
using Utilities.Constants.Enum;

namespace Database.Trupanion.Context;

public partial class TruDatBillingContext : DbContext
{
    public TruDatBillingContext()
    {
    }

    public TruDatBillingContext(DbContextOptions<TruDatBillingContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TruDatBillingAmazonBillingAgreement> AmazonBillingAgreements { get; set; }
    public virtual DbSet<TruDatBillingAmazonWalletPayment> AmazonWalletPayments { get; set; }
    public virtual DbSet<TruDatBillingAssociateBankAccount> AssociateBankAccounts { get; set; }
    public virtual DbSet<TruDatBillingBillingCalendar> BillingCalendars { get; set; }
    public virtual DbSet<TruDatBillingBillingDateChangeLog> BillingDateChangeLogs { get; set; }
    public virtual DbSet<TruDatBillingClaimPayment> ClaimPayments { get; set; }
    public virtual DbSet<TruDatBillingClinicBankAccount> ClinicBankAccounts { get; set; }
    public virtual DbSet<TruDatBillingCorporateBankAccount> CorporateBankAccounts { get; set; }
    public virtual DbSet<TruDatBillingCorporateCard> CorporateCards { get; set; }
    public virtual DbSet<TruDatBillingCreditCard> CreditCards { get; set; }
    public virtual DbSet<TruDatBillingDiscount> Discounts { get; set; }
    public virtual DbSet<TruDatBillingDiscountApplication> DiscountApplications { get; set; }
    public virtual DbSet<TruDatBillingDiscountEngine> DiscountEngines { get; set; }
    public virtual DbSet<TruDatBillingDiscountModificationType> DiscountModificationTypes { get; set; }
    public virtual DbSet<TruDatBillingDiscountType> DiscountTypes { get; set; }
    public virtual DbSet<TruDatBillingHsbc> Hsbcs { get; set; }
    public virtual DbSet<TruDatBillingHsbcBilling> HsbcBillings { get; set; }
    public virtual DbSet<TruDatBillingHsbcLegacy> HsbcLegacies { get; set; }
    public virtual DbSet<TruDatBillingItem> Items { get; set; }
    public virtual DbSet<TruDatBillingOrder> Orders { get; set; }
    public virtual DbSet<TruDatBillingOrderItem> OrderItems { get; set; }
    public virtual DbSet<TruDatBillingOrderItemDiscount> OrderItemDiscounts { get; set; }
    public virtual DbSet<TruDatBillingOrderItemDiscount2> OrderItemDiscount2s { get; set; }
    public virtual DbSet<TruDatBillingOrderItemTaxBreakdown> OrderItemTaxBreakdowns { get; set; }
    public virtual DbSet<TruDatBillingOwnerInitialOrder> OwnerInitialOrders { get; set; }
    public virtual DbSet<TruDatBillingOwnerPastDue> OwnerPastDues { get; set; }
    public virtual DbSet<TruDatBillingOwnerWaiveFee> OwnerWaiveFees { get; set; }
    public virtual DbSet<TruDatBillingPaymentAttempt> PaymentAttempts { get; set; }
    public virtual DbSet<TruDatBillingPaymentAttemptOrder> PaymentAttemptOrders { get; set; }
    public virtual DbSet<TruDatBillingPaymentMethod> PaymentMethods { get; set; }
    public virtual DbSet<TruDatBillingPetPolicyInitialFullOrder> PetPolicyInitialFullOrders { get; set; }
    public virtual DbSet<TruDatBillingPetPolicyInitialProrateOrder> PetPolicyInitialProrateOrders { get; set; }
    public virtual DbSet<TruDatBillingPetPolicyOrderItem> PetPolicyOrderItems { get; set; }
    public virtual DbSet<TruDatBillingRefund> Refunds { get; set; }
    public virtual DbSet<TruDatBillingRefundItem> RefundItems { get; set; }
    public virtual DbSet<TruDatBillingSetUpFee> SetUpFees { get; set; }
    public virtual DbSet<TruDatBillingTaxApplication> TaxApplications { get; set; }
    public virtual DbSet<TruDatBillingTaxRate> TaxRates { get; set; }
    public virtual DbSet<TruDatBillingWellsFargoErrorCode> WellsFargoErrorCodes { get; set; }

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

        modelBuilder.Entity<TruDatBillingAmazonBillingAgreement>(entity =>
        {
            entity.ToTable("AmazonBillingAgreement", "Billing");

            entity.HasIndex(e => e.OwnerId, "FK_OwnerId")
                .IsUnique();

            entity.Property(e => e.BillingAgreementId)
                .IsRequired()
                .HasMaxLength(32)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatBillingAmazonWalletPayment>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("AmazonWalletPayments", "Billing");

            entity.Property(e => e.BillingAgreementId)
                .IsRequired()
                .HasMaxLength(32)
                .IsUnicode(false);

            entity.Property(e => e.Total).HasColumnType("smallmoney");
        });

        modelBuilder.Entity<TruDatBillingAssociateBankAccount>(entity =>
        {
            entity.HasKey(e => e.AssociateAccountId)
                .HasName("pk_billingassociatebankaccount_caid");

            entity.ToTable("AssociateBankAccount", "Billing");

            entity.Property(e => e.AssociateAccountId).ValueGeneratedNever();

            entity.Property(e => e.AccountNumber)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AccountNumberLast4)
                .IsRequired()
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength(true);

            entity.Property(e => e.BankCode)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BankName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.TransitNumber)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TruDatBillingBillingCalendar>(entity =>
        {
            entity.ToTable("BillingCalendar", "Billing");

            entity.Property(e => e.Date).HasColumnType("date");
        });

        modelBuilder.Entity<TruDatBillingBillingDateChangeLog>(entity =>
        {
            entity.ToTable("BillingDateChangeLog", "Billing");

            entity.HasIndex(e => new { e.OwnerId, e.ProrateOrderId }, "ix_billingbillingdatechangelog_oid_ord");

            entity.HasIndex(e => e.ProrateOrderId, "ix_billingbillingdatechangelog_ord");

            entity.Property(e => e.ChangeDate)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TruDatBillingClaimPayment>(entity =>
        {
            entity.ToTable("ClaimPayments", "Billing");

            entity.HasIndex(e => e.AssessmentDataId, "ix_billingclaimpayments_aid");

            entity.HasIndex(e => new { e.StatusId, e.EntityTypeId }, "ix_billingclaimpayments_statusid_entitytypeid");

            entity.HasIndex(e => e.ClaimId, "ix_claimpaymentsclaim");

            entity.HasIndex(e => new { e.ClaimId, e.OwnerId, e.StatusId }, "ix_claimpaymentsclaim_statusId");

            entity.HasIndex(e => new { e.EntityTypeId, e.Inserted }, "ix_enttid_ins_id");

            entity.HasIndex(e => e.OwnerId, "ix_ownid_id_pd_cid_pmid_a_ins_upd_chid_assid");

            entity.HasIndex(e => new { e.StatusId, e.EntityTypeId, e.Inserted }, "ix_statid_enttid_ins_id");

            entity.Property(e => e.Amount).HasColumnType("smallmoney");

            entity.Property(e => e.AuditFlagName)
                .HasMaxLength(1012)
                .IsUnicode(false);

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.ProcessDate).HasColumnType("datetime");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.PaymentMethod)
                .WithMany(p => p.ClaimPayments)
                .HasForeignKey(d => d.PaymentMethodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_claimpayments_paymentmethod");
        });

        modelBuilder.Entity<TruDatBillingClinicBankAccount>(entity =>
        {
            entity.HasKey(e => e.ClinicId)
                .HasName("pk_billingclinicbankaccount_cid");

            entity.ToTable("ClinicBankAccount", "Billing");

            entity.Property(e => e.ClinicId).ValueGeneratedNever();

            entity.Property(e => e.AccountNumber)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AccountNumberLast4)
                .IsRequired()
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength(true);

            entity.Property(e => e.AccountType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.BankCode)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BankName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.NameOnAccount)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TransitNumber)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TruDatBillingCorporateBankAccount>(entity =>
        {
            entity.HasKey(e => e.CorporateAccountId)
                .HasName("pk_billingcorporatebankaccount_caid");

            entity.ToTable("CorporateBankAccount", "Billing");

            entity.Property(e => e.CorporateAccountId).ValueGeneratedNever();

            entity.Property(e => e.AccountNumber)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AccountNumberLast4)
                .IsRequired()
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength(true);

            entity.Property(e => e.AccountType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.BankCode)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BankName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.NameOnAccount)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TransitNumber)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TruDatBillingCorporateCard>(entity =>
        {
            entity.HasKey(e => e.CorporateAccountId)
                .HasName("pk_billingcorporatecard_caid");

            entity.ToTable("CorporateCard", "Billing");

            entity.Property(e => e.CorporateAccountId).ValueGeneratedNever();

            entity.Property(e => e.Ccexpiration)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CCExpiration");

            entity.Property(e => e.Ccname)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CCName");

            entity.Property(e => e.Ccnumber)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CCNumber");

            entity.Property(e => e.CcnumberLast4)
                .IsRequired()
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("CCNumberLast4")
                .IsFixedLength(true);

            entity.Property(e => e.Cctype)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CCType");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TruDatBillingCreditCard>(entity =>
        {
            entity.HasKey(e => e.OwnerId)
                .HasName("pk_billingcreditcard_oid");

            entity.ToTable("CreditCard", "Billing");

            entity.Property(e => e.OwnerId).ValueGeneratedNever();

            entity.Property(e => e.Ccexpiration)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CCExpiration");

            entity.Property(e => e.Ccname)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CCName");

            entity.Property(e => e.Ccnumber)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CCNumber");

            entity.Property(e => e.CcnumberLast4)
                .IsRequired()
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("CCNumberLast4")
                .IsFixedLength(true);

            entity.Property(e => e.Cctype)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CCType");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.NextExpiration)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TruDatBillingDiscount>(entity =>
        {
            entity.ToTable("Discount", "Billing");

            entity.HasIndex(e => e.Name, "uk_billingdiscount_nme")
                .IsUnique();

            entity.Property(e => e.DefaultDiscountValue).HasColumnType("numeric(9, 4)");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.DiscountModificationType)
                .WithMany(p => p.Discounts)
                .HasForeignKey(d => d.DiscountModificationTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_billingdiscountmodificationtype_billingdiscount");

            entity.HasOne(d => d.DiscountType)
                .WithMany(p => p.Discounts)
                .HasForeignKey(d => d.DiscountTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_billingdiscounttype_billingdiscount");
        });

        modelBuilder.Entity<TruDatBillingDiscountApplication>(entity =>
        {
            entity.ToTable("DiscountApplication", "Billing");

            entity.HasIndex(e => new { e.DiscountId, e.EntityId, e.DiscountValue }, "ix_billingdiscountapplication_did_eid");

            entity.HasIndex(e => new { e.EntityId, e.DiscountId, e.DiscountValue }, "ix_billingdiscountapplication_eid_did");

            entity.Property(e => e.DiscountValue).HasColumnType("numeric(9, 4)");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Discount)
                .WithMany(p => p.DiscountApplications)
                .HasForeignKey(d => d.DiscountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_billingdiscount_billingdiscountapplication");
        });

        modelBuilder.Entity<TruDatBillingDiscountEngine>(entity =>
        {
            entity.HasKey(e => new { e.DiscountId, e.EngineId })
                .HasName("pk_billingdiscountcountry_did_eid");

            entity.ToTable("DiscountEngine", "Billing");

            entity.HasIndex(e => new { e.EngineId, e.DiscountId }, "ix_discountcountry_eid_did");

            entity.HasOne(d => d.Discount)
                .WithMany(p => p.DiscountEngines)
                .HasForeignKey(d => d.DiscountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_billingdiscount_billingdiscountcountry");
        });

        modelBuilder.Entity<TruDatBillingDiscountModificationType>(entity =>
        {
            entity.ToTable("DiscountModificationType", "Billing");

            entity.HasIndex(e => e.Name, "uk_billingdiscountmodificationtype_nme")
                .IsUnique();

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TruDatBillingDiscountType>(entity =>
        {
            entity.ToTable("DiscountType", "Billing");

            entity.HasIndex(e => e.Name, "uk_billingdiscounttype_nme")
                .IsUnique();

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TruDatBillingHsbc>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("HSBC", "Billing");

            entity.Property(e => e.AccountNumber)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AccountNumberLast4)
                .IsRequired()
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength(true);

            entity.Property(e => e.AccountType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.BankCode)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BankName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.NameOnAccount)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.TransitNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatBillingHsbcBilling>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("HSBC_Billing", "Billing");

            entity.Property(e => e.AccountNumber)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AccountNumberLast4)
                .IsRequired()
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength(true);

            entity.Property(e => e.AccountType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.BankCode)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BankName)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.NameOnAccount).HasMaxLength(250);

            entity.Property(e => e.TransitNumber)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatBillingHsbcLegacy>(entity =>
        {
            entity.HasKey(e => e.OwnerId)
                .HasName("pk_billinghsbc_oid");

            entity.ToTable("HSBC_Legacy", "Billing");

            entity.Property(e => e.OwnerId).ValueGeneratedNever();

            entity.Property(e => e.AccountNumber)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AccountNumberLast4)
                .IsRequired()
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength(true);

            entity.Property(e => e.AccountType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.BankCode)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BankName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.NameOnAccount)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.TransitNumber)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TruDatBillingItem>(entity =>
        {
            entity.ToTable("Item", "Billing");

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

        modelBuilder.Entity<TruDatBillingOrder>(entity =>
        {
            entity.ToTable("Orders", "Billing");

            entity.HasIndex(e => new { e.OwnerId, e.BillingDate, e.StatusId }, "ix_billingorders_oid_bdt_sid");

            entity.HasIndex(e => new { e.OwnerId, e.ScheduledPaymentDate }, "ix_billingorders_oid_sd");

            entity.HasIndex(e => new { e.OwnerId, e.StatusId, e.BillingDate }, "ix_billingorders_oid_sid_bdt");

            entity.HasIndex(e => e.StatusId, "ix_billingorders_sid_id");

            entity.HasIndex(e => e.Inserted, "ix_orders_inserted");

            entity.Property(e => e.BillingDate).HasColumnType("datetime");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.ScheduledPaymentDate).HasColumnType("datetime");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TruDatBillingOrderItem>(entity =>
        {
            entity.ToTable("OrderItem", "Billing");

            entity.HasIndex(e => e.ItemId, "ix_billingorderitem_iid");

            entity.HasIndex(e => new { e.PetPolicyId, e.OrderId, e.ItemId }, "ix_billingorderitem_oid_oid_iid");

            entity.HasIndex(e => new { e.OrderId, e.ItemId }, "ix_billingorderitem_rid_iid");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Subtotal).HasColumnType("smallmoney");

            entity.Property(e => e.Taxtotal).HasColumnType("smallmoney");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Item)
                .WithMany(p => p.OrderItems)
                .HasForeignKey(d => d.ItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_billingitem_billingorderitem");

            entity.HasOne(d => d.Order)
                .WithMany(p => p.OrderItems)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("fk_billingorders_billingorderitem");
        });

        modelBuilder.Entity<TruDatBillingOrderItemDiscount>(entity =>
        {
            entity.ToTable("OrderItemDiscount", "Billing");

            entity.HasIndex(e => new { e.OrderItemId, e.DiscountId }, "uk_billingorderitemdiscount_oid_did")
                .IsUnique();

            entity.Property(e => e.DiscountTax).HasColumnType("smallmoney");

            entity.Property(e => e.DiscountValue).HasColumnType("smallmoney");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Discount)
                .WithMany(p => p.OrderItemDiscounts)
                .HasForeignKey(d => d.DiscountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_billingdiscount_billingorderitemdiscount");

            entity.HasOne(d => d.OrderItem)
                .WithMany(p => p.OrderItemDiscounts)
                .HasForeignKey(d => d.OrderItemId)
                .HasConstraintName("fk_billingorderitem_billingorderitemdiscount");
        });

        modelBuilder.Entity<TruDatBillingOrderItemDiscount2>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("OrderItemDiscount2", "Billing");

            entity.Property(e => e.DiscountTax).HasColumnType("smallmoney");

            entity.Property(e => e.DiscountValue).HasColumnType("smallmoney");

            entity.Property(e => e.Inserted).HasColumnType("datetime");

            entity.Property(e => e.Updated).HasColumnType("datetime");
        });

        modelBuilder.Entity<TruDatBillingOrderItemTaxBreakdown>(entity =>
        {
            entity.ToTable("OrderItemTaxBreakdown", "Billing");

            entity.HasIndex(e => e.TaxRateId, "ix_billingorderitemtaxbreakdown_tid");

            entity.HasIndex(e => new { e.OrderItemId, e.TaxRateId }, "uk_billingorderitemtaxbreakdown_oiid_tid")
                .IsUnique();

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.TaxAmount).HasColumnType("smallmoney");

            entity.Property(e => e.TaxPercentage).HasColumnType("numeric(6, 4)");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.OrderItem)
                .WithMany(p => p.OrderItemTaxBreakdowns)
                .HasForeignKey(d => d.OrderItemId)
                .HasConstraintName("fk_billingorderitem_billingorderitemtaxbreakdown");

            entity.HasOne(d => d.TaxRate)
                .WithMany(p => p.OrderItemTaxBreakdowns)
                .HasForeignKey(d => d.TaxRateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_billingtaxrate_billingorderitemtaxbreakdown");
        });

        modelBuilder.Entity<TruDatBillingOwnerInitialOrder>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OwnerInitialOrder", "Billing");
        });

        modelBuilder.Entity<TruDatBillingOwnerPastDue>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OwnerPastDue", "Billing");

            entity.Property(e => e.AmountDue).HasColumnType("money");

            entity.Property(e => e.BillingDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TruDatBillingOwnerWaiveFee>(entity =>
        {
            entity.HasKey(e => e.OwnerId)
                .HasName("pk_billingownerwaivefee_oid");

            entity.ToTable("OwnerWaiveFee", "Billing");

            entity.Property(e => e.OwnerId).ValueGeneratedNever();

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TruDatBillingPaymentAttempt>(entity =>
        {
            entity.ToTable("PaymentAttempt", "Billing");

            entity.HasIndex(e => new { e.StatusId, e.Inserted }, "ix_billingpaymentattempt_ins_st");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Message)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.PaymentAmount).HasColumnType("smallmoney");

            entity.Property(e => e.RefNum)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.PaymentMethod)
                .WithMany(p => p.PaymentAttempts)
                .HasForeignKey(d => d.PaymentMethodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_billingpaymentmethod_billingpaymentattempt");
        });

        modelBuilder.Entity<TruDatBillingPaymentAttemptOrder>(entity =>
        {
            entity.HasKey(e => new { e.PaymentAttemptId, e.OrderId })
                .HasName("pk_paymentattemptorder_pid_oid");

            entity.ToTable("PaymentAttemptOrder", "Billing");

            entity.HasIndex(e => new { e.OrderId, e.PaymentAttemptId }, "ix_billingpaymentattempt_oid_paid");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.PaymentAmount).HasColumnType("smallmoney");

            entity.Property(e => e.PaymentMethodLast4)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength(true);

            entity.HasOne(d => d.Order)
                .WithMany(p => p.PaymentAttemptOrders)
                .HasForeignKey(d => d.OrderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_billingorder_billingpaymentattemptorder");

            entity.HasOne(d => d.PaymentAttempt)
                .WithMany(p => p.PaymentAttemptOrders)
                .HasForeignKey(d => d.PaymentAttemptId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_billingpaymentattempt_billingpaymentattemptorder");
        });

        modelBuilder.Entity<TruDatBillingPaymentMethod>(entity =>
        {
            entity.ToTable("PaymentMethod", "Billing");

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

        modelBuilder.Entity<TruDatBillingPetPolicyInitialFullOrder>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PetPolicyInitialFullOrder", "Billing");
        });

        modelBuilder.Entity<TruDatBillingPetPolicyInitialProrateOrder>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PetPolicyInitialProrateOrder", "Billing");
        });

        modelBuilder.Entity<TruDatBillingPetPolicyOrderItem>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PetPolicyOrderItem", "Billing");

            entity.Property(e => e.BillingDate).HasColumnType("datetime");

            entity.Property(e => e.Subtotal).HasColumnType("smallmoney");

            entity.Property(e => e.Taxtotal).HasColumnType("smallmoney");
        });

        modelBuilder.Entity<TruDatBillingRefund>(entity =>
        {
            entity.ToTable("Refund", "Billing");

            entity.HasIndex(e => e.OwnerId, "ix_billingrefund_ownerid");

            entity.HasIndex(e => new { e.OwnerId, e.StatusId }, "ix_billingrefund_ownerid_statusid");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.RefundDate).HasColumnType("datetime");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TruDatBillingRefundItem>(entity =>
        {
            entity.ToTable("RefundItem", "Billing");

            entity.HasIndex(e => e.OrderItemId, "ix_billingrefunditem_orderitemid");

            entity.HasIndex(e => new { e.RefundId, e.OrderItemId }, "ix_billingrefunditem_refundid_orderid");

            entity.Property(e => e.Amount).HasColumnType("smallmoney");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.OrderItem)
                .WithMany(p => p.RefundItems)
                .HasForeignKey(d => d.OrderItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_refunditem_prderitem");

            entity.HasOne(d => d.Refund)
                .WithMany(p => p.RefundItems)
                .HasForeignKey(d => d.RefundId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_refunditem_refund");
        });

        modelBuilder.Entity<TruDatBillingSetUpFee>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("SetUpFee", "Billing");

            entity.Property(e => e.Csrdiscount)
                .HasColumnType("smallmoney")
                .HasColumnName("CSRDiscount");

            entity.Property(e => e.Fee).HasColumnType("smallmoney");

            entity.Property(e => e.WebDiscount).HasColumnType("numeric(15, 4)");
        });

        modelBuilder.Entity<TruDatBillingTaxApplication>(entity =>
        {
            entity.ToTable("TaxApplication", "Billing");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatBillingTaxRate>(entity =>
        {
            entity.ToTable("TaxRate", "Billing");

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Rate).HasColumnType("numeric(6, 4)");

            entity.Property(e => e.TaxDesc)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.TaxApplication)
                .WithMany(p => p.TaxRates)
                .HasForeignKey(d => d.TaxApplicationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_billingtaxapplication_billingtaxrate");
        });

        modelBuilder.Entity<TruDatBillingWellsFargoErrorCode>(entity =>
        {
            entity.ToTable("WellsFargoErrorCode", "Billing");

            entity.HasIndex(e => e.Code, "uk_wellsfargoerrorcode_code")
                .IsUnique();

            entity.Property(e => e.Code)
                .IsRequired()
                .HasMaxLength(4)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(1000)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
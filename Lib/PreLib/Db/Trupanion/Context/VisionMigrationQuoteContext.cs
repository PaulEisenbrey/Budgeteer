using Microsoft.EntityFrameworkCore;
using Database.Trupanion.Entity.VisionMigration.Quote;
using Utilities.ConnectionStringManager.Base;
using Utilities.Constants.Enum;

namespace Database.Trupanion.Context;

public partial class VisionMigrationQuoteContext : DbContext
{
    public VisionMigrationQuoteContext()
    {
    }

    public VisionMigrationQuoteContext(DbContextOptions<VisionMigrationQuoteContext> options)
        : base(options)
    {
    }

    public virtual DbSet<VmQuoteBasket> Baskets { get; set; }
    public virtual DbSet<VmQuoteBasketPetDatum> BasketPetData { get; set; }
    public virtual DbSet<VmQuoteBasketPetProductDatum> BasketPetProductData { get; set; }
    public virtual DbSet<VmQuoteBasketPetProductDetailDatum> BasketPetProductDetailData { get; set; }
    public virtual DbSet<VmQuoteFinancialsDatum> FinancialsData { get; set; }
    public virtual DbSet<VmQuotePetQuoteSelectedProduct> PetQuoteSelectedProducts { get; set; }
    public virtual DbSet<VmQuotePricing> Pricings { get; set; }
    public virtual DbSet<VmQuotePricingPetDatum> PricingPetData { get; set; }
    public virtual DbSet<VmQuotePricingPetProductDatum> PricingPetProductData { get; set; }
    public virtual DbSet<VmQuoteProductCoverOption> ProductCoverOptions { get; set; }
    public virtual DbSet<VmQuoteProductPremium> ProductPremia { get; set; }
    public virtual DbSet<VmQuoteProductPurchase> ProductPurchases { get; set; }
    public virtual DbSet<VmQuoteQuoteDatum> QuoteData { get; set; }
    public virtual DbSet<VmQuoteQuotePetDatum> QuotePetData { get; set; }
    public virtual DbSet<VmQuoteQuotePetProductPurchase> QuotePetProductPurchases { get; set; }
    public virtual DbSet<VmQuoteVet> Vets { get; set; }
    public virtual DbSet<VmQuoteVetHistory> VetHistories { get; set; }

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

        modelBuilder.Entity<VmQuoteBasket>(entity =>
        {
            entity.ToTable("Basket", "Quote");

            entity.Property(e => e.CountryId).HasColumnName("_CountryId");

            entity.Property(e => e.CustomerId).HasColumnName("_CustomerId");

            entity.Property(e => e.PetPolicyId).HasColumnName("_PetPolicyId");
        });

        modelBuilder.Entity<VmQuoteBasketPetDatum>(entity =>
        {
            entity.ToTable("BasketPetData", "Quote");

            entity.Property(e => e.CustomerId).HasColumnName("_CustomerId");

            entity.Property(e => e.PetPolicyId).HasColumnName("_PetPolicyId");
        });

        modelBuilder.Entity<VmQuoteBasketPetProductDatum>(entity =>
        {
            entity.ToTable("BasketPetProductData", "Quote");

            entity.Property(e => e.CustomerId).HasColumnName("_CustomerId");

            entity.Property(e => e.PetPolicyId).HasColumnName("_PetPolicyId");
        });

        modelBuilder.Entity<VmQuoteBasketPetProductDetailDatum>(entity =>
        {
            entity.ToTable("BasketPetProductDetailData", "Quote");

            entity.Property(e => e.CustomerId).HasColumnName("_CustomerId");

            entity.Property(e => e.PetPolicyId).HasColumnName("_PetPolicyId");
        });

        modelBuilder.Entity<VmQuoteFinancialsDatum>(entity =>
        {
            entity.ToTable("FinancialsData", "Quote");

            entity.Property(e => e.CountryId).HasColumnName("_CountryId");

            entity.Property(e => e.CustomerId).HasColumnName("_CustomerId");

            entity.Property(e => e.Discount).HasColumnType("decimal(18, 0)");

            entity.Property(e => e.Fee).HasColumnType("decimal(18, 0)");

            entity.Property(e => e.PetPolicyId).HasColumnName("_PetPolicyId");

            entity.Property(e => e.Premium).HasColumnType("decimal(18, 0)");

            entity.Property(e => e.Tax).HasColumnType("decimal(18, 0)");

            entity.Property(e => e.Total).HasColumnType("decimal(18, 0)");
        });

        modelBuilder.Entity<VmQuotePetQuoteSelectedProduct>(entity =>
        {
            entity.ToTable("PetQuoteSelectedProduct", "Quote");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.CustomerId).HasColumnName("_CustomerId");

            entity.Property(e => e.PetPolicyId).HasColumnName("_PetPolicyId");
        });

        modelBuilder.Entity<VmQuotePricing>(entity =>
        {
            entity.ToTable("Pricing", "Quote");

            entity.HasIndex(e => e.CountryId, "ix_quoteStagingPricing_countryId");

            entity.HasIndex(e => e.CustomerId, "ix_quoteStagingPricing_customerId");

            entity.Property(e => e.CountryId).HasColumnName("_CountryId");

            entity.Property(e => e.CustomerId).HasColumnName("_CustomerId");

            entity.Property(e => e.PetPolicyId).HasColumnName("_PetPolicyId");
        });

        modelBuilder.Entity<VmQuotePricingPetDatum>(entity =>
        {
            entity.ToTable("PricingPetData", "Quote");

            entity.Property(e => e.CustomerId).HasColumnName("_CustomerId");

            entity.Property(e => e.PetPolicyId).HasColumnName("_PetPolicyId");
        });

        modelBuilder.Entity<VmQuotePricingPetProductDatum>(entity =>
        {
            entity.ToTable("PricingPetProductData", "Quote");

            entity.Property(e => e.CoverEndDate).HasColumnType("date");

            entity.Property(e => e.CoverStartDate).HasColumnType("date");

            entity.Property(e => e.CustomerId).HasColumnName("_CustomerId");

            entity.Property(e => e.PetPolicyId).HasColumnName("_PetPolicyId");
        });

        modelBuilder.Entity<VmQuoteProductCoverOption>(entity =>
        {
            entity.ToTable("ProductCoverOptions", "Quote");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.CustomerId).HasColumnName("_CustomerId");

            entity.Property(e => e.PetPolicyId).HasColumnName("_PetPolicyId");
        });

        modelBuilder.Entity<VmQuoteProductPremium>(entity =>
        {
            entity.ToTable("ProductPremium", "Quote");

            entity.Property(e => e.CustomerId).HasColumnName("_CustomerId");

            entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");

            entity.Property(e => e.DiscountedPremium).HasColumnType("decimal(18, 2)");

            entity.Property(e => e.Fee).HasColumnType("decimal(18, 2)");

            entity.Property(e => e.FirstMonthPayable).HasColumnType("decimal(18, 2)");

            entity.Property(e => e.Payable).HasColumnType("decimal(18, 2)");

            entity.Property(e => e.PetPolicyId).HasColumnName("_PetPolicyId");

            entity.Property(e => e.Premium).HasColumnType("decimal(18, 2)");

            entity.Property(e => e.Tax).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<VmQuoteProductPurchase>(entity =>
        {
            entity.ToTable("ProductPurchase", "Quote");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.CustomerId).HasColumnName("_CustomerId");

            entity.Property(e => e.PetPolicyId).HasColumnName("_PetPolicyId");
        });

        modelBuilder.Entity<VmQuoteQuoteDatum>(entity =>
        {
            entity.ToTable("QuoteData", "Quote");

            entity.HasIndex(e => e.CountryId, "ix_quoteStagingQuoteData_countryId");

            entity.HasIndex(e => e.CustomerId, "ix_quoteStagingQuoteData_customerId");

            entity.Property(e => e.CountryId).HasColumnName("_CountryId");

            entity.Property(e => e.PetPolicyId).HasColumnName("_PetPolicyId");
        });

        modelBuilder.Entity<VmQuoteQuotePetDatum>(entity =>
        {
            entity.ToTable("QuotePetData", "Quote");

            entity.HasIndex(e => e.CountryId, "ix_quoteQuotePetData_countryId");

            entity.HasIndex(e => e.CustomerId, "ix_quoteQuotePetData_customerId");

            entity.Property(e => e.CountryId).HasColumnName("_CountryId");

            entity.Property(e => e.CoverStartDate).HasColumnType("date");

            entity.Property(e => e.CustomerId).HasColumnName("_CustomerId");

            entity.Property(e => e.TimeZoneCode).IsRequired();
        });

        modelBuilder.Entity<VmQuoteQuotePetProductPurchase>(entity =>
        {
            entity.ToTable("QuotePetProductPurchase", "Quote");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.CustomerId).HasColumnName("_CustomerId");

            entity.Property(e => e.PetPolicyId).HasColumnName("_PetPolicyId");
        });

        modelBuilder.Entity<VmQuoteVet>(entity =>
        {
            entity.ToTable("Vet", "Quote");

            entity.HasIndex(e => e.CountryId, "ix_quoteVet_countryId");

            entity.HasIndex(e => e.CustomerId, "ix_quoteVet_customerId");

            entity.HasIndex(e => e.PetPolicyId, "ix_quoteVet_petPolicyId");

            entity.Property(e => e.Address1).HasMaxLength(100);

            entity.Property(e => e.Address2).HasMaxLength(100);

            entity.Property(e => e.Address3).HasMaxLength(100);

            entity.Property(e => e.Country).HasMaxLength(55);

            entity.Property(e => e.CountryId).HasColumnName("_CountryId");

            entity.Property(e => e.CustomerId).HasColumnName("_CustomerId");

            entity.Property(e => e.Email).HasMaxLength(254);

            entity.Property(e => e.PetPolicyId).HasColumnName("_PetPolicyId");

            entity.Property(e => e.PhoneNumber).HasMaxLength(26);

            entity.Property(e => e.PostalCode).HasMaxLength(10);

            entity.Property(e => e.PracticeName).HasMaxLength(1000);

            entity.Property(e => e.RegionCounty).HasMaxLength(30);

            entity.Property(e => e.TownCity).HasMaxLength(60);
        });

        modelBuilder.Entity<VmQuoteVetHistory>(entity =>
        {
            entity.ToTable("VetHistory", "Quote");

            entity.HasIndex(e => e.CountryId, "ix_quoteVetHistory_countryId");

            entity.HasIndex(e => e.CustomerId, "ix_quoteVetHistory_customerId");

            entity.Property(e => e.CountryId).HasColumnName("_CountryId");

            entity.Property(e => e.CustomerId).HasColumnName("_CustomerId");

            entity.Property(e => e.PetId).HasColumnName("_PetId");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
using Microsoft.EntityFrameworkCore;
using Database.Trupanion.Entity.TruDat.Policy;
using Utilities.ConnectionStringManager.Base;
using Utilities.Constants.Enum;

namespace Database.Trupanion.Context;

public partial class TruDatPolicyContext : DbContext
{
    public TruDatPolicyContext()
    {
    }

    public TruDatPolicyContext(DbContextOptions<TruDatPolicyContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TruDatPolicyDeclarationPage> DeclarationPages { get; set; }
    public virtual DbSet<TruDatPolicyDeclarationPageOption> DeclarationPageOptions { get; set; }
    public virtual DbSet<TruDatPolicyEmailRequest> EmailRequests { get; set; }
    public virtual DbSet<TruDatPolicyEmailRequestStaging> EmailRequestStagings { get; set; }
    public virtual DbSet<TruDatPolicyPricingLog> PricingLogs { get; set; }

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

        modelBuilder.Entity<TruDatPolicyDeclarationPage>(entity =>
        {
            entity.ToTable("DeclarationPage", "Policy");

            entity.HasIndex(e => e.PetId, "ix_policydeclarationpage_pid");

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.AddressLine1)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AddressLine2)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AdministrativeFeeAmount).HasColumnType("smallmoney");

            entity.Property(e => e.AdministrativeFeeWaived).HasColumnType("smallmoney");

            entity.Property(e => e.AgeAtEnroll)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AnniversaryDate).HasColumnType("datetime");

            entity.Property(e => e.BoldDecPageLine1)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.BoldDecPageLine2).IsUnicode(false);

            entity.Property(e => e.BoldDecPageLine3)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Breed)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.City)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.DatePremiumEffective).HasColumnType("date");

            entity.Property(e => e.DecPageTaxMessage)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Deductible).HasColumnType("smallmoney");

            entity.Property(e => e.DocumentVersion)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

            entity.Property(e => e.ExternalDmsId)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.FormattedPhone)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength(true);

            entity.Property(e => e.InceptionTimeZone)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PetName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PolicyDate).HasColumnType("datetime");

            entity.Property(e => e.PolicyHolderName)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.PolicyNumber)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PolicyPlanCoinsuranceOwnerPercentage).HasColumnType("smallmoney");

            entity.Property(e => e.PolicyPlanCoinsurancePercentage).HasColumnType("smallmoney");

            entity.Property(e => e.PolicyPlanName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PolicyVersionName)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Premium).HasColumnType("smallmoney");

            entity.Property(e => e.PremiumBase).HasColumnType("smallmoney");

            entity.Property(e => e.PremiumTax).HasColumnType("smallmoney");

            entity.Property(e => e.PremiumTotal).HasColumnType("smallmoney");

            entity.Property(e => e.PremiumTotalWithFees).HasColumnType("smallmoney");

            entity.Property(e => e.SpayedOrNeutered)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SpeciesName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.StateCode)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.ZipCode)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatPolicyDeclarationPageOption>(entity =>
        {
            entity.ToTable("DeclarationPageOption", "Policy");

            entity.Property(e => e.Cost).HasColumnType("smallmoney");

            entity.Property(e => e.EffectiveFrom).HasColumnType("datetime");

            entity.Property(e => e.EndorsementDocumentVersion)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TruDatPolicyEmailRequest>(entity =>
        {
            entity.ToTable("EmailRequest", "Policy");

            entity.HasIndex(e => new { e.Id, e.EntityTypeId }, "ix_emailrequest_id_entityTypeId_sentime");

            entity.HasIndex(e => new { e.Complete, e.EntityTypeId, e.PlatformId }, "ix_policyemailrequest_cmplt_entytypid_pltfrmid");

            entity.HasIndex(e => new { e.EntityTypeId, e.EntityId }, "ix_policyemailrequest_etypeid_eid");

            entity.Property(e => e.BccAddresses).IsUnicode(false);

            entity.Property(e => e.Body).IsUnicode(false);

            entity.Property(e => e.CcAddresses).IsUnicode(false);

            entity.Property(e => e.EmailSubject).IsUnicode(false);

            entity.Property(e => e.Error).IsUnicode(false);

            entity.Property(e => e.FromAddress).IsUnicode(false);

            entity.Property(e => e.FromDisplayName).IsUnicode(false);

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.OptionalNote)
                .HasMaxLength(512)
                .IsUnicode(false);

            entity.Property(e => e.PolicyDocuments).IsUnicode(false);

            entity.Property(e => e.SendAfter).HasColumnType("datetime");

            entity.Property(e => e.SentTime).HasColumnType("datetime");

            entity.Property(e => e.ToAddresses).IsUnicode(false);

            entity.Property(e => e.Updated).HasColumnType("datetime");
        });

        modelBuilder.Entity<TruDatPolicyEmailRequestStaging>(entity =>
        {
            entity.ToTable("EmailRequestStaging", "Policy");

            entity.Property(e => e.BccAddresses)
                .HasMaxLength(512)
                .IsUnicode(false);

            entity.Property(e => e.Body).IsUnicode(false);

            entity.Property(e => e.CcAddresses)
                .HasMaxLength(512)
                .IsUnicode(false);

            entity.Property(e => e.EmailSubject)
                .HasMaxLength(1024)
                .IsUnicode(false);

            entity.Property(e => e.Error)
                .HasMaxLength(1024)
                .IsUnicode(false);

            entity.Property(e => e.FromAddress)
                .HasMaxLength(512)
                .IsUnicode(false);

            entity.Property(e => e.FromDisplayName)
                .HasMaxLength(256)
                .IsUnicode(false);

            entity.Property(e => e.Inserted).HasColumnType("datetime");

            entity.Property(e => e.Note).IsUnicode(false);

            entity.Property(e => e.ToAddresses)
                .HasMaxLength(1024)
                .IsUnicode(false);

            entity.Property(e => e.Updated).HasColumnType("datetime");
        });

        modelBuilder.Entity<TruDatPolicyPricingLog>(entity =>
        {
            entity.ToTable("PricingLog", "Policy");

            entity.Property(e => e.Deductible).HasColumnType("smallmoney");

            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength(true);

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.PolicyDate).HasColumnType("datetime");

            entity.Property(e => e.Premium).HasColumnType("smallmoney");

            entity.Property(e => e.PromoCode)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RatePendingDeductible).HasColumnType("smallmoney");

            entity.Property(e => e.RatePendingEffectiveDate).HasColumnType("datetime");

            entity.Property(e => e.SelectedOptions).IsUnicode(false);

            entity.Property(e => e.WorkingPetIds)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.ZipCode)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
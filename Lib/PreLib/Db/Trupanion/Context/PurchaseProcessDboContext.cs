using Microsoft.EntityFrameworkCore;

using Database.Trupanion.Entity.PurchaseProcess.Dbo;
using Utilities.ConnectionStringManager.Base;
using Utilities.Constants.Enum;

namespace Database.TestData.PurchaseProcessDbo;

public partial class PurchaseProcessDboContext : DbContext
{
    public PurchaseProcessDboContext()
    {
    }

    public PurchaseProcessDboContext(DbContextOptions<PurchaseProcessDboContext> options)
        : base(options)
    {
    }

    public virtual DbSet<PPDboAvailablePolicyNumber> AvailablePolicyNumbers { get; set; }
    public virtual DbSet<PPDboEnrollmentDataAssociation> EnrollmentDataAssociations { get; set; }
    public virtual DbSet<PPDboEnrollmentDatum> EnrollmentData { get; set; }
    public virtual DbSet<PPDboEnrollmentPetDatum> EnrollmentPetData { get; set; }
    public virtual DbSet<PPDboEnrollmentProcessDatum> EnrollmentProcessData { get; set; }
    public virtual DbSet<PPDboEnrollmentType> EnrollmentTypes { get; set; }
    public virtual DbSet<PPDboProcessItem> ProcessItems { get; set; }
    public virtual DbSet<PPDboSelectedPolicyOption> SelectedPolicyOptions { get; set; }
    public virtual DbSet<PPDboSelectedWorkingPet> SelectedWorkingPets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(ConnectionString.TrupanionConnectionString(SqlDatabase.purchaseprocess), options => options.EnableRetryOnFailure().CommandTimeout(60));
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<PPDboAvailablePolicyNumber>(entity =>
        {
            entity.ToTable("AvailablePolicyNumber");

            entity.HasIndex(e => e.PolicyNumber, "uk_availablepolicynumber_policynumber")
                .IsUnique();

            entity.Property(e => e.PolicyNumber)
                .IsRequired()
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PPDboEnrollmentDataAssociation>(entity =>
        {
            entity.ToTable("EnrollmentDataAssociation");

            entity.HasOne(d => d.EnrollmentData)
                .WithMany(p => p.EnrollmentDataAssociations)
                .HasForeignKey(d => d.EnrollmentDataId)
                .HasConstraintName("fk_enrollmentdataassociation_enrollmentdata");
        });

        modelBuilder.Entity<PPDboEnrollmentDatum>(entity =>
        {
            entity.ToTable("EnrollmentData", tb => tb.HasTrigger("trg_audit_insert_dboEnrollmentData"));

            entity.HasIndex(e => e.ReferenceNumber, "uk_enrollmentdata_referencenumber")
                .IsUnique();

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.Address).HasMaxLength(100);

            entity.Property(e => e.Address2).HasMaxLength(100);

            entity.Property(e => e.AlternameLastName).HasMaxLength(100);

            entity.Property(e => e.AlternateFirstName).HasMaxLength(100);

            entity.Property(e => e.AmazonBillingAgreementId).HasMaxLength(32);

            entity.Property(e => e.BankAccountAccountNumber).HasMaxLength(100);

            entity.Property(e => e.BankAccountAccountNumberLast4).HasMaxLength(100);

            entity.Property(e => e.BankAccountBankCode).HasMaxLength(100);

            entity.Property(e => e.BankAccountBankName).HasMaxLength(100);

            entity.Property(e => e.BankAccountNameOnAccount).HasMaxLength(100);

            entity.Property(e => e.BankAccountTransitNumber).HasMaxLength(100);

            entity.Property(e => e.City).HasMaxLength(100);

            entity.Property(e => e.CreditCardExpiration)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength(true);

            entity.Property(e => e.CreditCardLast4)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength(true);

            entity.Property(e => e.CreditCardNameOnCard).HasMaxLength(100);

            entity.Property(e => e.CreditCardNumber).HasMaxLength(100);

            entity.Property(e => e.CrmleadId).HasColumnName("CRMLeadId");

            entity.Property(e => e.Effective).HasColumnType("date");

            entity.Property(e => e.EmailAddress).HasMaxLength(100);

            entity.Property(e => e.EmployeeId).HasMaxLength(100);

            entity.Property(e => e.EmployerId).HasMaxLength(100);

            entity.Property(e => e.EnrollEffective).HasColumnType("datetime");

            entity.Property(e => e.EnrollProcessingCompleted).HasColumnType("datetime");

            entity.Property(e => e.EnrollProcessingStarted).HasColumnType("datetime");

            entity.Property(e => e.EnrollQueued).HasColumnType("datetime");

            entity.Property(e => e.ExternalAccountId).HasMaxLength(32);

            entity.Property(e => e.FirstName).HasMaxLength(100);

            entity.Property(e => e.LastName).HasMaxLength(100);

            entity.Property(e => e.Password).HasMaxLength(100);

            entity.Property(e => e.PolicyNumber)
                .IsRequired()
                .HasMaxLength(40);

            entity.Property(e => e.PostalCode).HasMaxLength(20);

            entity.Property(e => e.PrimaryPhone).HasMaxLength(100);

            entity.Property(e => e.SecondaryPhone).HasMaxLength(100);

            entity.Property(e => e.WorkPhone).HasMaxLength(100);

            entity.Property(e => e.WorkPhoneExt).HasMaxLength(100);
        });

        modelBuilder.Entity<PPDboEnrollmentPetDatum>(entity =>
        {
            entity.HasIndex(e => e.EnrollmentDataId, "ix_enrollmentpetdata_enrollmentdataid");

            entity.HasIndex(e => new { e.EnrollmentDataId, e.Name }, "uk_enrollmentpetdata_enrollmentpetdataid_name")
                .IsUnique();

            entity.Property(e => e.AdoptionDate).HasColumnType("datetime");

            entity.Property(e => e.CampaignCode).HasMaxLength(50);

            entity.Property(e => e.CampaignCodeReferenceNumber).HasMaxLength(50);

            entity.Property(e => e.CampaignInstanceSecurityKey).HasMaxLength(50);

            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

            entity.Property(e => e.Deductible).HasColumnType("smallmoney");

            entity.Property(e => e.ExternalPetSubscriptionId).HasMaxLength(32);

            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength(true);

            entity.Property(e => e.HospitalName).HasMaxLength(100);

            entity.Property(e => e.HospitalPhone).HasMaxLength(20);

            entity.Property(e => e.HospitalPostalCode).HasMaxLength(20);

            entity.Property(e => e.LastExameDate).HasColumnType("datetime");

            entity.Property(e => e.Name).HasMaxLength(100);

            entity.Property(e => e.Premium).HasColumnType("smallmoney");

            entity.HasOne(d => d.EnrollmentData)
                .WithMany(p => p.EnrollmentPetData)
                .HasForeignKey(d => d.EnrollmentDataId)
                .HasConstraintName("fk_enrollmentpetdata_enrollmentdata");
        });

        modelBuilder.Entity<PPDboEnrollmentProcessDatum>(entity =>
        {
            entity.HasIndex(e => e.EnrollmentDataId, "ix_enrollmentprocessdata_enrollmentdataid");

            entity.HasIndex(e => e.ProcessItemId, "ix_enrollmentprocessdata_processitemid");

            entity.Property(e => e.Completed).HasColumnType("datetime");

            entity.HasOne(d => d.EnrollmentData)
                .WithMany(p => p.EnrollmentProcessData)
                .HasForeignKey(d => d.EnrollmentDataId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_enrollmentprocessdata_enrollmentdata");
        });

        modelBuilder.Entity<PPDboEnrollmentType>(entity =>
        {
            entity.ToTable("EnrollmentType");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<PPDboProcessItem>(entity =>
        {
            entity.ToTable("ProcessItem");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PPDboSelectedPolicyOption>(entity =>
        {
            entity.ToTable("SelectedPolicyOption");

            entity.HasIndex(e => new { e.EnrollmentPetDataId, e.Name }, "uk_selectedpolicyoption_enrollmentpetdataid_name")
                .IsUnique();

            entity.Property(e => e.Cost).HasColumnType("smallmoney");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.EnrollmentPetData)
                .WithMany(p => p.SelectedPolicyOptions)
                .HasForeignKey(d => d.EnrollmentPetDataId)
                .HasConstraintName("fk_selectedpolicyoption_enrollmentpetdata");
        });

        modelBuilder.Entity<PPDboSelectedWorkingPet>(entity =>
        {
            entity.ToTable("SelectedWorkingPet");

            entity.HasIndex(e => new { e.EnrollmentPetDataId, e.WorkingPetId }, "uk_selectedworkingpet_enrollmentpetdataid_workingpetid")
                .IsUnique();

            entity.HasOne(d => d.EnrollmentPetData)
                .WithMany(p => p.SelectedWorkingPets)
                .HasForeignKey(d => d.EnrollmentPetDataId)
                .HasConstraintName("fk_selectedworkingpet_enrollmentpetdata");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

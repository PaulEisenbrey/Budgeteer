using Microsoft.EntityFrameworkCore;
using Database.Trupanion.Entity.TruDat.Claim;
using Utilities.ConnectionStringManager.Base;
using Utilities.Constants.Enum;

namespace Database.Trupanion.Context;

public partial class TruDatClaimContext : DbContext
{
    public TruDatClaimContext()
    {
    }

    public TruDatClaimContext(DbContextOptions<TruDatClaimContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TruDatClaimAdditionalBenefit> AdditionalBenefits { get; set; }
    public virtual DbSet<TruDatClaimAppealEntityNote> AppealEntityNotes { get; set; }
    public virtual DbSet<TruDatClaimAppealReason> AppealReasons { get; set; }
    public virtual DbSet<TruDatClaimAppealReasonCategory> AppealReasonCategorys { get; set; }
    public virtual DbSet<TruDatClaimAppealType> AppealTypes { get; set; }
    public virtual DbSet<TruDatClaimAssessment> Assessments { get; set; }
    public virtual DbSet<TruDatClaimAssessmentConditionPreviousLink> AssessmentConditionPreviousLinks { get; set; }
    public virtual DbSet<TruDatClaimAssessmentData> AssessmentDatas { get; set; }
    public virtual DbSet<TruDatClaimAssessmentDataAppeal> AssessmentDataAppeals { get; set; }
    public virtual DbSet<TruDatClaimAssessmentDataAppealReason> AssessmentDataAppealReasons { get; set; }
    public virtual DbSet<TruDatClaimAssessmentDataHistory> AssessmentDataHistories { get; set; }
    public virtual DbSet<TruDatClaimAuditType> AuditTypes { get; set; }
    public virtual DbSet<TruDatClaimCategory> Categories { get; set; }
    public virtual DbSet<TruDatClaimClaimHistory> ClaimHistories { get; set; }
    public virtual DbSet<TruDatClaimClinicClaimFrom> ClinicClaimFroms { get; set; }
    public virtual DbSet<TruDatClaimClinicInvoice> ClinicInvoices { get; set; }
    public virtual DbSet<TruDatClaimClinicInvoiceLineItem> ClinicInvoiceLineItems { get; set; }
    public virtual DbSet<TruDatClaimConditionBackup> ConditionBackups { get; set; }
    public virtual DbSet<TruDatClaimConditionData> ConditionDatas { get; set; }
    public virtual DbSet<TruDatClaimConditionDataConcept> ConditionDataConcepts { get; set; }
    public virtual DbSet<TruDatClaimConditionDataExcluded> ConditionDataExcludeds { get; set; }
    public virtual DbSet<TruDatClaimConditionDataPreferred> ConditionDataPreferreds { get; set; }
    public virtual DbSet<TruDatClaimConditionDataStaging> ConditionDataStagings { get; set; }
    public virtual DbSet<TruDatClaimConditionType> ConditionTypes { get; set; }
    public virtual DbSet<TruDatClaimCostCenter> CostCenters { get; set; }
    public virtual DbSet<TruDatClaimExclusionGroup> ExclusionGroups { get; set; }
    public virtual DbSet<TruDatClaimExclusionGroupMap> ExclusionGroupMaps { get; set; }
    public virtual DbSet<TruDatClaimInvoice> Invoices { get; set; }
    public virtual DbSet<TruDatClaimInvoiceLineItem> InvoiceLineItems { get; set; }
    public virtual DbSet<TruDatClaimInvoiceLineItemCondition> InvoiceLineItemConditions { get; set; }
    public virtual DbSet<TruDatClaimInvoiceLineItemDiscount> InvoiceLineItemDiscounts { get; set; }
    public virtual DbSet<TruDatClaimInvoiceLineItemExclusion> InvoiceLineItemExclusions { get; set; }
    public virtual DbSet<TruDatClaimInvoiceLineItemFood> InvoiceLineItemFoods { get; set; }
    public virtual DbSet<TruDatClaimLocationOld> LocationOlds { get; set; }
    public virtual DbSet<TruDatClaimMedicalRecord> MedicalRecords { get; set; }
    public virtual DbSet<TruDatClaimMedicalRecordAssessment> MedicalRecordAssessments { get; set; }
    public virtual DbSet<TruDatClaimMedicalRecordCondition> MedicalRecordConditions { get; set; }
    public virtual DbSet<TruDatClaimMedicalRecordDiagnosis> MedicalRecordDiagnosiss { get; set; }
    public virtual DbSet<TruDatClaimMedicalRecordEligible> MedicalRecordEligibles { get; set; }
    public virtual DbSet<TruDatClaimMedicalRecordLocation> MedicalRecordLocations { get; set; }
    public virtual DbSet<TruDatClaimMedicalRecordProcedure> MedicalRecordProcedures { get; set; }
    public virtual DbSet<TruDatClaimMedicalRecordSign> MedicalRecordSigns { get; set; }
    public virtual DbSet<TruDatClaimMedicalRecordTreatment> MedicalRecordTreatments { get; set; }
    public virtual DbSet<TruDatClaimMissingNotification> MissingNotifications { get; set; }
    public virtual DbSet<TruDatClaimPartialPawPrint> PartialPawPrints { get; set; }
    public virtual DbSet<TruDatClaimPartialPawPrintReason> PartialPawPrintReasons { get; set; }
    public virtual DbSet<TruDatClaimPawPrintDocument> PawPrintDocuments { get; set; }
    public virtual DbSet<TruDatClaimPetClinic> PetClinics { get; set; }
    public virtual DbSet<TruDatClaimPetClinicAttachment> PetClinicAttachments { get; set; }
    public virtual DbSet<TruDatClaimPetClinicContact> PetClinicContacts { get; set; }
    public virtual DbSet<TruDatClaimPetMedicalAction> PetMedicalActions { get; set; }
    public virtual DbSet<TruDatClaimPilotEntity> PilotEntitys { get; set; }
    public virtual DbSet<TruDatClaimProcedure> Procedures { get; set; }
    public virtual DbSet<TruDatClaimProcedureCondition> ProcedureConditions { get; set; }
    public virtual DbSet<TruDatClaimRecordType> RecordTypes { get; set; }
    public virtual DbSet<TruDatClaimTreatment> Treatments { get; set; }
    public virtual DbSet<TruDatClaimTreatmentType> TreatmentTypes { get; set; }
    public virtual DbSet<TruDatClaimWizardOverride> WizardOverrides { get; set; }
    public virtual DbSet<TruDatClaimWizardSection> WizardSections { get; set; }
    public virtual DbSet<TruDatClaimWizardTracking> WizardTrackings { get; set; }

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

        modelBuilder.Entity<TruDatClaimAppealEntityNote>(entity =>
        {
            entity.ToTable("AppealEntityNote", "Claim");
        });

        modelBuilder.Entity<TruDatClaimAdditionalBenefit>(entity =>
        {
            entity.ToTable("AdditionalBenefit", "Claim");
        });

        modelBuilder.Entity<TruDatClaimAppealReason>(entity =>
        {
            entity.ToTable("AppealReason", "Claim");
        });

        modelBuilder.Entity<TruDatClaimAppealReasonCategory>(entity =>
        {
            entity.ToTable("AppealReasonCategory", "Claim");
        });

        modelBuilder.Entity<TruDatClaimAppealType>(entity =>
        {
            entity.ToTable("AppealType", "Claim");
        });

        modelBuilder.Entity<TruDatClaimAssessment>(entity =>
        {
            entity.ToTable("Assessment", "Claim");
        });

        modelBuilder.Entity<TruDatClaimAssessmentData>(entity =>
        {
            entity.ToTable("AssessmentData", "Claim");
        });

        modelBuilder.Entity<TruDatClaimAssessmentDataAppeal>(entity =>
        {
            entity.ToTable("AssessmentDataAppeal", "Claim");
        });

        modelBuilder.Entity<TruDatClaimAssessmentDataAppealReason>(entity =>
        {
            entity.ToTable("AssessmentDataAppealReason", "Claim");
        });

        modelBuilder.Entity<TruDatClaimAssessmentDataHistory>(entity =>
        {
            entity.ToTable("AssessmentDataHistory", "Claim");

            entity.Property("ThirdPartyLiability").HasColumnName("3rdPartyLiability");

        });

        modelBuilder.Entity<TruDatClaimAuditType>(entity =>
        {
            entity.ToTable("AuditType", "Claim");
        });

        modelBuilder.Entity<TruDatClaimCategory>(entity =>
        {
            entity.ToTable("Category", "Claim");
        });

        modelBuilder.Entity<TruDatClaimClaimHistory>(entity =>
        {
            entity.ToTable("ClaimHistory", "Claim");
        });

        modelBuilder.Entity<TruDatClaimClinicClaimFrom>(entity =>
        {
            entity.ToTable("ClinicClaimFrom", "Claim");
        });

        modelBuilder.Entity<TruDatClaimClinicInvoice>(entity =>
        {
            entity.ToTable("ClinicInvoice", "Claim");
        });

        modelBuilder.Entity<TruDatClaimClinicInvoiceLineItem>(entity =>
        {
            entity.ToTable("ClinicInvoiceLineItem", "Claim");
        });

        modelBuilder.Entity<TruDatClaimConditionBackup>(entity =>
{
    entity.ToTable("ConditionBackup", "Claim");
});

        modelBuilder.Entity<TruDatClaimConditionData>(entity =>
        {
            entity.ToTable("ConditionData", "Claim");
        });

        modelBuilder.Entity<TruDatClaimConditionDataPreferred>(entity =>
        {
            entity.ToTable("ConditionDataPreferred", "Claim");
            entity.HasNoKey();
        });

        modelBuilder.Entity<TruDatClaimConditionDataExcluded>(entity =>
        {
            entity.ToTable("ConditionDataExcluded", "Claim");
            entity.HasNoKey();
        });

        modelBuilder.Entity<TruDatClaimConditionDataConcept>(entity =>
        {
            entity.ToTable("ConditionDataConcept", "Claim");
            entity.HasNoKey();
        });

        modelBuilder.Entity<TruDatClaimCostCenter>(entity =>
        {
            entity.ToTable("CostCenter", "Claim");
        });

        modelBuilder.Entity<TruDatClaimExclusionGroup>(Entity =>
        {
            Entity.ToTable("ExclusionGroup", "Claim");
        });

        modelBuilder.Entity<TruDatClaimExclusionGroupMap>(Entity =>
        {
            Entity.ToTable("ExclusionGroupMap", "Claim");
        });

        modelBuilder.Entity<TruDatClaimInvoice>(entity =>
        {
            entity.ToTable("Invoice", "Claim");
        });

        modelBuilder.Entity<TruDatClaimInvoiceLineItem>(entity =>
        {
            entity.ToTable("InvoiceLineItem", "Claim");
        });

        modelBuilder.Entity<TruDatClaimInvoiceLineItemCondition>(entity =>
        {
            entity.ToTable("InvoiceLineItemCondition", "Claim");
        });

        modelBuilder.Entity<TruDatClaimInvoiceLineItemDiscount>(entity =>
        {
            entity.ToTable("InvoiceLineItemDiscount", "Claim");
        });

        modelBuilder.Entity<TruDatClaimInvoiceLineItemExclusion>(entity =>
        {
            entity.ToTable("InvoiceLineItemExclusion", "Claim");
        });

        modelBuilder.Entity<TruDatClaimInvoiceLineItemFood>(entity =>
        {
            entity.ToTable("InvoiceLineItemFood", "Claim");
        });

        modelBuilder.Entity<TruDatClaimLocationOld>(entity =>
        {
            entity.ToTable("LocationOld", "Claim");
        });

        modelBuilder.Entity<TruDatClaimMedicalRecord>(entity =>
        {
            entity.ToTable("MedicalRecord", "Claim");
        });

        modelBuilder.Entity<TruDatClaimMedicalRecordAssessment>(entity =>
        {
            entity.ToTable("MedicalRecordAssessment", "Claim");
            entity.HasNoKey();
        });

        modelBuilder.Entity<TruDatClaimMedicalRecordCondition>(entity =>
        {
            entity.ToTable("MedicalRecordCondition", "Claim");
        });

        modelBuilder.Entity<TruDatClaimMedicalRecordDiagnosis>(entity =>
        {
            entity.ToTable("MedicalRecordDiagnosis", "Claim");
        });

        modelBuilder.Entity<TruDatClaimMedicalRecordEligible>(entity =>
        {
            entity.ToTable("MedicalRecordEligible", "Claim");
        });

        modelBuilder.Entity<TruDatClaimMedicalRecordLocation>(entity =>
        {
            entity.ToTable("MedicalRecordLocation", "Claim");
        });

        modelBuilder.Entity<TruDatClaimMedicalRecordProcedure>(entity =>
        {
            entity.ToTable("MedicalRecordProcedure", "Claim");
        });

        modelBuilder.Entity<TruDatClaimMedicalRecordSign>(entity =>
        {
            entity.ToTable("MedicalRecordSign", "Claim");
        });

        modelBuilder.Entity<TruDatClaimMedicalRecordTreatment>(entity =>
        {
            entity.ToTable("MedicalRecordTreatment", "Claim");
        });

        modelBuilder.Entity<TruDatClaimMissingNotification>(entity =>
        {
            entity.ToTable("MissingNotification", "Claim");
            entity.HasNoKey();
        });

        modelBuilder.Entity<TruDatClaimPartialPawPrint>(entity =>
        {
            entity.ToTable("PartialPawPrint", "Claim");
        });

        modelBuilder.Entity<TruDatClaimPartialPawPrintReason>(entity =>
        {
            entity.ToTable("PartialPawPrintReason", "Claim");
        });

        modelBuilder.Entity<TruDatClaimPawPrintDocument>(entity =>
        {
            entity.ToTable("PawPrintDocument", "Claim");
        });

        modelBuilder.Entity<TruDatClaimPetClinic>(entity =>
        {
            entity.ToTable("PetClinic", "Claim");
        });

        modelBuilder.Entity<TruDatClaimPetClinicAttachment>(entity =>
        {
            entity.ToTable("PetClinicAttachment", "Claim");
        });

        modelBuilder.Entity<TruDatClaimPetClinicContact>(entity =>
        {
            entity.ToTable("PetClinicContact", "Claim");
        });

        modelBuilder.Entity<TruDatClaimPetMedicalAction>(entity =>
        {
            entity.ToTable("PetMedicalAction", "Claim");
        });

        modelBuilder.Entity<TruDatClaimPilotEntity>(entity =>
        {
            entity.ToTable("PilotEntity", "Claim");
        });

        modelBuilder.Entity<TruDatClaimProcedure>(entity =>
        {
            entity.ToTable("Procedure", "Claim");
        });

        modelBuilder.Entity<TruDatClaimProcedureCondition>(entity =>
        {
            entity.ToTable("ProcedureCondition", "Claim");
        });

        modelBuilder.Entity<TruDatClaimRecordType>(entity =>
        {
            entity.ToTable("RecordType", "Claim");
        });

        modelBuilder.Entity<TruDatClaimTreatment>(entity =>
        {
            entity.ToTable("Treatment", "Claim");
        });

        modelBuilder.Entity<TruDatClaimTreatmentType>(entity =>
        {
            entity.ToTable("TreatmentType", "Claim");
        });

        modelBuilder.Entity<TruDatClaimWizardOverride>(entity =>
        {
            entity.ToTable("WizardOverride", "Claim");
        });

        modelBuilder.Entity<TruDatClaimWizardSection>(entity =>
        {
            entity.ToTable("WizardSection", "Claim");
        });

        modelBuilder.Entity<TruDatClaimWizardTracking>(entity =>
        {
            entity.ToTable("WizardTracking", "Claim");
        });

        OnModelCreatingPartial(modelBuilder);
    }
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
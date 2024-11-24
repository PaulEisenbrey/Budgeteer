using Microsoft.EntityFrameworkCore;
using Database.Trupanion.Entity.Claims.Dbo;
using Utilities.ConnectionStringManager.Base;
using Utilities.Constants.Enum;

namespace Database.Trupanion.Context;

public partial class ClaimsDboContext : DbContext
{
    public ClaimsDboContext()
    {
    }

    public ClaimsDboContext(DbContextOptions<ClaimsDboContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ClaimsDboBlackWhiteList> BlackWhiteLists { get; set; }
    public virtual DbSet<ClaimsDboClaimAutoAdjudicationRunSetting> ClaimAutoAdjudicationRunSettings { get; set; }
    public virtual DbSet<ClaimsDboClaimBusinessRuleDefinition> ClaimBusinessRuleDefinitions { get; set; }
    public virtual DbSet<ClaimsDboClaimBusinessRuleEvaluationLog> ClaimBusinessRuleEvaluationLogs { get; set; }
    public virtual DbSet<ClaimsDboClaimBusinessRuleListDefinition> ClaimBusinessRuleListDefinitions { get; set; }
    public virtual DbSet<ClaimsDboClaimExclusion> ClaimExclusions { get; set; }
    public virtual DbSet<ClaimsDboClaimExclusionList> ClaimExclusionLists { get; set; }
    public virtual DbSet<ClaimsDboClaimExclusionListProductVersion> ClaimExclusionListProductVersions { get; set; }
    public virtual DbSet<ClaimsDboClaimExclusionMap> ClaimExclusionMaps { get; set; }
    public virtual DbSet<ClaimsDboClaimPriority> ClaimPriorities { get; set; }
    public virtual DbSet<ClaimsDboClaimSpecialEmailAssignment> ClaimSpecialEmailAssignments { get; set; }
    public virtual DbSet<ClaimsDboClaimTrexStateAssignment> ClaimTrexStateAssignments { get; set; }
    public virtual DbSet<ClaimsDboClinicClaimForm> ClinicClaimForms { get; set; }
    public virtual DbSet<ClaimsDboClinicInvoice> ClinicInvoices { get; set; }
    public virtual DbSet<ClaimsDboClinicInvoiceLineItem> ClinicInvoiceLineItems { get; set; }
    public virtual DbSet<ClaimsDboCommandStatus> CommandStatuses { get; set; }
    public virtual DbSet<ClaimsDboConditionExclusion> ConditionExclusions { get; set; }
    public virtual DbSet<ClaimsDboConditionLocationMap> ConditionLocationMaps { get; set; }
    public virtual DbSet<ClaimsDboContactRequest> ContactRequests { get; set; }
    public virtual DbSet<ClaimsDboContactRequestClaim> ContactRequestClaims { get; set; }
    public virtual DbSet<ClaimsDboContactRequestClaimHistory> ContactRequestClaimHistories { get; set; }
    public virtual DbSet<ClaimsDboContactRequestHistory> ContactRequestHistories { get; set; }
    public virtual DbSet<ClaimsDboContactRequestMedicalRecordType> ContactRequestMedicalRecordTypes { get; set; }
    public virtual DbSet<ClaimsDboContactRequestMedicalRecordTypeHistory> ContactRequestMedicalRecordTypeHistories { get; set; }
    public virtual DbSet<ClaimsDboContactRequestType> ContactRequestTypes { get; set; }
    public virtual DbSet<ClaimsDboCoverageSummary> CoverageSummaries { get; set; }
    public virtual DbSet<ClaimsDboCoverageSummaryHistory> CoverageSummaryHistories { get; set; }
    public virtual DbSet<ClaimsDboCoverageSummaryTrial> CoverageSummaryTrials { get; set; }
    public virtual DbSet<ClaimsDboExclusion> Exclusions { get; set; }
    public virtual DbSet<ClaimsDboExclusionText> ExclusionTexts { get; set; }
    public virtual DbSet<ClaimsDboMedicalRecordType> MedicalRecordTypes { get; set; }
    public virtual DbSet<ClaimsDboMedicalRecordTypeRelationship> MedicalRecordTypeRelationships { get; set; }
    public virtual DbSet<ClaimsDboOnlineClaimSubmission> OnlineClaimSubmissions { get; set; }
    public virtual DbSet<ClaimsDboOvertCondition> OvertConditions { get; set; }
    public virtual DbSet<ClaimsDboPetDeletedExclusion> PetDeletedExclusions { get; set; }
    public virtual DbSet<ClaimsDboPolicyExclusionType> PolicyExclusionTypes { get; set; }
    public virtual DbSet<ClaimsDboPolicyExclusionTypeDefault> PolicyExclusionTypeDefaults { get; set; }
    public virtual DbSet<ClaimsDboSpecialCareEntity> SpecialCareEntities { get; set; }
    public virtual DbSet<ClaimsDboSpecialCareEntityRouting> SpecialCareEntityRoutings { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(ConnectionString.TrupanionConnectionString(SqlDatabase.claims), options => options.EnableRetryOnFailure().CommandTimeout(60));
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<ClaimsDboBlackWhiteList>(entity =>
        {
            entity.ToTable("BlackWhiteList");

            entity.Property(e => e.Comments).HasMaxLength(1024);

            entity.Property(e => e.CreatedOn).HasDefaultValueSql("(sysdatetime())");

            entity.Property(e => e.EntityId)
                .IsRequired()
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ModifiedOn).HasDefaultValueSql("(sysdatetime())");
        });

        modelBuilder.Entity<ClaimsDboClaimAutoAdjudicationRunSetting>(entity =>
        {
            entity.Property(e => e.ClaimSubmitter)
                .IsRequired()
                .HasMaxLength(64)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ClaimsDboClaimBusinessRuleDefinition>(entity =>
        {
            entity.ToTable("ClaimBusinessRuleDefinition");

            entity.HasIndex(e => e.Name, "ix_claimbusinessruledefinition_name");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(256)
                .IsUnicode(false);

            entity.Property(e => e.TypeName)
                .IsRequired()
                .HasMaxLength(256)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ClaimsDboClaimBusinessRuleEvaluationLog>(entity =>
        {
            entity.ToTable("ClaimBusinessRuleEvaluationLog");

            entity.Property(e => e.RuleListEvaluated)
                .IsRequired()
                .HasMaxLength(256)
                .IsUnicode(false);

            entity.Property(e => e.SerializedException).IsUnicode(false);
        });

        modelBuilder.Entity<ClaimsDboClaimBusinessRuleListDefinition>(entity =>
        {
            entity.ToTable("ClaimBusinessRuleListDefinition");

            entity.HasIndex(e => e.Name, "ix_claimbusinessrulelistdefinition_name");

            entity.Property(e => e.ConfigData)
                .IsRequired()
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(256)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ClaimsDboClaimExclusion>(entity =>
        {
            entity.ToTable("ClaimExclusion");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Blurb).HasMaxLength(2000);

            entity.Property(e => e.Label).HasMaxLength(100);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.Wording).HasMaxLength(2000);

            entity.HasOne(d => d.ClaimExclusionList)
                .WithMany(p => p.ClaimExclusions)
                .HasForeignKey(d => d.ClaimExclusionListId)
                .HasConstraintName("fk_claimexclusion_claimexclusionlistid");
        });

        modelBuilder.Entity<ClaimsDboClaimExclusionList>(entity =>
        {
            entity.ToTable("ClaimExclusionList");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<ClaimsDboClaimExclusionListProductVersion>(entity =>
        {
            entity.ToTable("ClaimExclusionListProductVersion");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.ProductVersionNumber)
                .IsRequired()
                .HasMaxLength(100);

            entity.HasOne(d => d.ClaimExclusionList)
                .WithMany(p => p.ClaimExclusionListProductVersions)
                .HasForeignKey(d => d.ClaimExclusionListId)
                .HasConstraintName("fk_claimexclusionlistproductversion_claimexclusionlistid");
        });

        modelBuilder.Entity<ClaimsDboClaimExclusionMap>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("ClaimExclusionMap");

            entity.HasIndex(e => e.ExclusionId, "ix_dboClaimExclusionMap_ExclusionId")
                .IsClustered();

            entity.Property(e => e.CategoryId).HasDefaultValueSql("((0))");

            entity.Property(e => e.ExclusionGroupMap)
                .IsRequired()
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ClaimsDboClaimPriority>(entity =>
        {
            entity.ToTable("ClaimPriority");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<ClaimsDboClaimSpecialEmailAssignment>(entity =>
        {
            entity.ToTable("ClaimSpecialEmailAssignment");

            entity.HasIndex(e => e.AssignedUserId, "uc_claimspecialemailassignment_assigneduserid")
                .IsUnique();

            entity.Property(e => e.CreatedOn).HasDefaultValueSql("(sysutcdatetime())");

            entity.Property(e => e.EmailGroup)
                .IsRequired()
                .HasMaxLength(256)
                .IsUnicode(false);

            entity.Property(e => e.EmailNote)
                .HasMaxLength(256)
                .IsUnicode(false);

            entity.Property(e => e.ModifiedOn).HasDefaultValueSql("(sysutcdatetime())");
        });

        modelBuilder.Entity<ClaimsDboClaimTrexStateAssignment>(entity =>
        {
            entity.ToTable("ClaimTrexStateAssignment");

            entity.HasIndex(e => e.StateId, "uc_stateid")
                .IsUnique();

            entity.Property(e => e.EmailGroup)
                .IsRequired()
                .HasMaxLength(32)
                .IsUnicode(false);

            entity.Property(e => e.EmailNote)
                .HasMaxLength(256)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ClaimsDboClinicClaimForm>(entity =>
        {
            entity.ToTable("ClinicClaimForm");

            entity.HasIndex(e => e.AssessmentDataId, "ix_clinicclaimform_assessmentdataid");

            entity.HasIndex(e => e.AssessmentDataId, "uk_cliniclaimform_assessmentdataId")
                .IsUnique();

            entity.Property(e => e.CreatedOn).HasDefaultValueSql("(sysutcdatetime())");

            entity.Property(e => e.ModifiedOn).HasDefaultValueSql("(sysutcdatetime())");

            entity.Property(e => e.PresentingConditions)
                .HasMaxLength(1024)
                .IsUnicode(false);

            entity.Property(e => e.PresentingConditions2)
                .HasMaxLength(1024)
                .IsUnicode(false);

            entity.Property(e => e.SecondaryInsurance)
                .HasMaxLength(1024)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ClaimsDboClinicInvoice>(entity =>
        {
            entity.ToTable("ClinicInvoice");

            entity.HasIndex(e => e.AssessmentDataId, "ix_clinicinvoice_assessmentdataid");

            entity.Property(e => e.CreatedOn).HasDefaultValueSql("(sysutcdatetime())");

            entity.Property(e => e.Discount).HasColumnType("smallmoney");

            entity.Property(e => e.ModifiedOn).HasDefaultValueSql("(sysutcdatetime())");

            entity.Property(e => e.PimsinvoiceId)
                .HasMaxLength(512)
                .IsUnicode(false)
                .HasColumnName("PIMSInvoiceId");

            entity.Property(e => e.Subtotal).HasColumnType("smallmoney");
        });

        modelBuilder.Entity<ClaimsDboClinicInvoiceLineItem>(entity =>
        {
            entity.ToTable("ClinicInvoiceLineItem");

            entity.HasIndex(e => e.ClinicInvoiceId, "ix_clinicinvoiceLineItem_ClinicInvoiceId");

            entity.Property(e => e.ActualExtendedPrice).HasColumnType("smallmoney");

            entity.Property(e => e.CreatedOn).HasDefaultValueSql("(sysutcdatetime())");

            entity.Property(e => e.InvoiceNumber)
                .HasMaxLength(512)
                .IsUnicode(false);

            entity.Property(e => e.InvoicePetName)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.ItemDescription).IsUnicode(false);

            entity.Property(e => e.ModifiedOn).HasDefaultValueSql("(sysutcdatetime())");

            entity.Property(e => e.OperatorName)
                .HasMaxLength(512)
                .IsUnicode(false);

            entity.Property(e => e.Provider)
                .HasMaxLength(512)
                .IsUnicode(false);

            entity.Property(e => e.TransactionDate).HasColumnType("datetime");

            entity.HasOne(d => d.ClinicInvoice)
                .WithMany(p => p.ClinicInvoiceLineItems)
                .HasForeignKey(d => d.ClinicInvoiceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_clinicinvoicelineitem_clinicinvoice");
        });

        modelBuilder.Entity<ClaimsDboCommandStatus>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("CommandStatus");

            entity.Property(e => e.CommandTypeId).HasDefaultValueSql("(newid())");

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
        });

        modelBuilder.Entity<ClaimsDboConditionExclusion>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("ConditionExclusion");

            entity.HasIndex(e => e.Id, "PK_ConditionExclusion")
                .IsUnique();
        });

        modelBuilder.Entity<ClaimsDboConditionLocationMap>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("ConditionLocationMap");

            entity.Property(e => e.ConditionLocation).IsUnicode(false);

            entity.Property(e => e.Inserted).HasColumnType("datetime");

            entity.Property(e => e.LocName).IsUnicode(false);

            entity.Property(e => e.ProposedLocation).IsUnicode(false);

            entity.Property(e => e.RollupConditionName).IsUnicode(false);

            entity.Property(e => e.Updated).HasColumnType("datetime");

            entity.Property(e => e.UpdatedCondition).IsUnicode(false);

            entity.Property(e => e.UpdatedLocation).IsUnicode(false);
        });

        modelBuilder.Entity<ClaimsDboContactRequest>(entity =>
        {
            entity.ToTable("ContactRequest");

            entity.HasIndex(e => new { e.ProcessInstanceId, e.RequestStatus }, "ix_contactrequest_processinstanceid_requeststatus");

            entity.HasIndex(e => new { e.ProcessInstanceId, e.TaskInstanceId }, "ix_contactrequest_taskgeneration");

            entity.Property(e => e.AssociatedDocumentId)
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ConcurrencyToken)
                .IsRequired()
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.Property(e => e.EndDate).HasColumnType("datetime");

            entity.Property(e => e.Message).HasMaxLength(1000);

            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ClaimsDboContactRequestClaim>(entity =>
        {
            entity.ToTable("ContactRequestClaim");

            entity.HasIndex(e => e.ContactRequestId, "ix_contactrequestclaim_contactrequestid");

            entity.HasOne(d => d.ContactRequest)
                .WithMany(p => p.ContactRequestClaims)
                .HasForeignKey(d => d.ContactRequestId)
                .HasConstraintName("fk_contactrequestclaim_contactrequest_contactrequestid");
        });

        modelBuilder.Entity<ClaimsDboContactRequestClaimHistory>(entity =>
        {
            entity.ToTable("ContactRequestClaimHistory");

            entity.HasIndex(e => e.ContactRequestHistoryId, "ix_contactrequestclaimhistory_contactrequesthistoryid");

            entity.HasOne(d => d.ContactRequestHistory)
                .WithMany(p => p.ContactRequestClaimHistories)
                .HasForeignKey(d => d.ContactRequestHistoryId)
                .HasConstraintName("fk_contactrequestclaimhistory_contactrequesthistory_contactrequesthistoryid");
        });

        modelBuilder.Entity<ClaimsDboContactRequestHistory>(entity =>
        {
            entity.ToTable("ContactRequestHistory");

            entity.HasIndex(e => e.ContactRequestId, "ix_contactrequesthistory_contactrequestid");

            entity.Property(e => e.EndDate).HasColumnType("datetime");

            entity.Property(e => e.Message)
                .IsRequired()
                .HasMaxLength(1000);

            entity.Property(e => e.StartDate).HasColumnType("datetime");

            entity.HasOne(d => d.ContactRequest)
                .WithMany(p => p.ContactRequestHistories)
                .HasForeignKey(d => d.ContactRequestId)
                .HasConstraintName("fk_contactrequest_contactrequesthistory_contactrequestid");
        });

        modelBuilder.Entity<ClaimsDboContactRequestMedicalRecordType>(entity =>
        {
            entity.ToTable("ContactRequestMedicalRecordType");

            entity.HasIndex(e => e.ContactRequestId, "ix_contactrequestmedicalrecordtype_contactrequestid");

            entity.Property(e => e.EndDate).HasColumnType("datetime");

            entity.Property(e => e.OtherDetails).HasMaxLength(500);

            entity.Property(e => e.StartDate).HasColumnType("datetime");

            entity.HasOne(d => d.ContactRequest)
                .WithMany(p => p.ContactRequestMedicalRecordTypes)
                .HasForeignKey(d => d.ContactRequestId)
                .HasConstraintName("fk_contactrequest_contactrequestmedicalrecordtype_contactrequestid");

            entity.HasOne(d => d.MedicalRecordType)
                .WithMany(p => p.ContactRequestMedicalRecordTypes)
                .HasForeignKey(d => d.MedicalRecordTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_medicalrecordtype_contactrequestmedicalrecordtype_medicalrecordtypeid");
        });

        modelBuilder.Entity<ClaimsDboContactRequestMedicalRecordTypeHistory>(entity =>
        {
            entity.ToTable("ContactRequestMedicalRecordTypeHistory");

            entity.HasIndex(e => e.ContactRequestHistoryId, "ix_contactrequestmedicalrecordtypehistory_contactrequestid");

            entity.Property(e => e.EndDate).HasColumnType("datetime");

            entity.Property(e => e.OtherDetails).HasMaxLength(500);

            entity.Property(e => e.StartDate).HasColumnType("datetime");

            entity.HasOne(d => d.ContactRequestHistory)
                .WithMany(p => p.ContactRequestMedicalRecordTypeHistories)
                .HasForeignKey(d => d.ContactRequestHistoryId)
                .HasConstraintName("fk_contactrequesthistory_contactrequestmedicalrecordtypehistory_contactrequestid");

            entity.HasOne(d => d.MedicalRecordType)
                .WithMany(p => p.ContactRequestMedicalRecordTypeHistories)
                .HasForeignKey(d => d.MedicalRecordTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_medicalrecordtype_contactrequestmedicalrecordtypehistory_medicalrecordtypeid");
        });

        modelBuilder.Entity<ClaimsDboContactRequestType>(entity =>
        {
            entity.ToTable("ContactRequestType");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            entity.Property(e => e.RequestType)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<ClaimsDboCoverageSummary>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_coveragesummary_id")
                .IsClustered(false);

            entity.ToTable("CoverageSummary");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.HospitalDocumentId).HasMaxLength(30);

            entity.Property(e => e.HospitalDocumentName).HasMaxLength(50);

            entity.Property(e => e.MemberDocumentId)
                .IsRequired()
                .HasMaxLength(30)
                .HasDefaultValueSql("('N/A')");

            entity.Property(e => e.MemberDocumentName)
                .IsRequired()
                .HasMaxLength(50)
                .HasDefaultValueSql("('N/A')");

            entity.Property(e => e.ModifiedOn)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.UserId).HasDefaultValueSql("('BFBF0A71-1F72-4D0D-851B-C3F34ABB4E2E')");

            entity.Property(e => e.VisibleModifiedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<ClaimsDboCoverageSummaryHistory>(entity =>
        {
            entity.HasKey(e => e.Id)
                .IsClustered(false);

            entity.ToTable("CoverageSummaryHistory");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Description).HasMaxLength(50);

            entity.Property(e => e.HospitalDocumentId).HasMaxLength(30);

            entity.Property(e => e.HospitalDocumentName).HasMaxLength(50);

            entity.Property(e => e.IsLocked)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.MemberDocumentId)
                .IsRequired()
                .HasMaxLength(30);

            entity.Property(e => e.MemberDocumentName)
                .IsRequired()
                .HasMaxLength(50);

            entity.Property(e => e.ModifiedOn)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<ClaimsDboCoverageSummaryTrial>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_dbocoveragesummarytrial")
                .IsClustered(false);

            entity.ToTable("CoverageSummaryTrial");

            entity.HasIndex(e => e.InsuredPetId, "ix_coveragesummarytrial_insuredpetid");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.CoverageSummaryDisposition)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<ClaimsDboExclusion>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_exclusion_id")
                .IsClustered(false);

            entity.ToTable("Exclusion");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.ExclusionText).IsRequired();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50);
        });

        modelBuilder.Entity<ClaimsDboExclusionText>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_exclusiontext_id")
                .IsClustered(false);

            entity.ToTable("ExclusionText");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Text)
                .IsRequired()
                .HasMaxLength(1024);

            entity.Property(e => e.VersionNumber)
                .IsRequired()
                .HasMaxLength(50);

            entity.HasOne(d => d.Exclusion)
                .WithMany(p => p.ExclusionTexts)
                .HasForeignKey(d => d.ExclusionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_exclusiontext_exclusionId");
        });

        modelBuilder.Entity<ClaimsDboMedicalRecordType>(entity =>
        {
            entity.ToTable("MedicalRecordType");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<ClaimsDboMedicalRecordTypeRelationship>(entity =>
        {
            entity.ToTable("MedicalRecordTypeRelationship");

            entity.HasOne(d => d.MedicalRecordType)
                .WithMany(p => p.MedicalRecordTypeRelationships)
                .HasForeignKey(d => d.MedicalRecordTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_medicalrecordtype_medicalrecordtyperelationship");
        });

        modelBuilder.Entity<ClaimsDboOnlineClaimSubmission>(entity =>
        {
            entity.ToTable("OnlineClaimSubmission");

            entity.Property(e => e.PolicyNumber)
                .IsRequired()
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ClaimsDboOvertCondition>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("OvertCondition");

            entity.HasIndex(e => e.Id, "PK_OvertCondition")
                .IsUnique();
        });

        modelBuilder.Entity<ClaimsDboPetDeletedExclusion>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("PetDeletedExclusion");

            entity.HasIndex(e => e.Id, "PK_PetDeletedExclusion")
                .IsUnique();
        });

        modelBuilder.Entity<ClaimsDboPolicyExclusionType>(entity =>
        {
            entity.ToTable("PolicyExclusionType");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(500);
        });

        modelBuilder.Entity<ClaimsDboPolicyExclusionTypeDefault>(entity =>
        {
            entity.ToTable("PolicyExclusionTypeDefault");

            entity.HasOne(d => d.PolicyExclusionType)
                .WithMany(p => p.PolicyExclusionTypeDefaults)
                .HasForeignKey(d => d.PolicyExclusionTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_policyexclusiontype_policyexclusiontypedefault");
        });

        modelBuilder.Entity<ClaimsDboSpecialCareEntity>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_specialcareentity_id")
                .IsClustered(false);

            entity.ToTable("SpecialCareEntity");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");

            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<ClaimsDboSpecialCareEntityRouting>(entity =>
        {
            entity.HasKey(e => e.Id)
                .HasName("pk_specialcareentityrouting_id")
                .IsClustered(false);

            entity.ToTable("SpecialCareEntityRouting");

            entity.HasIndex(e => e.SpecialCareEntityId, "ix_specialcareentityrouting_entity");

            entity.HasIndex(e => new { e.SpecialCareEntityId, e.RegardingEnterpriseEntityId }, "uk_specialcareentityrouting_sceid_entypeid")
                .IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");

            entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

            entity.Property(e => e.PriorityId).HasDefaultValueSql("((3))");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
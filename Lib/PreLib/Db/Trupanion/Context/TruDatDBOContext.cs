using Microsoft.EntityFrameworkCore;
using System.Configuration.Provider;
using System.Diagnostics;
using Database.Trupanion.Entity.TruDat.Dbo;
using Utilities.ConnectionStringManager.Base;
using Utilities.Constants.Enum;

namespace Database.Trupanion.Context;

public partial class TruDatDboContext : DbContext
{
    public TruDatDboContext()
    {
    }

    public TruDatDboContext(DbContextOptions<TruDatDboContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TruDatDboAccount> Accounts { get; set; }
    public virtual DbSet<TruDatDboActiveClaim> ActiveClaims { get; set; }
    public virtual DbSet<TruDatDboActiveDirectoryUser> ActiveDirectoryUsers { get; set; }
    public virtual DbSet<TruDatDboActiveDirectoryUserMapping> ActiveDirectoryUserMappings { get; set; }
    public virtual DbSet<TruDatDboAddress> Addresses { get; set; }
    public virtual DbSet<TruDatDboAge> Ages { get; set; }
    public virtual DbSet<TruDatDboAgeFactors2016Ca> AgeFactors2016Cas { get; set; }
    public virtual DbSet<TruDatDboAnimal> Animals { get; set; }
    public virtual DbSet<TruDatDboAnimalB> AnimalBs { get; set; }
    public virtual DbSet<TruDatDboAreaCode> AreaCodes { get; set; }
    public virtual DbSet<TruDatDboAssessmentTemplate> AssessmentTemplates { get; set; }
    public virtual DbSet<TruDatDboAssessmentTemplate2> AssessmentTemplate2s { get; set; }
    public virtual DbSet<TruDatDboAssessmentTemplateForCheck> AssessmentTemplateForChecks { get; set; }
    public virtual DbSet<TruDatDboAssociate> Associates { get; set; }
    public virtual DbSet<TruDatDboAssociateAccount> AssociateAccounts { get; set; }
    public virtual DbSet<TruDatDboAssociateBranchMap> AssociateBranchMaps { get; set; }
    public virtual DbSet<TruDatDboAssociateDatum> AssociateData { get; set; }
    public virtual DbSet<TruDatDboAssociateEnrollmentDatum> AssociateEnrollmentData { get; set; }
    public virtual DbSet<TruDatDboAssociateEnrollmentPending> AssociateEnrollmentPendings { get; set; }
    public virtual DbSet<TruDatDboAssociateEnrollmentWebsitePending> AssociateEnrollmentWebsitePendings { get; set; }
    public virtual DbSet<TruDatDboAssociateGroup> AssociateGroups { get; set; }
    public virtual DbSet<TruDatDboAssociateGroupAssociate> AssociateGroupAssociates { get; set; }
    public virtual DbSet<TruDatDboAssociateGroupSecurable> AssociateGroupSecurables { get; set; }
    public virtual DbSet<TruDatDboAssociatePolicy> AssociatePolicies { get; set; }
    public virtual DbSet<TruDatDboAssociateSecurable> AssociateSecurables { get; set; }
    public virtual DbSet<TruDatDboAssociateWebsiteDatum> AssociateWebsiteData { get; set; }
    public virtual DbSet<TruDatDboAttachment> Attachments { get; set; }
    public virtual DbSet<TruDatDboAttachmentCategory> AttachmentCategories { get; set; }
    public virtual DbSet<TruDatDboAttachmentDisposition> AttachmentDispositions { get; set; }
    public virtual DbSet<TruDatDboAttachmentDocType> AttachmentDocTypes { get; set; }
    public virtual DbSet<TruDatDboAttachmentEmail> AttachmentEmails { get; set; }
    public virtual DbSet<TruDatDboAttachmentEmailReference> AttachmentEmailReferences { get; set; }
    public virtual DbSet<TruDatDboAttachmentFaxInfo> AttachmentFaxInfos { get; set; }
    public virtual DbSet<TruDatDboAttachmentInputType> AttachmentInputTypes { get; set; }
    public virtual DbSet<TruDatDboAttachmentsDupFaxis> AttachmentsDupFaxes { get; set; }
    public virtual DbSet<TruDatDboAttachmentsForPet> AttachmentsForPets { get; set; }
    public virtual DbSet<TruDatDboBankCheck> BankChecks { get; set; }
    public virtual DbSet<TruDatDboBankCheckTransfer> BankCheckTransfers { get; set; }
    public virtual DbSet<TruDatDboBankcheck110110> Bankcheck110110s { get; set; }
    public virtual DbSet<TruDatDboBitmaskNumber> BitmaskNumbers { get; set; }
    public virtual DbSet<TruDatDboBreed> Breeds { get; set; }
    public virtual DbSet<TruDatDboBreed1> Breeds1 { get; set; }
    public virtual DbSet<TruDatDboBreedCharacteristic> BreedCharacteristics { get; set; }
    public virtual DbSet<TruDatDboBreedFactors2015> BreedFactors2015s { get; set; }
    public virtual DbSet<TruDatDboBreedFactors2015Fl> BreedFactors2015Fls { get; set; }
    public virtual DbSet<TruDatDboBreedFactors2016> BreedFactors2016s { get; set; }
    public virtual DbSet<TruDatDboBreedFactorsNy> BreedFactorsNies { get; set; }
    public virtual DbSet<TruDatDboBreedGuide> BreedGuides { get; set; }
    public virtual DbSet<TruDatDboBreedGuideBreed> BreedGuideBreeds { get; set; }
    public virtual DbSet<TruDatDboBreedGuideCharacteristic> BreedGuideCharacteristics { get; set; }
    public virtual DbSet<TruDatDboBreedGuideHealthConcern> BreedGuideHealthConcerns { get; set; }
    public virtual DbSet<TruDatDboBreedGuideTrait> BreedGuideTraits { get; set; }
    public virtual DbSet<TruDatDboBreedHealthConcern> BreedHealthConcerns { get; set; }
    public virtual DbSet<TruDatDboBreedShadow> BreedShadows { get; set; }
    public virtual DbSet<TruDatDboBreedTrait> BreedTraits { get; set; }
    public virtual DbSet<TruDatDboCancelledPolicy> CancelledPolicies { get; set; }
    public virtual DbSet<TruDatDboCappedPolicy> CappedPolicies { get; set; }
    public virtual DbSet<TruDatDboCazip> Cazips { get; set; }
    public virtual DbSet<TruDatDboCharity> Charities { get; set; }
    public virtual DbSet<TruDatDboCharityCountry> CharityCountries { get; set; }
    public virtual DbSet<TruDatDboCharityState> CharityStates { get; set; }
    public virtual DbSet<TruDatDboClaim> Claims { get; set; }
    public virtual DbSet<TruDatDboClaimBatchLetter> ClaimBatchLetters { get; set; }
    public virtual DbSet<TruDatDboClaimClinic> ClaimClinics { get; set; }
    public virtual DbSet<TruDatDboClaimDisposition> ClaimDispositions { get; set; }
    public virtual DbSet<TruDatDboClaimExclusion> ClaimExclusions { get; set; }
    public virtual DbSet<TruDatDboClaimHierarchy> ClaimHierarchies { get; set; }
    public virtual DbSet<TruDatDboClaimPrintHistory> ClaimPrintHistories { get; set; }
    public virtual DbSet<TruDatDboClaimProcess> ClaimProcesses { get; set; }
    public virtual DbSet<TruDatDboClaimReviewed> ClaimRevieweds { get; set; }
    public virtual DbSet<TruDatDboClaimReviewedEventSource> ClaimReviewedEventSources { get; set; }
    public virtual DbSet<TruDatDboClaimStatusLetter> ClaimStatusLetters { get; set; }
    public virtual DbSet<TruDatDboClaimType> ClaimTypes { get; set; }
    public virtual DbSet<TruDatDboClaimVersion> ClaimVersions { get; set; }
    public virtual DbSet<TruDatDboClaimWorkflowSpecialBucket> ClaimWorkflowSpecialBuckets { get; set; }
    public virtual DbSet<TruDatDboClaimWorkflowViewInstrumentation> ClaimWorkflowViewInstrumentations { get; set; }
    public virtual DbSet<TruDatDboClaimWorkflowViewStatsDebug> ClaimWorkflowViewStatsDebugs { get; set; }
    public virtual DbSet<TruDatDboClaimWorkflowViewStatus> ClaimWorkflowViewStatuses { get; set; }
    public virtual DbSet<TruDatDboClaimWorkflowViewStatusArchive> ClaimWorkflowViewStatusArchives { get; set; }
    public virtual DbSet<TruDatDboClaimsAdjuster> ClaimsAdjusters { get; set; }
    public virtual DbSet<TruDatDboClaimsTemplate> ClaimsTemplates { get; set; }
    public virtual DbSet<TruDatDboClaimsWeDontCountForUser> ClaimsWeDontCountForUsers { get; set; }
    public virtual DbSet<TruDatDboClinic> Clinics { get; set; }
    public virtual DbSet<TruDatDboClinicAttribute> ClinicAttributes { get; set; }
    public virtual DbSet<TruDatDboClinicBackup0222> ClinicBackup0222s { get; set; }
    public virtual DbSet<TruDatDboClinicBackup060610> ClinicBackup060610s { get; set; }
    public virtual DbSet<TruDatDboClinicPartner> ClinicPartners { get; set; }
    public virtual DbSet<TruDatDboClinicPartnerBackup07012010> ClinicPartnerBackup07012010s { get; set; }
    public virtual DbSet<TruDatDboClinicPet> ClinicPets { get; set; }
    public virtual DbSet<TruDatDboClinicPsi> ClinicPsis { get; set; }
    public virtual DbSet<TruDatDboClinicRisk> ClinicRisks { get; set; }
    public virtual DbSet<TruDatDboClinicText> ClinicTexts { get; set; }
    public virtual DbSet<TruDatDboClinicVmg> ClinicVmgs { get; set; }
    public virtual DbSet<TruDatDboClinicVmgPrior> ClinicVmgPriors { get; set; }
    public virtual DbSet<TruDatDboClinicVmgimport> ClinicVmgimports { get; set; }
    public virtual DbSet<TruDatDboClinicVpg> ClinicVpgs { get; set; }
    public virtual DbSet<TruDatDboClinicVpgimport> ClinicVpgimports { get; set; }
    public virtual DbSet<TruDatDboClinicVpgprior> ClinicVpgpriors { get; set; }
    public virtual DbSet<TruDatDboClinicvpgOld> ClinicvpgOlds { get; set; }
    public virtual DbSet<TruDatDboCodesToRemove> CodesToRemoves { get; set; }
    public virtual DbSet<TruDatDboCommandMonitor> CommandMonitors { get; set; }
    public virtual DbSet<TruDatDboCommentsPreFix> CommentsPreFixes { get; set; }
    public virtual DbSet<TruDatDboCommissionModelTiming> CommissionModelTimings { get; set; }
    public virtual DbSet<TruDatDboCommunicationPreference> CommunicationPreferences { get; set; }
    public virtual DbSet<TruDatDboCompetitorComparison> CompetitorComparisons { get; set; }
    public virtual DbSet<TruDatDboCompletedClaim> CompletedClaims { get; set; }
    public virtual DbSet<TruDatDboConditionType> ConditionTypes { get; set; }
    public virtual DbSet<TruDatDboConstant> Constants { get; set; }
    public virtual DbSet<TruDatDboContact> Contacts { get; set; }
    public virtual DbSet<TruDatDboContactMethod> ContactMethods { get; set; }
    public virtual DbSet<TruDatDboContactType> ContactTypes { get; set; }
    public virtual DbSet<TruDatDboCorporateAccount> CorporateAccounts { get; set; }
    public virtual DbSet<TruDatDboCorporateAccountAddress> CorporateAccountAddresses { get; set; }
    public virtual DbSet<TruDatDboCorporateAccountCampaignInstance> CorporateAccountCampaignInstances { get; set; }
    public virtual DbSet<TruDatDboCorporateAccountVoucher> CorporateAccountVouchers { get; set; }
    public virtual DbSet<TruDatDboCost> Costs { get; set; }
    public virtual DbSet<TruDatDboCountry> Countries { get; set; }
    public virtual DbSet<TruDatDboCounty> Counties { get; set; }
    public virtual DbSet<TruDatDboCreditCardType> CreditCardTypes { get; set; }
    public virtual DbSet<TruDatDboCurrentStatePricingEngine> CurrentStatePricingEngines { get; set; }
    public virtual DbSet<TruDatDboDedHistoryImport> DedHistoryImports { get; set; }
    public virtual DbSet<TruDatDboDmsClaimPetInfo> DmsClaimPetInfos { get; set; }
    public virtual DbSet<TruDatDboDmsImportAttachment> DmsImportAttachments { get; set; }
    public virtual DbSet<TruDatDboDmsPetInfo> DmsPetInfos { get; set; }
    public virtual DbSet<TruDatDboDotNetDataType> DotNetDataTypes { get; set; }
    public virtual DbSet<TruDatDboDoubleIncrease> DoubleIncreases { get; set; }
    public virtual DbSet<TruDatDboEligibleCondNoOther> EligibleCondNoOthers { get; set; }
    public virtual DbSet<TruDatDboEligibleConditionExport> EligibleConditionExports { get; set; }
    public virtual DbSet<TruDatDboEligibleConditionsNoNull> EligibleConditionsNoNulls { get; set; }
    public virtual DbSet<TruDatDboEmailHistory> EmailHistories { get; set; }
    public virtual DbSet<TruDatDboEmailSnippet> EmailSnippets { get; set; }
    public virtual DbSet<TruDatDboEmergencyZipcode> EmergencyZipcodes { get; set; }
    public virtual DbSet<TruDatDboEmployeesToUpgrade> EmployeesToUpgrades { get; set; }
    public virtual DbSet<TruDatDboEnrolledPolicy> EnrolledPolicies { get; set; }
    public virtual DbSet<TruDatDboEnrollmentQuote> EnrollmentQuotes { get; set; }
    public virtual DbSet<TruDatDboEnrollmentQuotePetPolicy> EnrollmentQuotePetPolicies { get; set; }
    public virtual DbSet<TruDatDboEntity> Entities { get; set; }
    public virtual DbSet<TruDatDboEntityAddress> EntityAddresses { get; set; }
    public virtual DbSet<TruDatDboEntityBankAccount> EntityBankAccounts { get; set; }
    public virtual DbSet<TruDatDboEntityCategory> EntityCategories { get; set; }
    public virtual DbSet<TruDatDboEntityContact> EntityContacts { get; set; }
    public virtual DbSet<TruDatDboEntityList> EntityLists { get; set; }
    public virtual DbSet<TruDatDboEntityListAssociate> EntityListAssociates { get; set; }
    public virtual DbSet<TruDatDboEntityListBluePearl> EntityListBluePearls { get; set; }
    public virtual DbSet<TruDatDboEntityListPetCo> EntityListPetCos { get; set; }
    public virtual DbSet<TruDatDboEntityLock> EntityLocks { get; set; }
    public virtual DbSet<TruDatDboEntityNote> EntityNotes { get; set; }
    public virtual DbSet<TruDatDboEntityNoteBackup> EntityNoteBackups { get; set; }
    public virtual DbSet<TruDatDboEntityNoteOrigin> EntityNoteOrigins { get; set; }
    public virtual DbSet<TruDatDboEntityReview> EntityReviews { get; set; }
    public virtual DbSet<TruDatDboEntityScore> EntityScores { get; set; }
    public virtual DbSet<TruDatDboEntityTree> EntityTrees { get; set; }
    public virtual DbSet<TruDatDboEntityTreeAttribute> EntityTreeAttributes { get; set; }
    public virtual DbSet<TruDatDboEntityTreeBranchMap> EntityTreeBranchMaps { get; set; }
    public virtual DbSet<TruDatDboFaxInProgress> FaxInProgresses { get; set; }
    public virtual DbSet<TruDatDboFaxLine> FaxLines { get; set; }
    public virtual DbSet<TruDatDboFaxLineNumber> FaxLineNumbers { get; set; }
    public virtual DbSet<TruDatDboFaxOnHold> FaxOnHolds { get; set; }
    public virtual DbSet<TruDatDboFaxQueueConfiguration> FaxQueueConfigurations { get; set; }
    public virtual DbSet<TruDatDboFeedback> Feedbacks { get; set; }
    public virtual DbSet<TruDatDboFixThese> FixTheses { get; set; }
    public virtual DbSet<TruDatDboGeoFactors2015> GeoFactors2015s { get; set; }
    public virtual DbSet<TruDatDboGeoFactors2015Ca> GeoFactors2015Cas { get; set; }
    public virtual DbSet<TruDatDboGeoFactors2015Fl> GeoFactors2015Fls { get; set; }
    public virtual DbSet<TruDatDboGeoFactors2015Sc> GeoFactors2015Scs { get; set; }
    public virtual DbSet<TruDatDboGeoFactors2016> GeoFactors2016s { get; set; }
    public virtual DbSet<TruDatDboGeoFactors2016Ca> GeoFactors2016Cas { get; set; }
    public virtual DbSet<TruDatDboGeoFactorsLaNy> GeoFactorsLaNies { get; set; }
    public virtual DbSet<TruDatDboGeoFactorsNj> GeoFactorsNjs { get; set; }
    public virtual DbSet<TruDatDboGeoRegion> GeoRegions { get; set; }
    public virtual DbSet<TruDatDboGuruError> GuruErrors { get; set; }
    public virtual DbSet<TruDatDboHowDidYouHearAboutU> HowDidYouHearAboutUs { get; set; }
    public virtual DbSet<TruDatDboHsbcreportFile> HsbcreportFiles { get; set; }
    public virtual DbSet<TruDatDboHsbctransmissionFile> HsbctransmissionFiles { get; set; }
    public virtual DbSet<TruDatDboIncrease> Increases { get; set; }
    public virtual DbSet<TruDatDboIncrease82010> Increase82010s { get; set; }
    public virtual DbSet<TruDatDboIncrease82010Merge> Increase82010Merges { get; set; }
    public virtual DbSet<TruDatDboIncrease82010Verify> Increase82010Verifies { get; set; }
    public virtual DbSet<TruDatDboIncrease92010> Increase92010s { get; set; }
    public virtual DbSet<TruDatDboIncrease92010Merge> Increase92010Merges { get; set; }
    public virtual DbSet<TruDatDboIncrease92010Verify> Increase92010Verifies { get; set; }
    public virtual DbSet<TruDatDboKnoticeDatum> KnoticeData { get; set; }
    public virtual DbSet<TruDatDboKnoticeEmailListCa> KnoticeEmailListCas { get; set; }
    public virtual DbSet<TruDatDboLanguage> Languages { get; set; }
    public virtual DbSet<TruDatDboMdrefundDatum> MdrefundData { get; set; }
    public virtual DbSet<TruDatDboMdrefundParameter> MdrefundParameters { get; set; }
    public virtual DbSet<TruDatDboMemberPortalExportUser> MemberPortalExportUsers { get; set; }
    public virtual DbSet<TruDatDboMigrationHistory> MigrationHistories { get; set; }
    public virtual DbSet<TruDatDboMissedIncrease> MissedIncreases { get; set; }
    public virtual DbSet<TruDatDboMissingClaim> MissingClaims { get; set; }
    public virtual DbSet<TruDatDboMissingLeadSource> MissingLeadSources { get; set; }
    public virtual DbSet<TruDatDboMissingOrder> MissingOrders { get; set; }
    public virtual DbSet<TruDatDboNewCanadaZip> NewCanadaZips { get; set; }
    public virtual DbSet<TruDatDboNewYorkEligiblePolicy> NewYorkEligiblePolicies { get; set; }
    public virtual DbSet<TruDatDboNonTrendActiveEngine> NonTrendActiveEngines { get; set; }
    public virtual DbSet<TruDatDboObservation> Observations { get; set; }
    public virtual DbSet<TruDatDboObservationType> ObservationTypes { get; set; }
    public virtual DbSet<TruDatDboOtherInfo> OtherInfos { get; set; }
    public virtual DbSet<TruDatDboOwner> Owners { get; set; }
    public virtual DbSet<TruDatDboOwnerAddress> OwnerAddresses { get; set; }
    public virtual DbSet<TruDatDboOwnerAlternateName> OwnerAlternateNames { get; set; }
    public virtual DbSet<TruDatDboOwnerAlternateNameText> OwnerAlternateNameTexts { get; set; }
    public virtual DbSet<TruDatDboOwnerAssociation> OwnerAssociations { get; set; }
    public virtual DbSet<TruDatDboOwnerAttribute> OwnerAttributes { get; set; }
    public virtual DbSet<TruDatDboOwnerCharity> OwnerCharities { get; set; }
    public virtual DbSet<TruDatDboOwnerCharityEffective> OwnerCharityEffectives { get; set; }
    public virtual DbSet<TruDatDboOwnerCorporateAccountHistory> OwnerCorporateAccountHistories { get; set; }
    public virtual DbSet<TruDatDboOwnerEmailCategory> OwnerEmailCategories { get; set; }
    public virtual DbSet<TruDatDboOwnerFailedPaymentDatum> OwnerFailedPaymentData { get; set; }
    public virtual DbSet<TruDatDboOwnerInvestigation> OwnerInvestigations { get; set; }
    public virtual DbSet<TruDatDboOwnerLanguagePreference> OwnerLanguagePreferences { get; set; }
    public virtual DbSet<TruDatDboOwnerManualRateLetter> OwnerManualRateLetters { get; set; }
    public virtual DbSet<TruDatDboOwnerPendingRateChange> OwnerPendingRateChanges { get; set; }
    public virtual DbSet<TruDatDboOwnerPolicyHolderUntil> OwnerPolicyHolderUntils { get; set; }
    public virtual DbSet<TruDatDboOwnerText> OwnerTexts { get; set; }
    public virtual DbSet<TruDatDboOwnerVisionClaimMigrationStatus> OwnerVisionClaimMigrationStatuses { get; set; }
    public virtual DbSet<TruDatDboOwnerVisionClaimSyncStatus> OwnerVisionClaimSyncStatuses { get; set; }
    public virtual DbSet<TruDatDboOwnerVisionPolicyMigrationStatus> OwnerVisionPolicyMigrationStatuses { get; set; }
    public virtual DbSet<TruDatDboPartner> Partners { get; set; }
    public virtual DbSet<TruDatDboPartnerProjection> PartnerProjections { get; set; }
    public virtual DbSet<TruDatDboPartnerSignup> PartnerSignups { get; set; }
    public virtual DbSet<TruDatDboPartnerZipcode> PartnerZipcodes { get; set; }
    public virtual DbSet<TruDatDboPartnerZipcodePattern> PartnerZipcodePatterns { get; set; }
    public virtual DbSet<TruDatDboPartnershipGroup> PartnershipGroups { get; set; }
    public virtual DbSet<TruDatDboPendingPremium> PendingPremiums { get; set; }
    public virtual DbSet<TruDatDboPerformanceTraceDatum> PerformanceTraceData { get; set; }
    public virtual DbSet<TruDatDboPet> Pets { get; set; }
    public virtual DbSet<TruDatDboPetAttribute> PetAttributes { get; set; }
    public virtual DbSet<TruDatDboPetFood> PetFoods { get; set; }
    public virtual DbSet<TruDatDboPetPolicy> PetPolicies { get; set; }
    public virtual DbSet<TruDatDboPetPolicyAction> PetPolicyActions { get; set; }
    public virtual DbSet<TruDatDboPetPolicyActionHistory> PetPolicyActionHistories { get; set; }
    public virtual DbSet<TruDatDboPetPolicyActionInitalEnrollment> PetPolicyActionInitalEnrollments { get; set; }
    public virtual DbSet<TruDatDboPetPolicyActionLast> PetPolicyActionLasts { get; set; }
    public virtual DbSet<TruDatDboPetPolicyActionLastEnrollment> PetPolicyActionLastEnrollments { get; set; }
    public virtual DbSet<TruDatDboPetPolicyActionLastTag> PetPolicyActionLastTags { get; set; }
    public virtual DbSet<TruDatDboPetPolicyActionWithPetId> PetPolicyActionWithPetIds { get; set; }
    public virtual DbSet<TruDatDboPetPolicyAssociation> PetPolicyAssociations { get; set; }
    public virtual DbSet<TruDatDboPetPolicyAttribute> PetPolicyAttributes { get; set; }
    public virtual DbSet<TruDatDboPetPolicyCancelInfo> PetPolicyCancelInfos { get; set; }
    public virtual DbSet<TruDatDboPetPolicyCancelInfoView> PetPolicyCancelInfoViews { get; set; }
    public virtual DbSet<TruDatDboPetPolicyClinic> PetPolicyClinics { get; set; }
    public virtual DbSet<TruDatDboPetPolicyCost> PetPolicyCosts { get; set; }
    public virtual DbSet<TruDatDboPetPolicyCostSaveAudit> PetPolicyCostSaveAudits { get; set; }
    public virtual DbSet<TruDatDboPetPolicyLastRateAdjustment> PetPolicyLastRateAdjustments { get; set; }
    public virtual DbSet<TruDatDboPetPolicyPartner> PetPolicyPartners { get; set; }
    public virtual DbSet<TruDatDboPetPolicyRateAdjustment> PetPolicyRateAdjustments { get; set; }
    public virtual DbSet<TruDatDboPetPolicyRateCommunication> PetPolicyRateCommunications { get; set; }
    public virtual DbSet<TruDatDboPetPolicyRateFactorEffective> PetPolicyRateFactorEffectives { get; set; }
    public virtual DbSet<TruDatDboPetPolicyRatePendingChange> PetPolicyRatePendingChanges { get; set; }
    public virtual DbSet<TruDatDboPetPolicyReferral> PetPolicyReferrals { get; set; }
    public virtual DbSet<TruDatDboPetPolicyTagNumber> PetPolicyTagNumbers { get; set; }
    public virtual DbSet<TruDatDboPetPolicyText> PetPolicyTexts { get; set; }
    public virtual DbSet<TruDatDboPetPolicyVersion> PetPolicyVersions { get; set; }
    public virtual DbSet<TruDatDboPetPolicyVoucher> PetPolicyVouchers { get; set; }
    public virtual DbSet<TruDatDboPetPolicyWebPartner> PetPolicyWebPartners { get; set; }
    public virtual DbSet<TruDatDboPetReferral> PetReferrals { get; set; }
    public virtual DbSet<TruDatDboPetWorkingPet> PetWorkingPets { get; set; }
    public virtual DbSet<TruDatDboPirlead> Pirleads { get; set; }
    public virtual DbSet<TruDatDboPolicy> Policies { get; set; }
    public virtual DbSet<TruDatDboPolicy2014BreedFactor> Policy2014BreedFactors { get; set; }
    public virtual DbSet<TruDatDboPolicy2014GeoFactor> Policy2014GeoFactors { get; set; }
    public virtual DbSet<TruDatDboPolicyAttribute> PolicyAttributes { get; set; }
    public virtual DbSet<TruDatDboPolicyDeclarationPage> PolicyDeclarationPages { get; set; }
    public virtual DbSet<TruDatDboPolicyDocType> PolicyDocTypes { get; set; }
    public virtual DbSet<TruDatDboPolicyNumberBatch> PolicyNumberBatches { get; set; }
    public virtual DbSet<TruDatDboPolicyOption> PolicyOptions { get; set; }
    public virtual DbSet<TruDatDboPolicyOptionRequiredDoc> PolicyOptionRequiredDocs { get; set; }
    public virtual DbSet<TruDatDboPolicyOptionState> PolicyOptionStates { get; set; }
    public virtual DbSet<TruDatDboPolicyOptionType> PolicyOptionTypes { get; set; }
    public virtual DbSet<TruDatDboPolicyRequiredDoc> PolicyRequiredDocs { get; set; }
    public virtual DbSet<TruDatDboPolicyState> PolicyStates { get; set; }
    public virtual DbSet<TruDatDboPolicyVersion> PolicyVersions { get; set; }
    public virtual DbSet<TruDatDboPreferredPartnership> PreferredPartnerships { get; set; }
    public virtual DbSet<TruDatDboPriceIncrease> PriceIncreases { get; set; }
    public virtual DbSet<TruDatDboRateAdjRedoPuertoRico> RateAdjRedoPuertoRicos { get; set; }
    public virtual DbSet<TruDatDboRateAdjustmentCorrection> RateAdjustmentCorrections { get; set; }
    public virtual DbSet<TruDatDboRateAdjustmentCorrectionUnderBilled> RateAdjustmentCorrectionUnderBilleds { get; set; }
    public virtual DbSet<TruDatDboRateChangeFix> RateChangeFixes { get; set; }
    public virtual DbSet<TruDatDboRateNoticeDailyLimit> RateNoticeDailyLimits { get; set; }
    public virtual DbSet<TruDatDboReciprocalLink> ReciprocalLinks { get; set; }
    public virtual DbSet<TruDatDboReferral> Referrals { get; set; }
    public virtual DbSet<TruDatDboReferralMapping> ReferralMappings { get; set; }
    public virtual DbSet<TruDatDboReminder> Reminders { get; set; }
    public virtual DbSet<TruDatDboReviewPolicy> ReviewPolicies { get; set; }
    public virtual DbSet<TruDatDboRole> Roles { get; set; }
    public virtual DbSet<TruDatDboScore> Scores { get; set; }
    public virtual DbSet<TruDatDboSecurable> Securables { get; set; }
    public virtual DbSet<TruDatDboSecurableEntityRelation> SecurableEntityRelations { get; set; }
    public virtual DbSet<TruDatDboSession> Sessions { get; set; }
    public virtual DbSet<TruDatDboSfVetClinicsCount> SfVetClinicsCounts { get; set; }
    public virtual DbSet<TruDatDboSfclinicBackup> SfclinicBackups { get; set; }
    public virtual DbSet<TruDatDboShadowAnimalImage> ShadowAnimalImages { get; set; }
    public virtual DbSet<TruDatDboState> States { get; set; }
    public virtual DbSet<TruDatDboStateAttribute> StateAttributes { get; set; }
    public virtual DbSet<TruDatDboStateCodeNotApproved> StateCodeNotApproveds { get; set; }
    public virtual DbSet<TruDatDboStatus> Statuses { get; set; }
    public virtual DbSet<TruDatDboStatusBranchMap> StatusBranchMaps { get; set; }
    public virtual DbSet<TruDatDboStatusGroup> StatusGroups { get; set; }
    public virtual DbSet<TruDatDboStatusSummary> StatusSummaries { get; set; }
    public virtual DbSet<TruDatDboTask> Tasks { get; set; }
    public virtual DbSet<TruDatDboTaskEmail> TaskEmails { get; set; }
    public virtual DbSet<TruDatDboTaskEmailRecipient> TaskEmailRecipients { get; set; }
    public virtual DbSet<TruDatDboTaskType> TaskTypes { get; set; }
    public virtual DbSet<TruDatDboTemplettersdataCccan> TemplettersdataCccans { get; set; }
    public virtual DbSet<TruDatDboTemplettersdataCccan20091130to20100127> TemplettersdataCccan20091130to20100127s { get; set; }
    public virtual DbSet<TruDatDboTemplettersdataCccan20100127to20100226> TemplettersdataCccan20100127to20100226s { get; set; }
    public virtual DbSet<TruDatDboTemplettersdataCccan20100127to20100226Letter2> TemplettersdataCccan20100127to20100226Letter2s { get; set; }
    public virtual DbSet<TruDatDboTemplettersdataCccan20100321to20100417Letter1> TemplettersdataCccan20100321to20100417Letter1s { get; set; }
    public virtual DbSet<TruDatDboTemplettersdataCccanCancellationNotice20100301> TemplettersdataCccanCancellationNotice20100301s { get; set; }
    public virtual DbSet<TruDatDboTemplettersdataCccanGrpBletter3> TemplettersdataCccanGrpBletter3s { get; set; }
    public virtual DbSet<TruDatDboTemplettersdataCccanGrpCletter1> TemplettersdataCccanGrpCletter1s { get; set; }
    public virtual DbSet<TruDatDboTemplettersdataCccanGrpCletter2> TemplettersdataCccanGrpCletter2s { get; set; }
    public virtual DbSet<TruDatDboTemplettersdataCccanGrpCletter3> TemplettersdataCccanGrpCletter3s { get; set; }
    public virtual DbSet<TruDatDboTemplettersdataCcusa> TemplettersdataCcusas { get; set; }
    public virtual DbSet<TruDatDboTemplettersdataCcusa20091130to20100127> TemplettersdataCcusa20091130to20100127s { get; set; }
    public virtual DbSet<TruDatDboTemplettersdataCcusa20100127to20100226> TemplettersdataCcusa20100127to20100226s { get; set; }
    public virtual DbSet<TruDatDboTemplettersdataCcusa20100127to20100226Letter2> TemplettersdataCcusa20100127to20100226Letter2s { get; set; }
    public virtual DbSet<TruDatDboTemplettersdataCcusa20100321to20100417Letter1> TemplettersdataCcusa20100321to20100417Letter1s { get; set; }
    public virtual DbSet<TruDatDboTemplettersdataCcusacancellationNotice20100301> TemplettersdataCcusacancellationNotice20100301s { get; set; }
    public virtual DbSet<TruDatDboTemplettersdataCcusagrpBletter3> TemplettersdataCcusagrpBletter3s { get; set; }
    public virtual DbSet<TruDatDboTemplettersdataCcusagrpCletter1> TemplettersdataCcusagrpCletter1s { get; set; }
    public virtual DbSet<TruDatDboTemplettersdataCcusagrpCletter2> TemplettersdataCcusagrpCletter2s { get; set; }
    public virtual DbSet<TruDatDboTemplettersdataCcusagrpCletter3> TemplettersdataCcusagrpCletter3s { get; set; }
    public virtual DbSet<TruDatDboTemplettersdataHsbc> TemplettersdataHsbcs { get; set; }
    public virtual DbSet<TruDatDboTemplettersdataHsbc20091130to20100127> TemplettersdataHsbc20091130to20100127s { get; set; }
    public virtual DbSet<TruDatDboTemplettersdataHsbc20100127to20100226> TemplettersdataHsbc20100127to20100226s { get; set; }
    public virtual DbSet<TruDatDboTemplettersdataHsbc20100127to20100226Letter2> TemplettersdataHsbc20100127to20100226Letter2s { get; set; }
    public virtual DbSet<TruDatDboTemplettersdataHsbc20100310to20100417Letter1> TemplettersdataHsbc20100310to20100417Letter1s { get; set; }
    public virtual DbSet<TruDatDboTemplettersdataHsbccancellationNotice20100301> TemplettersdataHsbccancellationNotice20100301s { get; set; }
    public virtual DbSet<TruDatDboTemplettersdataHsbcgrpBletter3> TemplettersdataHsbcgrpBletter3s { get; set; }
    public virtual DbSet<TruDatDboTemplettersdataHsbcgrpCletter1> TemplettersdataHsbcgrpCletter1s { get; set; }
    public virtual DbSet<TruDatDboTemplettersdataHsbcgrpCletter2> TemplettersdataHsbcgrpCletter2s { get; set; }
    public virtual DbSet<TruDatDboTemplettersdataHsbcgrpCletter3> TemplettersdataHsbcgrpCletter3s { get; set; }
    public virtual DbSet<TruDatDboTpemailCategory> TpemailCategories { get; set; }
    public virtual DbSet<TruDatDboTpopportunity> Tpopportunities { get; set; }
    public virtual DbSet<TruDatDboTpquestion> Tpquestions { get; set; }
    public virtual DbSet<TruDatDboTptableverify> Tptableverifies { get; set; }
    public virtual DbSet<TruDatDboTrialPolicy> TrialPolicies { get; set; }
    public virtual DbSet<TruDatDboUnassignedFaxesNotPilot> UnassignedFaxesNotPilots { get; set; }
    public virtual DbSet<TruDatDboUnassignedFaxis> UnassignedFaxes { get; set; }
    public virtual DbSet<TruDatDboUser> Users { get; set; }
    public virtual DbSet<TruDatDboUserBio> UserBios { get; set; }
    public virtual DbSet<TruDatDboUserBioCategory> UserBioCategories { get; set; }
    public virtual DbSet<TruDatDboUserGroup> UserGroups { get; set; }
    public virtual DbSet<TruDatDboUserSecurable> UserSecurables { get; set; }
    public virtual DbSet<TruDatDboUsersGroup> UsersGroups { get; set; }
    public virtual DbSet<TruDatDboUszip> Uszips { get; set; }
    public virtual DbSet<TruDatDboVoucher> Vouchers { get; set; }
    public virtual DbSet<TruDatDboVoucherAgeValidation> VoucherAgeValidations { get; set; }
    public virtual DbSet<TruDatDboVoucherAgeValidationBackup> VoucherAgeValidationBackups { get; set; }
    public virtual DbSet<TruDatDboVoucherAttribute> VoucherAttributes { get; set; }
    public virtual DbSet<TruDatDboVoucherBackup> VoucherBackups { get; set; }
    public virtual DbSet<TruDatDboVoucherCountryValidation> VoucherCountryValidations { get; set; }
    public virtual DbSet<TruDatDboVoucherCountryValidationBackup> VoucherCountryValidationBackups { get; set; }
    public virtual DbSet<TruDatDboVoucherOptOut> VoucherOptOuts { get; set; }
    public virtual DbSet<TruDatDboVoucherOverridePolicy> VoucherOverridePolicies { get; set; }
    public virtual DbSet<TruDatDboVoucherOverridePolicyOld> VoucherOverridePolicyOlds { get; set; }
    public virtual DbSet<TruDatDboVoucherReminder> VoucherReminders { get; set; }
    public virtual DbSet<TruDatDboVoucherText> VoucherTexts { get; set; }
    public virtual DbSet<TruDatDboVoucherTrialPeriod> VoucherTrialPeriods { get; set; }
    public virtual DbSet<TruDatDboVoucherTrialPeriodBackup> VoucherTrialPeriodBackups { get; set; }
    public virtual DbSet<TruDatDboWebPartner> WebPartners { get; set; }
    public virtual DbSet<TruDatDboWebPartnerPolicy> WebPartnerPolicies { get; set; }
    public virtual DbSet<TruDatDboWebPartnerText> WebPartnerTexts { get; set; }
    public virtual DbSet<TruDatDboWebpartnerBackup> WebpartnerBackups { get; set; }
    public virtual DbSet<TruDatDboWelcomeKits0803> WelcomeKits0803s { get; set; }
    public virtual DbSet<TruDatDboWhatClinicsAreTheseFor> WhatClinicsAreTheseFors { get; set; }
    public virtual DbSet<TruDatDboWorkflowCase> WorkflowCases { get; set; }
    public virtual DbSet<TruDatDboWorkflowCaseAction> WorkflowCaseActions { get; set; }
    public virtual DbSet<TruDatDboWorkflowCaseConfig> WorkflowCaseConfigs { get; set; }
    public virtual DbSet<TruDatDboWorkflowEmail> WorkflowEmails { get; set; }
    public virtual DbSet<TruDatDboWorkflowGroup> WorkflowGroups { get; set; }
    public virtual DbSet<TruDatDboWorkflowGroupUser> WorkflowGroupUsers { get; set; }
    public virtual DbSet<TruDatDboWorkflowQueue> WorkflowQueues { get; set; }
    public virtual DbSet<TruDatDboWorkflowQueueLock> WorkflowQueueLocks { get; set; }
    public virtual DbSet<TruDatDboWorkflowQueueUser> WorkflowQueueUsers { get; set; }
    public virtual DbSet<TruDatDboWorkingPet> WorkingPets { get; set; }
    public virtual DbSet<TruDatDboWorkingPetCategory> WorkingPetCategories { get; set; }
    public virtual DbSet<TruDatDboWrkCodePath> WrkCodePaths { get; set; }
    public virtual DbSet<TruDatDboWrkPotentialPet> WrkPotentialPets { get; set; }
    public virtual DbSet<TruDatDboZipCodesDatabaseDeluxeBusiness> ZipCodesDatabaseDeluxeBusinesses { get; set; }
    public virtual DbSet<TruDatDboZipcode> Zipcodes { get; set; }
    public virtual DbSet<TruDatDboZipcodeCopy07232012> ZipcodeCopy07232012s { get; set; }
    public virtual DbSet<TruDatDbo_20100615SentPastDueEmail> _20100615SentPastDueEmails { get; set; }

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

        modelBuilder.Entity<TruDatDboAccount>(entity =>
        {
            entity.ToTable("Account");

            entity.Property(e => e.AccountNumber)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Country)
                .WithMany(p => p.Accounts)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_countryId_account");
        });

        modelBuilder.Entity<TruDatDboActiveClaim>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ActiveClaim");

            entity.Property(e => e.AssessmentDataInserted).HasColumnType("datetime");

            entity.Property(e => e.ClaimInserted).HasColumnType("datetime");
        });

        modelBuilder.Entity<TruDatDboActiveDirectoryUser>(entity =>
        {
            entity.ToTable("ActiveDirectoryUser");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.UserName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.IdNavigation)
                .WithOne(p => p.ActiveDirectoryUser)
                .HasForeignKey<TruDatDboActiveDirectoryUser>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_activedirectoryuser_users");
        });

        modelBuilder.Entity<TruDatDboActiveDirectoryUserMapping>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ActiveDirectoryUserMapping");

            entity.Property(e => e.Adname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ADName");

            entity.Property(e => e.Poname)
                .IsRequired()
                .HasMaxLength(100)
            .IsUnicode(false)
                .HasColumnName("POName");
        });

        modelBuilder.Entity<TruDatDboAddress>(entity =>
        {
            entity.ToTable("Address");

            entity.HasIndex(e => e.Name, "uk_address_nme")
                .IsUnique();

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");

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

        modelBuilder.Entity<TruDatDboAge>(entity =>
        {
            entity.ToTable("Age", "dbo");

//            entity.HasKey(e => e.Id).HasName("pk_age_id");

//            entity.HasIndex(e => e.Name, "uk_age_nme")
//                .IsUnique();

//            entity.HasIndex(e => e.PetCharacteristicUniqueId, "uk_dboage_pcuid")
//                .IsUnique();
//
//            entity.HasIndex(e => e.ProductFactorInstanceUniqueId, "uk_dboage_pfiuid")
//                .IsUnique();

//            entity.Property(e => e.Active)
//                .IsRequired()
//                .HasDefaultValueSql("((1))");
//
//            entity.Property(e => e.AgeYearFrom).HasColumnType("numeric(4, 2)");
//
//            entity.Property(e => e.AgeYearTo).HasColumnType("numeric(4, 2)");
//
//            entity.Property(e => e.Inserted)
//                .HasColumnType("datetime")
//                .HasDefaultValueSql("(getdate())");
//
//            entity.Property(e => e.Name)
//                .IsRequired()
//                .HasMaxLength(100)
//                .IsUnicode(false);
//
//            entity.Property(e => e.PetCharacteristicUniqueId).HasDefaultValueSql("(newid())");
//
//            entity.Property(e => e.ProductFactorInstanceUniqueId).HasDefaultValueSql("(newid())");
//
//            entity.Property(e => e.Updated)
//                .HasColumnType("datetime")
//                .HasDefaultValueSql("(getdate())");
//
//            entity.Property(e => e.ValidForEnrollment)
//                .IsRequired()
//                .HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<TruDatDboAgeFactors2016Ca>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("AgeFactors2016CA");

            entity.Property(e => e.AgeGroupName)
                .HasMaxLength(256)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboAnimal>(entity =>
        {
            entity.ToTable("Animal");

            entity.HasIndex(e => e.Name, "uk_animal_nme")
                .IsUnique();

            entity.HasIndex(e => e.PetCharacteristicUniqueId, "uk_dboanimal_pcuid")
                .IsUnique();

            entity.HasIndex(e => e.ProductFactorInstanceUniqueId, "uk_dboanimal_pfiuid")
                .IsUnique();

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PetCharacteristicUniqueId).HasDefaultValueSql("(newid())");

            entity.Property(e => e.ProductFactorInstanceUniqueId).HasDefaultValueSql("(newid())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TruDatDboAnimalB>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("AnimalB");

            entity.HasIndex(e => e.Name, "CIX_Name");

            entity.HasIndex(e => e.Id, "IX_id")
                .IsClustered();

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.Property(e => e.Inserted).HasColumnType("datetime");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Updated).HasColumnType("datetime");
        });

        modelBuilder.Entity<TruDatDboAreaCode>(entity =>
        {
            entity.ToTable("AreaCode");

            entity.HasIndex(e => e.AreaCode1, "uk_areacode")
                .IsUnique();

            entity.Property(e => e.AreaCode1)
                .IsRequired()
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("AreaCode")
                .IsFixedLength(true);

            entity.HasOne(d => d.State)
                .WithMany(p => p.AreaCodes)
                .HasForeignKey(d => d.StateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__AreaCode__StateI__41031083");
        });

        modelBuilder.Entity<TruDatDboAssessmentTemplate>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("AssessmentTemplate");

            entity.Property(e => e.Accountnumber)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ACCOUNTNUMBER");

            entity.Property(e => e.Address)
                .IsRequired()
                .HasMaxLength(201)
                .IsUnicode(false)
                .HasColumnName("ADDRESS");

            entity.Property(e => e.Adjuster)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("ADJUSTER");

            entity.Property(e => e.Adjusteremailid)
                .HasMaxLength(114)
                .IsUnicode(false)
                .HasColumnName("ADJUSTEREMAILID");

            entity.Property(e => e.Amountinwords)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("AMOUNTINWORDS");

            entity.Property(e => e.Bankaddress)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BANKADDRESS");

            entity.Property(e => e.Bankcity)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BANKCITY");

            entity.Property(e => e.Bankname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BANKNAME");

            entity.Property(e => e.Bankstate)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("BANKSTATE");

            entity.Property(e => e.Bankzipcode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BANKZIPCODE");

            entity.Property(e => e.Checkdate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CHECKDATE");

            entity.Property(e => e.City)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CITY");

            entity.Property(e => e.Claimemail)
                .IsRequired()
                .HasMaxLength(29)
                .IsUnicode(false)
                .HasColumnName("CLAIMEMAIL");

            entity.Property(e => e.Claimfax)
                .IsRequired()
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("CLAIMFAX");

            entity.Property(e => e.Claimid).HasColumnName("CLAIMID");

            entity.Property(e => e.Claimnumber).HasColumnName("CLAIMNUMBER");

            entity.Property(e => e.Claimphone)
                .IsRequired()
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("CLAIMPHONE");

            entity.Property(e => e.Claimurgentfax)
                .IsRequired()
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("CLAIMURGENTFAX");

            entity.Property(e => e.Clinicaddress)
                .IsRequired()
                .HasMaxLength(201)
                .IsUnicode(false)
                .HasColumnName("CLINICADDRESS");

            entity.Property(e => e.Cliniccity)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CLINICCITY");

            entity.Property(e => e.Clinicname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CLINICNAME");

            entity.Property(e => e.Clinicstate)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CLINICSTATE");

            entity.Property(e => e.Cliniczipcode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CLINICZIPCODE");

            entity.Property(e => e.Closeddate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CLOSEDDATE");

            entity.Property(e => e.Comments)
                .IsUnicode(false)
                .HasColumnName("COMMENTS");

            entity.Property(e => e.Condition)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("CONDITION");

            entity.Property(e => e.Currentdate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CURRENTDATE");

            entity.Property(e => e.Currentdate2)
                .HasMaxLength(39)
                .HasColumnName("CURRENTDATE2");

            entity.Property(e => e.Dateofloss)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DATEOFLOSS");

            entity.Property(e => e.Deductibleapplied)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DEDUCTIBLEAPPLIED");

            entity.Property(e => e.Downchecknumber).HasColumnName("DOWNCHECKNUMBER");

            entity.Property(e => e.Emailaddress)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EMAILADDRESS");

            entity.Property(e => e.Enrolldate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ENROLLDATE");

            entity.Property(e => e.Firstname)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FIRSTNAME");

            entity.Property(e => e.Fullname)
                .IsRequired()
                .HasMaxLength(201)
                .IsUnicode(false)
                .HasColumnName("FULLNAME");

            entity.Property(e => e.Gender)
                .IsRequired()
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("GENDER");

            entity.Property(e => e.HtmlString)
                .IsRequired()
                .IsUnicode(false);

            entity.Property(e => e.Inceptiondate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("INCEPTIONDATE");

            entity.Property(e => e.Invoicenumbers)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("INVOICENUMBERS");

            entity.Property(e => e.Invoicesubtotal)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("INVOICESUBTOTAL");

            entity.Property(e => e.Lastname)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LASTNAME");

            entity.Property(e => e.Lettercomments)
                .IsUnicode(false)
                .HasColumnName("LETTERCOMMENTS");

            entity.Property(e => e.Ownerid).HasColumnName("OWNERID");

            entity.Property(e => e.PetOwnerPortion)
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Petname)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PETNAME");

            entity.Property(e => e.PilotContactEmail)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PilotContactName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PilotFax)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Policy)
                .IsRequired()
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("POLICY");

            entity.Property(e => e.Policynumber)
                .IsRequired()
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("POLICYNUMBER");

            entity.Property(e => e.Postaladdress)
                .IsRequired()
                .HasMaxLength(63)
                .IsUnicode(false)
                .HasColumnName("POSTALADDRESS");

            entity.Property(e => e.Postalcode)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("POSTALCODE");

            entity.Property(e => e.Province)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PROVINCE");

            entity.Property(e => e.Pupkinfact)
                .HasMaxLength(180)
                .IsUnicode(false)
                .HasColumnName("PUPKINFACT");

            entity.Property(e => e.State)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("STATE");

            entity.Property(e => e.Statemssg)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("STATEMSSG");

            entity.Property(e => e.Statusname)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("STATUSNAME");

            entity.Property(e => e.Topchecknumber).HasColumnName("TOPCHECKNUMBER");

            entity.Property(e => e.Totalclaimed)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TOTALCLAIMED");

            entity.Property(e => e.Totalclaimpaid)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TOTALCLAIMPAID");

            entity.Property(e => e.Totalclaimspaid)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TOTALCLAIMSPAID");

            entity.Property(e => e.Underwriter)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("UNDERWRITER");

            entity.Property(e => e.Zipcode)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ZIPCODE");
        });

        modelBuilder.Entity<TruDatDboAssessmentTemplate2>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("AssessmentTemplate2");

            entity.Property(e => e.Accountnumber)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ACCOUNTNUMBER");

            entity.Property(e => e.Address)
                .IsRequired()
                .HasMaxLength(201)
                .IsUnicode(false)
                .HasColumnName("ADDRESS");

            entity.Property(e => e.Adjuster)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("ADJUSTER");

            entity.Property(e => e.Adjusteremailid)
                .HasMaxLength(114)
                .IsUnicode(false)
                .HasColumnName("ADJUSTEREMAILID");

            entity.Property(e => e.Amountinwords)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("AMOUNTINWORDS");

            entity.Property(e => e.Bankaddress)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BANKADDRESS");

            entity.Property(e => e.Bankcity)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BANKCITY");

            entity.Property(e => e.Bankname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BANKNAME");

            entity.Property(e => e.Bankstate)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("BANKSTATE")
                .IsFixedLength(true);

            entity.Property(e => e.Bankzipcode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BANKZIPCODE");

            entity.Property(e => e.Checkdate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CHECKDATE");

            entity.Property(e => e.City)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CITY");

            entity.Property(e => e.Claimemail)
                .IsRequired()
                .HasMaxLength(29)
                .IsUnicode(false)
                .HasColumnName("CLAIMEMAIL");

            entity.Property(e => e.Claimfax)
                .IsRequired()
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("CLAIMFAX");

            entity.Property(e => e.Claimid).HasColumnName("CLAIMID");

            entity.Property(e => e.Claimnumber).HasColumnName("CLAIMNUMBER");

            entity.Property(e => e.Claimphone)
                .IsRequired()
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("CLAIMPHONE");

            entity.Property(e => e.Claimurgentfax)
                .IsRequired()
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("CLAIMURGENTFAX");

            entity.Property(e => e.Clinicaddress)
                .IsRequired()
                .HasMaxLength(201)
                .IsUnicode(false)
                .HasColumnName("CLINICADDRESS");

            entity.Property(e => e.Cliniccity)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CLINICCITY");

            entity.Property(e => e.Clinicname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CLINICNAME");

            entity.Property(e => e.Clinicstate)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CLINICSTATE");

            entity.Property(e => e.Cliniczipcode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CLINICZIPCODE");

            entity.Property(e => e.Closeddate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CLOSEDDATE");

            entity.Property(e => e.Comments)
                .IsUnicode(false)
                .HasColumnName("COMMENTS");

            entity.Property(e => e.Condition)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("CONDITION");

            entity.Property(e => e.Currentdate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CURRENTDATE");

            entity.Property(e => e.Currentdate2)
                .HasMaxLength(39)
                .HasColumnName("CURRENTDATE2");

            entity.Property(e => e.Dateofloss)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DATEOFLOSS");

            entity.Property(e => e.Downchecknumber).HasColumnName("DOWNCHECKNUMBER");

            entity.Property(e => e.Emailaddress)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EMAILADDRESS");

            entity.Property(e => e.Enrolldate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ENROLLDATE");

            entity.Property(e => e.Firstname)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FIRSTNAME");

            entity.Property(e => e.Fullname)
                .IsRequired()
                .HasMaxLength(201)
                .IsUnicode(false)
                .HasColumnName("FULLNAME");

            entity.Property(e => e.Gender)
                .IsRequired()
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("GENDER");

            entity.Property(e => e.HtmlString)
                .IsRequired()
                .IsUnicode(false);

            entity.Property(e => e.Inceptiondate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("INCEPTIONDATE");

            entity.Property(e => e.Invoicenumbers)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("INVOICENUMBERS");

            entity.Property(e => e.Invoicesubtotal)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("INVOICESUBTOTAL");

            entity.Property(e => e.Lastname)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LASTNAME");

            entity.Property(e => e.Lettercomments)
                .IsUnicode(false)
                .HasColumnName("LETTERCOMMENTS");

            entity.Property(e => e.Ownerid).HasColumnName("OWNERID");

            entity.Property(e => e.PetOwnerPortion)
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.Petname)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PETNAME");

            entity.Property(e => e.PilotContactEmail)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PilotContactName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PilotFax)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Policy)
                .IsRequired()
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("POLICY");

            entity.Property(e => e.Policynumber)
                .IsRequired()
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("POLICYNUMBER");

            entity.Property(e => e.Postaladdress)
                .IsRequired()
                .HasMaxLength(76)
                .IsUnicode(false)
                .HasColumnName("POSTALADDRESS");

            entity.Property(e => e.Postalcode)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("POSTALCODE");

            entity.Property(e => e.Province)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PROVINCE");

            entity.Property(e => e.State)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("STATE");

            entity.Property(e => e.Statemssg)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("STATEMSSG");

            entity.Property(e => e.Topchecknumber).HasColumnName("TOPCHECKNUMBER");

            entity.Property(e => e.Totalclaimed)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TOTALCLAIMED");

            entity.Property(e => e.Totalclaimpaid)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TOTALCLAIMPAID");

            entity.Property(e => e.Totalclaimspaid)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TOTALCLAIMSPAID");

            entity.Property(e => e.Underwriter)
                .IsRequired()
                .HasMaxLength(81)
                .IsUnicode(false)
                .HasColumnName("UNDERWRITER");

            entity.Property(e => e.Zipcode)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ZIPCODE");
        });

        modelBuilder.Entity<TruDatDboAssessmentTemplateForCheck>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("AssessmentTemplateForCheck");

            entity.Property(e => e.Accountnumber)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ACCOUNTNUMBER");

            entity.Property(e => e.Address)
                .IsRequired()
                .HasMaxLength(201)
                .IsUnicode(false)
                .HasColumnName("ADDRESS");

            entity.Property(e => e.Amountinwords)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("AMOUNTINWORDS");

            entity.Property(e => e.Bankaddress)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BANKADDRESS");

            entity.Property(e => e.Bankcity)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BANKCITY");

            entity.Property(e => e.Bankname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BANKNAME");

            entity.Property(e => e.Bankstate)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("BANKSTATE");

            entity.Property(e => e.Bankzipcode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BANKZIPCODE");

            entity.Property(e => e.Checkdate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CHECKDATE");

            entity.Property(e => e.City)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CITY");

            entity.Property(e => e.Claimid).HasColumnName("CLAIMID");

            entity.Property(e => e.Claimnumber).HasColumnName("CLAIMNUMBER");

            entity.Property(e => e.Clinicaddress)
                .IsRequired()
                .HasMaxLength(201)
                .IsUnicode(false)
                .HasColumnName("CLINICADDRESS");

            entity.Property(e => e.Cliniccity)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CLINICCITY");

            entity.Property(e => e.Clinicname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CLINICNAME");

            entity.Property(e => e.Clinicstate)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CLINICSTATE");

            entity.Property(e => e.Cliniczipcode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CLINICZIPCODE");

            entity.Property(e => e.Condition)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("CONDITION");

            entity.Property(e => e.Currentdate2)
                .HasMaxLength(39)
                .HasColumnName("CURRENTDATE2");

            entity.Property(e => e.Dateofloss)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DATEOFLOSS");

            entity.Property(e => e.Downchecknumber).HasColumnName("DOWNCHECKNUMBER");

            entity.Property(e => e.Emailaddress)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EMAILADDRESS");

            entity.Property(e => e.Fullname)
                .IsRequired()
                .HasMaxLength(201)
                .IsUnicode(false)
                .HasColumnName("FULLNAME");

            entity.Property(e => e.Invoicenumbers)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("INVOICENUMBERS");

            entity.Property(e => e.Petname)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PETNAME");

            entity.Property(e => e.Policy)
                .IsRequired()
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("POLICY");

            entity.Property(e => e.Policynumber)
                .IsRequired()
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("POLICYNUMBER");

            entity.Property(e => e.Postalcode)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("POSTALCODE");

            entity.Property(e => e.Province)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PROVINCE");

            entity.Property(e => e.State)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("STATE");

            entity.Property(e => e.Statemssg)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("STATEMSSG");

            entity.Property(e => e.Topchecknumber).HasColumnName("TOPCHECKNUMBER");

            entity.Property(e => e.Totalclaimpaid)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TOTALCLAIMPAID");

            entity.Property(e => e.Totalclaimspaid)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TOTALCLAIMSPAID");

            entity.Property(e => e.Underwriter)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("UNDERWRITER");

            entity.Property(e => e.Zipcode)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ZIPCODE");
        });

        modelBuilder.Entity<TruDatDboAssociate>(entity =>
        {
            entity.ToTable("Associate");

            entity.HasIndex(e => e.UniqueId, "ix_associate_uniqueid");

            entity.HasIndex(e => e.CompanyName, "uk_associate_cnm")
                .IsUnique();

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.CompanyName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.DefaultCampaignCode)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ExternalId)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.UniqueId).HasDefaultValueSql("(newid())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.ParentAssociate)
                .WithMany(p => p.InverseParentAssociate)
                .HasForeignKey(d => d.ParentAssociateId)
                .HasConstraintName("fk_associate_associate");

            entity.HasOne(d => d.ServiceCategory)
                .WithMany(p => p.Associates)
                .HasForeignKey(d => d.ServiceCategoryId)
                .HasConstraintName("fk_associate_entitylist");
        });

        modelBuilder.Entity<TruDatDboAssociateAccount>(entity =>
        {
            entity.ToTable("AssociateAccount");

            entity.HasIndex(e => e.AssociateId, "uk_associateaccount_nme")
                .IsUnique();

            entity.Property(e => e.AutomaticPayment)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TruDatDboAssociateBranchMap>(entity =>
        {
            entity.HasKey(e => new { e.ParentId, e.ChildId })
                .HasName("pk_assbranchmap_pid_cid");

            entity.ToTable("AssociateBranchMap");

            entity.HasOne(d => d.Child)
                .WithMany(p => p.AssociateBranchMapChildren)
                .HasForeignKey(d => d.ChildId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_assbranchmap_cid");

            entity.HasOne(d => d.Parent)
                .WithMany(p => p.AssociateBranchMapParents)
                .HasForeignKey(d => d.ParentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_assbranchmap_pid");
        });

        modelBuilder.Entity<TruDatDboAssociateDatum>(entity =>
        {
            entity.Property(e => e.Description).IsUnicode(false);

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Answer)
                .WithMany(p => p.AssociateData)
                .HasForeignKey(d => d.AnswerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_associatedata_entitytree");

            entity.HasOne(d => d.Associate)
                .WithMany(p => p.AssociateData)
                .HasForeignKey(d => d.AssociateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_associatedata_associate");

            entity.HasOne(d => d.ChangeUser)
                .WithMany(p => p.AssociateData)
                .HasForeignKey(d => d.ChangeUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_associatedata_users");
        });

        modelBuilder.Entity<TruDatDboAssociateEnrollmentDatum>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Description).IsUnicode(false);

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.SessionId)
                .IsRequired()
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Answer)
                .WithMany()
                .HasForeignKey(d => d.AnswerId)
                .HasConstraintName("fk_assenrolldata_entitytree");

            entity.HasOne(d => d.PendingAssociate)
                .WithMany()
                .HasForeignKey(d => d.PendingAssociateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_assenrolldata_assenrollmentpending");
        });

        modelBuilder.Entity<TruDatDboAssociateEnrollmentPending>(entity =>
        {
            entity.ToTable("AssociateEnrollmentPending");

            entity.Property(e => e.AddressLine1)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AddressLine2)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AssociateName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CellPhone)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.City)
                .IsRequired()
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.Property(e => e.HomePhone)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Inserted).HasColumnType("datetime");

            entity.Property(e => e.PortalEmailAddress)
                .IsRequired()
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.PortalUserName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PrimaryContactEmail)
                .IsRequired()
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.PrimaryContactName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SessionId)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.Title)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Updated).HasColumnType("datetime");

            entity.Property(e => e.WorkExtension)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.WorkPhone)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Zipcode)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboAssociateEnrollmentWebsitePending>(entity =>
        {
            entity.ToTable("AssociateEnrollmentWebsitePending");

            entity.Property(e => e.Url)
                .IsRequired()
                .HasMaxLength(512)
                .IsUnicode(false);

            entity.HasOne(d => d.AssociateEnrollmentPending)
                .WithMany(p => p.AssociateEnrollmentWebsitePendings)
                .HasForeignKey(d => d.AssociateEnrollmentPendingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_AssociateEnrollmentWebsitePending_AssociateEnrollmentPendingId");
        });

        modelBuilder.Entity<TruDatDboAssociateGroup>(entity =>
        {
            entity.ToTable("AssociateGroup");

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

            entity.HasOne(d => d.ChangeUser)
                .WithMany(p => p.AssociateGroups)
                .HasForeignKey(d => d.ChangeUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_associategroup_users");
        });

        modelBuilder.Entity<TruDatDboAssociateGroupAssociate>(entity =>
        {
            entity.ToTable("AssociateGroupAssociate");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.AssociateGroup)
                .WithMany(p => p.AssociateGroupAssociates)
                .HasForeignKey(d => d.AssociateGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_associategroupassociate_associategroup");

            entity.HasOne(d => d.Associate)
                .WithMany(p => p.AssociateGroupAssociates)
                .HasForeignKey(d => d.AssociateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_associategroupassociate_associate");

            entity.HasOne(d => d.ChangeUser)
                .WithMany(p => p.AssociateGroupAssociates)
                .HasForeignKey(d => d.ChangeUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_associategroupassociate_users");
        });

        modelBuilder.Entity<TruDatDboAssociateGroupSecurable>(entity =>
        {
            entity.ToTable("AssociateGroupSecurable");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.AssociateGroup)
                .WithMany(p => p.AssociateGroupSecurables)
                .HasForeignKey(d => d.AssociateGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_associategroupsecurable_associategroup");

            entity.HasOne(d => d.ChangeUser)
                .WithMany(p => p.AssociateGroupSecurables)
                .HasForeignKey(d => d.ChangeUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_associategroupsecurable_users");

            entity.HasOne(d => d.Securable)
                .WithMany(p => p.AssociateGroupSecurables)
                .HasForeignKey(d => d.SecurableId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_associategroupsecurable_securable");
        });

        modelBuilder.Entity<TruDatDboAssociatePolicy>(entity =>
        {
            entity.ToTable("AssociatePolicy");

            entity.HasIndex(e => new { e.AssociateId, e.PolicyId }, "uk_associatepolicy_aid_pid")
                .IsUnique();

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Associate)
                .WithMany(p => p.AssociatePolicies)
                .HasForeignKey(d => d.AssociateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_associate_associatepolicy");

            entity.HasOne(d => d.Policy)
                .WithMany(p => p.AssociatePolicies)
                .HasForeignKey(d => d.PolicyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_policy_associatepolicy");
        });

        modelBuilder.Entity<TruDatDboAssociateSecurable>(entity =>
        {
            entity.ToTable("AssociateSecurable");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Associate)
                .WithMany(p => p.AssociateSecurables)
                .HasForeignKey(d => d.AssociateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_associatesecurable_associate");

            entity.HasOne(d => d.ChangeUser)
                .WithMany(p => p.AssociateSecurables)
                .HasForeignKey(d => d.ChangeUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_associatesecurable_users");

            entity.HasOne(d => d.Securable)
                .WithMany(p => p.AssociateSecurables)
                .HasForeignKey(d => d.SecurableId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_associatesecurable_securable");
        });

        modelBuilder.Entity<TruDatDboAssociateWebsiteDatum>(entity =>
        {
            entity.Property(e => e.Url)
                .IsRequired()
                .HasMaxLength(512)
                .IsUnicode(false);

            entity.HasOne(d => d.Associate)
                .WithMany(p => p.AssociateWebsiteData)
                .HasForeignKey(d => d.AssociateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_AssociateEnrollmentWebsiteData_AssociateId");
        });

        modelBuilder.Entity<TruDatDboAttachment>(entity =>
        {
            entity.ToTable("Attachment");

            entity.HasIndex(e => e.DocumentId, "ix_attachment_Documentid");

            entity.HasIndex(e => e.Active, "ix_attachment_act");

            entity.HasIndex(e => new { e.InputTypeId, e.Id }, "ix_attachment_it_id");

            entity.HasIndex(e => e.FileName, "uk_attachment_nme")
                .IsUnique();

            entity.Property(e => e.Description).IsUnicode(false);

            entity.Property(e => e.DocumentId)
                .HasMaxLength(24)
                .IsUnicode(false);

            entity.Property(e => e.FileName)
                .IsRequired()
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.SalesForceId)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Source)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Category)
                .WithMany(p => p.Attachments)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("fk_attachment_attachmentcategory");

            entity.HasOne(d => d.DocType)
                .WithMany(p => p.Attachments)
                .HasForeignKey(d => d.DocTypeId)
                .HasConstraintName("fk_attachment_attachmentdoctype");

            entity.HasOne(d => d.InputType)
                .WithMany(p => p.Attachments)
                .HasForeignKey(d => d.InputTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_attachmentinputtype_attachment");
        });

        modelBuilder.Entity<TruDatDboAttachmentCategory>(entity =>
        {
            entity.ToTable("AttachmentCategory");

            entity.HasIndex(e => e.Name, "uk_attachmentcategory_nme")
                .IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();

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

        modelBuilder.Entity<TruDatDboAttachmentDisposition>(entity =>
        {
            entity.ToTable("AttachmentDisposition");

            entity.HasIndex(e => new { e.AttachmentId, e.EntityTypeId, e.EntityId }, "fk_attachmentdisposition_aid_etid_eid")
                .IsUnique();

            entity.HasIndex(e => e.EntityId, "ix_attachmentdisposition_eid");

            entity.HasIndex(e => e.EntityTypeId, "ix_attachmentdisposition_etid");

            entity.HasIndex(e => new { e.EntityTypeId, e.EntityId }, "ix_attachmentdisposition_tid_eid");

            entity.HasIndex(e => new { e.AttachmentId, e.EntityTypeId, e.EntityId }, "uk_attachmentdisposition_aid_etid_eid")
                .IsUnique();

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.AssignedUser)
                .WithMany(p => p.AttachmentDispositionAssignedUsers)
                .HasForeignKey(d => d.AssignedUserId)
                .HasConstraintName("fk_users_attachmentdisposition_assigned");

            entity.HasOne(d => d.Attachment)
                .WithMany(p => p.AttachmentDispositions)
                .HasForeignKey(d => d.AttachmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_attachmentdisposition_attachment");

            entity.HasOne(d => d.EntityType)
                .WithMany(p => p.AttachmentDispositions)
                .HasForeignKey(d => d.EntityTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_entity_attachmentdisposition");

            entity.HasOne(d => d.User)
                .WithMany(p => p.AttachmentDispositionUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_users_attachmentdisposition");
        });

        modelBuilder.Entity<TruDatDboAttachmentDocType>(entity =>
        {
            entity.ToTable("AttachmentDocType");

            entity.Property(e => e.Type)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboAttachmentEmail>(entity =>
        {
            entity.ToTable("AttachmentEmail");

            entity.HasIndex(e => new { e.EntityId, e.EntityTypeId }, "ix_attachmentemail_eid_etid");

            entity.Property(e => e.EmailBody).IsUnicode(false);

            entity.Property(e => e.Inserted).HasColumnType("datetime");

            entity.Property(e => e.IsBounceBack).HasDefaultValueSql("((0))");

            entity.Property(e => e.Name).IsUnicode(false);

            entity.Property(e => e.Updated).HasColumnType("datetime");
        });

        modelBuilder.Entity<TruDatDboAttachmentEmailReference>(entity =>
        {
            entity.ToTable("AttachmentEmailReference");

            entity.HasIndex(e => e.AttachmentEmailId, "ix_attachmentemailreference_attachmentemailid");

            entity.Property(e => e.DocumentId)
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.EmailAddress)
                .HasMaxLength(1024)
                .IsUnicode(false);

            entity.Property(e => e.FailedDeliveryExplanation)
                .HasMaxLength(512)
                .IsUnicode(false);

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.AboutEntityType)
                .WithMany(p => p.AttachmentEmailReferences)
                .HasForeignKey(d => d.AboutEntityTypeId)
                .HasConstraintName("fk_attachmentemailreference_entitytype");

            entity.HasOne(d => d.AttachmentEmail)
                .WithMany(p => p.AttachmentEmailReferences)
                .HasForeignKey(d => d.AttachmentEmailId)
                .HasConstraintName("fk_attachmentemailreference_referenceId");

            entity.HasOne(d => d.ChangeUser)
                .WithMany(p => p.AttachmentEmailReferences)
                .HasForeignKey(d => d.ChangeUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_attachmentemailreference_changeuserId");
        });

        modelBuilder.Entity<TruDatDboAttachmentFaxInfo>(entity =>
        {
            entity.HasKey(e => e.AttachmentId)
                .HasName("pk_attachmentfaxinfo_aid");

            entity.ToTable("AttachmentFaxInfo");

            entity.HasIndex(e => e.AttachmentId, "ix_attachmentfaxinfo_aid");

            entity.HasIndex(e => new { e.Assigned, e.FaxLineNumberId, e.ReceivedTime }, "ix_attachmentfaxinfo_ass_fn_rt");

            entity.HasIndex(e => new { e.Assigned, e.ReceivedTime }, "ix_attachmentfaxinfo_ass_rt");

            entity.HasIndex(e => new { e.ReceivedTime, e.AttachmentId }, "ix_attachmentfaxinfo_rd_aid");

            entity.HasIndex(e => e.SendingFaxNumber, "ix_attachmentfaxinfo_sendingfaxnumber");

            entity.HasIndex(e => e.RightFaxId, "ix_rightfax_attachment");

            entity.HasIndex(e => e.ProtusFaxId, "uk_attachmentfaxinfo_pid")
                .IsUnique();

            entity.Property(e => e.AttachmentId).ValueGeneratedNever();

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.ProtusFaxId)
                .IsRequired()
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ReceivedTime).HasColumnType("datetime");

            entity.Property(e => e.SendingFaxNumber)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Udpated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Attachment)
                .WithOne(p => p.AttachmentFaxInfo)
                .HasForeignKey<TruDatDboAttachmentFaxInfo>(d => d.AttachmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_attachment_attachmentfaxinfo");

            entity.HasOne(d => d.FaxLineNumber)
                .WithMany(p => p.AttachmentFaxInfos)
                .HasForeignKey(d => d.FaxLineNumberId)
                .HasConstraintName("fk_faxlinenumber_attachmentfaxinfo");
        });

        modelBuilder.Entity<TruDatDboAttachmentInputType>(entity =>
        {
            entity.ToTable("AttachmentInputType");

            entity.HasIndex(e => e.Name, "uk_attachmentinputtype_nme")
                .IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");

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

        modelBuilder.Entity<TruDatDboAttachmentsDupFaxis>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("Attachments_DupFaxes");

            entity.Property(e => e.Description).IsUnicode(false);

            entity.Property(e => e.FileName)
                .IsRequired()
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.Property(e => e.Inserted).HasColumnType("datetime");

            entity.Property(e => e.SalesForceId)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Source)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.Updated).HasColumnType("datetime");
        });

        modelBuilder.Entity<TruDatDboAttachmentsForPet>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("AttachmentsForPet");

            entity.Property(e => e.AttachmentId).HasColumnName("AttachmentID");

            entity.Property(e => e.EntityId).HasColumnName("EntityID");

            entity.Property(e => e.EntityTypeId).HasColumnName("EntityTypeID");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.Inserted).HasColumnType("datetime");

            entity.Property(e => e.Pagenumber).HasColumnName("pagenumber");

            entity.Property(e => e.Updated).HasColumnType("datetime");

            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<TruDatDboBankCheck>(entity =>
        {
            entity.ToTable("BankCheck");

            entity.HasIndex(e => e.StatusId, "inx_status_claim");

            entity.Property(e => e.Amount).HasColumnType("money");

            entity.Property(e => e.Comments)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.DateCancelled).HasColumnType("datetime");

            entity.Property(e => e.DateCleared).HasColumnType("datetime");

            entity.Property(e => e.DateRequested).HasColumnType("datetime");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.PayableTo)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.StopReason)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Account)
                .WithMany(p => p.BankChecks)
                .HasForeignKey(d => d.AccountId)
                .HasConstraintName("fk_bankcheck_accountId");

            entity.HasOne(d => d.CancelledByUser)
                .WithMany(p => p.BankCheckCancelledByUsers)
                .HasForeignKey(d => d.CancelledByUserId)
                .HasConstraintName("fk_bankcheck_cancelledby");

            entity.HasOne(d => d.Claim)
                .WithMany(p => p.BankChecks)
                .HasForeignKey(d => d.ClaimId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bankcheck_claimid");

            entity.HasOne(d => d.IssuedByUser)
                .WithMany(p => p.BankCheckIssuedByUsers)
                .HasForeignKey(d => d.IssuedByUserId)
                .HasConstraintName("fk_bankcheck_issuedby");

            entity.HasOne(d => d.RequestedByUser)
                .WithMany(p => p.BankCheckRequestedByUsers)
                .HasForeignKey(d => d.RequestedByUserId)
                .HasConstraintName("fk_bankcheck_requestedby");

            entity.HasOne(d => d.Status)
                .WithMany(p => p.BankChecks)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_bankcheck_statusid");
        });

        modelBuilder.Entity<TruDatDboBankCheckTransfer>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("BankCheckTransfer");

            entity.Property(e => e.Amount).HasColumnType("money");

            entity.Property(e => e.Comments)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.DateCancelled).HasColumnType("datetime");

            entity.Property(e => e.DateCleared).HasColumnType("datetime");

            entity.Property(e => e.DateRequested).HasColumnType("datetime");

            entity.Property(e => e.Inserted).HasColumnType("datetime");

            entity.Property(e => e.PayableTo)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.StopReason)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Updated).HasColumnType("datetime");
        });

        modelBuilder.Entity<TruDatDboBankcheck110110>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("bankcheck110110");

            entity.Property(e => e.Amount).HasColumnType("money");

            entity.Property(e => e.Comments)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.DateCancelled).HasColumnType("datetime");

            entity.Property(e => e.DateCleared).HasColumnType("datetime");

            entity.Property(e => e.DateRequested).HasColumnType("datetime");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.Property(e => e.Inserted).HasColumnType("datetime");

            entity.Property(e => e.PayableTo)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.StopReason)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Updated).HasColumnType("datetime");
        });

        modelBuilder.Entity<TruDatDboBitmaskNumber>(entity =>
        {
            entity.HasKey(e => e.Number)
                .IsClustered(false);

            entity.HasIndex(e => e.Byte, "ix_byte")
                .IsClustered();

            entity.Property(e => e.Number).ValueGeneratedNever();
        });

        modelBuilder.Entity<TruDatDboBreed>(entity =>
        {
            entity.ToTable("Breed");

            entity.HasIndex(e => new { e.AnimalId, e.Name }, "uk_breed_aid_nme")
                .IsUnique();

            entity.HasIndex(e => e.ProductFactorInstanceUniqueId, "uk_dboBreed_pfiuid")
                .IsUnique();

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

            entity.Property(e => e.PetCharacteristicUniqueId).HasDefaultValueSql("(newid())");

            entity.Property(e => e.ProductFactorInstanceUniqueId).HasDefaultValueSql("(newid())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Animal)
                .WithMany(p => p.Breeds)
                .HasForeignKey(d => d.AnimalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_animal_breed");
        });

        modelBuilder.Entity<TruDatDboBreed1>(entity =>
        {
            entity.HasKey(e => e.AnimalId)
                .HasName("PK_dbo.Breeds");

            entity.ToTable("Breeds");

            entity.Property(e => e.Inserted).HasColumnType("datetime");

            entity.Property(e => e.Updated).HasColumnType("datetime");
        });

        modelBuilder.Entity<TruDatDboBreedCharacteristic>(entity =>
        {
            entity.ToTable("BreedCharacteristic");

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

        modelBuilder.Entity<TruDatDboBreedFactors2015>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("BreedFactors2015");

            entity.Property(e => e.FactorChange)
                .HasMaxLength(255)
                .HasColumnName("Factor Change");

            entity.Property(e => e.Name).HasMaxLength(255);

            entity.Property(e => e.NyDelta)
                .HasMaxLength(255)
                .HasColumnName("NY delta");

            entity.Property(e => e.NyNoHdFactor).HasColumnName("NY - No HD Factor");

            entity.Property(e => e.NyNoHdGroup).HasColumnName("NY - No HD Group #");

            entity.Property(e => e._2015Group).HasColumnName("2015 Group");
        });

        modelBuilder.Entity<TruDatDboBreedFactors2015Fl>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("BreedFactors2015FL");

            entity.Property(e => e.BreedRollup).HasMaxLength(255);

            entity.Property(e => e.CanStandard).HasColumnName("CAN Standard");

            entity.Property(e => e.Flfactor).HasColumnName("FLFactor");

            entity.Property(e => e.Lookup).HasMaxLength(255);

            entity.Property(e => e.Name).HasMaxLength(255);

            entity.Property(e => e._2015Group).HasColumnName("2015 Group");
        });

        modelBuilder.Entity<TruDatDboBreedFactors2016>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("BreedFactors2016");

            entity.Property(e => e.Name).HasMaxLength(255);

            entity.Property(e => e.Nyfactor).HasColumnName("NYFactor");

            entity.Property(e => e._2015Group).HasColumnName("2015 Group");
        });

        modelBuilder.Entity<TruDatDboBreedFactorsNy>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("BreedFactorsNY");

            entity.Property(e => e.BreedRollup).HasMaxLength(255);

            entity.Property(e => e.Changed).HasMaxLength(255);

            entity.Property(e => e.F2).HasMaxLength(255);

            entity.Property(e => e.ForDropDownBox)
                .HasMaxLength(255)
                .HasColumnName("for drop down box");

            entity.Property(e => e.Lookup).HasMaxLength(255);

            entity.Property(e => e.Name).HasMaxLength(255);

            entity.Property(e => e.Nyfactor).HasColumnName("NYFactor");

            entity.Property(e => e._2015Group).HasColumnName("2015 Group");
        });

        modelBuilder.Entity<TruDatDboBreedGuide>(entity =>
        {
            entity.ToTable("BreedGuide");

            entity.HasIndex(e => e.BreedId, "uq_breedguide_breedid")
                .IsUnique();

            entity.HasIndex(e => e.Url, "uq_breedguide_url")
                .IsUnique();

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.BreedH1tag)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("BreedH1Tag");

            entity.Property(e => e.BreedMetaDescription)
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.Characteristics).IsUnicode(false);

            entity.Property(e => e.Detail).IsUnicode(false);

            entity.Property(e => e.HealthConcerns).IsUnicode(false);

            entity.Property(e => e.Height)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Lifespan)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.MoreInfo).IsUnicode(false);

            entity.Property(e => e.PageTitle)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.Photo1)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.Photo2)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.Summary).IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Url)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.VideoHtml).IsUnicode(false);

            entity.Property(e => e.Weight)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Breed)
                .WithOne(p => p.BreedGuide)
                .HasForeignKey<TruDatDboBreedGuide>(d => d.BreedId)
                .HasConstraintName("fk_breedguide_breed");
        });

        modelBuilder.Entity<TruDatDboBreedGuideBreed>(entity =>
        {
            entity.HasKey(e => new { e.BreedGuideId, e.BreedId })
                .HasName("pk_breedguidebreed_bgid_bid");

            entity.ToTable("BreedGuideBreed");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.BreedGuide)
                .WithMany(p => p.BreedGuideBreeds)
                .HasForeignKey(d => d.BreedGuideId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_breedguidebreed_breedguide");

            entity.HasOne(d => d.Breed)
                .WithMany(p => p.BreedGuideBreeds)
                .HasForeignKey(d => d.BreedId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_breedguidebreed_breed");
        });

        modelBuilder.Entity<TruDatDboBreedGuideCharacteristic>(entity =>
        {
            entity.ToTable("BreedGuideCharacteristic");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.BreedCharacteristic)
                .WithMany(p => p.BreedGuideCharacteristics)
                .HasForeignKey(d => d.BreedCharacteristicId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_breedguidecharacteristic_breedcharacteristic");

            entity.HasOne(d => d.BreedGuide)
                .WithMany(p => p.BreedGuideCharacteristics)
                .HasForeignKey(d => d.BreedGuideId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_breedguidecharacteristic_breedguide");
        });

        modelBuilder.Entity<TruDatDboBreedGuideHealthConcern>(entity =>
        {
            entity.ToTable("BreedGuideHealthConcern");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.BreedGuide)
                .WithMany(p => p.BreedGuideHealthConcerns)
                .HasForeignKey(d => d.BreedGuideId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_breedguidehealthconcern_breedguide");

            entity.HasOne(d => d.BreedHealthConcern)
                .WithMany(p => p.BreedGuideHealthConcerns)
                .HasForeignKey(d => d.BreedHealthConcernId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_breedguidehealthconcern_breedhealthconcern");
        });

        modelBuilder.Entity<TruDatDboBreedGuideTrait>(entity =>
        {
            entity.ToTable("BreedGuideTrait");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.BreedGuide)
                .WithMany(p => p.BreedGuideTraits)
                .HasForeignKey(d => d.BreedGuideId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_breedguidetrait_breedguide");

            entity.HasOne(d => d.BreedTrait)
                .WithMany(p => p.BreedGuideTraits)
                .HasForeignKey(d => d.BreedTraitId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_breedguidetrait_breedtrait");
        });

        modelBuilder.Entity<TruDatDboBreedHealthConcern>(entity =>
        {
            entity.ToTable("BreedHealthConcern");

            entity.HasIndex(e => e.Name, "uq_breedhealthconcern_name")
                .IsUnique();

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.Description).IsUnicode(false);

            entity.Property(e => e.Expenses)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.H1tag)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("H1Tag");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.MetaDescription)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.PageTitle)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Url)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasComputedColumnSql("([dbo].[fn_GetUrlFriendlyName]([Name]))", false);
        });

        modelBuilder.Entity<TruDatDboBreedShadow>(entity =>
        {
            entity.ToTable("BreedShadow");

            entity.HasIndex(e => new { e.BreedId, e.ShadowAnimalImageId }, "uk_breedshadow_animalshadowimage")
                .IsUnique();

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Breed)
                .WithMany(p => p.BreedShadows)
                .HasForeignKey(d => d.BreedId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_breedshadowimage_animal");

            entity.HasOne(d => d.ChangeUser)
                .WithMany(p => p.BreedShadows)
                .HasForeignKey(d => d.ChangeUserId)
                .HasConstraintName("fk_breedshadowimage_users");

            entity.HasOne(d => d.ShadowAnimalImage)
                .WithMany(p => p.BreedShadows)
                .HasForeignKey(d => d.ShadowAnimalImageId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_breedshadowimage_shadowanimalimage");
        });

        modelBuilder.Entity<TruDatDboBreedTrait>(entity =>
        {
            entity.ToTable("BreedTrait");

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

        modelBuilder.Entity<TruDatDboCancelledPolicy>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("CancelledPolicies");

            entity.Property(e => e.ApprovedBy)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BreedName)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.CancelApprovalDate).HasColumnType("datetime");

            entity.Property(e => e.CancelNote)
                .HasMaxLength(400)
                .IsUnicode(false);

            entity.Property(e => e.CancelReason)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CancelRequestDate).HasColumnType("datetime");

            entity.Property(e => e.EmailAddress)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.HomePhone)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OwnerFirstName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.OwnerLastName)
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

            entity.Property(e => e.PolicyDate).HasColumnType("datetime");

            entity.Property(e => e.PolicyNumber)
                .IsRequired()
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.PolicyPaidThru).HasColumnType("datetime");

            entity.Property(e => e.RequestedBy)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboCappedPolicy>(entity =>
        {
            entity.Property(e => e.FromPremium).HasColumnType("smallmoney");

            entity.Property(e => e.Inserted).HasColumnType("datetime");

            entity.Property(e => e.Note)
                .IsRequired()
                .IsUnicode(false);

            entity.Property(e => e.ToPremium).HasColumnType("smallmoney");

            entity.Property(e => e.UnCappedPremium).HasColumnType("smallmoney");
        });

        modelBuilder.Entity<TruDatDboCazip>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("CAZips");

            entity.Property(e => e.CityName)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.CityType)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.Latitude)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.Longitude)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.PostalCode)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.ProvinceAbbr)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.ProvinceName)
                .HasMaxLength(250)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboCharity>(entity =>
        {
            entity.ToTable("Charity");

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.DefaultDonation).HasColumnType("smallmoney");

            entity.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(512)
                .IsUnicode(false);

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.LogoName)
                .IsRequired()
                .HasMaxLength(150)
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.UniqueId).HasDefaultValueSql("(newid())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Url)
                .IsRequired()
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("URL");
        });

        modelBuilder.Entity<TruDatDboCharityCountry>(entity =>
        {
            entity.HasKey(e => new { e.CharityId, e.CountryId })
                .HasName("pk_charitycountry_cid_sid");

            entity.ToTable("CharityCountry");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Charity)
                .WithMany(p => p.CharityCountries)
                .HasForeignKey(d => d.CharityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_charity_charitycountry");

            entity.HasOne(d => d.Country)
                .WithMany(p => p.CharityCountries)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_country_charitycountry");
        });

        modelBuilder.Entity<TruDatDboCharityState>(entity =>
        {
            entity.HasKey(e => new { e.CharityId, e.StateId })
                .HasName("pk_charitystate_cid_sid");

            entity.ToTable("CharityState");

            entity.HasOne(d => d.Charity)
                .WithMany(p => p.CharityStates)
                .HasForeignKey(d => d.CharityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_charity_charitystate");

            entity.HasOne(d => d.State)
                .WithMany(p => p.CharityStates)
                .HasForeignKey(d => d.StateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CharitySt__State__42EB58F5");
        });

        modelBuilder.Entity<TruDatDboClaim>(entity =>
        {
            entity.ToTable("Claim");

            entity.HasIndex(e => e.AssignedToUserId, "ix_claim_claimworkflow_uid");

            entity.HasIndex(e => e.InvoiceNumbers, "ix_claim_dcr");

            entity.HasIndex(e => new { e.Deleted, e.StatusId }, "ix_claim_del_st");

            entity.HasIndex(e => e.DateOfLoss, "ix_claim_dol");

            entity.HasIndex(e => e.Inserted, "ix_claim_ins");

            entity.HasIndex(e => e.PetPolicyId, "ix_claim_pod");

            entity.HasIndex(e => e.StatusId, "ix_claim_sid");

            entity.HasIndex(e => new { e.StatusId, e.Deleted }, "ix_claim_status");

            entity.HasIndex(e => new { e.StatusId, e.DateOfLoss }, "ix_claim_statusId_dol");

            entity.HasIndex(e => new { e.CreateUserId, e.Inserted }, "ix_claim_uid_ins");

            entity.HasIndex(e => new { e.AssignedToUserId, e.StatusId }, "ix_claim_uid_sid");

            entity.HasIndex(e => e.Updated, "ix_claim_updated");

            entity.Property(e => e.AmountNotClaimable).HasColumnType("smallmoney");

            entity.Property(e => e.AmountPaidOut).HasColumnType("smallmoney");

            entity.Property(e => e.BoardingFees).HasColumnType("smallmoney");

            entity.Property(e => e.CauseOfInjury)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.Comments).IsUnicode(false);

            entity.Property(e => e.ConcurrencyToken)
                .IsRequired()
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.Property(e => e.DateDeleted).HasColumnType("datetime");

            entity.Property(e => e.DateOfLoss).HasColumnType("smalldatetime");

            entity.Property(e => e.DeductibleAmount).HasColumnType("smallmoney");

            entity.Property(e => e.Diagnosis)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.ExamFees).HasColumnType("smallmoney");

            entity.Property(e => e.ExclusionReasonNotes).IsUnicode(false);

            entity.Property(e => e.FromQcNbEtc).HasColumnName("FromQC_NB_etc");

            entity.Property(e => e.Gst5)
                .HasColumnType("smallmoney")
                .HasColumnName("GST5");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.InvoiceNumbers)
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.InvoiceSubTotal).HasColumnType("smallmoney");

            entity.Property(e => e.LetterComments).IsUnicode(false);

            entity.Property(e => e.OtherVetCost).HasColumnType("smallmoney");

            entity.Property(e => e.PendingInfoComments)
                .HasMaxLength(512)
                .IsUnicode(false);

            entity.Property(e => e.Rechecks).HasColumnType("smallmoney");

            entity.Property(e => e.RemDeductible).HasColumnType("smallmoney");

            entity.Property(e => e.SalesForceId)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.TotalClaimed).HasColumnType("smallmoney");

            entity.Property(e => e.TotalCustomerClaimed).HasColumnType("smallmoney");

            entity.Property(e => e.TypeOfInjury)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.UnRelatedChargesDesc).IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e._3rdPartyLiability).HasColumnName("3rdPartyLiability");

            entity.Property(e => e._90dayClaim).HasColumnName("90DayClaim");

            entity.HasOne(d => d.AssignedToUser)
                .WithMany(p => p.ClaimAssignedToUsers)
                .HasForeignKey(d => d.AssignedToUserId)
                .HasConstraintName("fk_claim_assignedToUserId");

            entity.HasOne(d => d.ClaimType)
                .WithMany(p => p.Claims)
                .HasForeignKey(d => d.ClaimTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_claimtype_claim");

            entity.HasOne(d => d.CreateUser)
                .WithMany(p => p.ClaimCreateUsers)
                .HasForeignKey(d => d.CreateUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_users_claim");

            entity.HasOne(d => d.ExclusionReason)
                .WithMany(p => p.Claims)
                .HasForeignKey(d => d.ExclusionReasonId)
                .HasConstraintName("fk_claimexclusion_claim");

            entity.HasOne(d => d.PetPolicy)
                .WithMany(p => p.Claims)
                .HasForeignKey(d => d.PetPolicyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_petpolicy_claim");

            entity.HasOne(d => d.Status)
                .WithMany(p => p.Claims)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_claim_status");
        });

        modelBuilder.Entity<TruDatDboClaimBatchLetter>(entity =>
        {
            entity.ToTable("ClaimBatchLetter");

            entity.HasIndex(e => e.AssessmentDataId, "ix_claimbatchletter_assessmentdataid");

            entity.HasIndex(e => new { e.AssessmentDataId, e.TemplateId }, "ix_claimbatchlettertemplateassessment");

            entity.HasIndex(e => new { e.ClaimId, e.TemplateId }, "ix_claimbatchlettertemplateclaim");

            entity.HasIndex(e => new { e.ClaimStatusLetterId, e.TemplateId }, "ix_claimbatchlettertemplatestatusclaim");

            entity.Property(e => e.Body).IsUnicode(false);

            entity.Property(e => e.EditableBody).IsUnicode(false);

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.LastPrinted).HasColumnType("datetime");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Claim)
                .WithMany(p => p.ClaimBatchLetters)
                .HasForeignKey(d => d.ClaimId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_claimbatchletter_claim");

            entity.HasOne(d => d.DeliveryStatus)
                .WithMany(p => p.ClaimBatchLetters)
                .HasForeignKey(d => d.DeliveryStatusId)
                .HasConstraintName("fk_claimbacthletter_status");

            entity.HasOne(d => d.LastEmailAttachment)
                .WithMany(p => p.ClaimBatchLetters)
                .HasForeignKey(d => d.LastEmailAttachmentId)
                .HasConstraintName("fk_claimbacthletter_lastemailattachment");

            entity.HasOne(d => d.User)
                .WithMany(p => p.ClaimBatchLetters)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_claimbatchletter_users");
        });

        modelBuilder.Entity<TruDatDboClaimClinic>(entity =>
        {
            entity.ToTable("ClaimClinic");

            entity.HasKey(e => e.ClaimClinicId).HasName("pk_claimclinic"); 

            entity.Property(e => e.ClaimClinicId).ValueGeneratedOnAdd();

            entity.HasIndex(e => e.ClinicId, "ix_claimclinic_clid");

            entity.HasIndex(e => new { e.ClaimId, e.ClinicId }, "uk_claimclinic_cid_clid")
                .IsUnique();

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Claim)
                .WithMany(p => p.ClaimClinics)
                .HasForeignKey(d => d.ClaimId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_claimclinic_claimid");

            entity.HasOne(d => d.Clinic)
                .WithMany(p => p.ClaimClinics)
                .HasForeignKey(d => d.ClinicId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_claimclinic_clinicid");
        });

        modelBuilder.Entity<TruDatDboClaimDisposition>(entity =>
        {
            entity.HasKey(e => e.ClaimId)
                .HasName("pk_claimdisposition_cid");

            entity.ToTable("ClaimDisposition");

            entity.Property(e => e.ClaimId).ValueGeneratedNever();

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.AssignedUser)
                .WithMany(p => p.ClaimDispositionAssignedUsers)
                .HasForeignKey(d => d.AssignedUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_users2_claimdisposition");

            entity.HasOne(d => d.Claim)
                .WithOne(p => p.ClaimDisposition)
                .HasForeignKey<TruDatDboClaimDisposition>(d => d.ClaimId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_claim_claimdisposition");

            entity.HasOne(d => d.User)
                .WithMany(p => p.ClaimDispositionUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_users_claimdiposition");
        });

        modelBuilder.Entity<TruDatDboClaimExclusion>(entity =>
        {
            entity.ToTable("ClaimExclusion");

            entity.HasKey(e => e.ClaimExclusionId).HasName("PK_ClaimExclusion");

            entity.Property(e => e.ClaimExclusion1)
                .IsRequired()
                .IsUnicode(false)
                .HasColumnName("ClaimExclusion");

            entity.Property(e => e.ClaimExclusionName)
                .HasMaxLength(512)
                .IsUnicode(false);

            entity.Property(e => e.EobBlurb).HasMaxLength(2000);

            entity.Property(e => e.IsDefaultLine).HasDefaultValueSql("((0))");

            entity.Property(e => e.IsFoodExclusion).HasDefaultValueSql("((0))");

            entity.HasOne(d => d.EntityCategory)
                .WithMany(p => p.ClaimExclusions)
                .HasForeignKey(d => d.EntityCategoryId)
                .HasConstraintName("fk_claimexclusion_entityCategoryId");

            entity.HasOne(d => d.State)
                .WithMany(p => p.ClaimExclusions)
                .HasForeignKey(d => d.StateId)
                .HasConstraintName("fk_claimexclusion_stateId");
        });

        modelBuilder.Entity<TruDatDboClaimHierarchy>(entity =>
        {
            entity.ToTable("ClaimHierarchy");

            entity.HasIndex(e => e.ClaimId, "IX_ClaimIdUnique")
                .IsUnique();

            entity.HasIndex(e => e.ParentClaimId, "ix_claimhierarchy_parentid");

            entity.HasIndex(e => e.ClaimId, "uk_claimhierarchy_claimid")
                .IsUnique();

            entity.HasOne(d => d.Claim)
                .WithOne(p => p.ClaimHierarchyClaim)
                .HasForeignKey<TruDatDboClaimHierarchy>(d => d.ClaimId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ClaimHierarchyClaimId_Claim");

            entity.HasOne(d => d.ParentClaim)
                .WithMany(p => p.ClaimHierarchyParentClaims)
                .HasForeignKey(d => d.ParentClaimId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ClaimHierarchyParentId_Claim");
        });

        modelBuilder.Entity<TruDatDboClaimPrintHistory>(entity =>
        {
            entity.ToTable("ClaimPrintHistory");

            entity.HasIndex(e => e.ClaimBatchLetterId, "ix_claimprinthistoryletter");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.ClaimBatchLetter)
                .WithMany(p => p.ClaimPrintHistories)
                .HasForeignKey(d => d.ClaimBatchLetterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_claimprinthistory_claimbatchletter");

            entity.HasOne(d => d.User)
                .WithMany(p => p.ClaimPrintHistories)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_claimprinthistory_users");
        });

        modelBuilder.Entity<TruDatDboClaimProcess>(entity =>
        {
            entity.ToTable("ClaimProcess");

            entity.HasIndex(e => e.AssessmentDataId, "ix_claimprocess_assessmentdataid");

            entity.HasIndex(e => e.ClaimId, "ix_claimprocess_cid");

            entity.Property(e => e.Approved).HasColumnType("datetime");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Claim)
                .WithMany(p => p.ClaimProcesses)
                .HasForeignKey(d => d.ClaimId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_claimprocess_Claim");

            entity.HasOne(d => d.User)
                .WithMany(p => p.ClaimProcesses)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_claimprocess_users");
        });

        modelBuilder.Entity<TruDatDboClaimReviewed>(entity =>
        {
            entity.ToTable("ClaimReviewed");

            entity.HasIndex(e => new { e.ClaimId, e.AssessmentDataId }, "uk_claimreviewed_RecipientClassification")
                .IsUnique();
        });

        modelBuilder.Entity<TruDatDboClaimReviewedEventSource>(entity =>
        {
            entity.ToTable("ClaimReviewedEventSource");

            entity.HasIndex(e => e.UniqueId, "uk_claimreviewedeventstore_uniqueid")
                .IsUnique();

            entity.Property(e => e.ClaimsJson).IsRequired();
        });

        modelBuilder.Entity<TruDatDboClaimStatusLetter>(entity =>
        {
            entity.HasIndex(e => e.TemplateId, "ix_claimlettertemplatecheck");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.IsPostRequired)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.ChangedUser)
                .WithMany(p => p.ClaimStatusLetters)
                .HasForeignKey(d => d.ChangedUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_claimstatusletter_users");

            entity.HasOne(d => d.ClaimStatus)
                .WithMany(p => p.ClaimStatusLetters)
                .HasForeignKey(d => d.ClaimStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_claimstatusletter_status");
        });

        modelBuilder.Entity<TruDatDboClaimType>(entity =>
        {
            entity.ToTable("ClaimType");

            entity.HasIndex(e => e.Name, "uk_claimtype_nme")
                .IsUnique();

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");

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

        modelBuilder.Entity<TruDatDboClaimVersion>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ClaimVersion");

            entity.Property(e => e.AmountNotClaimable).HasColumnType("smallmoney");

            entity.Property(e => e.AmountPaidOut).HasColumnType("smallmoney");

            entity.Property(e => e.BoardingFees).HasColumnType("smallmoney");

            entity.Property(e => e.CauseOfInjury)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.ClaimVersion1).HasColumnName("ClaimVersion");

            entity.Property(e => e.Comments).IsUnicode(false);

            entity.Property(e => e.DateDeleted).HasColumnType("datetime");

            entity.Property(e => e.DateOfLoss).HasColumnType("smalldatetime");

            entity.Property(e => e.DeductibleAmount).HasColumnType("money");

            entity.Property(e => e.Diagnosis)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.ExamFees).HasColumnType("smallmoney");

            entity.Property(e => e.ExclusionReasonNotes).IsUnicode(false);

            entity.Property(e => e.FromQcNbEtc).HasColumnName("FromQC_NB_etc");

            entity.Property(e => e.Gst5)
                .HasColumnType("smallmoney")
                .HasColumnName("GST5");

            entity.Property(e => e.Inserted).HasColumnType("datetime");

            entity.Property(e => e.InvoiceNumbers)
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.InvoiceSubTotal).HasColumnType("smallmoney");

            entity.Property(e => e.LetterComments).IsUnicode(false);

            entity.Property(e => e.OtherVetCost).HasColumnType("smallmoney");

            entity.Property(e => e.PendingInfoComments)
                .HasMaxLength(512)
                .IsUnicode(false);

            entity.Property(e => e.Rechecks).HasColumnType("smallmoney");

            entity.Property(e => e.SalesForceId)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.TotalClaimed).HasColumnType("smallmoney");

            entity.Property(e => e.TotalCustomerClaimed).HasColumnType("smallmoney");

            entity.Property(e => e.TypeOfInjury)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.UnRelatedChargesDesc).IsUnicode(false);

            entity.Property(e => e.Updated).HasColumnType("datetime");

            entity.Property(e => e._3rdPartyLiability).HasColumnName("3rdPartyLiability");

            entity.Property(e => e._90dayClaim).HasColumnName("90DayClaim");
        });

        modelBuilder.Entity<TruDatDboClaimWorkflowSpecialBucket>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("ClaimWorkflowSpecialBucket");

            entity.HasIndex(e => e.UserId, "ix_claimworkflowspecialbucket_userId");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.ChangeUser)
                .WithMany()
                .HasForeignKey(d => d.ChangeUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_claimworkflowspecialbucket_users_changeuserId");

            entity.HasOne(d => d.User)
                .WithMany()
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_claimworkflowspecialbucket_users_userId");
        });

        modelBuilder.Entity<TruDatDboClaimWorkflowViewInstrumentation>(entity =>
        {
            entity.ToTable("ClaimWorkflowViewInstrumentation");
        });

        modelBuilder.Entity<TruDatDboClaimWorkflowViewStatsDebug>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("ClaimWorkflowViewStatsDebug");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.Property(e => e.Inserted).HasColumnType("datetime");
        });

        modelBuilder.Entity<TruDatDboClaimWorkflowViewStatus>(entity =>
        {
            entity.ToTable("ClaimWorkflowViewStatus");

            entity.HasIndex(e => e.StatusId, "ix_claimworkflowviewstatus_etid");

            entity.HasIndex(e => new { e.ClaimId, e.StatusId }, "uk_claimworkflowviewstatus_cid_sid")
                .IsUnique();

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Claim)
                .WithMany(p => p.ClaimWorkflowViewStatuses)
                .HasForeignKey(d => d.ClaimId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_claim_claimworkflowstatus");

            entity.HasOne(d => d.Status)
                .WithMany(p => p.ClaimWorkflowViewStatuses)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_status_claimworkflowviewstatus");
        });

        modelBuilder.Entity<TruDatDboClaimWorkflowViewStatusArchive>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("ClaimWorkflowViewStatusArchive");

            entity.Property(e => e.Inserted).HasColumnType("datetime");
        });

        modelBuilder.Entity<TruDatDboClaimsAdjuster>(entity =>
        {
            entity.HasKey(e => e.UserId)
                .HasName("pk_claimsadjuster_uid");

            entity.ToTable("ClaimsAdjuster");

            entity.Property(e => e.UserId).ValueGeneratedNever();

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.AllowAutoAssign)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.AssignmentStamp).HasColumnType("datetime");

            entity.HasOne(d => d.User)
                .WithOne(p => p.ClaimsAdjuster)
                .HasForeignKey<TruDatDboClaimsAdjuster>(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_user_claimsadjuster");
        });

        modelBuilder.Entity<TruDatDboClaimsTemplate>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ClaimsTemplate");

            entity.Property(e => e.Accountnumber)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ACCOUNTNUMBER");

            entity.Property(e => e.Address)
                .IsRequired()
                .HasMaxLength(201)
                .IsUnicode(false)
                .HasColumnName("ADDRESS");

            entity.Property(e => e.Adjuster)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("ADJUSTER");

            entity.Property(e => e.Adjusteremailid)
                .HasMaxLength(114)
                .IsUnicode(false)
                .HasColumnName("ADJUSTEREMAILID");

            entity.Property(e => e.Amountinwords)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("AMOUNTINWORDS");

            entity.Property(e => e.Bankaddress)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BANKADDRESS");

            entity.Property(e => e.Bankcity)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BANKCITY");

            entity.Property(e => e.Bankname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("BANKNAME");

            entity.Property(e => e.Bankstate)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("BANKSTATE")
                .IsFixedLength(true);

            entity.Property(e => e.Bankzipcode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BANKZIPCODE");

            entity.Property(e => e.Boardingfee)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("BOARDINGFEE");

            entity.Property(e => e.Checkdate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CHECKDATE");

            entity.Property(e => e.City)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CITY");

            entity.Property(e => e.Claimid).HasColumnName("CLAIMID");

            entity.Property(e => e.Claimnumber).HasColumnName("CLAIMNUMBER");

            entity.Property(e => e.Clinicaddress)
                .IsRequired()
                .HasMaxLength(201)
                .IsUnicode(false)
                .HasColumnName("CLINICADDRESS");

            entity.Property(e => e.Cliniccity)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CLINICCITY");

            entity.Property(e => e.Clinicname)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CLINICNAME");

            entity.Property(e => e.Clinicstate)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CLINICSTATE");

            entity.Property(e => e.Cliniczipcode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CLINICZIPCODE");

            entity.Property(e => e.Closeddate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CLOSEDDATE");

            entity.Property(e => e.Condition)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("CONDITION");

            entity.Property(e => e.Consultation)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CONSULTATION");

            entity.Property(e => e.Currentdate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CURRENTDATE");

            entity.Property(e => e.Dateofloss)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DATEOFLOSS");

            entity.Property(e => e.Deductibleamount)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DEDUCTIBLEAMOUNT");

            entity.Property(e => e.Denialreasons)
                .IsRequired()
                .IsUnicode(false)
                .HasColumnName("DENIALREASONS");

            entity.Property(e => e.Downchecknumber).HasColumnName("DOWNCHECKNUMBER");

            entity.Property(e => e.Emailaddress)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EMAILADDRESS");

            entity.Property(e => e.Enrolldate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ENROLLDATE");

            entity.Property(e => e.Firstname)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FIRSTNAME");

            entity.Property(e => e.Fullname)
                .IsRequired()
                .HasMaxLength(201)
                .IsUnicode(false)
                .HasColumnName("FULLNAME");

            entity.Property(e => e.Inceptiondate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("INCEPTIONDATE");

            entity.Property(e => e.Invoicenumbers)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("INVOICENUMBERS");

            entity.Property(e => e.Invoicesubtotal)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("INVOICESUBTOTAL");

            entity.Property(e => e.Lastname)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LASTNAME");

            entity.Property(e => e.Lettercomments)
                .IsUnicode(false)
                .HasColumnName("LETTERCOMMENTS");

            entity.Property(e => e.NotIncludedItems).HasColumnName("notIncludedItems");

            entity.Property(e => e.Othervetcosts)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("OTHERVETCOSTS");

            entity.Property(e => e.Ownerid).HasColumnName("OWNERID");

            entity.Property(e => e.Petname)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PETNAME");

            entity.Property(e => e.Policynumber)
                .IsRequired()
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("POLICYNUMBER");

            entity.Property(e => e.Postaladdress)
                .IsRequired()
                .HasMaxLength(76)
                .IsUnicode(false)
                .HasColumnName("POSTALADDRESS");

            entity.Property(e => e.Postalcode)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("POSTALCODE");

            entity.Property(e => e.Province)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("PROVINCE");

            entity.Property(e => e.Rechecks)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("RECHECKS");

            entity.Property(e => e.State)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("STATE");

            entity.Property(e => e.Topchecknumber).HasColumnName("TOPCHECKNUMBER");

            entity.Property(e => e.Totalclaimed)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TOTALCLAIMED");

            entity.Property(e => e.Totalclaimpaid)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TOTALCLAIMPAID");

            entity.Property(e => e.Totalclaimspaid)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TOTALCLAIMSPAID");

            entity.Property(e => e.Underwriter)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("UNDERWRITER");

            entity.Property(e => e.Unrelatedchargedesc)
                .IsUnicode(false)
                .HasColumnName("UNRELATEDCHARGEDESC");

            entity.Property(e => e.Unrelatedcharges)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("UNRELATEDCHARGES");

            entity.Property(e => e.Zipcode)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ZIPCODE");
        });

        modelBuilder.Entity<TruDatDboClaimsWeDontCountForUser>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ClaimsWeDontCountForUsers");
        });

        modelBuilder.Entity<TruDatDboClinic>(entity =>
        {
            entity.ToTable("Clinic");

            entity.HasIndex(e => e.UniqueId, "ix_dboClinic_uid");

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.AddressLastVerified).HasColumnType("datetime");

            entity.Property(e => e.AddressLine2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");

            entity.Property(e => e.AddressLine3)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.City)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ClinicRiskId).HasDefaultValueSql("((4))");

            entity.Property(e => e.ConcurrencyToken)
                .IsRequired()
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.Property(e => e.ContactName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ContactTitle)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CrmownerId).HasColumnName("CRMOwnerID");

            entity.Property(e => e.Description)
                .HasMaxLength(512)
                .IsUnicode(false);

            entity.Property(e => e.EmailAddress)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Fax)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PaymentFailedDate).HasColumnType("datetime");

            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PreferredContactMethodId).HasDefaultValueSql("((4))");

            entity.Property(e => e.SalesForceId)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UniqueId).HasDefaultValueSql("(newid())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Url)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("URL");

            entity.Property(e => e.Zipcode)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.ClinicRisk)
                .WithMany(p => p.Clinics)
                .HasForeignKey(d => d.ClinicRiskId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_clinicrisk_clinic");

            entity.HasOne(d => d.Partner)
                .WithMany(p => p.Clinics)
                .HasForeignKey(d => d.PartnerId)
                .HasConstraintName("fk_clinic_partner");

            entity.HasOne(d => d.PreferredContactMethod)
                .WithMany(p => p.Clinics)
                .HasForeignKey(d => d.PreferredContactMethodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_clinicmethodcontact_preferredid");

            entity.HasOne(d => d.State)
                .WithMany(p => p.Clinics)
                .HasForeignKey(d => d.StateId)
                .HasConstraintName("fk_state_clinic");
        });

        modelBuilder.Entity<TruDatDboClinicAttribute>(entity =>
        {
            entity.HasKey(e => new { e.ClinicId, e.Attribute })
                .HasName("pk_clinicattribute_cid_atr");

            entity.ToTable("ClinicAttribute");

            entity.HasIndex(e => new { e.Attribute, e.ClinicId }, "ix_clinicattribute_atr_cid");

            entity.HasIndex(e => e.Id, "uk_clinicattribute_id")
                .IsUnique();

            entity.Property(e => e.Attribute)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Value)
                .IsRequired()
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.Clinic)
                .WithMany(p => p.ClinicAttributes)
                .HasForeignKey(d => d.ClinicId)
                .HasConstraintName("fk_clinic_clinicattribute");
        });

        modelBuilder.Entity<TruDatDboClinicBackup0222>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("Clinic_backup_0222");

            entity.Property(e => e.AddressLine2)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AddressLine3)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.City)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ContactName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ContactTitle)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.EmailAddress)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Fax)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.Property(e => e.Inserted).HasColumnType("datetime");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SalesForceId)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Updated).HasColumnType("datetime");

            entity.Property(e => e.Url)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("URL");

            entity.Property(e => e.Zipcode)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboClinicBackup060610>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("Clinic_backup_060610");

            entity.Property(e => e.AddressLine2)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AddressLine3)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.City)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ContactName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ContactTitle)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.EmailAddress)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Fax)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.Property(e => e.Inserted).HasColumnType("datetime");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SalesForceId)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Updated).HasColumnType("datetime");

            entity.Property(e => e.Url)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("URL");

            entity.Property(e => e.Zipcode)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboClinicPartner>(entity =>
        {
            entity.ToTable("ClinicPartner");

            entity.HasIndex(e => new { e.ClinicId, e.PartnerId }, "ix_clinicpartner_cid_pid");

            entity.HasIndex(e => new { e.EndDate, e.ClinicId }, "ix_clinicpartner_ed_cid");

            entity.HasIndex(e => new { e.PartnerId, e.ClinicId }, "ix_clinicpartner_pid_cid");

            entity.HasIndex(e => e.Id, "uk_clinicpartner_id")
                .IsUnique();

            entity.Property(e => e.EndDate).HasColumnType("datetime");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.StartDate).HasColumnType("datetime");

            entity.HasOne(d => d.Clinic)
                .WithMany(p => p.ClinicPartners)
                .HasForeignKey(d => d.ClinicId)
                .HasConstraintName("fk_clinic_clinicpartner");

            entity.HasOne(d => d.Partner)
                .WithMany(p => p.ClinicPartners)
                .HasForeignKey(d => d.PartnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_partner_clinicpartner");
        });

        modelBuilder.Entity<TruDatDboClinicPartnerBackup07012010>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("ClinicPartnerBackup07012010");

            entity.Property(e => e.EndDate).HasColumnType("datetime");

            entity.Property(e => e.Inserted).HasColumnType("datetime");

            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TruDatDboClinicPet>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ClinicPets");
        });

        modelBuilder.Entity<TruDatDboClinicPsi>(entity =>
        {
            entity.ToTable("ClinicPSI");

            entity.HasIndex(e => e.HospitalId, "uk_clinicpsi_hospitalid")
                .IsUnique();

            entity.Property(e => e.ActiveDate).HasColumnType("date");

            entity.Property(e => e.Address1)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.City)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.County)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Fax)
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.Property(e => e.HospitalName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PersonEmail)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PersonFirstName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PersonLastName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PersonSalutation)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.Phone)
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.Property(e => e.PostalCode)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StateCode)
                .HasMaxLength(2)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboClinicRisk>(entity =>
        {
            entity.ToTable("ClinicRisk");

            entity.HasIndex(e => e.RiskLevel, "uk_clinicrisk_rlv")
                .IsUnique();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboClinicText>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ClinicText");

            entity.Property(e => e.AddressLine2)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AddressLine3)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.City)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ClinicName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ContactName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ContactTitle)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.EmailAddress)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Fax)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Inserted).HasColumnType("datetime");

            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SalesForceId)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.StateCode)
                .IsRequired()
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.StateName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Updated).HasColumnType("datetime");

            entity.Property(e => e.Url)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("URL");

            entity.Property(e => e.Zipcode)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboClinicVmg>(entity =>
        {
            entity.ToTable("ClinicVMG");

            entity.Property(e => e.AddressLine1)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.AddressLine2)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ClinicName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ContactFirst)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ContactLast)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ContactMiddle)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ContactNickName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ContactSuffix)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ContactTitle)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Dbaname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DBAName");

            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Vmggroup)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VMGGroup");

            entity.Property(e => e.ZipCode)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboClinicVmgPrior>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("ClinicVmgPrior");

            entity.Property(e => e.AddressLine1)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.AddressLine2)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ClinicName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ContactFirst)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ContactLast)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ContactMiddle)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ContactNickName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ContactSuffix)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ContactTitle)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Dbaname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DBAName");

            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Vmggroup)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VMGGroup");

            entity.Property(e => e.ZipCode)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboClinicVmgimport>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("ClinicVMGImport");

            entity.Property(e => e.Address1)
                .HasMaxLength(255)
                .HasColumnName("Address 1");

            entity.Property(e => e.Address2)
                .HasMaxLength(255)
                .HasColumnName("Address 2");

            entity.Property(e => e.CanZip).HasColumnName("CAN ZIP");

            entity.Property(e => e.City).HasMaxLength(255);

            entity.Property(e => e.ClinicName)
                .HasMaxLength(255)
                .HasColumnName("Clinic Name");

            entity.Property(e => e.Country).HasMaxLength(255);

            entity.Property(e => e.DbaName)
                .HasMaxLength(255)
                .HasColumnName("dba name");

            entity.Property(e => e.F21).HasMaxLength(255);

            entity.Property(e => e.F22).HasMaxLength(255);

            entity.Property(e => e.F23).HasMaxLength(255);

            entity.Property(e => e.F24).HasMaxLength(255);

            entity.Property(e => e.First).HasMaxLength(255);

            entity.Property(e => e.Group).HasMaxLength(255);

            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .HasColumnName("Last Name");

            entity.Property(e => e.Notes).HasMaxLength(255);

            entity.Property(e => e.Phone).HasMaxLength(255);

            entity.Property(e => e.State).HasMaxLength(255);

            entity.Property(e => e.Suffix).HasMaxLength(255);

            entity.Property(e => e.Type).HasMaxLength(255);

            entity.Property(e => e.VmgAcct).HasColumnName("VMG Acct #");

            entity.Property(e => e.VmgGroup).HasColumnName("VMG Group #");

            entity.Property(e => e.ZipCode)
                .HasMaxLength(255)
                .HasColumnName("Zip Code");
        });

        modelBuilder.Entity<TruDatDboClinicVpg>(entity =>
        {
            entity.ToTable("ClinicVPG");

            entity.Property(e => e.Address)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.City)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Clinic)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Dvm)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DVM");

            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.State)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Zip)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboClinicVpgimport>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("ClinicVPGImport");

            entity.Property(e => e.Address).HasMaxLength(255);

            entity.Property(e => e.City).HasMaxLength(255);

            entity.Property(e => e.Clinic).HasMaxLength(255);

            entity.Property(e => e.Dvm)
                .HasMaxLength(255)
                .HasColumnName("DVM");

            entity.Property(e => e.EffectiveDate)
                .HasColumnType("datetime")
                .HasColumnName("Effective Date");

            entity.Property(e => e.State).HasMaxLength(255);

            entity.Property(e => e.VpgAcct).HasColumnName("VPG ACCT #");
        });

        modelBuilder.Entity<TruDatDboClinicVpgprior>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("ClinicVPGPrior");

            entity.Property(e => e.Address)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.City)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Clinic)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Dvm)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DVM");

            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.State)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Zip)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboClinicvpgOld>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("clinicvpg_old");

            entity.Property(e => e.Address)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.City)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Clinic)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Dvm)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DVM");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.State)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Zip)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboCodesToRemove>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("CodesToRemove");

            entity.Property(e => e.PromoCode)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboCommandMonitor>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("CommandMonitor");

            entity.HasIndex(e => e.Id, "PK_CommandMonitor_Id")
                .IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

            entity.Property(e => e.StartedDateTimeUtc).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TruDatDboCommentsPreFix>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("CommentsPreFix");

            entity.Property(e => e.ClaimId).ValueGeneratedOnAdd();

            entity.Property(e => e.Comments).IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboCommissionModelTiming>(entity =>
        {
            entity.ToTable("CommissionModelTiming");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboCommunicationPreference>(entity =>
        {
            entity.ToTable("CommunicationPreference");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboCompetitorComparison>(entity =>
        {
            entity.ToTable("CompetitorComparison");

            entity.Property(e => e.Active).HasDefaultValueSql("((1))");

            entity.Property(e => e.CompetitorCatPremium).HasColumnType("money");

            entity.Property(e => e.CompetitorDescription)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.CompetitorDogPremium).HasColumnType("money");

            entity.Property(e => e.CompetitorName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.TruDescription)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.TruEquivCatPremium).HasColumnType("money");

            entity.Property(e => e.TruEquivDogPremium).HasColumnType("money");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TruDatDboCompletedClaim>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("CompletedClaims");
        });

        modelBuilder.Entity<TruDatDboConditionType>(entity =>
        {
            entity.ToTable("ConditionType");

            entity.HasKey(e => e.ConditionTypeId).HasName("pk_ConditionType");

            entity.Property(e => e.ConditionTypeId).HasColumnName("ConditionTypeID");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboConstant>(entity =>
        {
            entity.HasKey(e => new { e.Environment, e.Id })
                .HasName("pk_constant_env_id");

            entity.ToTable("Constant");

            entity.Property(e => e.Environment)
                .HasMaxLength(10)
                .IsUnicode(false);

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

            entity.Property(e => e.Value)
                .IsRequired()
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboContact>(entity =>
        {
            entity.ToTable("Contact");

            entity.HasIndex(e => e.Name, "uk_contact_nme")
                .IsUnique();

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");

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

        modelBuilder.Entity<TruDatDboContactMethod>(entity =>
        {
            entity.ToTable("ContactMethod");

            entity.HasIndex(e => e.Name, "uk_contactmethod_nme")
                .IsUnique();

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");

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

        modelBuilder.Entity<TruDatDboContactType>(entity =>
        {
            entity.ToTable("ContactType");

            entity.HasIndex(e => e.Name, "uk_contacttype_nme")
                .IsUnique();

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");

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

        modelBuilder.Entity<TruDatDboCorporateAccount>(entity =>
        {
            entity.ToTable("CorporateAccount");

            entity.HasIndex(e => e.Name, "uk_corporateaccount_nme")
                .IsUnique();

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.AutomaticBilling)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.BillingContactEmail)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.UniqueId).HasDefaultValueSql("(newid())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TruDatDboCorporateAccountAddress>(entity =>
        {
            entity.ToTable("CorporateAccountAddress");

            entity.HasIndex(e => new { e.CorporateAccountId, e.AddressId }, "uk_corporateaccountaddress_cid_aid")
                .IsUnique();

            entity.Property(e => e.AddressLine2)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AddressLine3)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.City)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

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

            entity.Property(e => e.Zipcode)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.Address)
                .WithMany(p => p.CorporateAccountAddresses)
                .HasForeignKey(d => d.AddressId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_address_corporateaccountaddress");

            entity.HasOne(d => d.CorporateAccount)
                .WithMany(p => p.CorporateAccountAddresses)
                .HasForeignKey(d => d.CorporateAccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_owner_corporateaccountaddress");

            entity.HasOne(d => d.State)
                .WithMany(p => p.CorporateAccountAddresses)
                .HasForeignKey(d => d.StateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_state_corporateaccountaddress");
        });

        modelBuilder.Entity<TruDatDboCorporateAccountCampaignInstance>(entity =>
        {
            entity.ToTable("CorporateAccountCampaignInstance");

            entity.HasIndex(e => e.PromoCampaignInstanceId, "ix_corporateaccountcampaigninstance_campaigninstanceid");

            entity.HasIndex(e => e.CorporateAccountId, "ix_corporateaccountcampaigninstance_corporateaccountid");

            entity.HasIndex(e => new { e.CorporateAccountId, e.PromoCampaignInstanceId }, "uk_corporateaccountcampaigninstance_corporateaccountid_promocampaigninstanceid")
                .IsUnique();

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.CorporateAccount)
                .WithMany(p => p.CorporateAccountCampaignInstances)
                .HasForeignKey(d => d.CorporateAccountId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_corporateaccount_corporateaccountcampaigninstance");
        });

        modelBuilder.Entity<TruDatDboCorporateAccountVoucher>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("CorporateAccountVoucher");

            entity.Property(e => e.CampaignCode)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CorporateAccountName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Inserted).HasColumnType("datetime");

            entity.Property(e => e.PolicyCancelationDate).HasColumnType("datetime");

            entity.Property(e => e.PolicyInceptionDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TruDatDboCost>(entity =>
        {
            entity.ToTable("Cost");

            entity.HasIndex(e => e.Name, "uk_cost_nme")
                .IsUnique();

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");

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

        modelBuilder.Entity<TruDatDboCountry>(entity =>
        {
            entity.ToTable("Country");

            entity.HasIndex(e => e.Name, "uk_country_nme")
                .IsUnique();

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.CountryCode)
                .HasMaxLength(4)
                .IsUnicode(false);

            entity.Property(e => e.Currency)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.CurrencySymbol)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false);

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

        modelBuilder.Entity<TruDatDboCounty>(entity =>
        {
            entity.ToTable("County");

            entity.HasIndex(e => new { e.StateId, e.Name }, "uk_county_sid_nme")
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

            entity.HasOne(d => d.State)
                .WithMany(p => p.Counties)
                .HasForeignKey(d => d.StateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_state_county");
        });

        modelBuilder.Entity<TruDatDboCreditCardType>(entity =>
        {
            entity.ToTable("CreditCardType");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Ccvlength).HasColumnName("CCVLength");

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

        modelBuilder.Entity<TruDatDboCurrentStatePricingEngine>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("CurrentStatePricingEngines");

            entity.Property(e => e.StateCode)
                .IsRequired()
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength(true);
        });

        modelBuilder.Entity<TruDatDboDedHistoryImport>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("DedHistoryImport");

            entity.Property(e => e.CostAmount).HasColumnName("Cost amount");

            entity.Property(e => e.EffectiveFrom)
                .HasColumnType("datetime")
                .HasColumnName("Effective From");

            entity.Property(e => e.EffectiveTo)
                .HasColumnType("datetime")
                .HasColumnName("Effective to");

            entity.Property(e => e.F10).HasMaxLength(255);

            entity.Property(e => e.F100).HasMaxLength(255);

            entity.Property(e => e.F101).HasMaxLength(255);

            entity.Property(e => e.F102).HasMaxLength(255);

            entity.Property(e => e.F103).HasMaxLength(255);

            entity.Property(e => e.F104).HasMaxLength(255);

            entity.Property(e => e.F105).HasMaxLength(255);

            entity.Property(e => e.F106).HasMaxLength(255);

            entity.Property(e => e.F11).HasMaxLength(255);

            entity.Property(e => e.F12).HasMaxLength(255);

            entity.Property(e => e.F13).HasMaxLength(255);

            entity.Property(e => e.F14).HasMaxLength(255);

            entity.Property(e => e.F15).HasMaxLength(255);

            entity.Property(e => e.F16).HasMaxLength(255);

            entity.Property(e => e.F17).HasMaxLength(255);

            entity.Property(e => e.F18).HasMaxLength(255);

            entity.Property(e => e.F19).HasMaxLength(255);

            entity.Property(e => e.F20).HasMaxLength(255);

            entity.Property(e => e.F21).HasMaxLength(255);

            entity.Property(e => e.F22).HasMaxLength(255);

            entity.Property(e => e.F23).HasMaxLength(255);

            entity.Property(e => e.F24).HasMaxLength(255);

            entity.Property(e => e.F25).HasMaxLength(255);

            entity.Property(e => e.F26).HasMaxLength(255);

            entity.Property(e => e.F27).HasMaxLength(255);

            entity.Property(e => e.F28).HasMaxLength(255);

            entity.Property(e => e.F29).HasMaxLength(255);

            entity.Property(e => e.F30).HasColumnType("datetime");

            entity.Property(e => e.F31).HasColumnType("datetime");

            entity.Property(e => e.F32).HasMaxLength(255);

            entity.Property(e => e.F33).HasMaxLength(255);

            entity.Property(e => e.F34).HasMaxLength(255);

            entity.Property(e => e.F35).HasMaxLength(255);

            entity.Property(e => e.F36).HasMaxLength(255);

            entity.Property(e => e.F37).HasMaxLength(255);

            entity.Property(e => e.F38).HasMaxLength(255);

            entity.Property(e => e.F39).HasMaxLength(255);

            entity.Property(e => e.F40).HasMaxLength(255);

            entity.Property(e => e.F41).HasMaxLength(255);

            entity.Property(e => e.F42).HasMaxLength(255);

            entity.Property(e => e.F43).HasMaxLength(255);

            entity.Property(e => e.F44).HasMaxLength(255);

            entity.Property(e => e.F45).HasMaxLength(255);

            entity.Property(e => e.F46).HasMaxLength(255);

            entity.Property(e => e.F47).HasMaxLength(255);

            entity.Property(e => e.F48).HasMaxLength(255);

            entity.Property(e => e.F49).HasMaxLength(255);

            entity.Property(e => e.F50).HasMaxLength(255);

            entity.Property(e => e.F51).HasMaxLength(255);

            entity.Property(e => e.F52).HasMaxLength(255);

            entity.Property(e => e.F53).HasMaxLength(255);

            entity.Property(e => e.F54).HasMaxLength(255);

            entity.Property(e => e.F55).HasMaxLength(255);

            entity.Property(e => e.F56).HasMaxLength(255);

            entity.Property(e => e.F57).HasMaxLength(255);

            entity.Property(e => e.F58).HasMaxLength(255);

            entity.Property(e => e.F59).HasMaxLength(255);

            entity.Property(e => e.F60).HasMaxLength(255);

            entity.Property(e => e.F61).HasMaxLength(255);

            entity.Property(e => e.F62).HasMaxLength(255);

            entity.Property(e => e.F63).HasMaxLength(255);

            entity.Property(e => e.F64).HasMaxLength(255);

            entity.Property(e => e.F65).HasMaxLength(255);

            entity.Property(e => e.F66).HasMaxLength(255);

            entity.Property(e => e.F67).HasMaxLength(255);

            entity.Property(e => e.F68).HasMaxLength(255);

            entity.Property(e => e.F69).HasMaxLength(255);

            entity.Property(e => e.F7).HasMaxLength(255);

            entity.Property(e => e.F70).HasMaxLength(255);

            entity.Property(e => e.F71).HasMaxLength(255);

            entity.Property(e => e.F72).HasMaxLength(255);

            entity.Property(e => e.F73).HasMaxLength(255);

            entity.Property(e => e.F74).HasMaxLength(255);

            entity.Property(e => e.F75).HasMaxLength(255);

            entity.Property(e => e.F76).HasMaxLength(255);

            entity.Property(e => e.F77).HasMaxLength(255);

            entity.Property(e => e.F78).HasMaxLength(255);

            entity.Property(e => e.F79).HasMaxLength(255);

            entity.Property(e => e.F8).HasMaxLength(255);

            entity.Property(e => e.F80).HasMaxLength(255);

            entity.Property(e => e.F81).HasMaxLength(255);

            entity.Property(e => e.F82).HasMaxLength(255);

            entity.Property(e => e.F83).HasMaxLength(255);

            entity.Property(e => e.F84).HasMaxLength(255);

            entity.Property(e => e.F85).HasMaxLength(255);

            entity.Property(e => e.F86).HasMaxLength(255);

            entity.Property(e => e.F87).HasMaxLength(255);

            entity.Property(e => e.F88).HasMaxLength(255);

            entity.Property(e => e.F89).HasMaxLength(255);

            entity.Property(e => e.F9).HasMaxLength(255);

            entity.Property(e => e.F90).HasMaxLength(255);

            entity.Property(e => e.F91).HasMaxLength(255);

            entity.Property(e => e.F92).HasMaxLength(255);

            entity.Property(e => e.F93).HasMaxLength(255);

            entity.Property(e => e.F94).HasMaxLength(255);

            entity.Property(e => e.F95).HasMaxLength(255);

            entity.Property(e => e.F96).HasMaxLength(255);

            entity.Property(e => e.F97).HasMaxLength(255);

            entity.Property(e => e.F98).HasMaxLength(255);

            entity.Property(e => e.F99).HasMaxLength(255);

            entity.Property(e => e.NoDeductibleChange)
                .HasMaxLength(255)
                .HasColumnName("No deductible change");

            entity.Property(e => e.PetName)
                .HasMaxLength(255)
                .HasColumnName("Pet Name");

            entity.Property(e => e.PolicyNumber)
                .HasMaxLength(255)
                .HasColumnName("Policy Number");
        });

        modelBuilder.Entity<TruDatDboDmsClaimPetInfo>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("DmsClaimPetInfo");

            entity.Property(e => e.PetName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboDmsImportAttachment>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("DmsImportAttachments");

            entity.Property(e => e.AddedOnPst)
                .HasColumnType("datetime")
                .HasColumnName("AddedOnPST");

            entity.Property(e => e.Description).IsUnicode(false);

            entity.Property(e => e.DocumentId)
                .HasMaxLength(24)
                .IsUnicode(false);

            entity.Property(e => e.FaxProtusFaxId)
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.FaxReceivedOnPst)
                .HasColumnType("datetime")
                .HasColumnName("FaxReceivedOnPST");

            entity.Property(e => e.FaxReceivingNumber)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FaxSendingNumber)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.FaxSourceHospitalName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FileName)
                .IsRequired()
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboDmsPetInfo>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("DmsPetInfo");

            entity.Property(e => e.PetName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboDotNetDataType>(entity =>
        {
            entity.ToTable("DotNetDataType");

            entity.HasIndex(e => e.Name, "uk_dotnetdatatype_nme")
                .IsUnique();

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ObjectClass)
                .IsRequired()
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TruDatDboDoubleIncrease>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("DoubleIncrease");

            entity.Property(e => e.Breed)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.CurrentRate).HasColumnType("smallmoney");

            entity.Property(e => e.PetName)
                .HasMaxLength(255)
                .HasColumnName("Pet Name");

            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PolicyNumber)
                .IsRequired()
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboEligibleCondNoOther>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("EligibleCondNoOther");

            entity.Property(e => e.EnrollDate).HasColumnType("datetime");

            entity.Property(e => e.ParentLocationName).HasMaxLength(255);

            entity.Property(e => e.PetId).HasColumnName("PetID");

            entity.Property(e => e.PolicyId).HasMaxLength(255);

            entity.Property(e => e.Ppid).HasColumnName("PPID");

            entity.Property(e => e.PreferredConditionName).HasMaxLength(255);
        });

        modelBuilder.Entity<TruDatDboEligibleConditionExport>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("EligibleConditionExport");

            entity.Property(e => e.ConditionName)
                .IsRequired()
                .HasMaxLength(256)
                .IsUnicode(false);

            entity.Property(e => e.ExportedDate).HasColumnType("datetime");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.Property(e => e.LocationName)
                .IsRequired()
                .HasMaxLength(256)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboEligibleConditionsNoNull>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("EligibleConditionsNoNull");

            entity.Property(e => e.EnrollDate).HasColumnType("datetime");

            entity.Property(e => e.ParentLocationName).HasMaxLength(255);

            entity.Property(e => e.PetId).HasColumnName("PetID");

            entity.Property(e => e.PolicyId).HasMaxLength(255);

            entity.Property(e => e.Ppid).HasColumnName("PPID");

            entity.Property(e => e.PreferredConditionName).HasMaxLength(255);
        });

        modelBuilder.Entity<TruDatDboEmailHistory>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("EmailHistory");

            entity.HasIndex(e => e.Updated, "ix_EmailHistory_Updated");

            entity.HasIndex(e => e.EntityId, "ix_dboEmailHistory_EntityId")
                .IsClustered();

            entity.HasIndex(e => new { e.EntityId, e.CompanionEntityId }, "ix_dboEmailHistory_EntityId_CompanionEntityId");

            entity.Property(e => e.Updated).HasColumnType("datetime");
        });

        modelBuilder.Entity<TruDatDboEmailSnippet>(entity =>
        {
            entity.ToTable("EmailSnippet");

            entity.HasIndex(e => e.Name, "uk_emailsnippet_nme")
                .IsUnique();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Snippet)
                .IsRequired()
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboEmergencyZipcode>(entity =>
        {
            entity.HasKey(e => new { e.Zipcode, e.StateId })
                .HasName("pk_ezipcode_zip_sid");

            entity.ToTable("EmergencyZipcode");

            entity.HasIndex(e => e.StateId, "ix_emergencyzipcode_zipcode");

            entity.Property(e => e.Zipcode)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.State)
                .WithMany(p => p.EmergencyZipcodes)
                .HasForeignKey(d => d.StateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_state_ezipcode");
        });

        modelBuilder.Entity<TruDatDboEmployeesToUpgrade>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("EmployeesToUpgrade");

            entity.Property(e => e.Encina).HasDefaultValueSql("((0))");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TruDatDboEnrolledPolicy>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("EnrolledPolicies");

            entity.Property(e => e.BreedName)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.EmailAddress)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.HomePhone)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OwnerFirstName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.OwnerLastName)
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

            entity.Property(e => e.PolicyDate).HasColumnType("datetime");

            entity.Property(e => e.PolicyNumber)
                .IsRequired()
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboEnrollmentQuote>(entity =>
        {
            entity.ToTable("EnrollmentQuote");

            entity.HasIndex(e => e.LeadId, "ix_enrollmentquote_lid");

            entity.HasIndex(e => e.SessionId, "ix_enrollmentquote_sid");

            entity.Property(e => e.AlternateFirstName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AlternateLastName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BankAccountAccountNumber)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BankAccountAccountNumberLast4)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BankAccountAccountType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.BankAccountBankCode)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BankAccountBankName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BankAccountNameOnAccount)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BankAccountTransitNumber)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BillingAddressCity)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BillingAddressLine1)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BillingAddressLine2)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BillingAddressZipcode)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CellPhone)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CommitError).IsUnicode(false);

            entity.Property(e => e.ConfirmSessionId)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CreditCardExpMonth)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.CreditCardExpYear)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.CreditCardNameOnCard)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CreditCardNumber)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CreditCardNumberLast4)
                .HasMaxLength(4)
                .IsUnicode(false);

            entity.Property(e => e.DefaultPaymentMethodStr)
                .HasMaxLength(1)
                .IsUnicode(false);

            entity.Property(e => e.EmailAddress)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.EnrollEffective).HasColumnType("datetime");

            entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

            entity.Property(e => e.FaxNumber)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.FirstName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.HomePhone)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.LastName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SecondaryEmailAddress)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SessionId)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ShippingAddressCity)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ShippingAddressLine1)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ShippingAddressLine2)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ShippingAddressZipcode)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.WorkExtension)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.WorkPhone)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboEnrollmentQuotePetPolicy>(entity =>
        {
            entity.ToTable("EnrollmentQuotePetPolicy");

            entity.HasIndex(e => e.EnrollmentQuoteId, "ix_enrollmentquotepetpolicy_eq");

            entity.HasIndex(e => e.PetPolicyId, "ix_enrollmentquotepetpolicy_pid");

            entity.Property(e => e.AdoptionDate).HasColumnType("smalldatetime");

            entity.Property(e => e.DateOfBirth).HasColumnType("smalldatetime");

            entity.Property(e => e.Deductible).HasColumnType("smallmoney");

            entity.Property(e => e.EntityTypeListIds).IsUnicode(false);

            entity.Property(e => e.EntityTypeListItemIds).IsUnicode(false);

            entity.Property(e => e.Gender)
                .IsRequired()
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength(true);

            entity.Property(e => e.LastExamDate).HasColumnType("smalldatetime");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Premium).HasColumnType("smallmoney");

            entity.Property(e => e.PromoCode)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ReferralDescription).IsUnicode(false);

            entity.Property(e => e.SelectedPolicyOptionCosts).IsUnicode(false);

            entity.Property(e => e.SelectedPolicyOptions).IsUnicode(false);

            entity.Property(e => e.SpayedNeuteredDate).HasColumnType("smalldatetime");

            entity.Property(e => e.TreatmentNotes)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.EnrollmentQuote)
                .WithMany(p => p.EnrollmentQuotePetPolicies)
                .HasForeignKey(d => d.EnrollmentQuoteId)
                .HasConstraintName("fk_enrollmentquote_enrollmentquotepetpolicy");
        });

        modelBuilder.Entity<TruDatDboEntity>(entity =>
        {
            entity.ToTable("Entity");

            entity.HasIndex(e => e.Name, "uk_entity_nme")
                .IsUnique();

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");

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

        modelBuilder.Entity<TruDatDboEntityAddress>(entity =>
        {
            entity.ToTable("EntityAddress");

            entity.HasIndex(e => new { e.EntityTypeId, e.EntityId, e.AddressId }, "uk_entityaddress_etid_eid_aid")
                .IsUnique();

            entity.Property(e => e.AddressLine2)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AddressLine3)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.City)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

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

            entity.Property(e => e.Zipcode)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.Address)
                .WithMany(p => p.EntityAddresses)
                .HasForeignKey(d => d.AddressId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_address_entityaddress");

            entity.HasOne(d => d.EntityType)
                .WithMany(p => p.EntityAddresses)
                .HasForeignKey(d => d.EntityTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_entity_entityaddress");
        });

        modelBuilder.Entity<TruDatDboEntityBankAccount>(entity =>
        {
            entity.ToTable("EntityBankAccount");

            entity.HasIndex(e => new { e.EntityTypeId, e.EntityId }, "uk_entitybankacount_etid_eid")
                .IsUnique();

            entity.Property(e => e.AccountNumber)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AccountType)
                .HasMaxLength(50)
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

            entity.HasOne(d => d.EntityType)
                .WithMany(p => p.EntityBankAccounts)
                .HasForeignKey(d => d.EntityTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_entity_entitybankaccount");
        });

        modelBuilder.Entity<TruDatDboEntityCategory>(entity =>
        {
            entity.ToTable("EntityCategory");

            entity.HasIndex(e => new { e.EntityTypeId, e.Name }, "uk_entitycategory_etid_nme")
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

        modelBuilder.Entity<TruDatDboEntityContact>(entity =>
        {
            entity.ToTable("EntityContact");

            entity.HasIndex(e => new { e.EntityTypeId, e.ContactId, e.EntityId }, "ix_entitycontact_phonecontact");

            entity.HasIndex(e => new { e.EntityTypeId, e.EntityId, e.ContactId }, "uk_entitycontact_etid_eid_cid")
                .IsUnique();

            entity.Property(e => e.AdditionalInfo)
                .HasMaxLength(512)
                .IsUnicode(false);

            entity.Property(e => e.CellPhone)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ContactName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Fax)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.HomePhone)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.SecondaryEmail)
                .HasMaxLength(256)
                .IsUnicode(false);

            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.WorkExtension)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.WorkPhone)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.Contact)
                .WithMany(p => p.EntityContacts)
                .HasForeignKey(d => d.ContactId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_contact_entitycontact");

            entity.HasOne(d => d.EntityType)
                .WithMany(p => p.EntityContacts)
                .HasForeignKey(d => d.EntityTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_entity_entitycontact");

            entity.HasOne(d => d.PreferredContactMethod)
                .WithMany(p => p.EntityContacts)
                .HasForeignKey(d => d.PreferredContactMethodId)
                .HasConstraintName("fk_contactmethod_entitycontact");
        });

        modelBuilder.Entity<TruDatDboEntityList>(entity =>
        {
            entity.ToTable("EntityList");

            entity.HasIndex(e => new { e.EntityTypeId, e.ListValue }, "uk_entitylist_etid_lv")
                .IsUnique();

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.ListDescription)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ListValue)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.EntityType)
                .WithMany(p => p.EntityLists)
                .HasForeignKey(d => d.EntityTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_entity_entitylist");
        });

        modelBuilder.Entity<TruDatDboEntityListAssociate>(entity =>
        {
            entity.HasKey(e => e.EntityListId)
                .HasName("pk_entitylistassociate_id");

            entity.ToTable("EntityListAssociate");

            entity.HasIndex(e => new { e.AssociateId, e.EntityListId }, "ix_entitylistassociate_aid_elid");

            entity.Property(e => e.EntityListId).ValueGeneratedNever();

            entity.HasOne(d => d.Associate)
                .WithMany(p => p.EntityListAssociates)
                .HasForeignKey(d => d.AssociateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_associate_entitylistassociate");

            entity.HasOne(d => d.EntityList)
                .WithOne(p => p.EntityListAssociate)
                .HasForeignKey<TruDatDboEntityListAssociate>(d => d.EntityListId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_entitylist_entitylistassociate");
        });

        modelBuilder.Entity<TruDatDboEntityListBluePearl>(entity =>
        {
            entity.HasKey(e => e.EntityListId)
                .HasName("pk_entitylistbluepearl");

            entity.ToTable("EntityListBluePearl");

            entity.Property(e => e.EntityListId).ValueGeneratedNever();

            entity.Property(e => e.Address1)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.City)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.StoreName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ZipCode)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.EntityList)
                .WithOne(p => p.EntityListBluePearl)
                .HasForeignKey<TruDatDboEntityListBluePearl>(d => d.EntityListId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_entitylistbluepearl_entitylist");
        });

        modelBuilder.Entity<TruDatDboEntityListPetCo>(entity =>
        {
            entity.HasKey(e => e.EntityListId)
                .HasName("pk_entitylistpetco_elid");

            entity.ToTable("EntityListPetCo");

            entity.HasIndex(e => e.Zipcode, "ix_entitylistpetco_zip");

            entity.Property(e => e.EntityListId).ValueGeneratedNever();

            entity.Property(e => e.Address1)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Address2)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.City)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Cocd).HasColumnName("COCD");

            entity.Property(e => e.County)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.DateOpened).HasColumnType("datetime");

            entity.Property(e => e.DateRemodeled).HasColumnType("datetime");

            entity.Property(e => e.ExpOpen).HasColumnType("datetime");

            entity.Property(e => e.FaxNumber)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Format)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.FormatDesc)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FullZip)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.MainDc).HasColumnName("MainDC");

            entity.Property(e => e.ManagerName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.RegionalDc).HasColumnName("RegionalDC");

            entity.Property(e => e.StateCode)
                .HasMaxLength(2)
                .IsUnicode(false);

            entity.Property(e => e.StoreClass)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.StoreName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Zipcode)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.EntityList)
                .WithOne(p => p.EntityListPetCo)
                .HasForeignKey<TruDatDboEntityListPetCo>(d => d.EntityListId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_entitylist_entitylistpetco");
        });

        modelBuilder.Entity<TruDatDboEntityLock>(entity =>
        {
            entity.ToTable("EntityLock");

            entity.HasIndex(e => e.SessionId, "ix_entitylock_sid");

            entity.HasIndex(e => new { e.EntityTypeId, e.EntityId }, "uk_entitylock_etid_eid")
                .IsUnique();

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Session)
                .WithMany(p => p.EntityLocks)
                .HasForeignKey(d => d.SessionId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_session_entitylock");
        });

        modelBuilder.Entity<TruDatDboEntityNote>(entity =>
        {
            entity.ToTable("EntityNote");

            entity.HasIndex(e => new { e.EntityTypeId, e.Inserted }, "i_en_TypeId_Inserted_IdUserId");

            entity.HasIndex(e => new { e.EntityTypeId, e.UserId }, "ix_entitynote_entitytypeid_userid");

            entity.HasIndex(e => new { e.EntityTypeId, e.EntityId }, "ix_entitynote_env_eid");

            entity.HasIndex(e => e.UniqueId, "uix_dboentitynote")
                .IsUnique()
                .HasFilter("([UniqueId] IS NOT NULL)");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Note)
                .IsRequired()
                .IsUnicode(false);

            entity.Property(e => e.SalesForceId)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.EntityType)
                .WithMany(p => p.EntityNotes)
                .HasForeignKey(d => d.EntityTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_entity_entitynote");
        });

        modelBuilder.Entity<TruDatDboEntityNoteBackup>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("EntityNoteBackup");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.Property(e => e.Inserted).HasColumnType("datetime");

            entity.Property(e => e.Note)
                .IsRequired()
                .IsUnicode(false);

            entity.Property(e => e.SalesForceId)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Updated).HasColumnType("datetime");
        });

        modelBuilder.Entity<TruDatDboEntityNoteOrigin>(entity =>
        {
            entity.ToTable("EntityNoteOrigin");

            entity.HasIndex(e => e.EntityNoteId, "ix_entitynoteorigin_entitynoteid");

            entity.HasIndex(e => e.EntityNoteId, "uk_entitynoteorigin_entitynoteid")
                .IsUnique();

            entity.Property(e => e.CreatedOn).HasDefaultValueSql("(sysdatetime())");

            entity.HasOne(d => d.EntityNote)
                .WithOne(p => p.EntityNoteOrigin)
                .HasForeignKey<TruDatDboEntityNoteOrigin>(d => d.EntityNoteId)
                .HasConstraintName("fk_entitynoteorigin_entitynote");
        });

        modelBuilder.Entity<TruDatDboEntityReview>(entity =>
        {
            entity.ToTable("EntityReview");

            entity.HasIndex(e => new { e.EntityTypeId, e.Role }, "ix_EntityTypeId_Role_EntityId");

            entity.HasIndex(e => new { e.EntityTypeId, e.Inserted }, "ix_entityreview_entitytypeid_entityid_inserted");

            entity.HasIndex(e => new { e.EntityTypeId, e.EntityId, e.Role }, "uk_entityreview_entitytypeid_entityid_role")
                .IsUnique();

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Role)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.EntityType)
                .WithMany(p => p.EntityReviews)
                .HasForeignKey(d => d.EntityTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_entityreview_entity");

            entity.HasOne(d => d.User)
                .WithMany(p => p.EntityReviews)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_entityreview_user");
        });

        modelBuilder.Entity<TruDatDboEntityScore>(entity =>
        {
            entity.HasIndex(e => new { e.EntityTypeId, e.EntityId }, "ix_entityscores_etid_eid");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Value)
                .HasMaxLength(5)
                .IsUnicode(false);

            entity.HasOne(d => d.EntityType)
                .WithMany(p => p.EntityScores)
                .HasForeignKey(d => d.EntityTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_entitytype_entityscores");

            entity.HasOne(d => d.Score)
                .WithMany(p => p.EntityScores)
                .HasForeignKey(d => d.ScoreId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_score_entityscores");
        });

        modelBuilder.Entity<TruDatDboEntityTree>(entity =>
        {
            entity.ToTable("EntityTree");

            entity.HasIndex(e => new { e.ParentId, e.ListValue }, "uk_entitytree_pid_lv")
                .IsUnique();

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.ListDescription)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ListValue)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Category)
                .WithMany(p => p.EntityTrees)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("fk_entitytree_cid");

            entity.HasOne(d => d.Parent)
                .WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .HasConstraintName("fk_entitytree_entitytree");
        });

        modelBuilder.Entity<TruDatDboEntityTreeAttribute>(entity =>
        {
            entity.ToTable("EntityTreeAttribute");

            entity.HasIndex(e => new { e.EntityTreeId, e.Property, e.DataType, e.Value }, "ix_entitytreeattr_etid_prop_dt_value");

            entity.HasIndex(e => new { e.EntityTreeId, e.Property }, "uk_entitytreeattribute_entitytreeid_property")
                .IsUnique();

            entity.Property(e => e.DataType)
                .IsRequired()
                .HasMaxLength(128);

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Property)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Value)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.ChangeUser)
                .WithMany(p => p.EntityTreeAttributes)
                .HasForeignKey(d => d.ChangeUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_entitytreeattribute_users");

            entity.HasOne(d => d.EntityTree)
                .WithMany(p => p.EntityTreeAttributes)
                .HasForeignKey(d => d.EntityTreeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_entitytreeattribute_entitytree");
        });

        modelBuilder.Entity<TruDatDboEntityTreeBranchMap>(entity =>
        {
            entity.HasKey(e => new { e.ParentId, e.ChildId })
                .HasName("pk_entitytreebranchmap_pid_cid");

            entity.ToTable("EntityTreeBranchMap");

            entity.HasIndex(e => new { e.ChildId, e.ParentId }, "ix_entitytreebranchmap_cid_pid");

            entity.HasOne(d => d.Child)
                .WithMany(p => p.EntityTreeBranchMapChildren)
                .HasForeignKey(d => d.ChildId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_entitytree_entitytreebranchmap_cid");

            entity.HasOne(d => d.Parent)
                .WithMany(p => p.EntityTreeBranchMapParents)
                .HasForeignKey(d => d.ParentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_entitytree_entitytreebranchmap_pid");
        });

        modelBuilder.Entity<TruDatDboFaxInProgress>(entity =>
        {
            entity.ToTable("FaxInProgress");

            entity.HasIndex(e => new { e.Priority, e.Id }, "ix_faxinprogress_pri");

            entity.HasIndex(e => e.AttachmentId, "uk_faxinprogress_aid")
                .IsUnique();

            entity.HasIndex(e => new { e.SessionId, e.AttachmentId }, "uk_faxinprogress_sid_aid")
                .IsUnique();

            entity.Property(e => e.ClinicName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.FileName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.ProtusFaxId)
                .IsRequired()
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ReceivingLine)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ReceivingNumber)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.SendingFaxNumber)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Session)
                .WithMany(p => p.FaxInProgresses)
                .HasForeignKey(d => d.SessionId)
                .HasConstraintName("fk_session_faxinprogress");
        });

        modelBuilder.Entity<TruDatDboFaxLine>(entity =>
        {
            entity.ToTable("FaxLine");

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");

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

        modelBuilder.Entity<TruDatDboFaxLineNumber>(entity =>
        {
            entity.ToTable("FaxLineNumber");

            entity.HasIndex(e => e.Number, "uk_faxlinenumber_nmb")
                .IsUnique();

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Number)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.DefaultCategory)
                .WithMany(p => p.FaxLineNumbers)
                .HasForeignKey(d => d.DefaultCategoryId)
                .HasConstraintName("fk_attachmentcategory_faxlinenumber");

            entity.HasOne(d => d.FaxLine)
                .WithMany(p => p.FaxLineNumbers)
                .HasForeignKey(d => d.FaxLineId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_faxline_faxlinenumber");
        });

        modelBuilder.Entity<TruDatDboFaxOnHold>(entity =>
        {
            entity.ToTable("FaxOnHold");

            entity.HasIndex(e => e.AttachmentId, "ix_faxonhold_aid");

            entity.HasIndex(e => e.HoldStatus, "ix_faxonhold_hs");

            entity.Property(e => e.ClinicName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.HoldAttacher)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.ProtusFaxId)
                .IsRequired()
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ReceivingLine)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ReceivingNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboFaxQueueConfiguration>(entity =>
        {
            entity.ToTable("FaxQueueConfiguration");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TruDatDboFeedback>(entity =>
        {
            entity.ToTable("Feedback");

            entity.Property(e => e.Guid)
                .HasMaxLength(512)
                .IsUnicode(false);

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Question5).IsUnicode(false);

            entity.Property(e => e.Question6)
                .HasMaxLength(512)
                .IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TruDatDboFixThese>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("FixThese");

            entity.Property(e => e.CampaignCode)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.OriginalPolicyDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TruDatDboGeoFactors2015>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("GeoFactors2015");

            entity.Property(e => e.DetailName).HasMaxLength(255);

            entity.Property(e => e.FactorChange).HasMaxLength(255);

            entity.Property(e => e.RegionName).HasMaxLength(255);

            entity.Property(e => e.StateCode).HasMaxLength(255);

            entity.Property(e => e.Zip5Code).HasMaxLength(255);
        });

        modelBuilder.Entity<TruDatDboGeoFactors2015Ca>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("GeoFactors2015CA");

            entity.Property(e => e.IsChanged).HasMaxLength(255);

            entity.Property(e => e.Province).HasMaxLength(255);

            entity.Property(e => e.RegionName).HasMaxLength(255);

            entity.Property(e => e._33digitZip)
                .HasMaxLength(255)
                .HasColumnName("33DigitZip");
        });

        modelBuilder.Entity<TruDatDboGeoFactors2015Fl>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("GeoFactors2015FL");

            entity.Property(e => e.RegionDetailName).HasMaxLength(255);

            entity.Property(e => e.RegionName).HasMaxLength(255);

            entity.Property(e => e.State).HasMaxLength(255);

            entity.Property(e => e.Zip).HasColumnName("ZIP");

            entity.Property(e => e.ZipCode).HasMaxLength(255);

            entity.Property(e => e._2015Group).HasColumnName("2015 Group");
        });

        modelBuilder.Entity<TruDatDboGeoFactors2015Sc>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("GeoFactors2015SC");

            entity.Property(e => e.State).HasMaxLength(255);

            entity.Property(e => e.Zip).HasColumnName("ZIP");

            entity.Property(e => e.ZipCode).HasMaxLength(255);

            entity.Property(e => e._2015Group).HasColumnName("2015 Group");

            entity.Property(e => e._2015RegionDetailName)
                .HasMaxLength(255)
                .HasColumnName("2015 Region Detail Name");

            entity.Property(e => e._2015RegionName)
                .HasMaxLength(255)
                .HasColumnName("2015 Region Name");
        });

        modelBuilder.Entity<TruDatDboGeoFactors2016>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("GeoFactors2016");

            entity.Property(e => e.DetailName).HasMaxLength(255);

            entity.Property(e => e.FactorChange).HasMaxLength(255);

            entity.Property(e => e.RegionName).HasMaxLength(255);

            entity.Property(e => e.StateCode).HasMaxLength(255);

            entity.Property(e => e.Zip5Code).HasMaxLength(255);
        });

        modelBuilder.Entity<TruDatDboGeoFactors2016Ca>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("GeoFactors2016CA");

            entity.Property(e => e.IsChanged).HasMaxLength(255);

            entity.Property(e => e.Province).HasMaxLength(255);

            entity.Property(e => e.RegionName).HasMaxLength(255);

            entity.Property(e => e._33digitZip)
                .HasMaxLength(255)
                .HasColumnName("33DigitZip");
        });

        modelBuilder.Entity<TruDatDboGeoFactorsLaNy>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("GeoFactorsLaNy");

            entity.Property(e => e.F18).HasMaxLength(255);

            entity.Property(e => e.F19).HasMaxLength(255);

            entity.Property(e => e.F20).HasMaxLength(255);

            entity.Property(e => e.F21).HasMaxLength(255);

            entity.Property(e => e.F3).HasMaxLength(255);

            entity.Property(e => e.F7).HasMaxLength(255);

            entity.Property(e => e.FactorChange).HasMaxLength(255);

            entity.Property(e => e.RegionDetailName).HasMaxLength(255);

            entity.Property(e => e.RegionName).HasMaxLength(255);

            entity.Property(e => e.RegionName2014).HasMaxLength(255);

            entity.Property(e => e.RegionNameDetail2014).HasMaxLength(255);

            entity.Property(e => e.State).HasMaxLength(255);

            entity.Property(e => e.Zip).HasColumnName("ZIP");

            entity.Property(e => e.ZipCode).HasMaxLength(255);
        });

        modelBuilder.Entity<TruDatDboGeoFactorsNj>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("GeoFactorsNJ");

            entity.Property(e => e.FactorChange)
                .HasMaxLength(255)
                .HasColumnName("Factor Change?");

            entity.Property(e => e.State).HasMaxLength(255);

            entity.Property(e => e.Zip).HasColumnName("ZIP");

            entity.Property(e => e.ZipCode).HasMaxLength(255);

            entity.Property(e => e._2014Detail)
                .HasMaxLength(255)
                .HasColumnName("2014 Detail");

            entity.Property(e => e._2014Name)
                .HasMaxLength(255)
                .HasColumnName("2014 Name");

            entity.Property(e => e._2015Group).HasColumnName("2015 Group");

            entity.Property(e => e._2015RegionDetailName)
                .HasMaxLength(255)
                .HasColumnName("2015 Region Detail Name");

            entity.Property(e => e._2015RegionName)
                .HasMaxLength(255)
                .HasColumnName("2015 Region Name");
        });

        modelBuilder.Entity<TruDatDboGeoRegion>(entity =>
        {
            entity.ToTable("GeoRegion");

            entity.HasIndex(e => e.ZipCode, "ix_georegion_zipcode");

            entity.Property(e => e.DetailName).IsUnicode(false);

            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ZipCode)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboGuruError>(entity =>
        {
            entity.ToTable("GuruError");

            entity.Property(e => e.GuruNumber)
                .IsRequired()
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Xml)
                .IsRequired()
                .HasColumnType("xml");
        });

        modelBuilder.Entity<TruDatDboHowDidYouHearAboutU>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("HowDidYouHearAboutUs");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.Property(e => e.Inserted).HasColumnType("datetime");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Updated).HasColumnType("datetime");
        });

        modelBuilder.Entity<TruDatDboHsbcreportFile>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("HSBCReportFile");

            entity.Property(e => e.DateCreated).HasColumnType("datetime");

            entity.Property(e => e.FileName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.HsbcreportFileId)
                .ValueGeneratedOnAdd()
                .HasColumnName("HSBCReportFileID");

            entity.Property(e => e.ReportDateTime).HasColumnType("datetime");

            entity.Property(e => e.ReportDescription)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboHsbctransmissionFile>(entity =>
        {
            entity.ToTable("HSBCTransmissionFile");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.Comments)
                .HasMaxLength(5000)
                .IsUnicode(false);

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CreditTotal).HasColumnType("money");

            entity.Property(e => e.DateCreated).HasColumnType("datetime");

            entity.Property(e => e.DebitTotal).HasColumnType("money");

            entity.Property(e => e.FileName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboIncrease>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("Increase");

            entity.HasIndex(e => e.DoubleDiscount, "ix_increase_dd");

            entity.HasIndex(e => e.OwnerId, "ix_increase_o");

            entity.HasIndex(e => e.OwnerId, "ix_increase_oid");

            entity.HasIndex(e => e.PetPolicyId, "ix_increase_ppid");

            entity.Property(e => e.Age)
                .HasColumnType("numeric(9, 4)")
                .HasColumnName("age");

            entity.Property(e => e.Breed)
                .HasColumnType("numeric(9, 4)")
                .HasColumnName("breed");

            entity.Property(e => e.Correct).HasDefaultValueSql("((0))");

            entity.Property(e => e.CurrentRate).HasColumnName("currentRate");

            entity.Property(e => e.DateForNewPremium)
                .HasMaxLength(255)
                .HasColumnName("Date for new premium");

            entity.Property(e => e.Deductible).HasColumnType("smallmoney");

            entity.Property(e => e.DoubleDiscount).HasDefaultValueSql("((0))");

            entity.Property(e => e.IsHip).HasColumnName("isHip");

            entity.Property(e => e.NewRate).HasColumnName("newRate");

            entity.Property(e => e.NewRateDiscount).HasColumnName("newRateDiscount");

            entity.Property(e => e.NoIncrease).HasDefaultValueSql("((0))");

            entity.Property(e => e.PetName)
                .HasMaxLength(255)
                .HasColumnName("Pet Name");

            entity.Property(e => e.PolicyNumber)
                .HasMaxLength(255)
                .HasColumnName("Policy Number");

            entity.Property(e => e.Postal)
                .HasColumnType("numeric(9, 4)")
                .HasColumnName("postal");

            entity.Property(e => e.PostalCode)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.SystemDeductible).HasColumnType("smallmoney");

            entity.Property(e => e.SystemHip).HasColumnType("smallmoney");

            entity.Property(e => e.SystemRate).HasColumnType("smallmoney");
        });

        modelBuilder.Entity<TruDatDboIncrease82010>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("Increase82010");

            entity.Property(e => e.BillingZipcode)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Date).HasMaxLength(255);

            entity.Property(e => e.Deductible).HasColumnType("smallmoney");

            entity.Property(e => e.NewPremium).HasColumnType("smallmoney");

            entity.Property(e => e.PetName).HasMaxLength(255);

            entity.Property(e => e.PolicyNumber).HasMaxLength(255);

            entity.Property(e => e.Premium).HasColumnType("smallmoney");
        });

        modelBuilder.Entity<TruDatDboIncrease82010Merge>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("Increase82010Merge");

            entity.Property(e => e.AddressLine2)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AddressLine3)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.City)
                .IsRequired()
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

            entity.Property(e => e.PetInfo).IsUnicode(false);

            entity.Property(e => e.PolicyNumber)
                .IsRequired()
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.StateCode)
                .IsRequired()
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength(true);

            entity.Property(e => e.Zipcode)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboIncrease82010Verify>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("Increase82010Verify");

            entity.Property(e => e.BillingZipcode)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Date).HasMaxLength(255);

            entity.Property(e => e.Deductible).HasColumnType("smallmoney");

            entity.Property(e => e.NewPremium).HasColumnType("smallmoney");

            entity.Property(e => e.PetName).HasMaxLength(255);

            entity.Property(e => e.PolicyNumber).HasMaxLength(255);

            entity.Property(e => e.Premium).HasColumnType("smallmoney");
        });

        modelBuilder.Entity<TruDatDboIncrease92010>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("Increase92010");

            entity.Property(e => e.BillingZipcode)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Date).HasMaxLength(255);

            entity.Property(e => e.Deductible).HasColumnType("smallmoney");

            entity.Property(e => e.NewPremium).HasColumnType("smallmoney");

            entity.Property(e => e.PetName).HasMaxLength(255);

            entity.Property(e => e.PolicyNumber).HasMaxLength(255);

            entity.Property(e => e.Premium).HasColumnType("smallmoney");
        });

        modelBuilder.Entity<TruDatDboIncrease92010Merge>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("Increase92010Merge");

            entity.Property(e => e.AddressLine2)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AddressLine3)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.City)
                .IsRequired()
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

            entity.Property(e => e.PetInfo).IsUnicode(false);

            entity.Property(e => e.PolicyNumber)
                .IsRequired()
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.StateCode)
                .IsRequired()
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength(true);

            entity.Property(e => e.Zipcode)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboIncrease92010Verify>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("Increase92010Verify");

            entity.Property(e => e.BillingZipcode)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Date).HasMaxLength(255);

            entity.Property(e => e.Deductible).HasColumnType("smallmoney");

            entity.Property(e => e.NewPremium).HasColumnType("smallmoney");

            entity.Property(e => e.PetName).HasMaxLength(255);

            entity.Property(e => e.PolicyNumber).HasMaxLength(255);

            entity.Property(e => e.Premium).HasColumnType("smallmoney");
        });

        modelBuilder.Entity<TruDatDboKnoticeDatum>(entity =>
        {
            entity.HasIndex(e => e.EmailAddress, "ix_knoticedata_ea");

            entity.HasIndex(e => e.PolicyNumber, "ix_knoticedata_pn");

            entity.Property(e => e.ActivePets)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.EmailAddress)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.InactivePets)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.NewEmail)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.PolicyNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboKnoticeEmailListCa>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("KnoticeEmailListCA");

            entity.HasIndex(e => e.EmailAddress, "ix_knoticeemaillistca_e");

            entity.Property(e => e.AccountNumber).HasMaxLength(255);

            entity.Property(e => e.City).HasMaxLength(255);

            entity.Property(e => e.EmailAddress).HasMaxLength(255);

            entity.Property(e => e.FirstName).HasMaxLength(255);

            entity.Property(e => e.LastName).HasMaxLength(255);

            entity.Property(e => e.StateProvince).HasMaxLength(255);

            entity.Property(e => e.TrupanionCustomerInfoPolicyHolder).HasColumnName("TrupanionCustomerInfo#PolicyHolder");
        });

        modelBuilder.Entity<TruDatDboLanguage>(entity =>
        {
            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TruDatDboMdrefundDatum>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("MDRefundData");

            entity.Property(e => e.AmountOfRefund)
                .HasColumnType("money")
                .HasColumnName("Amount of Refund");

            entity.Property(e => e.DateOfRefund)
                .HasColumnType("datetime")
                .HasColumnName("Date of Refund");

            entity.Property(e => e.OwnerName)
                .HasMaxLength(255)
                .HasColumnName("Owner Name");

            entity.Property(e => e.PolicyDate)
                .HasColumnType("datetime")
                .HasColumnName("Policy Date");

            entity.Property(e => e.PolicyNumber)
                .HasMaxLength(255)
                .HasColumnName("Policy Number");

            entity.Property(e => e.PreviousPremium)
                .HasColumnType("money")
                .HasColumnName("Previous Premium");

            entity.Property(e => e.UpdatedPremium)
                .HasColumnType("money")
                .HasColumnName("Updated Premium");
        });

        modelBuilder.Entity<TruDatDboMdrefundParameter>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("MDRefundParameters");
        });

        modelBuilder.Entity<TruDatDboMemberPortalExportUser>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("MemberPortalExportUsers");

            entity.Property(e => e.EmailAddress)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.EmailAddress2)
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

            entity.Property(e => e.Password)
                .IsRequired()
                .HasMaxLength(128);

            entity.Property(e => e.PasswordSalt)
                .IsRequired()
                .HasMaxLength(128);

            entity.Property(e => e.PolicyNumber)
                .IsRequired()
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboMigrationHistory>(entity =>
        {
            entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                .HasName("PK_dbo.__MigrationHistory");

            entity.ToTable("__MigrationHistory");

            entity.Property(e => e.MigrationId).HasMaxLength(150);

            entity.Property(e => e.ContextKey).HasMaxLength(300);

            entity.Property(e => e.Model).IsRequired();

            entity.Property(e => e.ProductVersion)
                .IsRequired()
                .HasMaxLength(32);
        });

        modelBuilder.Entity<TruDatDboMissedIncrease>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("MissedIncrease");

            entity.Property(e => e.CurrentDeductible).HasColumnName("Current Deductible");

            entity.Property(e => e.CurrentPremium).HasColumnName("Current Premium");

            entity.Property(e => e.NewRate).HasColumnName("New Rate");

            entity.Property(e => e.Pet).HasMaxLength(255);

            entity.Property(e => e.Policy).HasMaxLength(255);

            entity.Property(e => e.PremiumIncrease).HasColumnType("smallmoney");

            entity.Property(e => e.ProblemSince)
                .HasMaxLength(255)
                .HasColumnName("Problem Since");

            entity.Property(e => e.ShouldBeIfTheyWerenTCappedWhatItWillBeIfTheyChang).HasColumnName("Should be if they weren't capped / What it will be if they chang");
        });

        modelBuilder.Entity<TruDatDboMissingClaim>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CheckClosedDate)
                .HasColumnType("datetime")
                .HasColumnName("Check/Closed Date");

            entity.Property(e => e.ClaimNumber).HasColumnName("Claim Number");

            entity.Property(e => e.ClaimStatus)
                .HasMaxLength(255)
                .HasColumnName("Claim Status");

            entity.Property(e => e.DateOfLoss)
                .HasColumnType("datetime")
                .HasColumnName("Date of Loss");

            entity.Property(e => e.DeductibleApplied).HasColumnName("Deductible Applied");

            entity.Property(e => e.InsuredName)
                .HasMaxLength(255)
                .HasColumnName("Insured Name");

            entity.Property(e => e.InvoiceTotal).HasColumnName("Invoice Total");

            entity.Property(e => e.PetId).HasColumnName("Pet ID");

            entity.Property(e => e.PetName)
                .HasMaxLength(255)
                .HasColumnName("Pet Name");

            entity.Property(e => e.PolicyNumber)
                .HasMaxLength(255)
                .HasColumnName("Policy Number");
        });

        modelBuilder.Entity<TruDatDboMissingLeadSource>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("MissingLeadSource");

            entity.Property(e => e.OwnerPolicyNumber)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PetPolicyNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboMissingOrder>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.FirstFullOrder)
                .HasColumnType("datetime")
                .HasColumnName("First Full Order");

            entity.Property(e => e.FullOrderId).HasColumnName("Full OrderId");

            entity.Property(e => e.Missing).HasColumnName("Missing $$");

            entity.Property(e => e.MissingOrder1)
                .HasColumnType("datetime")
                .HasColumnName("~ Missing Order");

            entity.Property(e => e.PetAdd)
                .HasColumnType("datetime")
                .HasColumnName("Pet Add");

            entity.Property(e => e.PetAddOrderId).HasColumnName("Pet Add OrderId");

            entity.Property(e => e.Petname).HasMaxLength(255);

            entity.Property(e => e.PolicyNumber).HasMaxLength(255);
        });

        modelBuilder.Entity<TruDatDboNewCanadaZip>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("NewCanadaZip");

            entity.Property(e => e.CityName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CityType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Latitude)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Longitude)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.PostalCode)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ProvinceAbbr)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ProvinceName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboNewYorkEligiblePolicy>(entity =>
        {
            entity.Property(e => e.AddressInserted).HasColumnType("datetime");

            entity.Property(e => e.AddressUpdated).HasColumnType("datetime");

            entity.Property(e => e.CoreRenewal)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CoverageEffective).HasColumnType("datetime");

            entity.Property(e => e.DropDate).HasColumnType("date");

            entity.Property(e => e.EffectiveUpgrade).HasColumnType("date");

            entity.Property(e => e.HistoryMoved).HasColumnType("datetime");

            entity.Property(e => e.Inserted).HasColumnType("datetime");

            entity.Property(e => e.NewDate).HasColumnType("date");

            entity.Property(e => e.Note)
                .HasMaxLength(512)
                .IsUnicode(false);

            entity.Property(e => e.PolicyDate).HasColumnType("datetime");

            entity.Property(e => e.Updated).HasColumnType("datetime");
        });

        modelBuilder.Entity<TruDatDboNonTrendActiveEngine>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("NonTrendActiveEngines");

            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

            entity.Property(e => e.Inserted).HasColumnType("datetime");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RetireDate).HasColumnType("datetime");

            entity.Property(e => e.Updated).HasColumnType("datetime");
        });

        modelBuilder.Entity<TruDatDboObservation>(entity =>
        {
            entity.ToTable("Observation");

            entity.HasKey(e => e.ObservationId).HasName("PK_Observation");

            entity.HasIndex(e => e.Active, "ix_observation_a");

            entity.HasIndex(e => new { e.ClaimId, e.PetId }, "ix_observation_cid_pid");

            entity.HasIndex(e => new { e.PetId, e.ClaimId }, "ix_observation_pid_cid");

            entity.Property(e => e.ObservationId).HasColumnName("ObservationID");

            entity.Property(e => e.AddedBy).HasMaxLength(50);

            entity.Property(e => e.AddedById).HasMaxLength(50);

            entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

            entity.Property(e => e.DateAdded).HasColumnType("datetime");

            entity.Property(e => e.DateObserved).HasColumnType("datetime");

            entity.Property(e => e.Description).IsUnicode(false);

            entity.Property(e => e.ObservationTypeId).HasColumnName("ObservationTypeID");

            entity.Property(e => e.OccurrenceTypeId).HasColumnName("OccurrenceTypeID");

            entity.Property(e => e.PetId).HasColumnName("PetID");

            entity.Property(e => e.RelationshipTypeId).HasColumnName("RelationshipTypeID");

            entity.Property(e => e.SignificanceTypeId).HasColumnName("SignificanceTypeID");
        });

        modelBuilder.Entity<TruDatDboObservationType>(entity =>
        {
            entity.ToTable("ObservationType");

            entity.HasKey(e => e.ObservationTypeId).HasName("PK_ObservationType");

            entity.Property(e => e.ObservationTypeId).HasColumnName("ObservationTypeID");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboOtherInfo>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("OtherInfo");

            entity.Property(e => e.Age).HasColumnName("age");

            entity.Property(e => e.Breed).HasColumnName("breed");

            entity.Property(e => e.F11).HasMaxLength(255);

            entity.Property(e => e.F12).HasMaxLength(255);

            entity.Property(e => e.Hip).HasColumnName("hip");

            entity.Property(e => e.HipAmount).HasColumnName("hipAmount");

            entity.Property(e => e.IsHip).HasColumnName("isHip");

            entity.Property(e => e.PetName)
                .HasMaxLength(255)
                .HasColumnName("Pet Name");

            entity.Property(e => e.PolicyNumber)
                .HasMaxLength(255)
                .HasColumnName("Policy Number");

            entity.Property(e => e.Postal).HasColumnName("postal");

            entity.Property(e => e.PostalCode).HasMaxLength(255);
        });

        modelBuilder.Entity<TruDatDboOwner>(entity =>
        {
            entity.ToTable("Owner");

            entity.HasIndex(e => e.CorporateAccountId, "ix_owner_caid");

            entity.HasIndex(e => new { e.BillingDayOfMonth, e.Id }, "ix_owner_day_id");

            entity.HasIndex(e => e.EmailAddress, "ix_owner_email");

            entity.HasIndex(e => new { e.PersonId, e.PolicyNumber }, "ix_owner_fn_ln_oid");

            entity.HasIndex(e => e.Inserted, "ix_owner_inserted");

            entity.HasIndex(e => new { e.LastName, e.FirstName, e.PolicyNumber }, "ix_owner_ln_fn_oid");

            entity.HasIndex(e => new { e.PolicyNumber, e.LastName, e.FirstName }, "ix_owner_oid_ln_fn");

            entity.HasIndex(e => e.SecondaryEmailAddress, "ix_owner_semail");

            entity.HasIndex(e => e.UserId, "ix_owner_uid");

            entity.HasIndex(e => e.PersonId, "uc_dboowner_personid")
                .IsUnique();

            entity.HasIndex(e => e.UniqueId, "uc_dboowner_uniqueid")
                .IsUnique();

            entity.HasIndex(e => e.PolicyNumber, "uk_owner_pol")
                .IsUnique();

            entity.Property(e => e.BillingPastDue).HasColumnType("datetime");

            entity.Property(e => e.BillingPastDueAmount).HasColumnType("smallmoney");

            entity.Property(e => e.CellPhone)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.CommunicationPreferenceId).HasDefaultValueSql("((1))");

            entity.Property(e => e.ConcurrencyToken)
                .IsRequired()
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.Property(e => e.EmailAddress)
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

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PaymentFailedDate).HasColumnType("datetime");

            entity.Property(e => e.PersonId).HasDefaultValueSql("(newid())");

            entity.Property(e => e.PolicyHolderUntil).HasColumnType("datetime");

            entity.Property(e => e.PolicyNumber)
                .IsRequired()
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SalesForceId)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.SecondaryEmailAddress)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.UniqueId).HasDefaultValueSql("(newid())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.WorkExtension)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.WorkPhone)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.CommunicationPreference)
                .WithMany(p => p.Owners)
                .HasForeignKey(d => d.CommunicationPreferenceId)
                .HasConstraintName("fk_ecommunicationpreference_owner");

            entity.HasOne(d => d.CorporateAccount)
                .WithMany(p => p.Owners)
                .HasForeignKey(d => d.CorporateAccountId)
                .HasConstraintName("fk_corporateaccount_owner");
        });

        modelBuilder.Entity<TruDatDboOwnerAddress>(entity =>
        {
            entity.ToTable("OwnerAddress");

            entity.HasIndex(e => new { e.OwnerId, e.AddressId }, "UQ__OwnerAdd__2102471628BDA232")
                .IsUnique();

            entity.HasIndex(e => new { e.AddressId, e.StateId }, "ix_owneraddress_ad_sd");

            entity.HasIndex(e => e.AddressId, "ix_owneraddress_aid_oid_sid");

            entity.HasIndex(e => new { e.OwnerId, e.StateId }, "ix_owneraddress_sid");

            entity.HasIndex(e => e.Zipcode, "ix_owneraddress_zip");

            entity.HasIndex(e => new { e.OwnerId, e.AddressId }, "uk_owneraddress_oid_aid")
                .IsUnique();

            entity.Property(e => e.AddressLine2)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AddressLine3)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.City)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ConcurrencyToken)
                .IsRequired()
                .IsRowVersion()
                .IsConcurrencyToken();

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

            entity.Property(e => e.Zipcode)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.Address)
                .WithMany(p => p.OwnerAddresses)
                .HasForeignKey(d => d.AddressId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_address_owneraddress");

            entity.HasOne(d => d.Owner)
                .WithMany(p => p.OwnerAddresses)
                .HasForeignKey(d => d.OwnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_owner_owneraddress");

            entity.HasOne(d => d.State)
                .WithMany(p => p.OwnerAddresses)
                .HasForeignKey(d => d.StateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_state_owneraddress");
        });

        modelBuilder.Entity<TruDatDboOwnerAlternateName>(entity =>
        {
            entity.HasKey(e => e.OwnerId)
                .HasName("pk_owneralternatename");

            entity.ToTable("OwnerAlternateName");

            entity.HasIndex(e => e.UniqueId, "uk_dboowneralternatename_uniqueid")
                .IsUnique();

            entity.Property(e => e.OwnerId).ValueGeneratedNever();

            entity.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.UniqueId).HasDefaultValueSql("(newid())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TruDatDboOwnerAlternateNameText>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OwnerAlternateNameText");

            entity.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(201)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboOwnerAssociation>(entity =>
        {
            entity.ToTable("OwnerAssociation");

            entity.HasIndex(e => new { e.OwnerId, e.EntityTypeId }, "uk_ownerassociation_owner_entitytypeid")
                .IsUnique();

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.ChangeUser)
                .WithMany(p => p.OwnerAssociations)
                .HasForeignKey(d => d.ChangeUserId)
                .HasConstraintName("fk_ownerassociation_users");

            entity.HasOne(d => d.EntityType)
                .WithMany(p => p.OwnerAssociations)
                .HasForeignKey(d => d.EntityTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ownerassociation_entity");

            entity.HasOne(d => d.Owner)
                .WithMany(p => p.OwnerAssociations)
                .HasForeignKey(d => d.OwnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ownerassociation_owner");
        });

        modelBuilder.Entity<TruDatDboOwnerAttribute>(entity =>
        {
            entity.ToTable("OwnerAttribute");

            entity.HasIndex(e => new { e.OwnerId, e.Attribute }, "uk_ownerattribute_oid_atr")
                .IsUnique();

            entity.Property(e => e.Attribute)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Value)
                .IsRequired()
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.ChangeUser)
                .WithMany(p => p.OwnerAttributes)
                .HasForeignKey(d => d.ChangeUserId)
                .HasConstraintName("fk_users_ownerattribute");

            entity.HasOne(d => d.Owner)
                .WithMany(p => p.OwnerAttributes)
                .HasForeignKey(d => d.OwnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_owner_ownerattribute");
        });

        modelBuilder.Entity<TruDatDboOwnerCharity>(entity =>
        {
            entity.HasKey(e => e.OwnerId)
                .HasName("pk_ownercharity_pid");

            entity.ToTable("OwnerCharity");

            entity.HasIndex(e => new { e.CharityId, e.OwnerId }, "ix_ownercharity_cid_oid");

            entity.Property(e => e.OwnerId).ValueGeneratedNever();

            entity.Property(e => e.CharityValue).HasColumnType("smallmoney");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Charity)
                .WithMany(p => p.OwnerCharities)
                .HasForeignKey(d => d.CharityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_charity_petpolicycharity");

            entity.HasOne(d => d.Owner)
                .WithOne(p => p.OwnerCharity)
                .HasForeignKey<TruDatDboOwnerCharity>(d => d.OwnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_owner_ownercharity");
        });

        modelBuilder.Entity<TruDatDboOwnerCharityEffective>(entity =>
        {
            entity.ToTable("OwnerCharityEffective");

            entity.HasIndex(e => new { e.OwnerId, e.EffectiveFrom, e.EffectiveTo }, "uk_ownercharityeffective_oid_efffrom_effto")
                .IsUnique();

            entity.Property(e => e.CharityValue).HasColumnType("smallmoney");

            entity.Property(e => e.EffectiveFrom).HasColumnType("date");

            entity.Property(e => e.EffectiveTo).HasColumnType("date");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.ChangeUser)
                .WithMany(p => p.OwnerCharityEffectives)
                .HasForeignKey(d => d.ChangeUserId)
                .HasConstraintName("fk_ownercharityeffective_users");

            entity.HasOne(d => d.Charity)
                .WithMany(p => p.OwnerCharityEffectives)
                .HasForeignKey(d => d.CharityId)
                .HasConstraintName("fk_ownercharityeffective_charity");

            entity.HasOne(d => d.Owner)
                .WithMany(p => p.OwnerCharityEffectives)
                .HasForeignKey(d => d.OwnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ownercharityeffective_owner");
        });

        modelBuilder.Entity<TruDatDboOwnerCorporateAccountHistory>(entity =>
        {
            entity.ToTable("OwnerCorporateAccountHistory");

            entity.Property(e => e.ActionType)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.Owner)
                .WithMany(p => p.OwnerCorporateAccountHistories)
                .HasForeignKey(d => d.OwnerId)
                .HasConstraintName("fk_owner_ownercorporateaccounthistory_id_ownerid");
        });

        modelBuilder.Entity<TruDatDboOwnerEmailCategory>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("OwnerEmailCategory");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.Property(e => e.Name)
                .IsRequired()
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboOwnerFailedPaymentDatum>(entity =>
        {
            entity.HasKey(e => e.OwnerId)
                .HasName("pk_dboOwnerFailedPaymentData_ownerId");

            entity.Property(e => e.OwnerId).ValueGeneratedNever();

            entity.Property(e => e.PaymentFailedDefaultPaymentMethodId).HasMaxLength(40);

            entity.HasOne(d => d.Owner)
                .WithOne(p => p.OwnerFailedPaymentDatum)
                .HasForeignKey<TruDatDboOwnerFailedPaymentDatum>(d => d.OwnerId)
                .HasConstraintName("fk_dboOwnerFailedPaymentData_dboOwner");
        });

        modelBuilder.Entity<TruDatDboOwnerInvestigation>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("OwnerInvestigation");

            entity.HasIndex(e => e.OwnerId, "ix_ownerinvestigation_oid");

            entity.HasIndex(e => new { e.PetPolicyId, e.OwnerId }, "ix_ownerinvestigation_pid_oid")
                .IsUnique();

            entity.Property(e => e.BillingDate).HasColumnType("datetime");

            entity.Property(e => e.Lastday).HasColumnName("lastday");
        });

        modelBuilder.Entity<TruDatDboOwnerLanguagePreference>(entity =>
        {
            entity.HasKey(e => e.OwnerId);

            entity.ToTable("OwnerLanguagePreference");

            entity.Property(e => e.OwnerId).ValueGeneratedNever();

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.ChangeUser)
                .WithMany(p => p.OwnerLanguagePreferences)
                .HasForeignKey(d => d.ChangeUserId)
                .HasConstraintName("fk_ownerlanguagepref");

            entity.HasOne(d => d.Language)
                .WithMany(p => p.OwnerLanguagePreferences)
                .HasForeignKey(d => d.LanguageId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ownerlanguagepref_languages");

            entity.HasOne(d => d.Owner)
                .WithOne(p => p.OwnerLanguagePreference)
                .HasForeignKey<TruDatDboOwnerLanguagePreference>(d => d.OwnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_ownerlanguagepref_language");
        });

        modelBuilder.Entity<TruDatDboOwnerManualRateLetter>(entity =>
        {
            entity.ToTable("OwnerManualRateLetter");

            entity.HasIndex(e => e.WorkflowCaseId, "ix_ownermanualrateletter_wid");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.LetterText).IsUnicode(false);

            entity.HasOne(d => d.WorkflowCase)
                .WithMany(p => p.OwnerManualRateLetters)
                .HasForeignKey(d => d.WorkflowCaseId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_workflowcase_ownermanualrateletter");
        });

        modelBuilder.Entity<TruDatDboOwnerPendingRateChange>(entity =>
        {
            entity.HasKey(e => e.OwnerId)
                .HasName("pk_ownerpendingratechange_oid");

            entity.ToTable("OwnerPendingRateChange");

            entity.Property(e => e.OwnerId).ValueGeneratedNever();

            entity.Property(e => e.DateAsOf).HasColumnType("date");

            entity.Property(e => e.EffectiveDate).HasColumnType("date");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.NoticeDate).HasColumnType("date");

            entity.Property(e => e.ScheduleError).IsUnicode(false);

            entity.Property(e => e.StateRequiredNoticeDate).HasColumnType("date");

            entity.HasOne(d => d.Owner)
                .WithOne(p => p.OwnerPendingRateChange)
                .HasForeignKey<TruDatDboOwnerPendingRateChange>(d => d.OwnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_owner_ownerpendingratechange");
        });

        modelBuilder.Entity<TruDatDboOwnerPolicyHolderUntil>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OwnerPolicyHolderUntil");

            entity.Property(e => e.PolicyHolderUntil).HasColumnType("datetime");
        });

        modelBuilder.Entity<TruDatDboOwnerText>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("OwnerText");

            entity.Property(e => e.CellPhone)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.EmailAddress)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Engine)
                .IsRequired()
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

            entity.Property(e => e.Inserted).HasColumnType("datetime");

            entity.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(201)
                .IsUnicode(false);

            entity.Property(e => e.PolicyNumber)
                .IsRequired()
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.SalesForceId)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.SecondaryEmail)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.State)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.StateCode)
                .IsRequired()
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.Updated).HasColumnType("datetime");

            entity.Property(e => e.WorkExtension)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.WorkPhone)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboOwnerVisionClaimMigrationStatus>(entity =>
        {
            entity.ToTable("OwnerVisionClaimMigrationStatus");

            entity.HasIndex(e => e.OwnerId, "ix_dboOwnerVisionClaimMigrationStatus_ownerId");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.Property(e => e.MigrationTimeStamp).HasColumnType("datetime");

            entity.HasOne(d => d.Owner)
                .WithMany(p => p.OwnerVisionClaimMigrationStatuses)
                .HasForeignKey(d => d.OwnerId)
                .HasConstraintName("fk_dboOwnerVisionClaimMigrationStatus_owner");
        });

        modelBuilder.Entity<TruDatDboOwnerVisionClaimSyncStatus>(entity =>
        {
            entity.HasKey(e => e.OwnerId)
                .HasName("pk_dboOwnerVisionClaimSyncStatus");

            entity.ToTable("OwnerVisionClaimSyncStatus");

            entity.Property(e => e.OwnerId).ValueGeneratedNever();

            entity.HasOne(d => d.Owner)
                .WithOne(p => p.OwnerVisionClaimSyncStatus)
                .HasForeignKey<TruDatDboOwnerVisionClaimSyncStatus>(d => d.OwnerId)
                .HasConstraintName("fk_dboOwnerVisionClaimSyncStatus_owner");
        });

        modelBuilder.Entity<TruDatDboOwnerVisionPolicyMigrationStatus>(entity =>
        {
            entity.HasKey(e => e.OwnerId)
                .HasName("pk_dboOwnerVisionPolicyMigrationStatus");

            entity.ToTable("OwnerVisionPolicyMigrationStatus");

            entity.HasIndex(e => e.MigrationStatusId, "ix_dboOwnerVisionPolicyMigrationStatus_migrationStatusId");

            entity.Property(e => e.OwnerId).ValueGeneratedNever();

            entity.Property(e => e.MigrationTimeStamp).HasColumnType("datetime");

            entity.HasOne(d => d.Owner)
                .WithOne(p => p.OwnerVisionPolicyMigrationStatus)
                .HasForeignKey<TruDatDboOwnerVisionPolicyMigrationStatus>(d => d.OwnerId)
                .HasConstraintName("fk_dboOwnerVisionPolicyMigrationStatus_owner");
        });

        modelBuilder.Entity<TruDatDboPartner>(entity =>
        {
            entity.ToTable("Partner");

            entity.HasIndex(e => new { e.StateId, e.Id }, "ix_partner_sid_pid");

            entity.HasIndex(e => e.UserId, "ix_partner_userid_notnull")
                .IsUnique()
                .HasFilter("([UserId] IS NOT NULL)");

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.AddressLine2)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AddressLine3)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CellPhone)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.City)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ContactMethod)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.EmailAddress)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ExperienceWithPets)
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.HeardAboutUsFrom)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.HomePhone)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SalesExperience)
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.SalesForceId)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.WorkPhone)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.Zipcode)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.Category)
                .WithMany(p => p.Partners)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("fk_entitycategory_categoryid");

            entity.HasOne(d => d.State)
                .WithMany(p => p.Partners)
                .HasForeignKey(d => d.StateId)
                .HasConstraintName("fk_state_partner");
        });

        modelBuilder.Entity<TruDatDboPartnerProjection>(entity =>
        {
            entity.HasKey(e => new { e.PartnerId, e.Month });

            entity.ToTable("PartnerProjection");

            entity.Property(e => e.Factor).HasColumnType("numeric(5, 4)");
        });

        modelBuilder.Entity<TruDatDboPartnerSignup>(entity =>
        {
            entity.HasKey(e => e.PartnerId);

            entity.ToTable("PartnerSignup");

            entity.Property(e => e.PartnerId).ValueGeneratedNever();

            entity.Property(e => e.AdpId)
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.Property(e => e.BasePay).HasColumnType("money");

            entity.Property(e => e.EmailCommissions).HasDefaultValueSql("((1))");

            entity.Property(e => e.GoalStartDate).HasColumnType("datetime");

            entity.Property(e => e.Manager)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.NewEnrollmentCommission).HasColumnType("smallmoney");

            entity.Property(e => e.RecurringEnrollmentCommission).HasColumnType("smallmoney");

            entity.Property(e => e.SignupDate).HasColumnType("datetime");

            entity.Property(e => e.TermDate).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<TruDatDboPartnerZipcode>(entity =>
        {
            entity.ToTable("PartnerZipcode");

            entity.HasIndex(e => new { e.EndDate, e.Zipcode }, "ix_partnerzipcode_ed_zip");

            entity.Property(e => e.EndDate).HasColumnType("datetime");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.StartDate).HasColumnType("datetime");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Zipcode)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.Partner)
                .WithMany(p => p.PartnerZipcodes)
                .HasForeignKey(d => d.PartnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_partner_partnerzipcode");
        });

        modelBuilder.Entity<TruDatDboPartnerZipcodePattern>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("PartnerZipcodePattern");

            entity.HasIndex(e => e.Id, "uk_partnerzipcodepattern_id")
                .IsUnique();

            entity.Property(e => e.EndDate).HasColumnType("datetime");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.StartDate).HasColumnType("datetime");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.ZipcodePattern)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.Partner)
                .WithMany()
                .HasForeignKey(d => d.PartnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_partner_partnerzipcodepattern");
        });

        modelBuilder.Entity<TruDatDboPartnershipGroup>(entity =>
        {
            entity.ToTable("PartnershipGroup");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<TruDatDboPendingPremium>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PendingPremiums");

            entity.Property(e => e.EffectiveDate).HasColumnType("date");

            entity.Property(e => e.PendingValue)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.UnCappedPremium).HasColumnType("smallmoney");
        });

        modelBuilder.Entity<TruDatDboPerformanceTraceDatum>(entity =>
        {
            entity.HasKey(e => e.RowNumber)
                .HasName("PK__Performa__AAAC09D83D1FF0BE");

            entity.Property(e => e.ApplicationName).HasMaxLength(128);

            entity.Property(e => e.BinaryData).HasColumnType("image");

            entity.Property(e => e.ClientProcessId).HasColumnName("ClientProcessID");

            entity.Property(e => e.Cpu).HasColumnName("CPU");

            entity.Property(e => e.DatabaseId).HasColumnName("DatabaseID");

            entity.Property(e => e.DatabaseName).HasMaxLength(128);

            entity.Property(e => e.EndTime).HasColumnType("datetime");

            entity.Property(e => e.GroupId).HasColumnName("GroupID");

            entity.Property(e => e.HostName).HasMaxLength(128);

            entity.Property(e => e.LoginName).HasMaxLength(128);

            entity.Property(e => e.LoginSid).HasColumnType("image");

            entity.Property(e => e.NtdomainName)
                .HasMaxLength(128)
                .HasColumnName("NTDomainName");

            entity.Property(e => e.NtuserName)
                .HasMaxLength(128)
                .HasColumnName("NTUserName");

            entity.Property(e => e.ObjectName).HasMaxLength(128);

            entity.Property(e => e.RequestId).HasColumnName("RequestID");

            entity.Property(e => e.ServerName).HasMaxLength(128);

            entity.Property(e => e.SessionLoginName).HasMaxLength(128);

            entity.Property(e => e.Spid).HasColumnName("SPID");

            entity.Property(e => e.StartTime).HasColumnType("datetime");

            entity.Property(e => e.TextData).HasColumnType("ntext");

            entity.Property(e => e.TransactionId).HasColumnName("TransactionID");
        });

        modelBuilder.Entity<TruDatDboPet>(entity =>
        {
            entity.ToTable("Pet");

            entity.HasIndex(e => new { e.BreedId, e.PawPrintHistoryId }, "ix_ped_bid_oid_nme_ppid_uid");

            entity.HasIndex(e => e.OwnerId, "ix_ped_oid")
                .HasFillFactor((byte)70);

            entity.HasIndex(e => e.BreedId, "ix_pet_bid")
                .HasFillFactor((byte)70);

            entity.HasIndex(e => e.LastPawPrintDocumentId, "ix_pet_doc")
                .HasFillFactor((byte)70);

            entity.HasIndex(e => e.PawPrintStatusId, "ix_pet_pps")
                .HasFillFactor((byte)70);

            entity.HasIndex(e => e.UniqueId, "uc_dbopet_uniqueid")
                .IsUnique();

            entity.Property(e => e.DateOfBirth).HasColumnType("smalldatetime");

            entity.Property(e => e.Edcdate)
                .HasColumnType("smalldatetime")
                .HasColumnName("EDCDate");

            entity.Property(e => e.Gender)
                .IsRequired()
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength(true);

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ParentClaimsValidated)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.SalesForceId)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.StatusChangeDate).HasColumnType("smalldatetime");

            entity.Property(e => e.UniqueId).HasDefaultValueSql("(newid())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Breed)
                .WithMany(p => p.Pets)
                .HasForeignKey(d => d.BreedId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_breed_pet");

            entity.HasOne(d => d.Owner)
                .WithMany(p => p.Pets)
                .HasForeignKey(d => d.OwnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_owner_pet");

            entity.HasOne(d => d.PawPrintHistory)
                .WithMany(p => p.PetPawPrintHistories)
                .HasForeignKey(d => d.PawPrintHistoryId)
                .HasConstraintName("fk_pet_pawprinthistory");

            entity.HasOne(d => d.PetFood)
                .WithMany(p => p.Pets)
                .HasForeignKey(d => d.PetFoodId)
                .HasConstraintName("fk_petfood_pet");

            entity.HasOne(d => d.SoapStatus)
                .WithMany(p => p.PetSoapStatuses)
                .HasForeignKey(d => d.SoapStatusId)
                .HasConstraintName("fk_pet_soapstatus");

            entity.HasOne(d => d.WorkingPet)
                .WithMany(p => p.Pets)
                .HasForeignKey(d => d.WorkingPetId)
                .HasConstraintName("fk_workingpet_pet");
        });

        modelBuilder.Entity<TruDatDboPetAttribute>(entity =>
        {
            entity.ToTable("PetAttribute");

            entity.HasIndex(e => new { e.Attribute, e.PetId }, "ix_petattribute_aid_pid");

            entity.HasIndex(e => new { e.PetId, e.Attribute }, "uk_petattribute_petid_attribute")
                .IsUnique();

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.Attribute)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Value)
                .IsRequired()
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.Pet)
                .WithMany(p => p.PetAttributes)
                .HasForeignKey(d => d.PetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pet_petattribute");
        });

        modelBuilder.Entity<TruDatDboPetFood>(entity =>
        {
            entity.ToTable("PetFood");

            entity.HasIndex(e => new { e.Name, e.CountryId }, "uk_petfood_nme_countryid")
                .IsUnique();

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Country)
                .WithMany(p => p.PetFoods)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_petfood_country");
        });

        modelBuilder.Entity<TruDatDboPetPolicy>(entity =>
        {
            entity.ToTable("PetPolicy");

            entity.HasIndex(e => new { e.PolicyNumber, e.PolicyDate, e.DocumentVersionId, e.PlanId }, "ix_PetPolicy_DocumentVersionId");

            entity.HasIndex(e => e.Inserted, "ix_petpolicy_Inserted")
                .HasFillFactor((byte)70);

            entity.HasIndex(e => e.PolicyDate, "ix_petpolicy_date")
                .HasFillFactor((byte)70);

            entity.HasIndex(e => e.EnrollmentStatusId, "ix_petpolicy_enrollmentstatusid");

            entity.HasIndex(e => e.PolicyId, "ix_petpolicy_oid");

            entity.HasIndex(e => e.PolicyNumber, "ix_petpolicy_onum")
                .HasFillFactor((byte)70);

            entity.HasIndex(e => e.ProductId, "ix_petpolicy_prodid_petid");

            entity.HasIndex(e => e.EngineVersionId, "ix_petpolicy_ver")
                .HasFillFactor((byte)70);

            entity.HasIndex(e => e.UniqueId, "uc_petpolicy_uniqueid")
                .IsUnique();

            entity.HasIndex(e => e.PetId, "uk_petpolicy_petid")
                .IsUnique();

            entity.HasIndex(e => new { e.PetId, e.PolicyId }, "uk_petpolicy_pid_oid")
                .IsUnique();

            entity.HasIndex(e => e.PolicyNumber, "uk_petpolicy_pol")
                .IsUnique();

            entity.Property(e => e.CoinsurancePercentage).HasColumnType("decimal(5, 2)");

            entity.Property(e => e.CrmsecondaryOwnerId).HasColumnName("CRMSecondaryOwnerId");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.PolicyDate)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.PolicyNumber)
                .IsRequired()
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.PolicyPaidThru).HasColumnType("datetime");

            entity.Property(e => e.ProductEffectiveDateUtc).HasColumnType("datetime");

            entity.Property(e => e.TagNumber)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.UniqueId).HasDefaultValueSql("(newid())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Pet)
                .WithOne(p => p.PetPolicy)
                .HasForeignKey<TruDatDboPetPolicy>(d => d.PetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pet_petpolicy");

//            entity.HasOne(d => d.PolicyAge)
//                .WithMany(p => p.PetPolicies)
//                .HasForeignKey(d => d.PolicyAgeId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("fk_age_petpolicy");

            entity.HasOne(d => d.Policy)
                .WithMany(p => p.PetPolicies)
                .HasForeignKey(d => d.PolicyId)
                .HasConstraintName("fk_policy_petpolicy");
        });

        modelBuilder.Entity<TruDatDboPetPolicyAction>(entity =>
        {
            entity.ToTable("PetPolicyAction");

            entity.HasIndex(e => e.Inserted, "ix_petpolicyaction_ins");

            entity.HasIndex(e => new { e.PetPolicyId, e.StatusId }, "ix_petpolicyaction_pod_sid_inc");

            entity.HasIndex(e => e.StatusId, "ix_petpolicyaction_sid");

            entity.HasIndex(e => new { e.StatusId, e.Inserted, e.PetPolicyId }, "ix_petpolicyaction_sid_ins");

            entity.HasIndex(e => new { e.StatusId, e.PetPolicyId, e.Id }, "ix_petpolicyaction_sid_pod_id");

            entity.HasIndex(e => e.UserId, "ix_petpolicyaction_uid");

            entity.HasIndex(e => new { e.PetPolicyId, e.StatusId, e.Id }, "ix_petpolicyatcion_pod_sid_id");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Note).IsUnicode(false);

            entity.HasOne(d => d.PetPolicy)
                .WithMany(p => p.PetPolicyActions)
                .HasForeignKey(d => d.PetPolicyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_petpolicy_petpolicyaction");

            entity.HasOne(d => d.Status)
                .WithMany(p => p.PetPolicyActions)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_status_petpolicyaction");

            entity.HasOne(d => d.User)
                .WithMany(p => p.PetPolicyActions)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_users_petpolicyaction");
        });

        modelBuilder.Entity<TruDatDboPetPolicyActionHistory>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PetPolicyActionHistory");

            entity.Property(e => e.Action)
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.ActionDate).HasColumnType("datetime");

            entity.Property(e => e.Note).IsUnicode(false);

            entity.Property(e => e.UserName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboPetPolicyActionInitalEnrollment>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PetPolicyActionInitalEnrollment");

            entity.Property(e => e.Inserted).HasColumnType("datetime");
        });

        modelBuilder.Entity<TruDatDboPetPolicyActionLast>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PetPolicyActionLast");
        });

        modelBuilder.Entity<TruDatDboPetPolicyActionLastEnrollment>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PetPolicyActionLastEnrollment");

            entity.Property(e => e.PetPolicyId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TruDatDboPetPolicyActionLastTag>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PetPolicyActionLastTag");
        });

        modelBuilder.Entity<TruDatDboPetPolicyActionWithPetId>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PetPolicyActionWithPetId");

            entity.Property(e => e.Inserted).HasColumnType("datetime");

            entity.Property(e => e.Note).IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboPetPolicyAssociation>(entity =>
        {
            entity.ToTable("PetPolicyAssociation");

            entity.HasIndex(e => new { e.EntityTypeId, e.EntityId }, "ix_petpolicyassociation_etid_eid");

            entity.HasIndex(e => new { e.PetPolicyId, e.EntityTypeId }, "uk_PetPolicyAssociation_petpolicyid_entitytypeid")
                .IsUnique();

            entity.HasIndex(e => new { e.PetPolicyId, e.EntityTypeId, e.EntityId }, "uk_petpolicyassociation_pid_etid_eid")
                .IsUnique();

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.ChangeUser)
                .WithMany(p => p.PetPolicyAssociations)
                .HasForeignKey(d => d.ChangeUserId)
                .HasConstraintName("fk_petpolicyassociation_users");

            entity.HasOne(d => d.EntityType)
                .WithMany(p => p.PetPolicyAssociations)
                .HasForeignKey(d => d.EntityTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_entity_petpolicyassociation");

            entity.HasOne(d => d.PetPolicy)
                .WithMany(p => p.PetPolicyAssociations)
                .HasForeignKey(d => d.PetPolicyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_petpolicy_petpolicyassociation");
        });

        modelBuilder.Entity<TruDatDboPetPolicyAttribute>(entity =>
        {
            entity.ToTable("PetPolicyAttribute");

            entity.HasIndex(e => new { e.Attribute, e.Value }, "ix_petpolicyattribute_atr_val");

            entity.HasIndex(e => new { e.PetPolicyId, e.Attribute }, "uk_petpolicyAttribute_petpolicyid_attribute")
                .IsUnique();

            entity.Property(e => e.Attribute)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Value)
                .IsRequired()
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.PetPolicy)
                .WithMany(p => p.PetPolicyAttributes)
                .HasForeignKey(d => d.PetPolicyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_petpolicy_petpolicyattribute");
        });

        modelBuilder.Entity<TruDatDboPetPolicyCancelInfo>(entity =>
        {
            entity.HasKey(e => e.PetPolicyId)
                .HasName("pk_petpolicycancelinfo_pid");

            entity.ToTable("PetPolicyCancelInfo");

            entity.HasIndex(e => e.Cancelled, "ix_petpolicycancelinfo_can");

            entity.HasIndex(e => e.CancelId, "ix_petpolicycancelinfo_cr");

            entity.Property(e => e.PetPolicyId).ValueGeneratedNever();

            entity.Property(e => e.CancelDate).HasColumnType("datetime");

            entity.Property(e => e.CancelNote)
                .HasMaxLength(400)
                .IsUnicode(false);

            entity.HasOne(d => d.PetPolicy)
                .WithOne(p => p.PetPolicyCancelInfo)
                .HasForeignKey<TruDatDboPetPolicyCancelInfo>(d => d.PetPolicyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_petpolicy_petpolicycancelinfo");
        });

        modelBuilder.Entity<TruDatDboPetPolicyCancelInfoView>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PetPolicyCancelInfoView");

            entity.Property(e => e.CancelDate).HasColumnType("datetime");

            entity.Property(e => e.CancelNote)
                .HasMaxLength(400)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboPetPolicyClinic>(entity =>
        {
            entity.HasKey(e => e.PetPolicyId)
                .HasName("pk_petpolicyclinic_pod");

            entity.ToTable("PetPolicyClinic");

            entity.HasIndex(e => new { e.ClinicId, e.PetPolicyId }, "ix_petpolicyclinic_cid_pod");

            entity.Property(e => e.PetPolicyId).ValueGeneratedNever();

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Clinic)
                .WithMany(p => p.PetPolicyClinics)
                .HasForeignKey(d => d.ClinicId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_clinic_petpolicyclinic");

            entity.HasOne(d => d.PetPolicy)
                .WithOne(p => p.PetPolicyClinic)
                .HasForeignKey<TruDatDboPetPolicyClinic>(d => d.PetPolicyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_petpolicy_petpolicyclinic");
        });

        modelBuilder.Entity<TruDatDboPetPolicyCost>(entity =>
        {
            entity.ToTable("PetPolicyCost");

            entity.HasIndex(e => new { e.PetPolicyId, e.CostId }, "UQ__PetPolic__10B363023B8645C5")
                .IsUnique();

            entity.HasIndex(e => e.CostId, "ix_ppc_cid_id_ppid_0915");

            entity.HasIndex(e => new { e.PetPolicyId, e.CostId }, "uk_petpolicycost_petpolicyid_costid")
                .IsUnique();

            entity.Property(e => e.Cost).HasColumnType("smallmoney");

            entity.Property(e => e.Effective).HasColumnType("datetime");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.CostNavigation)
                .WithMany(p => p.PetPolicyCosts)
                .HasForeignKey(d => d.CostId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_cost_petpolicycost");

            entity.HasOne(d => d.PetPolicy)
                .WithMany(p => p.PetPolicyCosts)
                .HasForeignKey(d => d.PetPolicyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_petpolicy_petpolicycost");
        });

        modelBuilder.Entity<TruDatDboPetPolicyCostSaveAudit>(entity =>
        {
            entity.ToTable("PetPolicyCostSaveAudit");

            entity.Property(e => e.AdditionalInformation)
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.Property(e => e.Cost).HasColumnType("smallmoney");

            entity.Property(e => e.Effective).HasColumnType("date");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Note).IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TruDatDboPetPolicyLastRateAdjustment>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PetPolicyLastRateAdjustment");

            entity.Property(e => e.LastAdjustmentDate).HasColumnType("date");
        });

        modelBuilder.Entity<TruDatDboPetPolicyPartner>(entity =>
        {
            entity.HasKey(e => e.PetPolicyId)
                .HasName("pk_petpolicypartner_pod");

            entity.ToTable("PetPolicyPartner");

            entity.HasIndex(e => new { e.PartnerId, e.PetPolicyId }, "ix_petpolicypartner_pid_pod");

            entity.Property(e => e.PetPolicyId).ValueGeneratedNever();

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.ChangeUser)
                .WithMany(p => p.PetPolicyPartners)
                .HasForeignKey(d => d.ChangeUserId)
                .HasConstraintName("fk_petpolicypartner_users");

            entity.HasOne(d => d.Partner)
                .WithMany(p => p.PetPolicyPartners)
                .HasForeignKey(d => d.PartnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_partner_petpolicypartner");

            entity.HasOne(d => d.PetPolicy)
                .WithOne(p => p.PetPolicyPartner)
                .HasForeignKey<TruDatDboPetPolicyPartner>(d => d.PetPolicyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_petpolicy_petpolicypartner");
        });

        modelBuilder.Entity<TruDatDboPetPolicyRateAdjustment>(entity =>
        {
            entity.ToTable("PetPolicyRateAdjustment");

            entity.HasIndex(e => e.CaseCategoryId, "ix_petpolicyrateadjustment_case");

            entity.HasIndex(e => new { e.ChangeUserId, e.Active, e.PolicyDocumentStatus, e.Inserted }, "ix_petpolicyrateadjustment_chnguser_actv_pdstats_ins");

            entity.HasIndex(e => new { e.Complete, e.Active }, "ix_petpolicyrateadjustment_cmplt_act");

            entity.HasIndex(e => e.Complete, "ix_petpolicyrateadjustment_com");

            entity.HasIndex(e => new { e.EffectiveDate, e.Complete }, "ix_petpolicyrateadjustment_ed_com");

            entity.HasIndex(e => e.EffectiveDate, "ix_petpolicyrateadjustment_ef");

            entity.HasIndex(e => e.RateGuid, "ix_petpolicyrateadjustment_guid");

            entity.HasIndex(e => new { e.PetPolicyId, e.EffectiveDate }, "ix_petpolicyrateadjustment_pid_eff");

            entity.HasIndex(e => new { e.PetPolicyId, e.CaseCategoryId, e.Active }, "uix_petpolicyrateadjustment_pid_cid_act")
                .IsUnique()
                .HasFilter("([Active]=(1))");

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.EffectiveDate).HasColumnType("date");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.RateGuid).HasDefaultValueSql("(newid())");

            entity.Property(e => e.UnCappedPremium).HasColumnType("smallmoney");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.CaseCategory)
                .WithMany(p => p.PetPolicyRateAdjustments)
                .HasForeignKey(d => d.CaseCategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_entitytree_petpolicyrateadjustment");

            entity.HasOne(d => d.PetPolicy)
                .WithMany(p => p.PetPolicyRateAdjustments)
                .HasForeignKey(d => d.PetPolicyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_petpolicy_petpolicyrateadjustment");
        });

        modelBuilder.Entity<TruDatDboPetPolicyRateCommunication>(entity =>
        {
            entity.ToTable("PetPolicyRateCommunication");

            entity.HasIndex(e => e.FactorId, "ix_petpolicyratecommunication_fid");

            entity.HasIndex(e => new { e.RateAdjustmentId, e.FactorId }, "ix_petpolicyratecommunication_ra_fi");

            entity.HasIndex(e => e.RateAdjustmentId, "ix_petpolicyratecommunication_raid");

            entity.HasIndex(e => new { e.RateAdjustmentId, e.FactorId }, "uk_petpolicyratecommunication_ra_rp")
                .IsUnique();

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.PreChangeValue)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.RateAdjustment)
                .WithMany(p => p.PetPolicyRateCommunications)
                .HasForeignKey(d => d.RateAdjustmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_petpolicyrateadjustment_petpolicyratecommunication");
        });

        modelBuilder.Entity<TruDatDboPetPolicyRateFactorEffective>(entity =>
        {
            entity.ToTable("PetPolicyRateFactorEffective");

            entity.HasIndex(e => new { e.PetPolicyId, e.EffectiveFrom, e.EffectiveTo }, "uk_petpolicyratefactoreffective_ppid_efffrom_effto")
                .IsUnique();

            entity.Property(e => e.CampaignCode)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Deductible).HasColumnType("smallmoney");

            entity.Property(e => e.EffectiveFrom).HasColumnType("date");

            entity.Property(e => e.EffectiveTo).HasColumnType("date");

            entity.Property(e => e.Inerted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Premium).HasColumnType("smallmoney");

            entity.Property(e => e.SelectedPolicyOptions)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Zipcode)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.Breed)
                .WithMany(p => p.PetPolicyRateFactorEffectives)
                .HasForeignKey(d => d.BreedId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_petpolicyratefactoreffective_breed");

            entity.HasOne(d => d.ChangeUser)
                .WithMany(p => p.PetPolicyRateFactorEffectives)
                .HasForeignKey(d => d.ChangeUserId)
                .HasConstraintName("fk_petpolicyratefactoreffective_users");

            entity.HasOne(d => d.Country)
                .WithMany(p => p.PetPolicyRateFactorEffectives)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_petpolicyratefactoreffective_country");

            entity.HasOne(d => d.Owner)
                .WithMany(p => p.PetPolicyRateFactorEffectives)
                .HasForeignKey(d => d.OwnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_petpolicyratefactoreffective_owner");

            entity.HasOne(d => d.PetFood)
                .WithMany(p => p.PetPolicyRateFactorEffectives)
                .HasForeignKey(d => d.PetFoodId)
                .HasConstraintName("fk_petpolicyratefactoreffective_petfood");

            entity.HasOne(d => d.PetPolicy)
                .WithMany(p => p.PetPolicyRateFactorEffectives)
                .HasForeignKey(d => d.PetPolicyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_petpolicyratefactoreffective_petpolicy");

//            entity.HasOne(d => d.PolicyAge)
//                .WithMany(p => p.PetPolicyRateFactorEffectives)
//                .HasForeignKey(d => d.PolicyAgeId)
//                .OnDelete(DeleteBehavior.ClientSetNull)
//                .HasConstraintName("fk_petpolicyratefactoreffective_age");

            entity.HasOne(d => d.Policy)
                .WithMany(p => p.PetPolicyRateFactorEffectives)
                .HasForeignKey(d => d.PolicyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_petpolicyratefactoreffective_policy");

            entity.HasOne(d => d.Specie)
                .WithMany(p => p.PetPolicyRateFactorEffectives)
                .HasForeignKey(d => d.SpecieId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_petpolicyratefactoreffective_animal");

            entity.HasOne(d => d.WorkingPet)
                .WithMany(p => p.PetPolicyRateFactorEffectives)
                .HasForeignKey(d => d.WorkingPetId)
                .HasConstraintName("fk_petpolicyratefactoreffective_workingpet");
        });

        modelBuilder.Entity<TruDatDboPetPolicyRatePendingChange>(entity =>
        {
            entity.ToTable("PetPolicyRatePendingChange");

            entity.HasIndex(e => new { e.PetPolicyId, e.FactorId, e.EffectiveDate }, "uk_petpolicyratependingchange_pid_fid")
                .IsUnique();

            entity.Property(e => e.EffectiveDate).HasColumnType("date");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.PendingValue)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.PetPolicy)
                .WithMany(p => p.PetPolicyRatePendingChanges)
                .HasForeignKey(d => d.PetPolicyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_petpolicy_petpolicyratependingchange");
        });

        modelBuilder.Entity<TruDatDboPetPolicyReferral>(entity =>
        {
            entity.HasKey(e => e.PetPolicyId)
                .HasName("pk_petpolicyreferral_oid");

            entity.ToTable("PetPolicyReferral");

            entity.HasIndex(e => new { e.ReferralId, e.PetPolicyId }, "ix_petpolicyreferral_rid_oid");

            entity.HasIndex(e => e.Id, "uk_petpolicyreferral_id")
                .IsUnique();

            entity.Property(e => e.PetPolicyId).ValueGeneratedNever();

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.ReferralExplain)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.PetPolicy)
                .WithOne(p => p.PetPolicyReferral)
                .HasForeignKey<TruDatDboPetPolicyReferral>(d => d.PetPolicyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_petpolicy_petpolicyreferral");

            entity.HasOne(d => d.Referral)
                .WithMany(p => p.PetPolicyReferrals)
                .HasForeignKey(d => d.ReferralId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_referral_petpolicyreferral");
        });

        modelBuilder.Entity<TruDatDboPetPolicyTagNumber>(entity =>
        {
            entity.ToTable("PetPolicyTagNumber");

            entity.HasIndex(e => e.PetPolicyId, "ix_petpolicytagnumber_petpolicyid");

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.TagNumber)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.PetPolicy)
                .WithMany(p => p.PetPolicyTagNumbers)
                .HasForeignKey(d => d.PetPolicyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_petpolicy_petpolicytagnumber");
        });

        modelBuilder.Entity<TruDatDboPetPolicyText>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PetPolicyText");

            entity.Property(e => e.AnimalType)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BreedName)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.DateOfBirth).HasColumnType("smalldatetime");

            entity.Property(e => e.Gender)
                .IsRequired()
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength(true);

            entity.Property(e => e.Inserted).HasColumnType("datetime");

            entity.Property(e => e.PetName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PetPolicyNumber)
                .IsRequired()
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.PolicyDate).HasColumnType("datetime");

            entity.Property(e => e.PolicyName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PolicyPaidThru).HasColumnType("datetime");

            entity.Property(e => e.SalesForceId)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.TagNumber)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Updated).HasColumnType("datetime");
        });

        modelBuilder.Entity<TruDatDboPetPolicyVersion>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PetPolicyVersion");

            entity.Property(e => e.PolicyVersionName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboPetPolicyVoucher>(entity =>
        {
            entity.HasKey(e => e.PetPolicyId)
                .HasName("pk_petpolicyvoucher_pod_vid");

            entity.ToTable("PetPolicyVoucher");

            entity.HasIndex(e => new { e.VoucherId, e.PetPolicyId }, "ix_petpolicyvoucher_vid_pod")
                .HasFillFactor((byte)70);

            entity.Property(e => e.PetPolicyId).ValueGeneratedNever();

            entity.Property(e => e.DateReminderSent).HasColumnType("datetime");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.ReferenceNumber)
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.PetPolicy)
                .WithOne(p => p.PetPolicyVoucher)
                .HasForeignKey<TruDatDboPetPolicyVoucher>(d => d.PetPolicyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_petpolicy_petpolicyvoucher");
        });

        modelBuilder.Entity<TruDatDboPetPolicyWebPartner>(entity =>
        {
            entity.HasKey(e => e.PetPolicyId)
                .HasName("pk_petpolicywebpartner_oid");

            entity.ToTable("PetPolicyWebPartner");

            entity.HasIndex(e => new { e.WebPartnerId, e.PetPolicyId }, "ix_petpolicywebpartner_wid_oid");

            entity.Property(e => e.PetPolicyId).ValueGeneratedNever();

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.PetPolicy)
                .WithOne(p => p.PetPolicyWebPartner)
                .HasForeignKey<TruDatDboPetPolicyWebPartner>(d => d.PetPolicyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_petpolicy_petpolicywebpartner");
        });

        modelBuilder.Entity<TruDatDboPetReferral>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PetReferral");

            entity.Property(e => e.ReferralExplain)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.ReferralName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboPetWorkingPet>(entity =>
        {
            entity.ToTable("PetWorkingPet");

            entity.HasIndex(e => new { e.PetId, e.WorkingPetId }, "ix_petworkingpet_wpid");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.WorkingPet)
                .WithMany(p => p.PetWorkingPets)
                .HasForeignKey(d => d.WorkingPetId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_workingpet_petworkingpet");
        });

        modelBuilder.Entity<TruDatDboPirlead>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("PIRLead");

            entity.HasIndex(e => e.F1, "uk_pirlead")
                .IsUnique();

            entity.Property(e => e.F1).HasMaxLength(255);
        });

        modelBuilder.Entity<TruDatDboPolicy>(entity =>
        {
            entity.ToTable("Policy");

            entity.HasIndex(e => e.Name, "uk_policy_nme")
                .IsUnique();

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.CoinsurancePercentage).HasColumnType("numeric(6, 4)");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.MaxDeductible).HasColumnType("smallmoney");

            entity.Property(e => e.MaximumLifetimeBenefitsPayment).HasColumnType("smallmoney");

            entity.Property(e => e.MinDeductible).HasColumnType("smallmoney");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TruDatDboPolicy2014BreedFactor>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.BreedName)
                .HasMaxLength(256)
                .IsUnicode(false);

            entity.Property(e => e.FactorNoHd).HasColumnName("FactorNoHD");
        });

        modelBuilder.Entity<TruDatDboPolicy2014GeoFactor>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Zipcode)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboPolicyAttribute>(entity =>
        {
            entity.HasKey(e => new { e.PolicyId, e.Attribute })
                .HasName("pk_policyattribute_pid_atr");

            entity.ToTable("PolicyAttribute");

            entity.HasIndex(e => e.Id, "uk_policyattribute_id")
                .IsUnique();

            entity.Property(e => e.Attribute)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Value)
                .IsRequired()
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.Policy)
                .WithMany(p => p.PolicyAttributes)
                .HasForeignKey(d => d.PolicyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_policy_policyattribute");
        });

        modelBuilder.Entity<TruDatDboPolicyDeclarationPage>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("PolicyDeclarationPage");

            entity.Property(e => e.DocumentId)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.FileName)
                .IsRequired()
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.Inserted).HasColumnType("datetime");
        });

        modelBuilder.Entity<TruDatDboPolicyDocType>(entity =>
        {
            entity.ToTable("PolicyDocType");

            entity.HasIndex(e => e.Name, "uk_policydoctype_nme")
                .IsUnique();

            entity.Property(e => e.DisplayName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboPolicyNumberBatch>(entity =>
        {
            entity.ToTable("PolicyNumberBatch");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TruDatDboPolicyOption>(entity =>
        {
            entity.ToTable("PolicyOption");

            entity.HasIndex(e => new { e.PolicyId, e.PolicyOptionId }, "ix_policyoption_pid_poid");

            entity.HasIndex(e => new { e.PolicyId, e.PolicyOptionId }, "uk_policyoption_pid_oid")
                .IsUnique();

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Policy)
                .WithMany(p => p.PolicyOptions)
                .HasForeignKey(d => d.PolicyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_policy_policyoption");

            entity.HasOne(d => d.PolicyOptionNavigation)
                .WithMany(p => p.PolicyOptions)
                .HasForeignKey(d => d.PolicyOptionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_policyoptiontype_policyoption");
        });

        modelBuilder.Entity<TruDatDboPolicyOptionRequiredDoc>(entity =>
        {
            entity.ToTable("PolicyOptionRequiredDoc");

            entity.HasIndex(e => new { e.PolicyOptionTypeId, e.PolicyDocTypeId }, "uk_policyoptionrequireddoc_poid_pdid")
                .IsUnique();

            entity.HasOne(d => d.PolicyDocType)
                .WithMany(p => p.PolicyOptionRequiredDocs)
                .HasForeignKey(d => d.PolicyDocTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_policydoctype_policyoptionrequireddoc");

            entity.HasOne(d => d.PolicyOptionType)
                .WithMany(p => p.PolicyOptionRequiredDocs)
                .HasForeignKey(d => d.PolicyOptionTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_policyoption_policyoptionrequireddoc");
        });

        modelBuilder.Entity<TruDatDboPolicyOptionState>(entity =>
        {
            entity.ToTable("PolicyOptionState");

            entity.HasIndex(e => new { e.StateId, e.PolicyOptionId }, "ix_policyoptionstate_sid_oid");

            entity.HasIndex(e => new { e.PolicyOptionId, e.StateId }, "uk_policyoptionstate_oid_sid")
                .IsUnique();

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.PolicyOption)
                .WithMany(p => p.PolicyOptionStates)
                .HasForeignKey(d => d.PolicyOptionId)
                .HasConstraintName("fk_policyoptiontype_policyoptionstate");

            entity.HasOne(d => d.State)
                .WithMany(p => p.PolicyOptionStates)
                .HasForeignKey(d => d.StateId)
                .HasConstraintName("fk_state_policyoptionstate");
        });

        modelBuilder.Entity<TruDatDboPolicyOptionType>(entity =>
        {
            entity.ToTable("PolicyOptionType");

            entity.HasIndex(e => e.CostId, "ix_policyoptiontype_costid");

            entity.HasIndex(e => e.RateId, "ix_policyoptiontype_rid");

            entity.HasIndex(e => e.Name, "uk_policyoption_nme")
                .IsUnique();

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.Description).IsUnicode(false);

            entity.Property(e => e.DisplayName).IsUnicode(false);

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PolicyDocumentHref)
                .HasMaxLength(1024)
                .IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Cost)
                .WithMany(p => p.PolicyOptionTypes)
                .HasForeignKey(d => d.CostId)
                .HasConstraintName("fk_cost_policyoptiontype");
        });

        modelBuilder.Entity<TruDatDboPolicyRequiredDoc>(entity =>
        {
            entity.ToTable("PolicyRequiredDoc");

            entity.HasIndex(e => new { e.PolicyId, e.PolicyDocTypeId }, "uk_policyrequireddoc_poid_pdid")
                .IsUnique();

            entity.HasOne(d => d.PolicyDocType)
                .WithMany(p => p.PolicyRequiredDocs)
                .HasForeignKey(d => d.PolicyDocTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_policydoctype_policyrequireddoc");

            entity.HasOne(d => d.Policy)
                .WithMany(p => p.PolicyRequiredDocs)
                .HasForeignKey(d => d.PolicyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_policy_policyrequireddoc");
        });

        modelBuilder.Entity<TruDatDboPolicyState>(entity =>
        {
            entity.ToTable("PolicyState");

            entity.HasIndex(e => new { e.StateId, e.PolicyId }, "NEWID")
                .IsUnique();

            entity.Property(e => e.DateEffective).HasColumnType("datetime");

            entity.Property(e => e.DateEffectiveEnd).HasColumnType("datetime");

            entity.HasOne(d => d.Policy)
                .WithMany(p => p.PolicyStates)
                .HasForeignKey(d => d.PolicyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_policy_PolicyState");

            entity.HasOne(d => d.State)
                .WithMany(p => p.PolicyStates)
                .HasForeignKey(d => d.StateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_state_PolicyState");
        });

        modelBuilder.Entity<TruDatDboPolicyVersion>(entity =>
        {
            entity.ToTable("PolicyVersion");

            entity.HasIndex(e => e.Name, "uk_policyVersion_nme")
                .IsUnique();

            entity.Property(e => e.DateEffective).HasColumnType("datetime");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PolicyPath)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TruDatDboPreferredPartnership>(entity =>
        {
            entity.ToTable("PreferredPartnership");

            entity.Property(e => e.AddressLine).HasMaxLength(200);

            entity.Property(e => e.City).HasMaxLength(100);

            entity.Property(e => e.Fax)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.GroupNo)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.KeyContactName).HasMaxLength(100);

            entity.Property(e => e.ManagerEmail)
                .HasMaxLength(256)
                .IsUnicode(false);

            entity.Property(e => e.ManagerName).HasMaxLength(100);

            entity.Property(e => e.PartnerEmail)
                .HasMaxLength(256)
                .IsUnicode(false);

            entity.Property(e => e.PartnerName).HasMaxLength(100);

            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PracticeName).HasMaxLength(150);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.ZipCode)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.Group)
                .WithMany(p => p.PreferredPartnerships)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_partnershipgroup_preferredpartnership");

            entity.HasOne(d => d.State)
                .WithMany(p => p.PreferredPartnerships)
                .HasForeignKey(d => d.StateId)
                .HasConstraintName("fk_state_preferredpartnership");
        });

        modelBuilder.Entity<TruDatDboPriceIncrease>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("PriceIncrease");

            entity.HasIndex(e => e.PetPolicyId, "ix_priceincrease_pid");

            entity.Property(e => e.Differ).HasColumnType("smallmoney");

            entity.Property(e => e.ExistingPremium).HasColumnType("smallmoney");

            entity.Property(e => e.NewPremium).HasColumnType("smallmoney");
        });

        modelBuilder.Entity<TruDatDboRateAdjRedoPuertoRico>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("RateAdjRedoPuertoRico");

            entity.Property(e => e.CurrentPremium).HasColumnType("smallmoney");

            entity.Property(e => e.DateAsOf).HasColumnType("datetime");

            entity.Property(e => e.Effectivedate)
                .HasColumnType("datetime")
                .HasColumnName("effectivedate");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.Property(e => e.NewPendingPremium).HasColumnType("smallmoney");

            entity.Property(e => e.Neweffectivedate)
                .HasColumnType("datetime")
                .HasColumnName("neweffectivedate");

            entity.Property(e => e.Note)
                .HasMaxLength(512)
                .IsUnicode(false);

            entity.Property(e => e.PendingPremium).HasColumnType("smallmoney");

            entity.Property(e => e.Petname)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("petname");
        });

        modelBuilder.Entity<TruDatDboRateAdjustmentCorrection>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("RateAdjustmentCorrection");

            entity.Property(e => e.CorrectPremium).HasColumnType("smallmoney");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.Property(e => e.Note)
                .HasMaxLength(512)
                .IsUnicode(false);

            entity.Property(e => e.RefundAmount).HasColumnType("smallmoney");

            entity.Property(e => e.UncapppedPremium).HasColumnType("smallmoney");
        });

        modelBuilder.Entity<TruDatDboRateAdjustmentCorrectionUnderBilled>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("RateAdjustmentCorrectionUnderBilled");

            entity.Property(e => e.AddBen).HasColumnType("smallmoney");

            entity.Property(e => e.CorrectPremium).HasColumnType("smallmoney");

            entity.Property(e => e.CurrentPremium).HasColumnType("smallmoney");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.Property(e => e.Loss).HasColumnType("smallmoney");

            entity.Property(e => e.LossAmount).HasColumnType("smallmoney");

            entity.Property(e => e.Note)
                .HasMaxLength(512)
                .IsUnicode(false);

            entity.Property(e => e.OptBenCost).HasColumnType("smallmoney");

            entity.Property(e => e.RatedPremium)
                .HasColumnType("smallmoney")
                .HasColumnName("ratedPremium");

            entity.Property(e => e.RiderA).HasColumnType("smallmoney");

            entity.Property(e => e.RiderB).HasColumnType("smallmoney");
        });

        modelBuilder.Entity<TruDatDboRateChangeFix>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("RateChangeFix");

            entity.Property(e => e.CappedCorrectPremium).HasColumnName("Capped CORRECT premium");

            entity.Property(e => e.CorrectPremium).HasColumnName("CORRECT premium");

            entity.Property(e => e.DeductibleScheduled)
                .HasMaxLength(255)
                .HasColumnName("Deductible Scheduled");

            entity.Property(e => e.EffectiveChangeDate)
                .HasColumnType("datetime")
                .HasColumnName("Effective Change Date");

            entity.Property(e => e.OptionsNoticeDate)
                .HasMaxLength(255)
                .HasColumnName("Options @ Notice Date");

            entity.Property(e => e.PolicyNumber)
                .HasMaxLength(255)
                .HasColumnName("Policy Number");

            entity.Property(e => e.PremiumNoticeDate).HasColumnName("Premium @Notice Date");

            entity.Property(e => e.PremiumTheyThinkIncludingADeductibleChangeIfTheySchedu).HasColumnName("Premium they think, including a deductible change if they schedu");
        });

        modelBuilder.Entity<TruDatDboRateNoticeDailyLimit>(entity =>
        {
            entity.HasKey(e => e.DoW)
                .HasName("pk_ratenoticedailylimit_dow");

            entity.ToTable("RateNoticeDailyLimit");

            entity.Property(e => e.DoW).ValueGeneratedNever();
        });

        modelBuilder.Entity<TruDatDboReciprocalLink>(entity =>
        {
            entity.HasIndex(e => e.Url, "LINKNAME")
                .IsUnique();

            entity.Property(e => e.ContactEmail)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.ContactName)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Description)
                .HasMaxLength(512)
                .IsUnicode(false);

            entity.Property(e => e.HostUrl)
                .HasMaxLength(512)
                .IsUnicode(false);

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Url)
                .IsRequired()
                .HasMaxLength(512)
                .IsUnicode(false);

            entity.Property(e => e.VerifiedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TruDatDboReferral>(entity =>
        {
            entity.ToTable("Referral");

            entity.HasIndex(e => new { e.Sort, e.Name }, "ix_referral_srt_nme");

            entity.HasIndex(e => e.UniqueId, "uc_referral_uid")
                .IsUnique();

            entity.HasIndex(e => e.Name, "uk_referral_nme")
                .IsUnique();

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.UniqueId).HasDefaultValueSql("(newid())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TruDatDboReferralMapping>(entity =>
        {
            entity.ToTable("ReferralMapping");

            entity.HasOne(d => d.EntityList)
                .WithMany(p => p.ReferralMappings)
                .HasForeignKey(d => d.EntityListId)
                .HasConstraintName("fk_rm_entitylist");

            entity.HasOne(d => d.Referral)
                .WithMany(p => p.ReferralMappings)
                .HasForeignKey(d => d.ReferralId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_rm_referral");
        });

        modelBuilder.Entity<TruDatDboReminder>(entity =>
        {
            entity.ToTable("Reminder");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TruDatDboReviewPolicy>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("ReviewPolicies");

            entity.Property(e => e.BreedName)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.EmailAddress)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.HomePhone)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OwnerFirstName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.OwnerLastName)
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

            entity.Property(e => e.PolicyDate).HasColumnType("datetime");

            entity.Property(e => e.PolicyNumber)
                .IsRequired()
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboRole>(entity =>
        {
            entity.ToTable("Role");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.RoleName)
                .IsRequired()
                .HasMaxLength(256);

            entity.Property(e => e.Updated)
            .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TruDatDboScore>(entity =>
        {
            entity.ToTable("Score");

            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Name)
                .HasMaxLength(45)
                .IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TruDatDboSecurable>(entity =>
        {
            entity.ToTable("Securable");

            entity.HasIndex(e => new { e.CategoryId, e.Name }, "uk_securable_cid_nme")
                .IsUnique();

            entity.Property(e => e.ApplyAction)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.RevokeAction)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Category)
                .WithMany(p => p.Securables)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_securable_entitycategory");

            entity.HasOne(d => d.ChangeUser)
                .WithMany(p => p.Securables)
                .HasForeignKey(d => d.ChangeUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_securable_users");
        });

        modelBuilder.Entity<TruDatDboSecurableEntityRelation>(entity =>
        {
            entity.ToTable("SecurableEntityRelation");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.ChangeUser)
                .WithMany(p => p.SecurableEntityRelations)
                .HasForeignKey(d => d.ChangeUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_securableentityrelation_users");

            entity.HasOne(d => d.EntityType)
                .WithMany(p => p.SecurableEntityRelations)
                .HasForeignKey(d => d.EntityTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_securableentityrelation_entity");

            entity.HasOne(d => d.Securable)
                .WithMany(p => p.SecurableEntityRelations)
                .HasForeignKey(d => d.SecurableId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_securableentityrelation_securable");
        });

        modelBuilder.Entity<TruDatDboSession>(entity =>
        {
            entity.ToTable("Session");

            entity.HasIndex(e => new { e.ApplicationId, e.UserId }, "ix_session_aid_uid");

            entity.HasIndex(e => e.UniqueId, "uk_session_uid")
                .IsUnique();

            entity.Property(e => e.ActivityDate).HasColumnType("datetime");

            entity.Property(e => e.LoginDate).HasColumnType("datetime");

            entity.Property(e => e.UniqueId)
                .IsRequired()
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.HasOne(d => d.User)
                .WithMany(p => p.Sessions)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_users_session");
        });

        modelBuilder.Entity<TruDatDboSfVetClinicsCount>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("SF_VetClinics_Counts");

            entity.Property(e => e.AccountName)
                .HasMaxLength(255)
                .HasColumnName("Account Name");

            entity.Property(e => e.ClinicActive)
                .HasMaxLength(255)
                .HasColumnName("Clinic Active");

            entity.Property(e => e.ClinicId)
                .HasMaxLength(255)
                .HasColumnName("Clinic ID");

            entity.Property(e => e.Phone).HasMaxLength(255);
        });

        modelBuilder.Entity<TruDatDboSfclinicBackup>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("SFClinicBackup");

            entity.Property(e => e.ClinicActiveC).HasColumnName("CLINIC_ACTIVE__C");

            entity.Property(e => e.Id)
                .HasMaxLength(255)
                .HasColumnName("ID");

            entity.Property(e => e.Ownerid)
                .HasMaxLength(255)
                .HasColumnName("OWNERID");

            entity.Property(e => e.Recordtypeid)
                .HasMaxLength(255)
                .HasColumnName("RECORDTYPEID");
        });

        modelBuilder.Entity<TruDatDboShadowAnimalImage>(entity =>
        {
            entity.ToTable("ShadowAnimalImage");

            entity.Property(e => e.Description)
                .HasMaxLength(512)
                .IsUnicode(false);

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.IsDefault).HasColumnName("isDefault");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Animal)
                .WithMany(p => p.ShadowAnimalImages)
                .HasForeignKey(d => d.AnimalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_shadowanimalimage_animal");

            entity.HasOne(d => d.ChangeUser)
                .WithMany(p => p.ShadowAnimalImages)
                .HasForeignKey(d => d.ChangeUserId)
                .HasConstraintName("fk_shadowanimalimage_users");
        });

        modelBuilder.Entity<TruDatDboState>(entity =>
        {
            entity.ToTable("State");

            entity.HasIndex(e => e.UniqueId, "uk_dbostate_uid")
                .IsUnique();

            entity.HasIndex(e => new { e.CountryId, e.Name }, "uk_state_cnt_name")
                .IsUnique();

            entity.HasIndex(e => new { e.CountryId, e.StateCode }, "uk_state_cnt_sc")
                .IsUnique();

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.AllowTrial)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PriceAdjustmentNoticeDays).HasDefaultValueSql("((30))");

            entity.Property(e => e.SetupFee).HasColumnType("smallmoney");

            entity.Property(e => e.StateCode)
                .IsRequired()
                .HasMaxLength(3)
                .IsUnicode(false);

            entity.Property(e => e.UniqueId).HasDefaultValueSql("(newid())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.ChangeUser)
                .WithMany(p => p.States)
                .HasForeignKey(d => d.ChangeUserId)
                .HasConstraintName("fk_state_users");

            entity.HasOne(d => d.Country)
                .WithMany(p => p.States)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_country_state");
        });

        modelBuilder.Entity<TruDatDboStateAttribute>(entity =>
        {
            entity.HasKey(e => new { e.StateId, e.Attribute })
                .HasName("pk_stateattribute_sid_atr");

            entity.ToTable("StateAttribute");

            entity.HasIndex(e => e.Id, "uk_stateattribute_id")
                .IsUnique();

            entity.Property(e => e.Attribute)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Value)
                .HasMaxLength(1000)
                .IsUnicode(false);

            entity.HasOne(d => d.State)
                .WithMany(p => p.StateAttributes)
                .HasForeignKey(d => d.StateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_state_stateattribute");
        });

        modelBuilder.Entity<TruDatDboStateCodeNotApproved>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("StateCodeNotApproved");

            entity.HasIndex(e => e.StateId, "uk_statecodenoteapproved_stateid")
                .IsUnique();

            entity.Property(e => e.StateCode)
                .IsRequired()
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength(true);
        });

        modelBuilder.Entity<TruDatDboStatus>(entity =>
        {
            entity.ToTable("Status");

            entity.HasIndex(e => new { e.ParentId, e.Id }, "ix_status_pid_id");

            entity.HasIndex(e => e.UniqueId, "uc_dbostatus_uniqueid")
                .IsUnique();

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.UniqueId).HasDefaultValueSql("(newid())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Parent)
                .WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .HasConstraintName("fk_status_status");
        });

        modelBuilder.Entity<TruDatDboStatusBranchMap>(entity =>
        {
            entity.HasKey(e => new { e.StatusId, e.ChildStatusId })
                .HasName("pk_statusbranchmap_sid_cid");

            entity.ToTable("StatusBranchMap");

            entity.HasIndex(e => new { e.ChildStatusId, e.StatusId }, "ix_statusbranchmap_cid_sid");
        });

        modelBuilder.Entity<TruDatDboStatusGroup>(entity =>
        {
            entity.ToTable("StatusGroup");

            entity.HasOne(d => d.Group)
                .WithMany(p => p.StatusGroupGroups)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StatusGroup_Status2");

            entity.HasOne(d => d.Status)
                .WithMany(p => p.StatusGroupStatuses)
                .HasForeignKey(d => d.StatusId)
                .HasConstraintName("FK_StatusGroup_Status1");
        });

        modelBuilder.Entity<TruDatDboStatusSummary>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("StatusSummary");

            entity.Property(e => e.StatusBreadCrumb)
                .HasMaxLength(2000)
                .IsUnicode(false);

            entity.Property(e => e.StatusId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TruDatDboTask>(entity =>
        {
            entity.Property(e => e.Alerted)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.CancelledDate).HasColumnType("datetime");

            entity.Property(e => e.CompletedDate).HasColumnType("datetime");

            entity.Property(e => e.DateDue).HasColumnType("datetime");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Notes)
                .HasMaxLength(512)
                .IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.CancelledByUser)
                .WithMany(p => p.TaskCancelledByUsers)
                .HasForeignKey(d => d.CancelledByUserId)
                .HasConstraintName("fk_task_cancelledByUserId");

            entity.HasOne(d => d.Type)
                .WithMany(p => p.Tasks)
                .HasForeignKey(d => d.TypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_type_typeid");

            entity.HasOne(d => d.User)
                .WithMany(p => p.TaskUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_task_userid");
        });

        modelBuilder.Entity<TruDatDboTaskEmail>(entity =>
        {
            entity.ToTable("TaskEmail");

            entity.Property(e => e.Bccaddress)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("BCCAddress");

            entity.Property(e => e.Ccaddress)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("CCAddress");

            entity.Property(e => e.EmailMessage)
                .IsRequired()
                .IsUnicode(false);

            entity.Property(e => e.FromAddress)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.FromName)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Subject)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Task)
                .WithMany(p => p.TaskEmails)
                .HasForeignKey(d => d.TaskId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_taskEmail_taskid");
        });

        modelBuilder.Entity<TruDatDboTaskEmailRecipient>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.TaskId, e.EntityTypeId, e.EntityId }, "uk_taskemailrecipients_aid_tid_eid")
                .IsUnique();

            entity.Property(e => e.Error)
                .HasMaxLength(512)
                .IsUnicode(false);

            entity.Property(e => e.Executed).HasColumnType("datetime");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.EntityType)
                .WithMany()
                .HasForeignKey(d => d.EntityTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("df_taskEmailrec_entitytypeid");

            entity.HasOne(d => d.Task)
                .WithMany()
                .HasForeignKey(d => d.TaskId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_taskEmailrec_taskId");
        });

        modelBuilder.Entity<TruDatDboTaskType>(entity =>
        {
            entity.ToTable("TaskType");

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

        modelBuilder.Entity<TruDatDboTemplettersdataCccan>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("templettersdataCCCan");

            entity.Property(e => e.Address).IsUnicode(false);

            entity.Property(e => e.City).IsUnicode(false);

            entity.Property(e => e.Currentdate).IsUnicode(false);

            entity.Property(e => e.FirstName).IsUnicode(false);

            entity.Property(e => e.LastName).IsUnicode(false);

            entity.Property(e => e.PolicyNumber).IsUnicode(false);

            entity.Property(e => e.PostalCode).IsUnicode(false);

            entity.Property(e => e.Province).IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboTemplettersdataCccan20091130to20100127>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("templettersdataCCCan20091130to20100127");

            entity.Property(e => e.Address).IsUnicode(false);

            entity.Property(e => e.City).IsUnicode(false);

            entity.Property(e => e.Currentdate).IsUnicode(false);

            entity.Property(e => e.FirstName).IsUnicode(false);

            entity.Property(e => e.LastName).IsUnicode(false);

            entity.Property(e => e.PolicyNumber).IsUnicode(false);

            entity.Property(e => e.PostalCode).IsUnicode(false);

            entity.Property(e => e.Province).IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboTemplettersdataCccan20100127to20100226>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("templettersdataCCCan20100127to20100226");

            entity.Property(e => e.Address).IsUnicode(false);

            entity.Property(e => e.City).IsUnicode(false);

            entity.Property(e => e.Currentdate).IsUnicode(false);

            entity.Property(e => e.FirstName).IsUnicode(false);

            entity.Property(e => e.LastName).IsUnicode(false);

            entity.Property(e => e.PolicyNumber).IsUnicode(false);

            entity.Property(e => e.PostalCode).IsUnicode(false);

            entity.Property(e => e.Province).IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboTemplettersdataCccan20100127to20100226Letter2>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("templettersdataCCCan20100127to20100226Letter2");

            entity.Property(e => e.Address).IsUnicode(false);

            entity.Property(e => e.City).IsUnicode(false);

            entity.Property(e => e.Currentdate).IsUnicode(false);

            entity.Property(e => e.FirstName).IsUnicode(false);

            entity.Property(e => e.LastName).IsUnicode(false);

            entity.Property(e => e.PolicyNumber).IsUnicode(false);

            entity.Property(e => e.PostalCode).IsUnicode(false);

            entity.Property(e => e.Province).IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboTemplettersdataCccan20100321to20100417Letter1>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("templettersdataCCCan20100321to20100417Letter1");

            entity.Property(e => e.Address).IsUnicode(false);

            entity.Property(e => e.City).IsUnicode(false);

            entity.Property(e => e.Currentdate).IsUnicode(false);

            entity.Property(e => e.FirstName).IsUnicode(false);

            entity.Property(e => e.LastName).IsUnicode(false);

            entity.Property(e => e.PolicyNumber).IsUnicode(false);

            entity.Property(e => e.PostalCode).IsUnicode(false);

            entity.Property(e => e.Province).IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboTemplettersdataCccanCancellationNotice20100301>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("templettersdataCCCanCancellationNotice20100301");

            entity.Property(e => e.Address).IsUnicode(false);

            entity.Property(e => e.City).IsUnicode(false);

            entity.Property(e => e.Currentdate).IsUnicode(false);

            entity.Property(e => e.FirstName).IsUnicode(false);

            entity.Property(e => e.LastName).IsUnicode(false);

            entity.Property(e => e.PolicyNumber).IsUnicode(false);

            entity.Property(e => e.PostalCode).IsUnicode(false);

            entity.Property(e => e.Province).IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboTemplettersdataCccanGrpBletter3>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("templettersdataCCCanGrpBLetter3");

            entity.Property(e => e.Address).IsUnicode(false);

            entity.Property(e => e.City).IsUnicode(false);

            entity.Property(e => e.Currentdate).IsUnicode(false);

            entity.Property(e => e.FirstName).IsUnicode(false);

            entity.Property(e => e.LastName).IsUnicode(false);

            entity.Property(e => e.PolicyNumber).IsUnicode(false);

            entity.Property(e => e.PostalCode).IsUnicode(false);

            entity.Property(e => e.Province).IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboTemplettersdataCccanGrpCletter1>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("templettersdataCCCanGrpCLetter1");

            entity.Property(e => e.Address).IsUnicode(false);

            entity.Property(e => e.City).IsUnicode(false);

            entity.Property(e => e.Currentdate).IsUnicode(false);

            entity.Property(e => e.FirstName).IsUnicode(false);

            entity.Property(e => e.LastName).IsUnicode(false);

            entity.Property(e => e.PolicyNumber).IsUnicode(false);

            entity.Property(e => e.PostalCode).IsUnicode(false);

            entity.Property(e => e.Province).IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboTemplettersdataCccanGrpCletter2>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("templettersdataCCCanGrpCLetter2");

            entity.Property(e => e.Address).IsUnicode(false);

            entity.Property(e => e.City).IsUnicode(false);

            entity.Property(e => e.Currentdate).IsUnicode(false);

            entity.Property(e => e.FirstName).IsUnicode(false);

            entity.Property(e => e.LastName).IsUnicode(false);

            entity.Property(e => e.PolicyNumber).IsUnicode(false);

            entity.Property(e => e.PostalCode).IsUnicode(false);

            entity.Property(e => e.Province).IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboTemplettersdataCccanGrpCletter3>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("templettersdataCCCanGrpCLetter3");

            entity.Property(e => e.Address).IsUnicode(false);

            entity.Property(e => e.City).IsUnicode(false);

            entity.Property(e => e.Currentdate).IsUnicode(false);

            entity.Property(e => e.FirstName).IsUnicode(false);

            entity.Property(e => e.LastName).IsUnicode(false);

            entity.Property(e => e.PolicyNumber).IsUnicode(false);

            entity.Property(e => e.PostalCode).IsUnicode(false);

            entity.Property(e => e.Province).IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboTemplettersdataCcusa>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("templettersdataCCUSA");

            entity.Property(e => e.Address).IsUnicode(false);

            entity.Property(e => e.City).IsUnicode(false);

            entity.Property(e => e.Currentdate).IsUnicode(false);

            entity.Property(e => e.FirstName).IsUnicode(false);

            entity.Property(e => e.LastName).IsUnicode(false);

            entity.Property(e => e.PolicyNumber).IsUnicode(false);

            entity.Property(e => e.PostalCode).IsUnicode(false);

            entity.Property(e => e.Province).IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboTemplettersdataCcusa20091130to20100127>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("templettersdataCCUSA20091130to20100127");

            entity.Property(e => e.Address).IsUnicode(false);

            entity.Property(e => e.City).IsUnicode(false);

            entity.Property(e => e.Currentdate).IsUnicode(false);

            entity.Property(e => e.FirstName).IsUnicode(false);

            entity.Property(e => e.LastName).IsUnicode(false);

            entity.Property(e => e.PolicyNumber).IsUnicode(false);

            entity.Property(e => e.PostalCode).IsUnicode(false);

            entity.Property(e => e.Province).IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboTemplettersdataCcusa20100127to20100226>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("templettersdataCCUSA20100127to20100226");

            entity.Property(e => e.Address).IsUnicode(false);

            entity.Property(e => e.City).IsUnicode(false);

            entity.Property(e => e.Currentdate).IsUnicode(false);

            entity.Property(e => e.FirstName).IsUnicode(false);

            entity.Property(e => e.LastName).IsUnicode(false);

            entity.Property(e => e.PolicyNumber).IsUnicode(false);

            entity.Property(e => e.PostalCode).IsUnicode(false);

            entity.Property(e => e.Province).IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboTemplettersdataCcusa20100127to20100226Letter2>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("templettersdataCCUSA20100127to20100226Letter2");

            entity.Property(e => e.Address).IsUnicode(false);

            entity.Property(e => e.City).IsUnicode(false);

            entity.Property(e => e.Currentdate).IsUnicode(false);

            entity.Property(e => e.FirstName).IsUnicode(false);

            entity.Property(e => e.LastName).IsUnicode(false);

            entity.Property(e => e.PolicyNumber).IsUnicode(false);

            entity.Property(e => e.PostalCode).IsUnicode(false);

            entity.Property(e => e.Province).IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboTemplettersdataCcusa20100321to20100417Letter1>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("templettersdataCCUSA20100321to20100417Letter1");

            entity.Property(e => e.Address).IsUnicode(false);

            entity.Property(e => e.City).IsUnicode(false);

            entity.Property(e => e.Currentdate).IsUnicode(false);

            entity.Property(e => e.FirstName).IsUnicode(false);

            entity.Property(e => e.LastName).IsUnicode(false);

            entity.Property(e => e.PolicyNumber).IsUnicode(false);

            entity.Property(e => e.PostalCode).IsUnicode(false);

            entity.Property(e => e.Province).IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboTemplettersdataCcusacancellationNotice20100301>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("templettersdataCCUSACancellationNotice20100301");

            entity.Property(e => e.Address).IsUnicode(false);

            entity.Property(e => e.City).IsUnicode(false);

            entity.Property(e => e.Currentdate).IsUnicode(false);

            entity.Property(e => e.FirstName).IsUnicode(false);

            entity.Property(e => e.LastName).IsUnicode(false);

            entity.Property(e => e.PolicyNumber).IsUnicode(false);

            entity.Property(e => e.PostalCode).IsUnicode(false);

            entity.Property(e => e.Province).IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboTemplettersdataCcusagrpBletter3>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("templettersdataCCUSAGrpBLetter3");

            entity.Property(e => e.Address).IsUnicode(false);

            entity.Property(e => e.City).IsUnicode(false);

            entity.Property(e => e.Currentdate).IsUnicode(false);

            entity.Property(e => e.FirstName).IsUnicode(false);

            entity.Property(e => e.LastName).IsUnicode(false);

            entity.Property(e => e.PolicyNumber).IsUnicode(false);

            entity.Property(e => e.PostalCode).IsUnicode(false);

            entity.Property(e => e.Province).IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboTemplettersdataCcusagrpCletter1>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("templettersdataCCUSAGrpCLetter1");

            entity.Property(e => e.Address).IsUnicode(false);

            entity.Property(e => e.City).IsUnicode(false);

            entity.Property(e => e.Currentdate).IsUnicode(false);

            entity.Property(e => e.FirstName).IsUnicode(false);

            entity.Property(e => e.LastName).IsUnicode(false);

            entity.Property(e => e.PolicyNumber).IsUnicode(false);

            entity.Property(e => e.PostalCode).IsUnicode(false);

            entity.Property(e => e.Province).IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboTemplettersdataCcusagrpCletter2>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("templettersdataCCUSAGrpCLetter2");

            entity.Property(e => e.Address).IsUnicode(false);

            entity.Property(e => e.City).IsUnicode(false);

            entity.Property(e => e.Currentdate).IsUnicode(false);

            entity.Property(e => e.FirstName).IsUnicode(false);

            entity.Property(e => e.LastName).IsUnicode(false);

            entity.Property(e => e.PolicyNumber).IsUnicode(false);

            entity.Property(e => e.PostalCode).IsUnicode(false);

            entity.Property(e => e.Province).IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboTemplettersdataCcusagrpCletter3>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("templettersdataCCUSAGrpCLetter3");

            entity.Property(e => e.Address).IsUnicode(false);

            entity.Property(e => e.City).IsUnicode(false);

            entity.Property(e => e.Currentdate).IsUnicode(false);

            entity.Property(e => e.FirstName).IsUnicode(false);

            entity.Property(e => e.LastName).IsUnicode(false);

            entity.Property(e => e.PolicyNumber).IsUnicode(false);

            entity.Property(e => e.PostalCode).IsUnicode(false);

            entity.Property(e => e.Province).IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboTemplettersdataHsbc>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("templettersdataHSBC");

            entity.Property(e => e.Address).IsUnicode(false);

            entity.Property(e => e.City).IsUnicode(false);

            entity.Property(e => e.Currentdate).IsUnicode(false);

            entity.Property(e => e.FirstName).IsUnicode(false);

            entity.Property(e => e.LastName).IsUnicode(false);

            entity.Property(e => e.PolicyNumber).IsUnicode(false);

            entity.Property(e => e.PostalCode).IsUnicode(false);

            entity.Property(e => e.Province).IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboTemplettersdataHsbc20091130to20100127>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("templettersdataHSBC20091130to20100127");

            entity.Property(e => e.Address).IsUnicode(false);

            entity.Property(e => e.City).IsUnicode(false);

            entity.Property(e => e.Currentdate).IsUnicode(false);

            entity.Property(e => e.FirstName).IsUnicode(false);

            entity.Property(e => e.LastName).IsUnicode(false);

            entity.Property(e => e.PolicyNumber).IsUnicode(false);

            entity.Property(e => e.PostalCode).IsUnicode(false);

            entity.Property(e => e.Province).IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboTemplettersdataHsbc20100127to20100226>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("templettersdataHSBC20100127to20100226");

            entity.Property(e => e.Address).IsUnicode(false);

            entity.Property(e => e.City).IsUnicode(false);

            entity.Property(e => e.Currentdate).IsUnicode(false);

            entity.Property(e => e.FirstName).IsUnicode(false);

            entity.Property(e => e.LastName).IsUnicode(false);

            entity.Property(e => e.PolicyNumber).IsUnicode(false);

            entity.Property(e => e.PostalCode).IsUnicode(false);

            entity.Property(e => e.Province).IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboTemplettersdataHsbc20100127to20100226Letter2>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("templettersdataHSBC20100127to20100226Letter2");

            entity.Property(e => e.Address).IsUnicode(false);

            entity.Property(e => e.City).IsUnicode(false);

            entity.Property(e => e.Currentdate).IsUnicode(false);

            entity.Property(e => e.FirstName).IsUnicode(false);

            entity.Property(e => e.LastName).IsUnicode(false);

            entity.Property(e => e.PolicyNumber).IsUnicode(false);

            entity.Property(e => e.PostalCode).IsUnicode(false);

            entity.Property(e => e.Province).IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboTemplettersdataHsbc20100310to20100417Letter1>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("templettersdataHSBC20100310to20100417Letter1");

            entity.Property(e => e.Address).IsUnicode(false);

            entity.Property(e => e.City).IsUnicode(false);

            entity.Property(e => e.Currentdate).IsUnicode(false);

            entity.Property(e => e.FirstName).IsUnicode(false);

            entity.Property(e => e.LastName).IsUnicode(false);

            entity.Property(e => e.PolicyNumber).IsUnicode(false);

            entity.Property(e => e.PostalCode).IsUnicode(false);

            entity.Property(e => e.Province).IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboTemplettersdataHsbccancellationNotice20100301>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("templettersdataHSBCCancellationNotice20100301");

            entity.Property(e => e.Address).IsUnicode(false);

            entity.Property(e => e.City).IsUnicode(false);

            entity.Property(e => e.Currentdate).IsUnicode(false);

            entity.Property(e => e.FirstName).IsUnicode(false);

            entity.Property(e => e.LastName).IsUnicode(false);

            entity.Property(e => e.PolicyNumber).IsUnicode(false);

            entity.Property(e => e.PostalCode).IsUnicode(false);

            entity.Property(e => e.Province).IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboTemplettersdataHsbcgrpBletter3>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("templettersdataHSBCGrpBLetter3");

            entity.Property(e => e.Address).IsUnicode(false);

            entity.Property(e => e.City).IsUnicode(false);

            entity.Property(e => e.Currentdate).IsUnicode(false);

            entity.Property(e => e.FirstName).IsUnicode(false);

            entity.Property(e => e.LastName).IsUnicode(false);

            entity.Property(e => e.PolicyNumber).IsUnicode(false);

            entity.Property(e => e.PostalCode).IsUnicode(false);

            entity.Property(e => e.Province).IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboTemplettersdataHsbcgrpCletter1>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("templettersdataHSBCGrpCLetter1");

            entity.Property(e => e.Address).IsUnicode(false);

            entity.Property(e => e.City).IsUnicode(false);

            entity.Property(e => e.Currentdate).IsUnicode(false);

            entity.Property(e => e.FirstName).IsUnicode(false);

            entity.Property(e => e.LastName).IsUnicode(false);

            entity.Property(e => e.PolicyNumber).IsUnicode(false);

            entity.Property(e => e.PostalCode).IsUnicode(false);

            entity.Property(e => e.Province).IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboTemplettersdataHsbcgrpCletter2>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("templettersdataHSBCGrpCLetter2");

            entity.Property(e => e.Address).IsUnicode(false);

            entity.Property(e => e.City).IsUnicode(false);

            entity.Property(e => e.Currentdate).IsUnicode(false);

            entity.Property(e => e.FirstName).IsUnicode(false);

            entity.Property(e => e.LastName).IsUnicode(false);

            entity.Property(e => e.PolicyNumber).IsUnicode(false);

            entity.Property(e => e.PostalCode).IsUnicode(false);

            entity.Property(e => e.Province).IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboTemplettersdataHsbcgrpCletter3>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("templettersdataHSBCGrpCLetter3");

            entity.Property(e => e.Address).IsUnicode(false);

            entity.Property(e => e.City).IsUnicode(false);

            entity.Property(e => e.Currentdate).IsUnicode(false);

            entity.Property(e => e.FirstName).IsUnicode(false);

            entity.Property(e => e.LastName).IsUnicode(false);

            entity.Property(e => e.PolicyNumber).IsUnicode(false);

            entity.Property(e => e.PostalCode).IsUnicode(false);

            entity.Property(e => e.Province).IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboTpemailCategory>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("TPEmailCategory");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.Property(e => e.Name)
                .IsRequired()
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboTpopportunity>(entity =>
        {
            entity.ToTable("TPOpportunities");

            entity.Property(e => e.Description)
                .HasMaxLength(512)
                .IsUnicode(false);

            entity.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Market)
                .IsRequired()
                .HasMaxLength(512)
                .IsUnicode(false);

            entity.Property(e => e.Owner)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TruDatDboTpquestion>(entity =>
        {
            entity.ToTable("TPQuestions");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Question)
                .IsRequired()
                .HasMaxLength(512)
                .IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TruDatDboTptableverify>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("tptableverify");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");

            entity.Property(e => e.Newclinicid).HasColumnName("newclinicid");

            entity.Property(e => e.Oldclinicid).HasColumnName("oldclinicid");
        });

        modelBuilder.Entity<TruDatDboTrialPolicy>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("TrialPolicies");

            entity.Property(e => e.BreedName)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.DateReminderSent).HasColumnType("datetime");

            entity.Property(e => e.Description).IsUnicode(false);

            entity.Property(e => e.EmailAddress)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.HomePhone)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.OwnerFirstName)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.OwnerLastName)
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

            entity.Property(e => e.PolicyDate).HasColumnType("datetime");

            entity.Property(e => e.PolicyNumber)
                .IsRequired()
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.PromoCode)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboUnassignedFaxesNotPilot>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("UnassignedFaxesNotPilot");

            entity.Property(e => e.FileName)
                .IsRequired()
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Number)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ProtusFaxId)
                .IsRequired()
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ReceivedTime).HasColumnType("datetime");

            entity.Property(e => e.SendingFaxNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboUnassignedFaxis>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("UnassignedFaxes");

            entity.Property(e => e.DocumentId)
                .HasMaxLength(24)
                .IsUnicode(false);

            entity.Property(e => e.FileName)
                .IsRequired()
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Number)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.ProtusFaxId)
                .IsRequired()
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ReceivedTime).HasColumnType("datetime");

            entity.Property(e => e.SendingFaxNumber)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboUser>(entity =>
        {
            entity.HasIndex(e => e.Name, "ix_users_name");

            entity.HasIndex(e => e.ExternalId, "uk_users_externalid")
                .IsUnique();

            entity.HasIndex(e => e.Name, "uk_users_uid")
                .IsUnique();

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.ExternalId).HasDefaultValueSql("(newid())");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SalesForceId)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Role)
                .WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_users_roleid");
        });

        modelBuilder.Entity<TruDatDboUserBio>(entity =>
        {
            entity.ToTable("UserBio");

            entity.HasIndex(e => e.UrlPathName, "uk_UserBio_UserUrlPathName")
                .IsUnique();

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.BioDescription).IsUnicode(false);

            entity.Property(e => e.FullName)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ImageName)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ImageNameSmall)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.JobTitle)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.ListPosition).HasDefaultValueSql("((1))");

            entity.Property(e => e.MetaDescription)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.MetaKeywords)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.PageTitle)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.UrlPathName)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.Category)
                .WithMany(p => p.UserBios)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_UserBio_UserBioCategory");
        });

        modelBuilder.Entity<TruDatDboUserBioCategory>(entity =>
        {
            entity.ToTable("UserBioCategory");

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");

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

        modelBuilder.Entity<TruDatDboUserGroup>(entity =>
        {
            entity.ToTable("UserGroup");

            entity.HasIndex(e => e.Name, "uk_usergroup_nme")
                .IsUnique();

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboUserSecurable>(entity =>
        {
            entity.ToTable("UserSecurable");

            entity.HasIndex(e => new { e.UserId, e.SecurableId }, "uk_usersecurable_uid_sid")
                .IsUnique();

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Securable)
                .WithMany(p => p.UserSecurables)
                .HasForeignKey(d => d.SecurableId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_securable_usersecurable");

            entity.HasOne(d => d.User)
                .WithMany(p => p.UserSecurables)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_users_usersecurable");
        });

        modelBuilder.Entity<TruDatDboUsersGroup>(entity =>
        {
            entity.ToTable("UsersGroup");

            entity.HasIndex(e => new { e.GroupId, e.UserId }, "ix_usersgroup_gid_uid");

            entity.HasIndex(e => new { e.UserId, e.GroupId }, "uk_usersgroup_uid_gid")
                .IsUnique();

            entity.HasOne(d => d.Group)
                .WithMany(p => p.UsersGroups)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_group_usersgroup");

            entity.HasOne(d => d.User)
                .WithMany(p => p.UsersGroups)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_users_usersgroup");
        });

        modelBuilder.Entity<TruDatDboUszip>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("USZips");

            entity.Property(e => e.AreaCode)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.CityName)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.CityType)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.CountyFips)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CountyFIPS");

            entity.Property(e => e.CountyName)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.Dst)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("DST");

            entity.Property(e => e.Latitude)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.Longitude)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.Msacode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("MSACode");

            entity.Property(e => e.StateAbbr)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.StateFips)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("StateFIPS");

            entity.Property(e => e.StateName)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.TimeZone)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.Property(e => e.Utc)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("UTC");

            entity.Property(e => e.Zipcode)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ZIPCode");

            entity.Property(e => e.Ziptype)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("ZIPType");
        });

        modelBuilder.Entity<TruDatDboVoucher>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("Voucher");

            entity.Property(e => e.Description).IsUnicode(false);

            entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

            entity.Property(e => e.Inserted).HasColumnType("datetime");

            entity.Property(e => e.LiveDate).HasColumnType("datetime");

            entity.Property(e => e.Name).IsUnicode(false);

            entity.Property(e => e.PromoCode)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.SalesForceId).IsUnicode(false);

            entity.Property(e => e.SecurityKey).IsUnicode(false);

            entity.Property(e => e.Updated).HasColumnType("datetime");

            entity.Property(e => e.Urlredirect)
                .IsUnicode(false)
                .HasColumnName("URLRedirect");
        });

        modelBuilder.Entity<TruDatDboVoucherAgeValidation>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("VoucherAgeValidation");

            entity.Property(e => e.AgeId).IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboVoucherAgeValidationBackup>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("VoucherAgeValidationBackup");
        });

        modelBuilder.Entity<TruDatDboVoucherAttribute>(entity =>
        {
            entity.HasKey(e => new { e.VoucherId, e.Attribute })
                .HasName("pk_voucherattribute_vid_atr");

            entity.ToTable("VoucherAttribute");

            entity.HasIndex(e => e.Id, "uk_voucherattribute_id")
                .IsUnique();

            entity.Property(e => e.Attribute)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Value)
                .IsRequired()
                .HasMaxLength(500)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboVoucherBackup>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("VoucherBackup");

            entity.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.Property(e => e.Inserted).HasColumnType("datetime");

            entity.Property(e => e.LiveDate).HasColumnType("datetime");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PromoCode)
                .IsRequired()
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.Property(e => e.SalesForceId)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.SecurityKey)
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.Updated).HasColumnType("datetime");
        });

        modelBuilder.Entity<TruDatDboVoucherCountryValidation>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("VoucherCountryValidation");

            entity.Property(e => e.CountryId).IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboVoucherCountryValidationBackup>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("VoucherCountryValidationBackup");
        });

        modelBuilder.Entity<TruDatDboVoucherOptOut>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("VoucherOptOut");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.Property(e => e.Inserted).HasColumnType("datetime");

            entity.Property(e => e.Updated).HasColumnType("datetime");

            entity.HasOne(d => d.Pet)
                .WithMany()
                .HasForeignKey(d => d.PetId)
                .HasConstraintName("fk_pet_voucheroptout");
        });

        modelBuilder.Entity<TruDatDboVoucherOverridePolicy>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("VoucherOverridePolicy");

            entity.Property(e => e.CoinsurancePercentage).HasColumnType("smallmoney");

            entity.Property(e => e.MaximumLifetimeBenefitsPayment).HasColumnType("smallmoney");
        });

        modelBuilder.Entity<TruDatDboVoucherOverridePolicyOld>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("VoucherOverridePolicy_old");

            entity.Property(e => e.CoinsurancePercentage).HasColumnType("numeric(6, 4)");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.Property(e => e.MaximumLifetimeBenefitsPayment).HasColumnType("smallmoney");
        });

        modelBuilder.Entity<TruDatDboVoucherReminder>(entity =>
        {
            entity.ToTable("VoucherReminder");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Reminder)
                .WithMany(p => p.VoucherReminders)
                .HasForeignKey(d => d.ReminderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_voucherreminder_reminderId");
        });

        modelBuilder.Entity<TruDatDboVoucherText>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("VoucherText");

            entity.Property(e => e.Description).IsUnicode(false);

            entity.Property(e => e.DiscountModificationTypeName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.DiscountName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.DiscountValue).HasColumnType("numeric(9, 4)");

            entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

            entity.Property(e => e.Inserted).HasColumnType("datetime");

            entity.Property(e => e.LandingPageName).IsUnicode(false);

            entity.Property(e => e.LiveDate).HasColumnType("datetime");

            entity.Property(e => e.Name).IsUnicode(false);

            entity.Property(e => e.PromoCode)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.SalesForceId).IsUnicode(false);

            entity.Property(e => e.SecurityKey).IsUnicode(false);

            entity.Property(e => e.Updated).HasColumnType("datetime");

            entity.Property(e => e.ValidAgeList).IsUnicode(false);

            entity.Property(e => e.ValidCountryList).IsUnicode(false);

            entity.Property(e => e.WebPartner).IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboVoucherTrialPeriod>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("VoucherTrialPeriod");

            entity.Property(e => e.Inserted).HasColumnType("datetime");

            entity.Property(e => e.Updated).HasColumnType("datetime");
        });

        modelBuilder.Entity<TruDatDboVoucherTrialPeriodBackup>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("VoucherTrialPeriodBackup");

            entity.Property(e => e.Inserted).HasColumnType("datetime");

            entity.Property(e => e.Updated).HasColumnType("datetime");
        });

        modelBuilder.Entity<TruDatDboWebPartner>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("WebPartner");

            entity.Property(e => e.AddressLine2)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AddressLine3)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ApiKey)
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.ApilevelId).HasColumnName("APILevelId");

            entity.Property(e => e.BccEmailAlias)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BillingEmailAlias)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BrandPhoneNumber).IsUnicode(false);

            entity.Property(e => e.BrandShadowImage).IsUnicode(false);

            entity.Property(e => e.BrandShadowImagePath).IsUnicode(false);

            entity.Property(e => e.City)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ClaimsEmailAlias)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CompanyName).IsUnicode(false);

            entity.Property(e => e.ContactName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.EmailAddress)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GeneralEmailAlias)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.HeaderHtml).IsUnicode(false);

            entity.Property(e => e.HostingUrl).IsUnicode(false);

            entity.Property(e => e.Inserted).HasColumnType("datetime");

            entity.Property(e => e.LandingPageTitle).IsUnicode(false);

            entity.Property(e => e.LandingPageWelcomeHtml)
                .IsUnicode(false)
                .HasColumnName("LandingPageWelcomeHTML");

            entity.Property(e => e.LogoImage).IsUnicode(false);

            entity.Property(e => e.LogoImagePath).IsUnicode(false);

            entity.Property(e => e.Name)
                .IsRequired()
                .IsUnicode(false);

            entity.Property(e => e.OfferDetailsHtml)
                .IsUnicode(false)
                .HasColumnName("OfferDetailsHTML");

            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.PixelTrackingCharityHtml)
                .IsUnicode(false)
                .HasColumnName("PixelTrackingCharityHTML");

            entity.Property(e => e.PixelTrackingLandingHtml)
                .IsUnicode(false)
                .HasColumnName("PixelTrackingLandingHTML");

            entity.Property(e => e.PixelTrackingMedicalHtml)
                .IsUnicode(false)
                .HasColumnName("PixelTrackingMedicalHTML");

            entity.Property(e => e.PixelTrackingOwnerHtml)
                .IsUnicode(false)
                .HasColumnName("PixelTrackingOwnerHTML");

            entity.Property(e => e.PixelTrackingPaymentHtml)
                .IsUnicode(false)
                .HasColumnName("PixelTrackingPaymentHTML");

            entity.Property(e => e.PixelTrackingQuoteHtml)
                .IsUnicode(false)
                .HasColumnName("PixelTrackingQuoteHTML");

            entity.Property(e => e.PixelTrackingReviewHtml)
                .IsUnicode(false)
                .HasColumnName("PixelTrackingReviewHTML");

            entity.Property(e => e.PixelTrackingWelcomeHtml)
                .IsUnicode(false)
                .HasColumnName("PixelTrackingWelcomeHTML");

            entity.Property(e => e.SalesforceId).IsUnicode(false);

            entity.Property(e => e.SupportEmailAlias)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TestEmailAlias)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TrialDisclaimerPetsHtml)
                .IsUnicode(false)
                .HasColumnName("TrialDisclaimerPetsHTML");

            entity.Property(e => e.TrialDisclaimerQuoteHtml)
                .IsUnicode(false)
                .HasColumnName("TrialDisclaimerQuoteHTML");

            entity.Property(e => e.TrialQuoteResultHtml)
                .IsUnicode(false)
                .HasColumnName("TrialQuoteResultHTML");

            entity.Property(e => e.TrialReviewReplacementHtml)
                .IsUnicode(false)
                .HasColumnName("TrialReviewReplacementHTML");

            entity.Property(e => e.Updated).HasColumnType("datetime");

            entity.Property(e => e.WelcomePageDetailsHtml)
                .IsUnicode(false)
                .HasColumnName("WelcomePageDetailsHTML");

            entity.Property(e => e.Zipcode)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboWebPartnerPolicy>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("WebPartnerPolicy");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TruDatDboWebPartnerText>(entity =>
        {
            entity.HasNoKey();

            entity.ToView("WebPartnerText");

            entity.Property(e => e.AddressLine2)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AddressLine3)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Apikey)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("APIKey");

            entity.Property(e => e.ApilevelId).HasColumnName("APILevelId");

            entity.Property(e => e.BrandPhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BrandShadowImage).IsUnicode(false);

            entity.Property(e => e.BrandShadowImagePath)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.City)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ContactName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.EmailAddress)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.HeaderHtml).IsUnicode(false);

            entity.Property(e => e.HostingUrl)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Inserted).HasColumnType("datetime");

            entity.Property(e => e.LandingPageTitle)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.LandingPageWelcomeHtml)
                .IsUnicode(false)
                .HasColumnName("LandingPageWelcomeHTML");

            entity.Property(e => e.LogoImage).IsUnicode(false);

            entity.Property(e => e.LogoImagePath)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.OfferDetailsHtml)
                .IsUnicode(false)
                .HasColumnName("OfferDetailsHTML");

            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PixelTrackingCharityHtml)
                .IsUnicode(false)
                .HasColumnName("PixelTrackingCharityHTML");

            entity.Property(e => e.PixelTrackingLandingHtml)
                .IsUnicode(false)
                .HasColumnName("PixelTrackingLandingHTML");

            entity.Property(e => e.PixelTrackingMedicalHtml)
                .IsUnicode(false)
                .HasColumnName("PixelTrackingMedicalHTML");

            entity.Property(e => e.PixelTrackingOwnerHtml)
                .IsUnicode(false)
                .HasColumnName("PixelTrackingOwnerHTML");

            entity.Property(e => e.PixelTrackingPaymentHtml)
                .IsUnicode(false)
                .HasColumnName("PixelTrackingPaymentHTML");

            entity.Property(e => e.PixelTrackingQuoteHtml)
                .IsUnicode(false)
                .HasColumnName("PixelTrackingQuoteHTML");

            entity.Property(e => e.PixelTrackingReviewHtml)
                .IsUnicode(false)
                .HasColumnName("PixelTrackingReviewHTML");

            entity.Property(e => e.PixelTrackingWelcomeHtml)
                .IsUnicode(false)
                .HasColumnName("PixelTrackingWelcomeHTML");

            entity.Property(e => e.PromoCode)
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.Property(e => e.Referral)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.SalesForceId)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.SecurityKey)
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.Property(e => e.State)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.StateCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength(true);

            entity.Property(e => e.TrialDisclaimerPetsHtml)
                .IsUnicode(false)
                .HasColumnName("TrialDisclaimerPetsHTML");

            entity.Property(e => e.TrialDisclaimerQuoteHtml)
                .IsUnicode(false)
                .HasColumnName("TrialDisclaimerQuoteHTML");

            entity.Property(e => e.TrialQuoteResultHtml)
                .IsUnicode(false)
                .HasColumnName("TrialQuoteResultHTML");

            entity.Property(e => e.TrialReviewReplacementHtml)
                .IsUnicode(false)
                .HasColumnName("TrialReviewReplacementHTML");

            entity.Property(e => e.Updated).HasColumnType("datetime");

            entity.Property(e => e.Voucher)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.WelcomePageDetailsHtml)
                .IsUnicode(false)
                .HasColumnName("WelcomePageDetailsHTML");

            entity.Property(e => e.Zipcode)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboWebpartnerBackup>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("WebpartnerBackup");

            entity.Property(e => e.AddressLine2)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.AddressLine3)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Apikey)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("APIKey");

            entity.Property(e => e.ApilevelId).HasColumnName("APILevelId");

            entity.Property(e => e.BccEmailAlias)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BillingEmailAlias)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.BrandPhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.BrandShadowImage).IsUnicode(false);

            entity.Property(e => e.BrandShadowImagePath)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.City)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ClaimsEmailAlias)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.CompanyName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.ContactName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.EmailAddress)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.GeneralEmailAlias)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.HeaderHtml).IsUnicode(false);

            entity.Property(e => e.HostingUrl)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.Property(e => e.Inserted).HasColumnType("datetime");

            entity.Property(e => e.LandingPageTitle)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.Property(e => e.LandingPageWelcomeHtml)
                .IsUnicode(false)
                .HasColumnName("LandingPageWelcomeHTML");

            entity.Property(e => e.LogoImage).IsUnicode(false);

            entity.Property(e => e.LogoImagePath)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.OfferDetailsHtml)
                .IsUnicode(false)
                .HasColumnName("OfferDetailsHTML");

            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.Property(e => e.PixelTrackingCharityHtml)
                .IsUnicode(false)
                .HasColumnName("PixelTrackingCharityHTML");

            entity.Property(e => e.PixelTrackingLandingHtml)
                .IsUnicode(false)
                .HasColumnName("PixelTrackingLandingHTML");

            entity.Property(e => e.PixelTrackingMedicalHtml)
                .IsUnicode(false)
                .HasColumnName("PixelTrackingMedicalHTML");

            entity.Property(e => e.PixelTrackingOwnerHtml)
                .IsUnicode(false)
                .HasColumnName("PixelTrackingOwnerHTML");

            entity.Property(e => e.PixelTrackingPaymentHtml)
                .IsUnicode(false)
                .HasColumnName("PixelTrackingPaymentHTML");

            entity.Property(e => e.PixelTrackingQuoteHtml)
                .IsUnicode(false)
                .HasColumnName("PixelTrackingQuoteHTML");

            entity.Property(e => e.PixelTrackingReviewHtml)
                .IsUnicode(false)
                .HasColumnName("PixelTrackingReviewHTML");

            entity.Property(e => e.PixelTrackingWelcomeHtml)
                .IsUnicode(false)
                .HasColumnName("PixelTrackingWelcomeHTML");

            entity.Property(e => e.SalesForceId)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.SupportEmailAlias)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TestEmailAlias)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.TrialDisclaimerPetsHtml)
                .IsUnicode(false)
                .HasColumnName("TrialDisclaimerPetsHTML");

            entity.Property(e => e.TrialDisclaimerQuoteHtml)
                .IsUnicode(false)
                .HasColumnName("TrialDisclaimerQuoteHTML");

            entity.Property(e => e.TrialQuoteResultHtml)
                .IsUnicode(false)
                .HasColumnName("TrialQuoteResultHTML");

            entity.Property(e => e.TrialReviewReplacementHtml)
                .IsUnicode(false)
                .HasColumnName("TrialReviewReplacementHTML");

            entity.Property(e => e.Updated).HasColumnType("datetime");

            entity.Property(e => e.WelcomePageDetailsHtml)
                .IsUnicode(false)
                .HasColumnName("WelcomePageDetailsHTML");

            entity.Property(e => e.Zipcode)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboWelcomeKits0803>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("WelcomeKits0803");

            entity.Property(e => e.AddressLine2).HasMaxLength(255);

            entity.Property(e => e.AddressLine3).HasMaxLength(255);

            entity.Property(e => e.City).HasMaxLength(255);

            entity.Property(e => e.Country).HasMaxLength(255);

            entity.Property(e => e.DateOrdered).HasColumnType("datetime");

            entity.Property(e => e.Email).HasMaxLength(255);

            entity.Property(e => e.F19).HasMaxLength(255);

            entity.Property(e => e.F20).HasMaxLength(255);

            entity.Property(e => e.F21).HasMaxLength(255);

            entity.Property(e => e.MailDate)
                .HasMaxLength(255)
                .HasColumnName("MAIL DATE");

            entity.Property(e => e.MailJob)
                .HasMaxLength(255)
                .HasColumnName("MAIL JOB");

            entity.Property(e => e.OwnerFirstName).HasMaxLength(255);

            entity.Property(e => e.OwnerLastName).HasMaxLength(255);

            entity.Property(e => e.PetName).HasMaxLength(255);

            entity.Property(e => e.PolicyDate).HasColumnType("datetime");

            entity.Property(e => e.PolicyNumber).HasMaxLength(255);

            entity.Property(e => e.StateCode).HasMaxLength(255);

            entity.Property(e => e.Tag)
                .HasMaxLength(255)
                .HasColumnName("TAG");
        });

        modelBuilder.Entity<TruDatDboWhatClinicsAreTheseFor>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("WhatClinicsAreTheseFor");

            entity.Property(e => e.Inserted).HasColumnType("datetime");

            entity.Property(e => e.Updated).HasColumnType("datetime");
        });

        modelBuilder.Entity<TruDatDboWorkflowCase>(entity =>
        {
            entity.ToTable("WorkflowCase");

            entity.HasIndex(e => new { e.CategoryId, e.SubjectEntityTypeId, e.SubjectEntityId }, "ix_workflowcase_cid_etid_eid");

            entity.HasIndex(e => new { e.SubjectEntityTypeId, e.SubjectEntityId }, "ix_workflowcase_etid_eid");

            entity.HasIndex(e => new { e.WorkflowQueueId, e.SubjectEntityTypeId, e.SubjectEntityId }, "ix_workflowcase_qid");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Category)
                .WithMany(p => p.WorkflowCases)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("fk_entitytree_workflowcase");

            entity.HasOne(d => d.Parent)
                .WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .HasConstraintName("fk_workflowcase_workflowcase");

            entity.HasOne(d => d.Status)
                .WithMany(p => p.WorkflowCases)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_status_workflowcase");

            entity.HasOne(d => d.SubjectEntityType)
                .WithMany(p => p.WorkflowCases)
                .HasForeignKey(d => d.SubjectEntityTypeId)
                .HasConstraintName("fk_entity_workflowcase_subject");

            entity.HasOne(d => d.WorkflowQueue)
                .WithMany(p => p.WorkflowCases)
                .HasForeignKey(d => d.WorkflowQueueId)
                .HasConstraintName("fk_workflowqueue_workflowcase");
        });

        modelBuilder.Entity<TruDatDboWorkflowCaseAction>(entity =>
        {
            entity.ToTable("WorkflowCaseAction");

            entity.HasIndex(e => new { e.WorkflowCaseId, e.Id }, "ix_workflowcaseaction_wcid_id");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Category)
                .WithMany(p => p.WorkflowCaseActions)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_entitytree_workflowcaseaction");

            entity.HasOne(d => d.WorkflowCase)
                .WithMany(p => p.WorkflowCaseActions)
                .HasForeignKey(d => d.WorkflowCaseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_workflowcase_workflowcaseaction");
        });

        modelBuilder.Entity<TruDatDboWorkflowCaseConfig>(entity =>
        {
            entity.ToTable("WorkflowCaseConfig");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.ChangeToStatus)
                .WithMany(p => p.WorkflowCaseConfigs)
                .HasForeignKey(d => d.ChangeToStatusId)
                .HasConstraintName("fk_status_workflowcaseconfig");

            entity.HasOne(d => d.WorkflowGroup)
                .WithMany(p => p.WorkflowCaseConfigs)
                .HasForeignKey(d => d.WorkflowGroupId)
                .HasConstraintName("fk_workflowgroup_workflowcaseconfig");
        });

        modelBuilder.Entity<TruDatDboWorkflowEmail>(entity =>
        {
            entity.ToTable("WorkflowEmail");

            entity.HasIndex(e => e.EmailId, "ix_workflowemail_eid");

            entity.HasIndex(e => e.WorkflowCaseId, "ix_workflowemail_wcid");

            entity.HasIndex(e => new { e.WorkflowCaseId, e.EmailId }, "uk_workflowemail_wid_eid")
                .IsUnique();

            entity.HasOne(d => d.WorkflowCase)
                .WithMany(p => p.WorkflowEmails)
                .HasForeignKey(d => d.WorkflowCaseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_workflowcase_workflowemail");
        });

        modelBuilder.Entity<TruDatDboWorkflowGroup>(entity =>
        {
            entity.ToTable("WorkflowGroup");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboWorkflowGroupUser>(entity =>
        {
            entity.HasKey(e => new { e.GroupId, e.UserId })
                .HasName("pk_workflowgroupuser_gid_uid");

            entity.ToTable("WorkflowGroupUser");

            entity.HasIndex(e => new { e.UserId, e.GroupId }, "ix_workflowgroupuser_uid_gid");

            entity.HasOne(d => d.Group)
                .WithMany(p => p.WorkflowGroupUsers)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_workflowgroup_workflowgroupuser_uid");

            entity.HasOne(d => d.User)
                .WithMany(p => p.WorkflowGroupUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_user_workflowgroupuser_uid");
        });

        modelBuilder.Entity<TruDatDboWorkflowQueue>(entity =>
        {
            entity.ToTable("WorkflowQueue");

            entity.HasIndex(e => new { e.CategoryId, e.Name }, "uk_workflowqueue_cid_nme")
                .IsUnique();

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Category)
                .WithMany(p => p.WorkflowQueues)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_entitytree_workflowqueue");
        });

        modelBuilder.Entity<TruDatDboWorkflowQueueLock>(entity =>
        {
            entity.HasKey(e => new { e.WorkflowQueueId, e.SubjectEntityTypeId, e.SubjectEntityId })
                .HasName("pk_workflowqueuelock_etid_eid_wqid");

            entity.ToTable("WorkflowQueueLock");

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TruDatDboWorkflowQueueUser>(entity =>
        {
            entity.ToTable("WorkflowQueueUser");

            entity.HasIndex(e => e.UserId, "ix_workflowqueueuser_uid");

            entity.HasIndex(e => new { e.WorkflowQueueId, e.UserId }, "uk_workflowqueueuser_qid_uid")
                .IsUnique();

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.User)
                .WithMany(p => p.WorkflowQueueUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_user_workflowqueueuser");

            entity.HasOne(d => d.WorkflowQueue)
                .WithMany(p => p.WorkflowQueueUsers)
                .HasForeignKey(d => d.WorkflowQueueId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_workflowqueue_workflowqueueuser");
        });

        modelBuilder.Entity<TruDatDboWorkingPet>(entity =>
        {
            entity.ToTable("WorkingPet");

            entity.HasIndex(e => e.CategoryId, "ix_workingpet_cid");

            entity.HasIndex(e => new { e.SpecieId, e.Name }, "uk_workingpet_nme")
                .IsUnique();

            entity.Property(e => e.Description)
                .IsRequired()
                .IsUnicode(false);

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Category)
                .WithMany(p => p.WorkingPets)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_workingpetcategory_workingpet");

            entity.HasOne(d => d.Document)
                .WithMany(p => p.WorkingPets)
                .HasForeignKey(d => d.DocumentId)
                .HasConstraintName("fk_policydoctype_workingpet");

            entity.HasOne(d => d.Specie)
                .WithMany(p => p.WorkingPets)
                .HasForeignKey(d => d.SpecieId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_animal_workingpet");
        });

        modelBuilder.Entity<TruDatDboWorkingPetCategory>(entity =>
        {
            entity.ToTable("WorkingPetCategory");

            entity.HasIndex(e => e.Name, "uk_workingpetcategory_nme")
                .IsUnique();

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboWrkCodePath>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("wrkCodePath");

            entity.Property(e => e.Logdate)
                .HasColumnType("datetime")
                .HasColumnName("logdate");

            entity.Property(e => e.Pathdescription)
                .HasMaxLength(250)
                .HasColumnName("pathdescription");
        });

        modelBuilder.Entity<TruDatDboWrkPotentialPet>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("wrkPotentialPets");

            entity.Property(e => e.ClinicType).HasMaxLength(250);

            entity.Property(e => e.Logdate)
                .HasColumnType("datetime")
                .HasColumnName("logdate");
        });

        modelBuilder.Entity<TruDatDboZipCodesDatabaseDeluxeBusiness>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("zip-codes-database-DELUXE-BUSINESS");

            entity.Property(e => e.AreaCode)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.AsianPopulation)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.AverageHouseValue)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.BlackPopulation)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.BoxCount)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.BusinessAnnualPayroll)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.BusinessEmploymentFlag)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.BusinessFirstQuarterPayroll)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Cbsa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CBSA");

            entity.Property(e => e.CbsaDiv)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CBSA_Div");

            entity.Property(e => e.CbsaDivName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CBSA_Div_Name");

            entity.Property(e => e.CbsadivPop2003)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CBSADivPop2003");

            entity.Property(e => e.Cbsaname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CBSAName");

            entity.Property(e => e.Cbsapop2003)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CBSAPop2003");

            entity.Property(e => e.Cbsatype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CBSAType");

            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CityAliasAbbreviation)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CityAliasCode)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CityAliasMixedCase)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CityAliasName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CityMixedCase)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CityStateKey)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CityType)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ClassificationCode)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CongressionalDistrict)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CongressionalLandArea)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.County)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.CountyFips)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CountyFIPS");

            entity.Property(e => e.Csa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSA");

            entity.Property(e => e.Csaname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CSAName");

            entity.Property(e => e.DayLightSaving)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.DeliveryBusiness)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.DeliveryResidential)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.DeliveryTotal)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Division)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Elevation)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.FemalePopulation)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.GrowthHousingUnits2003)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.GrowthHousingUnits2004)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.GrowthIncreaseNumber)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.GrowthIncreasePercentage)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.GrowthRank)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.HawaiianPopulation)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.HispanicPopulation)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.HouseholdsPerZipCode)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.IncomePerHousehold)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.IndianPopulation)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.LandArea)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Latitude)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Longitude)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.MailingName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.MalePopulation)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.MedianAge)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.MedianAgeFemale)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.MedianAgeMale)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Mfdu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MFDU");

            entity.Property(e => e.Msa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MSA");

            entity.Property(e => e.MultiCounty)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.NumberOfBusinesses)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.NumberOfEmployees)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.OtherPopulation)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.PersonsPerHousehold)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Pmsa)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PMSA");

            entity.Property(e => e.Pmsaname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PMSAName");

            entity.Property(e => e.Population)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.PopulationEstimate)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.PreferredLastLineKey)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.PrimaryRecord)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.Sfdu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SFDU");

            entity.Property(e => e.State)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.StateFips)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("StateFIPS");

            entity.Property(e => e.StateFullName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.TimeZone)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.WaterArea)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.WhitePopulation)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.Property(e => e.ZipCode)
            .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDboZipcode>(entity =>
        {
            entity.HasKey(e => new { e.Zipcode1, e.StateId })
                .HasName("pk_zipcode_zip_sid");

            entity.ToTable("Zipcode");

            entity.HasIndex(e => new { e.Lat, e.Lon, e.Zipcode1 }, "ix_zipcode_lat_lon_zip");

            entity.HasIndex(e => new { e.StateId, e.Zipcode1 }, "ix_zipcode_sid_zc");

            entity.HasIndex(e => new { e.Zipcode1, e.County }, "ix_zipcode_zc_cnt");

            entity.Property(e => e.Zipcode1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Zipcode");

            entity.Property(e => e.Active)
                .IsRequired()
                .HasDefaultValueSql("((1))");

            entity.Property(e => e.County)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Inserted)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.Property(e => e.Lat).HasColumnType("numeric(18, 15)");

            entity.Property(e => e.Lon).HasColumnType("numeric(18, 15)");

            entity.Property(e => e.PlaceName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Updated)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.State)
                .WithMany(p => p.Zipcodes)
                .HasForeignKey(d => d.StateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_state_zipcode");
        });

        modelBuilder.Entity<TruDatDboZipcodeCopy07232012>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("ZipcodeCopy_07232012");

            entity.Property(e => e.County)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Inserted).HasColumnType("datetime");

            entity.Property(e => e.Lat).HasColumnType("numeric(18, 15)");

            entity.Property(e => e.Lon).HasColumnType("numeric(18, 15)");

            entity.Property(e => e.PlaceName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.Property(e => e.Updated).HasColumnType("datetime");

            entity.Property(e => e.Zipcode)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TruDatDbo_20100615SentPastDueEmail>(entity =>
        {
            entity.HasNoKey();

            entity.ToTable("'20100615_SentPastDueEmail$'");

            entity.Property(e => e.AccountName)
                .HasMaxLength(255)
                .HasColumnName("Account Name");

            entity.Property(e => e.BillingDateFailedPmt).HasColumnType("datetime");

            entity.Property(e => e.Email).HasMaxLength(255);

            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .HasColumnName("First Name");

            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .HasColumnName("Last Name");

            entity.Property(e => e.MailingCountry)
                .HasMaxLength(255)
                .HasColumnName("Mailing Country");

            entity.Property(e => e.MailingStateProvince)
                .HasMaxLength(255)
                .HasColumnName("Mailing State/Province");

            entity.Property(e => e.PastDue).HasMaxLength(255);

            entity.Property(e => e.PastDueEmail1Sent).HasColumnType("datetime");

            entity.Property(e => e.PastDueEmail2Sent).HasMaxLength(255);

            entity.Property(e => e.PastDueEmail3Sent).HasMaxLength(255);

            entity.Property(e => e.PolicyNumber)
                .HasMaxLength(255)
                .HasColumnName("Policy Number");

            entity.Property(e => e.TerritoryPartner)
                .HasMaxLength(255)
                .HasColumnName("Territory Partner");

            entity.Property(e => e.TruDatOwnerId)
                .HasMaxLength(255)
                .HasColumnName("TruDat Owner ID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
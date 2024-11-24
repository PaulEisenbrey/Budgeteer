namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboClaim
{
    public int Id { get; set; }
    public int ClaimTypeId { get; set; }
    public int PetPolicyId { get; set; }
    public int StatusId { get; set; }
    public int? ExclusionReasonId { get; set; }
    public string? ExclusionReasonNotes { get; set; }
    public DateTime? DateOfLoss { get; set; }
    public string? Diagnosis { get; set; }
    public string? TypeOfInjury { get; set; }
    public string? CauseOfInjury { get; set; }
    public int? ConditionTypeId { get; set; }
    public decimal? TotalClaimed { get; set; }
    public decimal? TotalCustomerClaimed { get; set; }
    public decimal? AmountNotClaimable { get; set; }
    public decimal? AmountPaidOut { get; set; }
    public decimal? BoardingFees { get; set; }
    public decimal? ExamFees { get; set; }
    public bool? _90dayClaim { get; set; }
    public bool? Over1k { get; set; }
    public bool? Over2500 { get; set; }
    public bool? CertClaim { get; set; }
    public bool? SusClient { get; set; }
    public bool? SusClinic { get; set; }
    public bool? SusClaim { get; set; }
    public string? Comments { get; set; }
    public decimal? Rechecks { get; set; }
    public decimal? Gst5 { get; set; }
    public decimal? OtherVetCost { get; set; }
    public bool? ClaimForm { get; set; }
    public bool? ClaimsExpress { get; set; }
    public bool? PreApproval { get; set; }
    public bool? FromQcNbEtc { get; set; }
    public bool? _3rdPartyLiability { get; set; }
    public DateTime? DateClosed { get; set; }
    public bool? ClaimFormComplete { get; set; }
    public bool? SpayedNeutered { get; set; }
    public bool? IllnessRelatedToActivityPriorToPolicyInception { get; set; }
    public bool? PredisposedPriorToFullCoverage { get; set; }
    public bool? PreventiveMeasureAvailable { get; set; }
    public bool? ElectiveProcedure { get; set; }
    public bool? ProblemDetectableAtBirth { get; set; }
    public bool? FundsPaidToClinic { get; set; }
    public string? UnRelatedChargesDesc { get; set; }
    public decimal? InvoiceSubTotal { get; set; }
    public string? InvoiceNumbers { get; set; }
    public bool? IsChequeIssued { get; set; }
    public decimal? DeductibleAmount { get; set; }
    public bool Deleted { get; set; }
    public DateTime Inserted { get; set; }
    public int CreateUserId { get; set; }
    public DateTime Updated { get; set; }
    public int? AssignedToUserId { get; set; }
    public DateTime? DateDeleted { get; set; }
    public string? SalesForceId { get; set; }
    public string? LetterComments { get; set; }
    public int? ChangeUserId { get; set; }
    public string? PendingInfoComments { get; set; }
    public bool? DeductibleOverride { get; set; }
    public decimal? RemDeductible { get; set; }
    public bool IsFastTrack { get; set; }
    public bool IsFastTrackReviewed { get; set; }
    public byte[]? ConcurrencyToken { get; set; }

    public virtual TruDatDboUser? AssignedToUser { get; set; }
    public virtual TruDatDboClaimType? ClaimType { get; set; }
    public virtual TruDatDboUser? CreateUser { get; set; }
    public virtual TruDatDboClaimExclusion? ExclusionReason { get; set; }
    public virtual TruDatDboPetPolicy? PetPolicy { get; set; }
    public virtual TruDatDboStatus? Status { get; set; }
    public virtual TruDatDboClaimDisposition? ClaimDisposition { get; set; }
    public virtual TruDatDboClaimHierarchy? ClaimHierarchyClaim { get; set; }
    public virtual List<TruDatDboBankCheck> BankChecks { get; set; } = new();
    public virtual List<TruDatDboClaimBatchLetter> ClaimBatchLetters { get; set; } = new();
    public virtual List<TruDatDboClaimClinic> ClaimClinics { get; set; } = new();
    public virtual List<TruDatDboClaimHierarchy> ClaimHierarchyParentClaims { get; set; } = new();
    public virtual List<TruDatDboClaimProcess> ClaimProcesses { get; set; } = new();
    public virtual List<TruDatDboClaimWorkflowViewStatus> ClaimWorkflowViewStatuses { get; set; } = new();
}

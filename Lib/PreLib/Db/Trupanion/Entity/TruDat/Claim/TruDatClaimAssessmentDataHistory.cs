﻿using Utilities.EntityBaseClasses;

namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatClaimAssessmentDataHistory : EntityIntId
{
    public int AssessmentDataId { get; set; }

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

    public bool? NinetyDayClaim { get; set; }

    public bool? Over1k { get; set; }

    public bool? Over2500 { get; set; }

    public bool? CertClaim { get; set; }

    public bool? SusClient { get; set; }

    public bool? SusClinic { get; set; }

    public bool? SusClaim { get; set; }

    public string? Comments { get; set; }

    public decimal? Rechecks { get; set; }

    public decimal? GST5 { get; set; }

    public decimal? OtherVetCost { get; set; }

    public bool? ClaimForm { get; set; }

    public bool? ClaimsExpress { get; set; }

    public bool? PreApproval { get; set; }

    public bool? FromQC_NB_etc { get; set; }

    public bool? ThirdPartyLiability { get; set; }

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

    public int? UrgencyStatusId { get; set; }

    public int? ClinicId { get; set; }
}
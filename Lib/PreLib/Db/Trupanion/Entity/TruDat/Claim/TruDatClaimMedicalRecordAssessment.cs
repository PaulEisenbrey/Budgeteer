namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatClaimMedicalRecordAssessment
{
    public int MedicalRecordId { get; set; }

    public bool? PreX { get; set; }

    public string? PreXComments { get; set; }

    public bool? Covered { get; set; }

    public bool? History { get; set; }

    public DateTime Inserted { get; set; }

    public DateTime Updated { get; set; }

    public int? ChangeUserId { get; set; }

    public int? ConditionNumber { get; set; }

    public decimal? DeductibleApplied { get; set; }

    public bool? ManagerOverride { get; set; }

    public int? AdditionalBenefitTypeId { get; set; }

    public decimal? Eligible { get; set; }

    public bool? StampedEligible { get; set; }

    public decimal? Ineligible { get; set; }

    public decimal? RemDeductible { get; set; }

    public int PawPrintObserved { get; set; }

    public DateTime? HistoryObserved { get; set; }

    public DateTime? EligibilityCompleted { get; set; }

    public bool? PilotPreX { get; set; }

    public decimal? CoinsuranceApplied { get; set; }

    public int? CalculationVersionId { get; set; }

}

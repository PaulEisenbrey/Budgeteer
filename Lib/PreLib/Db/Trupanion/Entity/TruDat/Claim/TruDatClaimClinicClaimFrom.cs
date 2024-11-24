using Utilities.EntityBaseClasses;

namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatClaimClinicClaimFrom : EntityIntId
{
    public int AssessmentDataId { get; set; }

    public string? PresentingConditions { get; set; }

    public bool PostAssessment { get; set; }

    public string? CareType { get; set; }

    public string? SuspectedCause { get; set; }

    public bool IsSpayedNeutered { get; set; }

    public DateTime? SpayedNeuteredDate { get; set; }

    public DateTime? FirstSymptomDate { get; set; }

    public DateTime? LossDate { get; set; }

    public bool? isUrgent { get; set; }

    public DateTime? TreatmentDate { get; set; }

    public string? SubmittedBy { get; set; }

    public DateTime Updated { get; set; }

    public DateTime Inserted { get; set; }

    public int ChangeUserId { get; set; }

    public int? ClinicId { get; set; }

    public int? PaymentMethod { get; set; }

    public string? AttendingVet { get; set; }

    public int? RelatedClaim { get; set; }

    public string? HtmlString { get; set; }

    public int? AttachmentId { get; set; }

}

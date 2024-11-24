using Utilities.EntityBaseClasses;

namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatClaimAssessmentData : EntityIntId
{
    public int? AssessmentId { get; set; }

    public bool Finalized { get; set; }

    public int? FinalizedByUserId { get; set; }

    public int? ChangeUserId { get; set; }

    public DateTime Inserted { get; set; }

    public DateTime Updated { get; set; }

    public int? Priority { get; set; }

    public int AssessmentDataCategoryId { get; set; }

    public DateTime? TreatmentDate { get; set; }

    public int? PaymentMethodId { get; set; }

    public string? HtmlString { get; set; }

    public bool Deleted { get; set; }

    public int PawPrintObserved { get; set; }

    public bool HistoryObserved { get; set; }

    public bool? FastTrack { get; set; }

    public bool? Eligible18MonthReview { get; set; }

    public bool? Accident { get; set; }

    public bool? DirectPolicyExcl { get; set; }

    public bool? IncidentHx { get; set; }

    public bool? IsMasterAppeal { get; set; }

    public int? AppealTypeId { get; set; }

    public bool? DeceasedPet { get; set; }

    public bool? AutoSend { get; set; }

    public DateTime? ChangePayeeRequested { get; set; }
}

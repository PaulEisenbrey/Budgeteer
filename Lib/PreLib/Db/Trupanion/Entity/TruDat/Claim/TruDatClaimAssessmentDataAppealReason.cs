using Utilities.EntityBaseClasses;

namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatClaimAssessmentDataAppealReason : EntityIntId
{
    public int AssessmentDataAppealId { get; set; }

    public int ReasonId { get; set; }

    public DateTime Inserted { get; set; }

    public DateTime Updated { get; set; }

    public int? ChangeUserId { get; set; }

}

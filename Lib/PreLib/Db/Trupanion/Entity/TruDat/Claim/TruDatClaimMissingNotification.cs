using System;

namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatClaimMissingNotification
{
    public int? ClaimId { get; set; }

    public int? LastAssessmentDataId { get; set; }

    public bool? Completed { get; set; }

    public int? EntityReviewId { get; set; }

    public DateTime DateToSend { get; set; }
}

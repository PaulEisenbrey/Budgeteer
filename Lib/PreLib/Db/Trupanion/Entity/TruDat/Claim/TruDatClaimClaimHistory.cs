using Utilities.EntityBaseClasses;

namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatClaimClaimHistory : EntityIntId
{
    public int ClaimId { get; set; }

    public decimal? DeductibleForCondition { get; set; }

    public decimal? CumulativeDeductiblePaid { get; set; }

    public DateTime Inserted { get; set; }

    public DateTime Updated { get; set; }

    public int? ChangeUserId { get; set; }

    public decimal? PolicyDeductible { get; set; }

}

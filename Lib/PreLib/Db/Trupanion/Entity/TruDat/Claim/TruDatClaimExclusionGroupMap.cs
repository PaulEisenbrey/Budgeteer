using Utilities.EntityBaseClasses;

namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatClaimExclusionGroupMap : EntityIntId
{
    public int ClaimExclusionGroupId { get; set; }

    public int ClaimExclusionId { get; set; }

    public DateTime Inserted { get; set; }

    public DateTime Updated { get; set; }

    public int ChangeUserId { get; set; }

}

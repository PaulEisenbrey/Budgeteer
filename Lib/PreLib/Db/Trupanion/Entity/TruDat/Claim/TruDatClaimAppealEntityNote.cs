using Utilities.EntityBaseClasses;

namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatClaimAppealEntityNote : EntityIntId
{
    public int EntityNoteId { get; set; }

    public int CreateUserId { get; set; }

    public bool? Active { get; set; }

    public bool Pet { get; set; }

    public bool ClaimDash { get; set; }

    public DateTime Inserted { get; set; }

    public DateTime Updated { get; set; }

    public int? ChangeUserId { get; set; }

}
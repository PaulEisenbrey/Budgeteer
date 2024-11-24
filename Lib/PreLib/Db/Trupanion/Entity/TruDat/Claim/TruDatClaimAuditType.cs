using Utilities.EntityBaseClasses;

namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatClaimAuditType : EntityIntId
{
    public string? Name { get; set; }

    public int? ClaimExclusionGroupId { get; set; }

    public string? OrKeyList { get; set; }

    public string? AndKeyList { get; set; }

    public string? ExceptKeyList { get; set; }

    public bool Active { get; set; }

    public bool IsForClinicInvoice { get; set; }

    public DateTime Inserted { get; set; }

    public DateTime Updated { get; set; }

    public int ChangeUserId { get; set; }

}

using Utilities.EntityBaseClasses;

namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatClaimInvoiceLineItemExclusion : EntityIntId
{
    public int InvoiceLineItemId { get; set; }

    public int? ExclusionId { get; set; }

    public DateTime Inserted { get; set; }

    public DateTime Updated { get; set; }

    public int? ChangeUserId { get; set; }

    public Guid? ExclusionUniqueId { get; set; }

    public string? EobBlurb { get; set; }

}

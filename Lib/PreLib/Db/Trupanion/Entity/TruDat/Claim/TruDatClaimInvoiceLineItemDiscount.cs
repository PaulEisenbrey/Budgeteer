using Utilities.EntityBaseClasses;

namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatClaimInvoiceLineItemDiscount : EntityIntId
{
    public int InvoiceLineItemId { get; set; }

    public int? DiscountCategoryId { get; set; }

    public decimal? Amount { get; set; }

    public decimal? Percent { get; set; }

    public string? Description { get; set; }

    public DateTime Inserted { get; set; }

    public DateTime Updated { get; set; }

    public int? ChangeUserId { get; set; }

}

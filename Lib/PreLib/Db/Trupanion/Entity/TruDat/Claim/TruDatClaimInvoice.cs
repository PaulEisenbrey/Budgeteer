using Utilities.EntityBaseClasses;

namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatClaimInvoice : EntityIntId
{
    public string? ExternalInvoiceId { get; set; }

    public decimal? Discount { get; set; }

    public DateTime Inserted { get; set; }

    public DateTime Updated { get; set; }

    public int? ChangeUserId { get; set; }

    public int AssessmentDataId { get; set; }

    public decimal? Subtotal { get; set; }

    public string? ReturnCalcString { get; set; }

    public decimal? ReturnAmount { get; set; }

    public decimal FoodDays { get; set; }

}

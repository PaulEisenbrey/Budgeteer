using Utilities.EntityBaseClasses;

namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatClaimClinicInvoice : EntityIntId
{
    public int AssessmentDataId { get; set; }

    public string? PIMSInvoiceId { get; set; }

    public decimal Subtotal { get; set; }

    public decimal Discount { get; set; }

    public DateTime Updated { get; set; }

    public DateTime Inserted { get; set; }

    public int ChangeUserId { get; set; }

}

using Utilities.EntityBaseClasses;

namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatClaimInvoiceLineItemCondition : EntityIntId
{
    public int InvoiceLineItemId { get; set; }

    public int MedicalRecordId { get; set; }

    public DateTime Inserted { get; set; }

    public DateTime Updated { get; set; }

    public int? ChangeUserId { get; set; }

}

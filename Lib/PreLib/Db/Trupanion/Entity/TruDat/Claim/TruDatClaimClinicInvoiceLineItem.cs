using Utilities.EntityBaseClasses;

namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatClaimClinicInvoiceLineItem : EntityIntId
{
    public int ClinicInvoiceId { get; set; }

    public string? InvoiceNumber { get; set; }

    public bool IsEstimate { get; set; }

    public string? ItemDescription { get; set; }

    public string? Category { get; set; }

    public decimal Quantity { get; set; }

    public decimal BaseUnitPrice { get; set; }

    public decimal ActualExtendedPrice { get; set; }

    public string? Provider { get; set; }

    public string? OperatorName { get; set; }

    public DateTime TransactionDate { get; set; }

    public DateTime Updated { get; set; }

    public DateTime Inserted { get; set; }

    public int ChangeUserId { get; set; }

    public int? ItemType { get; set; }

}

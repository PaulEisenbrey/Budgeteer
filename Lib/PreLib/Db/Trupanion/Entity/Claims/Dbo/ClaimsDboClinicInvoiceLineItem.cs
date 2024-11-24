namespace Database.Trupanion.Entity.Claims.Dbo;

public class ClaimsDboClinicInvoiceLineItem
{
    public int Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid? CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid? ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public int ClinicInvoiceId { get; set; }
    public string? InvoiceNumber { get; set; }
    public string? InvoicePetName { get; set; }
    public string? ItemDescription { get; set; }
    public decimal ActualExtendedPrice { get; set; }
    public string? Provider { get; set; }
    public string? OperatorName { get; set; }
    public DateTime TransactionDate { get; set; }
    public int? ItemType { get; set; }
    public int? PaymentFlag { get; set; }
    public int? SalesTaxFlag { get; set; }

    public virtual ClaimsDboClinicInvoice? ClinicInvoice { get; set; }
}

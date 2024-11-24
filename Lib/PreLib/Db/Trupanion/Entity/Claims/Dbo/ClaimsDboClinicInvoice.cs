namespace Database.Trupanion.Entity.Claims.Dbo;

public class ClaimsDboClinicInvoice
{
    public ClaimsDboClinicInvoice()
    {
        ClinicInvoiceLineItems = new HashSet<ClaimsDboClinicInvoiceLineItem>();
    }

    public int Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid? CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid? ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public int AssessmentDataId { get; set; }
    public string? PimsinvoiceId { get; set; }
    public decimal Subtotal { get; set; }
    public decimal Discount { get; set; }
    public int SourceEnterpriseApplicationId { get; set; }

    public virtual ICollection<ClaimsDboClinicInvoiceLineItem> ClinicInvoiceLineItems { get; set; }
}

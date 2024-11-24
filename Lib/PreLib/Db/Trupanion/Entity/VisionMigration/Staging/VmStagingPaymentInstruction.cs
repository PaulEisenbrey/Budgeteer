namespace Database.Trupanion.Entity.VisionMigration.Staging;

public class VmStagingPaymentInstruction
{
    public int? Id { get; set; }
    public string? AccountName { get; set; }
    public string? AccountNumber { get; set; }
    public string? BrandCode { get; set; }
    public string? ChequeAddressee { get; set; }
    public string? ChequeAddress1 { get; set; }
    public string? ChequeAddress2 { get; set; }
    public string? ChequeCity { get; set; }
    public string? ChequeRegion { get; set; }
    public string? ChequeCountry { get; set; }
    public string? ChequePostalCode { get; set; }
    public int ClaimId { get; set; }
    public int? ClaimPaymentId { get; set; }
    public int ClientPaymentMethodId { get; set; }
    public string? Currency { get; set; }
    public DateTime DateTimeReceived { get; set; }
    public DateTime DateTimeUpdated { get; set; }
    public decimal? Gross { get; set; }
    public int PaymentMethodTypeId { get; set; }
    public int PaymentStatusId { get; set; }
    public string? PolicyId { get; set; }
    public string? SortCode { get; set; }
    public DateTime TransactionDate { get; set; }
    public bool? IsVet { get; set; }
    public Guid? BatchId { get; set; }
}

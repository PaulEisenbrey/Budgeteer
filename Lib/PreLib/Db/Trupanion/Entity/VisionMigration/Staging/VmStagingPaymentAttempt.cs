namespace Database.Trupanion.Entity.VisionMigration.Staging;

public class VmStagingPaymentAttempt
{
    public int? Id { get; set; }
    public string? AccountName { get; set; }
    public string? AccountNumber { get; set; }
    public int PaymentStatusId { get; set; }
    public int PaymentBatchId { get; set; }
    public string? BrandCode { get; set; }
    public string? ChequeAddressee { get; set; }
    public string? ChequeAddress1 { get; set; }
    public string? ChequeAddress2 { get; set; }
    public string? ChequeAddressCity { get; set; }
    public string? ChequeAddressRegion { get; set; }
    public int? ChequeNumber { get; set; }
    public string? ChequePostalCode { get; set; }
    public int ClaimId { get; set; }
    public int ClientPaymentMethodId { get; set; }
    public string? InstitutionNumber { get; set; }
    public DateTime? PaymentAttemptDateTime { get; set; }
    public int PaymentMethodTypeId { get; set; }
    public string? GatewayReason { get; set; }
    public string? GatewayReasonCode { get; set; }
    public int? GatewayResponseId { get; set; }
    public decimal? Gross { get; set; }
    public string? RoutingNumber { get; set; }
    public string? ChequeCountry { get; set; }
    public bool? IsVet { get; set; }
    public Guid? BatchId { get; set; }
}

namespace Database.Trupanion.Entity.Billing.DataIntegration;

public  class BillingDataIntegrationFailedPayment
{
    public int Id { get; set; }
    public string? AccountId { get; set; }
    public decimal AccountBalance { get; set; }
    public DateTime PaymentCreatedDate { get; set; }
    public int ProcessInstanceId { get; set; }
    public bool? Processed { get; set; }
    public string? PaymentGatewayResponse { get; set; }
    public string? PaymentGatewayResponseCode { get; set; }
    public string? DefaultPaymentMethodId { get; set; }
}

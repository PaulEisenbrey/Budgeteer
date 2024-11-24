namespace Database.Trupanion.Entity.Billing.DataIntegration;

public  class BillingDataIntegrationChargeback
{
    public int Id { get; set; }
    public string? AccountId { get; set; }
    public decimal AccountBalance { get; set; }
    public DateTime RefundCreatedDate { get; set; }
    public int ProcessInstanceId { get; set; }
    public bool? Processed { get; set; }
    public string? RefundReasonCode { get; set; }
    public string? DefaultPaymentMethodId { get; set; }
}

namespace Database.Trupanion.Entity.Billing.DataIntegration;

public  class BillingDataIntegrationUpdatedAccountBalance
{
    public int Id { get; set; }
    public string? AccountId { get; set; }
    public decimal AccountBalance { get; set; }
    public DateTime AccountUpdatedDate { get; set; }
    public int ProcessInstanceId { get; set; }
    public bool Processed { get; set; }
    public string? DefaultPaymentMethodId { get; set; }
}

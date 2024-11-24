namespace Database.Trupanion.Entity.Billing.Dbo;

public class BillingDboPartnerConfiguration
{
    public Guid Id { get; set; }
    public string? PaymentGatewayName { get; set; }
    public string? TenantId { get; set; }
}

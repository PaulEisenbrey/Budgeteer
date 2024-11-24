namespace Database.Trupanion.Entity.Billing.Dbo;

public class BillingDboAccountType
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? ExternalId { get; set; }

    public virtual List<BillingDboAccountPolicyholder> AccountPolicyholders { get; set; } = new();
    public virtual List<BillingDboAccount> Accounts { get; set; } = new();
    public virtual List<BillingDboInvoiceTemplate> InvoiceTemplates { get; set; } = new();
}

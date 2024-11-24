namespace Database.Trupanion.Entity.Billing.Dbo;

public class BillingDboInvoiceTemplate
{
    public int Id { get; set; }
    public int AccountTypeId { get; set; }
    public int CountryId { get; set; }
    public string? InvoiceTemplateId { get; set; }
    public string? Currency { get; set; }
    public string? TenantId { get; set; }

    public virtual BillingDboAccountType? AccountType { get; set; }
}

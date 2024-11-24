namespace Database.Trupanion.Entity.Billing.Dbo;

public class BillingDboPaymentMethodType
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public Guid UniqueId { get; set; }
    public bool RequiresSnapshot { get; set; }
    public bool IsNonReferencedCreditSupported { get; set; }

    public virtual List<BillingDboAccount> Accounts { get; set; } = new();
    public virtual List<BillingDboPendingPaymentMethod> PendingPaymentMethods { get; set; } = new();
}

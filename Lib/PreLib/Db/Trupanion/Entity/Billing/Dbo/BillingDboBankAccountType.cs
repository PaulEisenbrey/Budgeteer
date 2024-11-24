namespace Database.Trupanion.Entity.Billing.Dbo;

public class BillingDboBankAccountType
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public Guid UniqueId { get; set; }

    public virtual List<BillingDboBankAccount> BankAccounts { get; set; } = new();
    public virtual List<BillingDboPendingPaymentMethod> PendingPaymentMethods { get; set; } = new();
}

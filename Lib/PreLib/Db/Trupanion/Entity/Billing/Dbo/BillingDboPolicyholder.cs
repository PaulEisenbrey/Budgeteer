namespace Database.Trupanion.Entity.Billing.Dbo;

public class BillingDboPolicyholder
{
    public int Id { get; set; }
    public Guid UniqueId { get; set; }
    public bool LegacySetupFeePaid { get; set; }
}

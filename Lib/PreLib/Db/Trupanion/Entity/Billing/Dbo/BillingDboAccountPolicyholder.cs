namespace Database.Trupanion.Entity.Billing.Dbo;

public class BillingDboAccountPolicyholder
{
    public int Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public int AccountId { get; set; }
    public int PolicyholderId { get; set; }
    public int AccountTypeId { get; set; }
    public Guid PolicyholderUniqueId { get; set; }

    public virtual BillingDboAccount? Account { get; set; }
    public virtual BillingDboAccountType? AccountType { get; set; }
}

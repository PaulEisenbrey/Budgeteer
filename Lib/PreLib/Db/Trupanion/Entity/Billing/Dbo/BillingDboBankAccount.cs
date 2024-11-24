namespace Database.Trupanion.Entity.Billing.Dbo;

public class BillingDboBankAccount
{
    public int Id { get; set; }
    public int? AccountId { get; set; }
    public string? AchAbaCode { get; set; }
    public string? AchAccountName { get; set; }
    public string? AchAccountNumber { get; set; }
    public string? AchAccountNumberLast4 { get; set; }
    public int AchAccountTypeId { get; set; }
    public string? AchBankName { get; set; }
    public string? AchBankCode { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public Guid Uniqueid { get; set; }
    public bool IsPaymentMethod { get; set; }
    public bool IsNonReferencedCreditMethod { get; set; }

    public virtual BillingDboAccount? Account { get; set; }
    public virtual BillingDboBankAccountType? AchAccountType { get; set; }
}

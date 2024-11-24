namespace Database.Trupanion.Entity.Billing.Dbo;

public class BillingDboPaymentMethodSnapshot
{
    public Guid Id { get; set; }
    public string? AccountId { get; set; }
    public string? PaymentMethodId { get; set; }
    public string? Type { get; set; }
    public string? BankCode { get; set; }
    public string? BankName { get; set; }
    public string? BankStreetAddress { get; set; }
    public string? BankCity { get; set; }
    public string? BankPostalCode { get; set; }
    public string? BankTransferAccountName { get; set; }
    public string? BankTransferAccountNumber { get; set; }
    public string? BankTransferAccountNumberLast4 { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? City { get; set; }
    public string? Country { get; set; }
    public string? PostalCode { get; set; }
    public string? State { get; set; }
    public string? StreetAddress { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }

    public virtual BillingDboAccount? Account { get; set; }
}

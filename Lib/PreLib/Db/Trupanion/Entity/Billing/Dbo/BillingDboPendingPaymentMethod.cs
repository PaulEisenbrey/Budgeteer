namespace Database.Trupanion.Entity.Billing.Dbo;

public class BillingDboPendingPaymentMethod
{
    public Guid Id { get; set; }
    public Guid PartyId { get; set; }
    public string? Currency { get; set; }
    public string? BankRoutingNumber { get; set; }
    public string? BankAccountNumber { get; set; }
    public string? BankAccountNumberLast4 { get; set; }
    public Guid? BankAccountTypeId { get; set; }
    public string? BankName { get; set; }
    public Guid PaymentMethodTypeId { get; set; }
    public string? AccountName { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public string? AccountId { get; set; }
    public string? BankCode { get; set; }
    public string? BankStreetAddress { get; set; }
    public string? BankCity { get; set; }
    public string? BankPostalCode { get; set; }
    public string? City { get; set; }
    public string? Country { get; set; }
    public string? PostalCode { get; set; }
    public string? State { get; set; }
    public string? StreetAddress { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public Guid? PartnerId { get; set; }
    public string? TokenId { get; set; }
    public string? SecondTokenId { get; set; }

    public virtual BillingDboBankAccountType? BankAccountType { get; set; }
    public virtual BillingDboPaymentMethodType? PaymentMethodType { get; set; }
}

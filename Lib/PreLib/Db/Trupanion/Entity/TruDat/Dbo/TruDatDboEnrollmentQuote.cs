namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboEnrollmentQuote
{
    public int Id { get; set; }
    public DateTime? ExpirationDate { get; set; }
    public int? OwnerId { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? AlternateFirstName { get; set; }
    public string? AlternateLastName { get; set; }
    public string? EmailAddress { get; set; }
    public string? SecondaryEmailAddress { get; set; }
    public string? HomePhone { get; set; }
    public string? CellPhone { get; set; }
    public string? WorkPhone { get; set; }
    public string? WorkExtension { get; set; }
    public string? FaxNumber { get; set; }
    public string? DefaultPaymentMethodStr { get; set; }
    public string? BillingAddressLine1 { get; set; }
    public string? BillingAddressLine2 { get; set; }
    public string? BillingAddressCity { get; set; }
    public int? BillingAddressStateId { get; set; }
    public string? BillingAddressZipcode { get; set; }
    public string? ShippingAddressLine1 { get; set; }
    public string? ShippingAddressLine2 { get; set; }
    public string? ShippingAddressCity { get; set; }
    public int? ShippingAddressStateId { get; set; }
    public string? ShippingAddressZipcode { get; set; }
    public int? CountryId { get; set; }
    public int? CharityId { get; set; }
    public int? CreditCardTypeId { get; set; }
    public string? CreditCardNumber { get; set; }
    public string? CreditCardNumberLast4 { get; set; }
    public string? CreditCardExpMonth { get; set; }
    public string? CreditCardExpYear { get; set; }
    public string? CreditCardNameOnCard { get; set; }
    public string? BankAccountBankName { get; set; }
    public string? BankAccountBankCode { get; set; }
    public string? BankAccountTransitNumber { get; set; }
    public string? BankAccountAccountNumber { get; set; }
    public string? BankAccountAccountNumberLast4 { get; set; }
    public int? AssociateId { get; set; }
    public int? UserId { get; set; }
    public string? SessionId { get; set; }
    public string? ConfirmSessionId { get; set; }
    public int? EngineVersionId { get; set; }
    public string? CommitError { get; set; }
    public DateTime Inserted { get; set; }
    public string? Password { get; set; }
    public string? BankAccountNameOnAccount { get; set; }
    public DateTime? EnrollEffective { get; set; }
    public int? LeadId { get; set; }
    public string? BankAccountAccountType { get; set; }

    public virtual List<TruDatDboEnrollmentQuotePetPolicy> EnrollmentQuotePetPolicies { get; set; } = new();
}

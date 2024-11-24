namespace Database.Trupanion.Entity.PurchaseProcess.Dbo;

public class PPDboEnrollmentDatum
{
    public int Id { get; set; }
    public Guid ReferenceNumber { get; set; }
    public Guid? VisitorUniqueId { get; set; }
    public int? QuoteId { get; set; }
    public int EnrollmentTypeId { get; set; }
    public int PlatformId { get; set; }
    public Guid? CrmleadId { get; set; }
    public int? LeadPersonId { get; set; }
    public string PolicyNumber { get; set; } = "";
    public int? PolicyHolderId { get; set; }
    public DateTime EnrollEffective { get; set; }
    public DateTime? EnrollQueued { get; set; }
    public DateTime? EnrollProcessingStarted { get; set; }
    public DateTime? EnrollProcessingCompleted { get; set; }
    public int? AssociatedId { get; set; }
    public string? Password { get; set; }
    public int? HowDidYouHearAboutUsId { get; set; }
    public string? HowDidYouHearAboutUsDescription { get; set; }
    public int? CharityId { get; set; }
    public int? AgentUserId { get; set; }
    public bool WaiveAdministrativeFee { get; set; }
    public int? WaiveReasonId { get; set; }
    public int? PaymentMethodId { get; set; }
    public string? CreditCardNumber { get; set; }
    public string? CreditCardLast4 { get; set; }
    public string? CreditCardExpiration { get; set; }
    public string? CreditCardNameOnCard { get; set; }
    public int? CreditCardTypeId { get; set; }
    public string? BankAccountBankName { get; set; }
    public string? BankAccountBankCode { get; set; } = null;
    public string? BankAccountTransitNumber { get; set; }
    public string? BankAccountAccountNumber { get; set; }
    public string? BankAccountAccountNumberLast4 { get; set; }
    public int? BankAccountAccountTypeId { get; set; }
    public string? BankAccountNameOnAccount { get; set; }
    public string? EmailAddress { get; set; }
    public string? PostalCode { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Address { get; set; }
    public string? Address2 { get; set; }
    public string? City { get; set; }
    public int StateId { get; set; }
    public int CountryId { get; set; }
    public string? PrimaryPhone { get; set; }
    public string? SecondaryPhone { get; set; }
    public string? WorkPhone { get; set; }
    public string? WorkPhoneExt { get; set; }
    public string? AlternateFirstName { get; set; }
    public string? AlternameLastName { get; set; }
    public string? EmployeeId { get; set; }
    public string? EmployerId { get; set; }
    public int? MembershipUserId { get; set; }
    public bool Active { get; set; } = true;
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime? ModifiedOn { get; set; }
    public Guid? ModifiedBy { get; set; }
    public DateTime? PolicyCreatedOn { get; set; }
    public DateTime? MembershipCreatedOn { get; set; }
    public string? AmazonBillingAgreementId { get; set; }
    public string? ExternalAccountId { get; set; }
    public DateTime? Effective { get; set; }
    public string? EffectiveDateReason { get; set; }

    public virtual List<PPDboEnrollmentDataAssociation> EnrollmentDataAssociations { get; set; } = new();
    public virtual List<PPDboEnrollmentPetDatum> EnrollmentPetData { get; set; } = new();
    public virtual List<PPDboEnrollmentProcessDatum> EnrollmentProcessData { get; set; } = new();
}

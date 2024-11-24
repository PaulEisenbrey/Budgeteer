namespace Database.Trupanion.Entity.Quote.Dbo;

public class QuoteDboEnrollmentRequest
{
    public Guid Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public Guid? IssuedCertificateId { get; set; }
    public string? PromoCode { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Address1 { get; set; }
    public string? Address2 { get; set; }
    public string? City { get; set; }
    public string? StateCode { get; set; }
    public string? PostalCode { get; set; }
    public string? IsoAlpha3CountryCode { get; set; }
    public string? EmailAddress { get; set; }
    public string? PrimaryPhoneNumber { get; set; }
    public bool PrimaryPhoneNumberIsCell { get; set; }
    public string? AlternatePhoneNumber { get; set; }
    public bool AlternatePhoneNumberIsCell { get; set; }
    public Guid PolicyholderId { get; set; }
    public Guid PolicyId { get; set; }
    public string? PolicyNumber { get; set; }
    public Guid? BrandId { get; set; }
    public Guid? SelectedCharityId { get; set; }
    public Guid? OrganizationId { get; set; }
    public Guid? PaymentMethodId { get; set; }
    public Guid? ReferralUniqueId { get; set; }
    public string? Source { get; set; }
    public bool ElectronicPolicyDocumentsPreferred { get; set; }
    public bool SmsCertReminderOptedIn { get; set; }
    public bool SmsMemberCommunicationsOptedIn { get; set; }
    public string? LanguagePreference { get; set; }
    public Guid RequestTypeId { get; set; }
    public string? Password { get; set; }
    public string? Salt { get; set; }
    public string? Partner { get; set; }
    public Guid? AssociateUniqueId { get; set; }
    public string? ReferralOther { get; set; }

    public virtual QuoteDboEnrollmentRequestType? RequestType { get; set; }
    public virtual List<QuoteDboEnrollmentPolicyholderCharacteristic> EnrollmentPolicyholderCharacteristics { get; set; } = new();
    public virtual List<QuoteDboEnrollmentRequestAttribution> EnrollmentRequestAttributions { get; set; } = new();
    public virtual List<QuoteDboEnrollmentRequestFee> EnrollmentRequestFees { get; set; } = new();
    public virtual List<QuoteDboEnrollmentRequestPet> EnrollmentRequestPets { get; set; } = new();
}

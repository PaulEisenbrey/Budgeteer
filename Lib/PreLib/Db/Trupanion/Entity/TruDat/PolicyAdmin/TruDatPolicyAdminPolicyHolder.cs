namespace Database.Trupanion.Entity.TruDat.PolicyAdmin;

public class TruDatPolicyAdminPolicyHolder
{
    public Guid Id { get; set; }
    public DateTime? CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime? ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public Guid? BrandId { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? EmailAddress { get; set; }
    public string? PrimaryPhoneNumber { get; set; }
    public string? AlternatePhoneNumber { get; set; }
    public bool? ElectronicPolicyDocumentsPreferred { get; set; }
    public string? IsoAlpha3CountryCode { get; set; }
    public string? PostalCode { get; set; }
    public string? StateCode { get; set; }
    public string? Address1 { get; set; }
    public string? Address2 { get; set; }
    public string? City { get; set; }
    public string? LanguagePreference { get; set; }
    public string? Characteristics { get; set; }
    public DateTime? PrivacyPolicyNotificationDate { get; set; }
    public Guid? UserId { get; set; }
}

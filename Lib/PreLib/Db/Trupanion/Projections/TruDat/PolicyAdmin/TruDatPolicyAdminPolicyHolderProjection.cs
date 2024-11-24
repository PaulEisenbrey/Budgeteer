namespace Database.Trupanion.Projections.TruDat.PolicyAdmin;

public class TruDatPolicyAdminPolicyHolderProjection
{
    public Guid Id { get; set; }
    public Guid? BrandId { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? EmailAddress { get; set; }
    public string? PrimaryPhoneNumber { get; set; }
    public string? AlternatePhoneNumber { get; set; }
    public bool? ElectronicPolicyDocumentsPreferred { get; set; }
    public string? IsoAlpha3CountryCode { get; set; }
    public string? LanguagePreference { get; set; }
    public string? Characteristics { get; set; }
    public DateTime? PrivacyPolicyNotificationDate { get; set; }
    public Guid? UserId { get; set; }
}
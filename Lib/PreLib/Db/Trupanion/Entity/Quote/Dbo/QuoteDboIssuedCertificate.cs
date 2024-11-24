namespace Database.Trupanion.Entity.Quote.Dbo;

public class QuoteDboIssuedCertificate
{
    public Guid Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public string? Source { get; set; }
    public Guid? HospitalUniqueId { get; set; }
    public Guid? OrganizationId { get; set; }
    public DateTime IssueDate { get; set; }
    public DateTime? ActivationDate { get; set; }
    public DateTime ExpirationDate { get; set; }
    public string? PetName { get; set; }
    public DateTime? PetDateOfBirth { get; set; }
    public string? PetSpecies { get; set; }
    public string? PetGender { get; set; }
    public Guid? BreedPetCharacteristicId { get; set; }
    public Guid? AgeBandPetCharacteristicId { get; set; }
    public bool? IsSpayedOrNeutered { get; set; }
    public DateTime? PetExamDate { get; set; }
    public DateTime? PetAdoptionDate { get; set; }
    public Guid? PetPolicyId { get; set; }
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
    public string? PromoCode { get; set; }
    public Guid? AssociateUniqueId { get; set; }
    public bool? TruExHospitalEdoTextRequest { get; set; }
    public Guid IssuedCertificateTypeId { get; set; }
    public Guid? BreederId { get; set; }
    public string? SignedBy { get; set; }
    public string? AttendingDvm { get; set; }
    public string? PatientId { get; set; }

    public virtual QuoteDboIssuedCertificateType? IssuedCertificateType { get; set; }
    public virtual List<QuoteDboIssuedCertificateAttribution> IssuedCertificateAttributions { get; set; } = new();
}

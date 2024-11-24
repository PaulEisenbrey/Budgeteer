namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboClinic
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool Validated { get; set; }
    public string? ContactName { get; set; }
    public string? ContactTitle { get; set; }
    public string? EmailAddress { get; set; }
    public string? Url { get; set; }
    public string? AddressLine2 { get; set; }
    public string? AddressLine3 { get; set; }
    public string? City { get; set; }
    public int? StateId { get; set; }
    public string? Zipcode { get; set; }
    public string? Phone { get; set; }
    public string? Fax { get; set; }
    public int? Rating { get; set; }
    public bool? Active { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public string? SalesForceId { get; set; }
    public int? ChangeUserId { get; set; }
    public int PreferredContactMethodId { get; set; }
    public string? Description { get; set; }
    public int? EnrolledPolicyCount { get; set; }
    public int ClinicRiskId { get; set; }
    public int? DefaultPaymentMethodId { get; set; }
    public bool? Pilot { get; set; }
    public bool EarlyDataCollection { get; set; }
    public DateTime? PaymentFailedDate { get; set; }
    public int? PartnerId { get; set; }
    public Guid UniqueId { get; set; }
    public bool? VetDirectPayBlacklist { get; set; }
    public DateTime? AddressLastVerified { get; set; }
    public Guid? CrmownerId { get; set; }
    public byte[]? ConcurrencyToken { get; set; }
    public string? AddressValidationErrorMessage { get; set; }
    public int? CareFlag { get; set; }

    public virtual TruDatDboClinicRisk? ClinicRisk { get; set; }
    public virtual TruDatDboPartner? Partner { get; set; }
    public virtual TruDatDboContactMethod? PreferredContactMethod { get; set; }
    public virtual TruDatDboState? State { get; set; }
    public virtual List<TruDatDboClaimClinic> ClaimClinics { get; set; } = new();
    public virtual List<TruDatDboClinicAttribute> ClinicAttributes { get; set; } = new();
    public virtual List<TruDatDboClinicPartner> ClinicPartners { get; set; } = new();
    public virtual List<TruDatDboPetPolicyClinic> PetPolicyClinics { get; set; } = new();
}

namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboPartner
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? EmailAddress { get; set; }
    public string? AddressLine2 { get; set; }
    public string? AddressLine3 { get; set; }
    public string? City { get; set; }
    public int? StateId { get; set; }
    public string? Zipcode { get; set; }
    public string? ContactMethod { get; set; }
    public string? HomePhone { get; set; }
    public string? WorkPhone { get; set; }
    public string? CellPhone { get; set; }
    public string? ExperienceWithPets { get; set; }
    public string? SalesExperience { get; set; }
    public string? HeardAboutUsFrom { get; set; }
    public bool? Active { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public string? SalesForceId { get; set; }
    public int? UserId { get; set; }
    public byte[]? Picture { get; set; }
    public int? CategoryId { get; set; }

    public virtual TruDatDboEntityCategory? Category { get; set; }
    public virtual TruDatDboState? State { get; set; }
    public virtual List<TruDatDboClinicPartner> ClinicPartners { get; set; } = new();
    public virtual List<TruDatDboClinic> Clinics { get; set; } = new();
    public virtual List<TruDatDboPartnerZipcode> PartnerZipcodes { get; set; } = new();
    public virtual List<TruDatDboPetPolicyPartner> PetPolicyPartners { get; set; } = new();
}

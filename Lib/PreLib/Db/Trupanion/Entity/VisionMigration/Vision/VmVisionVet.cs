namespace Database.Trupanion.Entity.VisionMigration.Vision;

public class VmVisionVet
{
    public int Id { get; set; }
    public Guid UniqueId { get; set; }
    public string? PracticeName { get; set; }
    public string? Address1 { get; set; }
    public string? Address2 { get; set; }
    public string? City { get; set; }
    public string? PostalCode { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public bool Active { get; set; }
    public bool Validated { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public string? StateCode { get; set; }
    public string? IsoAlpha2CountryCode { get; set; }
    public int? VisionId { get; set; }
    public string? ContactName { get; set; }
    public string? Fax { get; set; }
    public int? ClaimPaymentMethod { get; set; }
    public int? PreferredContactMethod { get; set; }
    public string? PreferredLanguageCode { get; set; }
    public bool? VetDirectPay { get; set; }
    public long? Version { get; set; }
    public int? CareFlag { get; set; }
}

namespace Database.Trupanion.Entity.VisionMigration.Quote;

public class VmQuoteVet
{
    public int Id { get; set; }
    public Guid? VetCode { get; set; }
    public string? PracticeName { get; set; }
    public string? Address1 { get; set; }
    public string? Address2 { get; set; }
    public string? Address3 { get; set; }
    public string? TownCity { get; set; }
    public string? RegionCounty { get; set; }
    public string? Country { get; set; }
    public string? PostalCode { get; set; }
    public string? ExternalRef { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public int CountryId { get; set; }
    public int CustomerId { get; set; }
    public int PetPolicyId { get; set; }
}

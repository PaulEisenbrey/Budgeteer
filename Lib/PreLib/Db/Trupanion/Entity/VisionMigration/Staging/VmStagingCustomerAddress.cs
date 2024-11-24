namespace Database.Trupanion.Entity.VisionMigration.Staging;

public class VmStagingCustomerAddress
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public string? Address1 { get; set; }
    public string? Address2 { get; set; }
    public string? TownCity { get; set; }
    public string? RegionCounty { get; set; }
    public string? PostalCode { get; set; }
    public string? Country { get; set; }
    public int AddressType { get; set; }
    public string? Address3 { get; set; }
    public int ExtRef { get; set; }
    public int OwnerId { get; set; }
    public Guid BatchId { get; set; }
}

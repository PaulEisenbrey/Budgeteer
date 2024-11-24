namespace Database.Trupanion.Entity.VisionMigration.DataMap;

public class VmDataMapProductVersionToProductCode
{
    public Guid ProductId { get; set; }
    public string? ProductVersionNumber { get; set; }
    public string? VisionProductCode { get; set; }
    public string? Info { get; set; }
    public int CountryId { get; set; }
}

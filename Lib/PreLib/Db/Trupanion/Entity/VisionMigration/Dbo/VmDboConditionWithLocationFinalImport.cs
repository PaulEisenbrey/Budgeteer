namespace Database.Trupanion.Entity.VisionMigration.Dbo;

public class VmDboConditionWithLocationFinalImport
{
    public short LegacyCondId { get; set; }
    public string? LegacyCond { get; set; }
    public string? LegacyLoc { get; set; }
    public short LegacyLocId { get; set; }
    public bool ParentLocation { get; set; }
    public int VenomId { get; set; }
    public string? VenomCode { get; set; }
}

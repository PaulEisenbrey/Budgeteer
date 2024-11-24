namespace Database.Trupanion.Entity.VisionMigration.DataMap;

public class VmDataMapConditionAilmentMap
{
    public int ConditionId { get; set; }
    public int ConditionTypeId { get; set; }
    public string? ConditionName { get; set; }
    public string? VenOmCode { get; set; }
    public int VenomId { get; set; }
    public int AilmentId { get; set; }
    public string? FirstCause { get; set; }
}

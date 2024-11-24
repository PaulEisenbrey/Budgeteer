namespace Database.Trupanion.Entity.VisionMigration.Dbo;

public class VmDboSegmentType
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public virtual List<VmDboJobType> JobTypes { get; set; } = new();
    public virtual List<VmDboSegmentSelectionScript> SegmentSelectionScripts { get; set; } = new();
    public virtual List<VmDboSegment> Segments { get; set; } = new();
}

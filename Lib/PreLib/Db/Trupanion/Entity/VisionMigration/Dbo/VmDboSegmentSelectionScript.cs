namespace Database.Trupanion.Entity.VisionMigration.Dbo;

public class VmDboSegmentSelectionScript
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? ScriptText { get; set; }
    public int SegmentTypeId { get; set; }
    public DateTime CreatedOn { get; set; }
    public DateTime ModifiedOn { get; set; }

    public virtual VmDboSegmentType? SegmentType { get; set; }
    public virtual List<VmDboSegment> Segments { get; set; } = new();
}

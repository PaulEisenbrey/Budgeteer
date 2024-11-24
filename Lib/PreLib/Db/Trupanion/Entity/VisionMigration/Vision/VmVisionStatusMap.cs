namespace Database.Trupanion.Entity.VisionMigration.Vision;

public class VmVisionStatusMap
{
    public int StatusId { get; set; }
    public int? ParentId { get; set; }
    public string? StatusBreadCrumb { get; set; }
    public int VisionStatusId { get; set; }
    public string? VisionCrumb { get; set; }
}

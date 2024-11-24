namespace Database.Trupanion.Entity.VisionMigration.DataMap;

public class VmDataMapContentItemToVisionFile
{
    public int Id { get; set; }
    public int ContentItemId { get; set; }
    public int FileMetadataId { get; set; }
    public string? FileName { get; set; }
}

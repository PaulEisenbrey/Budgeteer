namespace Database.Trupanion.Entity.VisionMigration.DataMap;

public class VmDataMapEmailRequestToVisionFile
{
    public int Id { get; set; }
    public int EmailRequestId { get; set; }
    public int FileMetadataId { get; set; }
    public string? FileName { get; set; }
}

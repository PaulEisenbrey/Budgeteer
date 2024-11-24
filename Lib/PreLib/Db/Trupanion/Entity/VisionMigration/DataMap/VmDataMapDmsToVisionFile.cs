namespace Database.Trupanion.Entity.VisionMigration.DataMap;

public class VmDataMapDmsToVisionFile
{
    public int Id { get; set; }
    public string? DmsDocumentId { get; set; }
    public int? FileMetadataId { get; set; }
    public string? FileName { get; set; }
    public string? AdditionalInfo { get; set; }
}

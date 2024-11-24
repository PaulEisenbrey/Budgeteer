namespace Database.Trupanion.Entity.VisionMigration.Staging;

public class VmStagingCoverageSummary
{
    public DateTime? ActionDateTime { get; set; }
    public Guid? UserId { get; set; }
    public int PetId { get; set; }
    public string? SearchField { get; set; }
    public string? FileName { get; set; }
    public string? Value { get; set; }
    public string? ExtRef { get; set; }
    public int OwnerId { get; set; }
}

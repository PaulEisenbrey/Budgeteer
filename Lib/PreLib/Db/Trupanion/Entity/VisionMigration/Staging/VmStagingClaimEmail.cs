namespace Database.Trupanion.Entity.VisionMigration.Staging;

public class VmStagingClaimEmail
{
    public int? ClaimId { get; set; }
    public int ActionType { get; set; }
    public DateTime? ActionDateTime { get; set; }
    public Guid UserId { get; set; }
    public string? Value { get; set; }
    public int? OwnerId { get; set; }
    public string? SearchField { get; set; }
    public int AttachmentEmailId { get; set; }
}

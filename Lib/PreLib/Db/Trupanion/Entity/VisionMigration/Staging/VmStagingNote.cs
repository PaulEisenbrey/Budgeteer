namespace Database.Trupanion.Entity.VisionMigration.Staging;

public class VmStagingNote
{
    public int Id { get; set; }
    public int Type { get; set; }
    public DateTimeOffset? CreatedDateTime { get; set; }
    public Guid CreatedById { get; set; }
    public int? PetId { get; set; }
    public int? CustomerId { get; set; }
    public int? ClaimId { get; set; }
    public string? Details { get; set; }
    public string? Title { get; set; }
    public int ContainsEmail { get; set; }
    public Guid? BatchId { get; set; }
}

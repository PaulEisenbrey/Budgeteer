namespace Database.TestData.VisionMigrationClaims;

public class VMClaimsVisionClaimSyncQueue
{
    public int Id { get; set; }
    public int Priority { get; set; }
    public DateTime QueuedOn { get; set; }
    public int Id1 { get; set; }
    public int PetId { get; set; }
    public string? CustomerPayload { get; set; }
    public string? PetPayload { get; set; }
    public string? PaymentPayload { get; set; }
    public int SegmentId { get; set; }
}

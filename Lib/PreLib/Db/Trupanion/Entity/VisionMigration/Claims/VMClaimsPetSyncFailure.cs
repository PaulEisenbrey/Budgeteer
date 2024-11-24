namespace Database.TestData.VisionMigrationClaims;

public class VMClaimsPetSyncFailure
{
    public int PetId { get; set; }
    public int OwnerId { get; set; }
    public bool IsTransient { get; set; }
    public int SubsequentFailureCount { get; set; }
    public string? ErrorContext { get; set; }
    public DateTime CreatedOn { get; set; }
    public DateTime ModifiedOn { get; set; }
    public string? ErrorMessage { get; set; }
    public bool? MarkForRetry { get; set; }
    public int RetryCount { get; set; }
    public string? Payload { get; set; }
    public string? Notes { get; set; }
    public int SegmentId { get; set; }
}

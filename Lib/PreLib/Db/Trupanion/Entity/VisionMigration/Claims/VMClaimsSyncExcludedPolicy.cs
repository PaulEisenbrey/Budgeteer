namespace Database.TestData.VisionMigrationClaims;

public class VMClaimsSyncExcludedPolicy
{
    public string? PolicyNumber { get; set; }
    public string? Reason { get; set; }
    public int OwnerId { get; set; }
    public int ChangeUserId { get; set; }
    public DateTime CreatedOn { get; set; }
}

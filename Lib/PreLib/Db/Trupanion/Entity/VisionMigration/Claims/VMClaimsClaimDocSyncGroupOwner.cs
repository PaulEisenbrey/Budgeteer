namespace Database.TestData.VisionMigrationClaims;

public class VMClaimsClaimDocSyncGroupOwner
{
    public int OwnerId { get; set; }
    public int GroupId { get; set; }
    public int? InSync { get; set; }

    public virtual VMClaimsClaimDocSyncGroup? Group { get; set; }
}

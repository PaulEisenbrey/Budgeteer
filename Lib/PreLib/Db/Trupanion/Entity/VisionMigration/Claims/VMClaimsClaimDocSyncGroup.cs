namespace Database.TestData.VisionMigrationClaims;

public class VMClaimsClaimDocSyncGroup
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool Active { get; set; }

    public virtual List<VMClaimsClaimDocSyncGroupOwner> ClaimDocSyncGroupOwners { get; set; } = new();
}

namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboOwnerVisionPolicyMigrationStatus
{
    public int OwnerId { get; set; }
    public int MigrationStatusId { get; set; }
    public DateTime MigrationTimeStamp { get; set; }
    public string? SerializedOutput { get; set; }

    public virtual TruDatDboOwner? Owner { get; set; }
}

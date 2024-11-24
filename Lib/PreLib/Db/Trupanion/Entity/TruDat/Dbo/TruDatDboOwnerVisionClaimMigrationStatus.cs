namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboOwnerVisionClaimMigrationStatus
{
    public Guid Id { get; set; }
    public int OwnerId { get; set; }
    public int MigrationStatusId { get; set; }
    public DateTime MigrationTimeStamp { get; set; }
    public string? SerializedOutput { get; set; }
    public int? VisionCustomerId { get; set; }

    public virtual TruDatDboOwner? Owner { get; set; }
}

namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboOwnerVisionClaimSyncStatus
{
    public int OwnerId { get; set; }
    public int StatusId { get; set; }

    public virtual TruDatDboOwner? Owner { get; set; }
}

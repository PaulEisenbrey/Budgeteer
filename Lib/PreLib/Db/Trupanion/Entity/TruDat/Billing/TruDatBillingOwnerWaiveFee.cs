namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatBillingOwnerWaiveFee
{
    public int OwnerId { get; set; }
    public DateTime Inserted { get; set; }
    public int? ChangeUserId { get; set; }
    public int? ReasonId { get; set; }
}

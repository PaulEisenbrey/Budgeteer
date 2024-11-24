namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatBillingBillingDateChangeLog
{
    public int Id { get; set; }
    public int OwnerId { get; set; }
    public DateTime ChangeDate { get; set; }
    public int FromBillingDoM { get; set; }
    public int ToBillingDoM { get; set; }
    public int ProrateOrderId { get; set; }
}

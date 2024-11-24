namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatBillingSetUpFee
{
    public int OwnerId { get; set; }
    public decimal? Fee { get; set; }
    public int? OrderId { get; set; }
    public decimal? WebDiscount { get; set; }
    public decimal? Csrdiscount { get; set; }
}

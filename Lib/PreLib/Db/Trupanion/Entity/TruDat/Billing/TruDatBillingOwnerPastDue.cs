namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatBillingOwnerPastDue
{
    public int OwnerId { get; set; }
    public DateTime? BillingDate { get; set; }
    public decimal? AmountDue { get; set; }
}

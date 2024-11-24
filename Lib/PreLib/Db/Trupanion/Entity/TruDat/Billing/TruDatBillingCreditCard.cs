namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatBillingCreditCard
{
    public int OwnerId { get; set; }
    public string? Ccname { get; set; }
    public string? Ccnumber { get; set; }
    public string? CcnumberLast4 { get; set; }
    public string? Ccexpiration { get; set; }
    public string? Cctype { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public int? ChangeUserId { get; set; }
    public bool Canceled { get; set; }
    public string? NextExpiration { get; set; }
    public bool SkipUpdate { get; set; }
}

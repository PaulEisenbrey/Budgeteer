namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatBillingCorporateCard
{
    public int CorporateAccountId { get; set; }
    public string? Ccname { get; set; }
    public string? Ccnumber { get; set; }
    public string? CcnumberLast4 { get; set; }
    public string? Ccexpiration { get; set; }
    public string? Cctype { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public int? ChangeUserId { get; set; }
}

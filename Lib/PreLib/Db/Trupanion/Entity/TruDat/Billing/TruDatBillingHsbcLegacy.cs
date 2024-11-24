namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatBillingHsbcLegacy
{
    public int OwnerId { get; set; }
    public string? BankName { get; set; }
    public string? TransitNumber { get; set; }
    public string? BankCode { get; set; }
    public string? AccountNumber { get; set; }
    public string? AccountNumberLast4 { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public int? ChangeUserId { get; set; }
    public string? NameOnAccount { get; set; }
    public string? AccountType { get; set; }
}

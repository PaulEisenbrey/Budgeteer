namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboCorporateAccountVoucher
{
    public int Id { get; set; }
    public int? CorporateAccountId { get; set; }
    public string? CorporateAccountName { get; set; }
    public int? VoucherId { get; set; }
    public string? CampaignCode { get; set; }
    public DateTime? Inserted { get; set; }
    public int? GroupBenefitsAccountId { get; set; }
    public DateTime? PolicyInceptionDate { get; set; }
    public bool Active { get; set; }
    public bool IsDefaultPromo { get; set; }
    public DateTime? PolicyCancelationDate { get; set; }
}

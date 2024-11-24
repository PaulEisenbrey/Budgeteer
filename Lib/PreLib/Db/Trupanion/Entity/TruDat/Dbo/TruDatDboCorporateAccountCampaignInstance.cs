namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboCorporateAccountCampaignInstance
{
    public int Id { get; set; }
    public int? CorporateAccountId { get; set; }
    public int? PromoCampaignInstanceId { get; set; }
    public DateTime? Inserted { get; set; }
    public bool IsDefaultPromo { get; set; }

    public virtual TruDatDboCorporateAccount? CorporateAccount { get; set; }
}

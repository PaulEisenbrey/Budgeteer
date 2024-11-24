namespace Database.Trupanion.Entity.TruDat.Promo;

public class TruDatPromoCampaignInstanceConfiguration
{
    public int Id { get; set; }
    public int CampaignInstanceId { get; set; }
    public int ConfigId { get; set; }
    public string? ConfigString { get; set; }
    public int? ConfigInt { get; set; }
    public long? ConfigBigInt { get; set; }
    public bool? ConfigBit { get; set; }
    public double? ConfigFloat { get; set; }
    public DateTime? ConfigDate { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public int? ChangeUserId { get; set; }

    public virtual TruDatPromoCampaignInstance? CampaignInstance { get; set; }
    public virtual TruDatPromoConfiguration? Config { get; set; }
}

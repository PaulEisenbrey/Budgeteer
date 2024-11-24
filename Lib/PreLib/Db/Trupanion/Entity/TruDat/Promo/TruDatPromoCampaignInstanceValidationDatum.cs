namespace Database.Trupanion.Entity.TruDat.Promo;

public class TruDatPromoCampaignInstanceValidationDatum
{
    public int Id { get; set; }
    public int CampaignInstanceId { get; set; }
    public int ValidationId { get; set; }
    public int ValidationDataId { get; set; }
    public string? ValidationString { get; set; }
    public int? ValidationInt { get; set; }
    public long? ValidationBigInt { get; set; }
    public bool? ValidationBit { get; set; }
    public double? ValidationFloat { get; set; }
    public DateTime? ValidationDate { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public int? ChangeUserId { get; set; }

    public virtual TruDatPromoCampaignInstance? CampaignInstance { get; set; }
    public virtual TruDatPromoValidation? Validation { get; set; }
    public virtual TruDatPromoValidationDatum? ValidationData { get; set; }
}

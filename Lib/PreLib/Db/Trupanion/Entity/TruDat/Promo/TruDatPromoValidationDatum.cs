namespace Database.Trupanion.Entity.TruDat.Promo;

public class TruDatPromoValidationDatum
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public DateTime Inserted { get; set; }
    public int DataTypeId { get; set; }

    public virtual List<TruDatPromoCampaignInstanceValidationDatum> CampaignInstanceValidationData { get; set; } = new();
    public virtual List<TruDatPromoValidationRequiredDatum> ValidationRequiredData { get; set; } = new();
}

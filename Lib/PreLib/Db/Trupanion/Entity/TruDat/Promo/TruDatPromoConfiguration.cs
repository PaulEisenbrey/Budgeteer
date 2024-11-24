namespace Database.Trupanion.Entity.TruDat.Promo;

public class TruDatPromoConfiguration
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public DateTime Inserted { get; set; }
    public int DataTypeId { get; set; }

    public virtual List<TruDatPromoCampaignInstanceConfiguration> CampaignInstanceConfigurations { get; set; } = new();
}

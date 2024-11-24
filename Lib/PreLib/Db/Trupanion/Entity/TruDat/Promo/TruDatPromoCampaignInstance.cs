namespace Database.Trupanion.Entity.TruDat.Promo;

public class TruDatPromoCampaignInstance
{
    public int Id { get; set; }
    public int CampaignId { get; set; }
    public string? CampaignCode { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public bool? Active { get; set; }
    public int? ChangeUserId { get; set; }

    public virtual TruDatPromoCampaign? Campaign { get; set; }
    public virtual TruDatPromoCampaignInstanceEffectTrial? CampaignInstanceEffectTrial { get; set; }
    public virtual TruDatPromoCampaignInstanceEffectWp? CampaignInstanceEffectWp { get; set; }
    public virtual List<TruDatPromoCampaignInstanceAssociation> CampaignInstanceAssociations { get; set; } = new();
    public virtual List<TruDatPromoCampaignInstanceCategory> CampaignInstanceCategories { get; set; } = new();
    public virtual List<TruDatPromoCampaignInstanceConfiguration> CampaignInstanceConfigurations { get; set; } = new();
    public virtual List<TruDatPromoCampaignInstanceEffectDiscount> CampaignInstanceEffectDiscounts { get; set; } = new();
    public virtual List<TruDatPromoCampaignInstanceValidationDatum> CampaignInstanceValidationData { get; set; } = new();
    public virtual List<TruDatPromoCampaignInstanceValidation> CampaignInstanceValidations { get; set; } = new();
}

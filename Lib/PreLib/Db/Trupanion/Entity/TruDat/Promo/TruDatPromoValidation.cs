namespace Database.Trupanion.Entity.TruDat.Promo;

public class TruDatPromoValidation
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool IsFinalValidation { get; set; }
    public string? Description { get; set; }
    public string? IobjectValidationImplClass { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public int? ChangeUserId { get; set; }

    public virtual List<TruDatPromoCampaignInstanceValidationDatum> CampaignInstanceValidationData { get; set; } = new();
    public virtual List<TruDatPromoCampaignInstanceValidation> CampaignInstanceValidations { get; set; } = new();
    public virtual List<TruDatPromoValidationRequiredDatum> ValidationRequiredData { get; set; } = new();
}

namespace Database.Trupanion.Entity.TruDat.Promo;

public class TruDatPromoValidationRequiredDatum
{
    public int Id { get; set; }
    public int ValidationId { get; set; }
    public int ValidationDataId { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public int? ChangeUserId { get; set; }

    public virtual TruDatPromoValidation? Validation { get; set; }
    public virtual TruDatPromoValidationDatum? ValidationData { get; set; }
}

namespace Database.Trupanion.Entity.Product.Pricing;

public class ProductPricingFormulaPriceFactorLink
{
    public Guid Id { get; set; }
    public Guid PriceFactorId { get; set; }
    public Guid FormulaId { get; set; }

    public virtual ProductPricingFormula? Formula { get; set; }
    public virtual ProductPricingPriceFactor? PriceFactor { get; set; }
}

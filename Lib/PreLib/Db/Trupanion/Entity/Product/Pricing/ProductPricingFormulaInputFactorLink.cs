namespace Database.Trupanion.Entity.Product.Pricing;

public class ProductPricingFormulaInputFactorLink
{
    public Guid Id { get; set; }
    public Guid FactorId { get; set; }
    public Guid FormulaId { get; set; }

    public virtual ProductPricingInputFactor? Factor { get; set; }
    public virtual ProductPricingFormula? Formula { get; set; }
}

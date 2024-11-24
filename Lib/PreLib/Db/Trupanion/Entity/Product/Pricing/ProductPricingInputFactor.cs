namespace Database.Trupanion.Entity.Product.Pricing;

public class ProductPricingInputFactor
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }

    public virtual List<ProductPricingFormulaInputFactorLink> FormulaInputFactorLinks { get; set; } = new();
}

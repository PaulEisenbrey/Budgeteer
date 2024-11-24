namespace Database.Trupanion.Entity.Product.Pricing;

public class ProductPricingPriceFactor
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public decimal? DefaultValue { get; set; }
    public bool IsCompound { get; set; }

    public virtual List<ProductPricingFormulaPriceFactorLink> FormulaPriceFactorLinks { get; set; } = new();
    public virtual List<ProductPricingPriceFactorArgSet> PriceFactorArgSets { get; set; } = new();
    public virtual List<ProductPricingPriceFactorProductFactorLink> PriceFactorProductFactorLinks { get; set; } = new();
}

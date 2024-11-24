namespace Database.Trupanion.Entity.Product.Pricing;

public class ProductPricingPriceFactorArgSet
{
    public Guid Id { get; set; }
    public Guid PriceFactorId { get; set; }
    public byte[]? Hash { get; set; }

    public virtual ProductPricingPriceFactor? PriceFactor { get; set; }
    public virtual List<ProductPricingPriceFactorArgSetProductFactorInstanceLink> PriceFactorArgSetProductFactorInstanceLinks { get; set; } = new();
    public virtual List<ProductPricingPriceFactorValue> PriceFactorValues { get; set; } = new();
}

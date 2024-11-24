namespace Database.Trupanion.Entity.Product.Pricing;

public class ProductPricingPriceFactorArgSetProductFactorInstanceLink
{
    public Guid Id { get; set; }
    public Guid PriceFactorArgSetId { get; set; }
    public Guid ProductFactorInstanceId { get; set; }

    public virtual ProductPricingPriceFactorArgSet? PriceFactorArgSet { get; set; }
}

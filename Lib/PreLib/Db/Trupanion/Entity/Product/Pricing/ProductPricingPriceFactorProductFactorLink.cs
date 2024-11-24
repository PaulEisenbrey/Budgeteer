namespace Database.Trupanion.Entity.Product.Pricing;

public class ProductPricingPriceFactorProductFactorLink
{
    public Guid Id { get; set; }
    public Guid PriceFactorId { get; set; }
    public Guid ProductFactorId { get; set; }
    public bool? IsOptional { get; set; }

    public virtual ProductPricingPriceFactor? PriceFactor { get; set; }
}

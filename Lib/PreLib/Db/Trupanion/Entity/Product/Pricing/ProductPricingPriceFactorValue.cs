namespace Database.Trupanion.Entity.Product.Pricing;

public class ProductPricingPriceFactorValue
{
    public Guid Id { get; set; }
    public decimal Value { get; set; }
    public Guid ArgsId { get; set; }
    public Guid PriceEngineId { get; set; }
    public string? Metadata { get; set; }

    public virtual ProductPricingPriceFactorArgSet? Args { get; set; }
    public virtual ProductPricingPriceEngine? PriceEngine { get; set; }
}

namespace Database.Trupanion.Entity.Product.Pricing;

public class ProductPricingPriceEngine
{
    public Guid Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public string? Name { get; set; }
    public Guid FormulaId { get; set; }

    public virtual ProductPricingFormula? Formula { get; set; }
    public virtual List<ProductPricingPriceEngineArtifact> PriceEngineArtifacts { get; set; } = new();
    public virtual List<ProductPricingPriceFactorValue> PriceFactorValues { get; set; } = new();
    public virtual List<ProductPricingTestCase> TestCases { get; set; } = new();
}

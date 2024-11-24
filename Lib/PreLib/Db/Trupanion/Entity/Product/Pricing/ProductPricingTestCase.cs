namespace Database.Trupanion.Entity.Product.Pricing;

public class ProductPricingTestCase
{
    public Guid Id { get; set; }
    public decimal ExpectedValue { get; set; }
    public string? ProductFactorInstances { get; set; }
    public string? SelectedEndorsements { get; set; }
    public Guid PriceEngineId { get; set; }
    public string? InputFactors { get; set; }
    public int RowNumber { get; set; }

    public virtual ProductPricingPriceEngine? PriceEngine { get; set; }
    public virtual List<ProductPricingTestCaseResult> TestCaseResults { get; set; } = new();
}

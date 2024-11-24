namespace Database.Trupanion.Entity.Product.Pricing;

public class ProductPricingTestCaseResult
{
    public Guid Id { get; set; }
    public decimal ResultValue { get; set; }
    public DateTime TestExecutedOn { get; set; }
    public int Duration { get; set; }
    public bool Success { get; set; }
    public string? Diagnostics { get; set; }
    public Guid TestCaseId { get; set; }

    public virtual ProductPricingTestCase? TestCase { get; set; }
}

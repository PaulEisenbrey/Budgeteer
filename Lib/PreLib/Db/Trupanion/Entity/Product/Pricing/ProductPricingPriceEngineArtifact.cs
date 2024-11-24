namespace Database.Trupanion.Entity.Product.Pricing;

public class ProductPricingPriceEngineArtifact
{
    public Guid Id { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public Guid ModifiedBy { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public Guid PriceEngineId { get; set; }
    public string? FileName { get; set; }
    public byte[]? FileData { get; set; }

    public virtual ProductPricingPriceEngine? PriceEngine { get; set; }
}

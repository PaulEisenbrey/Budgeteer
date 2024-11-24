namespace Database.Trupanion.Entity.Product.Dbo;

public class ProductDboRelatedCoverageType
{
    public ProductDboRelatedCoverageType()
    {
        RelatedCoverages = new HashSet<ProductDboRelatedCoverage>();
    }

    public Guid Id { get; set; }
    public string? Name { get; set; }

    public virtual ICollection<ProductDboRelatedCoverage> RelatedCoverages { get; set; }
}

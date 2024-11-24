namespace Database.Trupanion.Entity.Product.Dbo;

public class ProductDboCoverageEffect
{
    public ProductDboCoverageEffect()
    {
        Coverages = new HashSet<ProductDboCoverage>();
    }

    public Guid Id { get; set; }
    public string? Name { get; set; }

    public virtual ICollection<ProductDboCoverage> Coverages { get; set; }
}

namespace Database.Trupanion.Entity.Product.Dbo;

public class ProductDboUnderwriter
{
    public ProductDboUnderwriter()
    {
        ProductVersions = new HashSet<ProductDboProductVersion>();
    }

    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? IsoAlpha3CountryCode { get; set; }

    public virtual ICollection<ProductDboProductVersion> ProductVersions { get; set; }
}

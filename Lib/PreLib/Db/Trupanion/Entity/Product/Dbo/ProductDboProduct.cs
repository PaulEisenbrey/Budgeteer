namespace Database.Trupanion.Entity.Product.Dbo;

public class ProductDboProduct
{
    public Guid Id { get; set; }
    public Guid BrandId { get; set; }
    public string? Name { get; set; }

    public virtual ProductDboBrand? Brand { get; set; }
    public virtual List<ProductDboProductCertificateIssuingOrganizationType> ProductCertificateIssuingOrganizationTypes { get; set; } = new();
    public virtual List<ProductDboProductVersion> ProductVersions { get; set; } = new();
}

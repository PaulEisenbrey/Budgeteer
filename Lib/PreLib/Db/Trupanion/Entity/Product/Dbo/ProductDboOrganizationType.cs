namespace Database.Trupanion.Entity.Product.Dbo;

public class ProductDboOrganizationType
{
    public ProductDboOrganizationType()
    {
        ProductCertificateIssuingOrganizationTypes = new HashSet<ProductDboProductCertificateIssuingOrganizationType>();
    }

    public Guid Id { get; set; }
    public string? Name { get; set; }

    public virtual ICollection<ProductDboProductCertificateIssuingOrganizationType> ProductCertificateIssuingOrganizationTypes { get; set; }
}

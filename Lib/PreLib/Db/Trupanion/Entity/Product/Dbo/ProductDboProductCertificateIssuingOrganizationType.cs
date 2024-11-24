namespace Database.Trupanion.Entity.Product.Dbo;

public class ProductDboProductCertificateIssuingOrganizationType
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public Guid OrganizationTypeId { get; set; }
    public bool RequiresAdoptionDate { get; set; }
    public bool RequiresExamDate { get; set; }

    public virtual ProductDboOrganizationType? OrganizationType { get; set; }
    public virtual ProductDboProduct? Product { get; set; }
}

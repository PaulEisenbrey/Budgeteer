namespace Database.Trupanion.Entity.Product.Dbo;

public class ProductDboProductVersionProductFactor
{
    public Guid Id { get; set; }
    public Guid ProductVersionId { get; set; }
    public Guid ProductFactorId { get; set; }

    public virtual ProductDboProductFactor? ProductFactor { get; set; }
    public virtual ProductDboProductVersion? ProductVersion { get; set; }
}

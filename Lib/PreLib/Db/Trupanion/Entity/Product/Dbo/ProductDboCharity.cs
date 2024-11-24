namespace Database.Trupanion.Entity.Product.Dbo;

public class ProductDboCharity
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? IsoAlpha3CountryCode { get; set; }
    public byte[]? Logo { get; set; }
    public Guid BrandId { get; set; }

    public virtual ProductDboBrand? Brand { get; set; }
}

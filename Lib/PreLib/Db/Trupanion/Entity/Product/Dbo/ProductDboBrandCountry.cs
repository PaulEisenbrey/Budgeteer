namespace Database.Trupanion.Entity.Product.Dbo;

public class ProductDboBrandCountry
{
    public Guid Id { get; set; }
    public Guid BrandId { get; set; }
    public string? IsoAlpha3CountryCode { get; set; }

    public virtual ProductDboBrand? Brand { get; set; }
}

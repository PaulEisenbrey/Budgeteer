namespace Database.Trupanion.Entity.Product.Dbo;

public class ProductDboBrand
{
    public ProductDboBrand()
    {
        Approvals = new HashSet<ProductDboApproval>();
        BrandCountries = new HashSet<ProductDboBrandCountry>();
        CharacteristicTypes = new HashSet<ProductDboCharacteristicType>();
        Charities = new HashSet<ProductDboCharity>();
        Products = new HashSet<ProductDboProduct>();
    }

    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? DefaultLanguageCode { get; set; }
    public string? Description { get; set; }
    public bool? IsDefault { get; set; }
    public byte[]? Logo { get; set; }

    public virtual ICollection<ProductDboApproval> Approvals { get; set; }
    public virtual ICollection<ProductDboBrandCountry> BrandCountries { get; set; }
    public virtual ICollection<ProductDboCharacteristicType> CharacteristicTypes { get; set; }
    public virtual ICollection<ProductDboCharity> Charities { get; set; }
    public virtual ICollection<ProductDboProduct> Products { get; set; }
}

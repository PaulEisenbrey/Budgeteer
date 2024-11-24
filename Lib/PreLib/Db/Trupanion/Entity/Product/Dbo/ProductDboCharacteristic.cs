namespace Database.Trupanion.Entity.Product.Dbo;

public class ProductDboCharacteristic
{
    public Guid Id { get; set; }
    public string Name { get; set; } = "";
    public Guid CharacteristicTypeId { get; set; }
    public string? IsoAlpha3CountryCode { get; set; }
    public string? StateCode { get; set; }
    public string? PostalCode { get; set; }
    public int? SortOrder { get; set; }

    public virtual ProductDboCharacteristicType? CharacteristicType { get; set; }
    public virtual List<ProductDboCharacteristicToProductVersionMap> CharacteristicToProductVersionMaps { get; set; } = new();
}

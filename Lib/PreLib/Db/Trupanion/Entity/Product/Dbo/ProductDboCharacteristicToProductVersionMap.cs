namespace Database.Trupanion.Entity.Product.Dbo;

public class ProductDboCharacteristicToProductVersionMap
{
    public Guid CharacteristicId { get; set; }
    public Guid ProductVersionId { get; set; }

    public virtual ProductDboCharacteristic? Characteristic { get; set; }
    public virtual ProductDboProductVersion? ProductVersion { get; set; }
}

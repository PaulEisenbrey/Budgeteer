namespace Database.Trupanion.Entity.Product.Dbo;

public class ProductDboCharacteristicToProductFactorInstanceMap
{
    public Guid CharacteristicId { get; set; }
    public Guid ProductFactorInstanceId { get; set; }
    public Guid? ProductVersionId { get; set; }

    public virtual ProductDboCharacteristic? Characteristic { get; set; }
    public virtual ProductDboProductFactorInstance? ProductFactorInstance { get; set; }
    public virtual ProductDboProductVersion? ProductVersion { get; set; }
}

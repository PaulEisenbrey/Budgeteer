namespace Database.Trupanion.Entity.Product.Dbo;

public class ProductDboCharacteristicType
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public Guid SubjectTypeId { get; set; }
    public bool IsLocation { get; set; }
    public Guid BrandId { get; set; }

    public virtual ProductDboBrand? Brand { get; set; }
    public virtual ProductDboCharacteristicSubjectType? SubjectType { get; set; }
    public virtual List<ProductDboCharacteristic> Characteristics { get; set; } = new();
}

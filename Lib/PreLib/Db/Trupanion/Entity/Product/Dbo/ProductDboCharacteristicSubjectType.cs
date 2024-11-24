namespace Database.Trupanion.Entity.Product.Dbo;

public class ProductDboCharacteristicSubjectType
{
    public ProductDboCharacteristicSubjectType()
    {
        CharacteristicTypes = new HashSet<ProductDboCharacteristicType>();
    }

    public Guid Id { get; set; }
    public string? Name { get; set; }

    public virtual ICollection<ProductDboCharacteristicType> CharacteristicTypes { get; set; }
}

namespace Database.Trupanion.Entity.Product.Dbo;

public class ProductDboConditionEffect
{
    public ProductDboConditionEffect()
    {
        Conditions = new HashSet<ProductDboCondition>();
    }

    public Guid Id { get; set; }
    public string? Name { get; set; }

    public virtual ICollection<ProductDboCondition> Conditions { get; set; }
}

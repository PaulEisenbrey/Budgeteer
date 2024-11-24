namespace Database.Trupanion.Entity.Product.Dbo;

public class ProductDboConditionOperator
{
    public ProductDboConditionOperator()
    {
        ConditionProductFactors = new HashSet<ProductDboConditionProductFactor>();
    }

    public Guid Id { get; set; }
    public string? Name { get; set; }
    public int MinValues { get; set; }
    public int MaxValues { get; set; }

    public virtual ICollection<ProductDboConditionProductFactor> ConditionProductFactors { get; set; }
}

namespace Database.Trupanion.Entity.Product.Dbo;

public class ProductDboRule
{
    public ProductDboRule()
    {
        PlanRules = new HashSet<ProductDboPlanRule>();
    }

    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }

    public virtual ICollection<ProductDboPlanRule> PlanRules { get; set; }
}

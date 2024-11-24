namespace Database.Trupanion.Entity.Product.Dbo;

public class ProductDboDurationType
{
    public ProductDboDurationType()
    {
        PlanPolicyTermDurationTypes = new HashSet<ProductDboPlan>();
        PlanPriceTermDurationTypes = new HashSet<ProductDboPlan>();
    }

    public Guid Id { get; set; }
    public string? Name { get; set; }

    public virtual ICollection<ProductDboPlan> PlanPolicyTermDurationTypes { get; set; }
    public virtual ICollection<ProductDboPlan> PlanPriceTermDurationTypes { get; set; }
}

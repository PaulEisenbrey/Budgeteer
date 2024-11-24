namespace Database.Trupanion.Entity.Product.Dbo;

public class ProductDboDisclosure
{
    public ProductDboDisclosure()
    {
        PlanDisclosures = new HashSet<ProductDboPlanDisclosure>();
    }

    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Content { get; set; }

    public virtual ICollection<ProductDboPlanDisclosure> PlanDisclosures { get; set; }
}

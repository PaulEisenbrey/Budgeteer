namespace Database.Trupanion.Entity.Product.Dbo;

public class ProductDboPlanDisclosure
{
    public Guid Id { get; set; }
    public Guid PlanId { get; set; }
    public Guid DisclosureId { get; set; }
    public Guid? BrandId { get; set; }

    public virtual ProductDboDisclosure? Disclosure { get; set; }
}

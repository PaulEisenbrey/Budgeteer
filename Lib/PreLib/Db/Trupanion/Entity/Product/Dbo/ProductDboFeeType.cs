namespace Database.Trupanion.Entity.Product.Dbo;

public class ProductDboFeeType
{
    public ProductDboFeeType()
    {
        FeeTriggers = new HashSet<ProductDboFeeTrigger>();
        PlanFees = new HashSet<ProductDboPlanFee>();
    }

    public Guid Id { get; set; }
    public string? Name { get; set; }

    public virtual ICollection<ProductDboFeeTrigger> FeeTriggers { get; set; }
    public virtual ICollection<ProductDboPlanFee> PlanFees { get; set; }
}

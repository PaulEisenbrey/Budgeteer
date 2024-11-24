namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatBillingDiscount
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int DiscountTypeId { get; set; }
    public int DiscountModificationTypeId { get; set; }
    public decimal DefaultDiscountValue { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }

    public virtual TruDatBillingDiscountModificationType? DiscountModificationType { get; set; }
    public virtual TruDatBillingDiscountType? DiscountType { get; set; }
    public virtual List<TruDatBillingDiscountApplication> DiscountApplications { get; set; } = new();
    public virtual List<TruDatBillingDiscountEngine> DiscountEngines { get; set; } = new();
    public virtual List<TruDatBillingOrderItemDiscount> OrderItemDiscounts { get; set; } = new();
}

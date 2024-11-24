namespace Database.Trupanion.Entity.Product.Dbo;

public class ProductDboPlanFee
{
    public Guid Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public Guid PlanId { get; set; }
    public Guid FeeTypeId { get; set; }
    public Guid? TemplateId { get; set; }
    public Guid? ApprovalId { get; set; }
    public Guid? PriceEngineId { get; set; }

    public virtual ProductDboApproval? Approval { get; set; }
    public virtual ProductDboFeeType? FeeType { get; set; }
    public virtual ProductDboPlan? Plan { get; set; }
    public virtual ProductDboPlanFee? Template { get; set; }
    public virtual List<ProductDboPlanFee> InverseTemplate { get; set; } = new();
}

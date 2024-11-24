namespace Database.Trupanion.Entity.Product.Dbo;

public class ProductDboPlanTransition
{
    public Guid Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public Guid? TemplateId { get; set; }
    public Guid? ApprovalId { get; set; }
    public Guid? FromPlanId { get; set; }
    public Guid? ToPlanId { get; set; }

    public virtual ProductDboApproval? Approval { get; set; }
    public virtual ProductDboPlan? FromPlan { get; set; }
    public virtual ProductDboPlanTransition? Template { get; set; }
    public virtual ProductDboPlan? ToPlan { get; set; }
    public virtual List<ProductDboPlanTransition> InverseTemplate { get; set; } = new();
}

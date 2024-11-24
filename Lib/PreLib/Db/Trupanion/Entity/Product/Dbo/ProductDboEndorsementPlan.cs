namespace Database.Trupanion.Entity.Product.Dbo;

public class ProductDboEndorsementPlan
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
    public Guid EndorsementId { get; set; }
    public Guid PlanId { get; set; }
    public bool IsOptional { get; set; }

    public virtual ProductDboApproval? Approval { get; set; }
    public virtual ProductDboEndorsement? Endorsement { get; set; }
    public virtual ProductDboPlan? Plan { get; set; }
    public virtual ProductDboEndorsementPlan? Template { get; set; }
    public virtual List<ProductDboEndorsementPlanForm> EndorsementPlanForms { get; set; } = new();
    public virtual List<ProductDboEndorsementPlan> InverseTemplate { get; set; } = new();
}

namespace Database.Trupanion.Entity.Product.Dbo;

public class ProductDboEndorsementPlanForm
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
    public Guid EndorsementPlanId { get; set; }
    public Guid FormId { get; set; }

    public virtual ProductDboApproval? Approval { get; set; }
    public virtual ProductDboEndorsementPlan? EndorsementPlan { get; set; }
    public virtual ProductDboForm? Form { get; set; }
    public virtual ProductDboEndorsementPlanForm? Template { get; set; }
    public virtual List<ProductDboEndorsementPlanForm> InverseTemplate { get; set; } = new();
}

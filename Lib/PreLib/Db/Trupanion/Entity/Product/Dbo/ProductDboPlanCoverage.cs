namespace Database.Trupanion.Entity.Product.Dbo;

public class ProductDboPlanCoverage
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
    public Guid PlanId { get; set; }
    public Guid CoverageId { get; set; }

    public virtual ProductDboApproval? Approval { get; set; }
    public virtual ProductDboCoverage? Coverage { get; set; }
    public virtual ProductDboPlan? Plan { get; set; }
    public virtual ProductDboPlanCoverage? Template { get; set; }
    public virtual List<ProductDboPlanCoverage> InverseTemplate { get; set; } = new();
}

namespace Database.Trupanion.Entity.Product.Dbo;

public class ProductDboPlanRule
{
    public Guid Id { get; set; }
    public Guid? TemplateId { get; set; }
    public Guid? ApprovalId { get; set; }
    public Guid PlanId { get; set; }
    public Guid RuleId { get; set; }

    public virtual ProductDboApproval? Approval { get; set; }
    public virtual ProductDboPlan? Plan { get; set; }
    public virtual ProductDboRule? Rule { get; set; }
    public virtual ProductDboPlanRule? Template { get; set; }
    public virtual List<ProductDboPlanRule> InverseTemplate { get; set; } = new();
}

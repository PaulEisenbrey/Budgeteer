namespace Database.Trupanion.Entity.Product.Dbo;

public class ProductDboFormDeliveryTrigger
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
    public Guid EventTypeId { get; set; }
    public Guid FormDeliveryMethodId { get; set; }
    public Guid FormId { get; set; }
    public Guid PlanId { get; set; }
    public bool ConsiderCustomerCommPref { get; set; }

    public virtual ProductDboApproval? Approval { get; set; }
    public virtual ProductDboEventType? EventType { get; set; }
    public virtual ProductDboForm? Form { get; set; }
    public virtual ProductDboFormDeliveryMethod? FormDeliveryMethod { get; set; }
    public virtual ProductDboPlan? Plan { get; set; }
    public virtual ProductDboFormDeliveryTrigger? Template { get; set; }
    public virtual List<ProductDboFormDeliveryTrigger> InverseTemplate { get; set; } = new();
}

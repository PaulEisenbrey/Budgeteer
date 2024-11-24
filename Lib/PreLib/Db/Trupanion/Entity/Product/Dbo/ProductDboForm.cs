namespace Database.Trupanion.Entity.Product.Dbo;

public class ProductDboForm
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
    public string? Name { get; set; }
    public Guid FormTypeId { get; set; }
    public string? VersionNumber { get; set; }
    public Guid ProductVersionId { get; set; }

    public virtual ProductDboApproval? Approval { get; set; }
    public virtual ProductDboFormType? FormType { get; set; }
    public virtual ProductDboProductVersion? ProductVersion { get; set; }
    public virtual ProductDboForm? Template { get; set; }
    public virtual List<ProductDboApprovalForm> ApprovalForms { get; set; } = new();
    public virtual List<ProductDboEndorsementForm> EndorsementForms { get; set; } = new();
    public virtual List<ProductDboEndorsementPlanForm> EndorsementPlanForms { get; set; } = new();
    public virtual List<ProductDboFormCondition> FormConditions { get; set; } = new();
    public virtual List<ProductDboFormDeliveryTrigger> FormDeliveryTriggers { get; set; } = new();
    public virtual List<ProductDboFormLanguage> FormLanguages { get; set; } = new();
    public virtual List<ProductDboFormTemplate> FormTemplates { get; set; } = new();
    public virtual List<ProductDboForm> InverseTemplate { get; set; } = new();
}

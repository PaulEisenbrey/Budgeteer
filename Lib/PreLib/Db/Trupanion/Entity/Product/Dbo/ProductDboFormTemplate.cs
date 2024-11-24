namespace Database.Trupanion.Entity.Product.Dbo;

public class ProductDboFormTemplate
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
    public Guid? FormId { get; set; }
    public int TemplateDefinitionFormatId { get; set; }
    public string? LanguageCode { get; set; }
    public string? VersionNumber { get; set; }

    public virtual ProductDboApproval? Approval { get; set; }
    public virtual ProductDboForm? Form { get; set; }
    public virtual ProductDboFormTemplate? Template { get; set; }
    public virtual List<ProductDboFormTemplate> InverseTemplate { get; set; } = new();
}

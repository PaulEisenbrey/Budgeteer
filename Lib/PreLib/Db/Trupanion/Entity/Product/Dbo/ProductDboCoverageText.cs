namespace Database.Trupanion.Entity.Product.Dbo;

public class ProductDboCoverageText
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
    public Guid? CoverageId { get; set; }
    public Guid? FormLanguageId { get; set; }
    public string? Name { get; set; }
    public string? Label { get; set; }
    public string? Wording { get; set; }
    public string? Blurb { get; set; }

    public virtual ProductDboApproval? Approval { get; set; }
    public virtual ProductDboCoverage? Coverage { get; set; }
    public virtual ProductDboFormLanguage? FormLanguage { get; set; }
    public virtual ProductDboCoverageText? Template { get; set; }
    public virtual List<ProductDboCoverageText> InverseTemplate { get; set; } = new();
}

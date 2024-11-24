namespace Database.Trupanion.Entity.Product.Dbo;

public class ProductDboRelatedCoverage
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
    public Guid CoverageId { get; set; }
    public Guid RelatedCoverageId { get; set; }
    public Guid RelatedCoverageTypeId { get; set; }

    public virtual ProductDboApproval? Approval { get; set; }
    public virtual ProductDboCoverage? Coverage { get; set; }
    public virtual ProductDboCoverage? RelatedCoverageNavigation { get; set; }
    public virtual ProductDboRelatedCoverageType? RelatedCoverageType { get; set; }
    public virtual ProductDboRelatedCoverage? Template { get; set; }
    public virtual List<ProductDboRelatedCoverage> InverseTemplate { get; set; } = new();
}

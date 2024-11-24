namespace Database.Trupanion.Entity.Product.Dbo;

public class ProductDboEndorsementForm
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
    public Guid FormId { get; set; }

    public virtual ProductDboApproval? Approval { get; set; }
    public virtual ProductDboEndorsement? Endorsement { get; set; }
    public virtual ProductDboForm? Form { get; set; }
    public virtual ProductDboEndorsementForm? Template { get; set; }
    public virtual List<ProductDboEndorsementForm> InverseTemplate { get; set; } = new();
}

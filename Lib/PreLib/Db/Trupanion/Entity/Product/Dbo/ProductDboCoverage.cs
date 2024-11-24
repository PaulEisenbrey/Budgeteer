namespace Database.Trupanion.Entity.Product.Dbo;

public class ProductDboCoverage
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
    public Guid? ParentId { get; set; }
    public Guid? EndorsementId { get; set; }
    public Guid CoverageEffectId { get; set; }

    public virtual ProductDboApproval? Approval { get; set; }
    public virtual ProductDboCoverageEffect? CoverageEffect { get; set; }
    public virtual ProductDboEndorsement? Endorsement { get; set; }
    public virtual ProductDboCoverage? Parent { get; set; }
    public virtual ProductDboCoverage? Template { get; set; }
    public virtual List<ProductDboCoverageText> CoverageTexts { get; set; } = new();
    public virtual List<ProductDboCoverageWaitingPeriod> CoverageWaitingPeriods { get; set; } = new();
    public virtual List<ProductDboCoverage> InverseParent { get; set; } = new();
    public virtual List<ProductDboCoverage> InverseTemplate { get; set; } = new();
    public virtual List<ProductDboPlanCoverage> PlanCoverages { get; set; } = new();
    public virtual List<ProductDboRelatedCoverage> RelatedCoverageCoverages { get; set; } = new();
    public virtual List<ProductDboRelatedCoverage> RelatedCoverageRelatedCoverageNavigations { get; set; } = new();
    public virtual List<ProductDboWaitingPeriod> WaitingPeriods { get; set; } = new();
}

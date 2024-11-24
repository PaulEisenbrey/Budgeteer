namespace Database.Trupanion.Entity.Product.Dbo;

public class ProductDboApproval
{
    public Guid Id { get; set; }
    public string Name { get; set; } = "";
    public Guid RegulatoryAgencyId { get; set; }
    public DateTime? NewBusinessEffectiveDate { get; set; }
    public DateTime? NewBusinessExpirationDate { get; set; }
    public DateTime? RenewalEffectiveDate { get; set; }
    public DateTime? RenewalExpirationDate { get; set; }
    public int? RateNotificationRequirementDays { get; set; }
    public DateTime? FilingDate { get; set; }
    public Guid ApprovalStatusId { get; set; }
    public Guid BrandId { get; set; }
    public string? ConfigurationHash { get; set; }

    public virtual ProductDboApprovalStatus? ApprovalStatus { get; set; }
    public virtual ProductDboBrand? Brand { get; set; }
    public virtual ProductDboRegulatoryAgency? RegulatoryAgency { get; set; }
    public virtual ProductDboProductVersion? ProductVersion { get; set; }
    public virtual List<ProductDboApprovalForm> ApprovalForms { get; set; } = new();
    public virtual List<ProductDboCoverageText> CoverageTexts { get; set; } = new();
    public virtual List<ProductDboCoverageWaitingPeriod> CoverageWaitingPeriods { get; set; } = new();
    public virtual List<ProductDboCoverage> Coverages { get; set; } = new();
    public virtual List<ProductDboEndorsementForm> EndorsementForms { get; set; } = new();
    public virtual List<ProductDboEndorsementPlanForm> EndorsementPlanForms { get; set; } = new();
    public virtual List<ProductDboEndorsementPlan> EndorsementPlans { get; set; } = new();
    public virtual List<ProductDboFormCondition> FormConditions { get; set; } = new();
    public virtual List<ProductDboFormDeliveryTrigger> FormDeliveryTriggers { get; set; } = new();
    public virtual List<ProductDboFormLanguage> FormLanguages { get; set; } = new();
    public virtual List<ProductDboFormTemplate> FormTemplates { get; set; } = new();
    public virtual List<ProductDboForm> Forms { get; set; } = new();
    public virtual List<ProductDboPlanCondition> PlanConditions { get; set; } = new();
    public virtual List<ProductDboPlanCoverage> PlanCoverages { get; set; } = new();
    public virtual List<ProductDboPlanFee> PlanFees { get; set; } = new();
    public virtual List<ProductDboPlanRule> PlanRules { get; set; } = new();
    public virtual List<ProductDboPlanTransition> PlanTransitions { get; set; } = new();
    public virtual List<ProductDboPlan> Plans { get; set; } = new();
    public virtual List<ProductDboRelatedCoverage> RelatedCoverages { get; set; } = new();
    public virtual List<ProductDboWaitingPeriod> WaitingPeriods { get; set; } = new();
}

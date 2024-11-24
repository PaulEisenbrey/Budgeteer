namespace Database.Trupanion.Entity.Product.Dbo;

public class ProductDboPlan
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
    public Guid? ProductVersionId { get; set; }
    public string? Name { get; set; }
    public bool Has30DayMoneyBack { get; set; }
    public string? AdvertisedDeductibleValues { get; set; }
    public string? AdvertisedCoinsuranceValues { get; set; }
    public string? DisclosureTemplateDefinitionName { get; set; }
    public bool RequiresCertificateCode { get; set; }
    public Guid? PriceEngineId { get; set; }
    public int CoverageWaitingPeriodDays { get; set; }
    public int AccidentWaitingPeriodDays { get; set; }
    public int IllnessWaitingPeriodDays { get; set; }
    public Guid PolicyTermDurationTypeId { get; set; }
    public int PolicyTermDuration { get; set; }
    public Guid? PriceTermDurationTypeId { get; set; }
    public int? PriceTermDuration { get; set; }
    public bool? IsAutomaticallyRenewing { get; set; }
    public int DefermentDays { get; set; }

    public virtual ProductDboApproval? Approval { get; set; }
    public virtual ProductDboDurationType? PolicyTermDurationType { get; set; }
    public virtual ProductDboDurationType? PriceTermDurationType { get; set; }
    public virtual ProductDboProductVersion? ProductVersion { get; set; }
    public virtual ProductDboPlan? Template { get; set; }
    public virtual List<ProductDboEndorsementPlan> EndorsementPlans { get; set; } = new();
    public virtual List<ProductDboFormDeliveryTrigger> FormDeliveryTriggers { get; set; } = new();
    public virtual List<ProductDboPlan> InverseTemplate { get; set; } = new();
    public virtual List<ProductDboPlanCondition> PlanConditions { get; set; } = new();
    public virtual List<ProductDboPlanCoverage> PlanCoverages { get; set; } = new();
    public virtual List<ProductDboPlanFee> PlanFees { get; set; } = new();
    public virtual List<ProductDboPlanRule> PlanRules { get; set; } = new();
    public virtual List<ProductDboPlanTransition> PlanTransitionFromPlans { get; set; } = new();
    public virtual List<ProductDboPlanTransition> PlanTransitionToPlans { get; set; } = new();
}

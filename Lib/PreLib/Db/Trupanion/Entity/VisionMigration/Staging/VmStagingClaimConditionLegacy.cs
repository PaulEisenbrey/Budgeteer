namespace Database.Trupanion.Entity.VisionMigration.Staging;

public class VmStagingClaimConditionLegacy
{
    public int? Id { get; set; }
    public int ClaimId { get; set; }
    public int? PolicyId { get; set; }
    public int AilmentId { get; set; }
    public int BodyPartId { get; set; }
    public int ConditionTypeId { get; set; }
    public int State { get; set; }
    public int? ParentId { get; set; }
    public int? PreExistingConditionId { get; set; }
    public int? WaitingPeriodId { get; set; }
    public int? EligibleConditionId { get; set; }
    public int? ManualRejectionReasonId { get; set; }
    public string? ManualRejectionReasonComment { get; set; }
    public bool? IgnoreNoCoverPeriod { get; set; }
    public bool? IgnoreNoProductCoverage { get; set; }
    public bool? IgnoreWaitingPeriod { get; set; }
    public bool? IgnorePreExistingCondition { get; set; }
    public bool? NoCover { get; set; }
    public bool? MarkAsEligible { get; set; }
    public decimal? SuggestedAmount { get; set; }
    public int? HistoryLinkId { get; set; }
    public int ExtRef { get; set; }
    public Guid? BatchId { get; set; }
}

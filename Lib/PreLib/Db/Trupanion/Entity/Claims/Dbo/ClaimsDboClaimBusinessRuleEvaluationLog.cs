namespace Database.Trupanion.Entity.Claims.Dbo;

public class ClaimsDboClaimBusinessRuleEvaluationLog
{
    public int Id { get; set; }
    public DateTime? CreatedOn { get; set; }
    public Guid? CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime? ModifiedOn { get; set; }
    public Guid? ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public string? RuleListEvaluated { get; set; }
    public int ClaimId { get; set; }
    public bool EvaluatedToCompletion { get; set; }
    public string? RuleOutcomes { get; set; }
    public string? SerializedException { get; set; }
    public string? Settings { get; set; }
    public string? Entities { get; set; }
}

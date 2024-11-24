namespace Database.Trupanion.Entity.Claims.Dbo;

public class ClaimsDboConditionExclusion
{
    public Guid Id { get; set; }
    public int ConditionId { get; set; }
    public Guid ExclusionId { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public bool IsOvertCondition { get; set; }
}

namespace Database.Trupanion.Entity.Claims.Dbo;

public class ClaimsDboOvertCondition
{
    public Guid Id { get; set; }
    public int BreedId { get; set; }
    public int ConditionId { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
}

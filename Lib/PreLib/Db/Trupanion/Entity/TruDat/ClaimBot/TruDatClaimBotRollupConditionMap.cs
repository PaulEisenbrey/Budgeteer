namespace Database.Trupanion.Entity.TruDat.ClaimBot;

public class TruDatClaimBotRollupConditionMap
{
    public int Id { get; set; }
    public int RollupConditionId { get; set; }
    public int? ConditionId { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid? CreatedBy { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid? ModifiedBy { get; set; }
}

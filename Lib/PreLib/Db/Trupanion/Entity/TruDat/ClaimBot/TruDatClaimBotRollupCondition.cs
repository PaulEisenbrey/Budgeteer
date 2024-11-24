namespace Database.Trupanion.Entity.TruDat.ClaimBot;

public class TruDatClaimBotRollupCondition
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid? CreatedBy { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid? ModifiedBy { get; set; }
}

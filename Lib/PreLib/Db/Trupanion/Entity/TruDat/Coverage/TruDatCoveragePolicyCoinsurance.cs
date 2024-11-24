namespace Database.Trupanion.Entity.TruDat.Coverage;

public class TruDatCoveragePolicyCoinsurance
{
    public int Id { get; set; }
    public decimal CoinsurancePercentage { get; set; }
    public bool Active { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime? ModifiedOn { get; set; }
    public Guid? ModifiedBy { get; set; }
}

namespace Database.Trupanion.Entity.TruDat.Coverage;

public class TruDatCoveragePolicyDeductible
{
    public int Id { get; set; }
    public decimal Deductible { get; set; }
    public bool Active { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime? ModifiedOn { get; set; }
    public Guid? ModifiedBy { get; set; }
}

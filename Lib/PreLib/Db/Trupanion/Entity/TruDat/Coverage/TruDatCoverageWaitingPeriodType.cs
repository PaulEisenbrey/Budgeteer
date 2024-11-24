namespace Database.Trupanion.Entity.TruDat.Coverage;

public class TruDatCoverageWaitingPeriodType
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime? ModifiedOn { get; set; }
    public Guid? ModifiedBy { get; set; }

    public virtual List<TruDatCoverageEntityWaitingPeriod> EntityWaitingPeriods { get; set; } = new();
}

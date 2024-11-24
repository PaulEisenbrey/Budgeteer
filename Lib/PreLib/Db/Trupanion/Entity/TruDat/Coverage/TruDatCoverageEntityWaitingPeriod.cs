namespace Database.Trupanion.Entity.TruDat.Coverage;

public partial class TruDatCoverageEntityWaitingPeriod
{
    public int Id { get; set; }
    public int WaitingPeriodTypeId { get; set; }
    public int EntityTypeId { get; set; }
    public int? EntityId { get; set; }
    public int WaitingPeriodDays { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime? ModifiedOn { get; set; }
    public Guid? ModifiedBy { get; set; }
    public Guid? EntityUniqueId { get; set; }

    public virtual TruDatCoverageEntityType? EntityType { get; set; }
    public virtual TruDatCoverageWaitingPeriodType? WaitingPeriodType { get; set; }
}

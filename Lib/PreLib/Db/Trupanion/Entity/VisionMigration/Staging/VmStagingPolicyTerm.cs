namespace Database.Trupanion.Entity.VisionMigration.Staging;

public class VmStagingPolicyTerm
{
    public int? Id { get; set; }
    public int PolicyId { get; set; }
    public int ProductId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public int Status { get; set; }
    public Guid? Ref { get; set; }
    public DateTimeOffset? ModifiedDateTime { get; set; }
    public string? ExtRef { get; set; }
    public DateTime YearStartDate { get; set; }
    public DateTime YearEndDate { get; set; }
    public Guid BatchId { get; set; }
}

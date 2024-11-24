namespace Database.Trupanion.Entity.Clu.CLUDbo;

public class CLUDboProposedCondition
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int? PawPrintId { get; set; }
    public int? ClaimId { get; set; }
    public int? PolicyId { get; set; }
    public string? Comment { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? ModifiedBy { get; set; }
    public DateTime CreatedOn { get; set; }
    public DateTime? ModifiedOn { get; set; }
}

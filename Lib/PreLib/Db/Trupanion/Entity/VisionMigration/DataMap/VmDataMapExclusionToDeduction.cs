namespace Database.Trupanion.Entity.VisionMigration.DataMap;

public class VmDataMapExclusionToDeduction
{
    public int Id { get; set; }
    public int? ExclusionId { get; set; }
    public Guid? ExclusionUniqueId { get; set; }
    public int? DeductionTypeId { get; set; }
    public int? RejectionReasonId { get; set; }
}

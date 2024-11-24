namespace Database.Trupanion.Entity.VisionMigration.DataMap;

public class VmDataMapExclusionToDeductionExpanded
{
    public int Id { get; set; }
    public int? ExclusionId { get; set; }
    public Guid? ExclusionUniqueId { get; set; }
    public int DeductionTypeId { get; set; }
    public int ProductId { get; set; }
    public string? Description { get; set; }
    public string? ProductName { get; set; }
    public string? ProductCode { get; set; }
    public int? TrudatPolicyId { get; set; }
    public int? StateId { get; set; }
    public string? DescriptionLong { get; set; }
}

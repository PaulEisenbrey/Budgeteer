namespace Database.Trupanion.Entity.VisionMigration.DataMap;

public class VmDataMapAdditionalBenefitToPolicySection
{
    public int AdditionalBenefitId { get; set; }
    public int PolicySectionId { get; set; }
    public string? Description { get; set; }
    public int? AilmentId { get; set; }
}

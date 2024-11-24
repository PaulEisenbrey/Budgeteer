namespace Database.Trupanion.Entity.VisionMigration.Dbo;

public class VmDboJobType
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int RequiredSegmentTypeId { get; set; }

    public virtual VmDboSegmentType? RequiredSegmentType { get; set; }
    public virtual List<VmDboDataQualityDefinitionJobType> DataQualityDefinitionJobTypes { get; set; } = new();
    public virtual List<VmDboJobTypeParameter> JobTypeParameters { get; set; } = new();
    public virtual List<VmDboJob> Jobs { get; set; } = new();
}

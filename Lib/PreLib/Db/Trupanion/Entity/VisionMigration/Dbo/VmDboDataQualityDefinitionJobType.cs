namespace Database.Trupanion.Entity.VisionMigration.Dbo;

public class VmDboDataQualityDefinitionJobType
{
    public int JobTypeId { get; set; }
    public int DataQualityDefinitionId { get; set; }

    public virtual VmDboDataQualityDefinition? DataQualityDefinition { get; set; }
    public virtual VmDboJobType? JobType { get; set; }
}

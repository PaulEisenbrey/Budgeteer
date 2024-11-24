namespace Database.Trupanion.Entity.VisionMigration.Dbo;

public class VmDboDataQualityDefinition
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? FixQuery { get; set; }
    public string? ResultQuery { get; set; }

    public virtual List<VmDboDataQualityDefinitionJobType> DataQualityDefinitionJobTypes { get; set; } = new();
    public virtual List<VmDboDataQualityResult> DataQualityResults { get; set; } = new();
}

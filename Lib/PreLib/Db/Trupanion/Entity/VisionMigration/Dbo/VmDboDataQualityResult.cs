namespace Database.Trupanion.Entity.VisionMigration.Dbo;

public class VmDboDataQualityResult
{
    public int Id { get; set; }
    public int DefinitionId { get; set; }
    public int ExecutionId { get; set; }
    public int Count { get; set; }
    public string? Error { get; set; }

    public virtual VmDboDataQualityDefinition? Definition { get; set; }
    public virtual VmDboDataQualityExecution? Execution { get; set; }
    public virtual List<VmDboDataQualityResultItem> DataQualityResultItems { get; set; } = new();
}

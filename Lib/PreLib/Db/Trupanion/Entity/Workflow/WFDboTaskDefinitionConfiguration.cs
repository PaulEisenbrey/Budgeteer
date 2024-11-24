namespace Database.Trupanion.Entity.Workflow;

public class WFDboTaskDefinitionConfiguration
{
    public int Id { get; set; }
    public int TaskDefinitionId { get; set; }
    public string ConfigKey { get; set; } = "";
    public string ConfigData { get; set; } = "";

    public virtual WFDboTaskDefinition? TaskDefinition { get; set; }
}

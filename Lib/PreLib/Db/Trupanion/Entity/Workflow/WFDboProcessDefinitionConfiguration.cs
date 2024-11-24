namespace Database.Trupanion.Entity.Workflow;

public class WFDboProcessDefinitionConfiguration
{
    public int Id { get; set; }
    public int ProcessDefinitionId { get; set; }
    public string ConfigKey { get; set; } = "";
    public string ConfigData { get; set; } = "";

    public virtual WFDboProcessDefinition? ProcessDefinition { get; set; }
}

namespace Database.Trupanion.Entity.Workflow;

public class WFDboProcessDefinitionFlowConfiguration
{
    public int Id { get; set; }
    public int ProcessDefinitionFlowId { get; set; }
    public string ConfigKey { get; set; } = "";
    public string ConfigData { get; set; } = "";

    public virtual WFDboProcessDefinitionFlow? ProcessDefinitionFlow { get; set; }
}

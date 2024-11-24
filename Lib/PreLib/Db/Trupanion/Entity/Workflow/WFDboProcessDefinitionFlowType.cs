namespace Database.Trupanion.Entity.Workflow;

public class WFDboProcessDefinitionFlowType
{
    public WFDboProcessDefinitionFlowType()
    {
        ProcessDefinitionFlows = new HashSet<WFDboProcessDefinitionFlow>();
    }

    public int Id { get; set; }
    public string Name { get; set; } = "";
    public long? VersionId { get; set; }
    public bool? DesignerVisible { get; set; }
    public string Description { get; set; } = "";

    public virtual ICollection<WFDboProcessDefinitionFlow> ProcessDefinitionFlows { get; set; }
}

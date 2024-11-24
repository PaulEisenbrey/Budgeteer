namespace Database.Trupanion.Entity.Workflow;

public class WFDboFriendlyProcessDefinitionFlow
{
    public int? Id { get; set; }
    public string ProcessName { get; set; } = "";
    public Guid? FlowUniqueId { get; set; }
    public int? FlowId { get; set; }
    public int? ParentFlowId { get; set; }
    public string FlowBreadCrumb { get; set; } = "";
}

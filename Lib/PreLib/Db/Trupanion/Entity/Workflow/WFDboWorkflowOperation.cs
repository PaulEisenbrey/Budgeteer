namespace Database.Trupanion.Entity.Workflow;

public class WFDboWorkflowOperation
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string DefaultImplementationClassName { get; set; } = "";
    public string Description { get; set; } = "";
    public string IsolationLevel { get; set; } = "";
}

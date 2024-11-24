namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboWorkflowGroup
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public virtual List<TruDatDboWorkflowCaseConfig> WorkflowCaseConfigs { get; set; } = new();
    public virtual List<TruDatDboWorkflowGroupUser> WorkflowGroupUsers { get; set; } = new();
}

namespace Database.Trupanion.Entity.Workflow;

public class WFDboTaskDefinitionWaitOnCompletion
{
    public int Id { get; set; }
    public int TaskDefinitionId { get; set; }
    public int? AttemptNumber { get; set; }
    public int? ExpirationSeconds { get; set; }
    public bool? IsAutomated { get; set; }
    public string AutomationOpinionService { get; set; } = "";
    public string AutomationDeterminedService { get; set; } = "";
    public string ExpirationSecondsCalculator { get; set; } = "";
    public string CustomConfiguration { get; set; } = "";

    public virtual WFDboTaskDefinition? TaskDefinition { get; set; }
}

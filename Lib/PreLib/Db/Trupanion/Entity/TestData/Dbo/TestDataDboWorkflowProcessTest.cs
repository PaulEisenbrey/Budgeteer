namespace Database.Trupanion.Entity.TestData.Dbo;

public  class TestDataDboWorkflowProcessTest
{
    public string? Name { get; set; }
    public int StepId { get; set; }
    public string? InitialLoadType { get; set; }
    public string? Test { get; set; }
    public string? TaskType { get; set; }
    public string? ActionType { get; set; }
    public int? ResolutionValue { get; set; }
    public string? TaskResolution { get; set; }
    public int ContextIndex { get; set; }
    public string? TaskStatus { get; set; }
    public int? ProcessResultValue { get; set; }
    public string? ProcessStatus { get; set; }
    public int StepOrdinal { get; set; }
    public bool IsSuccessModeStep { get; set; }
    public int? WaitDelay { get; set; }
    public int? EnterpriseEntityId { get; set; }
}

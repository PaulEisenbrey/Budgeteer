namespace Database.Trupanion.Entity.Workflow;

public class WFDboWorkflowOperationException
{
    public int Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public string ExceptionPolicy { get; set; } = "";
    public int AttemptCount { get; set; }
    public bool WillBeRetried { get; set; }
    public Guid OperationContextId { get; set; }
    public string ServerName { get; set; } = "";
    public string OperationList { get; set; } = "";
    public string OperationCallstack { get; set; } = "";
    public string ExceptionType { get; set; } = "";
    public string ExceptionMessage { get; set; } = "";
    public string ExceptionCallstack { get; set; } = "";
    public int? EnterpriseApplicationId { get; set; }
    public string MessageId { get; set; } = "";
    public string TriggeringMessageId { get; set; } = "";
    public string MessageTopic { get; set; } = "";
}

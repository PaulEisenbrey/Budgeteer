namespace Database.TestData.TestDataWorkflowAutomation;

public  class TestDataWorkflowAutomationAction
{
    public int Id { get; set; }
    public int ActionTypeId { get; set; }
    public int TaskTypeId { get; set; }
    public int? WaitTypeCount { get; set; }
    public int? ProcessCompletionId { get; set; }
    public int? TaskResolutionId { get; set; }
    public int? TaskStatusId { get; set; }
    public bool? WantHospitalContact { get; set; }
    public int? EnterpriseEntityId { get; set; }
    public int? WaitDelay { get; set; }
    public bool? AreAllRequestsComplete { get; set; }

    public virtual TestDataWorkflowAutomationActionType? ActionType { get; set; }
    public virtual TestDataWorkflowAutomationTaskType? TaskType { get; set; }
    public virtual List<TestDataWorkflowAutomationTestStep> TestSteps { get; set; } = new();
}

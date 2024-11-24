namespace Database.TestData.TestDataWorkflowAutomation;

public  class TestDataWorkflowAutomationActionType
{
    public int Id { get; set; }
    public string? Description { get; set; }

    public virtual List<TestDataWorkflowAutomationAction> Actions { get; set; } = new();
}

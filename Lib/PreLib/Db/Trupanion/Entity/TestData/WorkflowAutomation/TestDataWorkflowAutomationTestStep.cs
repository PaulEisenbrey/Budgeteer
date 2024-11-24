namespace Database.TestData.TestDataWorkflowAutomation;

public  class TestDataWorkflowAutomationTestStep
{
    public int Id { get; set; }
    public int TestId { get; set; }
    public int StepOrdinal { get; set; }
    public int ContextIndex { get; set; }
    public int ActionId { get; set; }
    public bool? IsSuccessModeStep { get; set; }

    public virtual TestDataWorkflowAutomationAction? Action { get; set; }
    public virtual TestDataWorkflowAutomationTest? Test { get; set; }
}

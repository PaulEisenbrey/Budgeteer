namespace Database.TestData.TestDataWorkflowAutomation;

public  class TestDataWorkflowAutomationTest
{
    public int Id { get; set; }
    public int TestSectionId { get; set; }
    public string? Description { get; set; }
    public bool? IsSuccessModeTest { get; set; }

    public virtual TestDataWorkflowAutomationTestSection? TestSection { get; set; }
    public virtual List<TestDataWorkflowAutomationTestStep> TestSteps { get; set; } = new();
}

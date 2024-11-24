namespace Database.Trupanion.Entity.TestData.AnnualNotification;

public class TestDataAnnualNotificationTestParent
{
    public TestDataAnnualNotificationTestParent()
    {
        TestInstances = new HashSet<TestDataAnnualNotificationTestInstance>();
    }

    public int Id { get; set; }
    public string? StateAbbr { get; set; }
    public int StateId { get; set; }
    public DateTime RunDate { get; set; }
    public bool IsInProcess { get; set; }
    public bool IsComplete { get; set; }
    public DateTime? CompletionDate { get; set; }

    public virtual ICollection<TestDataAnnualNotificationTestInstance> TestInstances { get; set; }
}

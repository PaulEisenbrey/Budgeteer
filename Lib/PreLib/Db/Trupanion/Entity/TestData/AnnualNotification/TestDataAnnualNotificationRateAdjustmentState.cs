namespace Database.Trupanion.Entity.TestData.AnnualNotification;

public class TestDataAnnualNotificationRateAdjustmentState
{
    public TestDataAnnualNotificationRateAdjustmentState()
    {
        RateAdjustmentMonitorLogs = new HashSet<TestDataAnnualNotificationRateAdjustmentMonitorLog>();
    }

    public int Id { get; set; }
    public string? Description { get; set; }

    public virtual ICollection<TestDataAnnualNotificationRateAdjustmentMonitorLog> RateAdjustmentMonitorLogs { get; set; }
}

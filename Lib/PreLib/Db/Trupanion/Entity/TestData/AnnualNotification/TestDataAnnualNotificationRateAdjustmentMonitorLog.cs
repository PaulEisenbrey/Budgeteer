namespace Database.Trupanion.Entity.TestData.AnnualNotification;

public class TestDataAnnualNotificationRateAdjustmentMonitorLog
{
    public int Id { get; set; }
    public DateTime RunDate { get; set; }
    public int CurrentStateId { get; set; }
    public int OwnerId { get; set; }
    public int PolicyId { get; set; }
    public string? ErrorMessage { get; set; }
    public double? CurrentRate { get; set; }
    public double? NewRate { get; set; }
    public DateTime? EffectiveDate { get; set; }

    public virtual TestDataAnnualNotificationRateAdjustmentState? CurrentState { get; set; }
}

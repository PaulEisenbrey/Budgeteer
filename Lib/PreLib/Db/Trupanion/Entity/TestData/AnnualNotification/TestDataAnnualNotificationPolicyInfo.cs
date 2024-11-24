namespace Database.Trupanion.Entity.TestData.AnnualNotification;

public class TestDataAnnualNotificationPolicyInfo
{
    public int Id { get; set; }
    public bool HasRiderA { get; set; }
    public bool HasRiderB { get; set; }
    public bool IsWorkingPet { get; set; }
    public int Deductible { get; set; }
    public decimal Premium { get; set; }
    public string? PromoCode { get; set; }
}

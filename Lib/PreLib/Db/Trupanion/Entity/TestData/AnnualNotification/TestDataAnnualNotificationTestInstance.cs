namespace Database.Trupanion.Entity.TestData.AnnualNotification;

public class TestDataAnnualNotificationTestInstance
{
    public int Id { get; set; }
    public int TestParentId { get; set; }
    public int? OwnerId { get; set; }
    public int? PetId { get; set; }
    public bool IsComplete { get; set; }

    public virtual TestDataAnnualNotificationTestParent? TestParent { get; set; }
}

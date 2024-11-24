namespace Database.Trupanion.Entity.VisionMigration.Staging;

public class VmStagingCustomerQueue
{
    public int OwnerId { get; set; }
    public int? VisionCustomerId { get; set; }
    public Guid? BatchId { get; set; }
}

namespace Database.Trupanion.Entity.VisionMigration.Staging;

public class VmStagingPetQueue
{
    public int PetId { get; set; }
    public int? VisionPetId { get; set; }
    public int? VisionPolicyId { get; set; }
    public Guid? BatchId { get; set; }
}

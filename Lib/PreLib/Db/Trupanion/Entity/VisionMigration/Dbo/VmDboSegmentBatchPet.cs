namespace Database.Trupanion.Entity.VisionMigration.Dbo;

public class VmDboSegmentBatchPet
{
    public int PetId { get; set; }
    public Guid Ref { get; set; }
    public int? VisionPetId { get; set; }
    public int? VisionPolicyId { get; set; }
    public Guid BatchId { get; set; }

    public virtual VmDboSegmentBatch? Batch { get; set; }
}

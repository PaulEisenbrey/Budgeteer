namespace Database.Trupanion.Entity.VisionMigration.Dbo;

public class VmDboDataQualityResultItem
{
    public int Id { get; set; }
    public int PetPolicyId { get; set; }
    public int OwnerId { get; set; }
    public int DataQualityResultId { get; set; }

    public virtual VmDboDataQualityResult? DataQualityResult { get; set; }
}

namespace Database.Trupanion.Entity.VisionMigration.Vision;

public class VmVisionClaimMedicalRecordCondition
{
    public int MedicalRecordId { get; set; }
    public byte BodyPartId { get; set; }
    public int? AilmentId { get; set; }
}

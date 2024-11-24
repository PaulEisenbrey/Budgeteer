namespace Database.Trupanion.Entity.VisionMigration.Vision;

public class VmVisionMedicalRecordCondition
{
    public int? Id { get; set; }
    public int MedicalRecordId { get; set; }
    public byte BodyPartId { get; set; }
    public int? AilmentId { get; set; }
}

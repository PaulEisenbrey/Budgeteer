namespace Database.Trupanion.Entity.VisionMigration.Staging;

public class VmStagingPreExistingConditionHead
{
    public int Id { get; set; }
    public int MainRecordId { get; set; }
    public int AilmentId { get; set; }
    public int PetId { get; set; }
    public int DiagnosisType { get; set; }
    public DateTimeOffset? UpdatedDate { get; set; }
    public string? Comments { get; set; }
    public bool Archived { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTimeOffset CreatedDate { get; set; }
    public Guid? UpdatedBy { get; set; }
    public int BodyPartId { get; set; }
    public DateTime? DiagnosisDate { get; set; }
    public int? VetId { get; set; }
    public string? DocumentCommentary { get; set; }
    public string? ExtRef { get; set; }
    public int DiagnosisConditionType { get; set; }
    public bool IsSystem { get; set; }
    public int MedicalRecordId { get; set; }
    public Guid BatchId { get; set; }
    public int? PageNumber { get; set; }
}

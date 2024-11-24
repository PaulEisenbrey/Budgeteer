namespace Database.Trupanion.Entity.VisionMigration.Staging;

public class VmStagingPreExistingCondition
{
    public int? Id { get; set; }
    public int AilmentId { get; set; }
    public int PetId { get; set; }
    public int DiagnosisType { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public string? Comments { get; set; }
    public bool? Archived { get; set; }
    public Guid? CreatedBy { get; set; }
    public DateTime? CreatedDate { get; set; }
    public Guid? UpdatedBy { get; set; }
    public int? BodyPartId { get; set; }
    public DateTime? DiagnosisDate { get; set; }
    public int? VetId { get; set; }
    public string? DocumentCommentary { get; set; }
    public int DiagnosisConditionType { get; set; }
    public bool? IsSystem { get; set; }
    public int? PageNumber { get; set; }
    public int ExtRef { get; set; }
    public Guid BatchId { get; set; }
}

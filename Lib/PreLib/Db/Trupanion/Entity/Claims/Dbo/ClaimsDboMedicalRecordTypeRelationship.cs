namespace Database.Trupanion.Entity.Claims.Dbo;

public class ClaimsDboMedicalRecordTypeRelationship
{
    public int Id { get; set; }
    public int MedicalRecordTypeId { get; set; }
    public int ParentId { get; set; }
    public int SortOrder { get; set; }
    public bool CheckedByDefault { get; set; }

    public virtual ClaimsDboMedicalRecordType? MedicalRecordType { get; set; }
}

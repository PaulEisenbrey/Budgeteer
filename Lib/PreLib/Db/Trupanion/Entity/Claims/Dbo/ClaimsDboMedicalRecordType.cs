namespace Database.Trupanion.Entity.Claims.Dbo;

public class ClaimsDboMedicalRecordType
{
    public ClaimsDboMedicalRecordType()
    {
        ContactRequestMedicalRecordTypeHistories = new HashSet<ClaimsDboContactRequestMedicalRecordTypeHistory>();
        ContactRequestMedicalRecordTypes = new HashSet<ClaimsDboContactRequestMedicalRecordType>();
        MedicalRecordTypeRelationships = new HashSet<ClaimsDboMedicalRecordTypeRelationship>();
    }

    public int Id { get; set; }
    public string? Name { get; set; }
    public bool IsActive { get; set; }

    public virtual ICollection<ClaimsDboContactRequestMedicalRecordTypeHistory> ContactRequestMedicalRecordTypeHistories { get; set; }
    public virtual ICollection<ClaimsDboContactRequestMedicalRecordType> ContactRequestMedicalRecordTypes { get; set; }
    public virtual ICollection<ClaimsDboMedicalRecordTypeRelationship> MedicalRecordTypeRelationships { get; set; }
}

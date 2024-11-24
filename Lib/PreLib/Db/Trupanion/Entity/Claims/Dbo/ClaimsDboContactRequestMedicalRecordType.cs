namespace Database.Trupanion.Entity.Claims.Dbo;

public class ClaimsDboContactRequestMedicalRecordType
{
    public int Id { get; set; }
    public DateTime? CreatedOn { get; set; }
    public Guid? CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime? ModifiedOn { get; set; }
    public Guid? ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public int ContactRequestId { get; set; }
    public int MedicalRecordTypeId { get; set; }
    public bool IsActive { get; set; }
    public bool WasReceived { get; set; }
    public string? OtherDetails { get; set; }
    public int? HospitalId { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }

    public virtual ClaimsDboContactRequest? ContactRequest { get; set; }
    public virtual ClaimsDboMedicalRecordType? MedicalRecordType { get; set; }
}

namespace Database.Trupanion.Entity.Claims.Dbo;

public class ClaimsDboContactRequestHistory
{
    public int Id { get; set; }
    public DateTime? CreatedOn { get; set; }
    public Guid? CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime? ModifiedOn { get; set; }
    public Guid? ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public int ContactRequestId { get; set; }
    public int? PolicyholderId { get; set; }
    public int? InsuredPetId { get; set; }
    public int? HospitalId { get; set; }
    public Guid RequestedBy { get; set; }
    public int RequestStatus { get; set; }
    public int ContactMethod { get; set; }
    public int RequestType { get; set; }
    public int Priority { get; set; }
    public string? Message { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public int ProcessInstanceId { get; set; }
    public int? TaskInstanceId { get; set; }
    public Guid? InitialAssignTo { get; set; }

    public virtual ClaimsDboContactRequest? ContactRequest { get; set; }
    public virtual List<ClaimsDboContactRequestClaimHistory> ContactRequestClaimHistories { get; set; } = new();
    public virtual List<ClaimsDboContactRequestMedicalRecordTypeHistory> ContactRequestMedicalRecordTypeHistories { get; set; } = new();
}

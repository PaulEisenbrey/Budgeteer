namespace Database.Trupanion.Entity.Claims.Dbo;

public class ClaimsDboContactRequest
{
    public int Id { get; set; }
    public DateTime? CreatedOn { get; set; }
    public Guid? CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime? ModifiedOn { get; set; }
    public Guid? ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public byte[]? ConcurrencyToken { get; set; }
    public int? PolicyholderId { get; set; }
    public int InsuredPetId { get; set; }
    public int? HospitalId { get; set; }
    public Guid RequestedBy { get; set; }
    public int RequestStatus { get; set; }
    public DateTime? LastWaitExpired { get; set; }
    public int Attempts { get; set; }
    public int ContactMethod { get; set; }
    public int RequestType { get; set; }
    public int Priority { get; set; }
    public string? Message { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public int ProcessInstanceId { get; set; }
    public int? TaskInstanceId { get; set; }
    public Guid? InitialAssignTo { get; set; }
    public string? AssociatedDocumentId { get; set; }
    public int? AppianId { get; set; }

    public virtual List<ClaimsDboContactRequestClaim> ContactRequestClaims { get; set; } = new();
    public virtual List<ClaimsDboContactRequestHistory> ContactRequestHistories { get; set; } = new();
    public virtual List<ClaimsDboContactRequestMedicalRecordType> ContactRequestMedicalRecordTypes { get; set; } = new();
}

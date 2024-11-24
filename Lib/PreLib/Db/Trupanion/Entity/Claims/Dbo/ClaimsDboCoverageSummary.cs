namespace Database.Trupanion.Entity.Claims.Dbo;

public class ClaimsDboCoverageSummary
{
    public Guid Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public bool IsMemberVisible { get; set; }
    public DateTime? VisibleModifiedOn { get; set; }
    public int PawprintStatusId { get; set; }
    public int PetId { get; set; }
    public Guid PetUniqueId { get; set; }
    public string? MemberDocumentId { get; set; }
    public string? MemberDocumentName { get; set; }
    public string? HospitalDocumentId { get; set; }
    public string? HospitalDocumentName { get; set; }
    public Guid? PlanId { get; set; }
    public Guid? ProductId { get; set; }
    public bool IsLocked { get; set; }
    public Guid UserId { get; set; }
    public bool IsAutomatic { get; set; }
    public int DocumentViewCount { get; set; }
}

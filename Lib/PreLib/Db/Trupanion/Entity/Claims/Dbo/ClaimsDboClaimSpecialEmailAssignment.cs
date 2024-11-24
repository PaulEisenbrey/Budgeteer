namespace Database.Trupanion.Entity.Claims.Dbo;

public class ClaimsDboClaimSpecialEmailAssignment
{
    public int Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid? CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid? ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public Guid AssignedUserId { get; set; }
    public string? EmailGroup { get; set; }
    public string? EmailNote { get; set; }
    public int? SubjectTemplateId { get; set; }
    public int? BodyTemplateId { get; set; }
}

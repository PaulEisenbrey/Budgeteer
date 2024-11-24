namespace Database.Trupanion.Entity.Claims.Dbo;

public class ClaimsDboCoverageSummaryTrial
{
    public Guid Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public Guid AgentId { get; set; }
    public int TaskId { get; set; }
    public string? CoverageSummaryDisposition { get; set; }
    public Guid? OpportunityId { get; set; }
    public Guid? ContactId { get; set; }
    public Guid? PolicyId { get; set; }
    public Guid? InsuredPetId { get; set; }
}

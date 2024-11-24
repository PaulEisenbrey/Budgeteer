namespace Database.Trupanion.Entity.Claims.Dbo;

public class ClaimsDboSpecialCareEntityRouting
{
    public Guid Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public Guid SpecialCareEntityId { get; set; }
    public Guid AssigneeUserId { get; set; }
    public int RegardingEnterpriseEntityId { get; set; }
    public int PriorityId { get; set; }
}

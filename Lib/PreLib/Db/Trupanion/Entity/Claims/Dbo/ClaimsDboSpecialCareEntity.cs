namespace Database.Trupanion.Entity.Claims.Dbo;

public class ClaimsDboSpecialCareEntity
{
    public Guid Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public int EnterpriseEntityId { get; set; }
    public int? PriorityInRouting { get; set; }
    public int? SpecialCareCategoryId { get; set; }
}

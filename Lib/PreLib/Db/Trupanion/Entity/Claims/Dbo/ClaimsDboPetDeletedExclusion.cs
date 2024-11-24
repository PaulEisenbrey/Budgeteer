namespace Database.Trupanion.Entity.Claims.Dbo;

public class ClaimsDboPetDeletedExclusion
{
    public Guid Id { get; set; }
    public Guid PetUniqueId { get; set; }
    public Guid ConditionExclusionId { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public string? Note { get; set; }
}

namespace Database.Trupanion.Entity.Claims.Dbo;

public class ClaimsDboPolicyExclusionTypeDefault
{
    public int Id { get; set; }
    public int PolicyVersionId { get; set; }
    public int PolicyExclusionTypeId { get; set; }
    public int DefaultPolicyExclusionId { get; set; }
    public bool IsActive { get; set; }

    public virtual ClaimsDboPolicyExclusionType? PolicyExclusionType { get; set; }
}

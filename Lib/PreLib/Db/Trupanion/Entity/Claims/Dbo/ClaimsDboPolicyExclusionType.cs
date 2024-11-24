namespace Database.Trupanion.Entity.Claims.Dbo;

public class ClaimsDboPolicyExclusionType
{
    public ClaimsDboPolicyExclusionType()
    {
        PolicyExclusionTypeDefaults = new HashSet<ClaimsDboPolicyExclusionTypeDefault>();
    }

    public int Id { get; set; }
    public string? Name { get; set; }
    public bool IsActive { get; set; }

    public virtual ICollection<ClaimsDboPolicyExclusionTypeDefault> PolicyExclusionTypeDefaults { get; set; }
}

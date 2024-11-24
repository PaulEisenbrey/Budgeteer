namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboReferral
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Sort { get; set; }
    public bool? Active { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public Guid UniqueId { get; set; }

    public virtual List<TruDatDboPetPolicyReferral> PetPolicyReferrals { get; set; } = new();
    public virtual List<TruDatDboReferralMapping> ReferralMappings { get; set; } = new();
}

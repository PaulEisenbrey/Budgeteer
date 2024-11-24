namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboPetPolicyReferral
{
    public int Id { get; set; }
    public int PetPolicyId { get; set; }
    public int ReferralId { get; set; }
    public string? ReferralExplain { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }

    public virtual TruDatDboPetPolicy? PetPolicy { get; set; }
    public virtual TruDatDboReferral? Referral { get; set; }
}

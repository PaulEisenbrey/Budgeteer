namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboPetReferral
{
    public int Id { get; set; }
    public int PetPolicyId { get; set; }
    public int ReferralId { get; set; }
    public string? ReferralName { get; set; }
    public string? ReferralExplain { get; set; }
}

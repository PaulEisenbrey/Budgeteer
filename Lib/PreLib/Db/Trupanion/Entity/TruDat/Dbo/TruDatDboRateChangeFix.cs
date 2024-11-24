namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboRateChangeFix
{
    public double? PetPolicyId { get; set; }
    public string? PolicyNumber { get; set; }
    public DateTime? EffectiveChangeDate { get; set; }
    public double? PremiumNoticeDate { get; set; }
    public string? OptionsNoticeDate { get; set; }
    public double? PremiumTheyThinkIncludingADeductibleChangeIfTheySchedu { get; set; }
    public string? DeductibleScheduled { get; set; }
    public double? CorrectPremium { get; set; }
    public double? CappedCorrectPremium { get; set; }
    public bool F10 { get; set; }
}

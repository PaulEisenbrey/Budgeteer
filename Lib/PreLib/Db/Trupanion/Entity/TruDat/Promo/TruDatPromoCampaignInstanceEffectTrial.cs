namespace Database.Trupanion.Entity.TruDat.Promo;

public class TruDatPromoCampaignInstanceEffectTrial
{
    public int Id { get; set; }
    public int CampaignInstanceId { get; set; }
    public int TrialDays { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public int? ChangeUserId { get; set; }

    public virtual TruDatPromoCampaignInstance? CampaignInstance { get; set; }
}

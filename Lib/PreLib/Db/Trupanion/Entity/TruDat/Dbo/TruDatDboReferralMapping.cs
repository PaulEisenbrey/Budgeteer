namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboReferralMapping
{
    public int Id { get; set; }
    public int ReferralId { get; set; }
    public int? EntityListId { get; set; }

    public virtual TruDatDboEntityList? EntityList { get; set; }
    public virtual TruDatDboReferral? Referral { get; set; }
}

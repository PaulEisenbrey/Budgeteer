namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboOwnerCharityEffective
{
    public int Id { get; set; }
    public int OwnerId { get; set; }
    public DateTime EffectiveFrom { get; set; }
    public DateTime? EffectiveTo { get; set; }
    public int? CharityId { get; set; }
    public decimal? CharityValue { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public int? ChangeUserId { get; set; }

    public virtual TruDatDboUser? ChangeUser { get; set; }
    public virtual TruDatDboCharity? Charity { get; set; }
    public virtual TruDatDboOwner? Owner { get; set; }
}

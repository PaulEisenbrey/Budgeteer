namespace Database.Trupanion.Entity.TruDat.Promo;

public class TruDatPromoCampaignInstanceAssociation
{
    public int Id { get; set; }
    public int CampaignInstanceId { get; set; }
    public int EntityTypeId { get; set; }
    public int EntityId { get; set; }
    public DateTime Inserted { get; set; }

    public virtual TruDatPromoCampaignInstance? CampaignInstance { get; set; }
}

namespace Database.Trupanion.Entity.TruDat.Promo;

public class TruDatPromoCampaign
{
    public int Id { get; set; }
    public int? AssociateId { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public bool? Active { get; set; }
    public int? ChangeUserId { get; set; }

    public virtual List<TruDatPromoCampaignInstance> CampaignInstances { get; set; } = new();
    public virtual List<TruDatPromoCampaignRequiredAssociation> CampaignRequiredAssociations { get; set; } = new();
}

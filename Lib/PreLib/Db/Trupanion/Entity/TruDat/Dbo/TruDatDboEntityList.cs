namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboEntityList
{
    public int Id { get; set; }
    public int EntityTypeId { get; set; }
    public string? ListValue { get; set; }
    public string? ListDescription { get; set; }
    public int SortValue { get; set; }
    public bool? Active { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public int? ChangeUserId { get; set; }

    public virtual TruDatDboEntity? EntityType { get; set; }
    public virtual TruDatDboEntityListAssociate? EntityListAssociate { get; set; }
    public virtual TruDatDboEntityListBluePearl? EntityListBluePearl { get; set; }
    public virtual TruDatDboEntityListPetCo? EntityListPetCo { get; set; }
    public virtual List<TruDatDboAssociate> Associates { get; set; } = new();
    public virtual List<TruDatDboReferralMapping> ReferralMappings { get; set; } = new();
}

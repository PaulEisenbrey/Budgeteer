namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboBreedTrait
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool? Active { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }

    public virtual List<TruDatDboBreedGuideTrait> BreedGuideTraits { get; set; } = new();
}

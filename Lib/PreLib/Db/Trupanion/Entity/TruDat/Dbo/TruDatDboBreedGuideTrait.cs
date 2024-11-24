namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboBreedGuideTrait
{
    public int Id { get; set; }
    public int BreedGuideId { get; set; }
    public int BreedTraitId { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }

    public virtual TruDatDboBreedGuide? BreedGuide { get; set; }
    public virtual TruDatDboBreedTrait? BreedTrait { get; set; }
}

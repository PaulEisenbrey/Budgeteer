namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboBreedGuideBreed
{
    public int BreedGuideId { get; set; }
    public int BreedId { get; set; }
    public DateTime Inserted { get; set; }

    public virtual TruDatDboBreed? Breed { get; set; }
    public virtual TruDatDboBreedGuide? BreedGuide { get; set; }
}

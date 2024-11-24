namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboBreedGuideHealthConcern
{
    public int Id { get; set; }
    public int BreedGuideId { get; set; }
    public int BreedHealthConcernId { get; set; }
    public bool CommonHealthConcern { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }

    public virtual TruDatDboBreedGuide? BreedGuide { get; set; }
    public virtual TruDatDboBreedHealthConcern? BreedHealthConcern { get; set; }
}

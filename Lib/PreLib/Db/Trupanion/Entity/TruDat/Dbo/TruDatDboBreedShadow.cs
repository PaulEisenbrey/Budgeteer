namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboBreedShadow
{
    public int Id { get; set; }
    public int BreedId { get; set; }
    public int ShadowAnimalImageId { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public int? ChangeUserId { get; set; }

    public virtual TruDatDboBreed? Breed { get; set; }
    public virtual TruDatDboUser? ChangeUser { get; set; }
    public virtual TruDatDboShadowAnimalImage? ShadowAnimalImage { get; set; }
}

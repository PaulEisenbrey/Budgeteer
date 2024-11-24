namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboShadowAnimalImage
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public byte[]? Data { get; set; }
    public string? Description { get; set; }
    public int AnimalId { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public int? ChangeUserId { get; set; }
    public bool IsDefault { get; set; }

    public virtual TruDatDboAnimal? Animal { get; set; }
    public virtual TruDatDboUser? ChangeUser { get; set; }
    public virtual List<TruDatDboBreedShadow> BreedShadows { get; set; } = new();
}

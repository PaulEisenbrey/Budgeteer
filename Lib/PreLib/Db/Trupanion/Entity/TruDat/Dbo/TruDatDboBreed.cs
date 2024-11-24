namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboBreed
{
    public int Id { get; set; }
    public int AnimalId { get; set; }
    public string Name { get; set; } = "";
    public bool Active { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public Guid PetCharacteristicUniqueId { get; set; }
    public Guid ProductFactorInstanceUniqueId { get; set; }

    public virtual TruDatDboAnimal? Animal { get; set; }
    public virtual TruDatDboBreedGuide? BreedGuide { get; set; }
    public virtual List<TruDatDboBreedGuideBreed> BreedGuideBreeds { get; set; } = new();
    public virtual List<TruDatDboBreedShadow> BreedShadows { get; set; } = new();
    public virtual List<TruDatDboPetPolicyRateFactorEffective> PetPolicyRateFactorEffectives { get; set; } = new();
    public virtual List<TruDatDboPet> Pets { get; set; } = new();
}

namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboAnimal
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool? Active { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public Guid PetCharacteristicUniqueId { get; set; }
    public Guid ProductFactorInstanceUniqueId { get; set; }

    public virtual List<TruDatDboBreed> Breeds { get; set; } = new();
    public virtual List<TruDatDboPetPolicyRateFactorEffective> PetPolicyRateFactorEffectives { get; set; } = new();
    public virtual List<TruDatDboShadowAnimalImage> ShadowAnimalImages { get; set; } = new();
    public virtual List<TruDatDboWorkingPet> WorkingPets { get; set; } = new();
}

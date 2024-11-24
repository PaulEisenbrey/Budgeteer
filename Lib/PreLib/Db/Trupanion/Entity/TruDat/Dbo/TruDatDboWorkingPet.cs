namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboWorkingPet
{
    public int Id { get; set; }
    public int CategoryId { get; set; }
    public int SpecieId { get; set; }
    public string? Name { get; set; }
    public int? DocumentId { get; set; }
    public string? Description { get; set; }
    public DateTime Inserted { get; set; }

    public virtual TruDatDboWorkingPetCategory? Category { get; set; }
    public virtual TruDatDboPolicyDocType? Document { get; set; }
    public virtual TruDatDboAnimal? Specie { get; set; }
    public virtual List<TruDatDboPetPolicyRateFactorEffective> PetPolicyRateFactorEffectives { get; set; } = new();
    public virtual List<TruDatDboPetWorkingPet> PetWorkingPets { get; set; } = new();
    public virtual List<TruDatDboPet> Pets { get; set; } = new();
}

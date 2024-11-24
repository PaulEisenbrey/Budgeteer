namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboWorkingPetCategory
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public DateTime Inserted { get; set; }

    public virtual List<TruDatDboWorkingPet> WorkingPets { get; set; } = new();
}

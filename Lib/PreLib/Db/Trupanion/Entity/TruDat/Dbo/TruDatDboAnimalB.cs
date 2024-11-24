namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboAnimalB
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool Active { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public Guid PetCharacteristicUniqueId { get; set; }
    public Guid ProductFactorInstanceUniqueId { get; set; }
}

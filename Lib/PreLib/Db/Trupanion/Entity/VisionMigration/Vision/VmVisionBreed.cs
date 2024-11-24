namespace Database.Trupanion.Entity.VisionMigration.Vision;

public class VmVisionBreed
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int PetTypeId { get; set; }
    public int VeNomCode { get; set; }
    public int? TrupanionBreedId { get; set; }
}

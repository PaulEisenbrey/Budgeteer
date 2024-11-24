namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboPetWorkingPet
{
    public int Id { get; set; }
    public int PetId { get; set; }
    public int WorkingPetId { get; set; }
    public int? ChangeUserId { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }

    public virtual TruDatDboWorkingPet? WorkingPet { get; set; }
}

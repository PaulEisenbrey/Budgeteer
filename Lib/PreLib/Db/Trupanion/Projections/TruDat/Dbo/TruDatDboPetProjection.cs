using Utilities.EntityBaseClasses;

namespace Database.Trupanion.Projections.TruDat.Dbo;

public class TruDatDboPetProjection : EntityIntId
{
    public int OwnerId { get; set; }

    public int BreedId { get; set; }

    public string Name { get; set; } = "";

    public DateTime? DateOfBirth { get; set; }

    public int? WorkingPetId { get; set; }

    public int? PetFoodId { get; set; }

    public string Gender { get; set; } = "";

    public Guid UniqueId { get; set; }
}

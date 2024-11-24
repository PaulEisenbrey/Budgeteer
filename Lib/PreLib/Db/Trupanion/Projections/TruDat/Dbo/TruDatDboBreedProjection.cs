using Utilities.EntityBaseClasses;

namespace Database.Trupanion.Projections.TruDat.Dbo;

public class TruDatDboBreedProjection : EntityIntId
{
    public int AnimalId { get; set; }

    public string? Name { get; set; } = "";

    public Guid PetCharacteristicUniqueId { get; set; }

    public Guid ProductFactorInstanceUniqueId { get; set; }

    public bool? Active { get; set; }
}

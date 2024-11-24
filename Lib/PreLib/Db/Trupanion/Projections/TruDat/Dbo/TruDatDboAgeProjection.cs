using Utilities.EntityBaseClasses;

namespace Database.Trupanion.Projections.TruDat.Dbo;

public class TruDatDboAgeProjection : EntityIntId
{
    public string Name { get; set; } = "";
    public decimal AgeYearFrom { get; set; }
    public decimal AgeYearTo { get; set; }
    public bool Active { get; set; } = false;
    public bool? ValidForEnrollment { get; set; }
    public Guid PetCharacteristicUniqueId { get; set; }
    public Guid ProductFactorInstanceUniqueId { get; set; }
}

using Utilities.EntityBaseClasses;

namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatClaimTreatment : EntityIntId
{
    public string? Name { get; set; }

    public int TypeId { get; set; }

    public bool? Core { get; set; }

    public bool Active { get; set; }

    public DateTime Inserted { get; set; }

    public DateTime Updated { get; set; }

    public int? ChangeUserId { get; set; }

    public int? AnimalId { get; set; }

    public bool OptionalClinic { get; set; }

}

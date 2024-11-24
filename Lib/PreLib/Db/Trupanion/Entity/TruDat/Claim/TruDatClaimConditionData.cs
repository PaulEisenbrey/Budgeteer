using Utilities.EntityBaseClasses;

namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatClaimConditionData : EntityIntId
{
    public int? ConceptId { get; set; }

    public int? DescriptionId { get; set; }

    public string? Name { get; set; }

    public bool UserAdded { get; set; }

    public bool Validated { get; set; }

    public bool Active { get; set; }

    public DateTime Inserted { get; set; }

    public DateTime Updated { get; set; }

    public int? ChangeUserId { get; set; }

}

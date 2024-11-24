using Utilities.EntityBaseClasses;

namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatClaimConditionBackup : EntityIntId
{
    public string? Name { get; set; }

    public bool Validated { get; set; }

    public bool Active { get; set; }

    public DateTime Inserted { get; set; }

    public DateTime Updated { get; set; }

    public int? ChangeUserId { get; set; }

    public int? PreferredId { get; set; }

    public bool UserAdded { get; set; }

    public int TypeId { get; set; }

    public double? ExternalId { get; set; }

    public int? ConceptId { get; set; }

}

using Utilities.EntityBaseClasses;

namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatClaimConditionDataStaging : EntityIntId
{
    public int ConceptId { get; set; }

    public int? DescriptionId { get; set; }

    public string? Name { get; set; }

    public int TypeId { get; set; }

    public int InternalPreferred { get; set; }

    public bool CustomerPreferred { get; set; }

    public bool ExcludeFromImport { get; set; }

    public DateTime Inserted { get; set; }

}

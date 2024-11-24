using Utilities.EntityBaseClasses;

namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatClaimProcedure : EntityIntId
{
    public string? Name { get; set; }

    public bool Active { get; set; }

    public DateTime Inserted { get; set; }

    public DateTime Updated { get; set; }

    public int? ChangeUserId { get; set; }

    public int? CostCenterId { get; set; }

    public int? ConditionProcedureId { get; set; }

}

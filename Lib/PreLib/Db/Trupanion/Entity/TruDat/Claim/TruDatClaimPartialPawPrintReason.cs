using Utilities.EntityBaseClasses;

namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatClaimPartialPawPrintReason : EntityIntId
{
    public string? Name { get; set; }

    public bool Active { get; set; }

}

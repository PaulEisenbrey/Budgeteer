using Utilities.EntityBaseClasses;

namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatClaimPartialPawPrint : EntityIntId
{
    public int PetClinicId { get; set; }

    public int PartialPawPrintReasonId { get; set; }

    public int? LastNoteId { get; set; }

    public int ChangeUserId { get; set; }

    public DateTime? MissingHistoryDate { get; set; }

    public DateTime Inserted { get; set; }

}

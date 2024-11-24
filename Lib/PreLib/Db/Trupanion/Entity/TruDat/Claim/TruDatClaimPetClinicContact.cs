using Utilities.EntityBaseClasses;

namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatClaimPetClinicContact : EntityIntId
{
    public int PetClinicId { get; set; }

    public int ContactEntityTypeId { get; set; }

    public int ContactTypeId { get; set; }

    public DateTime ContactTime { get; set; }

    public int ContactedByUserId { get; set; }

    public int? EntityNoteId { get; set; }

}

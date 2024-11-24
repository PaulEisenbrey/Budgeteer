using Utilities.EntityBaseClasses;

namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatClaimPetClinicAttachment : EntityIntId
{
    public int PetClinicId { get; set; }

    public int AttachmentId { get; set; }

    public int? ChangeUserId { get; set; }

    public DateTime Updated { get; set; }

}

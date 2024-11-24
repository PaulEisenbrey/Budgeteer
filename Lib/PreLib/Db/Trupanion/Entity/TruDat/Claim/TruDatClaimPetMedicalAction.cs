using Utilities.EntityBaseClasses;

namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatClaimPetMedicalAction : EntityIntId
{
    public int PetId { get; set; }

    public int StatusId { get; set; }

    public int UserId { get; set; }

    public DateTime Inserted { get; set; }

}

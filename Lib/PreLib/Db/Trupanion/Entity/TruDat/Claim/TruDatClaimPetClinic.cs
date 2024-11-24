using Utilities.EntityBaseClasses;

namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatClaimPetClinic : EntityIntId
{
    public int PetId { get; set; }

    public int ClinicId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public int ContactAttemptsClinic { get; set; }

    public int? LastPetClinicContactId { get; set; }

    public int MedicalRecordStatusId { get; set; }

    public bool Active { get; set; }

    public bool Prepolicy { get; set; }

    public DateTime Inserted { get; set; }

    public DateTime Updated { get; set; }

    public int? ChangeUserId { get; set; }

    public int ContactAttemptsOwner { get; set; }

    public DateTime StatusDate { get; set; }

}

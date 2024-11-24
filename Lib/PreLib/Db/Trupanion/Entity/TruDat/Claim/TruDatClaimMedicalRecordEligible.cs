using Utilities.EntityBaseClasses;

namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatClaimMedicalRecordEligible : EntityIntId
{
    public int MedicalRecordId { get; set; }

    public DateTime? DateDeleted { get; set; }

    public string? Comment { get; set; }

    public int? DeletedEntityNoteId { get; set; }

    public DateTime Inserted { get; set; }

    public DateTime Updated { get; set; }

    public int? ChangeUserId { get; set; }

}

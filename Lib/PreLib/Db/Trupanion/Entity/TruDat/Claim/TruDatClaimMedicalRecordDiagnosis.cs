using Utilities.EntityBaseClasses;

namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatClaimMedicalRecordDiagnosis : EntityIntId
{
    public int DiagnosisId { get; set; }

    public int MedicalRecordId { get; set; }

    public int StatusId { get; set; }

    public DateTime Inserted { get; set; }

    public DateTime Updated { get; set; }

    public int? ChangeUserId { get; set; }

}

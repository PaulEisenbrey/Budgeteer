﻿using Utilities.EntityBaseClasses;

namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatClaimMedicalRecordTreatment : EntityIntId
{
    public int? Duration { get; set; }

    public string? Notes { get; set; }

    public int TreatmentId { get; set; }

    public int MedicalRecordId { get; set; }

    public DateTime Inserted { get; set; }

    public DateTime Updated { get; set; }

    public int? ChangeUserId { get; set; }

    public DateTime? DateDue { get; set; }

}

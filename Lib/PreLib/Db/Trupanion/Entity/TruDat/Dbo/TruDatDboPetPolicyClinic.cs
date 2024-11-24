﻿namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboPetPolicyClinic
{
    public int PetPolicyId { get; set; }
    public int ClinicId { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public int? ChangeUserId { get; set; }

    public virtual TruDatDboClinic? Clinic { get; set; }
    public virtual TruDatDboPetPolicy? PetPolicy { get; set; }
}

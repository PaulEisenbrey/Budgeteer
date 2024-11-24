namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboClaimClinic
{
    public int ClaimClinicId { get; set; }
    public int ClinicId { get; set; }
    public int ClaimId { get; set; }
    public DateTime Inserted { get; set; }

    public virtual TruDatDboClaim? Claim { get; set; }
    public virtual TruDatDboClinic? Clinic { get; set; }
}

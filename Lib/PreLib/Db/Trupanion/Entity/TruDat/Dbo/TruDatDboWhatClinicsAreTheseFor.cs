namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboWhatClinicsAreTheseFor
{
    public int PetPolicyId { get; set; }
    public int ClinicId { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public int? ChangeUserId { get; set; }
}

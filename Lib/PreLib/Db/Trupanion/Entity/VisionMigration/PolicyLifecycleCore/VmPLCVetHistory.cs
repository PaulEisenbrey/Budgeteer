namespace Database.Trupanion.Entity.VisionMigration.PolicyLifecycleCore;

public class VmPLCVetHistory
{
    public int Id { get; set; }
    public bool? IsClinicHistoryComplete { get; set; }
    public int PetId { get; set; }
    public int CountryId { get; set; }
    public int CustomerId { get; set; }
}

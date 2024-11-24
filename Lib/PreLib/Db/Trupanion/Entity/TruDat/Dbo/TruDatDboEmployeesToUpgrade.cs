namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboEmployeesToUpgrade
{
    public int Id { get; set; }
    public int OwnerId { get; set; }
    public int PetPolicyId { get; set; }
    public int StateId { get; set; }
    public int DocumentVersionId { get; set; }
    public int EngineVersionId { get; set; }
    public bool Upgraded { get; set; }
    public bool? Encina { get; set; }
}

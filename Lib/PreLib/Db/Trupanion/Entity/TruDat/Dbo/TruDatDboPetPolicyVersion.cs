namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboPetPolicyVersion
{
    public int Id { get; set; }
    public int PetPolicyId { get; set; }
    public Guid PetPolicyUniqueId { get; set; }
    public Guid? ProductId { get; set; }
    public string? PolicyVersionName { get; set; }
}

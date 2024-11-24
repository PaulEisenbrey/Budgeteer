namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboPetPolicyActionHistory
{
    public int Sequence { get; set; }
    public int PetPolicyId { get; set; }
    public string? Action { get; set; }
    public string? UserName { get; set; }
    public string? Note { get; set; }
    public DateTime ActionDate { get; set; }
}

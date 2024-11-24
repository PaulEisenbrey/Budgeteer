namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboPetPolicyCancelInfoView
{
    public int Id { get; set; }
    public int PetPolicyId { get; set; }
    public DateTime CancelDate { get; set; }
    public int CancelId { get; set; }
    public string? CancelNote { get; set; }
    public bool Cancelled { get; set; }
    public int? ChangeUserId { get; set; }
}

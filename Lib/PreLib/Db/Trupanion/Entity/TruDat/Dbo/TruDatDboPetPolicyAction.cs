namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboPetPolicyAction
{
    public int Id { get; set; }
    public int PetPolicyId { get; set; }
    public int StatusId { get; set; }
    public int UserId { get; set; }
    public int? HistoryId { get; set; }
    public string? Note { get; set; }
    public DateTime Inserted { get; set; }

    public virtual TruDatDboPetPolicy? PetPolicy { get; set; }
    public virtual TruDatDboStatus? Status { get; set; }
    public virtual TruDatDboUser? User { get; set; }
}

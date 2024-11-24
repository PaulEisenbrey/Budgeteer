namespace Database.Trupanion.Entity.PurchaseProcess.Dbo;

public class PPDboAvailablePolicyNumber
{
    public int Id { get; set; }
    public int EngineId { get; set; }
    public string? PolicyNumber { get; set; }
    public int BatchId { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
}

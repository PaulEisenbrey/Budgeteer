namespace Database.Trupanion.Entity.Billing.Dbo;

public class BillingDboJobRun
{
    public int Id { get; set; }
    public int JobTypeId { get; set; }
    public DateTime StartedOn { get; set; }
    public DateTime? FinishedOn { get; set; }
    public string? MachineName { get; set; }
}
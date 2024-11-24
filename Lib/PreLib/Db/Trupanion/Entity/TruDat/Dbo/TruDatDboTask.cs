namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboTask
{
    public int Id { get; set; }
    public int TypeId { get; set; }
    public int UserId { get; set; }
    public DateTime? DateDue { get; set; }
    public string? Name { get; set; }
    public string? Notes { get; set; }
    public bool? Alert { get; set; }
    public string? Alerted { get; set; }
    public bool? Active { get; set; }
    public bool? Completed { get; set; }
    public bool? Cancelled { get; set; }
    public int? CancelledByUserId { get; set; }
    public DateTime? CompletedDate { get; set; }
    public DateTime? CancelledDate { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }

    public virtual TruDatDboUser? CancelledByUser { get; set; }
    public virtual TruDatDboTaskType? Type { get; set; }
    public virtual TruDatDboUser? User { get; set; }
    public virtual List<TruDatDboTaskEmail> TaskEmails { get; set; } = new();
}

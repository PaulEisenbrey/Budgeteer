namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboSession
{
    public int Id { get; set; }
    public string? UniqueId { get; set; }
    public int ApplicationId { get; set; }
    public int UserId { get; set; }
    public DateTime LoginDate { get; set; }
    public DateTime? ActivityDate { get; set; }

    public virtual TruDatDboUser? User { get; set; }
    public virtual List<TruDatDboEntityLock> EntityLocks { get; set; } = new();
    public virtual List<TruDatDboFaxInProgress> FaxInProgresses { get; set; } = new();
}

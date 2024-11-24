namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboOwnerPendingRateChange
{
    public int OwnerId { get; set; }
    public int CountryId { get; set; }
    public DateTime StateRequiredNoticeDate { get; set; }
    public DateTime NoticeDate { get; set; }
    public DateTime EffectiveDate { get; set; }
    public DateTime DateAsOf { get; set; }
    public string? ScheduleError { get; set; }
    public bool Success { get; set; }
    public DateTime Inserted { get; set; }
    public int? StateId { get; set; }

    public virtual TruDatDboOwner? Owner { get; set; }
}

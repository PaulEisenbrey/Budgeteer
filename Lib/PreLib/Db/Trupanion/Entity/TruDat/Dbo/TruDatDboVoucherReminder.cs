namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboVoucherReminder
{
    public int Id { get; set; }
    public int VoucherId { get; set; }
    public int ReminderId { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public bool Active { get; set; }

    public virtual TruDatDboReminder? Reminder { get; set; }
}

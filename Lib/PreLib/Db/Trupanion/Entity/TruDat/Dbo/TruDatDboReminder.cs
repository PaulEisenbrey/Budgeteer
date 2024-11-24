namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboReminder
{
    public int Id { get; set; }
    public int ReminderInterval { get; set; }
    public int TemplateId { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }

    public virtual List<TruDatDboVoucherReminder> VoucherReminders { get; set; } = new();
}

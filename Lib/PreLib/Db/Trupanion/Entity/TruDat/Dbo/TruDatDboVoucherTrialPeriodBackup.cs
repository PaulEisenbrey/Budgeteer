namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboVoucherTrialPeriodBackup
{
    public int VoucherId { get; set; }
    public int TrialDays { get; set; }
    public int ReminderInterval { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
}

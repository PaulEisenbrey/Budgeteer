namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboPetPolicyVoucher
{
    public int PetPolicyId { get; set; }
    public int VoucherId { get; set; }
    public string? ReferenceNumber { get; set; }
    public DateTime? DateReminderSent { get; set; }
    public int ReminderSentCount { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }

    public virtual TruDatDboPetPolicy? PetPolicy { get; set; }
}

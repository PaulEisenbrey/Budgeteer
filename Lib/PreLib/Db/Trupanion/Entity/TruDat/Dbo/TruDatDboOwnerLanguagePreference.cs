namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboOwnerLanguagePreference
{
    public int OwnerId { get; set; }
    public int LanguageId { get; set; }
    public int? ChangeUserId { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }

    public virtual TruDatDboUser? ChangeUser { get; set; }
    public virtual TruDatDboLanguage? Language { get; set; }
    public virtual TruDatDboOwner? Owner { get; set; }
}

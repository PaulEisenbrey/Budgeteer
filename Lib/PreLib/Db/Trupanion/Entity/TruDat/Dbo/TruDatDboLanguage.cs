namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboLanguage
{
    public int Id { get; set; }
    public string? Code { get; set; }
    public string? Name { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }

    public virtual List<TruDatDboOwnerLanguagePreference> OwnerLanguagePreferences { get; set; } = new();
}

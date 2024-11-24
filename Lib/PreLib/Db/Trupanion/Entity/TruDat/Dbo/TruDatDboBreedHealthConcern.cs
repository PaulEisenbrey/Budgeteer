namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboBreedHealthConcern
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Url { get; set; }
    public string? PageTitle { get; set; }
    public string? MetaDescription { get; set; }
    public string? H1tag { get; set; }
    public string? Description { get; set; }
    public string? Expenses { get; set; }
    public bool? Active { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }

    public virtual List<TruDatDboBreedGuideHealthConcern> BreedGuideHealthConcerns { get; set; } = new();
}

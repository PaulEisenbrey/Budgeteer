namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboBreedGuide
{
    public int Id { get; set; }
    public int? BreedId { get; set; }
    public string? Url { get; set; }
    public string? PageTitle { get; set; }
    public string? BreedMetaDescription { get; set; }
    public string? BreedH1tag { get; set; }
    public string? Photo1 { get; set; }
    public string? Photo2 { get; set; }
    public string? Summary { get; set; }
    public string? Characteristics { get; set; }
    public string? HealthConcerns { get; set; }
    public string? Detail { get; set; }
    public string? MoreInfo { get; set; }
    public string? Height { get; set; }
    public string? Weight { get; set; }
    public string? Lifespan { get; set; }
    public bool? Active { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public string? VideoHtml { get; set; }

    public virtual TruDatDboBreed? Breed { get; set; }
    public virtual List<TruDatDboBreedGuideBreed> BreedGuideBreeds { get; set; } = new();
    public virtual List<TruDatDboBreedGuideCharacteristic> BreedGuideCharacteristics { get; set; } = new();
    public virtual List<TruDatDboBreedGuideHealthConcern> BreedGuideHealthConcerns { get; set; } = new();
    public virtual List<TruDatDboBreedGuideTrait> BreedGuideTraits { get; set; } = new();
}

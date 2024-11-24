namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboUserBio
{
    public int Id { get; set; }
    public string? UrlPathName { get; set; }
    public string? FullName { get; set; }
    public string? JobTitle { get; set; }
    public string? ImageName { get; set; }
    public int ListPosition { get; set; }
    public string? BioDescription { get; set; }
    public int CategoryId { get; set; }
    public int? SecondaryCategoryId { get; set; }
    public string? PageTitle { get; set; }
    public string? MetaDescription { get; set; }
    public string? MetaKeywords { get; set; }
    public bool? Active { get; set; }
    public DateTime Updated { get; set; }
    public DateTime Inserted { get; set; }
    public string? ImageNameSmall { get; set; }

    public virtual TruDatDboUserBioCategory? Category { get; set; }
}

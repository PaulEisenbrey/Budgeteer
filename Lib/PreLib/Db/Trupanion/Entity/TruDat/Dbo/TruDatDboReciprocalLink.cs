namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboReciprocalLink
{
    public int Id { get; set; }
    public string? Url { get; set; }
    public string? HostUrl { get; set; }
    public string? Description { get; set; }
    public string? ContactName { get; set; }
    public string? ContactEmail { get; set; }
    public int? GroupId { get; set; }
    public int? SuGroup { get; set; }
    public bool Active { get; set; }
    public bool? Verified { get; set; }
    public DateTime? VerifiedDate { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
}

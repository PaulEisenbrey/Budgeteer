namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboPreferredPartnership
{
    public int Id { get; set; }
    public int GroupId { get; set; }
    public string? GroupNo { get; set; }
    public string? PracticeName { get; set; }
    public string? AddressLine { get; set; }
    public string? ZipCode { get; set; }
    public string? City { get; set; }
    public int? StateId { get; set; }
    public string? PartnerName { get; set; }
    public string? PartnerEmail { get; set; }
    public string? ManagerName { get; set; }
    public string? ManagerEmail { get; set; }
    public string? KeyContactName { get; set; }
    public int? NumberOfDoctors { get; set; }
    public bool? SendMarketingMaterials { get; set; }
    public string? Phone { get; set; }
    public string? Fax { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }

    public virtual TruDatDboPartnershipGroup? Group { get; set; }
    public virtual TruDatDboState? State { get; set; }
}

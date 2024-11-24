namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboEntityAddress
{
    public int Id { get; set; }
    public int EntityTypeId { get; set; }
    public int EntityId { get; set; }
    public int AddressId { get; set; }
    public string? Name { get; set; }
    public string? AddressLine2 { get; set; }
    public string? AddressLine3 { get; set; }
    public string? City { get; set; }
    public int StateId { get; set; }
    public string? Zipcode { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public int? ChangeUserId { get; set; }

    public virtual TruDatDboAddress? Address { get; set; }
    public virtual TruDatDboEntity? EntityType { get; set; }
}

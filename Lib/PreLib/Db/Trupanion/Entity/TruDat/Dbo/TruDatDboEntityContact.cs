namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboEntityContact
{
    public int Id { get; set; }
    public int EntityTypeId { get; set; }
    public int EntityId { get; set; }
    public int ContactId { get; set; }
    public string? ContactName { get; set; }
    public string? Email { get; set; }
    public string? Title { get; set; }
    public string? HomePhone { get; set; }
    public string? CellPhone { get; set; }
    public string? WorkPhone { get; set; }
    public string? WorkExtension { get; set; }
    public string? Fax { get; set; }
    public int? PreferredContactMethodId { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public int? ChangeUserId { get; set; }
    public string? AdditionalInfo { get; set; }
    public string? SecondaryEmail { get; set; }

    public virtual TruDatDboContact? Contact { get; set; }
    public virtual TruDatDboEntity? EntityType { get; set; }
    public virtual TruDatDboContactMethod? PreferredContactMethod { get; set; }
}

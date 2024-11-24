namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboOwnerAddress
{
    public int Id { get; set; }
    public int OwnerId { get; set; }
    public int AddressId { get; set; }
    public string? Name { get; set; }
    public string? AddressLine2 { get; set; }
    public string? AddressLine3 { get; set; }
    public string? City { get; set; }
    public int StateId { get; set; }
    public string? Zipcode { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public byte[]? ConcurrencyToken { get; set; }

    public virtual TruDatDboAddress? Address { get; set; }
    public virtual TruDatDboOwner? Owner { get; set; }
    public virtual TruDatDboState? State { get; set; }
}

namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboAddress
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool? Active { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }

    public virtual List<TruDatDboCorporateAccountAddress> CorporateAccountAddresses { get; set; } = new();
    public virtual List<TruDatDboEntityAddress> EntityAddresses { get; set; } = new();
    public virtual List<TruDatDboOwnerAddress> OwnerAddresses { get; set; } = new();
}

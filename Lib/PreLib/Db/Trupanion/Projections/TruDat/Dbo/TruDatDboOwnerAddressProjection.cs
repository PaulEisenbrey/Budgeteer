using Utilities.EntityBaseClasses;

namespace Database.Trupanion.Projections.TruDat.Dbo;

public class TruDatDboOwnerAddressProjection : EntityIntId
{
    public int OwnerId { get; set; }

    public string? Name { get; set; }

    public string? AddressLine2 { get; set; }

    public string? AddressLine3 { get; set; }

    public string? City { get; set; }

    public int StateId { get; set; }

    public string? Zipcode { get; set; }
}

using Utilities.EntityBaseClasses;

namespace Database.Models;

public partial class Address : EntityIntId
{
    public string Street { get; set; } = string.Empty;

    public string UnitNumber { get; set; } = string.Empty;

    public string City { get; set; } = string.Empty;

    public string State { get; set; } = string.Empty;

    public string PostalCode { get; set; } = string.Empty;

    public string Country { get; set; } = string.Empty;

    public virtual List<Institution> Institutions { get; set; } = new();
}

using System;
using System.Collections.Generic;

namespace Database.POCO.Budgeteer;

public partial class Address
{
    public int Id { get; set; }

    public string? Street { get; set; }

    public string? UnitNumber { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? PostalCode { get; set; }

    public string? Country { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? DeleteDate { get; set; }

    public virtual ICollection<Institution> Institutions { get; set; } = new List<Institution>();
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Utilities.EntityBaseClasses;

namespace Database.POCO.Budgeteer;
public class PostalCode : EntityIntId
{
    public string StateProvince { get; set; } = null!;
    public string City { get; set; } = null!;
    public string CountryCode { get; set; } = null!;
    public string PostalCodeValue { get; set; } = null!;

    public override string ToString() => $"{PostalCodeValue} : {City}, {StateProvince} ({CountryCode}. Id {Id})";
}

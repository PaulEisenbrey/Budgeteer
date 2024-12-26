using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUtilities.Conversion;
public static class CountryNameToAbbr
{
    public static string Convert(string countryName)
    {
        return countryName.ToLower() switch
        {
            "can" => "CAN",
            "canada" => "CAN",
            "united states" => "USA",
            "united states of america" => "USA",
            "usa" => "USA",
            _ => throw new ArgumentException("Country name not recognized"),
        };
    }
}

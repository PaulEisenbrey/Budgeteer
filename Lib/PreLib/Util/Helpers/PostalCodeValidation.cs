using System.Text.RegularExpressions;
using Utilities.Entity;
using Utilities.Extension.StringExtension;

namespace Utilities.Helpers;
public static class PostalCodeValidation
{
    private static readonly List<string> countries = new List<string> { "USA", "CAN", "AUS"};

    public static bool IsZip(string input)
    {
        foreach (string country in countries)
        {
            if (IsZip(input, country))
            {
                return true;
            }
        }

        return false;
    }

    public static bool IsZip(string input, string iso3Country)
    {
        if (iso3Country == Country.UnitedStatesOfAmerica.IsoAlpha3Code)
        {
            return UsZipCode(input);
        }

        if (iso3Country == Country.Canada.IsoAlpha3Code)
        {
            return CanadaPostalCode(input);
        }

        if (iso3Country == Country.Australia.IsoAlpha3Code)
        {
            return AustraliaPostCode(input);
        }

        return false;
    }

    public static bool AustraliaPostCode(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return false;
        }

        return input.Length == 4 && input.IsNumeric();
    }

    public static bool UsZipCode(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return false;
        }

        return input.Length == 5 && input.IsNumeric();
    }

    public static bool CanadaPostalCode(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return false;
        }

        string pattern = "^[ABCEGHJ-NPRSTVXY]{1}[0-9]{1}[ABCEGHJ-NPRSTV-Z]{1}[ ]?[0-9]{1}[ABCEGHJ-NPRSTV-Z]{1}[0-9]{1}$";
        return Regex.Match(input.ToUpper(), pattern).Success;
    }
}

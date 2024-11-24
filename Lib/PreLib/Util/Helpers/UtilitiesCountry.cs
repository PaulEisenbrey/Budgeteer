using System.Diagnostics;

using Utilities.Entity;

namespace Utilities.Helpers;

public static class UtilitiesCountry
{
    public const string Unknown = "?";

    private static List<string> supported = new();

    private const string usaUnderwriter = "American Pet Insurance Company";

    private const string canUnderwriter = "Omega General Insurance Company";

    private const string ausUnderwriter = "Trupanion Pet Insurance is general insurance issued by the insurer The Hollard Insurance Company Pty Ltd (ABN 78 090 584 473) (Hollard) is distributed, promoted and administered by Trupanion Australia Pty Ltd (ACN 626 393 628). Any advice provided is general only and you should consider the Product Disclosure Statement available from trupanion.com.au/policy in deciding whether to acquire or continue to hold Trupanion Pet Insurance.";

    public static string Default => Country.UnitedStatesOfAmerica.IsoAlpha3Code;

    public static string DefaultLanguage => "en-US";

    public static List<string> Supported
    {
        get
        {
            if (0 == supported.Count)
            {
                supported.Add(Country.Australia.IsoAlpha3Code);
                supported.Add(Country.Canada.IsoAlpha3Code);
                supported.Add(Country.UnitedStatesOfAmerica.IsoAlpha3Code);
            }

            return supported;
        }
    }

    public static bool IsNorthAmerica(string iso3)
    {
        return iso3 == Country.Canada.IsoAlpha3Code || iso3 == Country.UnitedStatesOfAmerica.IsoAlpha3Code;
    }

    public static string IsoAlpha3ToPhoneMask(string iso3)
    {
        if (iso3 == Country.Australia.IsoAlpha3Code)
        {
            return "(d2) d4-d4";
        }

        return "(d3) d3-d4";
    }

    public static string FormatPhoneNumber(string phone, string iso3)
    {
        if (iso3 == Country.Australia.IsoAlpha3Code)
        {
            return FormatPhoneAustralia(phone);
        }

        return FormatPhoneNorthAmerica(phone);
    }

    public static string CreditPaymentMethodTypeName(string iso3CountryCode, bool useEft)
    {
        string result;
        if (iso3CountryCode == Country.UnitedStatesOfAmerica.IsoAlpha3Code)
        {
            result = (useEft ? "ACH" : "Check");
        }
        else if (iso3CountryCode == Country.Canada.IsoAlpha3Code)
        {
            result = (useEft ? "EFT" : "Check");
        }
        else if (iso3CountryCode == Country.Australia.IsoAlpha3Code)
        {
            result = (useEft ? "EFT" : "Check");
        }
        else
        {
            result = "Unsupported Country";
            if (Debugger.IsAttached)
            {
                Debugger.Break();
            }
        }

        return result;
    }

    public static string IsoAlpha3CountryCode(string country, bool beNice = false)
    {
        if (string.IsNullOrWhiteSpace(country))
        {
            if (beNice)
            {
                return Country.UnitedStatesOfAmerica.IsoAlpha3Code;
            }

            if (Debugger.IsAttached)
            {
                Debugger.Break();
            }

            throw new ArgumentNullException("country");
        }

        if (country.Equals("USA", StringComparison.InvariantCultureIgnoreCase))
        {
            return Country.UnitedStatesOfAmerica.IsoAlpha3Code;
        }

        if (country.Equals("US", StringComparison.InvariantCultureIgnoreCase))
        {
            return Country.UnitedStatesOfAmerica.IsoAlpha3Code;
        }

        if (country.Equals("U.S.", StringComparison.InvariantCultureIgnoreCase))
        {
            return Country.UnitedStatesOfAmerica.IsoAlpha3Code;
        }

        if (country.Equals("U.S.A.", StringComparison.InvariantCultureIgnoreCase))
        {
            return Country.UnitedStatesOfAmerica.IsoAlpha3Code;
        }

        if (country.Equals("Ca", StringComparison.InvariantCultureIgnoreCase))
        {
            return Country.Canada.IsoAlpha3Code;
        }

        if (country.Equals("Can", StringComparison.InvariantCultureIgnoreCase))
        {
            return Country.Canada.IsoAlpha3Code;
        }

        if (country.Equals("Canada", StringComparison.InvariantCultureIgnoreCase))
        {
            return Country.Canada.IsoAlpha3Code;
        }

        if (country.Equals("Au", StringComparison.InvariantCultureIgnoreCase))
        {
            return Country.Australia.IsoAlpha3Code;
        }

        if (country.Equals("Aus", StringComparison.InvariantCultureIgnoreCase))
        {
            return Country.Australia.IsoAlpha3Code;
        }

        if (country.Equals("Australia", StringComparison.InvariantCultureIgnoreCase))
        {
            return Country.Australia.IsoAlpha3Code;
        }

        if (!beNice)
        {
            throw new ArgumentException("country");
        }

        return Country.UnitedStatesOfAmerica.IsoAlpha3Code;
    }

    public static string IsoAlpha3ToZipCodeName(string iso3)
    {
        if (iso3.Equals(Country.UnitedStatesOfAmerica.IsoAlpha3Code, StringComparison.InvariantCultureIgnoreCase))
        {
            return "Zip Code:";
        }

        if (iso3.Equals(Country.Canada.IsoAlpha3Code, StringComparison.InvariantCultureIgnoreCase))
        {
            return "Postal Code:";
        }

        if (iso3.Equals(Country.Australia.IsoAlpha3Code, StringComparison.InvariantCultureIgnoreCase))
        {
            return "Post Code:";
        }

        return "?";
    }

    public static int IsoAlpha3ToZipCodeLength(string iso3)
    {
        if (iso3.Equals(Country.UnitedStatesOfAmerica.IsoAlpha3Code, StringComparison.InvariantCultureIgnoreCase))
        {
            return 5;
        }

        if (iso3.Equals(Country.Canada.IsoAlpha3Code, StringComparison.InvariantCultureIgnoreCase))
        {
            return 7;
        }

        if (iso3.Equals(Country.Australia.IsoAlpha3Code, StringComparison.InvariantCultureIgnoreCase))
        {
            return 4;
        }

        return 7;
    }

    public static bool IsoAlpha3ToZipCodeIsNumeric(string iso3)
    {
        if (iso3.Equals(Country.UnitedStatesOfAmerica.IsoAlpha3Code, StringComparison.InvariantCultureIgnoreCase))
        {
            return true;
        }

        if (iso3.Equals(Country.Canada.IsoAlpha3Code, StringComparison.InvariantCultureIgnoreCase))
        {
            return false;
        }

        if (iso3.Equals(Country.Australia.IsoAlpha3Code, StringComparison.InvariantCultureIgnoreCase))
        {
            return true;
        }

        return false;
    }

    public static string IsoAlpha3ToCountryName(string iso3)
    {
        if (iso3.Equals(Country.UnitedStatesOfAmerica.IsoAlpha3Code, StringComparison.InvariantCultureIgnoreCase))
        {
            return "USA";
        }

        if (iso3.Equals(Country.Canada.IsoAlpha3Code, StringComparison.InvariantCultureIgnoreCase))
        {
            return "Canada";
        }

        if (iso3.Equals(Country.Australia.IsoAlpha3Code, StringComparison.InvariantCultureIgnoreCase))
        {
            return "Australia";
        }

        return "?";
    }

    public static string IsoAlpha3ToStateName(string iso3, bool isLabel = true)
    {
        if (iso3.Equals(Country.UnitedStatesOfAmerica.IsoAlpha3Code, StringComparison.InvariantCultureIgnoreCase))
        {
            return isLabel ? "State:" : "state";
        }

        if (iso3.Equals(Country.Canada.IsoAlpha3Code, StringComparison.InvariantCultureIgnoreCase))
        {
            return isLabel ? "Province:" : "province";
        }

        if (iso3.Equals(Country.Australia.IsoAlpha3Code, StringComparison.InvariantCultureIgnoreCase))
        {
            return isLabel ? "State / Territory:" : "state or territory";
        }

        return "?";
    }

    public static bool IsoAlpha3IsSupported(string iso3)
    {
        return iso3.Equals(Country.UnitedStatesOfAmerica.IsoAlpha3Code, StringComparison.InvariantCultureIgnoreCase) || iso3.Equals(Country.Canada.IsoAlpha3Code, StringComparison.InvariantCultureIgnoreCase) || iso3.Equals(Country.Australia.IsoAlpha3Code, StringComparison.InvariantCultureIgnoreCase);
    }

    public static string NormalizePostalCode(string iso3, string postalCode, bool noSpaceCanada = true)
    {
        if (iso3 == Country.UnitedStatesOfAmerica.IsoAlpha3Code)
        {
            if (string.IsNullOrWhiteSpace(postalCode))
            {
                return "?????";
            }

            return (postalCode.Length > 5) ? postalCode.Substring(0, 5) : postalCode;
        }

        if (iso3 == Country.Canada.IsoAlpha3Code)
        {
            if (string.IsNullOrWhiteSpace(postalCode))
            {
                return noSpaceCanada ? "??????" : "??? ???";
            }

            string text = postalCode.Replace(" ", string.Empty);
            int length = text.Length;
            text = ((length >= 6) ? ((text.Length > 6) ? postalCode.Substring(0, 6) : text) : (text + "??????".Substring(0, 6 - length)));
            text = text.ToUpperInvariant();
            if (noSpaceCanada)
            {
                return text;
            }

            return text.Substring(0, 3) + " " + text.Substring(3, 3);
        }

        if (iso3 == Country.Australia.IsoAlpha3Code)
        {
            if (string.IsNullOrWhiteSpace(postalCode))
            {
                return "????";
            }

            return (postalCode.Length > 4) ? postalCode.Substring(0, 4) : postalCode;
        }

        return postalCode;
    }

    public static string Underwriters(string country, bool shortName = true)
    {
        string text = IsoAlpha3CountryCode(country);
        if (text == Country.UnitedStatesOfAmerica.IsoAlpha3Code)
        {
            return shortName ? "APIC" : "American Pet Insurance Company";
        }

        if (text == Country.Canada.IsoAlpha3Code)
        {
            return shortName ? "Omega" : "Omega General Insurance Company";
        }

        if (text == Country.Australia.IsoAlpha3Code)
        {
            return shortName ? "Hollard Insurance Company Pty" : "Trupanion Pet Insurance is general insurance issued by the insurer The Hollard Insurance Company Pty Ltd (ABN 78 090 584 473) (Hollard) is distributed, promoted and administered by Trupanion Australia Pty Ltd (ACN 626 393 628). Any advice provided is general only and you should consider the Product Disclosure Statement available from trupanion.com.au/policy in deciding whether to acquire or continue to hold Trupanion Pet Insurance.";
        }

        return "?";
    }

    public static string LanguageCode(string country)
    {
        string text = IsoAlpha3CountryCode(country);
        if (text == Country.UnitedStatesOfAmerica.IsoAlpha3Code)
        {
            return "en-US";
        }

        if (text == Country.Canada.IsoAlpha3Code)
        {
            return "en-CA";
        }

        if (text == Country.Australia.IsoAlpha3Code)
        {
            return "en-AU";
        }

        return DefaultLanguage;
    }

    public static string CurrencySymbol(string country)
    {
        string text = IsoAlpha3CountryCode(country);
        if (text == Country.UnitedStatesOfAmerica.IsoAlpha3Code)
        {
            return Currency.USD.CurrencySymbol;
        }

        if (text == Country.Canada.IsoAlpha3Code)
        {
            return Currency.CAD.CurrencySymbol;
        }

        if (text == Country.Australia.IsoAlpha3Code)
        {
            return Currency.AUD.CurrencySymbol;
        }

        return "?";
    }

    public static string CurrencyIsoString(string country)
    {
        string text = IsoAlpha3CountryCode(country);
        if (text == Country.UnitedStatesOfAmerica.IsoAlpha3Code)
        {
            return Currency.USD.IsoCurrencySymbol;
        }

        if (text == Country.Canada.IsoAlpha3Code)
        {
            return Currency.CAD.IsoCurrencySymbol;
        }

        if (text == Country.Australia.IsoAlpha3Code)
        {
            return Currency.AUD.IsoCurrencySymbol;
        }

        return "?";
    }

    public static string FormatPhoneAustralia(string phone)
    {
        if (string.IsNullOrWhiteSpace(phone) || phone.Length < 10)
        {
            return "?";
        }

        string arg = phone.Substring(0, 2);
        string arg2 = phone.Substring(2, 4);
        string arg3 = phone.Substring(6);
        return $"({arg}) {arg2}-{arg3}";
    }

    public static string FormatPhoneNorthAmerica(string phone)
    {
        if (string.IsNullOrWhiteSpace(phone) || phone.Length < 10)
        {
            return "?";
        }

        string arg = phone.Substring(0, 3);
        string arg2 = phone.Substring(3, 3);
        string arg3 = phone.Substring(6);
        return $"({arg}) {arg2}-{arg3}";
    }
}
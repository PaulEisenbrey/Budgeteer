using System.Diagnostics;

using Utilities.Entity;

namespace Utilities.Helpers;

public static class Countries
{
    public const string Unknown = "?";

    private static List<string>? supported;

    public static string Default => Country.UnitedStatesOfAmerica.IsoAlpha3Code;
    public static string DefaultLanguage => "en-US";

    public static List<string> Supported
    {
        get
        {
            if (Countries.supported == null)
            {
                Countries.supported = new List<string>
                    {
                        Country.Australia.IsoAlpha3Code,
                        Country.Canada.IsoAlpha3Code,
                        Country.UnitedStatesOfAmerica.IsoAlpha3Code,
                    };
            }

            return Countries.supported;
        }
    }

    public static bool IsNorthAmerica(string iso3)
        => iso3 == Country.Canada.IsoAlpha3Code ||
           iso3 == Country.UnitedStatesOfAmerica.IsoAlpha3Code;

    public static string FormatPhoneNumber(string phone, string iso3)
    {
        if (iso3 == Country.Australia.IsoAlpha3Code)
        {
            // Australia
            return Countries.FormatPhoneAustralia(phone);
        }
        else
        {
            // US, CA and default
            return Countries.FormatPhoneNorthAmerica(phone);
        }
    }

    public static string CreditPaymentMethodTypeName(string iso3CountryCode, bool useEft)
    {
        string key;
        if (iso3CountryCode == Country.UnitedStatesOfAmerica.IsoAlpha3Code)
        {
            key = useEft ? "ACH" : "Check";
        }
        else if (iso3CountryCode == Country.Canada.IsoAlpha3Code)
        {
            key = useEft ? "EFT" : "Check";
        }
        else if (iso3CountryCode == Country.Australia.IsoAlpha3Code)
        {
            key = useEft ? "EFT" : "Check";
        }
        else
        {
            key = "Unsupported Country";
            if (Debugger.IsAttached) { Debugger.Break(); }
        }

        return key;
    }

    public static string IsoAlpha3CountryCode(string country, bool beNice = false)
    {
        if (string.IsNullOrWhiteSpace(country))
        {
            if (beNice)
            {
                return Country.UnitedStatesOfAmerica.IsoAlpha3Code;
            }
            else
            {
                if (Debugger.IsAttached) { Debugger.Break(); }
                throw new ArgumentNullException(nameof(country));
            }
        }

        if (country.Equals("USA", StringComparison.InvariantCultureIgnoreCase))
        {
            return Country.UnitedStatesOfAmerica.IsoAlpha3Code;
        }
        else if (country.Equals("US", StringComparison.InvariantCultureIgnoreCase))
        {
            return Country.UnitedStatesOfAmerica.IsoAlpha3Code;
        }
        else if (country.Equals("U.S.", StringComparison.InvariantCultureIgnoreCase))
        {
            return Country.UnitedStatesOfAmerica.IsoAlpha3Code;
        }
        else if (country.Equals("U.S.A.", StringComparison.InvariantCultureIgnoreCase))
        {
            return Country.UnitedStatesOfAmerica.IsoAlpha3Code;
        }
        else if (country.Equals("Ca", StringComparison.InvariantCultureIgnoreCase))
        {
            // This does happen
            return Country.Canada.IsoAlpha3Code;
        }
        else if (country.Equals("Can", StringComparison.InvariantCultureIgnoreCase))
        {
            return Country.Canada.IsoAlpha3Code;
        }
        else if (country.Equals("Canada", StringComparison.InvariantCultureIgnoreCase))
        {
            return Country.Canada.IsoAlpha3Code;
        }
        else if (country.Equals("Au", StringComparison.InvariantCultureIgnoreCase))
        {
            return Country.Australia.IsoAlpha3Code;
        }
        else if (country.Equals("Aus", StringComparison.InvariantCultureIgnoreCase))
        {
            return Country.Australia.IsoAlpha3Code;
        }
        else if (country.Equals("Australia", StringComparison.InvariantCultureIgnoreCase))
        {
            return Country.Australia.IsoAlpha3Code;
        }
        else
        {
            return beNice ? Country.UnitedStatesOfAmerica.IsoAlpha3Code : throw new ArgumentException(nameof(country));
        }
    }

    public static string IsoAlpha3ToZipCodeName(string iso3)
    {
        if (iso3.Equals(Country.UnitedStatesOfAmerica.IsoAlpha3Code, StringComparison.InvariantCultureIgnoreCase))
        {
            return "Zip Code:";
        }
        else if (iso3.Equals(Country.Canada.IsoAlpha3Code, StringComparison.InvariantCultureIgnoreCase))
        {
            return "Postal Code:";
        }
        else if (iso3.Equals(Country.Australia.IsoAlpha3Code, StringComparison.InvariantCultureIgnoreCase))
        {
            return "Post Code:";
        }
        else
        {
            return Countries.Unknown;
        }
    }

    public static int IsoAlpha3ToZipCodeLength(string iso3)
    {
        if (iso3.Equals(Country.UnitedStatesOfAmerica.IsoAlpha3Code, StringComparison.InvariantCultureIgnoreCase))
        {
            return 5;
        }
        else if (iso3.Equals(Country.Canada.IsoAlpha3Code, StringComparison.InvariantCultureIgnoreCase))
        {
            return 7;
        }
        else if (iso3.Equals(Country.Australia.IsoAlpha3Code, StringComparison.InvariantCultureIgnoreCase))
        {
            return 4;
        }
        else
        {
            return 7;
        }
    }

    public static bool IsoAlpha3ToZipCodeIsNumeric(string iso3)
    {
        if (iso3.Equals(Country.UnitedStatesOfAmerica.IsoAlpha3Code, StringComparison.InvariantCultureIgnoreCase))
        {
            return true;
        }
        else if (iso3.Equals(Country.Canada.IsoAlpha3Code, StringComparison.InvariantCultureIgnoreCase))
        {
            return false;
        }
        else if (iso3.Equals(Country.Australia.IsoAlpha3Code, StringComparison.InvariantCultureIgnoreCase))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static string IsoAlpha3ToCountryName(string iso3)
    {
        if (iso3.Equals(Country.UnitedStatesOfAmerica.IsoAlpha3Code, StringComparison.InvariantCultureIgnoreCase))
        {
            return "USA";
        }
        else if (iso3.Equals(Country.Canada.IsoAlpha3Code, StringComparison.InvariantCultureIgnoreCase))
        {
            return "Canada";
        }
        else if (iso3.Equals(Country.Australia.IsoAlpha3Code, StringComparison.InvariantCultureIgnoreCase))
        {
            return "Australia";
        }
        else
        {
            return Countries.Unknown;
        }
    }

    public static string IsoAlpha3ToStateName(string iso3, bool isLabel = true)
    {
        if (iso3.Equals(Country.UnitedStatesOfAmerica.IsoAlpha3Code, StringComparison.InvariantCultureIgnoreCase))
        {
            return isLabel ? "State:" : "state";
        }
        else if (iso3.Equals(Country.Canada.IsoAlpha3Code, StringComparison.InvariantCultureIgnoreCase))
        {
            return isLabel ? "Province:" : "province";
        }
        else if (iso3.Equals(Country.Australia.IsoAlpha3Code, StringComparison.InvariantCultureIgnoreCase))
        {
            return isLabel ? "State / Territory:" : "state or territory";
        }
        else
        {
            return Countries.Unknown;
        }
    }

    public static bool IsoAlpha3IsSupported(string iso3)
        => iso3.Equals(Country.UnitedStatesOfAmerica.IsoAlpha3Code, StringComparison.InvariantCultureIgnoreCase) ||
            iso3.Equals(Country.Canada.IsoAlpha3Code, StringComparison.InvariantCultureIgnoreCase) ||
            iso3.Equals(Country.Australia.IsoAlpha3Code, StringComparison.InvariantCultureIgnoreCase);

    public static string NormalizePostalCode(string iso3, string postalCode, bool noSpaceCanada = true)
    {
        if (iso3 == Country.UnitedStatesOfAmerica.IsoAlpha3Code)
        {
            if (string.IsNullOrWhiteSpace(postalCode))
            {
                return "?????";
            }

            // USA: Drop postal code extension, typically something like '-9999'
            return postalCode.Length > 5 ? postalCode.Substring(0, 5) : postalCode;
        }
        else if (iso3 == Country.Canada.IsoAlpha3Code)
        {
            if (string.IsNullOrWhiteSpace(postalCode))
            {
                return noSpaceCanada ? "??????" : "??? ???";
            }

            // Remove space
            string postalTrimmed = postalCode.Replace(" ", string.Empty);

            // Pad to 6 if needed
            int length = postalTrimmed.Length;
            if (length < 6)
            {
                postalTrimmed = string.Concat(postalTrimmed, "??????".Substring(0, 6 - length));
            }
            else
            {
                // Truncate to 6 if needed
                postalTrimmed = postalTrimmed.Length > 6 ? postalCode.Substring(0, 6) : postalTrimmed;
            }

            // Capitalize
            postalTrimmed = postalTrimmed.ToUpperInvariant();

            if (noSpaceCanada)
            {
                return postalTrimmed;
            }
            else
            {
                return string.Concat(postalTrimmed.Substring(0, 3), " ", postalTrimmed.Substring(3, 3));
            }
        }
        else if (iso3 == Country.Australia.IsoAlpha3Code)
        {
            if (string.IsNullOrWhiteSpace(postalCode))
            {
                return "????";
            }
            // AUS: Make sure it is 4 characters long
            return postalCode.Length > 4 ? postalCode.Substring(0, 4) : postalCode;
        }
        else
        {
            return postalCode;
        }
    }

    private const string usaUnderwriter = "American Pet Insurance Company";
    private const string canUnderwriter = "Omega General Insurance Company";

    private const string ausUnderwriter =
        "Trupanion Pet Insurance is general insurance issued by the insurer The Hollard Insurance Company Pty Ltd " +
        "(ABN 78 090 584 473) (Hollard) is distributed, promoted and administered by Trupanion Australia Pty Ltd " +
        "(ACN 626 393 628). Any advice provided is general only and you should consider the Product Disclosure " +
        "Statement available from trupanion.com.au/policy in deciding whether to acquire or continue to hold " +
        "Trupanion Pet Insurance.";

    public static string Underwriters(string country, bool shortName = true)
    {
        string iso3 = Countries.IsoAlpha3CountryCode(country);
        if (iso3 == Country.UnitedStatesOfAmerica.IsoAlpha3Code)
        {
            return shortName ? "APIC" : usaUnderwriter;
        }
        else if (iso3 == Country.Canada.IsoAlpha3Code)
        {
            return shortName ? "Omega" : canUnderwriter;
        }
        else if (iso3 == Country.Australia.IsoAlpha3Code)
        {
            return shortName ? "Hollard Insurance Company Pty" : ausUnderwriter;
        }
        else
        {
            return Countries.Unknown;
        }
    }

    public static string LanguageCode(string country)
    {
        string iso3 = Countries.IsoAlpha3CountryCode(country);
        if (iso3 == Country.UnitedStatesOfAmerica.IsoAlpha3Code)
        {
            return "en-US";
        }
        else if (iso3 == Country.Canada.IsoAlpha3Code)
        {
            return "en-CA";
        }
        else if (iso3 == Country.Australia.IsoAlpha3Code)
        {
            return "en-AU";
        }
        else
        {
            return Countries.DefaultLanguage;
        }
    }

    public static string CurrencySymbol(string country)
    {
        string iso3 = Countries.IsoAlpha3CountryCode(country);
        if (iso3 == Country.UnitedStatesOfAmerica.IsoAlpha3Code)
        {
            return Currency.USD.CurrencySymbol;
        }
        else if (iso3 == Country.Canada.IsoAlpha3Code)
        {
            return Currency.CAD.CurrencySymbol;
        }
        else if (iso3 == Country.Australia.IsoAlpha3Code)
        {
            return Currency.AUD.CurrencySymbol;
        }
        else
        {
            return Countries.Unknown;
        }
    }

    public static string CurrencyIsoString(string country)
    {
        string iso3 = Countries.IsoAlpha3CountryCode(country);
        if (iso3 == Country.UnitedStatesOfAmerica.IsoAlpha3Code)
        {
            return Currency.USD.IsoCurrencySymbol;
        }
        else if (iso3 == Country.Canada.IsoAlpha3Code)
        {
            return Currency.CAD.IsoCurrencySymbol;
        }
        else if (iso3 == Country.Australia.IsoAlpha3Code)
        {
            return Currency.AUD.IsoCurrencySymbol;
        }
        else
        {
            return Countries.Unknown;
        }
    }

    public static string FormatPhoneAustralia(string phone)
    {
        if (string.IsNullOrWhiteSpace(phone) || (phone.Length < 10))
        {
            return Countries.Unknown;
        }

        string s0 = phone.Substring(0, 2);
        string s1 = phone.Substring(2, 4);
        string s2 = phone.Substring(6);
        return string.Format("({0}) {1}-{2}", s0, s1, s2);
    }

    public static string FormatPhoneNorthAmerica(string phone)
    {
        if (string.IsNullOrWhiteSpace(phone) || (phone.Length < 10))
        {
            return Countries.Unknown;
        }

        string s0 = phone.Substring(0, 3);
        string s1 = phone.Substring(3, 3);
        string s2 = phone.Substring(6);
        return string.Format("({0}) {1}-{2}", s0, s1, s2);
    }
}
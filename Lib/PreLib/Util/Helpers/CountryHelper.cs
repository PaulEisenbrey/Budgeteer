using System.Globalization;

using Utilities.ArgumentEvaluation;
using Utilities.Entity;

namespace Utilities.Helpers;

public class CountryHelper
{
    private readonly string ausPhoneFormat = "(d2) d4-d4";
    private readonly string usaPhoneFormat = "(d3) d3-d4";

    private readonly Currency currency = Currency.From(new RegionInfo("US"));

    private readonly string usaUnderwriter = "American Pet Insurance Company";
    private readonly string canUnderwriter = "Omega General Insurance Company";

    private readonly string ausUnderwriter =
        "Trupanion Pet Insurance is general insurance issued by the insurer The Hollard Insurance Company Pty Ltd " +
        "(ABN 78 090 584 473) (Hollard) is distributed, promoted and administered by Trupanion Australia Pty Ltd " +
        "(ACN 626 393 628). Any advice provided is general only and you should consider the Product Disclosure " +
        "Statement available from trupanion.com.au/policy in deciding whether to acquire or continue to hold " +
        "Trupanion Pet Insurance.";

    private readonly string Unknown = "?";
    private List<string> supported = new();

    public string Default => Country.UnitedStatesOfAmerica.IsoAlpha3Code;
    public string DefaultLanguage => "en-US";

    public CountryHelper()
    {
        this.supported.Add(Country.Australia.IsoAlpha3Code);
        this.supported.Add(Country.Canada.IsoAlpha3Code);
        this.supported.Add(Country.UnitedStatesOfAmerica.IsoAlpha3Code);
    }

    public List<string> Supported => this.supported;

    public bool IsNorthAmerica(string iso3)
        => iso3 == Country.Canada.IsoAlpha3Code ||
           iso3 == Country.UnitedStatesOfAmerica.IsoAlpha3Code;

    public string IsoAlpha3ToPhoneMask(string iso3) => (iso3 == Country.Australia.IsoAlpha3Code) ? this.ausPhoneFormat : this.usaPhoneFormat;

    public string FormatPhoneNumber(string phone, string iso3) => (iso3 == Country.Australia.IsoAlpha3Code) ? this.FormatPhoneAustralia(phone) : this.FormatPhoneNorthAmerica(phone);

    public string CreditPaymentMethodTypeName(string iso3CountryCode, bool useEft)
    {
        EvaluateArgument.Execute(iso3CountryCode, fn =>
           Country.UnitedStatesOfAmerica.IsoAlpha3Code == iso3CountryCode
        || Country.Canada.IsoAlpha3Code == iso3CountryCode
        || Country.Australia.IsoAlpha3Code == iso3CountryCode,
        $"Invalid country code {iso3CountryCode}");

        string key = "Check";
        if (useEft)
        {
            key = iso3CountryCode == Country.UnitedStatesOfAmerica.IsoAlpha3Code ? "ACH" : "EFT";
        }

        return key;
    }

    public string IsoAlpha3CountryCode(string country)
    {
        EvaluateArgument.Execute(country, fn => !string.IsNullOrEmpty(country), "Country name cannot be empty");

        return (country.ToUpper() is "USA" or "US" or "U.S." or "U.S.A.") ? Country.UnitedStatesOfAmerica.IsoAlpha3Code
            : country.ToUpper() is "CA" or "CAN" or "CANADA" ? Country.Canada.IsoAlpha3Code
            : Country.Australia.IsoAlpha3Code;
    }

    public string IsoAlpha3ToZipCodeName(string iso3) =>
        iso3.ToUpper().Equals(Country.UnitedStatesOfAmerica.IsoAlpha3Code) ? "Zip Code"
            : iso3.ToUpper().Equals(Country.Canada.IsoAlpha3Code) ? "Postal Code"
            : iso3.ToUpper().Equals(Country.Australia.IsoAlpha3Code) ? "Post Code"
            : this.Unknown;

    public int IsoAlpha3ToZipCodeLength(string iso3) =>
        iso3.ToUpper().Equals(Country.UnitedStatesOfAmerica.IsoAlpha3Code) ? 5
            : iso3.ToUpper().Equals(Country.Canada.IsoAlpha3Code) ? 7
            : iso3.ToUpper().Equals(Country.Australia.IsoAlpha3Code) ? 4
            : 7;

    public bool IsoAlpha3ToZipCodeIsNumeric(string iso3) =>
        iso3.ToUpper().Equals(Country.UnitedStatesOfAmerica.IsoAlpha3Code) ? true
            : iso3.ToUpper().Equals(Country.Canada.IsoAlpha3Code) ? false
            : iso3.ToUpper().Equals(Country.Australia.IsoAlpha3Code) ? true
            : false;

    public string IsoAlpha3ToCountryName(string iso3) =>
            iso3.ToUpper().Equals(Country.UnitedStatesOfAmerica.IsoAlpha3Code) ? "USA"
                : iso3.ToUpper().Equals(Country.Canada.IsoAlpha3Code) ? "Canada"
                : iso3.ToUpper().Equals(Country.Australia.IsoAlpha3Code) ? "Australia"
                : this.Unknown;

    public bool IsoAlpha3IsSupported(string iso3)
        => iso3.Equals(Country.UnitedStatesOfAmerica.IsoAlpha3Code, StringComparison.InvariantCultureIgnoreCase) ||
            iso3.Equals(Country.Canada.IsoAlpha3Code, StringComparison.InvariantCultureIgnoreCase) ||
            iso3.Equals(Country.Australia.IsoAlpha3Code, StringComparison.InvariantCultureIgnoreCase);

    public string Underwriters(string country, bool shortName = true)
    {
        string iso3 = this.IsoAlpha3CountryCode(country);
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
            return this.Unknown;
        }
    }

    public string LanguageCode(string country) =>
        this.IsoAlpha3CountryCode(country) == Country.UnitedStatesOfAmerica.IsoAlpha3Code ? "en-US"
        : this.IsoAlpha3CountryCode(country) == Country.Canada.IsoAlpha3Code ? "en-CA"
        : this.IsoAlpha3CountryCode(country) == Country.Australia.IsoAlpha3Code ? "en-AU"
        : this.DefaultLanguage;

    public string CurrencyCode(string country) =>
        this.IsoAlpha3CountryCode(country) == Country.UnitedStatesOfAmerica.IsoAlpha3Code ? Currency.USD.IsoCurrencySymbol
        : this.IsoAlpha3CountryCode(country) == Country.Canada.IsoAlpha3Code ? Currency.CAD.IsoCurrencySymbol
        : this.IsoAlpha3CountryCode(country) == Country.Australia.IsoAlpha3Code ? Currency.AUD.IsoCurrencySymbol
        : Currency.USD.IsoCurrencySymbol;

    public string FormatPhoneAustralia(string phone)
    {
        if (string.IsNullOrWhiteSpace(phone) || (phone.Length < 10))
        {
            return this.Unknown;
        }

        string s0 = phone.Substring(0, 2);
        string s1 = phone.Substring(2, 4);
        string s2 = phone.Substring(6);
        return string.Format("({0}) {1}-{2}", s0, s1, s2);
    }

    public string FormatPhoneNorthAmerica(string phone)
    {
        if (string.IsNullOrWhiteSpace(phone) || (phone.Length < 10))
        {
            return this.Unknown;
        }

        string s0 = phone.Substring(0, 3);
        string s1 = phone.Substring(3, 3);
        string s2 = phone.Substring(6);
        return string.Format("({0}) {1}-{2}", s0, s1, s2);
    }
}
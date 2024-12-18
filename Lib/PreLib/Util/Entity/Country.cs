using System.Globalization;
using Utilities.ArgumentEvaluation;
using Utilities.ReturnType;

namespace Utilities.Entity;

public class Country
{
    private const string AustraliaIso3 = "AUS";

    private const string CanadaIso3 = "CAN";

    private const string UsaIso3 = "USA";

    private static readonly Dictionary<string, string> Iso3ToIso2Mapping;

    private static readonly Dictionary<string, string> PostalCodePatterns;

    public static readonly Country UnitedStatesOfAmerica;

    public static readonly Country Canada;

    public static readonly Country Australia;

    public string IsoAlpha2Code { get; }

    public string IsoAlpha3Code { get; }

    static Country()
    {
        Iso3ToIso2Mapping = (from ci in CultureInfo.GetCultures(CultureTypes.SpecificCultures)
                             where !ci.IsNeutralCulture && ci.LCID != 4096
                             select new RegionInfo(ci.LCID) into ri
                             group ri by ri.ThreeLetterISORegionName).ToDictionary((IGrouping<string, RegionInfo> g) => g.Key, (IGrouping<string, RegionInfo> g) => g.First().TwoLetterISORegionName);
        PostalCodePatterns = new Dictionary<string, string>
            {
                { "AUS", "^[0-9]{4}$" },
                { "USA", "^[0-9]{5}(-[0-9]{4})?$" },
                { "CAN", "\\A[ABCEGHJKLMNPRSTVXY]\\d[A-Z] ?\\d[A-Z]\\d\\z" }
            };
        Australia = new Country("AUS");
        UnitedStatesOfAmerica = new Country("USA");
        Canada = new Country("CAN");
    }

    private Country(string isoAlpha3Code)
    {
        IsoAlpha3Code = isoAlpha3Code;
        IsoAlpha2Code = Iso3ToIso2Mapping[isoAlpha3Code];
    }

    public static bool TryCreate(string isoAlpha3Code, out Country? country)
    {
        if (string.IsNullOrWhiteSpace(isoAlpha3Code) || !Iso3ToIso2Mapping.ContainsKey(isoAlpha3Code.ToUpperInvariant()))
        {
            country = null;
            return false;
        }

        country = new Country(isoAlpha3Code.ToUpperInvariant());
        return true;
    }

    public static ReturnValue<Country> Create(string isoAlpha3Code)
    {
        EvaluateArgument.Execute(isoAlpha3Code, fn => !string.IsNullOrEmpty(isoAlpha3Code), "IsoAlpha3Code cannot be empty");
        if (!TryCreate(isoAlpha3Code, out var country))
        {
            return ReturnValue<Country>.FromError($"Invalid ISO Country Code {isoAlpha3Code}");
        }

        if (null != country)
        {
            return ReturnValue<Country>.From(country);
        }

        return ReturnValue<Country>.FromError($"Unable to find country for {isoAlpha3Code}");
    }

    public string? GetPostalCodeMatchPattern()
    {
        PostalCodePatterns.TryGetValue(IsoAlpha3Code, out var value);
        return value;
    }
}
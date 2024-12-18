using System.Globalization;

using Utilities.ArgumentEvaluation;
using Utilities.Entity;

using Utilities.Extension.StringExtension;

namespace Utilities.Helpers;

public class Currency : ValueObject<Currency>
{
    private static readonly RegionInfo AusRegion = new RegionInfo("AU");

    private static readonly RegionInfo UsRegion = new RegionInfo("US");

    private static readonly RegionInfo CanadaRegion = new RegionInfo("CA");

    private static readonly Dictionary<string, Currency> Currencies = new Dictionary<string, Currency>
        {
            {
                AusRegion.ISOCurrencySymbol,
                new Currency(AusRegion, 2)
            },
            {
                UsRegion.ISOCurrencySymbol,
                new Currency(UsRegion, 2)
            },
            {
                CanadaRegion.ISOCurrencySymbol,
                new Currency(CanadaRegion, 2)
            }
        };

    public static Currency USD => From(nameof(USD));

    public static Currency CAD => From(nameof(CAD));

    public static Currency AUD => From(nameof(AUD));

    public string CurrencySymbol { get; }

    public string IsoCurrencySymbol { get; }

    public int DecimalPlaces { get; }

    private Currency(Required<RegionInfo> regionInfo, int decimalPlaces)
    {
        CurrencySymbol = regionInfo.Value.CurrencySymbol;
        IsoCurrencySymbol = regionInfo.Value.ISOCurrencySymbol;
        DecimalPlaces = decimalPlaces;
    }

    public override int GetHashCode()
    {
        return IsoCurrencySymbol.GetHashCode();
    }

    public override string ToString()
    {
        return IsoCurrencySymbol;
    }

    public static Currency From(string isoCurrencySymbol)
    {
        EvaluateArgument.Execute(isoCurrencySymbol,
            fn => !isoCurrencySymbol.ContainsWhiteSpace(),
            $"Parameter {isoCurrencySymbol} cannot have whitespace");

        if (!Currencies.TryGetValue(isoCurrencySymbol, out var value))
        {
            throw new NotSupportedException($"Currency with symbol '{isoCurrencySymbol}' not supported.");
        }

        return value;
    }

    public static Currency From(Required<RegionInfo> regionInfo)
    {
        if (!Currencies.ContainsKey(regionInfo.Value.ISOCurrencySymbol))
        {
            throw new NotSupportedException("Currency with symbol '" + regionInfo.Value.ISOCurrencySymbol + "' not supported.");
        }

        return Currencies[regionInfo.Value.ISOCurrencySymbol];
    }

    public static Currency From(Required<Country> country)
    {
        return From(new Required<RegionInfo>(new RegionInfo(country.Value.IsoAlpha2Code)));
    }
}
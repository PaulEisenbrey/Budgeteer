using Utilities.Constants.Enum;
using Utilities.Extension.StringExtension;

namespace Utilities.Helpers;

public static class CountryCodeFactory
{
    public static CountryCodeEx CountryCodeFromStateId(int stateId)
    {
        return stateId < (int)TrupStates.AB ? CountryCodeEx.USA : stateId < (int)TrupStates.AU_NSW ? CountryCodeEx.CAN : CountryCodeEx.AUS;
    }

    public static CountryCodeEx CountryCodeFromStateId(TrupStates stateCode)
    {
        return CountryCodeFromStateId((int)stateCode);
    }

    public static CountryCodeEx CountryCodeFromZip(string zipCode)
    {
        return !zipCode.IsDigitsOnly() ? CountryCodeEx.CAN : zipCode.Length < 5 ? CountryCodeEx.AUS : CountryCodeEx.USA;
    }

    public static PriceEngine PriceEngineFromZip(string zipCode)
    {
        return (PriceEngine)((int)CountryCodeFromZip(zipCode));
    }
}
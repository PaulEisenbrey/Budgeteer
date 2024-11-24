using Utilities.Constants.Enum;

namespace Utilities.Entity.Interfaces
{
    public interface ICountryCodeHelper
    {
        CountryCode? Country { get; set; }
        bool IsValid { get; }

        void SetCountryCode(CountryCode countryCode);
    }
}
using Utilities.Constants.Enum;

namespace Utilities.Entity.Interfaces
{
    public interface IPostalCode
    {
        bool IsValid { get; }
        string Code { get; }

        PostalCode SetCode(string postalCode);

        PostalCode SetCountry(CountryCode countryCode);
    }
}
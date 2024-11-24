using Utilities.Constants.Enum;
using Utilities.Entity.Interfaces;
using Utilities.Extension;
using Utilities.IoCInterfaces;

namespace Utilities.Entity;

public class CountryCodeHelper : ICountryCodeHelper, ITransientSvc
{
    public CountryCodeHelper()
    {
    }

    public void SetCountryCode(CountryCode countryCode)
    {
        this.Country = countryCode;
    }

    public bool IsValid => this.Country != CountryCode.UNDEFINED;

    public CountryCode? Country { get; set; } = CountryCode.UNDEFINED;

    public override string ToString() => this.Country?.Description() ?? "UNDEFINED";
}

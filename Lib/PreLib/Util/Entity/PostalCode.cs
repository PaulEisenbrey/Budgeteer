using System.Text.RegularExpressions;
using Utilities.ArgumentEvaluation;
using Utilities.Constants.Enum;
using Utilities.Constants.Strings;
using Utilities.Entity.Interfaces;
using Utilities.Extension;
using Utilities.IoCInterfaces;

namespace Utilities.Entity;

public class PostalCode : IPostalCode, ITransientSvc
{
    private readonly ICountryCodeHelper? countryCodeHelper = null;
    private string postalCode = StringSpace.ZipCodeStrings.invalid;

    public PostalCode(ICountryCodeHelper ccHelper)
    {
        this.countryCodeHelper = ccHelper;
    }

    public PostalCode SetCountry(CountryCode countryCode)
    {
        EvaluateArgument.Execute(countryCode, fn => countryCode != CountryCode.UNDEFINED, "Invalid Country Code");
        this.countryCodeHelper?.SetCountryCode(countryCode);

        return this;
    }

    public bool IsValid => this.postalCode != StringSpace.ZipCodeStrings.invalid;

    public string Code => this.postalCode;

    public PostalCode SetCode(string postalCode)
    {
        EvaluateArgument.Execute(this.countryCodeHelper, 
            fn => null != countryCodeHelper && this.countryCodeHelper.IsValid, 
            $"Cannot validate postal code for country {this.countryCodeHelper?.Country}");

        string regX = this.PostalCodeRegEx(this.countryCodeHelper!.Country);
        var regularExpression = new Regex(regX, RegexOptions.Compiled | RegexOptions.IgnoreCase);

        EvaluateArgument.Execute(postalCode, 
            fn => regularExpression.IsMatch(postalCode), 
            $"Postal Code {postalCode} does not match rules for {this.countryCodeHelper!.Country}");

        this.postalCode = postalCode;

        return this;
    }

    public static implicit operator string(PostalCode value) => value.Code;

    private string PostalCodeRegEx(CountryCode? country) => null != country && country == CountryCode.USA ? StringSpace.ZipCodeStrings.usaRegEx
        : null != country && country == CountryCode.CAN ? StringSpace.ZipCodeStrings.canRegEx 
        : null != country && country == CountryCode.AUS ? StringSpace.ZipCodeStrings.ausRegEx 
        : $"Unable to find postal code regex for country {country?.Description()}";
}

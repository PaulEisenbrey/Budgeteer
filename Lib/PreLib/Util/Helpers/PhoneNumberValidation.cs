using System.Text.RegularExpressions;
using Utilities.ArgumentEvaluation;
using Utilities.Entity;
using Utilities.ReturnType;

namespace Utilities.Helpers;

public static class PhoneNumberValidation
{
    private static string ausRegEx = @"^\({0,1}((0|\+61)(2|4|3|7|8)){0,1}\){0,1}(\ |-){0,1}[0-9]{2}(\ |-){0,1}[0-9]{2}(\ |-){0,1}[0-9]{1}(\ |-){0,1}[0-9]{3}$";
    private static string usaRegEx = @"\D*([2-9]\d{2})(\D*)([2-9]\d{2})(\D*)(\d{4})\\D*";
    private static string canRegEx = @"\D*([2-9]\d{2})(\D*)([2-9]\d{2})(\D*)(\d{4})\\D*";

    public static ReturnValue<string> IsPhoneNumber(string input, string iso3)
    {
        try
        {
            EvaluateArgument.Execute(input, fn => !string.IsNullOrWhiteSpace(input), "Phone number cannot be empty");
            var trialNumber = PhoneNumber.TryGetValidPhoneNumberDigits(input);

            if (trialNumber.IsValid)
            {
                var reg = (iso3.Equals(Country.Australia.IsoAlpha3Code, StringComparison.OrdinalIgnoreCase) ?
                    ausRegEx :
                    iso3.Equals(Country.Canada.IsoAlpha3Code, StringComparison.OrdinalIgnoreCase)
                        ? canRegEx
                        : usaRegEx
                    );

                if (Regex.IsMatch(trialNumber.Result!, reg, RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)))
                {
                    return ReturnValue<string>.From(trialNumber.Result!);
                }
            }

            return ReturnValue<string>.FromError($"{input} fails phone number checks");
        }
        catch (ArgumentException aex)
        {
            return ReturnValue<string>.FromError(aex);
        }
        catch (Exception ex)
        {
            return ReturnValue<string>.FromError(ex);
        }
    }
}
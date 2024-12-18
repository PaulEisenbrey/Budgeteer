using System.Text.RegularExpressions;
using Utilities.ArgumentEvaluation;
using Utilities.Constants.Strings;
using Utilities.Extension.StringExtension;
using Utilities.ReturnType;

namespace Utilities.Entity;

public class PhoneNumber : IFormattable
{
    private readonly string digits;

    private static readonly Regex ValidAustraliaNumberExpression = new Regex(StringSpace.PhoneStrings.ValidAustraliaNumber);

    private static readonly Regex ValidNorthAmericaNumberExpression = new Regex(StringSpace.PhoneStrings.ValidNorthAmericaNumber);

    public PhoneNumber(string telephoneNumber)
    {
        EvaluateArgument.Execute(telephoneNumber, fn => !string.IsNullOrEmpty(telephoneNumber), "telephoneNumber cannot be empty");

        telephoneNumber = RemoveOnePrefixIfApplicable(telephoneNumber);
        string text = string.Concat(telephoneNumber.Where(char.IsDigit));

        EvaluateArgument.Execute(telephoneNumber, fn => IsValidPhoneNumber(telephoneNumber), $"telephoneNumber {telephoneNumber} is invalid");

        digits = text;
    }

    public static bool TryParse(string s, out PhoneNumber? result)
    {
        result = null;
        if (string.IsNullOrWhiteSpace(s))
        {
            return false;
        }

        s = RemoveOnePrefixIfApplicable(s);
        if (!IsValidPhoneNumber(s))
        {
            return false;
        }

        result = new PhoneNumber(s);
        return true;
    }

    public static ReturnValue<PhoneNumber> Create(string phoneNumber) =>
        TryParse(phoneNumber, out PhoneNumber? result)
        ? ReturnValue<PhoneNumber>.From(result!)
        : ReturnValue<PhoneNumber>.FromError($"Invalid Phone Number {phoneNumber}");

    public static bool IsValidPhoneNumber(string s)
    {
        return IsValidAustralia(s) || IsValidNorthAmerica(s);
    }

    public static bool IsValidNorthAmerica(string s)
    {
        string? text = Prevalidate(s);
        return string.IsNullOrWhiteSpace(text) ? false : ValidNorthAmericaNumberExpression.IsMatch(text);
    }

    public static bool IsValidAustralia(string s)
    {
        string? text = Prevalidate(s);
        return string.IsNullOrWhiteSpace(text) ? false : ValidAustraliaNumberExpression.IsMatch(text);
    }

    private static string? Prevalidate(string s)
    {
        if (string.IsNullOrWhiteSpace(s))
        {
            return null;
        }

        s = RemoveOnePrefixIfApplicable(s);
        return string.Concat(s.Where(char.IsDigit));
    }

    public static ReturnValue<string> TryGetValidPhoneNumberDigits(string proposedPhoneNumber)
    {
        try
        {
            EvaluateArgument.Execute(proposedPhoneNumber, fn => !string.IsNullOrWhiteSpace(proposedPhoneNumber), "Phone number cannot be empty");

            proposedPhoneNumber = RemoveOnePrefixIfApplicable(proposedPhoneNumber);
            string text = string.Concat(proposedPhoneNumber.Where(char.IsDigit));

            if (IsValidPhoneNumber(text))
            {
                return ReturnValue<string>.From(text);
            }

            return ReturnValue<string>.FromError($"{proposedPhoneNumber} is an invalid phone number");
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

    public static implicit operator string(PhoneNumber? telephoneNumber)
    {
        return telephoneNumber?.ToString().NullIfEmpty() ?? "";
    }

    public static implicit operator PhoneNumber(string? value) => !string.IsNullOrEmpty(value) ? new PhoneNumber(value) : new PhoneNumber("4257779999");

    private static string RemoveOnePrefixIfApplicable(string telephoneNumber)
    {
        if (telephoneNumber.StartsWith("1"))
        {
            return telephoneNumber.Substring(1);
        }

        return telephoneNumber;
    }

    public override string ToString() => ToString("P");

    public string ToString(string? format, IFormatProvider? formatProvider = null) => FormatStringAsPhoneNumber(digits, format ?? "");

    public static string FormatStringAsPhoneNumber(string phoneNumber, string format = "P")
    {
        if (string.IsNullOrWhiteSpace(phoneNumber))
        {
            return phoneNumber;
        }

        if (string.IsNullOrEmpty(format))
        {
            format = "P";
        }

        string text = format;
        string text2 = text;
        if (!(text2 == "P"))
        {
            if (text2 == "N")
            {
                return phoneNumber;
            }

            throw new FormatException(format + " is an unrecognized format.  Valid values are P,N.");
        }

        if (IsValidAustralia(phoneNumber))
        {
            if (phoneNumber.Length == 10)
            {
                return "(" + phoneNumber.Substring(0, 2) + ") " + phoneNumber.Substring(2, 4) + "-" + phoneNumber.Substring(6, 4);
            }

            return phoneNumber;
        }

        if (IsValidNorthAmerica(phoneNumber))
        {
            return "(" + phoneNumber.Substring(0, 3) + ") " + phoneNumber.Substring(3, 3) + "-" + phoneNumber.Substring(6, 4);
        }

        return phoneNumber;
    }
}
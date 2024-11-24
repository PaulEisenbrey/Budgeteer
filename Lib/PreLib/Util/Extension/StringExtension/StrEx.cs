using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using Utilities.ArgumentEvaluation;
using Utilities.Entity;
using Utilities.ReturnType;

namespace Utilities.Extension.StringExtension;

public static class StrExt
{
    public static string? NullIfEmpty(this string? s) => string.IsNullOrEmpty(s) ? null : s;

    public static string? NullIfWhiteSpace(this string s) => string.IsNullOrWhiteSpace(s) ? null : s;

    public static string DecimalToCurrency(this string str, decimal amount) => str + string.Format("{0:C2}", amount);

    public static bool IsNumeric(this string input)
    {
        EvaluateArgument.Execute(input, fn => !string.IsNullOrWhiteSpace(input), "Cannot evaluate an empty string");

        var t = input.FirstOrDefault(ch => !char.IsDigit(ch));
        return t != default;
    }

    public static bool ContainsWhiteSpace(this string input) => input.Any(x => Char.IsWhiteSpace(x));

    public static bool IsZip(this string input, string iso3Country)
    {
        if (iso3Country == Country.UnitedStatesOfAmerica.IsoAlpha3Code)
        {
            return UsZipCode(input);
        }
        else if (iso3Country == Country.Canada.IsoAlpha3Code)
        {
            return CanadaPostalCode(input);
        }
        else if (iso3Country == Country.Australia.IsoAlpha3Code)
        {
            return AustraliaPostCode(input);
        }

        return false;
    }

    public static string RemoveNonNumeric(this string str)
    {
        if (string.IsNullOrWhiteSpace(str))
        {
            throw new ArgumentNullException(nameof(str));
        }

        return Regex.Replace(str, @"[^0-9]+", "");
    }

    public static bool AustraliaPostCode(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return false;
        }

        // AUS Post Code in the format of "9999"
        return input.Length == 4 && input.IsNumeric();
    }

    public static bool UsZipCode(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return false;
        }

        // US ZIP Code in the format of "99999"
        return input.Length == 5 && input.IsNumeric();
    }

    public static bool CanadaPostalCode(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return false;
        }

        // Canadian Postal Code in the format of "X9X 9X9" or "X9X"
        string caZipRegEx
            = "^[ABCEGHJ-NPRSTVXY]{1}[0-9]{1}[ABCEGHJ-NPRSTV-Z]{1}[ ]?[0-9]{1}[ABCEGHJ-NPRSTV-Z]{1}[0-9]{1}$";
        return Regex.Match(input.ToUpper(), caZipRegEx).Success;
    }

    public static string RemoveDiacritics(this string src)
    {
        var normalizedString = src.Normalize(NormalizationForm.FormD);

        return new StringBuilder().AppendSequence(
                normalizedString,
                (sb, ch) => sb.AppendWhen(
                    () => CharUnicodeInfo.GetUnicodeCategory(ch) != UnicodeCategory.NonSpacingMark,
                    sbldr => sbldr.Append(ch)))
            .ToString()
            .Normalize(NormalizationForm.FormC);
    }

    public static bool IsDigitsOnly(this string testVal)
    {
        return !testVal.Any(x => (x < '0' || x > '9'));
    }

    public static string TrimLastCharacter(this String str) => 
        string.IsNullOrEmpty(str) ? str : str.Remove(str.Length - 1);

    /// <summary>
    /// Generate a random alpha numeric string. String will always start with a letter, so it can be a valid identifier.
    /// </summary>
    /// <param name="length">length of string to return.</param>
    /// <returns>Random String</returns>
    public static string GetRandomAlphaNumericString(int length = 8)
    {
        Random random = new Random(Guid.NewGuid().GetHashCode());
        var chars = "abcdefghijklmnopqrstuvwxyz0123456789";
        string s = new string(chars.Select(c => chars[random.Next(chars.Length)]).Take(length - 1).ToArray());
        return "A" + s;
    }
}
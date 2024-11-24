namespace Utilities.Constants.Enum;

public interface IVersionAware
{
    byte[]? ConcurrencyToken { get; set; }
}
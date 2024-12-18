namespace Utilities.Conversion
{
    public interface ILegacyCryptoProvider
    {
        string? Decrypt(string text);

        string? Encrypt(string text);
    }
}
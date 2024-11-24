namespace Utilities.Conversion
{
    public interface IEncryptor
    {
        string? Decrypt(string text);
        string? Encrypt(string text);
    }
}
using System.Security.Cryptography;
using System.Text;

using Utilities.IoCInterfaces;

namespace Utilities.Conversion;

public class LegacyCryptoProvider : ILegacyCryptoProvider, IEncryptor, ISingletonSvc
{
    private const string CryptoKey = "^J&P*X%W><:LPO&%^XW@~!@?";
    private readonly ICryptoTransform decryptor;
    private readonly ICryptoTransform encryptor;
    private readonly byte[] initializationVector = new byte[] { 12, 35, 145, 9, 10, 26, 13, 39 };

    public LegacyCryptoProvider()
    {
#pragma warning disable SYSLIB0021 // Type or member is obsolete
        using (var cryptoProvider = new TripleDESCryptoServiceProvider())
        {
            this.encryptor = cryptoProvider.CreateEncryptor(Encoding.ASCII.GetBytes(CryptoKey), this.initializationVector);
            this.decryptor = cryptoProvider.CreateDecryptor(Encoding.ASCII.GetBytes(CryptoKey), this.initializationVector);
        }
#pragma warning restore SYSLIB0021 // Type or member is obsolete
    }

    public string? Decrypt(string text)
    {
        if (text != null)
        {
            // Convert the encrypted into bytes, decrypt, convert to string.
            byte[] inputBuffer = Convert.FromBase64String(text);
            byte[] outputBuffer = this.decryptor.TransformFinalBlock(inputBuffer, 0, inputBuffer.Length);

            return Encoding.ASCII.GetString(outputBuffer);
        }

        return null;
    }

    public string? Encrypt(string text)
    {
        if (text != null)
        {
            // Convert the password into bytes, encrypt, convert to string.
            byte[] inputBuffer = Encoding.ASCII.GetBytes(text);
            byte[] outputBuffer = this.encryptor.TransformFinalBlock(inputBuffer, 0, inputBuffer.Length);
            string encrypted = Convert.ToBase64String(outputBuffer);

            return encrypted;
        }

        return null;
    }
}
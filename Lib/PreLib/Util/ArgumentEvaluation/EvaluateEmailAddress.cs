using System.Net.Mail;

namespace Utilities.ArgumentEvaluation;

public static class EvaluateEmailAddress
{
    public static void Execute(string emailAddress, string failMessage)
    {
        try
        {
            _ = new MailAddress(emailAddress);
        }
        catch (System.Exception ex)
        {
            throw new ArgumentException($"{failMessage}: {ex.Message}. {ex.InnerException}");
        }
    }
}
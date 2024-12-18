namespace Utilities.Logging;

public class LogQueueItem
{
    private string errText = "";
    public LogLevel Level { get; private set; }

    public DateTime TimeStamp { get; private set; }

    public string ErrorText
    {
        get
        {
            return errText;
        }

        private set
        {
            this.errText = value;
            this.TimeStamp = DateTime.Now;
        }
    }

    public LogQueueItem SetErrorLevel(LogLevel logLevel)
    {
        this.Level = logLevel;
        return this;
    }

    public LogQueueItem SetErrorText(string text)
    {
        this.ErrorText = text;
        return this;
    }
}
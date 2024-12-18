using System.Diagnostics;
using Utilities.Extension;

namespace Utilities.Logging;

public class LogWriter
{
    private LogLevel floor = LogLevel.error;
    private readonly string fileName = $"{AppDomain.CurrentDomain.BaseDirectory}//log.txt";
    private readonly object locker = new();
    private const int maxLogLen = (1024 * 1000000);
    private const string timeFormat = "MM/dd/yyyy HH:mm:ss";

    public void Execute(LogQueueItem logEntry)
    {
        if ((int)logEntry.Level >= (int)floor)
        {
            var entry = this.FormatEntry(logEntry);
            Trace.WriteLine(entry);
            this.WriteToFile(entry);
        }
    }

    public void Execute(ICollection<LogQueueItem> logEntry)
    {
        foreach (var logItem in logEntry)
        {
            this.Execute(logItem);
        }
    }

    public void SetFloor(LogLevel newFloor)
    {
        this.floor = newFloor;
    }

    private void WriteToFile(string entry)
    {
        FileInfo fi = new FileInfo(this.fileName);
        if (fi.Exists && fi.Length > maxLogLen)  // cap at around a MB
        {
            lock (locker)
            {
                if (fi.Exists && fi.Length > maxLogLen)  // cap at around a MB
                {
                    File.Move(fileName, $"{AppDomain.CurrentDomain.BaseDirectory}//log.{DateTime.Now.Ticks}");
                }
            }
        }

        lock (locker)
        {
            using (StreamWriter outputFile = new StreamWriter(fileName, true))
            {
                outputFile.Write(entry);
            }
        }
    }

    private string FormatEntry(LogQueueItem logEntry) =>
        $"[{logEntry.Level.Description()}] [{logEntry.TimeStamp.ToString(timeFormat)}]\t{logEntry.ErrorText}\r\n";
}
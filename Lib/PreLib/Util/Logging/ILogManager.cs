namespace Utilities.Logging;

public interface ILogManager
{
    ILog? GenerateLogger();

    void SetLogLevelFloor(LogLevel newLevel);

    void Enqueue(LogQueueItem logData);

    void KillQueue();
}
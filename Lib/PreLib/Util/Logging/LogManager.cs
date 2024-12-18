using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using Utilities.IoCInterfaces;

namespace Utilities.Logging;

public class LogManager : ILogManager, ISingletonSvc
{
    private LogQueue logQueue = new();
    private bool exitThread = false;
    private LogWriter logWriter = new LogWriter();
    private bool isInitialized = false;
    private object locker = new();

    private IHost? di = null;

    public LogManager(IHost host)
    {
        this.di = host;
        this.Initialize();
    }

    private void Initialize()
    {
        if (!isInitialized)
        {
            lock (locker)
            {
                if (!isInitialized)
                {
                    StartQueue();
                    isInitialized = true;
                }
            }
        }
    }

    public ILog? GenerateLogger() => this.di?.Services.GetService<ILog>() ?? null;

    public void SetLogLevelFloor(LogLevel newLevel) => this.logWriter.SetFloor(newLevel);

    public void Enqueue(LogQueueItem logData) => logQueue.Enqueue(logData);

    public void KillQueue() => exitThread = true;

    private void StartQueue() => ThreadPool.QueueUserWorkItem(QueueWorker);

    public void QueueWorker(object? obj)
    {
        var workToDoEvent = logQueue.ObtainNewEntryEvent();

        while (!exitThread)
        {
            var res = workToDoEvent.WaitOne(1000);
            if (res)
            {
                List<LogQueueItem> entries = new();
                var logItem = logQueue.Dequeue();
                while (null != logItem)
                {
                    entries.Add(logItem);
                    if (exitThread)
                    {
                        break;
                    }

                    logItem = logQueue.Dequeue();
                }

                // tell the log implementation about it.
                Task.Run(() =>
                {
                    if (!exitThread)
                    {
                        logWriter.Execute(entries);
                    }
                });
            }
        }
    }
}
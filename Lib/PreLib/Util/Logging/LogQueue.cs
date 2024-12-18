using System.Collections.Concurrent;

namespace Utilities.Logging;

public class LogQueue
{
    private readonly ConcurrentQueue<LogQueueItem> queue = new ConcurrentQueue<LogQueueItem>();
    private readonly object locker = new object();
    private AutoResetEvent logEntryReceived = new AutoResetEvent(false);

    public AutoResetEvent ObtainNewEntryEvent() => this.logEntryReceived;

    public void Enqueue(LogQueueItem item)
    {
        lock (locker)
        {
            queue.Enqueue(item);
        }

        logEntryReceived.Set();
    }

    public LogQueueItem? Dequeue()
    {
        lock (locker)
        {
            var retItem = new LogQueueItem();
            if (this.queue.TryDequeue(out retItem))
            {
                return retItem;
            }
        }

        return null;
    }
}
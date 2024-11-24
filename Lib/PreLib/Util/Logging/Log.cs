using Microsoft.Data.SqlClient;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using Utilities.IoCInterfaces;

namespace Utilities.Logging;

public class Log : ILog, ITransientSvc
{
    private readonly IHost di;
    private readonly ILogManager? logManager;

    public Log(IHost depInjector)
    {
        di = depInjector;
        this.logManager = di.Services.GetService<ILogManager>();
        if (null == logManager)
        {
            var errStr = "Unable to create log manager";
            ConsoleOutPut.WriteVerbose(errStr);
            throw new Exception(errStr);
        }
    }

    public void WriteError(string message) => this.WriteToQueue(message, LogLevel.error);

    public void WriteError<T>(T exception) where T : Exception =>
        this.WriteToQueue($"Unexpected Exception: {exception.Message}. {exception.InnerException}", LogLevel.error);

    public void WriteError(SqlException sqex) =>
        this.WriteToQueue($"Unexpected SQL Exception: {sqex.Message}. {sqex.InnerException} {sqex.StackTrace}", LogLevel.error);

    public void WriteFatal(string message) => this.WriteToQueue(message, LogLevel.fatal);

    public void WriteFatal<T>(T exception) where T : Exception =>
        this.WriteToQueue($"Unexpected Exception: {exception.Message}. {exception.InnerException}", LogLevel.fatal);

    public void WriteInfo(string message) => this.WriteToQueue(message, LogLevel.info);

    public void WriteInfo<T>(T exception) where T : Exception =>
            this.WriteToQueue($"Unexpected Exception: {exception.Message}. {exception.InnerException}", LogLevel.info);

    public void WriteTrace(string message) => this.WriteToQueue(message, LogLevel.trace);

    public void WriteTrace<T>(T exception) where T : Exception =>
            this.WriteToQueue($"Unexpected Exception: {exception.Message}. {exception.InnerException}", LogLevel.trace);

    public void WriteWarn(string message) => this.WriteToQueue(message, LogLevel.warn);

    public void WriteWarn<T>(T exception) where T : Exception =>
            this.WriteToQueue($"Unexpected Exception: {exception.Message}. {exception.InnerException}", LogLevel.warn);

    private void WriteToQueue(string message, LogLevel logLevel) =>
        this.logManager?.Enqueue(new LogQueueItem().SetErrorText(message).SetErrorLevel(logLevel));
}
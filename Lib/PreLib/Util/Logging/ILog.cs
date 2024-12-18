namespace Utilities.Logging;

public interface ILog
{
    void WriteFatal(string message);

    void WriteFatal<T>(T exception) where T : Exception;

    void WriteError(string message);

    void WriteError<T>(T exception) where T : Exception;

    void WriteWarn(string message);

    void WriteWarn<T>(T exception) where T : Exception;

    void WriteInfo(string message);

    void WriteInfo<T>(T exception) where T : Exception;

    void WriteTrace(string message);

    void WriteTrace<T>(T exception) where T : Exception;
}
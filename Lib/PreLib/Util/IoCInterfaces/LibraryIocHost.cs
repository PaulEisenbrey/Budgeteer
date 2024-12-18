using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Diagnostics;
using Utilities.ArgumentEvaluation;

namespace Utilities.IoCInterfaces;

public static class LibraryIocHost
{
    private static IHost? _host { get; set; }

    public static void Initialize(IHost host)
    {
        _host = host;
    }

    public static T? Resolve<T>() where T : class
    {
        try
        {
            EvaluateArgument.Execute(_host, fn => null != _host, "Host is not initialized");
            return _host!.Services.GetService<T>();
        }
        catch (InvalidOperationException ioEx)
        {
            Debug.WriteLine($"{ioEx.Message}. {ioEx.InnerException}");
        }
        catch (System.Exception ex)
        {
            Debug.WriteLine($"{ex.Message}. {ex.InnerException}");
        }

        return null;
    }

    public static IEnumerable<T>? ResolveMany<T>() where T : class
    {
        EvaluateArgument.Execute(_host, fn => null != _host, "Host is not initialized");
        return _host!.Services.GetServices<T>();
    }
}
using Database.BaseClasses.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Diagnostics;
using Utilities;
using Utilities.ArgumentEvaluation;
using Utilities.IoCInterfaces;

namespace IoC;

public class IocServiceFactory : Singleton<IocServiceFactory>, IDisposable
{
    private IHost? _host = null;
    private readonly object locker = new object();

    protected IocServiceFactory()
    {
    }

    public void Initialize()
    {
        if (null == _host)
        {
            lock (this.locker)
            {
                if (null == _host)
                {
                    _host = Host.CreateDefaultBuilder()
                    .UseDefaultServiceProvider((context, options) =>
                    {
                        options.ValidateScopes = true;
                    })
                    .ConfigureServices((context, services) =>
                    {
                        services.Scan(t => t.FromApplicationDependencies()
                        .AddClasses(t => t.AssignableTo<IDatabaseCrud>())
                            .AsMatchingInterface()
                                .WithTransientLifetime()
                        .AddClasses(t => t.AssignableTo<ISingletonSvc>())
                            .AsMatchingInterface()
                                .WithSingletonLifetime()
                        .AddClasses(t => t.AssignableTo<ITransientSvc>())
                            .AsMatchingInterface()
                                .WithTransientLifetime()
                        .AddClasses(t => t.AssignableTo<IScopedSvc>())
                            .AsMatchingInterface()
                                .WithScopedLifetime()
                                );
                    }).Build();

                    LibraryIocHost.Initialize(_host);
                }
            }
        }

        EvaluateArgument.Execute(_host, fn => null != _host, "Host is not initialized");
    }

    public T? Resolve<T>() where T : class
    {
        try
        {
            EvaluateArgument.Execute(_host, fn => null != _host, "Host is not initialized");
            return this._host!.Services.GetService<T>();
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

    public IEnumerable<T>? ResolveMany<T>() where T : class
    {
        EvaluateArgument.Execute(_host, fn => null != _host, "Host is not initialized");
        return this._host!.Services.GetServices<T>();
    }

    public void Dispose()
    {
        this._host?.Dispose();
    }
}
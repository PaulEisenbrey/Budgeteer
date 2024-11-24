using System.Diagnostics;
using System.Reflection;

namespace Utilities;

public abstract class Singleton<TInstance> where TInstance : class
{
    private static TInstance? instance;

    public static TInstance? Instance => instance;

    static Singleton()
    {
        try
        {
            var constructor = typeof(TInstance).GetConstructor(
                BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic,
                null,
                Type.EmptyTypes,
                null);

            instance = (TInstance?)constructor?.Invoke(null) ?? null;
        }
        catch (Exception exception)
        {
            Debug.WriteLine(exception);
            throw;
        }
    }
}
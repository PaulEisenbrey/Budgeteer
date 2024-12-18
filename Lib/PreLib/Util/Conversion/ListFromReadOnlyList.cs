using Utilities.ArgumentEvaluation;
using Utilities.ReturnType;

namespace Utilities.Conversion;

public static class ListFromReadonlyList
{
    public static List<T> Execute<T>(IReadOnlyList<T>? rhs) where T : class
    {
        EvaluateArgument.Execute(rhs, fn => rhs != null, "Cannot convert NULL list");

        var retList = new List<T>();
        if (null != rhs)
        {
            retList.AddRange(rhs);
        }

        return retList;
    }

    public static List<T> Execute<T>(ReturnValue<IReadOnlyList<T>>? rhs) where T : class
    {
        EvaluateArgument.Execute(rhs, fn => rhs != null, "Cannot convert NULL list");
        EvaluateArgument.Execute(rhs, fn => rhs?.IsValid ?? false, rhs?.ErrorText ?? "No Error Listed");
        EvaluateArgument.Execute(rhs, fn => rhs?.Result != null, "Cannot convert NULL Result");

        var retList = new List<T>();
        if (null != rhs && rhs.IsValid && null != rhs.Result)
        {
            retList.AddRange(rhs.Result);
        }

        return retList;
    }
}
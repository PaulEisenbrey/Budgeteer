using System.Diagnostics;

namespace Utilities.ArgumentEvaluation;

public static class EvaluateArgument
{
    public static void Execute<T>(T? value, Func<T?, bool>? filter, string failMessage, EvaluateType eval = EvaluateType.et_throw)
    {
        if (null == filter)
        {
            return;
        }

        if (!filter.Invoke(value))
        {
            switch (eval)
            {
                case EvaluateType.et_throw:
                    throw new ArgumentException(failMessage);

                case EvaluateType.et_console:
                    Console.WriteLine(failMessage);
                    break;

                case EvaluateType.et_debugwindow:
                    Debug.WriteLine(failMessage);
                    break;
            }
        }
    }
}
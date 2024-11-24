using Microsoft.Extensions.Logging;

using Utilities.ArgumentEvaluation;
using Utilities.Constants.Enum;
using Utilities.Logging;
using Utilities.Tools.Interfaces;

namespace Database.Tools;

public class RotatingValueBase<T> : IRotatingValue<T>
{
    private int location = 0;
    private List<T> values = new();
    private object locker = new();

    private readonly ILog? logger;

    public RotatingValueBase(ILogManager logMgr)
    {
        this.logger = logMgr.GenerateLogger();
        EvaluateArgument.Execute(this.logger, fn => null != this.logger, "Unable to create logger");
    }

    public int Count
    {
        get
        {
            return this.values.Count;
        }
    }

    public virtual bool HandlesType(RotatorType rt)
    {
        throw new NotImplementedException("HandlesType");
    }

    public void SpinRotator(int spinCount)
    {
        for (int idx = 0; idx < spinCount; ++idx)
        {
            this.GetNext();
        }
    }

    public T GetNext()
    {
        if (!values.Any())
        {
            string err = "Underlying collection is not initialized";
            logger!.WriteError(err);
            throw new Exception(err);
        }

        lock (this.locker)
        {
            if (this.location >= values.Count)
            {
                this.location = 0;
            }

            T returnItem = this.values[this.location];

            Interlocked.Increment(ref this.location);

            return returnItem;
        }
    }

    public void ShiftLocationPointer(int newLocation)
    {
        int max = this.values.Count - 1;

        if (newLocation > max)
        {
            while (newLocation-- > max) ;
        }

        this.location = newLocation;
    }

    public virtual void Initialize(IEnumerable<T> collection)
    {
        if (!values.Any())
        {
            lock (this.locker)
            {
                if (!values.Any())
                {
                    this.values.AddRange(collection);
                }
            }
        }
    }
}
using Database.Tools.Interfaces;
using Utilities.Constants.Enum;
using Utilities.IoCInterfaces;
using Utilities.Logging;
using Utilities.Tools.Interfaces;

namespace Database.Tools;

public class RotatingDeductible : RotatingValueBase<decimal>, IRotatingValue<decimal>, IRotatingDeductible, ISingletonSvc
{
    public RotatingDeductible(ILogManager logManager) : base(logManager)
    {
        List<decimal> deductibles = new List<decimal>();
        for (int i = 50; i < 1000; i += 5)
        {
            deductibles.Add((decimal)i);
        }

        this.Initialize(deductibles);
    }

    public override bool HandlesType(RotatorType rt)
    {
        return RotatorType.Deductible == rt;
    }
}
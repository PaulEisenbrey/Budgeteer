using Database.Tools.Interfaces;
using Utilities.Constants.Enum;
using Utilities.IoCInterfaces;
using Utilities.Logging;
using Utilities.Tools.Interfaces;

namespace Database.Tools;

public class RotatingAge : RotatingValueBase<AgeType>, IRotatingValue<AgeType>, IRotatingAge, ISingletonSvc
{
    public RotatingAge(ILogManager logManager) : base(logManager)
    {
        List<AgeType> ageTypes = new();

        ageTypes.Add(AgeType.ZeroTo7Weeks);
        ageTypes.Add(AgeType.EightWeeksTo12Months);
        ageTypes.Add(AgeType.OneYear);
        ageTypes.Add(AgeType.TwoYears);
        ageTypes.Add(AgeType.ThreeYears);
        ageTypes.Add(AgeType.FourYears);
        ageTypes.Add(AgeType.FiveYears);
        ageTypes.Add(AgeType.SixYears);
        ageTypes.Add(AgeType.SevenYears);
        ageTypes.Add(AgeType.EightYears);
        ageTypes.Add(AgeType.NineYears);
        ageTypes.Add(AgeType.TenYears);
        ageTypes.Add(AgeType.ElevenYears);
        ageTypes.Add(AgeType.TwelveYears);

        this.Initialize(ageTypes);
    }

    public override bool HandlesType(RotatorType t) => t == RotatorType.Age;
}
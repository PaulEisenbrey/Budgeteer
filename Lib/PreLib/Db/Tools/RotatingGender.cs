using Database.Tools.Interfaces;
using Utilities.Constants.Enum;
using Utilities.IoCInterfaces;
using Utilities.Logging;
using Utilities.Tools.Interfaces;

namespace Database.Tools;

public class RotatingGender : RotatingValueBase<Gender>, IRotatingValue<Gender>, IRotatingGender, ISingletonSvc
{
    public RotatingGender(ILogManager logManager) : base(logManager)
    {
        // set the sequence to 'limp' a bit. 2 phase lists tend to lock together, and we don't want that.
        this.Initialize(new List<Gender>() { Gender.Female, Gender.Female, Gender.Male, Gender.Female, Gender.Male });
    }

    public override bool HandlesType(RotatorType rt) => RotatorType.Gender == rt;
}
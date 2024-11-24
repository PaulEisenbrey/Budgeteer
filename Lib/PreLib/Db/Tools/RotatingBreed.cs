using Database.Tools.Interfaces;
using Database.Trupanion.Entity.TruDat.Dbo;
using Utilities.Constants.Enum;
using Utilities.IoCInterfaces;
using Utilities.Logging;
using Utilities.Tools.Interfaces;

namespace Database.Tools;

public class RotatingBreed : RotatingValueBase<TruDatDboBreed>, IRotatingValue<TruDatDboBreed>, IRotatingBreed, ISingletonSvc
{
    public RotatingBreed(ILogManager logMgr) : base(logMgr)
    {

    }

    public override bool HandlesType(RotatorType t) => t == RotatorType.Breed;
}

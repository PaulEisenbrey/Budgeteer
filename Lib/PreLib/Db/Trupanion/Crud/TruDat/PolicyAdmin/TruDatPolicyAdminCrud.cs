using Database.BaseClasses;
using Database.BaseClasses.Interfaces;
using Database.Trupanion.Crud.Interfaces;
using Utilities.Logging;

namespace Database.Trupanion.Crud.TruDat.PolicyAdmin;

public class TruDatPolicyAdminCrud : QaLibCrud, IQaLibCrud, ITruDatPolicyAdminCrud
{
    public TruDatPolicyAdminCrud(ILogManager logMgr) : base(logMgr)
    {
    }
}
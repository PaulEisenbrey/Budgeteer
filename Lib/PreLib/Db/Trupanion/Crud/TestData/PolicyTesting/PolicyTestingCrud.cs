using Microsoft.EntityFrameworkCore;
using Database.BaseClasses;
using Database.BaseClasses.Interfaces;
using Database.Trupanion.Context;
using Database.Trupanion.Crud.Interfaces;
using Database.Trupanion.Entity.TestData.PolicyTesting;
using Utilities.Logging;
using Utilities.ReturnType;


namespace Database.Trupanion.Crud.TestData.PolicyTesting;

public class PolicyTestingCrud : QaLibCrud, IQaLibCrud, IPolicyTestingCrud
{
    public PolicyTestingCrud(ILogManager logMgr) : base(logMgr)
    {
    }

    public async Task<ReturnValue<List<TestDataPolicyTestingState>>> RetrieveLegacyStates(TestDataPolicyTestingContext? context = null)
    {
        var states = await this.EnsureContext(context).States.Where(st => st.IsLegacy).ToListAsync().ConfigureAwait(false);
        return ReturnValue<List<TestDataPolicyTestingState>>.From(states);
    }

    public async Task<ReturnValue<List<TestDataPolicyTestingState>>> RetrieveNonLegacyStates(TestDataPolicyTestingContext? context = null)
    {
        var newstates = await this.EnsureContext(context).States.Where(st => !st.IsLegacy).ToListAsync().ConfigureAwait(false);
        return ReturnValue<List<TestDataPolicyTestingState>>.From(newstates);
    }

    public async Task<ReturnValue<List<TestDataPolicyTestingStateColumnOffset>>> RetrieveOffsets(TestDataPolicyTestingContext? context = null)
    {
        var offsets = await this.EnsureContext(context).StateColumnOffsets.ToListAsync().ConfigureAwait(false);
        return ReturnValue<List<TestDataPolicyTestingStateColumnOffset>>.From(offsets);
    }
}

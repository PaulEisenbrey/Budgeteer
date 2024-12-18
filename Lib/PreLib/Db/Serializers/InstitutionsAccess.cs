using Database.BaseClasses;
using Database.BaseClasses.Interfaces;
using Database.Context;
using Database.Models;
using System.Linq.Expressions;
using Utilities.ArgumentEvaluation;
using Utilities.Logging;
using Utilities.ReturnType;

namespace Database.Serializers
{
    public class InstitutionsAccess : DatabaseCrud, IDatabaseCrud, IInstitutionsAccess
    {
        public InstitutionsAccess(ILogManager logMgr) : base(logMgr){ }

        public async Task<ReturnValue<Institution>> LoadInstitutionTreeAsync(int institutionId, BudgeteerContext? context = null)
        {
            var ctx = this.EnsureContext(context);

            Expression<Func<Institution, bool>> predicate = inst => inst.Id == institutionId;
            var institution = await this.RetrieveByQueryAsync(predicate, ctx);

            if (!institution.IsValid)
            {
                return ReturnValue<Institution>.FromError(institution.ErrorText);
            }

            var inst = institution.Result;
            EvaluateArgument.Execute(inst, fn => inst != null, "unable to view institution");

            Expression<Func<AccountDatum, bool>> adPredicate = ad => ad.InstitutionId == inst!.Id;
            _ = await this.RetrieveManyByQueryAsync(adPredicate, ctx);

            foreach (var account in inst!.AccountData)
            {
                Expression<Func<BtTransaction, bool>> transPredicate = trans => trans.AccountDatumId == account.Id;
                _ = await this.RetrieveManyByQueryAsync(transPredicate, ctx);
            }

            return ReturnValue<Institution>.From(inst!);
        }

        public async Task<ReturnValue<int>> CreateNewInstitution(Institution newInst, BudgeteerContext? context = null)
        {
            var ctx = this.EnsureContext(context);
            var val = await this.CreateAsync(newInst, ctx);

            return val.IsValid ? ReturnValue<int>.From(val.Result) : ReturnValue<int>.FromError(val.ErrorText);
        }
    }
}

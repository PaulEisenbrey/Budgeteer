using System.Linq.Expressions;

using Microsoft.Data.SqlClient;

using Database.BaseClasses;
using Database.BaseClasses.Interfaces;
using Database.TestData.QuoteDbo;
using Database.Trupanion.Entity.Quote.Dbo;
using Utilities.ArgumentEvaluation;
using Utilities.Logging;
using Utilities.ReturnType;

namespace Database.Trupanion.Crud.Quote.Dbo;

public class QuoteDboCrud : QaLibCrud, IQaLibCrud, IQuoteDboCrud
{
    public QuoteDboCrud(ILogManager logMgr) : base(logMgr)
    {
    }

    public async Task<ReturnValue<List<QuoteDboSelectedPolicyOption>>> RetrievePolicyOptionsByPetIdAsync(int petId, QuoteDboContext? context)
    {
        EvaluateArgument.Execute(petId, fn => 0 < petId, $"Pet Id must be a non-zero positive integer. Value received {petId}");
        var ctx = this.EnsureContext(context);
        Expression<Func<QuoteDboSelectedPolicyOption, bool>> predicate = option => option.Id == petId;

        try
        {
            var options = await this.RetrieveManyByQueryAsync(predicate, ctx).ConfigureAwait(false);

            EvaluateArgument.Execute(options, fn => null != options, $"Unable to retrieve options for pet id {petId}");
            EvaluateArgument.Execute(options, fn => options.IsValid, options.ErrorText);
            EvaluateArgument.Execute(options, fn => null != options.Result, $"No error, but no result for pet id {petId}");
            EvaluateArgument.Execute(options, fn => 0 != options.Result!.Count(), $"No options found for pet id {petId}");

            return ReturnValue<List<QuoteDboSelectedPolicyOption>>.From(options.Result!);
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<QuoteDboSelectedPolicyOption>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (ArgumentException aex)
        {
            Logger?.WriteError(aex);
            return ReturnValue<List<QuoteDboSelectedPolicyOption>>.FromError(aex);
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<List<QuoteDboSelectedPolicyOption>>.FromError(ex);
        }
    }

    public async Task<ReturnValue<List<QuoteDboSelectedWorkingPet>>> RetrieveWorkingPetByPetIdAsync(int petId, QuoteDboContext? context)
    {
        EvaluateArgument.Execute(petId, fn => 0 < petId, $"Pet Id must be a non-zero positive integer. Value received {petId}");
        var ctx = this.EnsureContext(context);
        Expression<Func<QuoteDboSelectedWorkingPet, bool>> predicate = option => option.Id == petId;

        try
        {
            var options = await this.RetrieveManyByQueryAsync(predicate, ctx).ConfigureAwait(false);

            EvaluateArgument.Execute(options, fn => null != options, $"Unable to retrieve Working Pet data for pet id {petId}");
            EvaluateArgument.Execute(options, fn => options.IsValid, options.ErrorText);
            EvaluateArgument.Execute(options, fn => null != options.Result, $"No error, but no Working Pet data for pet id {petId}");
            EvaluateArgument.Execute(options, fn => 0 != options.Result!.Count(), $"No Working Pet data found for pet id {petId}");

            return ReturnValue<List<QuoteDboSelectedWorkingPet>>.From(options.Result!);
        }
        catch (SqlException sqex)
        {
            Logger?.WriteError(sqex);
            return ReturnValue<List<QuoteDboSelectedWorkingPet>>.FromError(this.SqlExceptionFormat(sqex));
        }
        catch (ArgumentException aex)
        {
            Logger?.WriteError(aex);
            return ReturnValue<List<QuoteDboSelectedWorkingPet>>.FromError(aex);
        }
        catch (Exception ex)
        {
            Logger?.WriteError(ex);
            return ReturnValue<List<QuoteDboSelectedWorkingPet>>.FromError(ex);
        }
    }
}
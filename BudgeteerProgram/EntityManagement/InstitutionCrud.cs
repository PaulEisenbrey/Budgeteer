using System.Linq.Expressions;

using Budgeteer.EntityManagement.Interface;

using Database.BaseClasses;
using Database.Context;
using Database.POCO.Budgeteer;
using Database.POCO.Images;

using Microsoft.EntityFrameworkCore;

using Utilities.IoCInterfaces;
using Utilities.Logging;
using Utilities.ReturnType;

namespace Budgeteer.EntityManagement;
public class InstitutionCrud : DatabaseCrud, IInstitutionCrud, ISingletonSvc
{
    public InstitutionCrud(ILogManager logMgr) : base(logMgr)
    {

    }

    public ReturnValue<Institution> NewInstitution() =>
        ReturnValue<Institution>.From(new Institution());

    public async Task<ReturnValue<List<ActiveInstiutionNameAndId>>> GetActiveInstitutionHeaders(BudgeteerContext context)
    {
        var result = await context.Institutions.Where(i => !i.IsDeleted).ToListAsync();
        var headerList = result.Select(i => new ActiveInstiutionNameAndId
        {
            Id = i.Id,
            Name = i.Name ?? "Unknown",
            Nickname = i.Nickname ?? "Unk, To Friends"
        }).ToList();

        return null != result 
            ? ReturnValue<List<ActiveInstiutionNameAndId>>.From(headerList) 
            : ReturnValue<List<ActiveInstiutionNameAndId>>.FromError("No Results found");
    }

    public async Task<ReturnValue<int>> SaveNewInstitution(Institution institution, BudgeteerContext context)
    {
        if (institution.Id == 0)
        {
            return await base.CreateAsync<Institution, BudgeteerContext>(institution, context);
        }

        return ReturnValue<int>.FromError(0, new Exception("Invalid Id"));
    }

    public async Task<ReturnValue<int>> UpdateInstitution(Institution institution, BudgeteerContext context)
    {
        if (institution.Id != 0)
        {
            return await base.UpdateAsync<Institution, BudgeteerContext>(institution, context);
        }

        return ReturnValue<int>.FromError(0, new Exception("Invalid Id"));
    }

    public new async Task<ReturnValue<Institution>> RetrieveByIdAsync<T, IdType, C>(IdType id, C? context)
        where T : class
        where IdType : IConvertible
        where C : class, new()
    {
        var ctx = base.EnsureContext(context);
        if (ctx is BudgeteerContext dbCtx)
        {
            if (id is int intId)
            {
                var institution = await base.RetrieveByIdAsync<Institution, int, C>(intId, context);

                if (institution.IsValid && null != institution.Result)
                {
                    Expression<Func<AccountDatum, bool>> query = i => i.InstitutionId == institution.Result.Id;
                    var accounts = await base.RetrieveManyByQueryAsync(query, dbCtx);
                    if (accounts.IsValid && null != accounts.Result)
                    {
                        foreach (var account in accounts.Result)
                        {
                            Expression<Func<Transaction, bool>> transQuery = tr => tr.AccountDatumId == account.Id && !account.IsDeleted;
                            var transactions = await base.RetrieveManyByQueryAsync(transQuery, dbCtx);

                            if (transactions.IsValid && null != transactions.Result && transactions.Result.Any())
                            {
                                foreach (var transaction in transactions.Result)
                                {
                                    Expression<Func<TransactionType, bool>> catQuery = cat => cat.Id == transaction.TransactionTypeId;
                                    _ = await base.RetrieveManyByQueryAsync(catQuery, dbCtx);
                                }
                            }

                            Expression<Func<AnnualPercentageRate, bool>> aprQuery = apr => apr.AccountDatumId == account.Id;
                            _ = await base.RetrieveManyByQueryAsync(aprQuery, dbCtx);
                        }
                    }
                }

                return institution;
            }
        }
        return ReturnValue<Institution>.FromError(new Exception("Invalid Id Type"));
    }

    public override async Task<ReturnValue<int>> DeleteAsync<T, C>(T entity, C? context) where T : class where C : class
    { 
        if (entity is Institution institution)
        {
            institution.IsDeleted = true;
            return await base.UpdateAsync(entity, context);
        }
        
        return ReturnValue<int>.FromError(0, new Exception("Invalid Entity Type"));
    }
}

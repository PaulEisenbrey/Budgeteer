using Budgeteer.EntityManagement.Interface;

using Database.BaseClasses;
using Database.Context;
using Database.Models;

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

	public override async Task<ReturnValue<int>> DeleteAsync<T, C>(T entity, C? context) where T : class where C : class
	{ 
		if (entity is Institution institution)
		{
			institution.IsActive = false;
			return await base.UpdateAsync(entity, context);
		}
		
		return ReturnValue<int>.FromError(0, new Exception("Invalid Entity Type"));
	}
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Budgeteer.EntityManagement.Interface;

using Database.BaseClasses;
using Database.Context;
using Database.Models;

using Utilities.ArgumentEvaluation;
using Utilities.IoCInterfaces;
using Utilities.Logging;
using Utilities.ReturnType;

namespace Budgeteer.EntityManagement;
public class AddressCrud : DatabaseCrud, IAddressCrud, ISingletonSvc
{
	private readonly BudgeteerContext _context;

	public AddressCrud(ILogManager logMgr, BudgeteerContext context) : base(logMgr)
	{
		this._context = context;
	}

	public ReturnValue<Address> NewAddress() => ReturnValue<Address>.From(new Address());

	public async Task<ReturnValue<int>> DeleteAsync(Address address)
	{
		address.IsActive = false;
		return await base.UpdateAsync(address, this._context);		
	}
}

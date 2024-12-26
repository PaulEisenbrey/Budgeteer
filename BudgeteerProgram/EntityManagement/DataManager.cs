using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Budgeteer.EntityManagement.Interface;

using Database.Context;
using Database.POCO.Budgeteer;
using Database.POCO.Images;

using Microsoft.EntityFrameworkCore;

using Utilities.IoCInterfaces;
using Utilities.ReturnType;

namespace Budgeteer.EntityManagement;
public class DataManager : IDataManager, ISingletonSvc
{
    private readonly IInstitutionCrud institutionCrud;
    private readonly BudgeteerContext budgeteerContext = new();
    private readonly List<Institution> _institutions = new();
    private readonly List<ActiveInstiutionNameAndId> currentInstitutionHeaders = new();

    public DataManager(IInstitutionCrud institutionCrud)
    {
        this.institutionCrud = institutionCrud;
    }

    public async Task<ReturnValue<List<ActiveInstiutionNameAndId>>> GetInstitutionHeaderList()
    {
        if (this.currentInstitutionHeaders.Count == 0)
        {
            await this.Initialize();
            if (this.currentInstitutionHeaders.Count == 0)
            {
                return ReturnValue<List<ActiveInstiutionNameAndId>>.FromError("No institutions found.");
            }
        }

        return ReturnValue<List<ActiveInstiutionNameAndId>>.From(this.currentInstitutionHeaders);
    }

    public async Task<ReturnValue<int>> SaveInstitution(Institution institution)
    {
        if (institution.Id == 0)
        {
            return await institutionCrud.SaveNewInstitution(institution, this.budgeteerContext);
        }

        return await institutionCrud.UpdateInstitution(institution, this.budgeteerContext);
    }

    public async Task<ReturnValue<Institution>> GetInstitutionById(int id)
    {
        return await this.institutionCrud.RetrieveByIdAsync<Institution, int, BudgeteerContext>(id, this.budgeteerContext);
    }

    public async Task<ReturnValue<List<PostalCode>>> PostalCodesByCountryAndState(string countryCode, string stateProvince)
    {
        var pc = await this.budgeteerContext.PostalCodes
            .Where(pc => pc.CountryCode == countryCode && pc.StateProvince == stateProvince)
            .ToListAsync();

        if (pc.Count == 0)
        {
            return ReturnValue<List<PostalCode>>.FromError("No postal codes found for the given country and state.");
        }

        return ReturnValue<List<PostalCode>>.From(pc);
    }

    public async Task<ReturnValue<PostalCode>> PostalCodeDataByPostalCode(string zipCode)
    {
        var pc = await this.budgeteerContext.PostalCodes
            .Where(pc => pc.PostalCodeValue == zipCode)
            .FirstOrDefaultAsync();

        if (pc == null)
        {
            return ReturnValue<PostalCode>.FromError($"No postal code found for {zipCode}.");
        }

        return ReturnValue<PostalCode>.From(pc);
    }

    private async Task Initialize()
    {
        var institutionHeaders = await institutionCrud.GetActiveInstitutionHeaders(this.budgeteerContext);

        if (null != institutionHeaders && institutionHeaders.IsValid && null != institutionHeaders.Result)
        {
            this.currentInstitutionHeaders.AddRange(institutionHeaders.Result);
        }
    }
}

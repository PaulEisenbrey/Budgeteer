using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Budgeteer.EntityManagement;
using Budgeteer.EntityManagement.Interface;

using Database.Context;

using IoC;

using Utilities.ArgumentEvaluation;
using Utilities.IoCInterfaces;
using Utilities.ReturnType;

namespace Budgeteer.UIOverrides;
public class ZipComboBox : IZipComboBox, ISingletonSvc
{
    private readonly IDataManager? _dataManager = IocServiceFactory.Instance?.Resolve<IDataManager>();

    public async Task FillComboBox(ComboBox comboBox, string countryCode, string stateProvince)
    {
        var postalCodes = await this._dataManager!.PostalCodesByCountryAndState(countryCode, stateProvince);
        if (!postalCodes.IsValid)
        {
            comboBox.Items.Add("No postal codes found.");
            return;
        }

        EvaluateArgument.Execute(postalCodes.Result, fn => null != postalCodes.Result && postalCodes.Result.Count != 0, "No postal codes found.");
        var sortedCodes = postalCodes.Result!.OrderBy(pc => pc.PostalCodeValue).ToList();
        sortedCodes.ForEach(pc => comboBox.Items.Add(pc.PostalCodeValue));
    }

    public async Task<List<string>> GetPostalCodes(string countryCode, string stateProvince)
    {
        var postalCodes = await this._dataManager!.PostalCodesByCountryAndState(countryCode, stateProvince);
        if (!postalCodes.IsValid)
        {
            return ReturnValue<List<string>>.FromError("No postal codes found.");
        }

        EvaluateArgument.Execute(postalCodes.Result, fn => null != postalCodes.Result && postalCodes.Result.Count != 0, "No postal codes found.");
        var sortedCodes = postalCodes.Result!.OrderBy(pc => pc.PostalCodeValue).Select(pc => pc.PostalCodeValue).ToList();
        return sortedCodes;
    }
}

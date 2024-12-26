using Utilities.ReturnType;

namespace Budgeteer.UIOverrides;

public interface IZipComboBox
{
    Task FillComboBox(ComboBox comboBox, string countryCode, string stateProvince);
    Task<List<string>> GetPostalCodes(string countryCode, string stateProvince);
}
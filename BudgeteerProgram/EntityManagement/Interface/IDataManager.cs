using Database.POCO.Budgeteer;
using Database.POCO.Images;

using Utilities.ReturnType;

namespace Budgeteer.EntityManagement.Interface;

public interface IDataManager
{
    Task<ReturnValue<List<ActiveInstiutionNameAndId>>> GetInstitutionHeaderList();
    Task<ReturnValue<PostalCode>> PostalCodeDataByPostalCode(string zipCode);
    Task<ReturnValue<List<PostalCode>>> PostalCodesByCountryAndState(string countryCode, string stateProvince);
    Task<ReturnValue<int>> SaveInstitution(Institution institution);
}
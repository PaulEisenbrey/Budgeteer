using Database.Trupanion.Context;
using Database.Trupanion.Entity.Aggregates;
using Utilities.Constants.Enum;
using Utilities.ReturnType;

namespace Database.Trupanion.Crud.Interfaces;

public interface ITestDataNameSourceCrud
{
    Task<ReturnValue<FullName>> RetrieveRandomNameAsync(NameSourceLanguageOption languageOption, TestDataNameSourceContext? ctx = null);
    Task<ReturnValue<string>> RetrieveRandomPetNameAsync(TestDataNameSourceContext? context = null);
}

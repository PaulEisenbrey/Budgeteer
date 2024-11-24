using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

using Database.Aquarium.Entity.Quote.Dbo;
using Database.BaseClasses;
using Database.BaseClasses.Interfaces;
using Database.Trupanion.Context;
using Database.Trupanion.Crud.Interfaces;
using Database.Trupanion.Entity.Aggregates;
using Database.Trupanion.Entity.TestData.NameSource;
using Utilities.Constants.Enum;
using Utilities.Logging;
using Utilities.ReturnType;

namespace Database.Trupanion.Crud.TestData.NameSource;

public class TestDataNameSourceCrud : QaLibCrud, IQaLibCrud, ITestDataNameSourceCrud
{
    public TestDataNameSourceCrud(ILogManager logMgr) : base(logMgr)
    {
    }

    private static readonly List<TestDataNameSourceName> testDataNameSourceNames = new();
    private static readonly object locker = new();

    public async Task<ReturnValue<FullName>> RetrieveRandomNameAsync(NameSourceLanguageOption languageOption, TestDataNameSourceContext? ctx = null)
    {
        try
        {
            var testDataNameSourceNames = await this.EnsureContext(ctx).Names.ToListAsync().ConfigureAwait(false);

            Random r = new Random((int)DateTime.Now.Ticks);
            var fNames = testDataNameSourceNames.Where(n => !n.IsSurname && n.LanguageId == (int)languageOption).ToList();
            var lNames = testDataNameSourceNames.Where(n => n.IsSurname && n.LanguageId == (int)languageOption).ToList();

            var fNameIndex = r.Next(fNames.Count - 1);
            var lNameIndex = r.Next(lNames.Count - 1);

            var ret = new FullName { FirstName = fNames[fNameIndex]?.Name ?? "", LastName = lNames[lNameIndex]?.Name ?? "" };

            return ReturnValue<FullName>.From(ret);
        }
        catch (SqlException sqex)
        {
            return ReturnValue<FullName>.FromError(sqex);
        }
        catch (Exception ex)
        {
            return ReturnValue<FullName>.FromError(ex);
        }
    }

    public async Task<ReturnValue<string>> RetrieveRandomPetNameAsync(TestDataNameSourceContext? context = null)
    {
        try
        {
            var testDataNameSourceNames = await this.EnsureContext(context).Names.Where(name => !name.IsSurname).ToListAsync().ConfigureAwait(false);
            Random r = new Random((int)DateTime.Now.Ticks);
            var nameIndex = r.Next(testDataNameSourceNames.Count - 1);

            return ReturnValue<string>.From(testDataNameSourceNames[nameIndex].Name ?? "Mortis");
        }
        catch (SqlException sqex)
        {
            return ReturnValue<string>.FromError(sqex);
        }
        catch (Exception ex)
        {
            return ReturnValue<string>.FromError(ex);
        }
    }
}
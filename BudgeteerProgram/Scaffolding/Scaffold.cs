using Database.Models;
using Database.Serializers;
using Utilities.IoCInterfaces;
using Utilities.ReturnType;

namespace Budgeteer.Scaffolding
{
    public class Scaffold : IScaffold, ISingletonSvc
    {
        private IInstitutionsAccess loader;

        public Scaffold(IInstitutionsAccess loader)
        {
            this.loader = loader;
        }

        public ReturnValue<Institution> GetInstitution()
        {
            CreateTestInstitution createTestInstitution = new();

            return ReturnValue<Institution>.From(createTestInstitution.Create());
        }
    }
}

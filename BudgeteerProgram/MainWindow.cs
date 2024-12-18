using Budgeteer.Scaffolding;
using Database.BaseClasses.Interfaces;
using Database.Serializers;
using IoC;
using Utilities.IoCInterfaces;

namespace Budgeteer
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            IocServiceFactory? serviceFactory = IocServiceFactory.Instance ?? null;
            serviceFactory?.Initialize();

            var scaffold = serviceFactory?.Resolve<IScaffold>();

            var institution = scaffold?.GetInstitution();
            var instCrud = serviceFactory?.Resolve<IInstitutionsAccess>();

            if(null != institution && institution.IsValid &&  null != instCrud)
            {
                Task.Run(async () => await instCrud.CreateNewInstitution(institution.Result!)).Wait();
            }
        }
    }
}
using Database.BaseClasses.Interfaces;
using IoC;
using Utilities.IoCInterfaces;

namespace Budgeteer
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            IocServiceFactory serviceFactory = IocServiceFactory.Instance;
            serviceFactory?.Initialize();

            var crud = LibraryIocHost.Resolve<IDatabaseCrud>();
        }
    }
}

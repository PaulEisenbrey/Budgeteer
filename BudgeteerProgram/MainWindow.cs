using System.Diagnostics;

using Budgeteer.Dialogs;
using Budgeteer.EntityManagement.Interface;

using Database.BaseClasses.Interfaces;
using Database.POCO.Budgeteer;

using IoC;

using Utilities.ArgumentEvaluation;
using Utilities.IoCInterfaces;
using Utilities.ReturnType;

namespace Budgeteer
{
    public partial class MainWindow : Form
    {
        private readonly IDataManager _dataManager;

        public MainWindow()
        {
            InitializeComponent();

            IocServiceFactory? serviceFactory = IocServiceFactory.Instance;
            EvaluateArgument.Execute(serviceFactory, fn => null != serviceFactory, "Service Factory cannot be created");
            serviceFactory?.Initialize();

            _dataManager = serviceFactory?.Resolve<IDataManager>() ?? throw new ArgumentNullException("DataManager is null");

            Task.Run(async () => await this.InitializeInstitutions()).Wait();
        }

        private void btnNewInstitution_Click(object sender, EventArgs e)
        {
            CreateUpdateInstitution dlg = new CreateUpdateInstitution();
            var retVal = dlg.ShowDialog();
            if (retVal == DialogResult.OK)
            {
                var institution = dlg.GetInstitution();
                if (null == institution)
                {
                    Debug.WriteLine("Institution is null.");
                    return;
                }

                EvaluateArgument.Execute(institution, fn => null != institution, "Institution is null.");
                this._dataManager.SaveInstitution(institution);
                this.comboInstitutions.Items.Add($"{institution.Name} - {institution.Nickname}");
            }

            dlg.Dispose();
        }

        private async Task InitializeInstitutions()
        {
            var institutions = await this._dataManager.GetInstitutionHeaderList();
            if (!institutions.IsValid)
            {
                Debug.WriteLine("No institutions found.");
                return;
            }

            EvaluateArgument.Execute(institutions.Result, fn => null != institutions.Result && institutions.Result.Count != 0, "No institutions found.");
            institutions.Result!.ForEach(inst => this.comboInstitutions.Items.Add($"{inst.Name} - {inst.Nickname}"));
        }
    }
}

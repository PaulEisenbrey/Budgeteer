using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Budgeteer.UIOverrides;

using Database.POCO.Budgeteer;

using MyUtilities.Conversion;

namespace Budgeteer.Dialogs;
public partial class CreateUpdateInstitution : Form
{
    private readonly StateComboBox stateCombobox = new();
    private readonly ZipComboBox zipComboBox = new();
    private readonly bool windowCreated = false;
    private Institution institution = new();

    public CreateUpdateInstitution()
    {
        InitializeComponent();
        this.comboCountry.SelectedIndexChanged += new EventHandler(this.comboCountry_SelectedIndexChanged);
        this.comboStates.SelectedIndexChanged += new EventHandler(this.comboStates_SelectedIndexChanged);
        this.comboCountry.DataSource = new List<string> { "United States", "Canada" };
        this.comboCountry.SelectedIndex = 0;

        this.btnSave.Click += new EventHandler(this.btnSave_Click);

        windowCreated = true;
    }

    public Institution GetInstitution() => this.institution;

    private async void comboStates_SelectedIndexChanged(object? sender, EventArgs e)
    {
        var countryCode = this.comboCountry.SelectedValue?.ToString() ?? "USA";
        countryCode = CountryNameToAbbr.Convert(countryCode);
        var stateCode = this.comboStates.SelectedItem?.ToString() ?? "Alaska";

        stateCode = StateNameToAbbr.Convert(stateCode);

        if (!windowCreated)
        {
            Task.Run(async () => await this.zipComboBox.FillComboBox(this.comboZip, countryCode, stateCode)).Wait();
            return;
        }

        var currentCursor = Cursor.Current;

        try
        {
            Cursor.Current = Cursors.WaitCursor;
            comboZip.Items.Clear();
            List<string> postalValues = await this.zipComboBox.GetPostalCodes(countryCode, stateCode);
            postalValues.ForEach(pv => this.comboZip.Items.Add(pv));
        }
        finally
        {
            Cursor.Current = currentCursor;
        }
    }

    private void comboCountry_SelectedIndexChanged(object? sender, EventArgs e)
    {
        var countryCode = this.comboCountry.SelectedValue?.ToString() ?? "USA";
        countryCode = CountryNameToAbbr.Convert(countryCode);

        comboStates.Items.Clear();
        stateCombobox.FillComboBox(this.comboStates, countryCode);
        this.comboStates.SelectedIndex = 1;
    }

    public void SetInstitution(Institution? inst)
    {
        if (inst != null)
        {
            this.institution = inst;
        }

        this.txtInstitutionName.Text = institution.Name;
        this.txtNickname.Text = institution.Nickname;
        this.txtAccountNo.Text = institution.AccountNumber;
        this.txtPhone.Text = institution.PhoneNumber;
        this.txtUrl.Text = institution.Url;

        string country = string.Empty;
        if (institution.Address != null)
        {
            country = CountryNameToAbbr.Convert(institution.Address.Country ?? "USA");
        }

        this.comboCountry.Text = country;
        this.comboStates.Text = institution.Address?.State ?? "Alaska";

        this.txtAddress1.Text = institution.Address?.Street;
        this.txtAddress2.Text = institution.Address?.UnitNumber;
        this.txtCity.Text = institution.Address?.City;
        this.comboZip.Text = institution.Address?.PostalCode;
    }

    private void btnSave_Click(object? sender, EventArgs e)
    {
        if (AllFieldsAreValid())
        {
            this.institution.Name = this.txtInstitutionName.Text;
            this.institution.Nickname = this.txtNickname.Text;
            this.institution.AccountNumber = this.txtAccountNo.Text;
            this.institution.PhoneNumber = this.txtPhone.Text;
            this.institution.Url = this.txtUrl.Text;
            this.institution.Address ??= new Address();
            this.institution.Address.Country = this.comboCountry.Text;
            this.institution.Address.State = this.comboStates.Text;
            this.institution.Address.Street = this.txtAddress1.Text;
            this.institution.Address.UnitNumber = this.txtAddress2.Text;
            this.institution.Address.City = this.txtCity.Text;
            this.institution.Address.PostalCode = this.comboZip.Text;

            DialogResult = DialogResult.OK;
        }

        this.Close();
    }

    private bool AllFieldsAreValid()
    {
        if (string.IsNullOrWhiteSpace(this.txtInstitutionName.Text))
        {
            MessageBox.Show("Institution Name is required.");
            return false;
        }
        if (string.IsNullOrWhiteSpace(this.txtAccountNo.Text))
        {
            MessageBox.Show("Account Number is required.");
            return false;
        }
        if (string.IsNullOrWhiteSpace(this.txtPhone.Text))
        {
            MessageBox.Show("Phone Number is required.");
            return false;
        }

        return true;
    }
}

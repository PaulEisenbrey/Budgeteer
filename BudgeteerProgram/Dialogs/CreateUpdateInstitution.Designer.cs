namespace Budgeteer.Dialogs;

partial class CreateUpdateInstitution
{
	/// <summary>
	/// Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	/// <summary>
	/// Clean up any resources being used.
	/// </summary>
	/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	protected override void Dispose(bool disposing)
	{
		if (disposing && (components != null))
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	#region Windows Form Designer generated code

	/// <summary>
	/// Required method for Designer support - do not modify
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
		this.label1 = new Label();
		this.txtInstitutionName = new TextBox();
		this.label2 = new Label();
		this.txtNickname = new TextBox();
		this.label3 = new Label();
		this.txtAccountNo = new TextBox();
		this.label4 = new Label();
		this.label5 = new Label();
		this.panel1 = new Panel();
		this.comboCountry = new ComboBox();
		this.txtZip2 = new TextBox();
		this.label15 = new Label();
		this.txtZip = new TextBox();
		this.comboStates = new ComboBox();
		this.txtCity = new TextBox();
		this.txtAddress2 = new TextBox();
		this.txtAddress1 = new TextBox();
		this.label14 = new Label();
		this.label13 = new Label();
		this.label12 = new Label();
		this.label11 = new Label();
		this.label10 = new Label();
		this.label9 = new Label();
		this.label8 = new Label();
		this.textBox1 = new TextBox();
		this.label7 = new Label();
		this.btnSave = new Button();
		this.btnCancel = new Button();
		this.txtPhone = new MaskedTextBox();
		this.panel1.SuspendLayout();
		this.SuspendLayout();
		// 
		// label1
		// 
		this.label1.AutoSize = true;
		this.label1.Location = new Point(6, 19);
		this.label1.Name = "label1";
		this.label1.Size = new Size(99, 15);
		this.label1.Text = "Institution Name:";
		// 
		// txtInstitutionName
		// 
		this.txtInstitutionName.Location = new Point(112, 17);
		this.txtInstitutionName.Name = "txtInstitutionName";
		this.txtInstitutionName.Size = new Size(407, 23);
		this.txtInstitutionName.TabIndex = 1;
		// 
		// label2
		// 
		this.label2.AutoSize = true;
		this.label2.Location = new Point(6, 59);
		this.label2.Name = "label2";
		this.label2.Size = new Size(64, 15);
		this.label2.Text = "Nickname:";
		// 
		// txtNickname
		// 
		this.txtNickname.Location = new Point(112, 48);
		this.txtNickname.Name = "txtNickname";
		this.txtNickname.Size = new Size(312, 23);
		this.txtNickname.TabIndex = 3;
		// 
		// label3
		// 
		this.label3.AutoSize = true;
		this.label3.Location = new Point(535, 23);
		this.label3.Name = "label3";
		this.label3.Size = new Size(65, 15);
		this.label3.Text = "Account #:";
		// 
		// txtAccountNo
		// 
		this.txtAccountNo.Location = new Point(606, 19);
		this.txtAccountNo.Name = "txtAccountNo";
		this.txtAccountNo.Size = new Size(168, 23);
		this.txtAccountNo.TabIndex = 2;
		// 
		// label4
		// 
		this.label4.AutoSize = true;
		this.label4.Location = new Point(536, 54);
		this.label4.Name = "label4";
		this.label4.Size = new Size(54, 15);
		this.label4.Text = "Phone #:";
		// 
		// panel1
		// 
		this.panel1.BorderStyle = BorderStyle.Fixed3D;
		this.panel1.Controls.Add(this.txtPhone);
		this.panel1.Controls.Add(this.comboCountry);
		this.panel1.Controls.Add(this.txtZip2);
		this.panel1.Controls.Add(this.label15);
		this.panel1.Controls.Add(this.txtZip);
		this.panel1.Controls.Add(this.comboStates);
		this.panel1.Controls.Add(this.txtCity);
		this.panel1.Controls.Add(this.txtAddress2);
		this.panel1.Controls.Add(this.txtAddress1);
		this.panel1.Controls.Add(this.label14);
		this.panel1.Controls.Add(this.label13);
		this.panel1.Controls.Add(this.label12);
		this.panel1.Controls.Add(this.label11);
		this.panel1.Controls.Add(this.label10);
		this.panel1.Controls.Add(this.label9);
		this.panel1.Controls.Add(this.label8);
		this.panel1.Controls.Add(this.textBox1);
		this.panel1.Controls.Add(this.label7);
		this.panel1.Controls.Add(this.label1);
		this.panel1.Controls.Add(this.txtInstitutionName);
		this.panel1.Controls.Add(this.label4);
		this.panel1.Controls.Add(this.label2);
		this.panel1.Controls.Add(this.txtAccountNo);
		this.panel1.Controls.Add(this.txtNickname);
		this.panel1.Controls.Add(this.label3);
		this.panel1.Location = new Point(7, 12);
		this.panel1.Name = "panel1";
		this.panel1.Size = new Size(792, 383);
		this.panel1.Paint += this.panel1_Paint;
		// 
		// comboCountry
		// 
		this.comboCountry.FormattingEnabled = true;
		this.comboCountry.Location = new Point(623, 154);
		this.comboCountry.Name = "comboCountry";
		this.comboCountry.Size = new Size(151, 23);
		this.comboCountry.TabIndex = 12;
		// 
		// txtZip2
		// 
		this.txtZip2.Location = new Point(492, 245);
		this.txtZip2.Name = "txtZip2";
		this.txtZip2.Size = new Size(55, 23);
		this.txtZip2.TabIndex = 11;
		// 
		// label15
		// 
		this.label15.AutoSize = true;
		this.label15.Location = new Point(468, 248);
		this.label15.Name = "label15";
		this.label15.Size = new Size(18, 15);
		this.label15.Text = " - ";
		// 
		// txtZip
		// 
		this.txtZip.Location = new Point(387, 243);
		this.txtZip.Name = "txtZip";
		this.txtZip.Size = new Size(77, 23);
		this.txtZip.TabIndex = 10;
		this.txtZip.TextChanged += this.txtZip_TextChanged;
		// 
		// comboStates
		// 
		this.comboStates.FormattingEnabled = true;
		this.comboStates.Location = new Point(157, 242);
		this.comboStates.Name = "comboStates";
		this.comboStates.Size = new Size(121, 23);
		this.comboStates.TabIndex = 9;
		// 
		// txtCity
		// 
		this.txtCity.Location = new Point(156, 208);
		this.txtCity.Name = "txtCity";
		this.txtCity.Size = new Size(392, 23);
		this.txtCity.TabIndex = 8;
		// 
		// txtAddress2
		// 
		this.txtAddress2.Location = new Point(157, 178);
		this.txtAddress2.Name = "txtAddress2";
		this.txtAddress2.Size = new Size(392, 23);
		this.txtAddress2.TabIndex = 7;
		// 
		// txtAddress1
		// 
		this.txtAddress1.Location = new Point(157, 149);
		this.txtAddress1.Name = "txtAddress1";
		this.txtAddress1.Size = new Size(392, 23);
		this.txtAddress1.TabIndex = 6;
		// 
		// label14
		// 
		this.label14.AutoSize = true;
		this.label14.Location = new Point(567, 156);
		this.label14.Name = "label14";
		this.label14.Size = new Size(50, 15);
		this.label14.Text = "Country";
		// 
		// label13
		// 
		this.label13.AutoSize = true;
		this.label13.Location = new Point(306, 246);
		this.label13.Name = "label13";
		this.label13.Size = new Size(73, 15);
		this.label13.Text = "Postal Code:";
		// 
		// label12
		// 
		this.label12.AutoSize = true;
		this.label12.Location = new Point(63, 245);
		this.label12.Name = "label12";
		this.label12.Size = new Size(87, 15);
		this.label12.Text = "State/Province:";
		// 
		// label11
		// 
		this.label11.AutoSize = true;
		this.label11.Location = new Point(63, 211);
		this.label11.Name = "label11";
		this.label11.Size = new Size(31, 15);
		this.label11.Text = "City:";
		// 
		// label10
		// 
		this.label10.AutoSize = true;
		this.label10.Location = new Point(63, 181);
		this.label10.Name = "label10";
		this.label10.Size = new Size(36, 15);
		this.label10.Text = "Suite:";
		// 
		// label9
		// 
		this.label9.AutoSize = true;
		this.label9.Location = new Point(63, 156);
		this.label9.Name = "label9";
		this.label9.Size = new Size(40, 15);
		this.label9.TabIndex = 16;
		this.label9.Text = "Street:";
		// 
		// label8
		// 
		this.label8.AutoSize = true;
		this.label8.Location = new Point(12, 127);
		this.label8.Name = "label8";
		this.label8.Size = new Size(49, 15);
		this.label8.TabIndex = 15;
		this.label8.Text = "Address";
		// 
		// textBox1
		// 
		this.textBox1.Location = new Point(112, 82);
		this.textBox1.Name = "textBox1";
		this.textBox1.Size = new Size(662, 23);
		this.textBox1.TabIndex = 5;
		// 
		// label7
		// 
		this.label7.AutoSize = true;
		this.label7.Location = new Point(7, 85);
		this.label7.Name = "label7";
		this.label7.Size = new Size(25, 15);
		this.label7.TabIndex = 13;
		this.label7.Text = "Url:";
		// 
		// btnSave
		// 
		this.btnSave.Location = new Point(590, 408);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new Size(75, 23);
		this.btnSave.TabIndex = 13;
		this.btnSave.Text = "Save";
		this.btnSave.UseVisualStyleBackColor = true;
		// 
		// btnCancel
		// 
		this.btnCancel.Location = new Point(689, 408);
		this.btnCancel.Name = "btnCancel";
		this.btnCancel.Size = new Size(75, 23);
		this.btnCancel.TabIndex = 14;
		this.btnCancel.Text = "Cancel";
		this.btnCancel.UseVisualStyleBackColor = true;
		// 
		// txtPhone
		// 
		this.txtPhone.Location = new Point(607, 51);
		this.txtPhone.Mask = "(###) ###-####";
		this.txtPhone.Name = "txtPhone";
		this.txtPhone.Size = new Size(94, 23);
		this.txtPhone.TabIndex = 4;
		// 
		// CreateUpdateInstitution
		// 
		this.AcceptButton = this.btnSave;
		this.AutoScaleDimensions = new SizeF(7F, 15F);
		this.AutoScaleMode = AutoScaleMode.Font;
		this.CancelButton = this.btnCancel;
		this.ClientSize = new Size(811, 450);
		this.ControlBox = false;
		this.Controls.Add(this.btnCancel);
		this.Controls.Add(this.btnSave);
		this.Controls.Add(this.panel1);
		this.Controls.Add(this.label5);
		this.Name = "CreateUpdateInstitution";
		this.Text = "Create/Update Institution";
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		this.ResumeLayout(false);
		this.PerformLayout();
	}

	#endregion

	private Label label1;
	private TextBox txtInstitutionName;
	private Label label2;
	private TextBox txtNickname;
	private Label label3;
	private TextBox txtAccountNo;
	private Label label4;
	private Label label5;
	private Panel panel1;
	private Button btnSave;
	private Button btnCancel;
	private Label label7;
	private TextBox textBox1;
	private Label label12;
	private Label label11;
	private Label label10;
	private Label label9;
	private Label label8;
	private TextBox txtAddress2;
	private TextBox txtAddress1;
	private Label label14;
	private Label label13;
	private TextBox txtCity;
	private TextBox txtZip2;
	private Label label15;
	private TextBox txtZip;
	private ComboBox comboStates;
	private ComboBox comboCountry;
	private MaskedTextBox txtPhone;
}
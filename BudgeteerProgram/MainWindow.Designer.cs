namespace Budgeteer
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new MenuStrip();
            this.fileToolStripMenuItem = new ToolStripMenuItem();
            this.mailStatusStrip = new StatusStrip();
            this.panel1 = new Panel();
            this.panelTransaction = new Panel();
            this.textBox2 = new TextBox();
            this.textBox1 = new TextBox();
            this.cbIsDeposit = new CheckBox();
            this.txtTransactionAmt = new TextBox();
            this.dateTimeTransaction = new DateTimePicker();
            this.listviewTransaction = new ListView();
            this.headerTransactionDate = new ColumnHeader();
            this.headerDescription = new ColumnHeader();
            this.headerTransactionDeposit = new ColumnHeader();
            this.headerTransactionWithdrawl = new ColumnHeader();
            this.headerTransactionRemainingBalance = new ColumnHeader();
            this.dateTimeTo = new DateTimePicker();
            this.lblTo = new Label();
            this.dateTimeFrom = new DateTimePicker();
            this.lblRange = new Label();
            this.btnNewAccount = new Button();
            this.lvAccounts = new ListView();
            this.headerAccountName = new ColumnHeader();
            this.headerAccountNickName = new ColumnHeader();
            this.label2 = new Label();
            this.btnNewInstitution = new Button();
            this.label1 = new Label();
            this.comboInstitutions = new ComboBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelTransaction.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new ToolStripItem[] { this.fileToolStripMenuItem });
            this.menuStrip1.Location = new Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new Size(1709, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new Size(37, 20);
            this.fileToolStripMenuItem.Text = "F&ile";
            // 
            // mailStatusStrip
            // 
            this.mailStatusStrip.Location = new Point(0, 934);
            this.mailStatusStrip.Name = "mailStatusStrip";
            this.mailStatusStrip.Size = new Size(1709, 22);
            this.mailStatusStrip.TabIndex = 2;
            this.mailStatusStrip.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.panel1.BorderStyle = BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panelTransaction);
            this.panel1.Controls.Add(this.listviewTransaction);
            this.panel1.Controls.Add(this.dateTimeTo);
            this.panel1.Controls.Add(this.lblTo);
            this.panel1.Controls.Add(this.dateTimeFrom);
            this.panel1.Controls.Add(this.lblRange);
            this.panel1.Controls.Add(this.btnNewAccount);
            this.panel1.Controls.Add(this.lvAccounts);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnNewInstitution);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboInstitutions);
            this.panel1.Location = new Point(12, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(1685, 900);
            this.panel1.TabIndex = 3;
            // 
            // panelTransaction
            // 
            this.panelTransaction.BorderStyle = BorderStyle.Fixed3D;
            this.panelTransaction.Controls.Add(this.textBox2);
            this.panelTransaction.Controls.Add(this.textBox1);
            this.panelTransaction.Controls.Add(this.cbIsDeposit);
            this.panelTransaction.Controls.Add(this.txtTransactionAmt);
            this.panelTransaction.Controls.Add(this.dateTimeTransaction);
            this.panelTransaction.Location = new Point(1284, 95);
            this.panelTransaction.Name = "panelTransaction";
            this.panelTransaction.Size = new Size(378, 398);
            this.panelTransaction.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new Point(166, 86);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Size(100, 23);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.AcceptsTab = true;
            this.textBox1.Location = new Point(8, 284);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = ScrollBars.Vertical;
            this.textBox1.Size = new Size(356, 92);
            this.textBox1.TabIndex = 3;
            // 
            // cbIsDeposit
            // 
            this.cbIsDeposit.Appearance = Appearance.Button;
            this.cbIsDeposit.AutoSize = true;
            this.cbIsDeposit.Location = new Point(276, 47);
            this.cbIsDeposit.Name = "cbIsDeposit";
            this.cbIsDeposit.Size = new Size(57, 25);
            this.cbIsDeposit.TabIndex = 2;
            this.cbIsDeposit.Text = "Deposit";
            this.cbIsDeposit.UseVisualStyleBackColor = true;
            // 
            // txtTransactionAmt
            // 
            this.txtTransactionAmt.Location = new Point(165, 49);
            this.txtTransactionAmt.Name = "txtTransactionAmt";
            this.txtTransactionAmt.Size = new Size(100, 23);
            this.txtTransactionAmt.TabIndex = 1;
            // 
            // dateTimeTransaction
            // 
            this.dateTimeTransaction.Location = new Point(164, 15);
            this.dateTimeTransaction.Name = "dateTimeTransaction";
            this.dateTimeTransaction.Size = new Size(200, 23);
            this.dateTimeTransaction.TabIndex = 0;
            // 
            // listviewTransaction
            // 
            this.listviewTransaction.AutoArrange = false;
            this.listviewTransaction.Columns.AddRange(new ColumnHeader[] { this.headerTransactionDate, this.headerDescription, this.headerTransactionDeposit, this.headerTransactionWithdrawl, this.headerTransactionRemainingBalance });
            this.listviewTransaction.FullRowSelect = true;
            this.listviewTransaction.GridLines = true;
            this.listviewTransaction.Location = new Point(379, 98);
            this.listviewTransaction.MultiSelect = false;
            this.listviewTransaction.Name = "listviewTransaction";
            this.listviewTransaction.ShowItemToolTips = true;
            this.listviewTransaction.Size = new Size(876, 782);
            this.listviewTransaction.TabIndex = 10;
            this.listviewTransaction.UseCompatibleStateImageBehavior = false;
            this.listviewTransaction.View = View.Details;
            // 
            // headerTransactionDate
            // 
            this.headerTransactionDate.Text = "Date";
            this.headerTransactionDate.Width = 100;
            // 
            // headerDescription
            // 
            this.headerDescription.Text = "Description";
            this.headerDescription.Width = 300;
            // 
            // headerTransactionDeposit
            // 
            this.headerTransactionDeposit.Text = "Deposit";
            this.headerTransactionDeposit.Width = 150;
            // 
            // headerTransactionWithdrawl
            // 
            this.headerTransactionWithdrawl.Text = "Withdrawl";
            this.headerTransactionWithdrawl.Width = 150;
            // 
            // headerTransactionRemainingBalance
            // 
            this.headerTransactionRemainingBalance.Text = "Remaining Balance";
            this.headerTransactionRemainingBalance.Width = 150;
            // 
            // dateTimeTo
            // 
            this.dateTimeTo.AllowDrop = true;
            this.dateTimeTo.Location = new Point(727, 65);
            this.dateTimeTo.Name = "dateTimeTo";
            this.dateTimeTo.Size = new Size(200, 23);
            this.dateTimeTo.TabIndex = 9;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new Point(697, 70);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new Size(18, 15);
            this.lblTo.TabIndex = 8;
            this.lblTo.Text = "to";
            // 
            // dateTimeFrom
            // 
            this.dateTimeFrom.AllowDrop = true;
            this.dateTimeFrom.Location = new Point(489, 65);
            this.dateTimeFrom.Name = "dateTimeFrom";
            this.dateTimeFrom.Size = new Size(200, 23);
            this.dateTimeFrom.TabIndex = 7;
            // 
            // lblRange
            // 
            this.lblRange.AutoSize = true;
            this.lblRange.Location = new Point(373, 70);
            this.lblRange.Name = "lblRange";
            this.lblRange.Size = new Size(103, 15);
            this.lblRange.TabIndex = 6;
            this.lblRange.Text = "Transaction Range";
            // 
            // btnNewAccount
            // 
            this.btnNewAccount.FlatStyle = FlatStyle.Flat;
            this.btnNewAccount.Location = new Point(85, 470);
            this.btnNewAccount.Name = "btnNewAccount";
            this.btnNewAccount.Size = new Size(115, 23);
            this.btnNewAccount.TabIndex = 5;
            this.btnNewAccount.Text = "New Account";
            this.btnNewAccount.UseVisualStyleBackColor = true;
            // 
            // lvAccounts
            // 
            this.lvAccounts.BackColor = SystemColors.Control;
            this.lvAccounts.Columns.AddRange(new ColumnHeader[] { this.headerAccountName, this.headerAccountNickName });
            this.lvAccounts.FullRowSelect = true;
            this.lvAccounts.GridLines = true;
            this.lvAccounts.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            this.lvAccounts.Location = new Point(85, 61);
            this.lvAccounts.MultiSelect = false;
            this.lvAccounts.Name = "lvAccounts";
            this.lvAccounts.Size = new Size(262, 393);
            this.lvAccounts.TabIndex = 4;
            this.lvAccounts.UseCompatibleStateImageBehavior = false;
            this.lvAccounts.View = View.Details;
            // 
            // headerAccountName
            // 
            this.headerAccountName.Text = "Account Name";
            this.headerAccountName.Width = 130;
            // 
            // headerAccountNickName
            // 
            this.headerAccountNickName.Text = "Nickname";
            this.headerAccountNickName.Width = 130;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new Point(19, 60);
            this.label2.Name = "label2";
            this.label2.Size = new Size(57, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Accounts";
            // 
            // btnNewInstitution
            // 
            this.btnNewInstitution.FlatStyle = FlatStyle.Flat;
            this.btnNewInstitution.Location = new Point(364, 11);
            this.btnNewInstitution.Name = "btnNewInstitution";
            this.btnNewInstitution.Size = new Size(115, 23);
            this.btnNewInstitution.TabIndex = 2;
            this.btnNewInstitution.Text = "New Institution";
            this.btnNewInstitution.UseVisualStyleBackColor = true;
            this.btnNewInstitution.Click += this.btnNewInstitution_Click;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new Size(64, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Institution:";
            // 
            // comboInstitutions
            // 
            this.comboInstitutions.FormattingEnabled = true;
            this.comboInstitutions.Location = new Point(85, 11);
            this.comboInstitutions.Name = "comboInstitutions";
            this.comboInstitutions.Size = new Size(262, 23);
            this.comboInstitutions.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1709, 956);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mailStatusStrip);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.SizeGripStyle = SizeGripStyle.Show;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelTransaction.ResumeLayout(false);
            this.panelTransaction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private StatusStrip mailStatusStrip;
        private Panel panel1;
        private Label label1;
        private ComboBox comboInstitutions;
        private Button btnNewInstitution;
        private ListView lvAccounts;
        private ColumnHeader headerAccountName;
        private ColumnHeader headerAccountNickName;
        private Label label2;
        private DateTimePicker dateTimeTo;
        private Label lblTo;
        private DateTimePicker dateTimeFrom;
        private Label lblRange;
        private Button btnNewAccount;
        private ListView listviewTransaction;
        private ColumnHeader headerTransactionDate;
        private ColumnHeader headerDescription;
        private ColumnHeader headerTransactionDeposit;
        private ColumnHeader headerTransactionWithdrawl;
        private ColumnHeader headerTransactionRemainingBalance;
        private Panel panelTransaction;
        private DateTimePicker dateTimeTransaction;
        private CheckBox cbIsDeposit;
        private TextBox txtTransactionAmt;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}

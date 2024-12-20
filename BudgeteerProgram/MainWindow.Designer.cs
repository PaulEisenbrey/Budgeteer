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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            mailStatusStrip = new StatusStrip();
            panel1 = new Panel();
            panelTransaction = new Panel();
            cbIsDeposit = new CheckBox();
            txtTransactionAmt = new TextBox();
            dateTimeTransaction = new DateTimePicker();
            listviewTransaction = new ListView();
            headerTransactionDate = new ColumnHeader();
            headerDescription = new ColumnHeader();
            headerTransactionDeposit = new ColumnHeader();
            headerTransactionWithdrawl = new ColumnHeader();
            headerTransactionRemainingBalance = new ColumnHeader();
            dateTimeTo = new DateTimePicker();
            lblTo = new Label();
            dateTimeFrom = new DateTimePicker();
            lblRange = new Label();
            btnNewAccount = new Button();
            listView1 = new ListView();
            headerAccountName = new ColumnHeader();
            headerAccountNickName = new ColumnHeader();
            label2 = new Label();
            btnNewInstitution = new Button();
            label1 = new Label();
            comboInstitutions = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panelTransaction.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1709, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "F&ile";
            // 
            // mailStatusStrip
            // 
            mailStatusStrip.Location = new Point(0, 934);
            mailStatusStrip.Name = "mailStatusStrip";
            mailStatusStrip.Size = new Size(1709, 22);
            mailStatusStrip.TabIndex = 2;
            mailStatusStrip.Text = "statusStrip1";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(panelTransaction);
            panel1.Controls.Add(listviewTransaction);
            panel1.Controls.Add(dateTimeTo);
            panel1.Controls.Add(lblTo);
            panel1.Controls.Add(dateTimeFrom);
            panel1.Controls.Add(lblRange);
            panel1.Controls.Add(btnNewAccount);
            panel1.Controls.Add(listView1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnNewInstitution);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(comboInstitutions);
            panel1.Location = new Point(12, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(1685, 900);
            panel1.TabIndex = 3;
            // 
            // panelTransaction
            // 
            panelTransaction.BorderStyle = BorderStyle.Fixed3D;
            panelTransaction.Controls.Add(textBox2);
            panelTransaction.Controls.Add(textBox1);
            panelTransaction.Controls.Add(cbIsDeposit);
            panelTransaction.Controls.Add(txtTransactionAmt);
            panelTransaction.Controls.Add(dateTimeTransaction);
            panelTransaction.Location = new Point(1284, 95);
            panelTransaction.Name = "panelTransaction";
            panelTransaction.Size = new Size(378, 398);
            panelTransaction.TabIndex = 11;
            // 
            // cbIsDeposit
            // 
            cbIsDeposit.Appearance = Appearance.Button;
            cbIsDeposit.AutoSize = true;
            cbIsDeposit.Location = new Point(276, 47);
            cbIsDeposit.Name = "cbIsDeposit";
            cbIsDeposit.Size = new Size(57, 25);
            cbIsDeposit.TabIndex = 2;
            cbIsDeposit.Text = "Deposit";
            cbIsDeposit.UseVisualStyleBackColor = true;
            // 
            // txtTransactionAmt
            // 
            txtTransactionAmt.Location = new Point(165, 49);
            txtTransactionAmt.Name = "txtTransactionAmt";
            txtTransactionAmt.Size = new Size(100, 23);
            txtTransactionAmt.TabIndex = 1;
            // 
            // dateTimeTransaction
            // 
            dateTimeTransaction.Location = new Point(164, 15);
            dateTimeTransaction.Name = "dateTimeTransaction";
            dateTimeTransaction.Size = new Size(200, 23);
            dateTimeTransaction.TabIndex = 0;
            // 
            // listviewTransaction
            // 
            listviewTransaction.AutoArrange = false;
            listviewTransaction.Columns.AddRange(new ColumnHeader[] { headerTransactionDate, headerDescription, headerTransactionDeposit, headerTransactionWithdrawl, headerTransactionRemainingBalance });
            listviewTransaction.FullRowSelect = true;
            listviewTransaction.GridLines = true;
            listviewTransaction.Location = new Point(379, 98);
            listviewTransaction.MultiSelect = false;
            listviewTransaction.Name = "listviewTransaction";
            listviewTransaction.ShowItemToolTips = true;
            listviewTransaction.Size = new Size(876, 782);
            listviewTransaction.TabIndex = 10;
            listviewTransaction.UseCompatibleStateImageBehavior = false;
            listviewTransaction.View = View.Details;
            // 
            // headerTransactionDate
            // 
            headerTransactionDate.Text = "Date";
            headerTransactionDate.Width = 100;
            // 
            // headerDescription
            // 
            headerDescription.Text = "Description";
            headerDescription.Width = 300;
            // 
            // headerTransactionDeposit
            // 
            headerTransactionDeposit.Text = "Deposit";
            headerTransactionDeposit.Width = 150;
            // 
            // headerTransactionWithdrawl
            // 
            headerTransactionWithdrawl.Text = "Withdrawl";
            headerTransactionWithdrawl.Width = 150;
            // 
            // headerTransactionRemainingBalance
            // 
            headerTransactionRemainingBalance.Text = "Remaining Balance";
            headerTransactionRemainingBalance.Width = 150;
            // 
            // dateTimeTo
            // 
            dateTimeTo.AllowDrop = true;
            dateTimeTo.Location = new Point(727, 65);
            dateTimeTo.Name = "dateTimeTo";
            dateTimeTo.Size = new Size(200, 23);
            dateTimeTo.TabIndex = 9;
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Location = new Point(697, 70);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(18, 15);
            lblTo.TabIndex = 8;
            lblTo.Text = "to";
            // 
            // dateTimeFrom
            // 
            dateTimeFrom.AllowDrop = true;
            dateTimeFrom.Location = new Point(489, 65);
            dateTimeFrom.Name = "dateTimeFrom";
            dateTimeFrom.Size = new Size(200, 23);
            dateTimeFrom.TabIndex = 7;
            // 
            // lblRange
            // 
            lblRange.AutoSize = true;
            lblRange.Location = new Point(373, 70);
            lblRange.Name = "lblRange";
            lblRange.Size = new Size(103, 15);
            lblRange.TabIndex = 6;
            lblRange.Text = "Transaction Range";
            // 
            // btnNewAccount
            // 
            btnNewAccount.FlatStyle = FlatStyle.Flat;
            btnNewAccount.Location = new Point(85, 470);
            btnNewAccount.Name = "btnNewAccount";
            btnNewAccount.Size = new Size(115, 23);
            btnNewAccount.TabIndex = 5;
            btnNewAccount.Text = "New Account";
            btnNewAccount.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.BackColor = SystemColors.Control;
            listView1.Columns.AddRange(new ColumnHeader[] { headerAccountName, headerAccountNickName });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.Location = new Point(85, 61);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(262, 393);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // headerAccountName
            // 
            headerAccountName.Text = "Account Name";
            headerAccountName.Width = 130;
            // 
            // headerAccountNickName
            // 
            headerAccountNickName.Text = "Nickname";
            headerAccountNickName.Width = 130;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 60);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Accounts";
            // 
            // btnNewInstitution
            // 
            btnNewInstitution.FlatStyle = FlatStyle.Flat;
            btnNewInstitution.Location = new Point(364, 11);
            btnNewInstitution.Name = "btnNewInstitution";
            btnNewInstitution.Size = new Size(115, 23);
            btnNewInstitution.TabIndex = 2;
            btnNewInstitution.Text = "New Institution";
            btnNewInstitution.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 1;
            label1.Text = "Institution:";
            // 
            // comboInstitutions
            // 
            comboInstitutions.FormattingEnabled = true;
            comboInstitutions.Location = new Point(85, 11);
            comboInstitutions.Name = "comboInstitutions";
            comboInstitutions.Size = new Size(262, 23);
            comboInstitutions.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.AcceptsReturn = true;
            textBox1.AcceptsTab = true;
            textBox1.Location = new Point(8, 284);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Size = new Size(356, 92);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(166, 86);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1709, 956);
            Controls.Add(panel1);
            Controls.Add(mailStatusStrip);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainWindow";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelTransaction.ResumeLayout(false);
            panelTransaction.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private StatusStrip mailStatusStrip;
        private Panel panel1;
        private Label label1;
        private ComboBox comboInstitutions;
        private Button btnNewInstitution;
        private ListView listView1;
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

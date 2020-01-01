namespace hotelMgtSyst_Accounting
{
    partial class expense_form
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
            this.tabExpenses = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.update_group = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.upd_exp_name = new System.Windows.Forms.TextBox();
            this.upd_exp_bal = new System.Windows.Forms.NumericUpDown();
            this.upd_exp_cost = new System.Windows.Forms.NumericUpDown();
            this.upd_exp_paid = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.upd_exp_date = new System.Windows.Forms.DateTimePicker();
            this.edit_expense = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.upd_exp_desc = new System.Windows.Forms.TextBox();
            this.expense_list = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.paid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.balance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.del_expenses = new System.Windows.Forms.Button();
            this.recExpense = new System.Windows.Forms.Button();
            this.expense_description = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.balance_expense = new System.Windows.Forms.NumericUpDown();
            this.expense_cost = new System.Windows.Forms.NumericUpDown();
            this.amount_paid = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.expense_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.expense_date = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.newPaymentMeans = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.newPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.newPaymentAmount = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.testButton = new System.Windows.Forms.Button();
            this.expenseGridView = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.listExpenseSumm = new System.Windows.Forms.ListView();
            this.listExpenseId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listExpenseName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listExpenseDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listExpenseDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listExpenseCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listExpenseBal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchDateTo = new System.Windows.Forms.DateTimePicker();
            this.searchDateFrom = new System.Windows.Forms.DateTimePicker();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.means_of_payment = new System.Windows.Forms.ComboBox();
            this.upd_means_of_payment = new System.Windows.Forms.ComboBox();
            this.GridExpensePaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridExpenseBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridExpenseMeans = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GridExpenseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabExpenses.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.update_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upd_exp_bal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upd_exp_cost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upd_exp_paid)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.balance_expense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expense_cost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amount_paid)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newPaymentAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabExpenses
            // 
            this.tabExpenses.Controls.Add(this.tabPage1);
            this.tabExpenses.Controls.Add(this.tabPage2);
            this.tabExpenses.Location = new System.Drawing.Point(0, 0);
            this.tabExpenses.Name = "tabExpenses";
            this.tabExpenses.SelectedIndex = 0;
            this.tabExpenses.Size = new System.Drawing.Size(948, 444);
            this.tabExpenses.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.update_group);
            this.tabPage1.Controls.Add(this.expense_list);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(940, 418);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Expenses";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // update_group
            // 
            this.update_group.Controls.Add(this.upd_means_of_payment);
            this.update_group.Controls.Add(this.label12);
            this.update_group.Controls.Add(this.upd_exp_name);
            this.update_group.Controls.Add(this.upd_exp_bal);
            this.update_group.Controls.Add(this.upd_exp_cost);
            this.update_group.Controls.Add(this.upd_exp_paid);
            this.update_group.Controls.Add(this.label9);
            this.update_group.Controls.Add(this.label10);
            this.update_group.Controls.Add(this.label11);
            this.update_group.Controls.Add(this.label8);
            this.update_group.Controls.Add(this.upd_exp_date);
            this.update_group.Controls.Add(this.edit_expense);
            this.update_group.Controls.Add(this.label7);
            this.update_group.Controls.Add(this.upd_exp_desc);
            this.update_group.Location = new System.Drawing.Point(288, 228);
            this.update_group.Name = "update_group";
            this.update_group.Size = new System.Drawing.Size(644, 180);
            this.update_group.TabIndex = 13;
            this.update_group.TabStop = false;
            this.update_group.Text = "Update expense record";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Name";
            // 
            // upd_exp_name
            // 
            this.upd_exp_name.Location = new System.Drawing.Point(12, 40);
            this.upd_exp_name.Name = "upd_exp_name";
            this.upd_exp_name.Size = new System.Drawing.Size(200, 20);
            this.upd_exp_name.TabIndex = 21;
            // 
            // upd_exp_bal
            // 
            this.upd_exp_bal.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.upd_exp_bal.Location = new System.Drawing.Point(108, 124);
            this.upd_exp_bal.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.upd_exp_bal.Name = "upd_exp_bal";
            this.upd_exp_bal.ReadOnly = true;
            this.upd_exp_bal.Size = new System.Drawing.Size(104, 20);
            this.upd_exp_bal.TabIndex = 20;
            this.upd_exp_bal.ValueChanged += new System.EventHandler(this.upd_exp_bal_ValueChanged);
            // 
            // upd_exp_cost
            // 
            this.upd_exp_cost.Location = new System.Drawing.Point(108, 68);
            this.upd_exp_cost.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.upd_exp_cost.Name = "upd_exp_cost";
            this.upd_exp_cost.Size = new System.Drawing.Size(104, 20);
            this.upd_exp_cost.TabIndex = 18;
            this.upd_exp_cost.ValueChanged += new System.EventHandler(this.upd_exp_cost_ValueChanged);
            // 
            // upd_exp_paid
            // 
            this.upd_exp_paid.Location = new System.Drawing.Point(108, 96);
            this.upd_exp_paid.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.upd_exp_paid.Name = "upd_exp_paid";
            this.upd_exp_paid.Size = new System.Drawing.Size(104, 20);
            this.upd_exp_paid.TabIndex = 19;
            this.upd_exp_paid.ValueChanged += new System.EventHandler(this.upd_exp_paid_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Expense Cost";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Balance";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Amount Paid";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(256, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Date";
            // 
            // upd_exp_date
            // 
            this.upd_exp_date.Location = new System.Drawing.Point(300, 124);
            this.upd_exp_date.Name = "upd_exp_date";
            this.upd_exp_date.Size = new System.Drawing.Size(208, 20);
            this.upd_exp_date.TabIndex = 13;
            // 
            // edit_expense
            // 
            this.edit_expense.Location = new System.Drawing.Point(516, 60);
            this.edit_expense.Name = "edit_expense";
            this.edit_expense.Size = new System.Drawing.Size(120, 60);
            this.edit_expense.TabIndex = 10;
            this.edit_expense.Text = "Update Expense";
            this.edit_expense.UseVisualStyleBackColor = true;
            this.edit_expense.Click += new System.EventHandler(this.updateExpense_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(332, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Expense Description";
            // 
            // upd_exp_desc
            // 
            this.upd_exp_desc.Location = new System.Drawing.Point(256, 44);
            this.upd_exp_desc.Multiline = true;
            this.upd_exp_desc.Name = "upd_exp_desc";
            this.upd_exp_desc.Size = new System.Drawing.Size(252, 76);
            this.upd_exp_desc.TabIndex = 11;
            // 
            // expense_list
            // 
            this.expense_list.CheckBoxes = true;
            this.expense_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.name,
            this.description,
            this.cost,
            this.paid,
            this.balance,
            this.date});
            this.expense_list.Location = new System.Drawing.Point(292, 16);
            this.expense_list.Name = "expense_list";
            this.expense_list.Size = new System.Drawing.Size(640, 204);
            this.expense_list.TabIndex = 1;
            this.expense_list.UseCompatibleStateImageBehavior = false;
            this.expense_list.View = System.Windows.Forms.View.Details;
            this.expense_list.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.expense_list_ItemChecked);
            this.expense_list.SelectedIndexChanged += new System.EventHandler(this.expense_list_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.Text = "ID";
            // 
            // name
            // 
            this.name.Text = "NAME";
            // 
            // description
            // 
            this.description.Text = "DESCRIPTION";
            this.description.Width = 121;
            // 
            // cost
            // 
            this.cost.Text = "COST";
            // 
            // paid
            // 
            this.paid.Text = "PAID";
            // 
            // balance
            // 
            this.balance.Text = "BALANCE";
            this.balance.Width = 86;
            // 
            // date
            // 
            this.date.Text = "DATE";
            this.date.Width = 143;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.means_of_payment);
            this.groupBox1.Controls.Add(this.del_expenses);
            this.groupBox1.Controls.Add(this.recExpense);
            this.groupBox1.Controls.Add(this.expense_description);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.balance_expense);
            this.groupBox1.Controls.Add(this.expense_cost);
            this.groupBox1.Controls.Add(this.amount_paid);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.expense_name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.expense_date);
            this.groupBox1.Location = new System.Drawing.Point(0, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 396);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Expense";
            // 
            // del_expenses
            // 
            this.del_expenses.Location = new System.Drawing.Point(8, 328);
            this.del_expenses.Name = "del_expenses";
            this.del_expenses.Size = new System.Drawing.Size(268, 40);
            this.del_expenses.TabIndex = 10;
            this.del_expenses.Text = "Delete Expense";
            this.del_expenses.UseVisualStyleBackColor = true;
            this.del_expenses.Click += new System.EventHandler(this.del_expense_Click);
            // 
            // recExpense
            // 
            this.recExpense.Location = new System.Drawing.Point(8, 276);
            this.recExpense.Name = "recExpense";
            this.recExpense.Size = new System.Drawing.Size(268, 40);
            this.recExpense.TabIndex = 10;
            this.recExpense.Text = "Record Expense";
            this.recExpense.UseVisualStyleBackColor = true;
            this.recExpense.Click += new System.EventHandler(this.recExpense_Click);
            // 
            // expense_description
            // 
            this.expense_description.Location = new System.Drawing.Point(8, 196);
            this.expense_description.Multiline = true;
            this.expense_description.Name = "expense_description";
            this.expense_description.Size = new System.Drawing.Size(268, 64);
            this.expense_description.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Expense Description";
            // 
            // balance_expense
            // 
            this.balance_expense.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.balance_expense.Location = new System.Drawing.Point(80, 136);
            this.balance_expense.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.balance_expense.Name = "balance_expense";
            this.balance_expense.ReadOnly = true;
            this.balance_expense.Size = new System.Drawing.Size(68, 20);
            this.balance_expense.TabIndex = 7;
            // 
            // expense_cost
            // 
            this.expense_cost.Location = new System.Drawing.Point(80, 80);
            this.expense_cost.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.expense_cost.Name = "expense_cost";
            this.expense_cost.Size = new System.Drawing.Size(68, 20);
            this.expense_cost.TabIndex = 6;
            this.expense_cost.ValueChanged += new System.EventHandler(this.expense_cost_ValueChanged);
            // 
            // amount_paid
            // 
            this.amount_paid.Location = new System.Drawing.Point(80, 108);
            this.amount_paid.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.amount_paid.Name = "amount_paid";
            this.amount_paid.Size = new System.Drawing.Size(68, 20);
            this.amount_paid.TabIndex = 6;
            this.amount_paid.ValueChanged += new System.EventHandler(this.amount_paid_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Expense Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Balance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Amount Paid";
            // 
            // expense_name
            // 
            this.expense_name.Location = new System.Drawing.Point(76, 20);
            this.expense_name.Name = "expense_name";
            this.expense_name.Size = new System.Drawing.Size(200, 20);
            this.expense_name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date";
            // 
            // expense_date
            // 
            this.expense_date.Location = new System.Drawing.Point(56, 48);
            this.expense_date.Name = "expense_date";
            this.expense_date.Size = new System.Drawing.Size(200, 20);
            this.expense_date.TabIndex = 0;
            this.expense_date.ValueChanged += new System.EventHandler(this.expense_date_ValueChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.newPaymentMeans);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.newPaymentDate);
            this.tabPage2.Controls.Add(this.newPaymentAmount);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.testButton);
            this.tabPage2.Controls.Add(this.expenseGridView);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.listExpenseSumm);
            this.tabPage2.Controls.Add(this.searchDateTo);
            this.tabPage2.Controls.Add(this.searchDateFrom);
            this.tabPage2.Controls.Add(this.txtSearch);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(940, 418);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Expense Transactions";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // newPaymentMeans
            // 
            this.newPaymentMeans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newPaymentMeans.FormattingEnabled = true;
            this.newPaymentMeans.Items.AddRange(new object[] {
            "Cash",
            "POS",
            "Bank Deposit",
            "Mobile Transfer",
            "Bank Transfer"});
            this.newPaymentMeans.Location = new System.Drawing.Point(352, 100);
            this.newPaymentMeans.Name = "newPaymentMeans";
            this.newPaymentMeans.Size = new System.Drawing.Size(180, 21);
            this.newPaymentMeans.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(448, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 36);
            this.button1.TabIndex = 13;
            this.button1.Text = "Add Payment";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(352, 60);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(30, 13);
            this.label17.TabIndex = 12;
            this.label17.Text = "Date";
            // 
            // newPaymentDate
            // 
            this.newPaymentDate.Location = new System.Drawing.Point(352, 76);
            this.newPaymentDate.Name = "newPaymentDate";
            this.newPaymentDate.Size = new System.Drawing.Size(180, 20);
            this.newPaymentDate.TabIndex = 11;
            // 
            // newPaymentAmount
            // 
            this.newPaymentAmount.Location = new System.Drawing.Point(356, 36);
            this.newPaymentAmount.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.newPaymentAmount.Name = "newPaymentAmount";
            this.newPaymentAmount.Size = new System.Drawing.Size(72, 20);
            this.newPaymentAmount.TabIndex = 10;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(396, 12);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 13);
            this.label16.TabIndex = 9;
            this.label16.Text = "New Payment";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 8);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(142, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "Search (name or description)";
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(236, 32);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(75, 40);
            this.testButton.TabIndex = 7;
            this.testButton.Text = "Date Filter";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // expenseGridView
            // 
            this.expenseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.expenseGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GridExpensePaid,
            this.GridExpenseBalance,
            this.GridExpenseMeans,
            this.GridExpenseDate});
            this.expenseGridView.Location = new System.Drawing.Point(536, 8);
            this.expenseGridView.Name = "expenseGridView";
            this.expenseGridView.Size = new System.Drawing.Size(404, 328);
            this.expenseGridView.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 60);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "To:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "From:";
            // 
            // listExpenseSumm
            // 
            this.listExpenseSumm.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listExpenseId,
            this.listExpenseName,
            this.listExpenseDesc,
            this.listExpenseDate,
            this.listExpenseCost,
            this.listExpenseBal});
            this.listExpenseSumm.Location = new System.Drawing.Point(8, 128);
            this.listExpenseSumm.Name = "listExpenseSumm";
            this.listExpenseSumm.Size = new System.Drawing.Size(524, 208);
            this.listExpenseSumm.TabIndex = 3;
            this.listExpenseSumm.UseCompatibleStateImageBehavior = false;
            this.listExpenseSumm.View = System.Windows.Forms.View.Details;
            this.listExpenseSumm.SelectedIndexChanged += new System.EventHandler(this.listExpenseSumm_SelectedIndexChanged);
            // 
            // listExpenseId
            // 
            this.listExpenseId.Text = "ID";
            this.listExpenseId.Width = 30;
            // 
            // listExpenseName
            // 
            this.listExpenseName.Text = "Name";
            this.listExpenseName.Width = 144;
            // 
            // listExpenseDesc
            // 
            this.listExpenseDesc.Text = "Description";
            this.listExpenseDesc.Width = 171;
            // 
            // listExpenseDate
            // 
            this.listExpenseDate.Text = "Date";
            // 
            // listExpenseCost
            // 
            this.listExpenseCost.Text = "Cost";
            this.listExpenseCost.Width = 54;
            // 
            // listExpenseBal
            // 
            this.listExpenseBal.Text = "Balance";
            // 
            // searchDateTo
            // 
            this.searchDateTo.Location = new System.Drawing.Point(48, 56);
            this.searchDateTo.Name = "searchDateTo";
            this.searchDateTo.Size = new System.Drawing.Size(180, 20);
            this.searchDateTo.TabIndex = 2;
            this.searchDateTo.ValueChanged += new System.EventHandler(this.searchDateTo_ValueChanged);
            // 
            // searchDateFrom
            // 
            this.searchDateFrom.Location = new System.Drawing.Point(48, 28);
            this.searchDateFrom.Name = "searchDateFrom";
            this.searchDateFrom.Size = new System.Drawing.Size(180, 20);
            this.searchDateFrom.TabIndex = 1;
            this.searchDateFrom.ValueChanged += new System.EventHandler(this.searchDateFrom_ValueChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(152, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(160, 20);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // means_of_payment
            // 
            this.means_of_payment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.means_of_payment.FormattingEnabled = true;
            this.means_of_payment.Items.AddRange(new object[] {
            "Cash",
            "POS",
            "Bank Deposit",
            "Mobile Transfer",
            "Bank Transfer"});
            this.means_of_payment.Location = new System.Drawing.Point(156, 80);
            this.means_of_payment.Name = "means_of_payment";
            this.means_of_payment.Size = new System.Drawing.Size(124, 21);
            this.means_of_payment.TabIndex = 15;
            // 
            // upd_means_of_payment
            // 
            this.upd_means_of_payment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.upd_means_of_payment.FormattingEnabled = true;
            this.upd_means_of_payment.Items.AddRange(new object[] {
            "Cash",
            "POS",
            "Bank Deposit",
            "Mobile Transfer",
            "Bank Transfer"});
            this.upd_means_of_payment.Location = new System.Drawing.Point(16, 152);
            this.upd_means_of_payment.Name = "upd_means_of_payment";
            this.upd_means_of_payment.Size = new System.Drawing.Size(196, 21);
            this.upd_means_of_payment.TabIndex = 23;
            // 
            // GridExpensePaid
            // 
            this.GridExpensePaid.HeaderText = "Paid";
            this.GridExpensePaid.Name = "GridExpensePaid";
            this.GridExpensePaid.ReadOnly = true;
            this.GridExpensePaid.Width = 80;
            // 
            // GridExpenseBalance
            // 
            this.GridExpenseBalance.HeaderText = "Balance";
            this.GridExpenseBalance.Name = "GridExpenseBalance";
            this.GridExpenseBalance.ReadOnly = true;
            this.GridExpenseBalance.Width = 80;
            // 
            // GridExpenseMeans
            // 
            this.GridExpenseMeans.HeaderText = "Means of Payment";
            this.GridExpenseMeans.Name = "GridExpenseMeans";
            // 
            // GridExpenseDate
            // 
            this.GridExpenseDate.HeaderText = "Date";
            this.GridExpenseDate.Name = "GridExpenseDate";
            this.GridExpenseDate.ReadOnly = true;
            this.GridExpenseDate.Width = 200;
            // 
            // expense_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 457);
            this.Controls.Add(this.tabExpenses);
            this.Name = "expense_form";
            this.Text = "Expenses";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.expense_form_FormClosed);
            this.Load += new System.EventHandler(this.expense_form_Load);
            this.tabExpenses.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.update_group.ResumeLayout(false);
            this.update_group.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upd_exp_bal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upd_exp_cost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upd_exp_paid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.balance_expense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expense_cost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amount_paid)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newPaymentAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabExpenses;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox expense_description;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown balance_expense;
        private System.Windows.Forms.NumericUpDown amount_paid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox expense_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker expense_date;
        private System.Windows.Forms.ListView expense_list;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader description;
        private System.Windows.Forms.ColumnHeader cost;
        private System.Windows.Forms.ColumnHeader paid;
        private System.Windows.Forms.ColumnHeader balance;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.Button del_expenses;
        private System.Windows.Forms.Button edit_expense;
        private System.Windows.Forms.NumericUpDown expense_cost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button recExpense;
        private System.Windows.Forms.TextBox upd_exp_desc;
        private System.Windows.Forms.GroupBox update_group;
        private System.Windows.Forms.NumericUpDown upd_exp_bal;
        private System.Windows.Forms.NumericUpDown upd_exp_cost;
        private System.Windows.Forms.NumericUpDown upd_exp_paid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker upd_exp_date;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox upd_exp_name;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListView listExpenseSumm;
        private System.Windows.Forms.DateTimePicker searchDateTo;
        private System.Windows.Forms.DateTimePicker searchDateFrom;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView expenseGridView;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.ColumnHeader listExpenseId;
        private System.Windows.Forms.ColumnHeader listExpenseName;
        private System.Windows.Forms.ColumnHeader listExpenseDesc;
        private System.Windows.Forms.ColumnHeader listExpenseDate;
        private System.Windows.Forms.ColumnHeader listExpenseCost;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ColumnHeader listExpenseBal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker newPaymentDate;
        private System.Windows.Forms.NumericUpDown newPaymentAmount;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox newPaymentMeans;
        private System.Windows.Forms.ComboBox means_of_payment;
        private System.Windows.Forms.ComboBox upd_means_of_payment;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridExpenseMeans;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridExpenseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridExpenseBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn GridExpensePaid;
    }
}
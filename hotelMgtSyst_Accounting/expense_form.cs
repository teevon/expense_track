using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

using System.Data.SqlClient;
using System.Configuration;
namespace hotelMgtSyst_Accounting
{
    public partial class expense_form : Form
    {
        private string connstr = hotelMgtSyst_Accounting.Utility.GetConnectionString();
        private string expenseDataSql = "select * from account_expenses";
        loadpayments lp = new loadpayments();
        private DataTable dtable;
        public delegate void events_fire(object sender, EventArgs e);

        string update_exp_name = "";
        int update_exp_cost = 0;
        string update_exp_desc = "";
        int update_exp_paid = 0;
        int update_exp_bal = 0;
        DateTime update_exp_date;
        int current_payment_index;
        string ExpenseID = "";
        public expense_form()
        {
            InitializeComponent();
            //this.searchDateFrom.ValueChanged += new EventHandler(searchDateFrom_ValueChanged);
        }

        private static DataSet SelectRows(string connectionString, string queryString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            Console.WriteLine("connstring: " + connectionString);
            Console.WriteLine("queryString: " + queryString);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(queryString, connection);
            DataSet expenseDataSet = new DataSet();
            adapter.Fill(expenseDataSet, "account_expenses");
            Console.WriteLine("Table name: " + expenseDataSet.Tables[0].TableName);
            Type mytype = expenseDataSet.GetType();
            IList<PropertyInfo> props = new List<PropertyInfo>(mytype.GetProperties());
            foreach (PropertyInfo prop in props)
            {
                object propValue = prop.GetValue(expenseDataSet, null);
                Console.WriteLine("Propvalue: " + propValue);
            }
            Console.WriteLine("dataset check: " + (expenseDataSet != null));
            connection.Close();
            return expenseDataSet;
        }

        private void initializeListView()
        {
            //set the view to show details
            this.expense_list.View = View.Details;
            this.expense_list.AllowColumnReorder = true;
        }

        private void LoadList()
        {
            //DataTable dtable = new DataTable();
            dtable = SelectRows(connstr, expenseDataSql).Tables["account_expenses"];
            this.expense_list.Items.Clear();
            this.listExpenseSumm.Items.Clear();
            this.newPaymentMeans.SelectedIndex = 0;
            means_of_payment.SelectedIndex = 0;
            upd_means_of_payment.SelectedIndex = 0;
            int dtableCount = dtable.Rows.Count;
            Console.WriteLine("table Row count: " + dtableCount);

            for (int i = 0; i < dtableCount; i++)
            {
                DataRow dRow = dtable.Rows[i];

                if (dRow.RowState != DataRowState.Deleted)
                {
                    ListViewItem lvi = new ListViewItem(dRow["id"].ToString());
                    lvi.SubItems.Add(dRow["expense"].ToString());
                    lvi.SubItems.Add(dRow["expense_description"].ToString());
                    lvi.SubItems.Add(dRow["expense_cost"].ToString());
                    lvi.SubItems.Add(dRow["amount_paid"].ToString());
                    lvi.SubItems.Add(dRow["balance"].ToString());
                    lvi.SubItems.Add(dRow["date"].ToString());
                    this.expense_list.Items.Add(lvi);

                    ListViewItem lvitem = new ListViewItem(dRow["id"].ToString());
                    lvitem.SubItems.Add(dRow["expense"].ToString());
                    lvitem.SubItems.Add(dRow["expense_description"].ToString());
                    lvitem.SubItems.Add(dRow["date"].ToString());
                    lvitem.SubItems.Add(dRow["expense_cost"].ToString());
                    lvitem.SubItems.Add(dRow["balance"].ToString());
                    this.listExpenseSumm.Items.Add(lvitem);

                }
            }
        }
        private void expense_form_Load(object sender, EventArgs e)
        {
            // create the connection
            //SqlConnection conn = new SqlConnection(connstr);
            // string expenseDataSql = "select * from account_expenses";
            //Create a SqlCommand, and identify it as stored procedure.
            //SqlCommand cmdGetExpenses = new SqlCommand(expenseDataSql, conn);
            LoadList();
            //loadExpenseView();
        }
        private void recExpense_Click(object sender, EventArgs e)
        {
            if(this.expense_name.Text == "") {
                MessageBox.Show("The name field cannot be empty");
                return;
            }

            if (this.expense_cost.Value == 0)
            {
                MessageBox.Show("The cost field cannot be zero");
                return;
            }

            SqlConnection conn = new SqlConnection(connstr);
            try
            {
                string add_expense = "INSERT INTO account_expenses (expense_ref, expense, expense_description, expense_cost, amount_paid, balance, date) output INSERTED.Id values(@exp_ref, @expense, @expense_description, @expense_cost, @amount_paid, @balance, @date)";
                int expense_ref = 12004;
                SqlCommand cmdInsertExpense = new SqlCommand(add_expense, conn);

                cmdInsertExpense.Parameters.Add(new SqlParameter("@expense", SqlDbType.VarChar));
                cmdInsertExpense.Parameters.Add(new SqlParameter("@expense_description", SqlDbType.VarChar));
                cmdInsertExpense.Parameters.Add(new SqlParameter("@exp_ref", SqlDbType.Int));
                cmdInsertExpense.Parameters.Add(new SqlParameter("@expense_cost", SqlDbType.Int));
                cmdInsertExpense.Parameters.Add(new SqlParameter("@amount_paid", SqlDbType.Int));
                cmdInsertExpense.Parameters.Add(new SqlParameter("@balance", SqlDbType.Int));
                cmdInsertExpense.Parameters.Add(new SqlParameter("@date", SqlDbType.SmallDateTime));
                cmdInsertExpense.Parameters["@expense"].Value = this.expense_name.Text;
                cmdInsertExpense.Parameters["@exp_ref"].Value = expense_ref;
                cmdInsertExpense.Parameters["@expense_description"].Value = this.expense_description.Text;
                cmdInsertExpense.Parameters["@expense_cost"].Value = this.expense_cost.Value;
                cmdInsertExpense.Parameters["@amount_paid"].Value = this.amount_paid.Value;
                cmdInsertExpense.Parameters["@balance"].Value = this.balance_expense.Value;
                //DateTime expenseDate = this.expense_date.Value;
                cmdInsertExpense.Parameters["@date"].Value = this.expense_date.Value;

                Console.WriteLine(this.expense_date.Value);

                conn.Open();

                int insertResult = (int)cmdInsertExpense.ExecuteScalar();
                if (insertResult < 0)
                {
                    Console.WriteLine("Error inserting data into database");
                }
                else
                {
                    string add_payments = "INSERT INTO account_expense_payments (expense_id, payment_index, txn_date, amount_paid, date_of_payment, balance, net_paid, txn_worth, means_of_payment) values( @expense_id, @payment_index, @txn_date, @amount_paid, @date_of_payment, @balance, @net_paid, @txn_worth, @means_of_payment)";
                    SqlCommand cmdAddPayment = new SqlCommand(add_payments, conn);

                    cmdAddPayment.Parameters.Add(new SqlParameter("@expense_id", SqlDbType.Int));
                    cmdAddPayment.Parameters.Add(new SqlParameter("@payment_index", SqlDbType.Int));
                    cmdAddPayment.Parameters.Add(new SqlParameter("@txn_date", SqlDbType.SmallDateTime));
                    cmdAddPayment.Parameters.Add(new SqlParameter("@amount_paid", SqlDbType.Int));
                    cmdAddPayment.Parameters.Add(new SqlParameter("@date_of_payment", SqlDbType.SmallDateTime));
                    cmdAddPayment.Parameters.Add(new SqlParameter("@balance", SqlDbType.Int));
                    cmdAddPayment.Parameters.Add(new SqlParameter("@net_paid", SqlDbType.Int));
                    cmdAddPayment.Parameters.Add(new SqlParameter("@txn_worth", SqlDbType.Int));
                    cmdAddPayment.Parameters.Add(new SqlParameter("@means_of_payment", SqlDbType.VarChar));
                    cmdAddPayment.Parameters["@expense_id"].Value = insertResult;
                    cmdAddPayment.Parameters["@payment_index"].Value = 1;
                    cmdAddPayment.Parameters["@txn_date"].Value = this.expense_date.Value;
                    cmdAddPayment.Parameters["@amount_paid"].Value = this.amount_paid.Value;
                    cmdAddPayment.Parameters["@date_of_payment"].Value = this.expense_date.Value;
                    cmdAddPayment.Parameters["@balance"].Value = this.balance_expense.Value;
                    cmdAddPayment.Parameters["@net_paid"].Value = this.amount_paid.Value;
                    cmdAddPayment.Parameters["@txn_worth"].Value = this.expense_cost.Value;
                    cmdAddPayment.Parameters["@means_of_payment"].Value = means_of_payment.SelectedItem;
                    //conn.Open();

                    int addPay = cmdAddPayment.ExecuteNonQuery();
                    if (addPay < 0)
                    {
                        Console.WriteLine("Error adding payment into database");
                        MessageBox.Show("Error creating record");
                        return;
                    }
                    MessageBox.Show("New expense recorded");
                    this.amount_paid.Value = this.balance_expense.Value = this.expense_cost.Value = 0;
                    this.expense_name.Text = this.expense_description.Text = "";
                    LoadList();
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
                Properties.Settings.Default.Save();
            }

        }

        private void del_expense_Click(object sender, EventArgs e)
        {
            int expense_list_selected = this.expense_list.CheckedItems.Count;
            if (expense_list_selected == 0)
                return;
            SqlConnection conn = new SqlConnection(connstr);
            try
            {
                string in_id = "(";
                for (int c = 0; c < expense_list_selected; c++)
                {
                    in_id = in_id + "@exp" + c.ToString();
                    if (c + 1 != expense_list_selected)
                    {
                        in_id = in_id + ", ";
                    }
                }
                in_id = in_id + ")";
                string del_expense = "DELETE FROM account_expenses WHERE id in " + in_id;
                string del_payments = "DELETE FROM account_expense_payments WHERE expense_id in " + in_id;
                SqlCommand cmdDelExpense = new SqlCommand(del_expense, conn);
                SqlCommand cmdDelPayments = new SqlCommand(del_payments, conn);

                for (int i = 0; i < expense_list_selected; i++)
                {
                    ListViewItem item = this.expense_list.CheckedItems[i];
                    int id = Convert.ToInt32(item.SubItems[0].Text);
                    cmdDelExpense.Parameters.Add(new SqlParameter("@exp" + i.ToString(), SqlDbType.Int));
                    cmdDelPayments.Parameters.Add(new SqlParameter("@exp" + i.ToString(), SqlDbType.Int));
                    cmdDelExpense.Parameters["@exp" + i.ToString()].Value = id;
                    cmdDelPayments.Parameters["@exp" + i.ToString()].Value = id;
                    //MessageBox.Show(item.SubItems[0].Text);
                }
                conn.Open();


                int delPayments = cmdDelPayments.ExecuteNonQuery();
                int delResult = cmdDelExpense.ExecuteNonQuery();
                if (delResult < 0)
                {
                    Console.WriteLine("Error deleting data into database");
                }
                else
                {
                    MessageBox.Show("Records deleted");
                    LoadList();
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
                Properties.Settings.Default.Save();
            }

        }

        private void updateExpense_Click(object sender, EventArgs e)
        {
            int expense_list_selected = this.expense_list.CheckedItems.Count;
            if (expense_list_selected != 1)
            {
                MessageBox.Show("Select 1 expense to update");
                return;
            }
            List<String> columns_update = new List<String>();

            if (this.upd_exp_name.Text != update_exp_name)
            {
                columns_update.Add("expense = @exp_name");
            }

            if (this.upd_exp_desc.Text != update_exp_desc)
            {
                columns_update.Add("expense_description = @exp_desc");
            }

            if (this.upd_exp_cost.Value != update_exp_cost)
            {
                columns_update.Add("expense_cost = @exp_cost");
            }

            if (this.upd_exp_paid.Value != update_exp_paid)
            {
                columns_update.Add("amount_paid = @exp_paid, balance = @exp_bal");
            }

            if (this.upd_exp_date.Value != update_exp_date)
            {
                columns_update.Add("date = @exp_date");
            }
            
            string update_param = String.Join(",", columns_update.ToArray());
            if(update_param == "")
            {
                MessageBox.Show("No changes were detected");
                return;
            }
            SqlConnection conn = new SqlConnection(connstr);

            try {
                string update_Expense = "UPDATE account_expenses SET " + update_param + " WHERE id = @id";
                string del_payment = "DELETE FROM account_expense_payments WHERE expense_id = @id";
                Console.WriteLine(update_Expense);
                //return;

            SqlCommand cmdUpdateExpense = new SqlCommand(update_Expense, conn);
            SqlCommand cmdDelPay = new SqlCommand(del_payment, conn);

                if (this.upd_exp_name.Text != update_exp_name)
            {
                cmdUpdateExpense.Parameters.Add(new SqlParameter("@exp_name", SqlDbType.VarChar));
                cmdUpdateExpense.Parameters["@exp_name"].Value = this.upd_exp_name.Text;
            }

            if (this.upd_exp_desc.Text != update_exp_desc)
            {
                cmdUpdateExpense.Parameters.Add(new SqlParameter("@exp_desc", SqlDbType.VarChar));
                cmdUpdateExpense.Parameters["@exp_desc"].Value = this.upd_exp_desc.Text;
            }

            if (this.upd_exp_cost.Value != update_exp_cost)
            {
                cmdUpdateExpense.Parameters.Add(new SqlParameter("@exp_cost", SqlDbType.Int));
                cmdUpdateExpense.Parameters["@exp_cost"].Value = this.upd_exp_cost.Value;
            }

            if (this.upd_exp_paid.Value != update_exp_paid)
            {
                cmdUpdateExpense.Parameters.Add(new SqlParameter("@exp_paid", SqlDbType.Int));
                cmdUpdateExpense.Parameters["@exp_paid"].Value = this.upd_exp_paid.Value;
                cmdUpdateExpense.Parameters.Add(new SqlParameter("@exp_bal", SqlDbType.Int));
                cmdUpdateExpense.Parameters["@exp_bal"].Value = this.upd_exp_cost.Value - this.upd_exp_paid.Value;
            }

            if (this.upd_exp_date.Value != update_exp_date)
            {
                cmdUpdateExpense.Parameters.Add(new SqlParameter("@exp_date", SqlDbType.SmallDateTime));
                cmdUpdateExpense.Parameters["@exp_date"].Value = this.upd_exp_date.Value;
            }

            ListViewItem update_item = this.expense_list.CheckedItems[0];
            int id = Convert.ToInt32(update_item.SubItems[0].Text);

            cmdUpdateExpense.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
            cmdUpdateExpense.Parameters["@id"].Value = id;

            cmdDelPay.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
            cmdDelPay.Parameters["@id"].Value = id;

                conn.Open();

            int updateResult = cmdUpdateExpense.ExecuteNonQuery();

            if ((this.upd_exp_cost.Value != update_exp_cost) || (this.upd_exp_paid.Value != update_exp_paid))
            {
              int delResult = cmdDelPay.ExecuteNonQuery();
              if(delResult >= 0)
              {
                 string add_payments = "INSERT INTO account_expense_payments (expense_id, payment_index, txn_date, amount_paid, date_of_payment, balance, net_paid, txn_worth, means_of_payment) values( @expense_id, @payment_index, @txn_date, @amount_paid, @date_of_payment, @balance, @net_paid, @txn_worth, @means_of_payment)";
                 SqlCommand cmdAddPayment = new SqlCommand(add_payments, conn);

                 cmdAddPayment.Parameters.Add(new SqlParameter("@expense_id", SqlDbType.Int));
                 cmdAddPayment.Parameters.Add(new SqlParameter("@payment_index", SqlDbType.Int));
                 cmdAddPayment.Parameters.Add(new SqlParameter("@txn_date", SqlDbType.SmallDateTime));
                 cmdAddPayment.Parameters.Add(new SqlParameter("@amount_paid", SqlDbType.Int));
                 cmdAddPayment.Parameters.Add(new SqlParameter("@date_of_payment", SqlDbType.SmallDateTime));
                 cmdAddPayment.Parameters.Add(new SqlParameter("@balance", SqlDbType.Int));
                 cmdAddPayment.Parameters.Add(new SqlParameter("@net_paid", SqlDbType.Int));
                 cmdAddPayment.Parameters.Add(new SqlParameter("@txn_worth", SqlDbType.Int));
                 cmdAddPayment.Parameters.Add(new SqlParameter("@means_of_payment", SqlDbType.VarChar));
                 cmdAddPayment.Parameters["@expense_id"].Value = id;
                 cmdAddPayment.Parameters["@payment_index"].Value = 1;
                 cmdAddPayment.Parameters["@txn_date"].Value = this.upd_exp_date.Value;
                 cmdAddPayment.Parameters["@amount_paid"].Value = this.upd_exp_paid.Value;
                 cmdAddPayment.Parameters["@date_of_payment"].Value = this.upd_exp_date.Value;
                 cmdAddPayment.Parameters["@balance"].Value = this.upd_exp_cost.Value - this.upd_exp_paid.Value;
                 cmdAddPayment.Parameters["@net_paid"].Value = this.upd_exp_paid.Value;
                 cmdAddPayment.Parameters["@txn_worth"].Value = this.upd_exp_cost.Value;
                 cmdAddPayment.Parameters["@means_of_payment"].Value = this.upd_means_of_payment.SelectedItem;

                 int addPay = cmdAddPayment.ExecuteNonQuery();
                 if(addPay < 0)
                 {
                   //MessageBox.Show(addPay.ToString());
                   MessageBox.Show("Error refactoring payment");
                 }
              }
              else
              {
                //MessageBox.Show(delResult.ToString());
                MessageBox.Show("Error reseting payments");
              }
            }
                
            if (updateResult <= 0)
            {      
               Console.WriteLine("Error updating expense");
               MessageBox.Show("Error updating expense");
               return;
            }
            else
            {
                MessageBox.Show("Record updated");
                LoadList();
            }
          }
          catch (SqlException ex)
            {
                throw ex;
            }
         catch (Exception ex)
            {
                throw ex;
            }
         finally
            {
                conn.Close();
                Properties.Settings.Default.Save();
            }
        }

        private void expense_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void expense_list_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            int expense_list_checked = this.expense_list.CheckedItems.Count;
            if (expense_list_checked == 1)
            {
                SqlConnection conn = new SqlConnection(connstr);
                string readExpense = "select * from account_expenses where id = @id";

                //NC-7 Create a SqlCommand, and identify it as stored procedure.
                SqlCommand cmdGetExpense = new SqlCommand(readExpense, conn);

                cmdGetExpense.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                cmdGetExpense.Parameters["@id"].Value = this.expense_list.CheckedItems[0].SubItems[0].Text;

                //open the connection.
                conn.Open();
                SqlDataReader rdr = cmdGetExpense.ExecuteReader();

                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        update_exp_name = rdr.GetString(1);
                        this.upd_exp_name.Text = update_exp_name;

                        update_exp_cost = rdr.GetInt32(3);
                        this.upd_exp_cost.Value = update_exp_cost;

                        update_exp_desc = rdr.GetString(4);
                        this.upd_exp_desc.Text = update_exp_desc;

                        update_exp_paid = rdr.GetInt32(5);
                        this.upd_exp_paid.Value = update_exp_paid;

                        update_exp_bal = rdr.GetInt32(6);
                        this.upd_exp_bal.Value = update_exp_bal;

                        update_exp_date = DateTime.Parse(rdr["date"].ToString());
                        this.upd_exp_date.Value = update_exp_date;
                        //MessageBox.Show("Worked");
                        //Console.WriteLine(rdr["date"].GetType());
                    }
                    return;
                }
                else
                {
                    MessageBox.Show("Nothing retrieved");
                }

            }
            else
            {
                reset_update();
            }
        }

        private void reset_update()
        {
            this.upd_exp_name.Text = "";
            this.upd_exp_cost.Value = 0;
            this.upd_exp_desc.Text = "";
            this.upd_exp_paid.Value = 0;
            this.upd_exp_bal.Value = 0;
            this.upd_exp_date.Value = DateTime.Now;
            update_exp_name = "";
            update_exp_cost = 0;
            update_exp_desc = "";
            update_exp_paid = 0;
            update_exp_bal = 0;
            update_exp_date = DateTime.Parse("1592-11-11");
        }

        private void expense_date_ValueChanged(object sender, EventArgs e)
        {

        }

        /*private void loadExpenseView()
        {
            //DataTable summExpense = new DataTable();
            dtable = SelectRows(connstr, expenseDataSql).Tables["account_expenses"];
            this.listExpenseSumm.Items.Clear();
            int summExpenseCount = dtable.Rows.Count;
            Console.WriteLine("table Rows count: " + summExpenseCount);

            for (int i = 0; i < summExpenseCount; i++)
            {
                DataRow dRow = dtable.Rows[i];

                if (dRow.RowState != DataRowState.Deleted)

                {
                    ListViewItem lvitem = new ListViewItem(dRow["id"].ToString());
                    lvitem.SubItems.Add(dRow["expense"].ToString());
                    lvitem.SubItems.Add(dRow["expense_description"].ToString());
                    this.listExpenseSumm.Items.Add(lvitem);
                }
            }
        } */

        private void testButton_Click(object sender, EventArgs e)
        {
            dateFilter();
        }

        private void listExpenseSumm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listExpenseSumm.SelectedItems.Count > 0)
            {
                ExpenseID = listExpenseSumm.SelectedItems[0].Text;
                current_payment_index = lp.loadpayment(ExpenseID, this.expenseGridView, this.newPaymentDate, this.newPaymentAmount);
            }
                /*
            if (this.listExpenseSumm.SelectedItems.Count > 0)
            {
                string expense_id = this.listExpenseSumm.SelectedItems[0].Text;
                SqlConnection conn = new SqlConnection(connstr);
                string readPayments = "select amount_paid, balance, date_of_payment, payment_index from account_expense_payments where expense_id = @id";
                Console.WriteLine("expense ID: " + readPayments);

                //NC-7 Create a SqlCommand, and identify it as stored procedure.
                SqlCommand cmdGetPayments = new SqlCommand(readPayments, conn);

                cmdGetPayments.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                cmdGetPayments.Parameters["@id"].Value = expense_id;

                //open the connection.
                conn.Open();
                SqlDataReader rdr = cmdGetPayments.ExecuteReader();
                this.expenseGridView.Rows.Clear();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        string amount_paid = rdr.GetInt32(0).ToString();
                        string balance = rdr.GetInt32(1).ToString();
                        //string balance = rdr["balance"].ToString();

                        string payment_date = rdr["date_of_payment"].ToString();

                        string[] row = new string[] { amount_paid, balance, payment_date };
                        this.expenseGridView.Rows.Add(row);
                        this.newPaymentDate.MinDate = DateTime.Parse(payment_date);
                        this.newPaymentDate.MaxDate = DateTime.Today;
                        this.newPaymentAmount.Maximum = rdr.GetInt32(1);
                        current_payment_index = rdr.GetInt32(3);
                    }
                }
             }
            */
        }

        public void searchFilter()
        {
            string searchQ = this.txtSearch.Text;
            if (searchQ != "") {
                SqlConnection conn = new SqlConnection(connstr);
                string searchSQL = "select id, expense, expense_description, date, expense_cost, balance  from account_expenses where expense like '%' + @search + '%' or expense_description like '%' + @search + '%'";
                SqlCommand cmdGetExpenses = new SqlCommand(searchSQL, conn);

                cmdGetExpenses.Parameters.Add(new SqlParameter("@search", SqlDbType.VarChar));
                cmdGetExpenses.Parameters["@search"].Value = searchQ;
                //open the connection.
                conn.Open();
                SqlDataReader rdr = cmdGetExpenses.ExecuteReader();
                this.listExpenseSumm.Items.Clear();

                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        ListViewItem lvitem = new ListViewItem(rdr.GetInt32(0).ToString());
                        lvitem.SubItems.Add(rdr.GetString(1));
                        lvitem.SubItems.Add(rdr.GetString(2));
                        string date_expense = rdr["date"].ToString();
                        lvitem.SubItems.Add(date_expense);
                        lvitem.SubItems.Add((rdr.GetInt32(4)).ToString());
                        lvitem.SubItems.Add((rdr.GetInt32(5)).ToString());
                        this.listExpenseSumm.Items.Add(lvitem);
                    }
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            searchFilter();
        }

        private void dateFilter()
        {
            SqlConnection conn = new SqlConnection(connstr);
            string dateFilterSql = "select id, expense, expense_description, date, expense_cost, balance  from account_expenses where date >= @dateFrom and date <= @dateTo";
            SqlCommand cmdGetExpenses = new SqlCommand(dateFilterSql, conn);

            cmdGetExpenses.Parameters.Add(new SqlParameter("@dateFrom", SqlDbType.SmallDateTime));
            cmdGetExpenses.Parameters["@dateFrom"].Value = this.searchDateFrom.Value.AddDays(-1);
            cmdGetExpenses.Parameters.Add(new SqlParameter("@dateTo", SqlDbType.SmallDateTime));
            cmdGetExpenses.Parameters["@dateTo"].Value = this.searchDateTo.Value;
            //open the connection.
            conn.Open();
            SqlDataReader rdr = cmdGetExpenses.ExecuteReader();
            this.listExpenseSumm.Items.Clear();

            if (rdr.HasRows)
            {
                while (rdr.Read())
                {
                    ListViewItem lvitem = new ListViewItem(rdr.GetInt32(0).ToString());
                    lvitem.SubItems.Add(rdr.GetString(1));
                    lvitem.SubItems.Add(rdr.GetString(2));
                    string date_expense = rdr["date"].ToString();
                    lvitem.SubItems.Add(date_expense);
                    lvitem.SubItems.Add((rdr.GetInt32(4)).ToString());
                    lvitem.SubItems.Add((rdr.GetInt32(5)).ToString());
                    this.listExpenseSumm.Items.Add(lvitem);
                }
            }
        }

        private void constrainDates(DateTimePicker dateFrom, DateTimePicker dateTo)
        {
            if(dateFrom.Value > dateTo.Value) {
                dateTo.Value = dateFrom.Value;
            }
            if (dateTo.Value < dateFrom.Value) { dateTo.Value = dateFrom.Value; }
        }

        private void searchDateFrom_ValueChanged(object sender, EventArgs e)
        {
            constrainDates(this.searchDateFrom, this.searchDateTo);
        }

        private void searchDateTo_ValueChanged(object sender, EventArgs e)
        {
            constrainDates(this.searchDateFrom, this.searchDateTo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string listViewExpenseDate = "";
            int newPaymentBalance;
            int listViewTxnWorth;
            if(newPaymentAmount.Value == 0)
            {
                MessageBox.Show("Please input a valid amount");
                return;
            }
            if (this.listExpenseSumm.SelectedItems.Count > 0)
            {
                SqlConnection conn = new SqlConnection(connstr);
                try
                {
                    string add_payments = "INSERT INTO account_expense_payments (expense_id, payment_index, txn_date, amount_paid, date_of_payment, balance, net_paid, txn_worth, means_of_payment) values( @expense_id, @payment_index, @txn_date, @amount_paid, @date_of_payment, @balance, @net_paid, @txn_worth, @means_of_payment)";
                    SqlCommand cmdAddPayment = new SqlCommand(add_payments, conn);

                    cmdAddPayment.Parameters.Add(new SqlParameter("@expense_id", SqlDbType.Int));
                    cmdAddPayment.Parameters.Add(new SqlParameter("@payment_index", SqlDbType.Int));
                    cmdAddPayment.Parameters.Add(new SqlParameter("@txn_date", SqlDbType.SmallDateTime));
                    cmdAddPayment.Parameters.Add(new SqlParameter("@amount_paid", SqlDbType.Int));
                    cmdAddPayment.Parameters.Add(new SqlParameter("@date_of_payment", SqlDbType.SmallDateTime));
                    cmdAddPayment.Parameters.Add(new SqlParameter("@balance", SqlDbType.Int));
                    cmdAddPayment.Parameters.Add(new SqlParameter("@net_paid", SqlDbType.Int));
                    cmdAddPayment.Parameters.Add(new SqlParameter("@txn_worth", SqlDbType.Int));
                    cmdAddPayment.Parameters.Add(new SqlParameter("@means_of_payment", SqlDbType.VarChar));
                    cmdAddPayment.Parameters["@expense_id"].Value = Int32.Parse(this.listExpenseSumm.SelectedItems[0].Text);
                    cmdAddPayment.Parameters["@payment_index"].Value = current_payment_index + 1;
                    listViewExpenseDate = this.listExpenseSumm.SelectedItems[0].SubItems[3].Text;
                    cmdAddPayment.Parameters["@txn_date"].Value = DateTime.Parse(listViewExpenseDate);
                    cmdAddPayment.Parameters["@amount_paid"].Value = this.newPaymentAmount.Value;
                    cmdAddPayment.Parameters["@date_of_payment"].Value = this.newPaymentDate.Value;
                    newPaymentBalance = (Int32.Parse(this.listExpenseSumm.SelectedItems[0].SubItems[5].Text)) - ((int)this.newPaymentAmount.Value);
                    cmdAddPayment.Parameters["@balance"].Value = newPaymentBalance;
                    listViewTxnWorth = (Int32.Parse(this.listExpenseSumm.SelectedItems[0].SubItems[4].Text));
                    cmdAddPayment.Parameters["@net_paid"].Value = listViewTxnWorth - newPaymentBalance;
                    cmdAddPayment.Parameters["@txn_worth"].Value = listViewTxnWorth;
                    //this.ComboBox.GetItemText(this.ComboBox.SelectedItem)
                    cmdAddPayment.Parameters["@means_of_payment"].Value = this.newPaymentMeans.SelectedItem;

                    conn.Open();

                    int insertResult = cmdAddPayment.ExecuteNonQuery();
                    if (insertResult < 0)
                    {
                        Console.WriteLine("Error inserting data into database");
                    }
                    else
                    {
                        try
                        {
                            string update_Expense = "UPDATE account_expenses SET amount_paid = @exp_paid, balance = @exp_bal WHERE id = @id";
                            SqlCommand cmdUpdateExpense = new SqlCommand(update_Expense, conn);

                            cmdUpdateExpense.Parameters.Add(new SqlParameter("@exp_paid", SqlDbType.Int));
                            cmdUpdateExpense.Parameters["@exp_paid"].Value = listViewTxnWorth - newPaymentBalance;
                            cmdUpdateExpense.Parameters.Add(new SqlParameter("@exp_bal", SqlDbType.Int));
                            cmdUpdateExpense.Parameters["@exp_bal"].Value = newPaymentBalance;
                            cmdUpdateExpense.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                            cmdUpdateExpense.Parameters["@id"].Value = Int32.Parse(this.listExpenseSumm.SelectedItems[0].Text);

                            int updateResult = cmdUpdateExpense.ExecuteNonQuery();
                            if (updateResult < 0)
                            {
                                Console.WriteLine("Error updating expense");
                            }
                            else
                            {
                                LoadList();
                            }

                        }
                        catch (SqlException SqlEx)
                        {
                            throw SqlEx;
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                        finally
                        {
                            //conn.Close();
                            Properties.Settings.Default.Save();
                        }
                        LoadList();
                    }
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                    Properties.Settings.Default.Save();
                }
            } else {
                MessageBox.Show("Please select a transaction to add payment");
                return;
            }

            Console.WriteLine("About to load");
            current_payment_index = lp.loadpayment(ExpenseID, this.expenseGridView, this.newPaymentDate, this.newPaymentAmount);
            Console.WriteLine("Loaded");
            Console.WriteLine("current index: " + current_payment_index.ToString());
        }

        private void expense_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void amount_paid_ValueChanged(object sender, EventArgs e)
        {
            this.balance_expense.Value = this.expense_cost.Value - this.amount_paid.Value;
        }

        private void expense_cost_ValueChanged(object sender, EventArgs e)
        {
            this.amount_paid.Maximum = this.expense_cost.Value;
            if (amount_paid.Value > amount_paid.Value)
            {
                this.amount_paid.Value = 0;
                this.balance_expense.Value = this.expense_cost.Value;
            }
            else
            {
                balance_expense.Value = expense_cost.Value - amount_paid.Value;
            }
        }

        private void upd_exp_bal_ValueChanged(object sender, EventArgs e)
        {

        }

        private void upd_exp_cost_ValueChanged(object sender, EventArgs e)
        {
            this.upd_exp_paid.Maximum = this.upd_exp_cost.Value;
            this.upd_exp_bal.Value = this.upd_exp_cost.Value;
            upd_exp_bal.Value = upd_exp_cost.Value - upd_exp_paid.Value;

           /* if (upd_exp_paid.Value > upd_exp_cost.Value) {
                this.upd_exp_paid.Value = 0;
                this.upd_exp_bal.Value = this.upd_exp_cost.Value;
            }
            else
            {
                upd_exp_bal.Value = upd_exp_cost.Value - upd_exp_paid.Value;
            } */
        }

        private void upd_exp_paid_ValueChanged(object sender, EventArgs e)
        {
            this.upd_exp_bal.Value = this.upd_exp_cost.Value - this.upd_exp_paid.Value;
        }
    }
}

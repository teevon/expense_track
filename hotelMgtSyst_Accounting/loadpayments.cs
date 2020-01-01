using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace hotelMgtSyst_Accounting
{
    class loadpayments
    {
        private string connstr = hotelMgtSyst_Accounting.Utility.GetConnectionString();
        public int loadpayment(string expense_id, DataGridView expenseGridView, DateTimePicker newPaymentDate, NumericUpDown newPaymentAmount)
        {
            int current_payment_index = 0;
            if (expense_id != "")
            {
                //string expense_id = listExpenseSumm.SelectedItems[0].Text;
                SqlConnection conn = new SqlConnection(connstr);
                string readPayments = "select amount_paid, balance, means_of_payment, date_of_payment, payment_index from account_expense_payments where expense_id = @id";
                Console.WriteLine("loaded payment.cs: expense ID: " + readPayments);

                //NC-7 Create a SqlCommand, and identify it as stored procedure.
                SqlCommand cmdGetPayments = new SqlCommand(readPayments, conn);

                cmdGetPayments.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                cmdGetPayments.Parameters["@id"].Value = expense_id;

                //open the connection.
                conn.Open();
                SqlDataReader rdr = cmdGetPayments.ExecuteReader();
                expenseGridView.Rows.Clear();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        string amount_paid = rdr.GetInt32(0).ToString();
                        string balance = rdr.GetInt32(1).ToString();
                        string means_of_payment = rdr.GetString(2).ToString();
                        //string balance = rdr["balance"].ToString();

                        string payment_date = rdr["date_of_payment"].ToString();

                        string[] row = new string[] { amount_paid, balance, means_of_payment, payment_date };
                        expenseGridView.Rows.Add(row);
                        newPaymentDate.MinDate = DateTime.Parse(payment_date);
                        newPaymentDate.MaxDate = DateTime.Today;
                        newPaymentAmount.Maximum = rdr.GetInt32(1);
                        current_payment_index = rdr.GetInt32(4);
                        Console.WriteLine("PaymentIndex from loadpayments " + current_payment_index.ToString());
                    }
                    Console.WriteLine("Payment.cs: Loading the payments, index: "+ current_payment_index.ToString());
                    return current_payment_index;
                }
            }
            Console.WriteLine("Index outside if branch: " + current_payment_index.ToString());
            return current_payment_index;
        }
    }
}

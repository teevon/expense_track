using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace hotelMgtSyst_Accounting
{
    public partial class Logon : Form
    {
        private string connstr = hotelMgtSyst_Accounting.Utility.GetConnectionString();
        private string username;
       // private string password;
       // private string rdrUser;
        private string rdrPass;
        public Logon()
        {
            InitializeComponent();
        }

        private void logon_btn_Click(object sender, EventArgs e)
        {
            connstr = hotelMgtSyst_Accounting.Utility.GetConnectionString();
            Console.WriteLine("test "+ connstr);
            if (this.username_txt.Text != "")
            {
                username = this.username_txt.Text;
                //NC-6 create the connection.
                SqlConnection conn = new SqlConnection(connstr);
                string readPassword = "select password from account_users where user_name = @username";

                //NC-7 Create a SqlCommand, and identify it as stored procedure.
                SqlCommand cmdGetPass = new SqlCommand(readPassword, conn);

                cmdGetPass.Parameters.Add(new SqlParameter("@username", SqlDbType.VarChar));
                cmdGetPass.Parameters["@username"].Value = username;

                try
                {
                    //open the connection.
                    conn.Open();
                    SqlDataReader rdr = cmdGetPass.ExecuteReader();
                    //MessageBox.Show("Nothing much");
                    
                    if(rdr.HasRows)
                    {
                        while (rdr.Read())
                        {
                            rdrPass = rdr.GetString(0);
                        }
                        if(rdrPass == this.password_txt.Text)
                        {
                            //MessageBox.Show("Password match");
                            this.password_txt.Text = "";
                            this.username_txt.Text = "";
                            hotelAccounts hotAcc = new hotelAccounts();
                            hotelAccContext.formCount++;
                            hotAcc.Closed += new EventHandler(hotelAccContext.CurrentContext.OnFormClosed);
                            hotAcc.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Wrong username or password");
                            this.password_txt.Text = "";
                            this.username_txt.Text = "";
                        }
                    } else
                    {
                        MessageBox.Show("This username does not exist");
                        this.password_txt.Text = "";
                        this.username_txt.Text = "";
                    }
                    
                    //Create a data table to hold the retrieved data.
                    //DataTable dataTable = new DataTable();

                    //Load the data from SqlDataReader into the data table.
                    //dataTable.Load(rdr);
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("Invalid username or password " +sqlEx.Message);
                }
                finally
                {
                    //close the connection
                    conn.Close();
                }
            }
        }

        public delegate void placeholder_txt(object sender, EventArgs e);
         
        public void RemoveText(object sender, EventArgs e)
        {
            if (this.username_txt.Text == "Enter Username here")
            {
                this.username_txt.Text = "";
            }

            if (this.password_txt.Text == "")
            {
                this.password_txt.PasswordChar = '\0';
                this.password_txt.Text = "Enter password here";
            }

        }

        public void AddText(object sender, EventArgs e)
        {
            if (this.username_txt.Text == "")
            {
                this.username_txt.Text = "Enter Username here";
            }
            
            if (this.password_txt.Text == "Enter password here")
            {
                this.password_txt.Text = "";
                this.password_txt.PasswordChar = '*';
            }
        }

        private void Logon_Load(object sender, EventArgs e)
        {
            placeholder_txt ph_t1 = new placeholder_txt(this.AddText);
            placeholder_txt ph_t2 = new placeholder_txt(this.RemoveText);
            this.username_txt.Text = "Enter Username here";
            this.username_txt.Enter += new EventHandler(ph_t2);
            this.username_txt.Leave += new EventHandler(ph_t1);
            this.password_txt.Text = "Enter password here";
        }

        private void password_txt_TextChanged(object sender, EventArgs e)
        {
            if(password_txt.Text != "Enter password here") {
                password_txt.PasswordChar = '*';
            }
        }
    }
}

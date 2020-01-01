using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelMgtSyst_Accounting
{
    public class hotelAccContext : ApplicationContext
    {
        public static int formCount;
        private Logon _hotelAccLogon;
        public delegate void form_closer(object sender, EventArgs e);
        public static hotelAccContext CurrentContext;

        public hotelAccContext()
        {
            CurrentContext = this;
            formCount = 1;
            form_closer frmClose_1 = new form_closer(OnFormClosed);
            _hotelAccLogon = new Logon();
            _hotelAccLogon.Closed += new EventHandler(frmClose_1);
            _hotelAccLogon.Show();
        }

        public void OnFormClosed(Object sender, EventArgs e)
        {
            formCount--;
            if(formCount == 0)
            {
                ExitThread();
            }
        }

       // private void OnFormOpened(Object sender, EventArgs e)
       // {
       //     if(sender.GetType().Name == "hotelAccounts")
       //     {
       //         formCount++;
       //     }
       // }
    }
}

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelMgtSyst_Accounting
{
    class forms_shared : ApplicationContext
    {
        public void OnFormClosed(Object sender, EventArgs e)
        {
            hotelAccContext.formCount--;
            ExitThread();
        }
    }
}

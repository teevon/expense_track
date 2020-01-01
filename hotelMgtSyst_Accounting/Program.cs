using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotelMgtSyst_Accounting
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Create the HotelAccContext that derives from the  ApplicationContext
            // that manages when the application should exit
            Application.SetCompatibleTextRenderingDefault(false);
            Application.EnableVisualStyles();
            hotelAccContext context = new hotelAccContext();
            //Application.Run(context);
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Logon());
            Application.Run(context);
        }
    }
}

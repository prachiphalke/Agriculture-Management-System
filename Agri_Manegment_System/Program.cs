using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agri_Manegment_System
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

             Application.Run(new FrmHome());
             //Application.Run(new FrmApplicationDetails());
            //Application.Run(new FrmPersonalDetails());
            //Application.Run(new FrmAgricultureLand_CropDetails());
            //Application.Run(new FrmNFSM());
            //Application.Run(new FrmApproval());
            //Application.Run(new frmReports());

        }
    }
}

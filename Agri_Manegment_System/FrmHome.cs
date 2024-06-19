using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Agri_Manegment_System
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            SetConnection();
            InitializeComponent();
        }
        private static string myconn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:/BCS_9436/Agri_mng.mdb";
        public OleDbConnection conn = new OleDbConnection(myconn);
        public void SetConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                
            }
        }

        private void btnNFSM_Click(object sender, EventArgs e)
        {
            
            FrmNFSM n = new FrmNFSM();
            n.Show();
            this.Hide();
            
        }

        private void btnSAMS_Click(object sender, EventArgs e)
        {
            FrmApplicationDetails ap = new FrmApplicationDetails();
            ap.Show();
            this.Hide();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frmReports r = new frmReports();
            r.Show();
            this.Hide();
        }

        private void btnrep1_Click(object sender, EventArgs e)
        {
            Report1 r1 = new Report1();
            r1.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

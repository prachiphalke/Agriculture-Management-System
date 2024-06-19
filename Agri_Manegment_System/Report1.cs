using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using System.Data.OleDb;

namespace Agri_Manegment_System
{
    public partial class Report1 : Form
    {
        private static string myconn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:/BCS_9436/Agri_mng.mdb";
        static OleDbConnection conn = new OleDbConnection(myconn);
        OleDbCommand cmd = new OleDbCommand();
        DataTable dt = new DataTable();

        public Report1()
        {
            InitializeComponent();
            SetConnection();
        }
        public void SetConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                //MessageBox.Show("Connection Open");
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (cmbReportType.Text == "Farmer wise Report")
            {
                ReportDocument crypt = new ReportDocument();
                crypt.Load("D:/BCS_9436/Agri_Manegment_System/Agri_Manegment_System/reports/Scheme1.rpt");
                crypt.RecordSelectionFormula = "{AppDetails.appno} = " + Convert.ToInt32(txtappno.Text) + "";
                panel1.Visible = false;
                crypt.Refresh();
                CrystalReportViewer view2 = new CrystalReportViewer();
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
                dtpstartdate.Visible = false;
                lblsdt.Visible = false;
                dtpenddate.Visible = false;
                lblenddt.Visible = false;
                   
                view2.Dock = DockStyle.Fill;
                view2.ReportSource = crypt;
                this.Controls.Add(view2);
            }

            else if (cmbReportType.Text == "Date wise Report")
            {
                ReportDocument crypt = new ReportDocument();
                crypt.Load("D:/BCS_9436/Agri_Manegment_System/Agri_Manegment_System/reports/Scheme1.rpt");
                crypt.RecordSelectionFormula = "{PersonalDt.dt} >= #" + dtpstartdate.Value + "# and {PersonalDt.dt} <= #" + dtpenddate.Value + "#";
                crypt.DataDefinition.FormulaFields["tdate"].Text = "'" + dtpstartdate.Text + "To" + dtpenddate.Text + "'";
                panel1.Visible = false;
                CrystalReportViewer view1 = new CrystalReportViewer();
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;
                txtappno.Visible = false;
                lblappno.Visible = false;
                view1.Dock = DockStyle.Fill;
                view1.ReportSource = crypt;
                this.Controls.Add(view1);
            }


        }
    }
}

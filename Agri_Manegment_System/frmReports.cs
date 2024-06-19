
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
    public partial class frmReports : Form
    {
        //string Flag = "";

        private static string myconn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:/BCS_9436/Agri_mng.mdb";
        static OleDbConnection conn = new OleDbConnection(myconn);
        OleDbCommand cmd = new OleDbCommand();
        DataTable dr = new DataTable();

        public frmReports()
        {
            InitializeComponent();
           
            SetConnection();

            ctrlOnFocusPannel2();
            ctrlOnLostFocusPannel2();

          
        }
        public void SetConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
                // MessageBox.Show("Connection Open");
            }
        }
        // just for on focusing the seperate panel
        private void onFocus(object sender, EventArgs e)
        {
            var ctrl = sender as Control;
            ctrl.Tag = ctrl.BackColor;
            ctrl.BackColor = Color.Cyan;
        }

        private void onLostFocus(object sender, EventArgs e)
        {
            var ctrl = sender as Control;
            ctrl.Tag = ctrl.BackColor;
            ctrl.BackColor = Color.White;
        }

        //just for got focusing every panel 
        private void ctrlOnFocusPannel2()
        {
            foreach (Control i in panel2.Controls)
            {
                if (i is TextBox || i is ComboBox || i is DateTimePicker)
                {
                    i.GotFocus += onFocus;
                }
            }
        }
        //just for on lost focusing the panel
        private void ctrlOnLostFocusPannel2()
        {
            foreach (Control i in panel2.Controls)
            {
                if (i is TextBox || i is ComboBox || i is DateTimePicker)
                {
                    i.LostFocus += onLostFocus;
                }
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (cmbReportType.Text == "Farmer wise Report")
            {
                ReportDocument crypt = new ReportDocument();
                crypt.Load("D:/BCS_9436/Agri_Manegment_System/Agri_Manegment_System/reports/Food.rpt");
                crypt.RecordSelectionFormula = "{foodfood.appno} = " + Convert.ToInt32(txtappno.Text) + "";
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
                crypt.Load("D:/BCS_9436/Agri_Manegment_System/Agri_Manegment_System/reports/Food.rpt");
                crypt.RecordSelectionFormula = "{foodfood.dt} >= #" + dtpstartdate.Value + "# and {foodfood.dt} <= #" + dtpenddate.Value + "#";
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

        private void cmbReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbReportType_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtappno_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtappno.Text))
            {
                btnShow.Enabled = true;
            }
        }

        private void dtpDate_KeyDown(object sender, KeyEventArgs e)
        {
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

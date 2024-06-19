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
using System.IO;

namespace Agri_Manegment_System
{
    public partial class FrmPersonalDetails : Form
    {
        public Guid PrimaryKey
        {
            get;
            set;
        }
        public FrmPersonalDetails()
        {
            InitializeComponent();
            SetConnection();
            ctrlGotFocus();
            ctrlLostFocus();
            FormClear();
        }

        string Flag = "";
        private static string myconn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:/BCS_9436/Agri_mng.mdb";
        static OleDbConnection conn = new OleDbConnection(myconn);
        OleDbCommand cmd = new OleDbCommand();
        DataTable dt = new DataTable();

        public void SetConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
             //   MessageBox.Show("Connection Open");
            }
        }
        private void OnFocus(Object Sender, EventArgs e)
        {
            var ctrl = Sender as Control;
            ctrl.Tag = ctrl.BackColor;
            ctrl.BackColor = Color.Blue;
        }
        private void OnLostFocus(Object Sender, EventArgs e)
        {
            var ctrl = Sender as Control;
            ctrl.Tag = ctrl.BackColor;
            ctrl.BackColor = Color.White;
        }
        private void ctrlGotFocus()
        {
            foreach (Control c in panel2.Controls)
            {
                if (c is TextBox || c is ComboBox)
                {
                    c.GotFocus += OnFocus;
                }
            }
        }
        private void ctrlLostFocus()
        {
            foreach (Control c in panel2.Controls)
            {
                if (c is TextBox || c is ComboBox)
                {
                    c.GotFocus += OnLostFocus;
                }
            }
        }
        private void FormClear()
        {
            foreach (Control c in panel2.Controls)
            {
                if (c is TextBox || c is ComboBox)
                {
                    c.Text = "";
                }
            }
        }

        private void txtApplicantName_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                txtMobileno.Focus();
            }
        }

        private void txtMobileno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAlternateno.Focus();
            }

        }

        private void txtAlternateno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbGender.Focus();
            }

        }

        private void cmbGender_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cmbGender.SelectedIndex < 0)
                {
                    MessageBox.Show("Select the correct option");
                }
                else
                {
                    txtEmailID.Focus();
                }

            }
        }

        private void txtEmailID_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                dtpDOB.Focus();
            }

        }

        private void dtpDOB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbPH.Focus();
            }

        }

        private void cmbPH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cmbPH.SelectedIndex < 0)
                {
                    MessageBox.Show("Select the correct option");
                    e.Handled = true;
                }
                else
                {
                    if (cmbPH.SelectedIndex == 1)
                    {
                        cmbphtype.Visible = false;
                        lblphtype.Visible = false;
                        cmbphtype.Text = " - ";
                        txtFirstName.Focus();
                    }
                    else
                    {
                        cmbphtype.Visible = true;
                        lblphtype.Visible = true;
                        cmbphtype.Focus();
                    }
                }
            }

        }

        private void cmbphtype_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cmbphtype.SelectedIndex < 0)
                {
                    MessageBox.Show("Select the correct option");
                }
                else
                {
                    txtFirstName.Focus();
                }
            }

        }

        private void txtFirstName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMiddlename.Focus();
            }

        }

        private void txtMiddlename_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtLastname.Focus();
            }

        }

        private void txtLastname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbCS.Focus();
            }

        }

        private void cmbCS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cmbCS.SelectedIndex < 0)
                {
                    MessageBox.Show("Select the correct option");
                }
                else
                {
                    cmbcheck.Focus();
                }
            }

        }

        private void cmbcheck_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cmbcheck.SelectedIndex < 0)
                {
                    MessageBox.Show("Select the correct option");
                }
                else
                {
                    btnSave.Focus();
                }
            }

        }
        
        private void txtApplicantName_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtApplicantName.Text, "[^A-Z,a-z, ]"))
            {
                MessageBox.Show("only characters can allowed");
                txtApplicantName.Text = txtApplicantName.Text.Remove(txtApplicantName.Text.Length - 1);

            }
        }

        private void txtMobileno_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtMobileno.Text, "[^0-9]"))
            {
                MessageBox.Show("only number can allowed");
                txtMobileno.Text = txtMobileno.Text.Remove(txtMobileno.Text.Length - 1);
            }

        }

        private void txtAlternateno_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtAlternateno.Text, "[^0-9]"))
            {
                MessageBox.Show("only number can allowed");
                txtAlternateno.Text = txtAlternateno.Text.Remove(txtAlternateno.Text.Length - 1);
            }

        }

        private void txtEmailID_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtEmailID.Text, "[^0-9,^A-Z,^a-z @ , . ,-]"))
            {
                MessageBox.Show("Error");
                txtEmailID.Text = txtEmailID.Text.Remove(txtEmailID.Text.Length - 1);
            }

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtFirstName.Text, "[^A-z,a-z]"))
            {
                MessageBox.Show("only characters can allowed");
                txtFirstName.Text = txtFirstName.Text.Remove(txtFirstName.Text.Length - 1);
            }

        }

        private void txtMiddlename_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtMiddlename.Text, "[^A-Z,a-z]"))
            {
                MessageBox.Show("only characters can allowed");
                txtMiddlename.Text = txtMiddlename.Text.Remove(txtMiddlename.Text.Length - 1);
            }
        }

        private void txtLastname_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtLastname.Text, "[^A-Z,a-z]"))
            {
                MessageBox.Show("only characters can allowed");
                txtLastname.Text = txtLastname.Text.Remove(txtLastname.Text.Length - 1);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SetConnection();
           // if (Flag == "A")
            //{
                DialogResult result = MessageBox.Show("After click yes button you can't delete or modify your records?", "Save Successfully", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    cmd = new OleDbCommand("INSERT INTO PersonalDt (appno,appnm, phone, altno, gender, email, dob, ph, phtype, fnm, mnm, lnm, sucide, cast1,dt) values (" + txtApplicationNo.Text + ",'" + txtApplicantName.Text + "','" + txtMobileno.Text + "', '" + txtAlternateno.Text + "','" + cmbGender.Text + "','" + txtEmailID.Text + "',#" + dtpDOB.Value + "#, '" + cmbPH.Text + "', '" + cmbphtype.Text + "', '" + txtFirstName.Text + "', '" + txtMiddlename.Text + "', '" + txtLastname.Text + "', '" + cmbCS.Text + "', '" + cmbcheck.Text + "',#"+DateTime.Now +"#)", conn);
                    cmd.ExecuteNonQuery();

                    conn.Close();
                   // FormClear();
                    Flag = "";
            }
            //}
           
           
            btnNext.Focus();
        }

      

       


        private void btnPrevious_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand();
            FrmApplicationDetails ap = new FrmApplicationDetails();
            ap.Show();
            this.Hide();
           
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            FrmAgricultureLand_CropDetails a = new FrmAgricultureLand_CropDetails();
            a.Show();
            this.Hide();
        }

        private void FrmPersonalDetails_Load(object sender, EventArgs e)
        {
            FormClear();
            MessageBox.Show("Fill Data Properly after saving your records you can't modify or delete it");
            Flag = "A";
            SetConnection();
            cmd = new OleDbCommand("Select max(appno)from PersonalDt ", conn);
            if (System.DBNull.Value == cmd.ExecuteScalar())
            {
                txtApplicationNo.Text = Convert.ToString(1);
            }
            else
            {
                int i = Convert.ToInt32(cmd.ExecuteScalar());
                txtApplicationNo.Text = Convert.ToString(i + 1);
            }
            conn.Close();
            txtApplicationNo.Focus();
        }

        private void txtApplicationNo_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.KeyCode == Keys.Enter)
                {
               
                    if ( Flag == "A" )
                    {
                        txtApplicantName.Focus();
                    }


                }
        }

        private void txtApplicationNo_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtApplicationNo.Text, "[^0-9]"))
            {
                MessageBox.Show("only numbers can allowed");
                txtApplicationNo.Text = txtApplicationNo.Text.Remove(txtApplicationNo.Text.Length - 1);
            }
        }

    }
}





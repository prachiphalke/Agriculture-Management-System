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
    public partial class FrmApplicationDetails : Form
    {
        private Guid primaryKey;
        

        private void GeneratePrimaryKey()
        {            primaryKey = Guid.NewGuid();
        }

        public string PrimaryKey
        {
            get { return txtApplicationNo.Text; }
        }

        private void FrmPersonalDetails()
        {
            FrmPersonalDetails p1 = new FrmPersonalDetails();
            p1.PrimaryKey = primaryKey;
            p1.Show();
        }
        private void FrmAgricultureLand_CropDetails()
        {
            FrmAgricultureLand_CropDetails l1 = new FrmAgricultureLand_CropDetails();
            l1.PrimaryKey = primaryKey;
            l1.Show();
        }

        


        public FrmApplicationDetails()
        {
            InitializeComponent();
            SetConnection();
            ctrlGotFocus();
            ctrlLostFocus();
            FormClear();
        }

        string Flag = "";
        private static String myConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:/BCS_9436/Agri_mng.mdb";
        static OleDbConnection conn = new OleDbConnection(myConn);
        OleDbCommand cmd = new OleDbCommand();
       

        public void SetConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
               // MessageBox.Show("Connection Open");
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

        private void txtApplicationNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(Flag == "A" )
                {
                    txtApplicantName.Focus();
                }
            }
        }


        private void txtApplicantName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtApplicantName.TextLength == 0)
                {
                    MessageBox.Show("Error");
                }
                else
                {
                    txtDistrict.Focus();
                }
            }
        }

        private void txtDistrict_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtDistrict.TextLength == 0)
                {
                    MessageBox.Show("Error");
                }
                else
                {
                    txtTaluka.Focus();
                }
            }
        }

        private void txtTaluka_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtTaluka.TextLength == 0)
                {
                    MessageBox.Show("Error");
                }
                else
                {
                    txtVillage.Focus();
                }
            }
        }

        private void txtVillage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtVillage.TextLength == 0)
                {
                    MessageBox.Show("Error");
                }
                else
                {
                    cmbComponentName.Focus();
                }
            }
        }

        private void cmbComponentName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cmbComponentName.SelectedIndex < 0)
                {
                    MessageBox.Show("Select the correct option");
                }
                else
                {
                    btnSave.Focus();
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

        private void txtApplicantName_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtApplicantName.Text, "[^A-Z,a-z, ,]"))
            {
                MessageBox.Show("only characters can allowed");
                txtApplicantName.Text = txtApplicantName.Text.Remove(txtApplicantName.Text.Length - 1);
            }
        }

        private void txtDistrict_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtDistrict.Text, "[^A-Z,a-z, ,]"))
            {
                MessageBox.Show("only characters can allowed");
                txtDistrict.Text = txtDistrict.Text.Remove(txtDistrict.Text.Length - 1);
            }
        }

        private void txtTaluka_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtTaluka.Text, "[^A-Z,a-z, ,]"))
            {
                MessageBox.Show("only characters can allowed");
                txtTaluka.Text = txtTaluka.Text.Remove(txtTaluka.Text.Length - 1);
            }
        }

        private void txtVillage_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtVillage.Text, "[^A-Z,a-z, ,]"))
            {
                MessageBox.Show("only characters can allowed");
                txtVillage.Text = txtVillage.Text.Remove(txtVillage.Text.Length - 1);
            }
        }

       

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormClear();
            MessageBox.Show("Fill Data Properly after saving your records you can't modify or delete it");
            Flag = "A";
            SetConnection();
            cmd = new OleDbCommand("Select max(appno)from AppDetails ", conn);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("After click yes button you can't delete or modify your records?", "Save Successfully", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SetConnection();
                cmd = new OleDbCommand("Insert into AppDetails(appno,appnm,dist,tal,village,cmpnm) values (" + txtApplicationNo.Text + ",'" + txtApplicantName.Text + "', '" + txtDistrict.Text + "','" + txtTaluka.Text + "','" + txtVillage.Text + "','" + cmbComponentName.Text + "')", conn);
                cmd.ExecuteNonQuery();


                conn.Close();
              //  FormClear();
                Flag = "";
            }
            btnNext.Focus();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            
            FrmPersonalDetails P = new FrmPersonalDetails();
            
            P.Show();
            this.Hide();
        }

       
    }
}

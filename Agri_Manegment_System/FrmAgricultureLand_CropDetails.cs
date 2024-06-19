
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
    public partial class FrmAgricultureLand_CropDetails : Form
    {
        public Guid PrimaryKey
        {
            get;
            set;
        }
        public FrmAgricultureLand_CropDetails()
        {
            SetConnection();
            InitializeComponent();
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
                //MessageBox.Show("Connection Open");
            }
        }

        public void FormClear()
        {
            foreach (Control c in panel3.Controls)
            {
                if (c is TextBox || c is ComboBox)
                {
                    c.Text = "";
                }
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
            foreach (Control c in panel3.Controls)
            {
                if (c is TextBox || c is ComboBox)
                {
                    c.GotFocus += OnFocus;
                }
            }
        }
        private void ctrlLostFocus()
        {
            foreach (Control c in panel3.Controls)
            {
                if (c is TextBox || c is ComboBox)
                {
                    c.GotFocus += OnLostFocus;
                }
            }
        }

        

        private void btnNext_Click(object sender, EventArgs e)
        {
            FrmApproval a = new FrmApproval();
            a.Show();
            this.Hide();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            cmd = new OleDbCommand();
            FrmPersonalDetails p = new FrmPersonalDetails();
            p.Show();
            this.Hide();
        }

       

        private void FrmAgricultureLand_CropDetails_Load(object sender, EventArgs e)
        {
            FormClear();
            
            Flag = "A";
            SetConnection();
            cmd = new OleDbCommand("Select max(appno) from LandDt ", conn);
            if(System.DBNull.Value == cmd.ExecuteScalar())
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
                    txt8ANo.Focus();
                }
            }
        }

        private void txt8ANo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt8ANo.TextLength == 0)
                {
                    MessageBox.Show("Error");
                }
                else
                {
                    txt8AAreaHa.Focus();
                }
            }
        }

        private void txt8AAreaHa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt8AAreaHa.TextLength == 0)
                {
                    MessageBox.Show("Error");
                }
                else
                {
                    txtSurveyNo.Focus();
                }
            }
        }

        private void txtSurveyNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtSurveyNo.TextLength == 0)
                {
                    MessageBox.Show("Error");
                }
                else
                {
                    txtSurveyNoAreaHa.Focus();
                }
            }
        }

        private void txtSurveyNoAreaHa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtSurveyNoAreaHa.TextLength == 0)
                {
                    MessageBox.Show("Error");
                }
                else
                {
                    btnSave.Focus();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SetConnection();
                DialogResult result = MessageBox.Show("After click yes button you can't delete or modify your records?", "Save Successfully", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    cmd = new OleDbCommand("Insert into LandDt (appno,village,taluka,dist,8ano,area,surveyno,hano) values (" + txtApplicationNo.Text + ",'" + txtVillage.Text + "','" + txtTaluka.Text + "','" + txtDistrict.Text + "'," + txt8ANo.Text + "," + txt8AAreaHa.Text + "," + txtSurveyNo.Text + "," + txtSurveyNoAreaHa.Text + ")", conn);
                    cmd.ExecuteNonQuery();

                    conn.Close();
                   // FormClear();
                    Flag = "";
                }                                 
            btnNext.Focus();
            
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
                    txtTaluka.Focus();
                }
            }
        }


        

        private void txt8ANo_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt8ANo.Text, "[^0-9,.]"))
            {
                MessageBox.Show("only number can allowed");
                txt8ANo.Text = txt8ANo.Text.Remove(txt8ANo.Text.Length - 1);
            }
        }

        private void txt8AAreaHa_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt8AAreaHa.Text, "[^0-9,.]"))
            {
                MessageBox.Show("only number can allowed");
                txt8AAreaHa.Text = txt8AAreaHa.Text.Remove(txt8AAreaHa.Text.Length - 1);
            }

        }

        private void txtSurveyNo_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtSurveyNo.Text, "[^0-9,.]"))
            {
                MessageBox.Show("only number can allowed");
                txtSurveyNo.Text = txtSurveyNo.Text.Remove(txtSurveyNo.Text.Length - 1);
            }
        }

        private void txtSurveyNoAreaHa_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtSurveyNoAreaHa.Text, "[^0-9,.]"))
            {
                MessageBox.Show("only number can allowed");
                txtSurveyNoAreaHa.Text = txtSurveyNoAreaHa.Text.Remove(txtSurveyNoAreaHa.Text.Length - 1);
            }

        }

        private void txtApplicationNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               
                if (Flag == "A" )
                {
                    txtVillage.Focus();
                }
            }

        }

        private void txtApplicationNo_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtApplicationNo.Text, "[^0-9]"))
            {
                MessageBox.Show("only number can allowed");
                txtApplicationNo.Text = txtApplicationNo.Text.Remove(txtApplicationNo.Text.Length - 1);
            }
        }

      
    }
}

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
    public partial class FrmNFSM : Form
    {
        string Flag = "";
        private static string myconn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:/BCS_9436/Agri_mng.mdb";
        static OleDbConnection conn = new OleDbConnection(myconn);
        OleDbCommand cmd = new OleDbCommand();
        DataTable dt = new DataTable();

        public FrmNFSM()
        {
            InitializeComponent();
            SetConnection();
            ctrlGotFocus();
            ctrlLostFocus();
            FormClear();
            dtpDate.Value = DateTime.Now;
        }

        private void FrmNFSM_Load(object sender, EventArgs e)
        {

        }
       
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

        private void txtApplicationName_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (Flag == "M" || Flag == "D")
                {
                    SetConnection();

                    cmd = new OleDbCommand("Select * from foodfood where appno=" + txtApplicationName.Text + "", conn);
                    OleDbDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        cmbScheme.Text = dr["sch"].ToString();
                        dtpDate.Text = dr["dt"].ToString();
                        txtApplicantName.Text = dr["appnm"].ToString();
                        txtVillage.Text = dr["village"].ToString();
                        txtAdharIDNo.Text = dr["adhar"].ToString();
                        cmbGender.Text = dr["gender"].ToString();
                        txtAge.Text = dr["age"].ToString();
                        txtMobileNo.Text = dr["phone"].ToString();
                        txtCategory.Text = dr["cast"].ToString();
                        txt8ALandHolding.Text = dr["Eighta"].ToString();
                        txtDemoAreaHa.Text = dr["area"].ToString();
                        txtDemoSurveyNo.Text = dr["surveyno"].ToString();
                        txtDemoCrop.Text = dr["dcrop"].ToString();
                        txtCropVariety.Text = dr["vcrop"].ToString();
                        txtGramSeeds.Text = dr["gseed"].ToString();
                    }
                }
                if (Flag == "D")
                {
                    DialogResult result = MessageBox.Show("Are you sure ?", "Confirm Deletion", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        cmd = new OleDbCommand("Delete from foodfood where appno=" + txtApplicationName.Text + "", conn);
                        cmd.ExecuteNonQuery();
                        Flag = "";
                        FormClear();
                        btnNew.Focus();
                    }
                }
                if(Flag == "A" || Flag == "M")
                {
                    cmbScheme.Focus();
                }
            }
        }



        private void txtApplicantName_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void cmbScheme_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cmbScheme.SelectedIndex < 0)
                {
                    MessageBox.Show("Select the correct option");
                }
                else
                {
                    dtpDate.Focus();
                }
            }
        }

        private void dtpDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtApplicantName.Focus();
            }
        }

        private void txtApplicantName_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtApplicantName.TextLength == 0)
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
                    txtAdharIDNo.Focus();
                }
            }
        }

        private void txtAdharIDNo_KeyDown(object sender, KeyEventArgs e)
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
                    txtAge.Focus();
                }
            }
        }

        private void txtAge_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMobileNo.Focus();
            }
        }

        private void txtMobileNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCategory.Focus();
            }
        }

        private void txtCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt8ALandHolding.Focus();
            }
        }

        private void txt8ALandHolding_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDemoSurveyNo.Focus();
            }
        }

        private void txtDemoSurveyNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDemoAreaHa.Focus();
            }
        }

        private void txtDemoAreaHa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDemoCrop.Focus();
            }
        }

        private void txtDemoCrop_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCropVariety.Focus();
            }
        }

        private void txtCropVariety_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtGramSeeds.Focus();
            }
        }

        private void txtGramSeeds_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.Focus();
            }
        }

        private void txtApplicationName_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtApplicationName.Text, "[^0-9]"))
            {
                MessageBox.Show("only numbers can allowed");
                txtApplicationName.Text = txtApplicationName.Text.Remove(txtApplicationName.Text.Length -1);
            }
        }

        private void txtApplicantName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtVillage_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtVillage.Text, "[^A-Z,a-z, ,]"))
            {
                MessageBox.Show("only characters can allowed");
                txtVillage.Text = txtVillage.Text.Remove(txtVillage.Text.Length - 1);
            }
        }

        private void txtAdharIDNo_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtAdharIDNo.Text, "[^0-9]"))
            {
                MessageBox.Show("only numbers can allowed");
                txtAdharIDNo.Text = txtAdharIDNo.Text.Remove(txtAdharIDNo.Text.Length - 1);
            }
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtAge.Text, "[^0-9]"))
            {
                MessageBox.Show("only numbers can allowed");
                txtAge.Text = txtAge.Text.Remove(txtAge.Text.Length - 1);
            }
        }

        private void txtMobileNo_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtMobileNo.Text, "[^0-9]"))
            {
                MessageBox.Show("only numbers can allowed");
                txtMobileNo.Text = txtMobileNo.Text.Remove(txtMobileNo.Text.Length - 1);
            }
        }

        private void txtCategory_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtCategory.Text, "[^A-Z,a-z, ,]"))
            {
                MessageBox.Show("only characters can allowed");
                txtCategory.Text = txtCategory.Text.Remove(txtCategory.Text.Length - 1);
            }
        }

        private void txt8ALandHolding_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt8ALandHolding.Text, "[^0-9,.]"))
            {
                MessageBox.Show("only numbers can allowed");
                txt8ALandHolding.Text = txt8ALandHolding.Text.Remove(txt8ALandHolding.Text.Length - 1);
            }
        }

        private void txtDemoSurveyNo_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtDemoSurveyNo.Text, "[^0-9,.]"))
            {
                MessageBox.Show("only numbers can allowed");
                txtDemoSurveyNo.Text = txtDemoSurveyNo.Text.Remove(txtDemoSurveyNo.Text.Length - 1);
            }
        }

        private void txtDemoAreaHa_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtDemoAreaHa.Text, "[^0-9,.]"))
            {
                MessageBox.Show("only numbers can allowed");
                txtDemoAreaHa.Text = txtDemoAreaHa.Text.Remove(txtDemoAreaHa.Text.Length - 1);
            }
        }

        private void txtDemoCrop_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtDemoCrop.Text, "[^A-Z,a-z, ,]"))
            {
                MessageBox.Show("only characters can allowed");
                txtDemoCrop.Text = txtDemoCrop.Text.Remove(txtDemoCrop.Text.Length - 1);
            }
        }

        private void txtCropVariety_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtCropVariety.Text, "[^A-Z,a-z, ,]"))
            {
                MessageBox.Show("only characters can allowed");
                txtCropVariety.Text = txtCropVariety.Text.Remove(txtCropVariety.Text.Length - 1);
            }
        }

        private void txtGramSeeds_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtGramSeeds.Text, "[^0-9,.]"))
            {
                MessageBox.Show("only numbers can allowed");
                txtGramSeeds.Text = txtGramSeeds.Text.Remove(txtGramSeeds.Text.Length - 1);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FormClear();
            Flag = "A";
            SetConnection();
            cmd = new OleDbCommand("Select max(appno) from foodfood ", conn);
            if (System.DBNull.Value == cmd.ExecuteScalar())
            {
                txtApplicationName.Text = Convert.ToString(1);
            }
            else
            {
                int i = Convert.ToInt32(cmd.ExecuteScalar());
                txtApplicationName.Text = Convert.ToString(i + 1);
            }
            conn.Close();
            txtApplicationName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            SetConnection();

            if (Flag == "A")
            {
                //(appno,sch,dt,appnm,village,adhar,gender,age,phone,cast,Eighta,area,surveyno,dcrop,vcrop,gseed)
                cmd = new OleDbCommand("Insert into foodfood values (" + txtApplicationName.Text + ",'" + cmbScheme.Text + "',#" + dtpDate.Value + "#, '" + txtApplicantName.Text + "','" + txtVillage.Text + "','" + txtAdharIDNo.Text+ "','" + cmbGender.Text + "'," + txtAge.Text + ",'" + txtMobileNo.Text + "','" + txtCategory.Text + "'," + txt8ALandHolding.Text + "," + txtDemoAreaHa.Text + "," + txtDemoSurveyNo.Text + ",'" + txtDemoCrop.Text + "','" + txtCropVariety.Text + "'," + txtGramSeeds.Text + ")", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Save Successfully");
            }
            if (Flag == "M")
            {
                OleDbCommand cmd = new OleDbCommand();
                //cmd = new OleDbCommand("Update foodfood set sch = '" + cmbScheme.Text + "' , dt = #" + dtpDate.Value.ToString("yyyy-MM-dd") + "#, appnm = '" + txtApplicantName.Text + "', village = '" + txtVillage.Text + "', adhar = '" + txtAdharIDNo.Text + "', gender = '" + cmbGender.Text + "', age = " + txtAge.Text + ", phone = '" + txtMobileNo.Text + "', cast = '" + txtCategory.Text + "',  Eighta = " + txt8ALandHolding.Text + ", area = " + txtDemoAreaHa.Text + ", surveyno = " + txtDemoSurveyNo.Text + ", dcrop = '" + txtDemoCrop.Text + "', vcrop = '" + txtCropVariety.Text + "', gseed = " + txtGramSeeds.Text + " where appno = " + txtApplicationName.Text + "", conn);

                cmd = new OleDbCommand("UPDATE foodfood SET sch=?, dt=?, appnm=?, village=?, adhar=?, gender=?, age=?, phone=?, [cast]=?, Eighta=?, [area]=?, surveyno=?, dcrop=?, vcrop=?, gseed=? WHERE appno=?", conn);
                cmd.Parameters.AddWithValue("@sch", cmbScheme.Text);
                cmd.Parameters.AddWithValue("@dt", dtpDate.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@appnm", txtApplicantName.Text);
                cmd.Parameters.AddWithValue("@village", txtVillage.Text);
                cmd.Parameters.AddWithValue("@adhar", txtAdharIDNo.Text);
                cmd.Parameters.AddWithValue("@gender", cmbGender.Text);
                cmd.Parameters.AddWithValue("@age", Convert.ToInt32(txtAge.Text));
                cmd.Parameters.AddWithValue("@phone", txtMobileNo.Text);
                cmd.Parameters.AddWithValue("@cast", txtCategory.Text);
                cmd.Parameters.AddWithValue("@Eighta", Convert.ToDouble(txt8ALandHolding.Text));
                cmd.Parameters.AddWithValue("@area", Convert.ToDouble(txtDemoAreaHa.Text));
                cmd.Parameters.AddWithValue("@surveyno", txtDemoSurveyNo.Text);
                cmd.Parameters.AddWithValue("@dcrop", txtDemoCrop.Text);
                cmd.Parameters.AddWithValue("@vcrop", txtCropVariety.Text);
                cmd.Parameters.AddWithValue("@gseed", Convert.ToInt32(txtGramSeeds.Text));
                cmd.Parameters.AddWithValue("@appno", Convert.ToInt32(txtApplicationName.Text));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Modify Successfully");
            }
            conn.Close();
            FormClear();
            Flag = "";
            btnNew.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            FormClear();
            Flag = "D";
            txtApplicationName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            Flag = "";
            FormClear();
            btnNew.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormClear();
            Flag = "M";
            txtApplicationName.Focus();
        }

        private void txtApplicantName_KeyDown_2(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtApplicantName.TextLength == 0)
                {
                    MessageBox.Show("Error");
                }
                else
                {
                    txtVillage.Focus();
                }
            }
        }

        private void txtApplicantName_TextChanged_1(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtApplicantName.Text, "[^A-Z,a-z, ]"))
            {
                MessageBox.Show("only characters can allowed");
                txtApplicantName.Text = txtApplicantName.Text.Remove(txtApplicantName.Text.Length - 1);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}



using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace Agri_Manegment_System
{
    public partial class FrmApproval : Form
    {

        public Guid PrimaryKey
        {
            get;
            set;
        }
        public FrmApproval()
        {
            InitializeComponent();
            SetConnection();
            ctrlGotFocus();
            ctrlLostFocus();
            FormClear();

            Approval1.Visible = false;
            agrisupervisor.Visible = false;
            Bank.Visible = false;
            TalukaAgriOfficer.Visible = false;

            txtAmmount.Visible = false;


           
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
               // MessageBox.Show("Connection Open");
            }
        }

        private void OnFocus(Object Sender, EventArgs e)
        {
            var ctrl = Sender as Control;
            ctrl.Tag = ctrl.BackColor;
            ctrl.BackColor = Color.Cyan;
        }
        private void OnLostFocus(Object Sender, EventArgs e)
        {
            var ctrl = Sender as Control;
            ctrl.Tag = ctrl.BackColor;
            ctrl.BackColor = Color.White;
        }
        private void ctrlGotFocus()
        {
            foreach (Control c in panel4.Controls )
            {
                if (c is TextBox || c is ComboBox)
                {
                    c.GotFocus += OnFocus;
                }
            }
        }
        private void ctrlLostFocus()
        {
            foreach (Control c in panel4.Controls)
            {
                if (c is TextBox || c is ComboBox)
                {
                    c.GotFocus += OnLostFocus;
                }
            }
        }
        private void FormClear()
        {
            foreach (Control c in panel4.Controls)
            {
                if (c is TextBox || c is ComboBox)
                {
                    c.Text = "";
                }
            }
        }
        private void FrmApproval_Load(object sender, EventArgs e)
        {
            
            FormClear();
            
            Flag = "A";
            SetConnection();
            cmd = new OleDbCommand("Select max(appno)from Approval ", conn);
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

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            FrmAgricultureLand_CropDetails ap = new FrmAgricultureLand_CropDetails();
            ap.Show();
            this.Hide();
        }



        private void cmbComponentName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(cmbComponentName.SelectedIndex < 0)
                {
                    MessageBox.Show("Error");
                }
                else
                {
                    txtWGST.Focus();
                }
            }
        }

        private void txtApplicationNo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                if(Flag =="A")
                {
                    cmbComponentName.Focus();
                   
                }
            }
        }

        private void txtWGST_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtWGST.Text == "")
                {
                    MessageBox.Show("Error");
                }
                else
                {
                    double amount = double.Parse(txtWGST.Text);
                    double gst = amount * 0.18; // assuming GST rate is 18%
                    txtwhGST.Text = gst.ToString("F2");
                    txtwhGST.Text = (amount + gst).ToString("F2");
                    txtwhGST.Focus();
                }
            }
        }

        private void txtwhGST_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtwhGST.Text=="")
                {
                    MessageBox.Show("Error");
                }
                else
                {
                    AgriAssiAproval.Focus();
                    Approval1.Visible = true;
                }
            }
        }

        private void AgriAssiAproval_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(AgriAssiAproval.Checked)
                {
                    Approval1.Focus();
                    agrisupervisor.Visible = true;
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void Approval1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Approval1.Checked)
                {
                    agrisupervisor.Focus();
                    Bank.Visible = true;
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }

        }

        private void agrisupervisor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (agrisupervisor.Checked)
                {
                    Bank.Focus();
                    TalukaAgriOfficer.Visible = true;
                   
                    
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void Bank_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Bank.Checked)
                {
                    TalukaAgriOfficer.Visible = true;
                    TalukaAgriOfficer.Select();
                    TalukaAgriOfficer.Focus();


                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void TalukaAgriOfficer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (TalukaAgriOfficer.Checked)
                {
                    txtAmmount.Visible = true;
                    TalukaAgriOfficer.Select();
                    txtAmmount.Text = txtwhGST.Text;
                    txtAmmount.Focus();


                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }


        private void txtAmmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtAmmount.Text == "" )
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
            DialogResult result = MessageBox.Show("After click yes button you can't delete or modify your records?", " conferm Save ", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                /*string assist = AgriAssiAproval.Checked ? "Yes" : "No";
                string ap1 = Approval1.Checked ? "Yes" : "No";
                string sup = agrisupervisor.Checked ? "Yes" : "No";
                string bank = Bank.Checked ? "Yes" : "No";
                string ap2 = TalukaAgriOfficer.Checked ? "Yes" : "No";*/
                cmd = new OleDbCommand("Insert into Approval (appno,cmpnm,gst,wgst,amt) values (" + txtApplicationNo.Text + ",'" + cmbComponentName.Text + "','" + txtWGST.Text + "','" + txtwhGST.Text + "','" + txtAmmount.Text + "')", conn);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Save Successfully");

                conn.Close();
               //FormClear();
                Flag = "";
            }
            btnExit.Focus();
        }

        private void txtApplicationNo_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtApplicationNo.Text, "[^0-9,.]"))
            {
                MessageBox.Show("only number can allowed");
                txtApplicationNo.Text = txtApplicationNo.Text.Remove(txtApplicationNo.Text.Length - 1);
            }
        }

        private void txtWGST_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtWGST.Text, "[^0-9,.]"))
            {
                MessageBox.Show("only number can allowed");
                txtWGST.Text = txtWGST.Text.Remove(txtWGST.Text.Length - 1);
            }
        }

        private void txtwhGST_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtwhGST.Text, "[^0-9,.]"))
            {
                MessageBox.Show("only number can allowed");
                    txtwhGST.Text = txtwhGST.Text.Remove(txtwhGST.Text.Length - 1);
            }
        }

        private void txtAmmount_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtAmmount.Text, "[^0-9,.]"))
            {
                MessageBox.Show("only number can allowed");
                txtAmmount.Text = txtAmmount.Text.Remove(txtAmmount.Text.Length - 1);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblAmmount_Click(object sender, EventArgs e)
        {

        }
    }
}

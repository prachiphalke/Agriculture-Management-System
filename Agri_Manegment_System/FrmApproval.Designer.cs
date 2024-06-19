
namespace Agri_Manegment_System
{
    partial class FrmApproval
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblArroval = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblAmmount = new System.Windows.Forms.Label();
            this.lblApplicationNo = new System.Windows.Forms.Label();
            this.txtApplicationNo = new System.Windows.Forms.TextBox();
            this.Approval1 = new System.Windows.Forms.CheckBox();
            this.AgriAssiAproval = new System.Windows.Forms.CheckBox();
            this.txtwhGST = new System.Windows.Forms.TextBox();
            this.txtWGST = new System.Windows.Forms.TextBox();
            this.cmbComponentName = new System.Windows.Forms.ComboBox();
            this.lblComponentName = new System.Windows.Forms.Label();
            this.WithGST = new System.Windows.Forms.Label();
            this.lblWithGST = new System.Windows.Forms.Label();
            this.lblammont = new System.Windows.Forms.Label();
            this.txtAmmount = new System.Windows.Forms.TextBox();
            this.TalukaAgriOfficer = new System.Windows.Forms.CheckBox();
            this.Bank = new System.Windows.Forms.CheckBox();
            this.agrisupervisor = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.lblArroval);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1203, 96);
            this.panel1.TabIndex = 0;
            this.panel1.TabStop = true;
            // 
            // lblArroval
            // 
            this.lblArroval.AutoSize = true;
            this.lblArroval.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArroval.Location = new System.Drawing.Point(419, 25);
            this.lblArroval.Name = "lblArroval";
            this.lblArroval.Size = new System.Drawing.Size(301, 38);
            this.lblArroval.TabIndex = 13;
            this.lblArroval.Text = "Approval Process ";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SteelBlue;
            this.panel4.Controls.Add(this.lblAmmount);
            this.panel4.Controls.Add(this.lblApplicationNo);
            this.panel4.Controls.Add(this.txtApplicationNo);
            this.panel4.Controls.Add(this.Approval1);
            this.panel4.Controls.Add(this.AgriAssiAproval);
            this.panel4.Controls.Add(this.txtwhGST);
            this.panel4.Controls.Add(this.txtWGST);
            this.panel4.Controls.Add(this.cmbComponentName);
            this.panel4.Controls.Add(this.lblComponentName);
            this.panel4.Controls.Add(this.WithGST);
            this.panel4.Controls.Add(this.lblWithGST);
            this.panel4.Controls.Add(this.lblammont);
            this.panel4.Controls.Add(this.txtAmmount);
            this.panel4.Controls.Add(this.TalukaAgriOfficer);
            this.panel4.Controls.Add(this.Bank);
            this.panel4.Controls.Add(this.agrisupervisor);
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.Location = new System.Drawing.Point(2, 89);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1203, 454);
            this.panel4.TabIndex = 0;
            // 
            // lblAmmount
            // 
            this.lblAmmount.AutoSize = true;
            this.lblAmmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmmount.ForeColor = System.Drawing.Color.Yellow;
            this.lblAmmount.Location = new System.Drawing.Point(228, 411);
            this.lblAmmount.Name = "lblAmmount";
            this.lblAmmount.Size = new System.Drawing.Size(189, 25);
            this.lblAmmount.TabIndex = 91;
            this.lblAmmount.Text = "Subsidy Ammount =";
            this.lblAmmount.Click += new System.EventHandler(this.lblAmmount_Click);
            // 
            // lblApplicationNo
            // 
            this.lblApplicationNo.AutoSize = true;
            this.lblApplicationNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationNo.Location = new System.Drawing.Point(30, 38);
            this.lblApplicationNo.Name = "lblApplicationNo";
            this.lblApplicationNo.Size = new System.Drawing.Size(182, 29);
            this.lblApplicationNo.TabIndex = 90;
            this.lblApplicationNo.Text = "Application No.:";
            // 
            // txtApplicationNo
            // 
            this.txtApplicationNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApplicationNo.Location = new System.Drawing.Point(233, 45);
            this.txtApplicationNo.Name = "txtApplicationNo";
            this.txtApplicationNo.Size = new System.Drawing.Size(534, 30);
            this.txtApplicationNo.TabIndex = 28;
            this.txtApplicationNo.TextChanged += new System.EventHandler(this.txtApplicationNo_TextChanged);
            this.txtApplicationNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtApplicationNo_KeyDown);
            // 
            // Approval1
            // 
            this.Approval1.AutoSize = true;
            this.Approval1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Approval1.ForeColor = System.Drawing.Color.Lime;
            this.Approval1.Location = new System.Drawing.Point(792, 90);
            this.Approval1.Name = "Approval1";
            this.Approval1.Size = new System.Drawing.Size(281, 54);
            this.Approval1.TabIndex = 27;
            this.Approval1.Text = "Taluka Agriculture officer \r\n   (Pre sinction Approval)";
            this.Approval1.UseVisualStyleBackColor = true;
            this.Approval1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Approval1_KeyDown);
            // 
            // AgriAssiAproval
            // 
            this.AgriAssiAproval.AutoSize = true;
            this.AgriAssiAproval.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgriAssiAproval.ForeColor = System.Drawing.Color.Lime;
            this.AgriAssiAproval.Location = new System.Drawing.Point(792, 40);
            this.AgriAssiAproval.Name = "AgriAssiAproval";
            this.AgriAssiAproval.Size = new System.Drawing.Size(337, 29);
            this.AgriAssiAproval.TabIndex = 26;
            this.AgriAssiAproval.Text = "Agriculture Assistanat Approval";
            this.AgriAssiAproval.UseVisualStyleBackColor = true;
            this.AgriAssiAproval.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AgriAssiAproval_KeyDown);
            // 
            // txtwhGST
            // 
            this.txtwhGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtwhGST.Location = new System.Drawing.Point(401, 249);
            this.txtwhGST.Name = "txtwhGST";
            this.txtwhGST.Size = new System.Drawing.Size(367, 30);
            this.txtwhGST.TabIndex = 24;
            this.txtwhGST.TextChanged += new System.EventHandler(this.txtwhGST_TextChanged);
            this.txtwhGST.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtwhGST_KeyDown);
            // 
            // txtWGST
            // 
            this.txtWGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWGST.Location = new System.Drawing.Point(401, 197);
            this.txtWGST.Name = "txtWGST";
            this.txtWGST.Size = new System.Drawing.Size(367, 30);
            this.txtWGST.TabIndex = 23;
            this.txtWGST.TextChanged += new System.EventHandler(this.txtWGST_TextChanged);
            this.txtWGST.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtWGST_KeyDown);
            // 
            // cmbComponentName
            // 
            this.cmbComponentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbComponentName.FormattingEnabled = true;
            this.cmbComponentName.Items.AddRange(new object[] {
            "Tractor",
            "Power Dealer",
            "Chaff Cutter",
            "Sowing Machine",
            "Rotavator",
            "Threshing Machine",
            "Overturn",
            "Pomegranate harvesting Machine",
            "brush Cutter",
            "Ridger",
            "Power Dealer"});
            this.cmbComponentName.Location = new System.Drawing.Point(271, 120);
            this.cmbComponentName.Name = "cmbComponentName";
            this.cmbComponentName.Size = new System.Drawing.Size(496, 33);
            this.cmbComponentName.TabIndex = 21;
            this.cmbComponentName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbComponentName_KeyDown);
            // 
            // lblComponentName
            // 
            this.lblComponentName.AutoSize = true;
            this.lblComponentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComponentName.Location = new System.Drawing.Point(30, 115);
            this.lblComponentName.Name = "lblComponentName";
            this.lblComponentName.Size = new System.Drawing.Size(209, 29);
            this.lblComponentName.TabIndex = 12;
            this.lblComponentName.Text = "Component Name";
            // 
            // WithGST
            // 
            this.WithGST.AutoSize = true;
            this.WithGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WithGST.Location = new System.Drawing.Point(212, 249);
            this.WithGST.Name = "WithGST";
            this.WithGST.Size = new System.Drawing.Size(116, 25);
            this.WithGST.TabIndex = 11;
            this.WithGST.Text = "With GST =";
            // 
            // lblWithGST
            // 
            this.lblWithGST.AutoSize = true;
            this.lblWithGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWithGST.Location = new System.Drawing.Point(212, 194);
            this.lblWithGST.Name = "lblWithGST";
            this.lblWithGST.Size = new System.Drawing.Size(143, 25);
            this.lblWithGST.TabIndex = 10;
            this.lblWithGST.Text = "Without GST =";
            // 
            // lblammont
            // 
            this.lblammont.AutoSize = true;
            this.lblammont.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblammont.Location = new System.Drawing.Point(42, 190);
            this.lblammont.Name = "lblammont";
            this.lblammont.Size = new System.Drawing.Size(135, 29);
            this.lblammont.TabIndex = 9;
            this.lblammont.Text = "Ammount :";
            // 
            // txtAmmount
            // 
            this.txtAmmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmmount.Location = new System.Drawing.Point(471, 395);
            this.txtAmmount.Name = "txtAmmount";
            this.txtAmmount.Size = new System.Drawing.Size(334, 30);
            this.txtAmmount.TabIndex = 50;
            this.txtAmmount.TextChanged += new System.EventHandler(this.txtAmmount_TextChanged);
            this.txtAmmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAmmount_KeyDown);
            // 
            // TalukaAgriOfficer
            // 
            this.TalukaAgriOfficer.AutoSize = true;
            this.TalukaAgriOfficer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TalukaAgriOfficer.ForeColor = System.Drawing.Color.Lime;
            this.TalukaAgriOfficer.Location = new System.Drawing.Point(666, 325);
            this.TalukaAgriOfficer.Name = "TalukaAgriOfficer";
            this.TalukaAgriOfficer.Size = new System.Drawing.Size(286, 54);
            this.TalukaAgriOfficer.TabIndex = 6;
            this.TalukaAgriOfficer.Text = "Taluka Agriculture  Officer\r\nApproval";
            this.TalukaAgriOfficer.UseVisualStyleBackColor = true;
            this.TalukaAgriOfficer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TalukaAgriOfficer_KeyDown);
            // 
            // Bank
            // 
            this.Bank.AutoSize = true;
            this.Bank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bank.ForeColor = System.Drawing.Color.Lime;
            this.Bank.Location = new System.Drawing.Point(217, 325);
            this.Bank.Name = "Bank";
            this.Bank.Size = new System.Drawing.Size(309, 54);
            this.Bank.TabIndex = 5;
            this.Bank.Text = "Bank Approval \r\n(All Bank Details are Proper)";
            this.Bank.UseVisualStyleBackColor = true;
            this.Bank.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Bank_KeyDown);
            // 
            // agrisupervisor
            // 
            this.agrisupervisor.AutoSize = true;
            this.agrisupervisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agrisupervisor.ForeColor = System.Drawing.Color.Lime;
            this.agrisupervisor.Location = new System.Drawing.Point(792, 190);
            this.agrisupervisor.Name = "agrisupervisor";
            this.agrisupervisor.Size = new System.Drawing.Size(340, 29);
            this.agrisupervisor.TabIndex = 4;
            this.agrisupervisor.Text = "Agriculture Supervisor Approval";
            this.agrisupervisor.UseVisualStyleBackColor = true;
            this.agrisupervisor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.agrisupervisor_KeyDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(2, 542);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1206, 94);
            this.panel2.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(422, 30);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 34);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save\r\n";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(670, 30);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 34);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FrmApproval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 653);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmApproval";
            this.Text = "FrmApproval";
            this.Load += new System.EventHandler(this.FrmApproval_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtAmmount;
        private System.Windows.Forms.CheckBox TalukaAgriOfficer;
        private System.Windows.Forms.CheckBox Bank;
        private System.Windows.Forms.CheckBox agrisupervisor;
        private System.Windows.Forms.Label WithGST;
        private System.Windows.Forms.Label lblWithGST;
        private System.Windows.Forms.Label lblammont;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblComponentName;
        private System.Windows.Forms.ComboBox cmbComponentName;
        private System.Windows.Forms.TextBox txtwhGST;
        private System.Windows.Forms.TextBox txtWGST;
        private System.Windows.Forms.Label lblArroval;
        private System.Windows.Forms.TextBox txtApplicationNo;
        private System.Windows.Forms.CheckBox AgriAssiAproval;
        private System.Windows.Forms.Label lblApplicationNo;
        private System.Windows.Forms.CheckBox Approval1;
        private System.Windows.Forms.Label lblAmmount;
    }
}
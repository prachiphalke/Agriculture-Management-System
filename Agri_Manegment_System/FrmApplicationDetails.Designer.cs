
namespace Agri_Manegment_System
{
    partial class FrmApplicationDetails
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
            this.lblApplicationDetails = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblDepartmentName = new System.Windows.Forms.Label();
            this.lblSchemeName = new System.Windows.Forms.Label();
            this.lblApplicationName = new System.Windows.Forms.Label();
            this.lblApplicantName = new System.Windows.Forms.Label();
            this.lblDistrict = new System.Windows.Forms.Label();
            this.lblTaluka = new System.Windows.Forms.Label();
            this.lblVillage = new System.Windows.Forms.Label();
            this.lblComponentName = new System.Windows.Forms.Label();
            this.txtApplicantName = new System.Windows.Forms.TextBox();
            this.txtDistrict = new System.Windows.Forms.TextBox();
            this.txtTaluka = new System.Windows.Forms.TextBox();
            this.txtVillage = new System.Windows.Forms.TextBox();
            this.cmbComponentName = new System.Windows.Forms.ComboBox();
            this.txtApplicationNo = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblsnm = new System.Windows.Forms.Label();
            this.lbldeptnm = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.lblApplicationDetails);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1101, 104);
            this.panel1.TabIndex = 4;
            // 
            // lblApplicationDetails
            // 
            this.lblApplicationDetails.AutoSize = true;
            this.lblApplicationDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationDetails.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblApplicationDetails.Location = new System.Drawing.Point(33, 28);
            this.lblApplicationDetails.Name = "lblApplicationDetails";
            this.lblApplicationDetails.Size = new System.Drawing.Size(304, 38);
            this.lblApplicationDetails.TabIndex = 0;
            this.lblApplicationDetails.Text = "Application Details";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.AliceBlue;
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.btnNext);
            this.panel3.Controls.Add(this.btnNew);
            this.panel3.Location = new System.Drawing.Point(2, 638);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1101, 85);
            this.panel3.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(452, 25);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 37);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(767, 25);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(124, 37);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(162, 25);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(124, 37);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblDepartmentName
            // 
            this.lblDepartmentName.AutoSize = true;
            this.lblDepartmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentName.Location = new System.Drawing.Point(47, 43);
            this.lblDepartmentName.Name = "lblDepartmentName";
            this.lblDepartmentName.Size = new System.Drawing.Size(215, 29);
            this.lblDepartmentName.TabIndex = 0;
            this.lblDepartmentName.Text = "Department Name:";
            // 
            // lblSchemeName
            // 
            this.lblSchemeName.AutoSize = true;
            this.lblSchemeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchemeName.Location = new System.Drawing.Point(47, 109);
            this.lblSchemeName.Name = "lblSchemeName";
            this.lblSchemeName.Size = new System.Drawing.Size(179, 29);
            this.lblSchemeName.TabIndex = 1;
            this.lblSchemeName.Text = "Scheme Name:";
            // 
            // lblApplicationName
            // 
            this.lblApplicationName.AutoSize = true;
            this.lblApplicationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationName.Location = new System.Drawing.Point(47, 173);
            this.lblApplicationName.Name = "lblApplicationName";
            this.lblApplicationName.Size = new System.Drawing.Size(182, 29);
            this.lblApplicationName.TabIndex = 2;
            this.lblApplicationName.Text = "Application No.:";
            // 
            // lblApplicantName
            // 
            this.lblApplicantName.AutoSize = true;
            this.lblApplicantName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicantName.Location = new System.Drawing.Point(47, 233);
            this.lblApplicantName.Name = "lblApplicantName";
            this.lblApplicantName.Size = new System.Drawing.Size(189, 29);
            this.lblApplicantName.TabIndex = 3;
            this.lblApplicantName.Text = "Applicant Name:";
            // 
            // lblDistrict
            // 
            this.lblDistrict.AutoSize = true;
            this.lblDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistrict.Location = new System.Drawing.Point(47, 289);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(92, 29);
            this.lblDistrict.TabIndex = 4;
            this.lblDistrict.Text = "District:";
            // 
            // lblTaluka
            // 
            this.lblTaluka.AutoSize = true;
            this.lblTaluka.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaluka.Location = new System.Drawing.Point(47, 346);
            this.lblTaluka.Name = "lblTaluka";
            this.lblTaluka.Size = new System.Drawing.Size(92, 29);
            this.lblTaluka.TabIndex = 5;
            this.lblTaluka.Text = "Taluka:";
            // 
            // lblVillage
            // 
            this.lblVillage.AutoSize = true;
            this.lblVillage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVillage.Location = new System.Drawing.Point(46, 398);
            this.lblVillage.Name = "lblVillage";
            this.lblVillage.Size = new System.Drawing.Size(93, 29);
            this.lblVillage.TabIndex = 6;
            this.lblVillage.Text = "Village:";
            // 
            // lblComponentName
            // 
            this.lblComponentName.AutoSize = true;
            this.lblComponentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComponentName.Location = new System.Drawing.Point(47, 459);
            this.lblComponentName.Name = "lblComponentName";
            this.lblComponentName.Size = new System.Drawing.Size(215, 29);
            this.lblComponentName.TabIndex = 7;
            this.lblComponentName.Text = "Component Name:";
            // 
            // txtApplicantName
            // 
            this.txtApplicantName.Location = new System.Drawing.Point(287, 233);
            this.txtApplicantName.Name = "txtApplicantName";
            this.txtApplicantName.Size = new System.Drawing.Size(729, 30);
            this.txtApplicantName.TabIndex = 14;
            this.txtApplicantName.TextChanged += new System.EventHandler(this.txtApplicantName_TextChanged);
            this.txtApplicantName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtApplicantName_KeyDown);
            // 
            // txtDistrict
            // 
            this.txtDistrict.Location = new System.Drawing.Point(287, 289);
            this.txtDistrict.Name = "txtDistrict";
            this.txtDistrict.Size = new System.Drawing.Size(729, 30);
            this.txtDistrict.TabIndex = 15;
            this.txtDistrict.TextChanged += new System.EventHandler(this.txtDistrict_TextChanged);
            this.txtDistrict.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDistrict_KeyDown);
            // 
            // txtTaluka
            // 
            this.txtTaluka.Location = new System.Drawing.Point(287, 346);
            this.txtTaluka.Name = "txtTaluka";
            this.txtTaluka.Size = new System.Drawing.Size(729, 30);
            this.txtTaluka.TabIndex = 16;
            this.txtTaluka.TextChanged += new System.EventHandler(this.txtTaluka_TextChanged);
            this.txtTaluka.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTaluka_KeyDown);
            // 
            // txtVillage
            // 
            this.txtVillage.Location = new System.Drawing.Point(287, 398);
            this.txtVillage.Name = "txtVillage";
            this.txtVillage.Size = new System.Drawing.Size(729, 30);
            this.txtVillage.TabIndex = 17;
            this.txtVillage.TextChanged += new System.EventHandler(this.txtVillage_TextChanged);
            this.txtVillage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVillage_KeyDown);
            // 
            // cmbComponentName
            // 
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
            this.cmbComponentName.Location = new System.Drawing.Point(287, 459);
            this.cmbComponentName.Name = "cmbComponentName";
            this.cmbComponentName.Size = new System.Drawing.Size(729, 33);
            this.cmbComponentName.TabIndex = 20;
            this.cmbComponentName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbComponentName_KeyDown);
            // 
            // txtApplicationNo
            // 
            this.txtApplicationNo.Location = new System.Drawing.Point(287, 180);
            this.txtApplicationNo.Name = "txtApplicationNo";
            this.txtApplicationNo.Size = new System.Drawing.Size(729, 30);
            this.txtApplicationNo.TabIndex = 0;
            this.txtApplicationNo.TextChanged += new System.EventHandler(this.txtApplicationNo_TextChanged);
            this.txtApplicationNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtApplicationNo_KeyDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Controls.Add(this.lblsnm);
            this.panel2.Controls.Add(this.lbldeptnm);
            this.panel2.Controls.Add(this.txtApplicationNo);
            this.panel2.Controls.Add(this.cmbComponentName);
            this.panel2.Controls.Add(this.txtVillage);
            this.panel2.Controls.Add(this.txtTaluka);
            this.panel2.Controls.Add(this.txtDistrict);
            this.panel2.Controls.Add(this.txtApplicantName);
            this.panel2.Controls.Add(this.lblComponentName);
            this.panel2.Controls.Add(this.lblVillage);
            this.panel2.Controls.Add(this.lblTaluka);
            this.panel2.Controls.Add(this.lblDistrict);
            this.panel2.Controls.Add(this.lblApplicantName);
            this.panel2.Controls.Add(this.lblApplicationName);
            this.panel2.Controls.Add(this.lblSchemeName);
            this.panel2.Controls.Add(this.lblDepartmentName);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(2, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1101, 536);
            this.panel2.TabIndex = 3;
            // 
            // lblsnm
            // 
            this.lblsnm.AutoSize = true;
            this.lblsnm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsnm.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblsnm.Location = new System.Drawing.Point(282, 109);
            this.lblsnm.Name = "lblsnm";
            this.lblsnm.Size = new System.Drawing.Size(438, 29);
            this.lblsnm.TabIndex = 25;
            this.lblsnm.Text = "Sate Agriculture Mechanization Scheme";
            // 
            // lbldeptnm
            // 
            this.lbldeptnm.AutoSize = true;
            this.lbldeptnm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldeptnm.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbldeptnm.Location = new System.Drawing.Point(282, 47);
            this.lbldeptnm.Name = "lbldeptnm";
            this.lbldeptnm.Size = new System.Drawing.Size(285, 29);
            this.lbldeptnm.TabIndex = 24;
            this.lbldeptnm.Text = "Department of Agriculture";
            // 
            // FrmApplicationDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 727);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FrmApplicationDetails";
            this.Text = "FrmApplicationDetails";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblApplicationDetails;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblDepartmentName;
        private System.Windows.Forms.Label lblSchemeName;
        private System.Windows.Forms.Label lblApplicationName;
        private System.Windows.Forms.Label lblApplicantName;
        private System.Windows.Forms.Label lblDistrict;
        private System.Windows.Forms.Label lblTaluka;
        private System.Windows.Forms.Label lblVillage;
        private System.Windows.Forms.Label lblComponentName;
        private System.Windows.Forms.TextBox txtApplicantName;
        private System.Windows.Forms.TextBox txtDistrict;
        private System.Windows.Forms.TextBox txtTaluka;
        private System.Windows.Forms.TextBox txtVillage;
        private System.Windows.Forms.ComboBox cmbComponentName;
        private System.Windows.Forms.TextBox txtApplicationNo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblsnm;
        private System.Windows.Forms.Label lbldeptnm;
    }
}
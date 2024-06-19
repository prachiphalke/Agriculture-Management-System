
namespace Agri_Manegment_System
{
    partial class FrmPersonalDetails
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
            this.lblPersonalDetails = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtApplicationNo = new System.Windows.Forms.TextBox();
            this.lblApplicationNo = new System.Windows.Forms.Label();
            this.txtApplicantName = new System.Windows.Forms.TextBox();
            this.cmbphtype = new System.Windows.Forms.ComboBox();
            this.lblphtype = new System.Windows.Forms.Label();
            this.cmbPH = new System.Windows.Forms.ComboBox();
            this.cmbcheck = new System.Windows.Forms.ComboBox();
            this.cmbCS = new System.Windows.Forms.ComboBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtAlternateno = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtMiddlename = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtEmailID = new System.Windows.Forms.TextBox();
            this.txtMobileno = new System.Windows.Forms.TextBox();
            this.lblCS = new System.Windows.Forms.Label();
            this.lblAlternateNumber = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblEmailID = new System.Windows.Forms.Label();
            this.lblPH = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblMobileno = new System.Windows.Forms.Label();
            this.lblApplicantname = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.lblPersonalDetails);
            this.panel1.Location = new System.Drawing.Point(3, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1386, 96);
            this.panel1.TabIndex = 0;
            // 
            // lblPersonalDetails
            // 
            this.lblPersonalDetails.AutoSize = true;
            this.lblPersonalDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonalDetails.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPersonalDetails.Location = new System.Drawing.Point(41, 27);
            this.lblPersonalDetails.Name = "lblPersonalDetails";
            this.lblPersonalDetails.Size = new System.Drawing.Size(271, 38);
            this.lblPersonalDetails.TabIndex = 0;
            this.lblPersonalDetails.Text = "Personal Details";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Controls.Add(this.txtApplicationNo);
            this.panel2.Controls.Add(this.lblApplicationNo);
            this.panel2.Controls.Add(this.txtApplicantName);
            this.panel2.Controls.Add(this.cmbphtype);
            this.panel2.Controls.Add(this.lblphtype);
            this.panel2.Controls.Add(this.cmbPH);
            this.panel2.Controls.Add(this.cmbcheck);
            this.panel2.Controls.Add(this.cmbCS);
            this.panel2.Controls.Add(this.cmbGender);
            this.panel2.Controls.Add(this.dtpDOB);
            this.panel2.Controls.Add(this.txtAlternateno);
            this.panel2.Controls.Add(this.txtLastname);
            this.panel2.Controls.Add(this.txtMiddlename);
            this.panel2.Controls.Add(this.txtFirstName);
            this.panel2.Controls.Add(this.txtEmailID);
            this.panel2.Controls.Add(this.txtMobileno);
            this.panel2.Controls.Add(this.lblCS);
            this.panel2.Controls.Add(this.lblAlternateNumber);
            this.panel2.Controls.Add(this.lblLastName);
            this.panel2.Controls.Add(this.lblMiddleName);
            this.panel2.Controls.Add(this.lblFirstName);
            this.panel2.Controls.Add(this.lblGender);
            this.panel2.Controls.Add(this.lblDOB);
            this.panel2.Controls.Add(this.lblEmailID);
            this.panel2.Controls.Add(this.lblPH);
            this.panel2.Controls.Add(this.lblCategory);
            this.panel2.Controls.Add(this.lblMobileno);
            this.panel2.Controls.Add(this.lblApplicantname);
            this.panel2.Location = new System.Drawing.Point(3, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1386, 515);
            this.panel2.TabIndex = 0;
            // 
            // txtApplicationNo
            // 
            this.txtApplicationNo.Location = new System.Drawing.Point(130, 85);
            this.txtApplicationNo.Name = "txtApplicationNo";
            this.txtApplicationNo.Size = new System.Drawing.Size(102, 22);
            this.txtApplicationNo.TabIndex = 0;
            this.txtApplicationNo.TextChanged += new System.EventHandler(this.txtApplicationNo_TextChanged);
            this.txtApplicationNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtApplicationNo_KeyDown);
            // 
            // lblApplicationNo
            // 
            this.lblApplicationNo.AutoSize = true;
            this.lblApplicationNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationNo.Location = new System.Drawing.Point(97, 19);
            this.lblApplicationNo.Name = "lblApplicationNo";
            this.lblApplicationNo.Size = new System.Drawing.Size(182, 29);
            this.lblApplicationNo.TabIndex = 89;
            this.lblApplicationNo.Text = "Application No.:";
            // 
            // txtApplicantName
            // 
            this.txtApplicantName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApplicantName.Location = new System.Drawing.Point(377, 84);
            this.txtApplicantName.Name = "txtApplicantName";
            this.txtApplicantName.Size = new System.Drawing.Size(276, 30);
            this.txtApplicantName.TabIndex = 1;
            this.txtApplicantName.TextChanged += new System.EventHandler(this.txtApplicantName_TextChanged);
            this.txtApplicantName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtApplicantName_KeyDown);
            // 
            // cmbphtype
            // 
            this.cmbphtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbphtype.FormattingEnabled = true;
            this.cmbphtype.Items.AddRange(new object[] {
            "Blindness",
            "leprosy Cures ",
            "hearing impairment",
            "locomotor disability ",
            "low vision",
            "mental illness",
            "mental retardation ",
            "severally handicapped",
            "severally orthopedically handicapped"});
            this.cmbphtype.Location = new System.Drawing.Point(63, 301);
            this.cmbphtype.Name = "cmbphtype";
            this.cmbphtype.Size = new System.Drawing.Size(249, 33);
            this.cmbphtype.TabIndex = 88;
            this.cmbphtype.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbphtype_KeyDown);
            // 
            // lblphtype
            // 
            this.lblphtype.AutoSize = true;
            this.lblphtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphtype.Location = new System.Drawing.Point(155, 249);
            this.lblphtype.Name = "lblphtype";
            this.lblphtype.Size = new System.Drawing.Size(89, 25);
            this.lblphtype.TabIndex = 87;
            this.lblphtype.Text = "PH Type\r\n";
            // 
            // cmbPH
            // 
            this.cmbPH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPH.FormattingEnabled = true;
            this.cmbPH.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbPH.Location = new System.Drawing.Point(1094, 180);
            this.cmbPH.Name = "cmbPH";
            this.cmbPH.Size = new System.Drawing.Size(249, 33);
            this.cmbPH.TabIndex = 86;
            this.cmbPH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbPH_KeyDown);
            // 
            // cmbcheck
            // 
            this.cmbcheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcheck.FormattingEnabled = true;
            this.cmbcheck.Items.AddRange(new object[] {
            "SC(Scheduled Caste)",
            "ST(Scheduled Tribes)",
            "Other"});
            this.cmbcheck.Location = new System.Drawing.Point(439, 450);
            this.cmbcheck.Name = "cmbcheck";
            this.cmbcheck.Size = new System.Drawing.Size(284, 33);
            this.cmbcheck.TabIndex = 85;
            this.cmbcheck.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbcheck_KeyDown);
            // 
            // cmbCS
            // 
            this.cmbCS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCS.FormattingEnabled = true;
            this.cmbCS.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbCS.Location = new System.Drawing.Point(68, 450);
            this.cmbCS.Name = "cmbCS";
            this.cmbCS.Size = new System.Drawing.Size(291, 33);
            this.cmbCS.TabIndex = 84;
            this.cmbCS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCS_KeyDown);
            // 
            // cmbGender
            // 
            this.cmbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(63, 185);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(249, 33);
            this.cmbGender.TabIndex = 83;
            this.cmbGender.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbGender_KeyDown);
            // 
            // dtpDOB
            // 
            this.dtpDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOB.Location = new System.Drawing.Point(761, 183);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(249, 30);
            this.dtpDOB.TabIndex = 82;
            this.dtpDOB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpDOB_KeyDown);
            // 
            // txtAlternateno
            // 
            this.txtAlternateno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlternateno.Location = new System.Drawing.Point(1094, 77);
            this.txtAlternateno.MaxLength = 10;
            this.txtAlternateno.Name = "txtAlternateno";
            this.txtAlternateno.Size = new System.Drawing.Size(249, 30);
            this.txtAlternateno.TabIndex = 3;
            this.txtAlternateno.TextChanged += new System.EventHandler(this.txtAlternateno_TextChanged);
            this.txtAlternateno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAlternateno_KeyDown);
            // 
            // txtLastname
            // 
            this.txtLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastname.Location = new System.Drawing.Point(1094, 304);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(249, 30);
            this.txtLastname.TabIndex = 81;
            this.txtLastname.TextChanged += new System.EventHandler(this.txtLastname_TextChanged);
            this.txtLastname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLastname_KeyDown);
            // 
            // txtMiddlename
            // 
            this.txtMiddlename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddlename.Location = new System.Drawing.Point(761, 304);
            this.txtMiddlename.Name = "txtMiddlename";
            this.txtMiddlename.Size = new System.Drawing.Size(276, 30);
            this.txtMiddlename.TabIndex = 80;
            this.txtMiddlename.TextChanged += new System.EventHandler(this.txtMiddlename_TextChanged);
            this.txtMiddlename.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMiddlename_KeyDown);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(377, 301);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(276, 30);
            this.txtFirstName.TabIndex = 79;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            this.txtFirstName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFirstName_KeyDown);
            // 
            // txtEmailID
            // 
            this.txtEmailID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailID.Location = new System.Drawing.Point(377, 188);
            this.txtEmailID.Name = "txtEmailID";
            this.txtEmailID.Size = new System.Drawing.Size(279, 30);
            this.txtEmailID.TabIndex = 78;
            this.txtEmailID.TextChanged += new System.EventHandler(this.txtEmailID_TextChanged);
            this.txtEmailID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmailID_KeyDown);
            // 
            // txtMobileno
            // 
            this.txtMobileno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobileno.Location = new System.Drawing.Point(761, 77);
            this.txtMobileno.MaxLength = 10;
            this.txtMobileno.Name = "txtMobileno";
            this.txtMobileno.Size = new System.Drawing.Size(276, 30);
            this.txtMobileno.TabIndex = 2;
            this.txtMobileno.TextChanged += new System.EventHandler(this.txtMobileno_TextChanged);
            this.txtMobileno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMobileno_KeyDown);
            // 
            // lblCS
            // 
            this.lblCS.AutoSize = true;
            this.lblCS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCS.Location = new System.Drawing.Point(110, 356);
            this.lblCS.Name = "lblCS";
            this.lblCS.Size = new System.Drawing.Size(183, 100);
            this.lblCS.TabIndex = 77;
            this.lblCS.Text = "Are you heir of \r\nfarmer who has\r\ncommitted suicide ?\r\n\r\n";
            // 
            // lblAlternateNumber
            // 
            this.lblAlternateNumber.AutoSize = true;
            this.lblAlternateNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlternateNumber.Location = new System.Drawing.Point(1140, 23);
            this.lblAlternateNumber.Name = "lblAlternateNumber";
            this.lblAlternateNumber.Size = new System.Drawing.Size(164, 25);
            this.lblAlternateNumber.TabIndex = 74;
            this.lblAlternateNumber.Text = "Alternate Number";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(1163, 249);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(106, 25);
            this.lblLastName.TabIndex = 73;
            this.lblLastName.Text = "Last Name";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddleName.Location = new System.Drawing.Point(828, 249);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(127, 25);
            this.lblMiddleName.TabIndex = 72;
            this.lblMiddleName.Text = "Middle Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(469, 249);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(106, 25);
            this.lblFirstName.TabIndex = 71;
            this.lblFirstName.Text = "First Name";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(155, 136);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(77, 25);
            this.lblGender.TabIndex = 70;
            this.lblGender.Text = "Gender";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(873, 136);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(118, 25);
            this.lblDOB.TabIndex = 69;
            this.lblDOB.Text = "Date of Birth";
            // 
            // lblEmailID
            // 
            this.lblEmailID.AutoSize = true;
            this.lblEmailID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailID.Location = new System.Drawing.Point(469, 136);
            this.lblEmailID.Name = "lblEmailID";
            this.lblEmailID.Size = new System.Drawing.Size(84, 25);
            this.lblEmailID.TabIndex = 68;
            this.lblEmailID.Text = "Email ID";
            // 
            // lblPH
            // 
            this.lblPH.AutoSize = true;
            this.lblPH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPH.Location = new System.Drawing.Point(1163, 136);
            this.lblPH.Name = "lblPH";
            this.lblPH.Size = new System.Drawing.Size(39, 25);
            this.lblPH.TabIndex = 67;
            this.lblPH.Text = "PH";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(538, 376);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(92, 25);
            this.lblCategory.TabIndex = 66;
            this.lblCategory.Text = "Category";
            // 
            // lblMobileno
            // 
            this.lblMobileno.AutoSize = true;
            this.lblMobileno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobileno.Location = new System.Drawing.Point(838, 23);
            this.lblMobileno.Name = "lblMobileno";
            this.lblMobileno.Size = new System.Drawing.Size(102, 25);
            this.lblMobileno.TabIndex = 65;
            this.lblMobileno.Text = "Mobile no.";
            // 
            // lblApplicantname
            // 
            this.lblApplicantname.AutoSize = true;
            this.lblApplicantname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicantname.Location = new System.Drawing.Point(453, 23);
            this.lblApplicantname.Name = "lblApplicantname";
            this.lblApplicantname.Size = new System.Drawing.Size(147, 25);
            this.lblApplicantname.TabIndex = 64;
            this.lblApplicantname.Text = "Applicant name";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.AliceBlue;
            this.panel3.Controls.Add(this.btnNext);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Location = new System.Drawing.Point(3, 623);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1386, 97);
            this.panel3.TabIndex = 1;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(889, 34);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(121, 29);
            this.btnNext.TabIndex = 75;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(583, 29);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(121, 34);
            this.btnSave.TabIndex = 72;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmPersonalDetails
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 722);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmPersonalDetails";
            this.Text = "FrmPersonalDetails";
            this.Load += new System.EventHandler(this.FrmPersonalDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblPersonalDetails;
        private System.Windows.Forms.TextBox txtApplicantName;
        private System.Windows.Forms.ComboBox cmbphtype;
        private System.Windows.Forms.Label lblphtype;
        private System.Windows.Forms.ComboBox cmbPH;
        private System.Windows.Forms.ComboBox cmbcheck;
        private System.Windows.Forms.ComboBox cmbCS;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox txtAlternateno;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtMiddlename;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtEmailID;
        private System.Windows.Forms.TextBox txtMobileno;
        private System.Windows.Forms.Label lblCS;
        private System.Windows.Forms.Label lblAlternateNumber;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblEmailID;
        private System.Windows.Forms.Label lblPH;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblMobileno;
        private System.Windows.Forms.Label lblApplicantname;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtApplicationNo;
        private System.Windows.Forms.Label lblApplicationNo;
    }
}
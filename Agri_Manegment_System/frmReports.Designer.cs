namespace Agri_Manegment_System
{
    partial class frmReports
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
            this.lblNFSM = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblappno = new System.Windows.Forms.Label();
            this.lblenddt = new System.Windows.Forms.Label();
            this.lblsdt = new System.Windows.Forms.Label();
            this.txtappno = new System.Windows.Forms.TextBox();
            this.dtpenddate = new System.Windows.Forms.DateTimePicker();
            this.dtpstartdate = new System.Windows.Forms.DateTimePicker();
            this.cmbReportType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.lblNFSM);
            this.panel1.Location = new System.Drawing.Point(-7, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1152, 110);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblNFSM
            // 
            this.lblNFSM.AutoSize = true;
            this.lblNFSM.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNFSM.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNFSM.Location = new System.Drawing.Point(528, 37);
            this.lblNFSM.Name = "lblNFSM";
            this.lblNFSM.Size = new System.Drawing.Size(139, 38);
            this.lblNFSM.TabIndex = 0;
            this.lblNFSM.Text = "Reports";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.AliceBlue;
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Controls.Add(this.btnShow);
            this.panel3.Location = new System.Drawing.Point(0, 495);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1145, 91);
            this.panel3.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(585, 28);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(160, 38);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(344, 28);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(160, 38);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Show Report";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Controls.Add(this.lblappno);
            this.panel2.Controls.Add(this.lblenddt);
            this.panel2.Controls.Add(this.lblsdt);
            this.panel2.Controls.Add(this.txtappno);
            this.panel2.Controls.Add(this.dtpenddate);
            this.panel2.Controls.Add(this.dtpstartdate);
            this.panel2.Controls.Add(this.cmbReportType);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-1, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1145, 387);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblappno
            // 
            this.lblappno.AutoSize = true;
            this.lblappno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblappno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblappno.Location = new System.Drawing.Point(385, 209);
            this.lblappno.Name = "lblappno";
            this.lblappno.Size = new System.Drawing.Size(141, 25);
            this.lblappno.TabIndex = 33;
            this.lblappno.Text = "Applicant no.  :";
            // 
            // lblenddt
            // 
            this.lblenddt.AutoSize = true;
            this.lblenddt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblenddt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblenddt.Location = new System.Drawing.Point(422, 267);
            this.lblenddt.Name = "lblenddt";
            this.lblenddt.Size = new System.Drawing.Size(104, 25);
            this.lblenddt.TabIndex = 32;
            this.lblenddt.Text = "End Date :";
            // 
            // lblsdt
            // 
            this.lblsdt.AutoSize = true;
            this.lblsdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsdt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblsdt.Location = new System.Drawing.Point(422, 161);
            this.lblsdt.Name = "lblsdt";
            this.lblsdt.Size = new System.Drawing.Size(110, 25);
            this.lblsdt.TabIndex = 31;
            this.lblsdt.Text = "Start Date :";
            // 
            // txtappno
            // 
            this.txtappno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtappno.Location = new System.Drawing.Point(544, 209);
            this.txtappno.Name = "txtappno";
            this.txtappno.Size = new System.Drawing.Size(259, 30);
            this.txtappno.TabIndex = 30;
            // 
            // dtpenddate
            // 
            this.dtpenddate.CustomFormat = "dd/mm/yy";
            this.dtpenddate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpenddate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpenddate.Location = new System.Drawing.Point(544, 267);
            this.dtpenddate.Name = "dtpenddate";
            this.dtpenddate.Size = new System.Drawing.Size(206, 30);
            this.dtpenddate.TabIndex = 29;
            this.dtpenddate.Value = new System.DateTime(2023, 4, 2, 8, 13, 5, 0);
            // 
            // dtpstartdate
            // 
            this.dtpstartdate.CustomFormat = "dd/mm/yy";
            this.dtpstartdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpstartdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpstartdate.Location = new System.Drawing.Point(544, 156);
            this.dtpstartdate.Name = "dtpstartdate";
            this.dtpstartdate.Size = new System.Drawing.Size(206, 30);
            this.dtpstartdate.TabIndex = 27;
            this.dtpstartdate.Value = new System.DateTime(2023, 4, 2, 8, 13, 5, 0);
            // 
            // cmbReportType
            // 
            this.cmbReportType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbReportType.FormattingEnabled = true;
            this.cmbReportType.Items.AddRange(new object[] {
            "Farmer wise Report",
            "Date wise Report"});
            this.cmbReportType.Location = new System.Drawing.Point(544, 89);
            this.cmbReportType.Name = "cmbReportType";
            this.cmbReportType.Size = new System.Drawing.Size(259, 33);
            this.cmbReportType.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(342, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Select Report Type :";
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 587);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "frmReports";
            this.Text = "frmReports";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNFSM;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblappno;
        private System.Windows.Forms.Label lblenddt;
        private System.Windows.Forms.Label lblsdt;
        private System.Windows.Forms.TextBox txtappno;
        private System.Windows.Forms.DateTimePicker dtpenddate;
        private System.Windows.Forms.DateTimePicker dtpstartdate;
        private System.Windows.Forms.ComboBox cmbReportType;
        private System.Windows.Forms.Label label1;
    }
}
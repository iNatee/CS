namespace AppliedSystemsChallenge
{
    partial class Insurance
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
            this.lblDriverInfo = new System.Windows.Forms.Label();
            this.lblDriverName = new System.Windows.Forms.Label();
            this.txtDriverName = new System.Windows.Forms.TextBox();
            this.lblDriverOccupation = new System.Windows.Forms.Label();
            this.lblDriverDoB = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dtpDriverDoB = new System.Windows.Forms.DateTimePicker();
            this.dtpPolicyStartDate = new System.Windows.Forms.DateTimePicker();
            this.cbxDriverOccupation = new System.Windows.Forms.ComboBox();
            this.lblPremium = new System.Windows.Forms.Label();
            this.lblDecline = new System.Windows.Forms.Label();
            this.lblInsuranceInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDriverInfo
            // 
            this.lblDriverInfo.AutoSize = true;
            this.lblDriverInfo.Location = new System.Drawing.Point(24, 81);
            this.lblDriverInfo.Name = "lblDriverInfo";
            this.lblDriverInfo.Size = new System.Drawing.Size(93, 13);
            this.lblDriverInfo.TabIndex = 0;
            this.lblDriverInfo.Text = "Driver Information:";
            // 
            // lblDriverName
            // 
            this.lblDriverName.AutoSize = true;
            this.lblDriverName.ForeColor = System.Drawing.Color.Black;
            this.lblDriverName.Location = new System.Drawing.Point(24, 116);
            this.lblDriverName.Name = "lblDriverName";
            this.lblDriverName.Size = new System.Drawing.Size(76, 13);
            this.lblDriverName.TabIndex = 1;
            this.lblDriverName.Text = "Driver Name: *";
            // 
            // txtDriverName
            // 
            this.txtDriverName.Location = new System.Drawing.Point(27, 132);
            this.txtDriverName.Name = "txtDriverName";
            this.txtDriverName.Size = new System.Drawing.Size(100, 20);
            this.txtDriverName.TabIndex = 2;
            this.txtDriverName.TextChanged += new System.EventHandler(this.TxtDriverName_TextChanged);
            // 
            // lblDriverOccupation
            // 
            this.lblDriverOccupation.AutoSize = true;
            this.lblDriverOccupation.Location = new System.Drawing.Point(24, 168);
            this.lblDriverOccupation.Name = "lblDriverOccupation";
            this.lblDriverOccupation.Size = new System.Drawing.Size(103, 13);
            this.lblDriverOccupation.TabIndex = 3;
            this.lblDriverOccupation.Text = "Driver Occupation: *";
            // 
            // lblDriverDoB
            // 
            this.lblDriverDoB.AutoSize = true;
            this.lblDriverDoB.Location = new System.Drawing.Point(24, 222);
            this.lblDriverDoB.Name = "lblDriverDoB";
            this.lblDriverDoB.Size = new System.Drawing.Size(107, 13);
            this.lblDriverDoB.TabIndex = 5;
            this.lblDriverDoB.Text = "Driver Date of Birth: *";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(185, 116);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(96, 13);
            this.lblStartDate.TabIndex = 7;
            this.lblStartDate.Text = "Policy Start Date: *";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(27, 346);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // dtpDriverDoB
            // 
            this.dtpDriverDoB.Location = new System.Drawing.Point(27, 238);
            this.dtpDriverDoB.Name = "dtpDriverDoB";
            this.dtpDriverDoB.Size = new System.Drawing.Size(130, 20);
            this.dtpDriverDoB.TabIndex = 10;
            this.dtpDriverDoB.ValueChanged += new System.EventHandler(this.DtpDriverDoB_ValueChanged);
            // 
            // dtpPolicyStartDate
            // 
            this.dtpPolicyStartDate.Location = new System.Drawing.Point(188, 132);
            this.dtpPolicyStartDate.Name = "dtpPolicyStartDate";
            this.dtpPolicyStartDate.Size = new System.Drawing.Size(130, 20);
            this.dtpPolicyStartDate.TabIndex = 11;
            this.dtpPolicyStartDate.ValueChanged += new System.EventHandler(this.DtpPolicyStartDate_ValueChanged);
            // 
            // cbxDriverOccupation
            // 
            this.cbxDriverOccupation.FormattingEnabled = true;
            this.cbxDriverOccupation.Items.AddRange(new object[] {
            "Chauffeur",
            "Accountant"});
            this.cbxDriverOccupation.Location = new System.Drawing.Point(27, 190);
            this.cbxDriverOccupation.Name = "cbxDriverOccupation";
            this.cbxDriverOccupation.Size = new System.Drawing.Size(121, 21);
            this.cbxDriverOccupation.TabIndex = 14;
            this.cbxDriverOccupation.SelectedIndexChanged += new System.EventHandler(this.CbxDriverOccupation_SelectedIndexChanged);
            // 
            // lblPremium
            // 
            this.lblPremium.AutoSize = true;
            this.lblPremium.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPremium.Location = new System.Drawing.Point(297, 244);
            this.lblPremium.Name = "lblPremium";
            this.lblPremium.Size = new System.Drawing.Size(0, 16);
            this.lblPremium.TabIndex = 15;
            // 
            // lblDecline
            // 
            this.lblDecline.AutoSize = true;
            this.lblDecline.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecline.ForeColor = System.Drawing.Color.Red;
            this.lblDecline.Location = new System.Drawing.Point(297, 213);
            this.lblDecline.Name = "lblDecline";
            this.lblDecline.Size = new System.Drawing.Size(0, 16);
            this.lblDecline.TabIndex = 13;
            // 
            // lblInsuranceInfo
            // 
            this.lblInsuranceInfo.AutoSize = true;
            this.lblInsuranceInfo.Location = new System.Drawing.Point(185, 81);
            this.lblInsuranceInfo.Name = "lblInsuranceInfo";
            this.lblInsuranceInfo.Size = new System.Drawing.Size(112, 13);
            this.lblInsuranceInfo.TabIndex = 12;
            this.lblInsuranceInfo.Text = "Insurance Information:";
            // 
            // Insurance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPremium);
            this.Controls.Add(this.cbxDriverOccupation);
            this.Controls.Add(this.lblDecline);
            this.Controls.Add(this.lblInsuranceInfo);
            this.Controls.Add(this.dtpPolicyStartDate);
            this.Controls.Add(this.dtpDriverDoB);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblDriverDoB);
            this.Controls.Add(this.lblDriverOccupation);
            this.Controls.Add(this.txtDriverName);
            this.Controls.Add(this.lblDriverName);
            this.Controls.Add(this.lblDriverInfo);
            this.Name = "Insurance";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDriverInfo;
        private System.Windows.Forms.Label lblDriverName;
        private System.Windows.Forms.TextBox txtDriverName;
        private System.Windows.Forms.Label lblDriverOccupation;
        private System.Windows.Forms.Label lblDriverDoB;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DateTimePicker dtpDriverDoB;
        private System.Windows.Forms.DateTimePicker dtpPolicyStartDate;
        private System.Windows.Forms.ComboBox cbxDriverOccupation;
        private System.Windows.Forms.Label lblPremium;
        private System.Windows.Forms.Label lblDecline;
        private System.Windows.Forms.Label lblInsuranceInfo;
    }
}


namespace ClinicManagementSystem
{
    partial class AdminMainForm
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
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.pnlCurrPageName = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnPatientsRecords = new System.Windows.Forms.Button();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButtons
            // 
            this.pnlButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlButtons.Controls.Add(this.btnPatientsRecords);
            this.pnlButtons.Location = new System.Drawing.Point(0, -1);
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(193, 719);
            this.pnlButtons.TabIndex = 0;
            // 
            // pnlCurrPageName
            // 
            this.pnlCurrPageName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCurrPageName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlCurrPageName.Location = new System.Drawing.Point(192, -1);
            this.pnlCurrPageName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlCurrPageName.Name = "pnlCurrPageName";
            this.pnlCurrPageName.Size = new System.Drawing.Size(1234, 84);
            this.pnlCurrPageName.TabIndex = 1;
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlMain.Location = new System.Drawing.Point(192, 83);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1234, 633);
            this.pnlMain.TabIndex = 2;
            // 
            // btnPatientsRecords
            // 
            this.btnPatientsRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPatientsRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientsRecords.Location = new System.Drawing.Point(0, 259);
            this.btnPatientsRecords.Name = "btnPatientsRecords";
            this.btnPatientsRecords.Size = new System.Drawing.Size(193, 71);
            this.btnPatientsRecords.TabIndex = 0;
            this.btnPatientsRecords.Text = "PATIENTS RECORDS";
            this.btnPatientsRecords.UseVisualStyleBackColor = true;
            this.btnPatientsRecords.Click += new System.EventHandler(this.btnPatientsRecords_Click);
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 716);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlCurrPageName);
            this.Controls.Add(this.pnlButtons);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminMainForm";
            this.Text = "Clinic Management System - Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AMainFomr_Load);
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Panel pnlCurrPageName;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnPatientsRecords;
    }
}
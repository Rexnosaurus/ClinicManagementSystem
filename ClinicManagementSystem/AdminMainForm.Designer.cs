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
            this.btnPatientsRecords = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnAppointmentSchedules = new System.Windows.Forms.Button();
            this.btnRecords = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlButtons.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButtons
            // 
            this.pnlButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlButtons.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.pnlButtons.Controls.Add(this.button3);
            this.pnlButtons.Controls.Add(this.btnPayment);
            this.pnlButtons.Controls.Add(this.btnRecords);
            this.pnlButtons.Controls.Add(this.btnAppointmentSchedules);
            this.pnlButtons.Controls.Add(this.btnDashboard);
            this.pnlButtons.Controls.Add(this.label2);
            this.pnlButtons.Controls.Add(this.pictureBox1);
            this.pnlButtons.Controls.Add(this.btnPatientsRecords);
            this.pnlButtons.Location = new System.Drawing.Point(0, -1);
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(265, 885);
            this.pnlButtons.TabIndex = 0;
            // 
            // btnPatientsRecords
            // 
            this.btnPatientsRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPatientsRecords.FlatAppearance.BorderSize = 0;
            this.btnPatientsRecords.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPatientsRecords.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnPatientsRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientsRecords.Font = new System.Drawing.Font("Segoe UI Variable Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientsRecords.Location = new System.Drawing.Point(-4, 436);
            this.btnPatientsRecords.Margin = new System.Windows.Forms.Padding(4);
            this.btnPatientsRecords.Name = "btnPatientsRecords";
            this.btnPatientsRecords.Size = new System.Drawing.Size(265, 87);
            this.btnPatientsRecords.TabIndex = 0;
            this.btnPatientsRecords.Text = "PATIENTS RECORDS";
            this.btnPatientsRecords.UseVisualStyleBackColor = true;
            this.btnPatientsRecords.Click += new System.EventHandler(this.btnPatientsRecords_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.BackColor = System.Drawing.Color.GhostWhite;
            this.pnlMain.Controls.Add(this.pictureBox2);
            this.pnlMain.Location = new System.Drawing.Point(256, 1);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1645, 880);
            this.pnlMain.TabIndex = 2;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ClinicManagementSystem.Properties.Resources.White_Modern_Minimalist_Signature_Brand_Logo_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(3, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Text", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(113, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 63);
            this.label2.TabIndex = 7;
            this.label2.Text = "CMS";
            // 
            // btnDashboard
            // 
            this.btnDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI Variable Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Location = new System.Drawing.Point(-6, 258);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(265, 87);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "DASHBOARD";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnAppointmentSchedules
            // 
            this.btnAppointmentSchedules.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAppointmentSchedules.FlatAppearance.BorderSize = 0;
            this.btnAppointmentSchedules.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAppointmentSchedules.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAppointmentSchedules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppointmentSchedules.Font = new System.Drawing.Font("Segoe UI Variable Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppointmentSchedules.Location = new System.Drawing.Point(-6, 341);
            this.btnAppointmentSchedules.Margin = new System.Windows.Forms.Padding(4);
            this.btnAppointmentSchedules.Name = "btnAppointmentSchedules";
            this.btnAppointmentSchedules.Size = new System.Drawing.Size(265, 87);
            this.btnAppointmentSchedules.TabIndex = 9;
            this.btnAppointmentSchedules.Text = "APPOINTMENT\r\nSCHEDULES";
            this.btnAppointmentSchedules.UseVisualStyleBackColor = true;
            // 
            // btnRecords
            // 
            this.btnRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecords.FlatAppearance.BorderSize = 0;
            this.btnRecords.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRecords.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecords.Font = new System.Drawing.Font("Segoe UI Variable Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecords.Location = new System.Drawing.Point(-4, 521);
            this.btnRecords.Margin = new System.Windows.Forms.Padding(4);
            this.btnRecords.Name = "btnRecords";
            this.btnRecords.Size = new System.Drawing.Size(265, 87);
            this.btnRecords.TabIndex = 10;
            this.btnRecords.Text = "RECORDS";
            this.btnRecords.UseVisualStyleBackColor = true;
            // 
            // btnPayment
            // 
            this.btnPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPayment.FlatAppearance.BorderSize = 0;
            this.btnPayment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPayment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Segoe UI Variable Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.Location = new System.Drawing.Point(-6, 605);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(4);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(265, 87);
            this.btnPayment.TabIndex = 11;
            this.btnPayment.Text = "PAYMENT";
            this.btnPayment.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Variable Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ImageKey = "(none)";
            this.button3.Location = new System.Drawing.Point(12, 863);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(219, 52);
            this.button3.TabIndex = 12;
            this.button3.Text = "LOGOUT";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::ClinicManagementSystem.Properties.Resources._2101e0de_3e8a_42c1_865a_06b73ea7d74e;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1645, 880);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1901, 881);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlButtons);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminMainForm";
            this.Text = "Clinic Management System - Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AMainFomr_Load);
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnPatientsRecords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnAppointmentSchedules;
        private System.Windows.Forms.Button btnRecords;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
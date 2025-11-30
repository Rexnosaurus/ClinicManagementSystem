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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlButtons.Location = new System.Drawing.Point(0, -1);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(257, 885);
            this.pnlButtons.TabIndex = 0;
            // 
            // pnlCurrPageName
            // 
            this.pnlCurrPageName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlCurrPageName.Location = new System.Drawing.Point(256, -1);
            this.pnlCurrPageName.Name = "pnlCurrPageName";
            this.pnlCurrPageName.Size = new System.Drawing.Size(1646, 104);
            this.pnlCurrPageName.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Location = new System.Drawing.Point(256, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1646, 779);
            this.panel1.TabIndex = 2;
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 881);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlCurrPageName);
            this.Controls.Add(this.pnlButtons);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminMainForm";
            this.Text = "Clinic Management System - Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AMainFomr_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Panel pnlCurrPageName;
        private System.Windows.Forms.Panel panel1;
    }
}
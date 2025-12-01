namespace ClinicManagementSystem.AdminForms
{
    partial class PatientsRecordsForm
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
            this.dgvPatientsRecords = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnArchive = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientsRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPatientsRecords
            // 
            this.dgvPatientsRecords.AllowUserToAddRows = false;
            this.dgvPatientsRecords.AllowUserToDeleteRows = false;
            this.dgvPatientsRecords.AllowUserToResizeColumns = false;
            this.dgvPatientsRecords.AllowUserToResizeRows = false;
            this.dgvPatientsRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPatientsRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvPatientsRecords.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvPatientsRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatientsRecords.Location = new System.Drawing.Point(12, 138);
            this.dgvPatientsRecords.Name = "dgvPatientsRecords";
            this.dgvPatientsRecords.ReadOnly = true;
            this.dgvPatientsRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatientsRecords.Size = new System.Drawing.Size(1194, 305);
            this.dgvPatientsRecords.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAdd.Location = new System.Drawing.Point(22, 528);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(255, 52);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnArchive
            // 
            this.btnArchive.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnArchive.Location = new System.Drawing.Point(283, 528);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(255, 52);
            this.btnArchive.TabIndex = 2;
            this.btnArchive.Text = "ARCHIVE";
            this.btnArchive.UseVisualStyleBackColor = true;
            this.btnArchive.Click += new System.EventHandler(this.btnArchive_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUpdate.Location = new System.Drawing.Point(544, 530);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(255, 52);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // PatientsRecordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 594);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnArchive);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvPatientsRecords);
            this.Name = "PatientsRecordsForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PatientsRecordsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientsRecords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPatientsRecords;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnArchive;
        private System.Windows.Forms.Button btnUpdate;
    }
}
using LogInForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementSystem.AdminForms
{
    
    public partial class PatientsRecordsForm : Form
    {       
        ConnectionClass cc = new ConnectionClass();

        AdminPopUpForms.AddPatientForm addPatient = new AdminPopUpForms.AddPatientForm();
        public PatientsRecordsForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void getTableData()
        {
            dgvPatientsRecords.DataSource = cc.GetPatientsRecord();
        }

        private void PatientsRecordsForm_Load(object sender, EventArgs e)
        {
            getTableData();

            dgvPatientsRecords.Columns["Patient_Id"].HeaderText = "Patient ID";
            dgvPatientsRecords.Columns["FirstName"].HeaderText = "First Name";
            dgvPatientsRecords.Columns["MiddleName"].HeaderText = "Middle Name";
            dgvPatientsRecords.Columns["LastName"].HeaderText = "Last Name";
            dgvPatientsRecords.Columns["Suffix"].HeaderText = "Suffix";
            dgvPatientsRecords.Columns["Gender"].HeaderText = "Gender";
            dgvPatientsRecords.Columns["Birthday"].HeaderText = "Birthday";
            dgvPatientsRecords.Columns["Address"].HeaderText = "Address";
            dgvPatientsRecords.Columns["ContactNo"].HeaderText = "Contact Number";
            dgvPatientsRecords.Columns["EmailAddress"].HeaderText = "Email Address";

            dgvPatientsRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (addPatient.ShowDialog() == DialogResult.OK) {
                getTableData();
            }
                
            addPatient.BringToFront();
            
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            if (dgvPatientsRecords.CurrentRow != null)
            {
                int patientId = Convert.ToInt32(dgvPatientsRecords.CurrentRow.Cells["Patient_Id"].Value);

                DialogResult dr = MessageBox.Show("Do you want to archive this Patient?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    bool archived = cc.ArchivePatient(patientId);
                    if (archived)
                    {
                        MessageBox.Show("Patient archived successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getTableData(); 
                    }
                    else
                    {
                        MessageBox.Show("Failed to archive patient.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvPatientsRecords.CurrentRow == null)
            {
                MessageBox.Show("Please select a patient to update.");
                return;
            }

            AdminPopUpForms.UpdatePatient updateForm = new AdminPopUpForms.UpdatePatient();
            updateForm.LoadPatientData(dgvPatientsRecords.CurrentRow);

            if (updateForm.ShowDialog() == DialogResult.OK)
            {
                getTableData();
            }
        }

        private void dgvPatientsRecords_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

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
    public partial class AppointmentsSchedulesForms : Form
    {
        ConnectionClass cc = new ConnectionClass();

        AdminPopUpForms.AddAppointment addAppointment = new AdminPopUpForms.AddAppointment();
        public AppointmentsSchedulesForms()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void getTableData()
        {
            dgvAppointmentSchedules.DataSource = cc.GetPatientsRecord();
        }

        private void PatientsRecordsForm_Load(object sender, EventArgs e)
        {
            getTableData();

            dgvAppointmentSchedules.Columns["Patient_Id"].HeaderText = "Patient ID";
            dgvAppointmentSchedules.Columns["FirstName"].HeaderText = "First Name";
            dgvAppointmentSchedules.Columns["MiddleName"].HeaderText = "Middle Name";
            dgvAppointmentSchedules.Columns["LastName"].HeaderText = "Last Name";
            dgvAppointmentSchedules.Columns["Suffix"].HeaderText = "Suffix";
            dgvAppointmentSchedules.Columns["Gender"].HeaderText = "Gender";
            dgvAppointmentSchedules.Columns["Birthday"].HeaderText = "Birthday";
            dgvAppointmentSchedules.Columns["Address"].HeaderText = "Address";
            dgvAppointmentSchedules.Columns["ContactNo"].HeaderText = "Contact Number";
            dgvAppointmentSchedules.Columns["EmailAddress"].HeaderText = "Email Address";

            dgvAppointmentSchedules.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (addAppointment.ShowDialog() == DialogResult.OK)
            {
                getTableData();
            }

            addAppointment.BringToFront();
            

        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            if (dgvAppointmentSchedules.CurrentRow != null)
            {
                int patientId = Convert.ToInt32(dgvAppointmentSchedules.CurrentRow.Cells["Patient_Id"].Value);

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
            if (dgvAppointmentSchedules.CurrentRow == null)
            {
                MessageBox.Show("Please select a patient to update.");
                return;
            }

            AdminPopUpForms.UpdatePatient updateForm = new AdminPopUpForms.UpdatePatient();
            updateForm.LoadPatientData(dgvAppointmentSchedules.CurrentRow);

            if (updateForm.ShowDialog() == DialogResult.OK)
            {
                getTableData();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvAppointmentSchedules.DataSource = cc.SearchPatients(txtSearch.Text);
        }
    }
}

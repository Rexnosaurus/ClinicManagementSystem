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

namespace ClinicManagementSystem.AdminPopUpForms
{
    public partial class UpdatePatient : Form
    {

        ConnectionClass cc = new ConnectionClass();
        public UpdatePatient()
        {
            InitializeComponent();
        }

        public void LoadPatientData(DataGridViewRow row)
        {
            txtPatientId.Text = row.Cells["Patient_Id"].Value.ToString();
            txtFName.Text = row.Cells["FirstName"].Value.ToString();
            txtMName.Text = row.Cells["MiddleName"].Value.ToString();
            txtLName.Text = row.Cells["LastName"].Value.ToString();
            txtSuffix.Text = row.Cells["Suffix"].Value.ToString();
            txtAddress.Text = row.Cells["Address"].Value.ToString();
            txtContactNo.Text = row.Cells["ContactNo"].Value.ToString();
            txtEmailAddress.Text = row.Cells["EmailAddress"].Value.ToString();

            string gender = row.Cells["Gender"].Value.ToString();
            if (gender == "Male") rdoMale.Checked = true;
            else if (gender == "Female") rdoFemale.Checked = true;

            dtpDateOfBirth.Value = Convert.ToDateTime(row.Cells["Birthday"].Value);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int patientId = Convert.ToInt32(txtPatientId.Text);
            string fname = txtFName.Text.Trim();
            string mname = txtMName.Text.Trim();
            string lname = txtLName.Text.Trim();
            string suffix = txtSuffix.Text.Trim();
            string gender = rdoMale.Checked ? "Male" : "Female";
            string dob = dtpDateOfBirth.Value.ToString("yyyy-MM-dd");
            string address = txtAddress.Text.Trim();
            string contactNo = txtContactNo.Text.Trim();
            string email = txtEmailAddress.Text.Trim();

            bool success = cc.UpdatePatient(patientId, fname, mname, lname, suffix, gender, dob, address, contactNo, email);

            if (success)
            {
                MessageBox.Show("Patient updated successfully!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to update patient.");
            }
        }

        private void txtPatientId_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdatePatient_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}

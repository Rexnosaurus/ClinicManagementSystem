using LogInForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace ClinicManagementSystem.AdminPopUpForms
{
    public partial class AddPatientForm : Form
    {
        ConnectionClass cc = new ConnectionClass();
        public AddPatientForm()
        {
            InitializeComponent();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            string fname = txtFName.Text.Trim();
            string mname = txtMName.Text.Trim();
            string lname = txtLName.Text.Trim();
            string suffix = txtSuffix.Text.Trim();

            string gender = "";
            if (rdoFemale.Checked) gender = "Female";
            else if (rdoMale.Checked) gender = "Male";
            else
            {
                MessageBox.Show("Please select gender.");
                return;
            }

            string dob = dtpDateOfBirth.Value.ToString("yyyy-MM-dd");
            string address = txtAddress.Text.Trim();
            string contactno = txtContactNo.Text.Trim();
            string emailaddr = txtEmailAddress.Text.Trim();

            bool success = cc.InsertPatient(fname, mname, lname, suffix, gender, dob, address, contactno, emailaddr);

            if (success)
            {
                MessageBox.Show("Patient added successfully!");

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to add patient.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            TextBox[] fields = {
            txtFName,
            txtMName,
            txtLName,
            txtSuffix,
            txtEmailAddress,
            txtAddress,
            txtContactNo
            };

            foreach (TextBox txt in fields)
            {
                txt.Clear();
            }
        }

        private void AddPatientForm_Load(object sender, EventArgs e)
        {
            txtPatientId.Text = cc.GetNextPatientID().ToString();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}

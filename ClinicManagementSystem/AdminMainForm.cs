using ClinicManagementSystem.AdminForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementSystem
{
    public partial class AdminMainForm : Form
    {
        PatientsRecordsForm patientsRecordsForm = new PatientsRecordsForm();
        public AdminMainForm()
        {
            InitializeComponent();
        }

        private void AMainFomr_Load(object sender, EventArgs e)
        {

        }

        private void btnPatientsRecords_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            patientsRecordsForm.TopLevel = false;
            patientsRecordsForm.FormBorderStyle = FormBorderStyle.None;
            pnlMain.Controls.Add(patientsRecordsForm);
            patientsRecordsForm.Dock = DockStyle.Fill;

            patientsRecordsForm.Show();
        }
    }
}

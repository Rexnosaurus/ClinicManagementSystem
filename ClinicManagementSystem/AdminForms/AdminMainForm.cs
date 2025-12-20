using ClinicManagementSystem.AdminForms;
using System;
using System.Windows.Forms;

namespace ClinicManagementSystem
{
    public partial class AdminMainForm : Form
    {
        PatientsRecordsForm patientsRecordsForm = new PatientsRecordsForm();
        AppointmentsSchedulesForms appointmentsSchedulesForm = new AppointmentsSchedulesForms();
        public AdminMainForm()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
        }

        private void AMainFomr_Load(object sender, EventArgs e)
        {
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
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

        private void btnAppnmtSched_Click(object sender, EventArgs e)
        {
            pnlMain.Controls.Clear();
            appointmentsSchedulesForm.TopLevel = false;
            appointmentsSchedulesForm.FormBorderStyle = FormBorderStyle.None;
            pnlMain.Controls.Add(appointmentsSchedulesForm);
            appointmentsSchedulesForm.Dock = DockStyle.Fill;

            appointmentsSchedulesForm.Show();
        }
    }
}

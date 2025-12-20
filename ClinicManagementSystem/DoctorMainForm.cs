using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicManagementSystem.AdminForms;
using ClinicManagementSystem.DoctorsForms;

namespace ClinicManagementSystem
{
    public partial class DoctorMainForm : Form
    {
        DASHBOARD doctorDashboard = new DASHBOARD();
        DoctorsForms.AppointmentSchedule appointmentSchedule = new DoctorsForms.AppointmentSchedule();
        PatientRecords patientRecords = new PatientRecords();
        public DoctorMainForm()
        {
            InitializeComponent();
        }

        private void DoctorMainForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        private void pnlButtons_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnPatientsRecords_Click(object sender, EventArgs e) //DASHBOARD
        {
          

            panel2.Controls.Clear();
            doctorDashboard.TopLevel = false;
            panel2.Controls.Add(doctorDashboard);
            doctorDashboard.FormBorderStyle = FormBorderStyle.None;
            doctorDashboard.Dock = DockStyle.Fill;

            doctorDashboard.Show();
            {
              
               
            }
        }

        

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //APPOINTMENT SCEHDULE
        {
            panel2.Controls.Clear();
            appointmentSchedule.TopLevel = false;
            panel2.Controls.Add(appointmentSchedule);
            appointmentSchedule.FormBorderStyle = FormBorderStyle.None;
            appointmentSchedule.Dock = DockStyle.Fill;

            appointmentSchedule.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            patientRecords.TopLevel = false;
            panel2.Controls.Add(patientRecords);
            patientRecords.FormBorderStyle = FormBorderStyle.None;
            patientRecords.Dock = DockStyle.Fill;

            patientRecords.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class AddAppointment : Form
    {
        ConnectionClass cc = new ConnectionClass();
        public AddAppointment()
        {
            InitializeComponent();
        }

        private void txtPatientId_TextChanged(object sender, EventArgs e)
        {
            txtFullName.Text = cc.SearchIdPatient(txtPatientId.Text);   
        }
    }
}

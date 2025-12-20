using LogInForm;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagementSystem
{
    public partial class LoginForm : Form
    {
        ConnectionClass cc = new ConnectionClass();
        
        AdminMainForm adminMainForm = new AdminMainForm();
        DoctorMainForm doctorMainForm = new DoctorMainForm();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = "";

            if (username == "" || password == "")
            {
                MessageBox.Show("Please fill in all fields.", "Warning", MessageBoxButtons.OK);
                return;
            }

            try
            {
                cc.OpenConnection();
                string query = "SELECT * FROM users WHERE Username = @Username AND Password = @password";
                
                MySqlCommand cmd = new MySqlCommand(query, cc.GetConnection());

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {

                    role = reader.GetString("role");
                     

                    MessageBox.Show("Login successful!", "Success" + role + "Damn", MessageBoxButtons.OK);
                    if (role == "Admin")
                    {
                        adminMainForm.Show();
                        
                    } else if (role == "Doctor")
                        { doctorMainForm.Show();
                    }
                    
                    this.Hide();
                    adminMainForm.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK);
                }
                reader.Close();
                cc.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK);
            }
        }

    }
}

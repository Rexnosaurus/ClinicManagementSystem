using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace LogInForm
{
    internal class ConnectionClass
    {
        private MySqlConnection connection;
        private string username;
        private string password;
        private string database;
        private string link;

        public ConnectionClass()
        {
            username = "root";
            password = "rextcm132";
            database = "clinic_ms";
            link = "localhost";

            string connectionString = $"Server={link};Database={database};User ID={username};Password={password};";
            connection = new MySqlConnection(connectionString);
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }

        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public int GetNextPatientID()
        {
            int nextId = 1;
            string query = "SELECT MAX(Patient_Id) FROM patientsrecords";

            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    nextId = Convert.ToInt32(result) + 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching next Patient ID: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return nextId;
        }
        public DataTable GetPatientsRecord()
        {

            DataTable dt = new DataTable();
            string query = "SELECT * FROM patientsrecords";

            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return dt;
        }

        public bool InsertPatient(
            string fname, string mname, string lname, string suffix,
            string gender, string birthday, string address,
            string contactNo, string emailAddress)
        {
            string query = @"INSERT INTO patientsrecords
                         (FirstName, MiddleName, LastName, Suffix, Gender, Birthday, Address, ContactNo, EmailAddress)
                         VALUES
                         (@fname, @mname, @lname, @suffix, @gender, @birthday, @address, @contactNo, @emailAddress)";

            try
            {
                OpenConnection();

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@fname", fname);
                cmd.Parameters.AddWithValue("@mname", mname);
                cmd.Parameters.AddWithValue("@lname", lname);
                cmd.Parameters.AddWithValue("@suffix", suffix);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@birthday", birthday);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@contactNo", contactNo);
                cmd.Parameters.AddWithValue("@emailAddress", emailAddress);

                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Insert Error: " + ex.Message);
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }

        public bool ArchivePatient(int patientId)
        {

            string queryArchive = @"INSERT INTO archivedpatients
                            (Patient_Id, FirstName, MiddleName, LastName, Suffix, Gender, Birthday, Address, ContactNo, EmailAddress)
                            SELECT Patient_Id, FirstName, MiddleName, LastName, Suffix, Gender, Birthday, Address, ContactNo, EmailAddress
                            FROM patientsrecords
                            WHERE Patient_Id = @patientId";

            string queryDelete = @"DELETE FROM patientsrecords WHERE Patient_ID = @patientId";

            try
            {
                OpenConnection();

                MySqlCommand cmdArchive = new MySqlCommand(queryArchive, connection);
                cmdArchive.Parameters.AddWithValue("@patientId", patientId);
                int rowsArchived = cmdArchive.ExecuteNonQuery();

                if (rowsArchived > 0)
                {
                    MySqlCommand cmdDelete = new MySqlCommand(queryDelete, connection);
                    cmdDelete.Parameters.AddWithValue("@patientId", patientId);
                    cmdDelete.ExecuteNonQuery();
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Archive Error: " + ex.Message);
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }

        public bool UpdatePatient(
            int patientId,
            string fname,
            string mname,
            string lname,
            string suffix,
            string gender,
            string birthday,
            string address,
            string contactNo,
            string emailAddress)
        {
            string query = @"UPDATE patientsrecords
                         SET FirstName = @fname, MiddleName = @mname, LastName = @lname,
                             Suffix = @suffix,
                             Gender = @gender,
                             Birthday = @birthday,
                             Address = @address,
                             ContactNo = @contactNo,
                             EmailAddress = @emailAddress
                         WHERE Patient_Id = @patientId";

            try
            {
                OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@fname", fname);
                cmd.Parameters.AddWithValue("@mname", mname);
                cmd.Parameters.AddWithValue("@lname", lname);
                cmd.Parameters.AddWithValue("@suffix", suffix);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@birthday", birthday);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@contactNo", contactNo);
                cmd.Parameters.AddWithValue("@emailAddress", emailAddress);
                cmd.Parameters.AddWithValue("@patientId", patientId);

                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Error: " + ex.Message);
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }

        public DataTable SearchPatients(string keyword)
        {
            DataTable dt = new DataTable();

            string query = @"
        SELECT *
        FROM patientsrecords
        WHERE FirstName LIKE @search
           OR MiddleName LIKE @search
           OR LastName LIKE @search
           OR Address LIKE @search
           OR ContactNo LIKE @search";

            try
            {
                OpenConnection();

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@search", "%" + keyword + "%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search Error: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return dt;
        }

        public string SearchIdPatient(string keyword)
        {
            string patient_Name = "";

            string query = @"
        SELECT FirstName, MiddleName, LastName
        FROM patientsrecords
        WHERE Patient_Id LIKE @search
        LIMIT 1";

            try
            {
                OpenConnection();

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@search", keyword + "%"); // search as you type

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    patient_Name = reader["FirstName"].ToString() + " " +
                                   reader["MiddleName"].ToString() + " " +
                                   reader["LastName"].ToString();
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search Error: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return patient_Name;
        }



    }
}

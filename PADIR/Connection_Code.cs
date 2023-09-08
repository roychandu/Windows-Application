using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PADIR
{
    internal class Connection_Code
    {
        private static string s = "Data Source=***********;Initial Catalog=*********;User ID=**********;Password=*********";
        public static SqlConnection con = new SqlConnection(s);

        // Insert Nurse Details

        public void addNurse(string First,string Middle, string Last, string Gender, string DOB, string Nationality,
            string Address1, string Address2, string Registration, string Password, string EmployeeStatus,
            string EmployeeArea)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertNurseDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@First", First);
                cmd.Parameters.AddWithValue("@Middle", Middle);
                cmd.Parameters.AddWithValue("@Last", Last);
                cmd.Parameters.AddWithValue("@Gender", Gender);
                cmd.Parameters.AddWithValue("@DOB", DOB);
                cmd.Parameters.AddWithValue("@Nationality", Nationality);
                cmd.Parameters.AddWithValue("@Address1", Address1);
                cmd.Parameters.AddWithValue("@Address2", Address2);
                cmd.Parameters.AddWithValue("@Registration", Registration);
                cmd.Parameters.AddWithValue("@Password", Password);
                cmd.Parameters.AddWithValue("@EmployeeStatus", EmployeeStatus);
                cmd.Parameters.AddWithValue("@EmployeeArea", EmployeeArea);

                con.Open();
                int x = cmd.ExecuteNonQuery();
                if (x > 0)
                {
                    MessageBox.Show("Successfully added into the database");
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // Insert Patient Details

        public void addPatient(string First, string Middle, string Last, string Gender, string DOB, string Nationality,
            string patientContact,string Address1, string Address2, string RegistrationDate, string RegistrationTime,
            string RegistrationNumber, string Issue ,string MedicalBackGround, string EmergencyFirst, string EmergencyLast, string EmergencyRelationship,
            string EmergencyNumber, string EmergencyAddress)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertPatientDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@First", First);
                cmd.Parameters.AddWithValue("@Middle", Middle);
                cmd.Parameters.AddWithValue("@Last", Last);
                cmd.Parameters.AddWithValue("@Gender", Gender);
                cmd.Parameters.AddWithValue("@DOB", DOB);
                cmd.Parameters.AddWithValue("@Nationality", Nationality);
                cmd.Parameters.AddWithValue("@patient_Contact", patientContact);
                cmd.Parameters.AddWithValue("@Address1", Address1);
                cmd.Parameters.AddWithValue("@Address2", Address2);
                cmd.Parameters.AddWithValue("@RegistrationDate", RegistrationDate);
                cmd.Parameters.AddWithValue("@RegistrationTime", RegistrationTime);
                cmd.Parameters.AddWithValue("@RegistrationNumber", RegistrationNumber);
                cmd.Parameters.AddWithValue("@patient_Issue", Issue);
                cmd.Parameters.AddWithValue("@MedicalBackGround", MedicalBackGround);
                cmd.Parameters.AddWithValue("@EmergencyFirst", EmergencyFirst);
                cmd.Parameters.AddWithValue("@EmergencyLast", EmergencyLast);
                cmd.Parameters.AddWithValue("@EmergencyRelationship", EmergencyRelationship);
                cmd.Parameters.AddWithValue("@EmergencyNumber", EmergencyNumber);
                cmd.Parameters.AddWithValue("@EmergencyAddress", EmergencyAddress);
               

                con.Open();
                int x = cmd.ExecuteNonQuery();
                if (x > 0)
                {
                    MessageBox.Show("Successfully added into the database");
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


            // Insert Doctor Details

            
           
    }

}

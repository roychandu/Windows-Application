using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PADIR
{
    public partial class PatientSensors : Form
    {
        string patient;
        SqlConnection con = new SqlConnection("Data Source=************;Initial Catalog=*************;User ID=***********;Password=***********");
        bool verify = false;
        public PatientSensors(string patient)
        {
            InitializeComponent();
            this.patient = patient;
        }

        private void PatientSensors_Load(object sender, EventArgs e)
        {
            RegistrationTXT.Text = patient;
        }

        private void RegistrationTXT_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void RegistrationTXT_Enter(object sender, EventArgs e)
        {
            if(RegistrationTXT.Text == "Registration Number")
            {
                RegistrationTXT.Text = "";
                RegistrationTXT.ForeColor = Color.Black;
            }
        }

        private void RegistrationTXT_Leave(object sender, EventArgs e)
        {
            if( RegistrationTXT.Text == "")
            {
                RegistrationTXT.Text = "Registration Number";
                RegistrationTXT.ForeColor = Color.Gray;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashBoard n = new DashBoard();
            n.ShowDialog();
        }

        private void DOBTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void PatientNameTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void GenderTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void IssueTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void VerifyBT_Click(object sender, EventArgs e)
        {
            try
            {               
                SqlCommand cmd = new SqlCommand("select First, Middle, Last, DOB, Gender, patient_Issue from Patient_Details where RegistrationNumber = @RegNumber ", con);
                con.Open();
                cmd.Parameters.AddWithValue("RegNumber", RegistrationTXT.Text);
                SqlDataReader reader1;
                reader1 = cmd.ExecuteReader();
                if (reader1.Read())
                {
                    string first = reader1["First"].ToString();
                    string middle = reader1["Middle"].ToString();
                    string last = reader1["Last"].ToString();
                    string full_name = first +" "+ middle + " " + last;
                    PatientNameTXT.Text = full_name;
                    DOBTXT.Text = reader1["DOB"].ToString();
                    GenderTXT.Text = reader1["Gender"].ToString();
                    IssueTXT.Text = reader1["patient_Issue"].ToString();

                    verify = true;
                }
                else
                {
                    MessageBox.Show(" Patient is Not Registered !!");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CheckBT_Click(object sender, EventArgs e)
        {
            if (verify)
            {
                if (CheckBT.Enabled)
                {
                    //UpdateSensorData();
                    MessageBox.Show("Sensors are not connected!!");
                }
            }
            else
            {
                MessageBox.Show("First Enter Valib Patient Registered Number !!");
            }
        }
        private void UpdateSensorData()
        {


            Random BPT = new Random();
            double minValue = 96.0;
            double maxValue = 96.9;
            double a = minValue + (BPT.NextDouble() * (maxValue - minValue) + 0.5);


            Random Sweat = new Random();
            double minValue1 = 350.0;
            double maxValue2 = 380.0;
            double b = minValue1 + (Sweat.NextDouble() * (maxValue2 - minValue1) + 0.5);

            Random Temp = new Random();
            double minValue3 = 96.0;
            double maxValue4 = 96.9;
            double c = minValue3 + (Temp.NextDouble() * (maxValue4 - minValue3) + 0.5);

            Random x = new Random();
            double minx = 96.0;
            double maxx = 96.9;
            double d = minx + (Temp.NextDouble() * (maxx - minx) + 0.5);

            Random y = new Random();
            double miny = 96.0;
            double maxy = 96.9;
            double e = miny + (Temp.NextDouble() * (maxy - miny) + 0.5);

            Sensor1TXT.Text = "Sensor Reading: " + a + "  gsr";
            Sensor2TXT.Text = "Sensor Reading: " + b + "  F";
            Sensor3TXT.Text = "Sensor Reading: " + c + "  Spo2";
            Sensor4TXT.Text = "Sensor Reading: " + d + "  Spo2";
            Sensor5TXT.Text = "Sensor Reading: " + e + "  Spo2";
        }

        private void SaveBT_Click(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            try
            {
                if (MessageBox.Show("Are you sure ", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK);
                {
                    SqlCommand cmd = new SqlCommand("Insert INTO Sensors_Details(Registration_No, Patient_Name, DOB, Patient_Issue, Check_DateTime, Sensor1, Sensor2, Sensor3, Sensor4, Sensor5)" +
                        "VALUES(@Reg, @pname, @Dob, @pissue, @checkTime, @s1, @s2, @s3, @s4, @s5)", con);
                    cmd.Parameters.AddWithValue("@Reg", RegistrationTXT.Text);
                    cmd.Parameters.AddWithValue("@pname", PatientNameTXT.Text);
                    cmd.Parameters.AddWithValue("@Dob", DOBTXT.Text);
                    cmd.Parameters.AddWithValue("@pissue", IssueTXT.Text);
                    cmd.Parameters.AddWithValue("@checkTime", currentTime);
                    cmd.Parameters.AddWithValue("@s1", Sensor1TXT.Text);
                    cmd.Parameters.AddWithValue("@s2", Sensor2TXT.Text);
                    cmd.Parameters.AddWithValue("@s3", Sensor3TXT.Text);
                    cmd.Parameters.AddWithValue("@s4", Sensor4TXT.Text);
                    cmd.Parameters.AddWithValue("@s5", Sensor5TXT.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data has been successfully saved !");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

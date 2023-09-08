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
    public partial class ActiveInactivePatient : Form
    {
        string reg;
        SqlConnection con = new SqlConnection("Data Source=************;Initial Catalog=*************;User ID=***********;Password=***********");
        public ActiveInactivePatient(string reg)
        {
            InitializeComponent();
            this.reg = reg;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ActiveInactivePatient_Load(object sender, EventArgs e)
        {
            RegistrationNumberTXT.Text = reg;

            // Fatch data

            try
            {

                SqlCommand cmd = new SqlCommand("select * from Patient_Details where RegistrationNumber = @reg ", con);
                con.Open();
                cmd.Parameters.AddWithValue("reg", RegistrationNumberTXT.Text);
                SqlDataReader reader1;
                reader1 = cmd.ExecuteReader();
                if (reader1.Read())
                {
                    FirstTXT.Text = reader1["First"].ToString();
                    MiddleTXT.Text = reader1["Middle"].ToString();
                    LastTXT.Text = reader1["Last"].ToString();
                    GenderTXT.Text = reader1["Gender"].ToString();
                    DOBTXT.Text = reader1["DOB"].ToString();
                    NationalityTXT.Text = reader1["Nationality"].ToString();
                    Address1TXT.Text = reader1["Address1"].ToString();
                    Address2TXT.Text = reader1["Address2"].ToString();
                    HealthIssueTXT.Text = reader1["MedicalBackground"].ToString();
                    PatientHistoryTXT.Text = reader1["patient_Issue"].ToString();
                    EmergencyFirstTXT.Text = reader1["EmergencyFirst"].ToString();
                    EmergencyLastTXT.Text = reader1["EmergencyLast"].ToString();
                    RelationshipTXT.Text = reader1["EmergencyRelationShip"].ToString();
                    EmerContactTXT.Text = reader1["EmergencyNumber"].ToString();
                    EmerAddressTXT.Text = reader1["EmergencyAddress"].ToString();
                    ContactTXT.Text = reader1["patient_Contact"].ToString();
                    RegistrationTime.Text = reader1["RegistrationTime"].ToString();
                    RegistrationDate.Text = reader1["RegistrationDate"].ToString();

                }
                else
                {
                    MessageBox.Show("No Data found");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void DischargedData()
        {
            try
            {
                if (MessageBox.Show("Are you sure this Patient is Discharged ", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK) ;
                {
                    SqlCommand cmd = new SqlCommand("Insert INTO Discharge_Patient(First, Middle, Last, Gender, DOB, Nationality, Address1, Address2, RegistrationDate," +
                        "RegistrationTime, RegistrationNumber, MedicalBackground, EmergencyFirst, EmergencyLast, EmergencyRelationShip, EmergencyNumber, EmergencyAddress, Patient_Contact, Patient_Issue, DischargeDate, DischargeTime)VALUES" +
                        "(@first, @middle, @last, @gender, @dob, @nationality, @address1, @address2, @regdate, @regtime, @regnum, @background, @emerfirst, @emerlast, @emerRelation, @emernum, @emeradd, @patientnum, @patientissue, @dischargedate, @dischargetime)", con);
                    cmd.Parameters.AddWithValue("@first", FirstTXT.Text);
                    cmd.Parameters.AddWithValue("@middle", MiddleTXT.Text);
                    cmd.Parameters.AddWithValue("@last", LastTXT.Text);
                    cmd.Parameters.AddWithValue("@gender", GenderTXT.Text);
                    cmd.Parameters.AddWithValue("@dob", DOBTXT.Text);
                    cmd.Parameters.AddWithValue("@nationality", NationalityTXT.Text);
                    cmd.Parameters.AddWithValue("@address1", Address1TXT.Text);
                    cmd.Parameters.AddWithValue("@address2", Address2TXT.Text);
                    cmd.Parameters.AddWithValue("@regdate", RegistrationDate.Text);
                    cmd.Parameters.AddWithValue("@regtime", RegistrationTime.Text);
                    cmd.Parameters.AddWithValue("@regnum", RegistrationNumberTXT.Text);
                    cmd.Parameters.AddWithValue("@background", HealthIssueTXT.Text);
                    cmd.Parameters.AddWithValue("@emerfirst", EmergencyFirstTXT.Text);
                    cmd.Parameters.AddWithValue("@emerlast", EmergencyLastTXT.Text);
                    cmd.Parameters.AddWithValue("@emerRelation", RelationshipTXT.Text);
                    cmd.Parameters.AddWithValue("@emernum", EmerContactTXT.Text);
                    cmd.Parameters.AddWithValue("@emeradd", EmerAddressTXT.Text);
                    cmd.Parameters.AddWithValue("@patientnum", ContactTXT.Text);
                    cmd.Parameters.AddWithValue("@patientissue", PatientHistoryTXT.Text);
                    cmd.Parameters.AddWithValue("@dischargedate", dateTimePicker3.Text);
                    cmd.Parameters.AddWithValue("@dischargetime", dateTimePicker4.Text);


                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show(FirstTXT.Text + " are discharged !!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DeleteData()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("Delete from Patient_Details where RegistrationNumber = @reg ", con);
                con.Open();
                cmd.Parameters.AddWithValue("@reg", reg);
                int x = cmd.ExecuteNonQuery();
                
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void HealthIssueTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void DischargeBT_Click(object sender, EventArgs e)
        {
            DischargedData();
            DeleteData();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashBoard d = new DashBoard();
            d.ShowDialog();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

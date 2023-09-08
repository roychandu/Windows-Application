using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PADIR
{
    public partial class SensorHistory : Form
    {
        SqlConnection con = new SqlConnection("Data Source=************;Initial Catalog=*************;User ID=***********;Password=***********");
        public SensorHistory()
        {
            InitializeComponent();
        }

        private void GetDataGrid(string reg)
        {
            con.Open();
            try
            {
                string Query = "Select Sensor1, Sensor2, Sensor3, Sensor4, Sensor5 From Sensors_Details where Registration_No = @reg";
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@reg", RegistrationTXT.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
        }

        private void GetDateText(string reg)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("select Patient_Name, DOB, Patient_Issue, Check_DateTime from Sensors_Details where Registration_No = @reg ", con);
                con.Open();
                cmd.Parameters.AddWithValue("@reg", RegistrationTXT.Text);
                // cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader1;
                reader1 = cmd.ExecuteReader();
                if (reader1.Read())
                {
                    PatientNameTXT.Text = reader1["Patient_Name"].ToString();
                    DOBTXT.Text = reader1["DOB"].ToString();
                    PatientIssueTXT.Text = reader1["Patient_Issue"].ToString();
                    CheckDateTXT.Text = reader1["Check_DateTime"].ToString();
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

        private void button1_Click(object sender, EventArgs e)
        {
            string reg = RegistrationTXT.Text;
            GetDataGrid(reg);
            GetDateText(reg);
        }

        private void SensorHistory_Load(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashBoard d = new DashBoard();
            d.ShowDialog();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

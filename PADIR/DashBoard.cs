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
    public partial class DashBoard : Form
    {
        SqlConnection con = new SqlConnection("Data Source=**********;Initial Catalog=************;User ID=**********;Password=**********");
        public DashBoard()
        {
            InitializeComponent();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void GetData()
        {
            con.Open();
            try
            {
                string Query = "Select RegistrationNumber, RegistrationDate, RegistrationTime, First, Middle, Last From Patient_Details";
                SqlCommand cmd = new SqlCommand(Query, con);
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Check")
            {
                string Patient;
                Patient = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["RegNumberCL"].Value);

                this.Hide();
                PatientSensors p = new PatientSensors(Patient);
                p.ShowDialog();
            }
            else if(dataGridView1.Columns[e.ColumnIndex].HeaderText == "Discharged")
            {
                string Reg;
                Reg = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["RegNumberCL"].Value);

                this.Hide();
                ActiveInactivePatient d = new ActiveInactivePatient(Reg);
                d.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DischargedPatient s = new DischargedPatient();
            s.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientRegistration p = new PatientRegistration();
            p.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            SensorHistory d = new SensorHistory();
            d.ShowDialog();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            NurseLogin n = new NurseLogin();
            n.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

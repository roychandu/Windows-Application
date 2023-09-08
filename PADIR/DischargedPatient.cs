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
    public partial class DischargedPatient : Form
    {
        SqlConnection con = new SqlConnection("Data Source=************;Initial Catalog=*************;User ID=***********;Password=***********");
        public DischargedPatient()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Sexy_Load(object sender, EventArgs e)
        {
            

            GetDischargePatientData();
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            DashBoard d = new DashBoard();
            d.ShowDialog();
        }

        



        // Discharge Patient Detiles
        private void GetDischargePatientData()
        {
            con.Open();
            try
            {
                string Query = "Select First, Middle, Last, RegistrationNumber, RegistrationDate, RegistrationTime, DischargeDate, DischargeTime From Discharge_Patient";
                SqlCommand cmd = new SqlCommand(Query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView2.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

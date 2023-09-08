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
    public partial class NurseResetPassword : Form
    {
        bool verify;
        public NurseResetPassword()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NurseResetPassword_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (verify)
            {
                if(NewPassTXT.Text == ConfirmpassTXT.Text)
                {
                    SqlConnection con = new SqlConnection("Data Source=************;Initial Catalog=*************;User ID=***********;Password=***********");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Update Nurse_Details set Password = @pass where Registration = @Reg", con);
                    cmd.Parameters.AddWithValue("@pass", ConfirmpassTXT.Text);
                    cmd.Parameters.AddWithValue("@Reg", RegistrationTXT.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfully Update !");

                    this.Hide();
                    NurseLogin d = new NurseLogin();
                    d.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Password is Not Match !!");
                    NewPassTXT.Clear();
                    ConfirmpassTXT.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please Enter Correct Registration Number !!");
            }
        }

        private void VerifyBT_Click(object sender, EventArgs e)
        {
            if (RegistrationTXT.Text == "")
            {
                MessageBox.Show("Enter Registration Number");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=************;Initial Catalog=*************;User ID=***********;Password=***********");
                    SqlCommand cmd = new SqlCommand("select * from Nurse_Details where Registration = @Reg", con);
                    cmd.Parameters.AddWithValue("@Reg", RegistrationTXT.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show(" Verified Registration Number !");
                        verify = true;
                    }
                    else
                    {
                        MessageBox.Show(" Registration Number is invalid !");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" " + ex);
                }
            }
        }

        private void ShowpassCB_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowpassCB.Checked == false)
            {
                NewPassTXT.UseSystemPasswordChar = true;
                ConfirmpassTXT.UseSystemPasswordChar = true;
            }
            else
            {
                NewPassTXT.UseSystemPasswordChar = false;
                ConfirmpassTXT.UseSystemPasswordChar = false;
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            NurseLogin n = new NurseLogin();
            n.ShowDialog();
        }
    }
}

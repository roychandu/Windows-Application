using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
    public partial class NurseLogin : Form
    {

        public NurseLogin()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NurseLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (RegistrationTXT.Text == "")
            {
                MessageBox.Show("Enter Registration Number !!");
            }
            else if (PasswordTXT.Text == "")
            {
                MessageBox.Show("Enter password");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=************;Initial Catalog=*************;User ID=***********;Password=***********");
                    SqlCommand cmd = new SqlCommand("select * from Nurse_Details where Registration = @Registration and Password = @password", con);
                    cmd.Parameters.AddWithValue("@Registration", RegistrationTXT.Text);
                    cmd.Parameters.AddWithValue("@password", PasswordTXT.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Login successfull !");
                        this.Hide();
                        DashBoard d = new DashBoard();
                        d.ShowDialog();
                        
                    }
                    else
                    {
                        MessageBox.Show("Username and password invalid !");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" " + ex);
                }
            }
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            NurseRegistration r = new NurseRegistration();
            r.ShowDialog();
        }

        private void ShowpassCB_CheckedChanged(object sender, EventArgs e)
        {
            if(ShowpassCB.Checked == false)
            {
                PasswordTXT.UseSystemPasswordChar = true;
            }
            else
            {
                PasswordTXT.UseSystemPasswordChar = false;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            NurseResetPassword  r = new NurseResetPassword();
            r.ShowDialog();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
        }
    }
}

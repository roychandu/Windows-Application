using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PADIR
{
    public partial class NurseRegistration : Form
    {
        public NurseRegistration()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NurseRegistration_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check Password 
            if (PasswordTXT.Text == ConfirmPassTXT.Text)
            {

                Connection_Code obj = new Connection_Code();
                string gender = MaleRB.Checked ? Convert.ToString("Male") : FemaleRB.Checked ?
                Convert.ToString("Female") : Convert.ToString("Transgender");

                string status = FulltimeRB.Checked ? Convert.ToString("Full Time") :
                    ParttimeRB.Checked ? Convert.ToString("Part Time") : StudyingRB.Checked ?
                    Convert.ToString("Studying") : Convert.ToString("Other");

                string Area = GovermentRB.Checked ? Convert.ToString("Goverment") :
                    PrivateRB.Checked ? Convert.ToString("Private") : NGORB.Checked ?
                    Convert.ToString("NGO's") : Convert.ToString("Other");

                obj.addNurse(FirstTXT.Text, MiddleTXT.Text, LastTXT.Text, gender, dateTimePicker1.Text,
                    NationalityComb.Text, Address1TXT.Text, Address2TXT.Text, RegistrationNoTXT.Text,
                    PasswordTXT.Text, status, Area);

                this.Hide();
                NurseLogin n = new NurseLogin();
                n.ShowDialog();
            }
            else
            {
                MessageBox.Show("Password is not matched !");
                PasswordTXT.Clear();
                ConfirmPassTXT.Clear();
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            NurseLogin n = new NurseLogin();
            n.ShowDialog();
        }

        private void ShowpassCB_CheckedChanged(object sender, EventArgs e)
        {
            if(ShowpassCB.Checked == false)
            {
                ConfirmPassTXT.UseSystemPasswordChar = true;
                PasswordTXT.UseSystemPasswordChar = true;
            }
            else
            {
                ConfirmPassTXT.UseSystemPasswordChar = false;
                PasswordTXT.UseSystemPasswordChar = false;
            }
        }

        private void FirstTXT_TextChanged(object sender, EventArgs e)
        {
            if (FirstTXT.Text == "")
            {
                //label4.Visible = true;
            }
            else
            {
                Regex abc = new Regex("^[A-za-z]+$");
                if (abc.Match(FirstTXT.Text).Success)
                {
                    //label4.Visible = false;
                }
                else
                {
                    MessageBox.Show("Only Alphabetic Values are Vaild !");
                }
            }
        }

        private void MiddleTXT_TextChanged(object sender, EventArgs e)
        {
            if (MiddleTXT.Text == "")
            {
                //label4.Visible = true;
            }
            else
            {
                Regex abc = new Regex("^[A-za-z]+$");
                if (abc.Match(MiddleTXT.Text).Success)
                {
                    //label4.Visible = false;
                }
                else
                {
                    MessageBox.Show("Only Alphabetic Values are Vaild !");
                }

            }
        }

        private void LastTXT_TextChanged(object sender, EventArgs e)
        {
            if (LastTXT.Text == "")
            {
                //label4.Visible = true;
            }
            else
            {
                Regex abc = new Regex("^[A-za-z]+$");
                if (abc.Match(LastTXT.Text).Success)
                {
                    //label4.Visible = false;
                }
                else
                {
                    MessageBox.Show("Only Alphabetic Values are Vaild !");
                }

            }
        }

        private void PasswordTXT_Validating(object sender, CancelEventArgs e)
        {
            string password = PasswordTXT.Text;

            if (password.Length < 8)
            {
                e.Cancel = true;
                MessageBox.Show("Password should have at least 8 characters.");
                PasswordTXT.Clear();
            }
            else if (!password.Any(char.IsDigit) || !password.Any(char.IsLetter))
            {
                e.Cancel = true;
                MessageBox.Show("Password should have both letters and digits.");
                PasswordTXT.Clear();
            }
        }

        private void ConfirmPassTXT_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ConfirmPassTXT_Validating(object sender, CancelEventArgs e)
        {
            string Confirmpassword = PasswordTXT.Text;

            if (Confirmpassword.Length < 8)
            {
                e.Cancel = true;
                MessageBox.Show("Password should have at least 8 characters.");
                PasswordTXT.Clear();
            }
            else if (!Confirmpassword.Any(char.IsDigit) || !Confirmpassword.Any(char.IsLetter))
            {
                e.Cancel = true;
                MessageBox.Show("Password should have both letters and digits.");
                PasswordTXT.Clear();
            }
        }
    }
}

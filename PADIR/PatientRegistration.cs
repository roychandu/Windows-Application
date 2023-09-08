using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Taskbar;
namespace PADIR
{
    public partial class PatientRegistration : Form
    {
        
        public PatientRegistration()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PatientRegistration_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection_Code obj = new Connection_Code();

            string Gender = MelaRB.Checked ? Convert.ToString("Male") : FemaleRB.Checked ?
                        Convert.ToString("Female") : Convert.ToString("Transgender");

            obj.addPatient(FirstTXT.Text, MiddleTXT.Text, LastTXT.Text, Gender, dateTimePicker1.Text, NationalityComb.Text, PatientConTXT.Text,
                Address1TXT.Text, Address2TXT.Text, dateTimePicker2.Text, dateTimePicker3.Text, RegistrationNoTXT.Text, IssueTXT.Text,
                MedicalBackgroundTXT.Text, EmerFirstTXt.Text, EmerLastTXT.Text, EmerRelationTXT.Text, EmerContactTXt.Text,
                EmerAddressTXT.Text);

            this.Hide();
            DashBoard d = new DashBoard();
            d.ShowDialog();

           
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashBoard n = new DashBoard();
            n.ShowDialog();
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
                    FirstTXT.Clear();
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
                    MiddleTXT.Clear();
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
                    LastTXT.Clear();
                }

            }
        }

        private void Address1TXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistrationNoTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmerFirstTXt_TextChanged(object sender, EventArgs e)
        {
            if (EmerFirstTXt.Text == "")
            {
                //label4.Visible = true;
            }
            else
            {
                Regex abc = new Regex("^[A-za-z]+$");
                if (abc.Match(EmerFirstTXt.Text).Success)
                {
                    //label4.Visible = false;
                }
                else
                {
                    MessageBox.Show("Only Alphabetic Values are Vaild !");
                    EmerFirstTXt.Clear();
                }

            }
        }

        private void EmerLastTXT_TextChanged(object sender, EventArgs e)
        {
            if (EmerLastTXT.Text == "")
            {
                //label4.Visible = true;
            }
            else
            {
                Regex abc = new Regex("^[A-za-z]+$");
                if (abc.Match(EmerLastTXT.Text).Success)
                {
                    //label4.Visible = false;
                }
                else
                {
                    MessageBox.Show("Only Alphabetic Values are Vaild !");
                    EmerLastTXT.Clear();
                }

            }
        }

        private void EmerRelationTXT_TextChanged(object sender, EventArgs e)
        {
            if (EmerRelationTXT.Text == "")
            {
                //label4.Visible = true;
            }
            else
            {
                Regex abc = new Regex("^[A-za-z]+$");
                if (abc.Match(EmerRelationTXT.Text).Success)
                {
                    //label4.Visible = false;
                }
                else
                {
                    MessageBox.Show("Only Alphabetic Values are Vaild !");
                    EmerRelationTXT.Clear();
                }

            }
        }

        private void EmerContactTXt_TextChanged(object sender, EventArgs e)
        {
            if (EmerContactTXt.Text == "")
            {
                //label4.Visible = true;
            }
            else
            {
                Regex abc = new Regex("^[0-9]+$");
                if (abc.Match(EmerContactTXt.Text).Success)
                {
                    //label4.Visible = false;
                }
                else
                {
                    MessageBox.Show("Only Numeric Values are Vaild !");
                    EmerContactTXt.Clear();
                }

            }
        }

        private void EmerContactTXt_Validating(object sender, CancelEventArgs e)
        {
            if (EmerContactTXt.Text.Count(char.IsDigit) < 10)
            {
                e.Cancel = true;
                MessageBox.Show("Phone number should have at least 10 digits.");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PatientConTXT_TextChanged(object sender, EventArgs e)
        {
            if (PatientConTXT.Text == "")
            {
                //label4.Visible = true;
            }
            else
            {
                Regex abc = new Regex("^[0-9]+$");
                if (abc.Match(PatientConTXT.Text).Success)
                {
                    //label4.Visible = false;
                }
                else
                {
                    MessageBox.Show("Only Numeric Values are Vaild !");
                    PatientConTXT.Clear();
                }

            }
        }

        private void PatientConTXT_Validating(object sender, CancelEventArgs e)
        {
            if (PatientConTXT.Text.Count(char.IsDigit) < 10)
            {
                e.Cancel = true;
                MessageBox.Show("Phone number should have at least 10 digits.");
            }
        }
    }
    
}

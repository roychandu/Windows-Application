namespace PADIR
{
    partial class PatientSensors
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.VerifyBT = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.IssueTXT = new System.Windows.Forms.TextBox();
            this.GenderTXT = new System.Windows.Forms.TextBox();
            this.DOBTXT = new System.Windows.Forms.TextBox();
            this.PatientNameTXT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SaveBT = new System.Windows.Forms.Button();
            this.CheckBT = new System.Windows.Forms.Button();
            this.RegistrationTXT = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Sensor5TXT = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Sensor4TXT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Sensor3TXT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Sensor2TXT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Sensor1TXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.VideoBT = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // VerifyBT
            // 
            this.VerifyBT.BackColor = System.Drawing.Color.Transparent;
            this.VerifyBT.FlatAppearance.BorderSize = 3;
            this.VerifyBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VerifyBT.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerifyBT.Location = new System.Drawing.Point(306, 115);
            this.VerifyBT.Name = "VerifyBT";
            this.VerifyBT.Size = new System.Drawing.Size(132, 39);
            this.VerifyBT.TabIndex = 29;
            this.VerifyBT.Text = "Verify";
            this.VerifyBT.UseVisualStyleBackColor = false;
            this.VerifyBT.Click += new System.EventHandler(this.VerifyBT_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.IssueTXT);
            this.panel2.Controls.Add(this.GenderTXT);
            this.panel2.Controls.Add(this.DOBTXT);
            this.panel2.Controls.Add(this.PatientNameTXT);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(-8, 163);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(357, 420);
            this.panel2.TabIndex = 27;
            // 
            // IssueTXT
            // 
            this.IssueTXT.Enabled = false;
            this.IssueTXT.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueTXT.Location = new System.Drawing.Point(14, 282);
            this.IssueTXT.Multiline = true;
            this.IssueTXT.Name = "IssueTXT";
            this.IssueTXT.Size = new System.Drawing.Size(324, 112);
            this.IssueTXT.TabIndex = 7;
            this.IssueTXT.TextChanged += new System.EventHandler(this.IssueTXT_TextChanged);
            // 
            // GenderTXT
            // 
            this.GenderTXT.Enabled = false;
            this.GenderTXT.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderTXT.Location = new System.Drawing.Point(14, 201);
            this.GenderTXT.Name = "GenderTXT";
            this.GenderTXT.Size = new System.Drawing.Size(324, 33);
            this.GenderTXT.TabIndex = 6;
            this.GenderTXT.TextChanged += new System.EventHandler(this.GenderTXT_TextChanged);
            // 
            // DOBTXT
            // 
            this.DOBTXT.Enabled = false;
            this.DOBTXT.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOBTXT.Location = new System.Drawing.Point(14, 127);
            this.DOBTXT.Name = "DOBTXT";
            this.DOBTXT.Size = new System.Drawing.Size(324, 33);
            this.DOBTXT.TabIndex = 5;
            this.DOBTXT.TextChanged += new System.EventHandler(this.DOBTXT_TextChanged);
            // 
            // PatientNameTXT
            // 
            this.PatientNameTXT.Enabled = false;
            this.PatientNameTXT.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientNameTXT.Location = new System.Drawing.Point(14, 48);
            this.PatientNameTXT.Name = "PatientNameTXT";
            this.PatientNameTXT.Size = new System.Drawing.Size(324, 33);
            this.PatientNameTXT.TabIndex = 4;
            this.PatientNameTXT.TextChanged += new System.EventHandler(this.PatientNameTXT_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "Patient Issue";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Date of Birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Patient Name";
            // 
            // SaveBT
            // 
            this.SaveBT.BackColor = System.Drawing.Color.Transparent;
            this.SaveBT.FlatAppearance.BorderSize = 5;
            this.SaveBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBT.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBT.Location = new System.Drawing.Point(162, 640);
            this.SaveBT.Name = "SaveBT";
            this.SaveBT.Size = new System.Drawing.Size(136, 70);
            this.SaveBT.TabIndex = 25;
            this.SaveBT.Text = "Save Detail";
            this.SaveBT.UseVisualStyleBackColor = false;
            this.SaveBT.Click += new System.EventHandler(this.SaveBT_Click);
            // 
            // CheckBT
            // 
            this.CheckBT.BackColor = System.Drawing.Color.Transparent;
            this.CheckBT.FlatAppearance.BorderSize = 5;
            this.CheckBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckBT.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBT.Location = new System.Drawing.Point(727, 640);
            this.CheckBT.Name = "CheckBT";
            this.CheckBT.Size = new System.Drawing.Size(136, 70);
            this.CheckBT.TabIndex = 26;
            this.CheckBT.Text = "Check";
            this.CheckBT.UseVisualStyleBackColor = false;
            this.CheckBT.Click += new System.EventHandler(this.CheckBT_Click);
            // 
            // RegistrationTXT
            // 
            this.RegistrationTXT.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrationTXT.ForeColor = System.Drawing.Color.Gray;
            this.RegistrationTXT.Location = new System.Drawing.Point(5, 120);
            this.RegistrationTXT.Name = "RegistrationTXT";
            this.RegistrationTXT.Size = new System.Drawing.Size(276, 37);
            this.RegistrationTXT.TabIndex = 28;
            this.RegistrationTXT.Text = "Registration Number";
            this.RegistrationTXT.TextChanged += new System.EventHandler(this.RegistrationTXT_TextChanged);
            this.RegistrationTXT.Enter += new System.EventHandler(this.RegistrationTXT_Enter);
            this.RegistrationTXT.Leave += new System.EventHandler(this.RegistrationTXT_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Sensor5TXT);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.Sensor4TXT);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.Sensor3TXT);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Sensor2TXT);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Sensor1TXT);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(355, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 420);
            this.panel1.TabIndex = 23;
            // 
            // Sensor5TXT
            // 
            this.Sensor5TXT.Enabled = false;
            this.Sensor5TXT.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sensor5TXT.Location = new System.Drawing.Point(3, 359);
            this.Sensor5TXT.Name = "Sensor5TXT";
            this.Sensor5TXT.Size = new System.Drawing.Size(581, 33);
            this.Sensor5TXT.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 331);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 26);
            this.label10.TabIndex = 0;
            this.label10.Text = "Sensor 5";
            // 
            // Sensor4TXT
            // 
            this.Sensor4TXT.Enabled = false;
            this.Sensor4TXT.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sensor4TXT.Location = new System.Drawing.Point(3, 280);
            this.Sensor4TXT.Name = "Sensor4TXT";
            this.Sensor4TXT.Size = new System.Drawing.Size(581, 33);
            this.Sensor4TXT.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 26);
            this.label9.TabIndex = 0;
            this.label9.Text = "Sensor 4";
            // 
            // Sensor3TXT
            // 
            this.Sensor3TXT.Enabled = false;
            this.Sensor3TXT.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sensor3TXT.Location = new System.Drawing.Point(3, 199);
            this.Sensor3TXT.Name = "Sensor3TXT";
            this.Sensor3TXT.Size = new System.Drawing.Size(581, 33);
            this.Sensor3TXT.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sensor 3";
            // 
            // Sensor2TXT
            // 
            this.Sensor2TXT.Enabled = false;
            this.Sensor2TXT.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sensor2TXT.Location = new System.Drawing.Point(3, 116);
            this.Sensor2TXT.Name = "Sensor2TXT";
            this.Sensor2TXT.Size = new System.Drawing.Size(581, 33);
            this.Sensor2TXT.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sensor 2";
            // 
            // Sensor1TXT
            // 
            this.Sensor1TXT.Enabled = false;
            this.Sensor1TXT.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sensor1TXT.Location = new System.Drawing.Point(3, 46);
            this.Sensor1TXT.Name = "Sensor1TXT";
            this.Sensor1TXT.Size = new System.Drawing.Size(581, 33);
            this.Sensor1TXT.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sensor 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 57F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, -9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 121);
            this.label1.TabIndex = 20;
            this.label1.Text = "PADIR";
            // 
            // VideoBT
            // 
            this.VideoBT.BackColor = System.Drawing.Color.Transparent;
            this.VideoBT.FlatAppearance.BorderSize = 0;
            this.VideoBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VideoBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoBT.IconChar = FontAwesome.Sharp.IconChar.VideoCamera;
            this.VideoBT.IconColor = System.Drawing.Color.Black;
            this.VideoBT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.VideoBT.IconSize = 70;
            this.VideoBT.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.VideoBT.Location = new System.Drawing.Point(452, 640);
            this.VideoBT.Name = "VideoBT";
            this.VideoBT.Size = new System.Drawing.Size(129, 70);
            this.VideoBT.TabIndex = 24;
            this.VideoBT.Text = "Video Call";
            this.VideoBT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.VideoBT.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.Transparent;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(1004, 2);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(44, 44);
            this.iconButton2.TabIndex = 22;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(954, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(44, 44);
            this.iconButton1.TabIndex = 21;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PADIR.Properties.Resources.PADIR;
            this.pictureBox1.Location = new System.Drawing.Point(5, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // PatientSensors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PADIR.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1050, 733);
            this.Controls.Add(this.VerifyBT);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.SaveBT);
            this.Controls.Add(this.VideoBT);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.CheckBT);
            this.Controls.Add(this.RegistrationTXT);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PatientSensors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PatientSensors";
            this.Load += new System.EventHandler(this.PatientSensors_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button VerifyBT;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox IssueTXT;
        private System.Windows.Forms.TextBox GenderTXT;
        private System.Windows.Forms.TextBox DOBTXT;
        private System.Windows.Forms.TextBox PatientNameTXT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SaveBT;
        private FontAwesome.Sharp.IconButton VideoBT;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Button CheckBT;
        private System.Windows.Forms.TextBox RegistrationTXT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Sensor5TXT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Sensor4TXT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Sensor3TXT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Sensor2TXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Sensor1TXT;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
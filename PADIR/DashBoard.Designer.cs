namespace PADIR
{
    partial class DashBoard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CheckCLBT = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DischargeBTCL = new System.Windows.Forms.DataGridViewButtonColumn();
            this.FirstCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MiddleCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegNumberCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegDateCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegTimeCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(349, 640);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Dischareged Patients";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(36, 640);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(242, 48);
            this.button2.TabIndex = 2;
            this.button2.Text = "New Registration";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(680, 640);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(242, 48);
            this.button3.TabIndex = 3;
            this.button3.Text = "View Sensor History";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PADIR.Properties.Resources.PADIR;
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(906, 1);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(44, 44);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.Transparent;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(856, 1);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(44, 44);
            this.iconButton2.TabIndex = 5;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(609, 89);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nurse Dashboard";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckCLBT,
            this.DischargeBTCL,
            this.FirstCL,
            this.MiddleCL,
            this.LastCL,
            this.RegNumberCL,
            this.RegDateCL,
            this.RegTimeCL});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.LightSkyBlue;
            this.dataGridView1.Location = new System.Drawing.Point(1, 228);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(948, 394);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CheckCLBT
            // 
            this.CheckCLBT.HeaderText = "Check";
            this.CheckCLBT.MinimumWidth = 6;
            this.CheckCLBT.Name = "CheckCLBT";
            this.CheckCLBT.ReadOnly = true;
            this.CheckCLBT.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CheckCLBT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CheckCLBT.Text = "Check Patient";
            this.CheckCLBT.UseColumnTextForButtonValue = true;
            this.CheckCLBT.Width = 125;
            // 
            // DischargeBTCL
            // 
            this.DischargeBTCL.HeaderText = "Discharged";
            this.DischargeBTCL.MinimumWidth = 6;
            this.DischargeBTCL.Name = "DischargeBTCL";
            this.DischargeBTCL.ReadOnly = true;
            this.DischargeBTCL.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DischargeBTCL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DischargeBTCL.Text = "Discharge";
            this.DischargeBTCL.UseColumnTextForButtonValue = true;
            this.DischargeBTCL.Width = 125;
            // 
            // FirstCL
            // 
            this.FirstCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FirstCL.DataPropertyName = "First";
            this.FirstCL.HeaderText = "First Name";
            this.FirstCL.MinimumWidth = 6;
            this.FirstCL.Name = "FirstCL";
            this.FirstCL.ReadOnly = true;
            // 
            // MiddleCL
            // 
            this.MiddleCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MiddleCL.DataPropertyName = "Middle";
            this.MiddleCL.HeaderText = "Middle Name";
            this.MiddleCL.MinimumWidth = 6;
            this.MiddleCL.Name = "MiddleCL";
            this.MiddleCL.ReadOnly = true;
            // 
            // LastCL
            // 
            this.LastCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LastCL.DataPropertyName = "Last";
            this.LastCL.HeaderText = "Last Name";
            this.LastCL.MinimumWidth = 6;
            this.LastCL.Name = "LastCL";
            this.LastCL.ReadOnly = true;
            // 
            // RegNumberCL
            // 
            this.RegNumberCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RegNumberCL.DataPropertyName = "RegistrationNumber";
            this.RegNumberCL.HeaderText = "Registration Number";
            this.RegNumberCL.MinimumWidth = 6;
            this.RegNumberCL.Name = "RegNumberCL";
            this.RegNumberCL.ReadOnly = true;
            // 
            // RegDateCL
            // 
            this.RegDateCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RegDateCL.DataPropertyName = "RegistrationDate";
            this.RegDateCL.HeaderText = "Registration Date";
            this.RegDateCL.MinimumWidth = 6;
            this.RegDateCL.Name = "RegDateCL";
            this.RegDateCL.ReadOnly = true;
            // 
            // RegTimeCL
            // 
            this.RegTimeCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RegTimeCL.DataPropertyName = "RegistrationTime";
            this.RegTimeCL.HeaderText = "Registration Time";
            this.RegTimeCL.MinimumWidth = 6;
            this.RegTimeCL.Name = "RegTimeCL";
            this.RegTimeCL.ReadOnly = true;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PADIR.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(950, 700);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn CheckCLBT;
        private System.Windows.Forms.DataGridViewButtonColumn DischargeBTCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MiddleCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegNumberCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegDateCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegTimeCL;
    }
}
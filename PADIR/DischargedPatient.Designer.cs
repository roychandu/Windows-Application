namespace PADIR
{
    partial class DischargedPatient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.DfirstCl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DmiddleCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DlastCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DregnumberCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistrationDateCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistrationTimeCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisDateCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisTimeCL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PADIR.Properties.Resources.PADIR;
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 57F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 121);
            this.label1.TabIndex = 1;
            this.label1.Text = "PADIR";
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(848, 1);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(44, 44);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.Transparent;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(905, 1);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(44, 44);
            this.iconButton2.TabIndex = 3;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(268, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(408, 56);
            this.label4.TabIndex = 6;
            this.label4.Text = "Discharge Patients";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DfirstCl,
            this.DmiddleCL,
            this.DlastCL,
            this.DregnumberCL,
            this.RegistrationDateCL,
            this.RegistrationTimeCL,
            this.DisDateCL,
            this.DisTimeCL});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView2.GridColor = System.Drawing.Color.LightSkyBlue;
            this.dataGridView2.Location = new System.Drawing.Point(1, 228);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(948, 437);
            this.dataGridView2.TabIndex = 0;
            // 
            // DfirstCl
            // 
            this.DfirstCl.DataPropertyName = "First";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DfirstCl.DefaultCellStyle = dataGridViewCellStyle6;
            this.DfirstCl.HeaderText = "First Name";
            this.DfirstCl.MinimumWidth = 6;
            this.DfirstCl.Name = "DfirstCl";
            this.DfirstCl.ReadOnly = true;
            // 
            // DmiddleCL
            // 
            this.DmiddleCL.DataPropertyName = "Middle";
            this.DmiddleCL.HeaderText = "Middle Name";
            this.DmiddleCL.MinimumWidth = 6;
            this.DmiddleCL.Name = "DmiddleCL";
            this.DmiddleCL.ReadOnly = true;
            // 
            // DlastCL
            // 
            this.DlastCL.DataPropertyName = "Last";
            this.DlastCL.HeaderText = "Last Name";
            this.DlastCL.MinimumWidth = 6;
            this.DlastCL.Name = "DlastCL";
            this.DlastCL.ReadOnly = true;
            // 
            // DregnumberCL
            // 
            this.DregnumberCL.DataPropertyName = "RegistrationNumber";
            this.DregnumberCL.HeaderText = "Registration Number";
            this.DregnumberCL.MinimumWidth = 6;
            this.DregnumberCL.Name = "DregnumberCL";
            this.DregnumberCL.ReadOnly = true;
            // 
            // RegistrationDateCL
            // 
            this.RegistrationDateCL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RegistrationDateCL.DataPropertyName = "RegistrationDate";
            this.RegistrationDateCL.HeaderText = "Registration Date";
            this.RegistrationDateCL.MinimumWidth = 6;
            this.RegistrationDateCL.Name = "RegistrationDateCL";
            this.RegistrationDateCL.ReadOnly = true;
            // 
            // RegistrationTimeCL
            // 
            this.RegistrationTimeCL.DataPropertyName = "RegistrationTime";
            this.RegistrationTimeCL.HeaderText = "Registration Time";
            this.RegistrationTimeCL.MinimumWidth = 6;
            this.RegistrationTimeCL.Name = "RegistrationTimeCL";
            this.RegistrationTimeCL.ReadOnly = true;
            // 
            // DisDateCL
            // 
            this.DisDateCL.DataPropertyName = "DischargeDate";
            this.DisDateCL.HeaderText = "Dischareg Date";
            this.DisDateCL.MinimumWidth = 6;
            this.DisDateCL.Name = "DisDateCL";
            this.DisDateCL.ReadOnly = true;
            // 
            // DisTimeCL
            // 
            this.DisTimeCL.DataPropertyName = "DischargeTime";
            this.DisTimeCL.HeaderText = "Discharge Time";
            this.DisTimeCL.MinimumWidth = 6;
            this.DisTimeCL.Name = "DisTimeCL";
            this.DisTimeCL.ReadOnly = true;
            // 
            // DischargedPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PADIR.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(950, 700);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DischargedPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sexy";
            this.Load += new System.EventHandler(this.Sexy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DfirstCl;
        private System.Windows.Forms.DataGridViewTextBoxColumn DmiddleCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DlastCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DregnumberCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationDateCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationTimeCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisDateCL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisTimeCL;
    }
}
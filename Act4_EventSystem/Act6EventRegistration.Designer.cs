namespace Act4_EventSystem
{
    partial class Act6EventRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Act6EventRegistration));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectStudentCombobox = new System.Windows.Forms.ComboBox();
            this.SelectEventCombobox = new System.Windows.Forms.ComboBox();
            this.SelectStatusCombobox = new System.Windows.Forms.ComboBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.dataGridView1Registration = new System.Windows.Forms.DataGridView();
            this.BackButton = new System.Windows.Forms.Button();
            this.s = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RegistrationDatePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Registration)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Cyan;
            this.label2.Cursor = System.Windows.Forms.Cursors.No;
            this.label2.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(3, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(348, 44);
            this.label2.TabIndex = 18;
            this.label2.Text = "Registration Event";
            // 
            // SelectStudentCombobox
            // 
            this.SelectStudentCombobox.FormattingEnabled = true;
            this.SelectStudentCombobox.Location = new System.Drawing.Point(41, 132);
            this.SelectStudentCombobox.Name = "SelectStudentCombobox";
            this.SelectStudentCombobox.Size = new System.Drawing.Size(121, 24);
            this.SelectStudentCombobox.TabIndex = 19;
            this.SelectStudentCombobox.SelectedIndexChanged += new System.EventHandler(this.SelectStudentCombobox_SelectedIndexChanged);
            // 
            // SelectEventCombobox
            // 
            this.SelectEventCombobox.FormattingEnabled = true;
            this.SelectEventCombobox.Location = new System.Drawing.Point(41, 202);
            this.SelectEventCombobox.Name = "SelectEventCombobox";
            this.SelectEventCombobox.Size = new System.Drawing.Size(121, 24);
            this.SelectEventCombobox.TabIndex = 20;
            this.SelectEventCombobox.SelectedIndexChanged += new System.EventHandler(this.SelectEventCombobox_SelectedIndexChanged);
            // 
            // SelectStatusCombobox
            // 
            this.SelectStatusCombobox.FormattingEnabled = true;
            this.SelectStatusCombobox.Location = new System.Drawing.Point(41, 274);
            this.SelectStatusCombobox.Name = "SelectStatusCombobox";
            this.SelectStatusCombobox.Size = new System.Drawing.Size(121, 24);
            this.SelectStatusCombobox.TabIndex = 21;
            this.SelectStatusCombobox.SelectedIndexChanged += new System.EventHandler(this.SelectStatusCombobox_SelectedIndexChanged);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(266, 373);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(85, 28);
            this.RegisterButton.TabIndex = 22;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // dataGridView1Registration
            // 
            this.dataGridView1Registration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1Registration.Location = new System.Drawing.Point(354, 114);
            this.dataGridView1Registration.Name = "dataGridView1Registration";
            this.dataGridView1Registration.RowHeadersWidth = 51;
            this.dataGridView1Registration.RowTemplate.Height = 24;
            this.dataGridView1Registration.Size = new System.Drawing.Size(409, 204);
            this.dataGridView1Registration.TabIndex = 23;
            this.dataGridView1Registration.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1Registration_CellContentClick);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(376, 373);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(85, 28);
            this.BackButton.TabIndex = 24;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // s
            // 
            this.s.AutoSize = true;
            this.s.Location = new System.Drawing.Point(41, 114);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(96, 16);
            this.s.TabIndex = 25;
            this.s.Text = "Select Student:";
            this.s.Click += new System.EventHandler(this.s_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Select Event:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Status";
            // 
            // RegistrationDatePicker
            // 
            this.RegistrationDatePicker.Location = new System.Drawing.Point(44, 326);
            this.RegistrationDatePicker.Name = "RegistrationDatePicker";
            this.RegistrationDatePicker.Size = new System.Drawing.Size(256, 22);
            this.RegistrationDatePicker.TabIndex = 28;
            this.RegistrationDatePicker.ValueChanged += new System.EventHandler(this.RegistrationDatePicker_ValueChanged);
            // 
            // Act6EventRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RegistrationDatePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.s);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.dataGridView1Registration);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.SelectStatusCombobox);
            this.Controls.Add(this.SelectEventCombobox);
            this.Controls.Add(this.SelectStudentCombobox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Act6EventRegistration";
            this.Text = "Act6EventRegistration";
            this.Load += new System.EventHandler(this.Act6EventRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Registration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SelectStudentCombobox;
        private System.Windows.Forms.ComboBox SelectEventCombobox;
        private System.Windows.Forms.ComboBox SelectStatusCombobox;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.DataGridView dataGridView1Registration;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label s;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker RegistrationDatePicker;
    }
}
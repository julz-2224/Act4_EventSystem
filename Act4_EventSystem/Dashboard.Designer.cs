namespace Act4_EventSystem
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.ReportsButton = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.TotalStudents = new System.Windows.Forms.Label();
            this.TotalEvents = new System.Windows.Forms.Label();
            this.RegistrationTitle = new System.Windows.Forms.Label();
            this.lblStudentsCount = new System.Windows.Forms.Label();
            this.lblEventsCount = new System.Windows.Forms.Label();
            this.lblRegistrationsCount = new System.Windows.Forms.Label();
            this.Usermanagement = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.CreateeventButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnRepGen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportsButton
            // 
            this.ReportsButton.Location = new System.Drawing.Point(36, 126);
            this.ReportsButton.Name = "ReportsButton";
            this.ReportsButton.Size = new System.Drawing.Size(75, 23);
            this.ReportsButton.TabIndex = 0;
            this.ReportsButton.Text = "Reports";
            this.ReportsButton.UseVisualStyleBackColor = true;
            this.ReportsButton.Click += new System.EventHandler(this.ReportsButton_Click);
            // 
            // AboutButton
            // 
            this.AboutButton.Location = new System.Drawing.Point(117, 126);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(75, 23);
            this.AboutButton.TabIndex = 1;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(690, 50);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(75, 23);
            this.LogoutButton.TabIndex = 2;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // TotalStudents
            // 
            this.TotalStudents.AutoSize = true;
            this.TotalStudents.Location = new System.Drawing.Point(33, 180);
            this.TotalStudents.Name = "TotalStudents";
            this.TotalStudents.Size = new System.Drawing.Size(96, 16);
            this.TotalStudents.TabIndex = 4;
            this.TotalStudents.Text = "Total Students:";
            this.TotalStudents.Click += new System.EventHandler(this.label1_Click);
            // 
            // TotalEvents
            // 
            this.TotalEvents.AutoSize = true;
            this.TotalEvents.Location = new System.Drawing.Point(33, 226);
            this.TotalEvents.Name = "TotalEvents";
            this.TotalEvents.Size = new System.Drawing.Size(82, 16);
            this.TotalEvents.TabIndex = 5;
            this.TotalEvents.Text = "Total Events";
            this.TotalEvents.Click += new System.EventHandler(this.label2_Click);
            // 
            // RegistrationTitle
            // 
            this.RegistrationTitle.AutoSize = true;
            this.RegistrationTitle.Location = new System.Drawing.Point(33, 269);
            this.RegistrationTitle.Name = "RegistrationTitle";
            this.RegistrationTitle.Size = new System.Drawing.Size(117, 16);
            this.RegistrationTitle.TabIndex = 6;
            this.RegistrationTitle.Text = "Total Registraions";
            this.RegistrationTitle.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblStudentsCount
            // 
            this.lblStudentsCount.AutoSize = true;
            this.lblStudentsCount.Location = new System.Drawing.Point(152, 180);
            this.lblStudentsCount.Name = "lblStudentsCount";
            this.lblStudentsCount.Size = new System.Drawing.Size(14, 16);
            this.lblStudentsCount.TabIndex = 8;
            this.lblStudentsCount.Text = "0";
            this.lblStudentsCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblStudentsCount.Click += new System.EventHandler(this.lblStudentsCount_Click);
            // 
            // lblEventsCount
            // 
            this.lblEventsCount.AutoSize = true;
            this.lblEventsCount.Location = new System.Drawing.Point(152, 226);
            this.lblEventsCount.Name = "lblEventsCount";
            this.lblEventsCount.Size = new System.Drawing.Size(14, 16);
            this.lblEventsCount.TabIndex = 9;
            this.lblEventsCount.Text = "0";
            this.lblEventsCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblEventsCount.Click += new System.EventHandler(this.lblEventsCount_Click);
            // 
            // lblRegistrationsCount
            // 
            this.lblRegistrationsCount.AutoSize = true;
            this.lblRegistrationsCount.Location = new System.Drawing.Point(152, 269);
            this.lblRegistrationsCount.Name = "lblRegistrationsCount";
            this.lblRegistrationsCount.Size = new System.Drawing.Size(14, 16);
            this.lblRegistrationsCount.TabIndex = 10;
            this.lblRegistrationsCount.Text = "0";
            this.lblRegistrationsCount.Click += new System.EventHandler(this.lblRegistrationsCount_Click);
            // 
            // Usermanagement
            // 
            this.Usermanagement.Location = new System.Drawing.Point(36, 303);
            this.Usermanagement.Name = "Usermanagement";
            this.Usermanagement.Size = new System.Drawing.Size(177, 57);
            this.Usermanagement.TabIndex = 11;
            this.Usermanagement.Text = "User Management";
            this.Usermanagement.UseVisualStyleBackColor = true;
            this.Usermanagement.Click += new System.EventHandler(this.Usermanagement_Click);
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
            this.label2.Location = new System.Drawing.Point(12, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 44);
            this.label2.TabIndex = 18;
            this.label2.Text = "Dashboard:";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(219, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 57);
            this.button1.TabIndex = 19;
            this.button1.Text = "Event Registration";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreateeventButton
            // 
            this.CreateeventButton.Location = new System.Drawing.Point(402, 303);
            this.CreateeventButton.Name = "CreateeventButton";
            this.CreateeventButton.Size = new System.Drawing.Size(177, 57);
            this.CreateeventButton.TabIndex = 20;
            this.CreateeventButton.Text = "Create Event";
            this.CreateeventButton.UseVisualStyleBackColor = true;
            this.CreateeventButton.Click += new System.EventHandler(this.CreateeventButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(585, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 57);
            this.button2.TabIndex = 21;
            this.button2.Text = "Attendance";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRepGen
            // 
            this.btnRepGen.Location = new System.Drawing.Point(36, 366);
            this.btnRepGen.Name = "btnRepGen";
            this.btnRepGen.Size = new System.Drawing.Size(177, 57);
            this.btnRepGen.TabIndex = 22;
            this.btnRepGen.Text = "Reports Generation";
            this.btnRepGen.UseVisualStyleBackColor = true;
            this.btnRepGen.Click += new System.EventHandler(this.btnRepGen_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRepGen);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CreateeventButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Usermanagement);
            this.Controls.Add(this.lblRegistrationsCount);
            this.Controls.Add(this.lblEventsCount);
            this.Controls.Add(this.lblStudentsCount);
            this.Controls.Add(this.RegistrationTitle);
            this.Controls.Add(this.TotalEvents);
            this.Controls.Add(this.TotalStudents);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.ReportsButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Dashboard";
            this.Text = "Student Information System";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReportsButton;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Label TotalStudents;
        private System.Windows.Forms.Label TotalEvents;
        private System.Windows.Forms.Label RegistrationTitle;
        private System.Windows.Forms.Label lblStudentsCount;
        private System.Windows.Forms.Label lblEventsCount;
        private System.Windows.Forms.Label lblRegistrationsCount;
        private System.Windows.Forms.Button Usermanagement;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CreateeventButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnRepGen;
    }
}
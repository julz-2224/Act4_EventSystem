namespace Act4_EventSystem
{
    partial class Act6Attendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Act6Attendance));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectStudent = new System.Windows.Forms.ComboBox();
            this.SelectEvent = new System.Windows.Forms.ComboBox();
            this.Attendance = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.SaveAttendanceButton = new System.Windows.Forms.Button();
            this.AttendaceGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttendaceGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Cyan;
            this.label2.Cursor = System.Windows.Forms.Cursors.No;
            this.label2.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 44);
            this.label2.TabIndex = 20;
            this.label2.Text = "Attendance:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // SelectStudent
            // 
            this.SelectStudent.FormattingEnabled = true;
            this.SelectStudent.Location = new System.Drawing.Point(20, 124);
            this.SelectStudent.Name = "SelectStudent";
            this.SelectStudent.Size = new System.Drawing.Size(121, 24);
            this.SelectStudent.TabIndex = 21;
            this.SelectStudent.SelectedIndexChanged += new System.EventHandler(this.SelectStudent_SelectedIndexChanged);
            // 
            // SelectEvent
            // 
            this.SelectEvent.FormattingEnabled = true;
            this.SelectEvent.Location = new System.Drawing.Point(20, 201);
            this.SelectEvent.Name = "SelectEvent";
            this.SelectEvent.Size = new System.Drawing.Size(121, 24);
            this.SelectEvent.TabIndex = 22;
            this.SelectEvent.SelectedIndexChanged += new System.EventHandler(this.SelectEvent_SelectedIndexChanged);
            // 
            // Attendance
            // 
            this.Attendance.FormattingEnabled = true;
            this.Attendance.Location = new System.Drawing.Point(20, 271);
            this.Attendance.Name = "Attendance";
            this.Attendance.Size = new System.Drawing.Size(121, 24);
            this.Attendance.TabIndex = 23;
            this.Attendance.SelectedIndexChanged += new System.EventHandler(this.Attendance_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Select Student:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Select Event";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Attendance";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(384, 385);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(85, 28);
            this.BackButton.TabIndex = 27;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SaveAttendanceButton
            // 
            this.SaveAttendanceButton.Location = new System.Drawing.Point(265, 390);
            this.SaveAttendanceButton.Name = "SaveAttendanceButton";
            this.SaveAttendanceButton.Size = new System.Drawing.Size(75, 23);
            this.SaveAttendanceButton.TabIndex = 28;
            this.SaveAttendanceButton.Text = "Save Attendance";
            this.SaveAttendanceButton.UseVisualStyleBackColor = true;
            this.SaveAttendanceButton.Click += new System.EventHandler(this.SaveAttendanceButton_Click);
            // 
            // AttendaceGridView1
            // 
            this.AttendaceGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AttendaceGridView1.Location = new System.Drawing.Point(177, 108);
            this.AttendaceGridView1.Name = "AttendaceGridView1";
            this.AttendaceGridView1.RowHeadersWidth = 51;
            this.AttendaceGridView1.RowTemplate.Height = 24;
            this.AttendaceGridView1.Size = new System.Drawing.Size(611, 248);
            this.AttendaceGridView1.TabIndex = 29;
            this.AttendaceGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AttendaceGridView1_CellContentClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(20, 362);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(225, 22);
            this.dateTimePicker1.TabIndex = 30;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Act6Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.AttendaceGridView1);
            this.Controls.Add(this.SaveAttendanceButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Attendance);
            this.Controls.Add(this.SelectEvent);
            this.Controls.Add(this.SelectStudent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Act6Attendance";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Act6Attendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttendaceGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SelectStudent;
        private System.Windows.Forms.ComboBox SelectEvent;
        private System.Windows.Forms.ComboBox Attendance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button SaveAttendanceButton;
        private System.Windows.Forms.DataGridView AttendaceGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}
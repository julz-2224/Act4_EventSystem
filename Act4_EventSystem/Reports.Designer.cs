namespace Act4_EventSystem
{
    partial class Reports
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
            this.RPBackButton = new System.Windows.Forms.Button();
            this.ReportsTitle = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StudentName = new System.Windows.Forms.Label();
            this.StudentEvent = new System.Windows.Forms.Label();
            this.StudentStatus = new System.Windows.Forms.Label();
            this.NameDisplay = new System.Windows.Forms.Label();
            this.EventDisplay = new System.Windows.Forms.Label();
            this.SetStatus = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ConfirmButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // RPBackButton
            // 
            this.RPBackButton.Location = new System.Drawing.Point(357, 358);
            this.RPBackButton.Name = "RPBackButton";
            this.RPBackButton.Size = new System.Drawing.Size(75, 23);
            this.RPBackButton.TabIndex = 0;
            this.RPBackButton.Text = "Back";
            this.RPBackButton.UseVisualStyleBackColor = true;
            this.RPBackButton.Click += new System.EventHandler(this.RPBackButton_Click);
            // 
            // ReportsTitle
            // 
            this.ReportsTitle.AutoSize = true;
            this.ReportsTitle.Location = new System.Drawing.Point(343, 21);
            this.ReportsTitle.Name = "ReportsTitle";
            this.ReportsTitle.Size = new System.Drawing.Size(55, 16);
            this.ReportsTitle.TabIndex = 1;
            this.ReportsTitle.Text = "Reports";
            this.ReportsTitle.Click += new System.EventHandler(this.ReportsTitle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(215, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(316, 100);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(368, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Student ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // StudentName
            // 
            this.StudentName.AutoSize = true;
            this.StudentName.Location = new System.Drawing.Point(212, 162);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(0, 16);
            this.StudentName.TabIndex = 5;
            // 
            // StudentEvent
            // 
            this.StudentEvent.AutoSize = true;
            this.StudentEvent.Location = new System.Drawing.Point(354, 162);
            this.StudentEvent.Name = "StudentEvent";
            this.StudentEvent.Size = new System.Drawing.Size(0, 16);
            this.StudentEvent.TabIndex = 6;
            // 
            // StudentStatus
            // 
            this.StudentStatus.AutoSize = true;
            this.StudentStatus.Location = new System.Drawing.Point(487, 162);
            this.StudentStatus.Name = "StudentStatus";
            this.StudentStatus.Size = new System.Drawing.Size(0, 16);
            this.StudentStatus.TabIndex = 7;
            // 
            // NameDisplay
            // 
            this.NameDisplay.AutoSize = true;
            this.NameDisplay.Location = new System.Drawing.Point(212, 198);
            this.NameDisplay.Name = "NameDisplay";
            this.NameDisplay.Size = new System.Drawing.Size(0, 16);
            this.NameDisplay.TabIndex = 9;
            this.NameDisplay.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.NameDisplay.Click += new System.EventHandler(this.NameDisplay_Click);
            // 
            // EventDisplay
            // 
            this.EventDisplay.AutoSize = true;
            this.EventDisplay.Location = new System.Drawing.Point(354, 198);
            this.EventDisplay.Name = "EventDisplay";
            this.EventDisplay.Size = new System.Drawing.Size(44, 16);
            this.EventDisplay.TabIndex = 10;
            this.EventDisplay.Text = "Name";
            this.EventDisplay.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.EventDisplay.Click += new System.EventHandler(this.EventDisplay_Click);
            // 
            // SetStatus
            // 
            this.SetStatus.AutoSize = true;
            this.SetStatus.Location = new System.Drawing.Point(487, 213);
            this.SetStatus.Name = "SetStatus";
            this.SetStatus.Size = new System.Drawing.Size(0, 16);
            this.SetStatus.TabIndex = 11;
            this.SetStatus.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.SetStatus.Click += new System.EventHandler(this.SetStatus_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(305, 198);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(182, 134);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(368, 112);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmButton.TabIndex = 13;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SetStatus);
            this.Controls.Add(this.NameDisplay);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.EventDisplay);
            this.Controls.Add(this.StudentStatus);
            this.Controls.Add(this.StudentEvent);
            this.Controls.Add(this.StudentName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ReportsTitle);
            this.Controls.Add(this.RPBackButton);
            this.Name = "Reports";
            this.Text = "Student Information System";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RPBackButton;
        private System.Windows.Forms.Label ReportsTitle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label StudentName;
        private System.Windows.Forms.Label StudentEvent;
        private System.Windows.Forms.Label StudentStatus;
        private System.Windows.Forms.Label NameDisplay;
        private System.Windows.Forms.Label EventDisplay;
        private System.Windows.Forms.Label SetStatus;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button ConfirmButton;
    }
}
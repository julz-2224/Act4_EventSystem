namespace Act4_EventSystem
{
    partial class ForgotPassword2
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
            this.PRTitle = new System.Windows.Forms.Label();
            this.PR2CancelButton = new System.Windows.Forms.Button();
            this.ConfirmPasswordButton = new System.Windows.Forms.Button();
            this.PREnterEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PRTitle
            // 
            this.PRTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PRTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PRTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PRTitle.Location = new System.Drawing.Point(299, 95);
            this.PRTitle.Name = "PRTitle";
            this.PRTitle.Size = new System.Drawing.Size(184, 27);
            this.PRTitle.TabIndex = 1;
            // 
            // PR2CancelButton
            // 
            this.PR2CancelButton.Location = new System.Drawing.Point(397, 273);
            this.PR2CancelButton.Name = "PR2CancelButton";
            this.PR2CancelButton.Size = new System.Drawing.Size(75, 23);
            this.PR2CancelButton.TabIndex = 8;
            this.PR2CancelButton.Text = "Cancel";
            this.PR2CancelButton.UseVisualStyleBackColor = true;
            this.PR2CancelButton.Click += new System.EventHandler(this.PR2CancelButton_Click);
            // 
            // ConfirmPasswordButton
            // 
            this.ConfirmPasswordButton.Location = new System.Drawing.Point(295, 273);
            this.ConfirmPasswordButton.Name = "ConfirmPasswordButton";
            this.ConfirmPasswordButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmPasswordButton.TabIndex = 7;
            this.ConfirmPasswordButton.Text = "Confirm";
            this.ConfirmPasswordButton.UseVisualStyleBackColor = true;
            this.ConfirmPasswordButton.Click += new System.EventHandler(this.ConfirmPasswordButton_Click);
            // 
            // PREnterEmail
            // 
            this.PREnterEmail.Location = new System.Drawing.Point(295, 174);
            this.PREnterEmail.Name = "PREnterEmail";
            this.PREnterEmail.Size = new System.Drawing.Size(177, 22);
            this.PREnterEmail.TabIndex = 6;
            this.PREnterEmail.Text = "...";
            this.PREnterEmail.TextChanged += new System.EventHandler(this.PREnterEmail_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enter new password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Confirm Password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(295, 226);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 22);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "...";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ForgotPassword2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PR2CancelButton);
            this.Controls.Add(this.ConfirmPasswordButton);
            this.Controls.Add(this.PREnterEmail);
            this.Controls.Add(this.PRTitle);
            this.Name = "ForgotPassword2";
            this.Text = "New Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PRTitle;
        private System.Windows.Forms.Button PR2CancelButton;
        private System.Windows.Forms.Button ConfirmPasswordButton;
        private System.Windows.Forms.TextBox PREnterEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}
namespace Act4_EventSystem
{
    partial class ForgotPassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.PREnterEmail = new System.Windows.Forms.TextBox();
            this.PRConfirmButton = new System.Windows.Forms.Button();
            this.PRCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PRTitle
            // 
            this.PRTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PRTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PRTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PRTitle.Location = new System.Drawing.Point(294, 83);
            this.PRTitle.Name = "PRTitle";
            this.PRTitle.Size = new System.Drawing.Size(184, 27);
            this.PRTitle.TabIndex = 0;
            this.PRTitle.Text = "PASSWORD RECOVERY";
            this.PRTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter email:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // PREnterEmail
            // 
            this.PREnterEmail.Location = new System.Drawing.Point(264, 190);
            this.PREnterEmail.Name = "PREnterEmail";
            this.PREnterEmail.Size = new System.Drawing.Size(177, 22);
            this.PREnterEmail.TabIndex = 2;
            this.PREnterEmail.TextChanged += new System.EventHandler(this.PREnterEmail_TextChanged);
            // 
            // PRConfirmButton
            // 
            this.PRConfirmButton.Location = new System.Drawing.Point(264, 289);
            this.PRConfirmButton.Name = "PRConfirmButton";
            this.PRConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.PRConfirmButton.TabIndex = 3;
            this.PRConfirmButton.Text = "Confirm";
            this.PRConfirmButton.UseVisualStyleBackColor = true;
            this.PRConfirmButton.Click += new System.EventHandler(this.PRConfirmButton_Click);
            // 
            // PRCancelButton
            // 
            this.PRCancelButton.Location = new System.Drawing.Point(403, 289);
            this.PRCancelButton.Name = "PRCancelButton";
            this.PRCancelButton.Size = new System.Drawing.Size(75, 23);
            this.PRCancelButton.TabIndex = 4;
            this.PRCancelButton.Text = "Cancel";
            this.PRCancelButton.UseVisualStyleBackColor = true;
            this.PRCancelButton.Click += new System.EventHandler(this.PRCancelButton_Click);
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PRCancelButton);
            this.Controls.Add(this.PRConfirmButton);
            this.Controls.Add(this.PREnterEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PRTitle);
            this.Name = "ForgotPassword";
            this.Text = "Forgot Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PRTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PREnterEmail;
        private System.Windows.Forms.Button PRConfirmButton;
        private System.Windows.Forms.Button PRCancelButton;
    }
}
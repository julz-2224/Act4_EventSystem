using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Act4_EventSystem
{
    public partial class ForgotPassword2 : Form
    {
        string userEmail;

        public ForgotPassword2(string email)
        {
            InitializeComponent();
            userEmail = email;
        }

        private void ConfirmPasswordButton_Click(object sender, EventArgs e)
        {
            string newPassword = PREnterEmail.Text; // new password textbox
            string confirmPassword = textBox1.Text; // confirm password textbox

            if (string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Please fill in all fields!");
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            string connectionString = "server=localhost;database=event_information_system;uid=root;pwd=;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string updateQuery = "UPDATE students SET password=@pass WHERE email=@email";

                    MySqlCommand cmd = new MySqlCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@pass", newPassword);
                    cmd.Parameters.AddWithValue("@email", userEmail);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Password updated successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoginForm login = new LoginForm();
                        login.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Update failed!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:\n" + ex.Message);
                }
            }
        }

        private void PR2CancelButton_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void PREnterEmail_TextChanged(object sender, EventArgs e) 
        {
            PREnterEmail.UseSystemPasswordChar = true;
        }
        private void textBox1_TextChanged(object sender, EventArgs e) 
        {
            textBox1.UseSystemPasswordChar = true;
        }
        private void label1_Click(object sender, EventArgs e) { }
    }
}
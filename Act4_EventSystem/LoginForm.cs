using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Act4_EventSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        // 🔐 LOGIN BUTTON (DATABASE-BASED)
        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string password = textBox2.Text;

            // VALIDATION
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "server=localhost;database=event_information_system;uid=root;pwd=;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // CHECK USER IN DATABASE
                    string query = "SELECT COUNT(*) FROM students WHERE email=@Email AND password=@Password";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("Login Successful!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // OPEN DASHBOARD
                        Dashboard dashboard = new Dashboard();
                        dashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Email or Password!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error:\n" + ex.Message);
                }
            }
        }

        // EMAIL TEXTBOX EVENT
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // PASSWORD TEXTBOX EVENT
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        /// Email Label Click
        private void label2_Click(object sender, EventArgs e)
        {

        }

        /// Login Title Click
        private void label1_Click(object sender, EventArgs e)
        {

        }

        // 🔐 FORGOT PASSWORD BUTTON
        private void button2_Click(object sender, EventArgs e)
        {
            ForgotPassword fp = new ForgotPassword();
            fp.FormClosed += (s, args) => this.Show(); // return to login
            fp.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
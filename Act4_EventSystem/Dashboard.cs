using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Act4_EventSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        // 📊 LOAD DASHBOARD DATA
        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadDashboardCounts();
        }

        // 📊 METHOD TO GET COUNTS FROM DATABASE
        private void LoadDashboardCounts()
        {


            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();

                    // 👨‍🎓 STUDENTS COUNT
                    MySqlCommand cmdStudents = new MySqlCommand("SELECT COUNT(*) FROM students", conn);
                    int studentCount = Convert.ToInt32(cmdStudents.ExecuteScalar());
                    lblStudentsCount.Text = studentCount.ToString();

                    // 📅 EVENTS COUNT
                    MySqlCommand cmdEvents = new MySqlCommand("SELECT COUNT(*) FROM events", conn);
                    int eventCount = Convert.ToInt32(cmdEvents.ExecuteScalar());
                    lblEventsCount.Text = eventCount.ToString();

                    // 📝 REGISTRATIONS COUNT
                    MySqlCommand cmdReg = new MySqlCommand("SELECT COUNT(*) FROM registrations", conn);
                    int regCount = Convert.ToInt32(cmdReg.ExecuteScalar());
                    lblRegistrationsCount.Text = regCount.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error:\n" + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        // 📑 REPORTS BUTTON
        private void ReportsButton_Click(object sender, EventArgs e)
        {
            // Open Reports Form
            Reports rp = new Reports();
            rp.Show();

            // Hide Dashboard
            this.Hide();
        }

        // ℹ️ ABOUT BUTTON
        private void AboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Event Information System\nVersion 1.0\nDeveloped using C# WinForms",
                "About Program",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        // 🚪 LOGOUT BUTTON
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                LoginForm login = new LoginForm();
                login.Show();
                this.Hide();
            }
        }

        // OPTIONAL EVENTS (SAFE TO KEEP)
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }

        private void lblStudentsCount_Click(object sender, EventArgs e) { }
        private void lblEventsCount_Click(object sender, EventArgs e) { }
        private void lblRegistrationsCount_Click(object sender, EventArgs e) { }

        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void Usermanagement_Click(object sender, EventArgs e)
        {
            // Open Usermanagement Form
            UserManagement rp = new UserManagement();
            rp.Show();

            // Hide Dashboard
            this.Hide();
        }

        private void DashBoardTitle_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Act6EventRegistration db = new Act6EventRegistration();
            db.Show();
            this.Hide();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void CreateeventButton_Click(object sender, EventArgs e)
        {
            Act6EventCreation db = new Act6EventCreation();
            db.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Act6Attendance db = new Act6Attendance();
            db.Show();
            this.Hide();
        }

        private void btnRepGen_Click(object sender, EventArgs e)
        {
            Act6ReportsGenerator db = new Act6ReportsGenerator();
            db.Show();
            this.Hide();
        }
    }
    }
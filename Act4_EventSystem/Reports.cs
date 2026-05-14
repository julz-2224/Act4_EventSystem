using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Act4_EventSystem
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
        }


        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            LoadStudentReport();
        }

        private void LoadStudentReport()
        {
            string connectionString = "server=localhost;database=event_information_system;uid=root;pwd=;";

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter Student ID!");
                return;
            }

            int studentId;

            if (!int.TryParse(textBox1.Text, out studentId))
            {
                MessageBox.Show("Invalid Student ID!");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            CONCAT(s.first_name, ' ', s.last_name) AS student_name,
                            e.event_name,
                            r.status
                        FROM registrations r
                        JOIN students s ON r.student_id = s.student_id
                        JOIN events e ON r.event_id = e.event_id
                        WHERE r.student_id = @id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", studentId);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    flowLayoutPanel1.Controls.Clear();

                    bool found = false;

                    while (reader.Read())
                    {
                        found = true;

                        Label lbl = new Label();

                        lbl.AutoSize = true;
                        lbl.BorderStyle = BorderStyle.FixedSingle;
                        lbl.Padding = new Padding(10);
                        lbl.Margin = new Padding(5);

                        lbl.Text =
                            "Name: " + reader["student_name"] + "\n" +
                            "Event: " + reader["event_name"] + "\n" +
                            "Status: " + reader["status"];

                        flowLayoutPanel1.Controls.Add(lbl);
                    }

                    if (!found)
                    {
                        Label lbl = new Label();
                        lbl.AutoSize = true;
                        lbl.Text = "This student does not exist or isn't registered to any event/seminar. ID: " + studentId;
                        flowLayoutPanel1.Controls.Add(lbl);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:\n" + ex.Message);
                }
            }
        }

        // 🔙 BACK BUTTON
        private void RPBackButton_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            db.Show();
            this.Hide();
        }

        // unused events
        private void ReportsTitle_Click(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void NameDisplay_Click(object sender, EventArgs e) { }
        private void EventDisplay_Click(object sender, EventArgs e) { }
        private void SetStatus_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
    }
}
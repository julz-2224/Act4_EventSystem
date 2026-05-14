using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Act4_EventSystem
{
    public partial class Act6Attendance : Form
    {
        public Act6Attendance()
        {
            InitializeComponent();
        }

        // LOAD FORM
        private void Act6Attendance_Load(object sender, EventArgs e)
        {
            LoadStudents();
            LoadEvents();
            LoadAttendance();

            Attendance.Items.Clear();
            Attendance.Items.Add("Present");
            Attendance.Items.Add("Absent");
            Attendance.Items.Add("Late");
        }

        // LOAD STUDENTS
        private void LoadStudents()
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = "SELECT student_id, first_name FROM students";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    SelectStudent.DataSource = dt;
                    SelectStudent.DisplayMember = "first_name";
                    SelectStudent.ValueMember = "student_id";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // LOAD EVENTS
        private void LoadEvents()
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = "SELECT event_id, event_name FROM events";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    SelectEvent.DataSource = dt;
                    SelectEvent.DisplayMember = "event_name";
                    SelectEvent.ValueMember = "event_id";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // LOAD ATTENDANCE GRID
        private void LoadAttendance()
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            a.attendance_id,
                            s.first_name,
                            e.event_name,
                            a.attendance_status,
                            a.attendance_date
                        FROM attendance a
                        JOIN students s ON a.student_id = s.student_id
                        JOIN events e ON a.event_id = e.event_id";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    AttendaceGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // SAVE ATTENDANCE
        private void SaveAttendanceButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = @"
                        INSERT INTO attendance
                        (student_id, event_id, attendance_status, attendance_date)
                        VALUES
                        (@student, @event, @status, @date)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@student", SelectStudent.SelectedValue);
                    cmd.Parameters.AddWithValue("@event", SelectEvent.SelectedValue);
                    cmd.Parameters.AddWithValue("@status", Attendance.Text);
                    cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value.Date);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Attendance Saved!");

                    LoadAttendance();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // BACK BUTTON
        private void BackButton_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            db.Show();
            this.Hide();
        }

        // UNUSED EVENTS
        private void SelectStudent_SelectedIndexChanged(object sender, EventArgs e) { }
        private void SelectEvent_SelectedIndexChanged(object sender, EventArgs e) { }
        private void Attendance_SelectedIndexChanged(object sender, EventArgs e) { }
        private void AttendaceGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
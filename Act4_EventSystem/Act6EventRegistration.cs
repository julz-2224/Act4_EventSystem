using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Act4_EventSystem
{
    public partial class Act6EventRegistration : Form
    {
        public Act6EventRegistration()
        {
            InitializeComponent();
        }

        // FORM LOAD
        private void Act6EventRegistration_Load(object sender, EventArgs e)
        {
            LoadStudents();
            LoadEvents();
            LoadRegistrations();

            // STATUS OPTIONS
            SelectStatusCombobox.Items.Clear();

            SelectStatusCombobox.Items.Add("Registered");
            SelectStatusCombobox.Items.Add("Attended");
            SelectStatusCombobox.Items.Add("Cancelled");

            // DEFAULT DATE
            RegistrationDatePicker.Value = DateTime.Now;
        }

        // LOAD STUDENTS
        private void LoadStudents()
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query =
                        "SELECT student_id, first_name FROM students";

                    MySqlDataAdapter adapter =
                        new MySqlDataAdapter(query, conn);

                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    SelectStudentCombobox.DataSource = dt;
                    SelectStudentCombobox.DisplayMember = "first_name";
                    SelectStudentCombobox.ValueMember = "student_id";
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

                    string query =
                        "SELECT event_id, event_name FROM events";

                    MySqlDataAdapter adapter =
                        new MySqlDataAdapter(query, conn);

                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    SelectEventCombobox.DataSource = dt;
                    SelectEventCombobox.DisplayMember = "event_name";
                    SelectEventCombobox.ValueMember = "event_id";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // LOAD REGISTRATION TABLE
        private void LoadRegistrations()
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            r.registration_id,
                            s.first_name,
                            e.event_name,
                            r.registration_date,
                            r.status
                        FROM registrations r
                        JOIN students s 
                            ON r.student_id = s.student_id
                        JOIN events e 
                            ON r.event_id = e.event_id";

                    MySqlDataAdapter adapter =
                        new MySqlDataAdapter(query, conn);

                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    dataGridView1Registration.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // REGISTER BUTTON
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = @"
                        INSERT INTO registrations
                        (
                            student_id,
                            event_id,
                            registration_date,
                            status
                        )
                        VALUES
                        (
                            @student,
                            @event,
                            @date,
                            @status
                        )";

                    MySqlCommand cmd =
                        new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue(
                        "@student",
                        SelectStudentCombobox.SelectedValue
                    );

                    cmd.Parameters.AddWithValue(
                        "@event",
                        SelectEventCombobox.SelectedValue
                    );

                    cmd.Parameters.AddWithValue(
                        "@date",
                        RegistrationDatePicker.Value.Date
                    );

                    cmd.Parameters.AddWithValue(
                        "@status",
                        SelectStatusCombobox.Text
                    );

                    cmd.ExecuteNonQuery();

                    MessageBox.Show(
                        "Registration Successful!"
                    );

                    LoadRegistrations();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // UNUSED EVENTS
        private void SelectStudentCombobox_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {

        }

        private void SelectEventCombobox_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {

        }

        private void SelectStatusCombobox_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {

        }

        private void dataGridView1Registration_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {

        }

        private void s_Click(object sender, EventArgs e)
        {

        }

        private void RegistrationDatePicker_ValueChanged(
            object sender,
            EventArgs e)
        {

        }

        // BACK BUTTON
        private void BackButton_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            db.Show();
            this.Hide();
        }
    }
}
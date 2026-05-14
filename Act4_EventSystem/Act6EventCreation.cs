using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Act4_EventSystem
{
    public partial class Act6EventCreation : Form
    {
        int selectedEventId = 0;
        public Act6EventCreation()
        {
            InitializeComponent();
        }

        private void Act6EventCreation_Load(object sender, EventArgs e)
        {
            LoadEvents();
        }

        private void LoadEvents()
        {
            using (MySql.Data.MySqlClient.MySqlConnection connections = DBConnection.GetConnection())
            {
                try
                {
                    connections.Open();
                    string query = "SELECT event_id, event_name, event_date, venue FROM events";
                    MySql.Data.MySqlClient.MySqlDataAdapter adapter = new MySql.Data.MySqlClient.MySqlDataAdapter(query, connections);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

        }
           




        /// Title ///
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void EventName_TextChanged(object sender, EventArgs e)
        {

        }

        private void EventDate_ValueChanged(object sender, EventArgs e)
        {

        }

        /// Event Venue ////
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = @"
                        INSERT INTO events
                        (
                            event_name,
                            event_date,
                            venue
                        )
                        VALUES
                        (
                            @name,
                            @date,
                            @venue
                        )";

                    MySqlCommand cmd =
                        new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue(
                        "@name",
                        EventName.Text
                    );

                    cmd.Parameters.AddWithValue(
                        "@date",
                        EventDate.Value.Date
                    );

                    cmd.Parameters.AddWithValue(
                        "@venue",
                        textBox2.Text
                    );

                    cmd.ExecuteNonQuery();

                    MessageBox.Show(
                        "Event Added Successfully!"
                    );

                    LoadEvents();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = @"
                        UPDATE events
                        SET
                            event_name = @name,
                            event_date = @date,
                            venue = @venue
                        WHERE event_id = @id";

                    MySqlCommand cmd =
                        new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue(
                        "@name",
                        EventName.Text
                    );

                    cmd.Parameters.AddWithValue(
                        "@date",
                        EventDate.Value.Date
                    );

                    cmd.Parameters.AddWithValue(
                        "@venue",
                        textBox2.Text
                    );

                    cmd.Parameters.AddWithValue(
                        "@id",
                        selectedEventId
                    );

                    cmd.ExecuteNonQuery();

                    MessageBox.Show(
                        "Event Updated Successfully!"
                    );

                    LoadEvents();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedEventId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["event_id"].Value);
                EventName.Text = dataGridView1.Rows[e.RowIndex].Cells["event_name"].Value.ToString();
                EventDate.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["event_date"].Value);
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["venue"].Value.ToString();
        }
    }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

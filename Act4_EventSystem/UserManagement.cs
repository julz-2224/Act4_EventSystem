using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Act4_EventSystem
{
    public partial class UserManagement : Form
    {
        int selectedUserId = 0;
        public UserManagement()
        {
            InitializeComponent();
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = "SELECT student_id, first_name, last_name, email, department_id, status FROM students";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);

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


        /// Scapped
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /// Email
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        /// Password
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.UseSystemPasswordChar = true;
        }

        /// Combobox status
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = "INSERT INTO students(first_name, last_name, email, password, department_id, status) VALUES(@name,@lname,@email,@pass,@dept,@status)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@name", textBox1.Text);
                    cmd.Parameters.AddWithValue("@lname", LastName.Text);
                    cmd.Parameters.AddWithValue("@email", textBox2.Text);
                    cmd.Parameters.AddWithValue("@pass", textBox3.Text);
                    cmd.Parameters.AddWithValue("@dept", DeptID.Text);
                    cmd.Parameters.AddWithValue("@status", comboBox1.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Account Added!");

                    LoadUsers();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = "UPDATE students SET first_name=@name, last_name=@lname, email=@email, password=@pass, department_id=@dept, status=@status WHERE student_id=@id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@name", textBox1.Text);
                    cmd.Parameters.AddWithValue("@lname", LastName.Text);
                    cmd.Parameters.AddWithValue("@email", textBox2.Text);
                    cmd.Parameters.AddWithValue("@pass", textBox3.Text);
                    cmd.Parameters.AddWithValue("@dept", DeptID.Text);
                    cmd.Parameters.AddWithValue("@status", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@id", selectedUserId);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Account Updated!");

                    LoadUsers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Activate_Click(object sender, EventArgs e)
        {
            UpdateStatus("Active");
        }

        private void Deactivate_Click(object sender, EventArgs e)
        {
            UpdateStatus("Inactive");
        }

        private void UpdateStatus(string status)
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = "UPDATE students SET status=@status WHERE student_id=@id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@id", selectedUserId);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Status Updated!");

                    LoadUsers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        /// List of users
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedUserId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["student_id"].Value);

            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["first_name"].Value.ToString();
            LastName.Text = dataGridView1.Rows[e.RowIndex].Cells["last_name"].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["email"].Value.ToString();
            DeptID.Text = dataGridView1.Rows[e.RowIndex].Cells["department_id"].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["status"].Value.ToString();
        }



        /// Search box bro
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = "SELECT student_id, first_name, last_name, email, department_id, status FROM students WHERE first_name LIKE @search OR email LIKE @search";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);

                    adapter.SelectCommand.Parameters.AddWithValue("@search", "%" + textBox4.Text + "%");

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

        ///  First Name

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            db.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeptID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

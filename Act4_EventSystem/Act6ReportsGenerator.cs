using MySql.Data.MySqlClient;
using OfficeOpenXml;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Act4_EventSystem
{
    public partial class Act6ReportsGenerator : Form
    {
        DataTable currentTable = new DataTable();

        public Act6ReportsGenerator()
        {
            InitializeComponent();
        }

        // FORM LOAD
        private void Act6ReportsGenerator_Load(object sender, EventArgs e)
        {
            // REPORT TYPES
            cmbReportType.Items.Clear();

            cmbReportType.Items.Add("Registrations");
            cmbReportType.Items.Add("Events");
            cmbReportType.Items.Add("Attendance");

            // LABELS
            labelCompany.Text =
                "EVENT INFORMATION SYSTEM";

            labelSignature.Text =
                "Authorized Signature: ____________";
        }

        // REPORT TYPE
        private void cmbReportType_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {

        }

        // LOAD BUTTON
        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn =
                DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = "";

                    // REGISTRATION REPORT
                    if (cmbReportType.Text ==
                        "Registrations")
                    {
                        query = @"
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
                    }

                    // EVENTS REPORT
                    else if (cmbReportType.Text ==
                        "Events")
                    {
                        query = @"
                            SELECT
                                event_id,
                                event_name,
                                event_date,
                                venue
                            FROM events";
                    }

                    // ATTENDANCE REPORT
                    else if (cmbReportType.Text ==
                        "Attendance")
                    {
                        query = @"
                            SELECT
                                a.attendance_id,
                                s.first_name,
                                e.event_name,
                                a.attendance_status,
                                a.attendance_date
                            FROM attendance a
                            JOIN students s
                                ON a.student_id = s.student_id
                            JOIN events e
                                ON a.event_id = e.event_id";
                    }

                    MySqlDataAdapter adapter =
                        new MySqlDataAdapter(query, conn);

                    currentTable = new DataTable();

                    adapter.Fill(currentTable);

                    dataGridView1.DataSource =
                        currentTable;

                    LoadChart();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // LOAD CHART
        private void LoadChart()
        {
            chart1.Series.Clear();

            Series series = new Series();

            series.ChartType =
                SeriesChartType.Column;

            chart1.Series.Add(series);

            foreach (DataRow row in currentTable.Rows)
            {
                series.Points.AddXY(
                    row[0].ToString(),
                    1
                );
            }
        }

        // EXPORT EXCEL
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            try
            {
 
                OfficeOpenXml.ExcelPackage.License.SetNonCommercialPersonal("Admin");

                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "Excel Workbook|*.xlsx";
                    sfd.Title = "Save Excel Report";
                    sfd.FileName = "EventReport.xlsx";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (OfficeOpenXml.ExcelPackage package =
                            new OfficeOpenXml.ExcelPackage())
                        {
                            // =========================
                            // SHEET 1 : REPORT DATA
                            // =========================
                            var ws = package.Workbook.Worksheets.Add("Report");

                            // COMPANY HEADER
                            ws.Cells["A1"].Value = "Event Information System";
                            ws.Cells["A2"].Value = "Generated Report";
                            ws.Cells["A1:A2"].Style.Font.Bold = true;
                            ws.Cells["A1:A2"].Style.Font.Size = 14;

                            // COLUMN HEADERS
                            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                            {
                                ws.Cells[4, i + 1].Value =
                                    dataGridView1.Columns[i].HeaderText;

                                ws.Cells[4, i + 1].Style.Font.Bold = true;
                            }

                            // DATA
                            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                            {
                                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                                {
                                    ws.Cells[i + 5, j + 1].Value =
                                        dataGridView1.Rows[i].Cells[j].Value?.ToString();
                                }
                            }

                            // SIGNATURE PLACEHOLDER
                            int lastRow = dataGridView1.Rows.Count + 8;

                            ws.Cells["A" + lastRow].Value =
                                "Prepared by:";
                            ws.Cells["A" + (lastRow + 2)].Value =
                                "________________________";

                            // AUTO FIT
                            ws.Cells[ws.Dimension.Address].AutoFitColumns();

                            // =========================
                            // SHEET 2 : GRAPH
                            // =========================
                            var chartSheet =
                                package.Workbook.Worksheets.Add("Graph");

                            chartSheet.Cells["A1"].Value =
                                "Graph Placeholder";

                            // SAVE FILE
                            System.IO.File.WriteAllBytes(
                                sfd.FileName,
                                package.GetAsByteArray());

                            MessageBox.Show(
                                "Excel Report Exported Successfully!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // GRID CLICK
        private void dataGridView1_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {

        }

        // LOGO
        private void pictureBox2_Click(
            object sender,
            EventArgs e)
        {

        }

        // COMPANY LABEL
        private void labelCompany_Click(
            object sender,
            EventArgs e)
        {

        }

        // SIGNATURE LABEL
        private void labelSignature_Click(
            object sender,
            EventArgs e)
        {

        }

        // CHART
        private void chart1_Click(
            object sender,
            EventArgs e)
        {

        }
    }
}
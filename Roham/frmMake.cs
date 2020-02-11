using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Roham
{
    public partial class frmMake : Form
    {
        int ID;

        public frmMake()
        {
            InitializeComponent();
            DisplayData();
        }

        private void DisplayData()
        {
            using (SqlConnection connection = DbHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand("SelectMake", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                da.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString());
            txtUnit.Text = dataGridView1.Rows[e.RowIndex].Cells["car"].Value.ToString();
            checkBox1.Checked = !(dataGridView1.Rows[e.RowIndex].Cells["iscompany"].Value is DBNull) && (bool)dataGridView1.Rows[e.RowIndex].Cells["iscompany"].Value;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtUnit.Text != "")
            {
                using (SqlConnection connection = DbHelper.GetConnection())
                {
                    SqlCommand command = new SqlCommand("InsertMake", connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    command.Parameters.AddWithValue("@make", txtUnit.Text.Trim());
                    command.Parameters.AddWithValue("@company", checkBox1.Checked);
                    command.ExecuteNonQuery();
                    DisplayData();
                    ClearData();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtUnit.Text != "")
            {
                using (SqlConnection connection = DbHelper.GetConnection())
                {
                    SqlCommand command = new SqlCommand("UpdateMake", connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    command.Parameters.AddWithValue("@id", ID);
                    command.Parameters.AddWithValue("@make", txtUnit.Text.Trim());
                    command.Parameters.AddWithValue("@company", checkBox1.Checked);
                    command.ExecuteNonQuery();
                    DisplayData();
                    ClearData();
                }
            }
        }

        private void ClearData()
        {
            txtUnit.Text = "";
            checkBox1.Checked = false;
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
            {
                Name = "delete",
                Text = "Delete",
                UseColumnTextForButtonValue = true,
            };
            int columnIndex = 4;
            if (dataGridView1.Columns["delete"] == null)
            {
                dataGridView1.Columns.Insert(columnIndex, deleteButtonColumn);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["delete"].Index)
            {
                ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString());

                if (ID != 0)
                {
                    using (SqlConnection connection = DbHelper.GetConnection())
                    {
                        SqlCommand command = new SqlCommand("DeleteMake", connection)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                        command.Parameters.AddWithValue("@id", ID);
                        command.ExecuteNonQuery();
                        DisplayData();
                        ClearData();
                    }
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            using (SqlConnection connection = DbHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand("SelectMake", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@make", toolStripTextBox1.Text.Trim());
                if (!string.IsNullOrEmpty(toolStripComboBox1.SelectedText))
                {
                    var company = toolStripComboBox1.SelectedText.ToLower() == "car" ? 0 : 1;
                    command.Parameters.AddWithValue("@company", company);
                }
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                da.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    dataGridView1.DataSource = dataTable;
                }
            }
        }

    }
}
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Roham
{
    public partial class frmColorType : Form
    {
        int ID;

        public frmColorType()
        {
            InitializeComponent();
            DisplayData();
        }

        private void DisplayData()
        {
            using (SqlConnection connection = DbHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand("SelectColorType", connection)
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
            txtUnit.Text = dataGridView1.Rows[e.RowIndex].Cells["type"].Value.ToString();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtUnit.Text != "")
            {
                using (SqlConnection connection = DbHelper.GetConnection())
                {
                    SqlCommand command = new SqlCommand("InsertColorType", connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    command.Parameters.AddWithValue("@type", txtUnit.Text.Trim());
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
                    SqlCommand command = new SqlCommand("UpdateColorType", connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    command.Parameters.AddWithValue("@id", ID);
                    command.Parameters.AddWithValue("@type", txtUnit.Text.Trim());
                    command.ExecuteNonQuery();
                    DisplayData();
                    ClearData();
                }
            }
        }

        private void ClearData()
        {
            txtUnit.Text = "";
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
            {
                Name = "delete",
                Text = "Delete",
                UseColumnTextForButtonValue = true,
            };
            int columnIndex = 3;
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
                        SqlCommand command = new SqlCommand("DeleteColorType", connection)
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

    }
}
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Roham
{
    public partial class frmNotes : Form
    {
        public frmNotes()
        {
            InitializeComponent();
            DisplayData();
        }

        private void DisplayData()
        {
            using (SqlConnection connection = DbHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand("SelectNote", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                da.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    textBox1.Text = dataTable.Rows[0]["Body"].ToString();
                }
            }
        }


        private void frmNotes_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (SqlConnection connection = DbHelper.GetConnection())
            {
                SqlCommand command = new SqlCommand("UpdateNote", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@body", textBox1.Text.Trim());
                command.ExecuteNonQuery();
            }
        }

    }
}
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Roham
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            cmbMake.DataSource = DbHelper.LoadDataSet("SelectCar").Tables[0];
            cmbMake.DisplayMember = "Car";
            cmbMake.ValueMember = "ID";

            cmbCompany.DataSource = DbHelper.LoadDataSet("SelectCompany").Tables[0];
            cmbCompany.DisplayMember = "Car";
            cmbCompany.ValueMember = "ID";

            cmbColorType.DataSource = DbHelper.LoadDataSet("SelectTypes").Tables[0];
            cmbColorType.DisplayMember = "Type";
            cmbColorType.ValueMember = "ID";


        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbMake.SelectedIndex = cmbColorType.SelectedIndex = cmbCompany.SelectedIndex = 0;
            txtColorCode.Text = txtColorDesc1.Text = txtColorDesc2.Text = txtUsage.Text = dtDate.Text = string.Empty;
            dtDate.Value = null;
            SearchGrid.DataSource = null;
            SearchGrid.Columns.Clear();

        }
        private void Search()
        {
            SearchGrid.DataSource = null;
            SearchGrid.Columns.Clear();
            toolStripStatusLabel1.Text = "";

            if ((cmbCompany.SelectedIndex != 0) && (cmbMake.SelectedIndex != 0))
            {
                MessageBox.Show("لطفا از بین شرکت و اتومبیل یکی را انتخاب کنید", "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);

                cmbCompany.SelectedValue = "1";
                cmbMake.Focus();
                return;
            }
            using (SqlConnection connection = DbHelper.GetConnection())
            {
                SqlCommand com = new SqlCommand("Search", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                if (cmbMake.SelectedIndex != 0)
                {
                    com.Parameters.AddWithValue("@carid", cmbMake.SelectedValue);
                }
                if (cmbCompany.SelectedIndex != 0)
                {
                    com.Parameters.AddWithValue("@carid", cmbCompany.SelectedValue);
                }
                if (cmbColorType.SelectedIndex != 0)
                {
                    com.Parameters.AddWithValue("@typeid", cmbColorType.SelectedValue);
                }
                if (!string.IsNullOrEmpty(txtColorCode.Text.Trim()))
                {
                    com.Parameters.AddWithValue("@code", txtColorCode.Text.Trim());
                }
                if (!string.IsNullOrEmpty(txtColorDesc1.Text.Trim()))
                {
                    com.Parameters.AddWithValue("@desc1", txtColorDesc1.Text.Trim());
                }
                if (!string.IsNullOrEmpty(txtColorDesc2.Text.Trim()))
                {
                    com.Parameters.AddWithValue("@desc2", txtColorDesc2.Text.Trim());
                }
                if (!string.IsNullOrEmpty(txtUsage.Text.Trim()))
                {
                    com.Parameters.AddWithValue("@usage", txtUsage.Text.Trim());
                }
                if (!string.IsNullOrEmpty(dtDate.Text))
                {
                    com.Parameters.AddWithValue("@date", dtDate.Value);
                }

                SqlDataAdapter da = new SqlDataAdapter(com);
                DataSet ds = new DataSet();

                try
                {
                    var recordCount = da.Fill(ds, "search");
                    var result = ds.Tables["search"];
                    if (result.Rows.Count > 0)
                    {
                        SearchGrid.DataSource = result;
                        toolStripStatusLabel1.Text = recordCount.ToString();
                    }
                    else
                    {
                        MessageBox.Show("رنگی با این مشخصات پیدا نشد", "جستجوی رنگ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطا" + ex.Message);
                }
            }

        }
        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var path = @"C:\FormulBackup\";
            if (Directory.Exists(path))
            {
                string[] files = Directory.GetFiles(path);
                foreach (var file in files)
                {
                    File.Delete(file);
                }
            }
            else
            {
                MessageBox.Show("لطفا در درایو C یک فولدر به نام FormulBackup ایجادکنید", "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                return;
            }

            using (SqlConnection dbConnection = DbHelper.GetConnection())
            {
                SqlCommand com = new SqlCommand("BackUpAll", dbConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                try
                {
                    com.ExecuteNonQuery();
                    MessageBox.Show("بک آپ با موفقیت انجام شد", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Backup", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.ShowDialog();
        }

        private void colorTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmColorType color = new frmColorType();
            color.ShowDialog();
        }
        private void SearchGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var colorCol = SearchGrid.Columns["ColorId"];
            if (colorCol != null) colorCol.Visible = false;

            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn
            {
                Name = "Edit",
                Text = "Edit",
                UseColumnTextForButtonValue = true,
            };
            int columnIndex = 8;
            if (SearchGrid.Columns["Edit"] == null)
            {
                SearchGrid.Columns.Insert(columnIndex, editButtonColumn);
            }
        }
        private void SearchGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == SearchGrid.Columns["Edit"].Index)
            {
                var dataGridView = sender as DataGridView;
                if (dataGridView != null && dataGridView.CurrentRow != null)
                {
                    var colorId = (int)dataGridView.CurrentRow.Cells[0].Value;
                    frmEditFomrul editForm = new frmEditFomrul
                    {
                        ColorId = colorId
                    };

                    editForm.ShowDialog();
                }
            }

            if (e.ColumnIndex == SearchGrid.Columns["Comment"].Index)
            {
                var dataGridView = sender as DataGridView;
                if (dataGridView != null && dataGridView.CurrentRow != null)
                {
                    var comment = dataGridView.CurrentRow.Cells[4].Value;
                    MessageBox.Show(comment.ToString(), "شرح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (e.ColumnIndex == SearchGrid.Columns["Usage"].Index)
            {
                var dataGridView = sender as DataGridView;
                if (dataGridView != null && dataGridView.CurrentRow != null)
                {
                    var comment = dataGridView.CurrentRow.Cells[5].Value;
                    MessageBox.Show(comment.ToString(), "موارد کاربرد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void fomrulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFormul formul = new frmFormul();
            formul.ShowDialog();
        }
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void SearchGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var colorId = Convert.ToInt32(SearchGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            frmResult result = new frmResult { ColorId = colorId };
            result.ShowDialog();
        }

        private void notesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNotes notes = new frmNotes();
            notes.ShowDialog();
        }

        private void unitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUnit unit = new frmUnit();
            unit.ShowDialog();

        }

        private void carToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMake make = new frmMake();
            make.ShowDialog();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChanegPassword frm = new frmChanegPassword();
            frm.ShowDialog();
        }

        private void SearchGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (SearchGrid.Columns[e.ColumnIndex].Name.Equals("LastUpdate"))
            {

                if (!string.IsNullOrEmpty(e.Value.ToString()))
                {
                    DateTime dt;
                    DateTime.TryParse(e.Value.ToString(), out dt);
                    e.Value = DbHelper.GregorianToShamsi(dt);
                }
            }
        }

        private void baseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBase frmBase = new frmBase();
            frmBase.ShowDialog();
        }
    }

}
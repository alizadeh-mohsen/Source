using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Roham
{

    public partial class frmFormul : Form
    {
        private readonly SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=ColorDb;Integrated Security=True");

        public frmFormul()
        {
            InitializeComponent();
        }

        private void frmFormul_Load(object sender, EventArgs e)
        {
            cmbMake.DataSource = DbHelper.LoadDataSet("SelectCar").Tables[0];
            cmbMake.DisplayMember = "Car";
            cmbMake.ValueMember = "ID";

            cmbCompany.DataSource = DbHelper.LoadDataSet("SelectCompany").Tables[0];
            cmbCompany.DisplayMember = "Car";
            cmbCompany.ValueMember = "ID";

            cmbColorGroup.DataSource = DbHelper.LoadDataSet("SelectTypes").Tables[0];
            cmbColorGroup.DisplayMember = "Type";
            cmbColorGroup.ValueMember = "ID";

            cmbUnit.DataSource = DbHelper.LoadDataSet("SelectUnit").Tables[0];
            cmbUnit.DisplayMember = "Name";
            cmbUnit.ValueMember = "ID";

            cmbBase.DataSource = DbHelper.LoadDataSet("SelectBase").Tables[0];
            cmbBase.DisplayMember = "Name";
            cmbBase.ValueMember = "ID";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {

            if ((cmbMake.SelectedIndex == 0) && (cmbCompany.SelectedIndex == 0) ||
                (cmbMake.SelectedIndex != 0) && (cmbCompany.SelectedIndex != 0))
            {
                MessageBox.Show("لطفا از بین شرکت و اتومبیل یکی را انتخاب کنید", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                cmbCompany.SelectedValue = "1";
                cmbMake.Focus();
                return;
            }

            if (cmbColorGroup.SelectedIndex == 0)
            {
                MessageBox.Show("نوع رنگ را از لیست انتخاب کنید", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);

                cmbColorGroup.Focus();
                return;
            }
            if (txtColorCode.Text == string.Empty)
            {
                MessageBox.Show("کد رنگ را وارد کنید", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                txtColorCode.Focus();
                return;
            }
            if (txtBaseColor.Text != string.Empty || txtWeight.Text != string.Empty)
            {
                MessageBox.Show("فرمولی وجود دارد که وارد نشده است", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                txtBaseColor.Focus();
                return;
            }

            if (lstWeight.Items.Count == 0 || lstBaseColor.Items.Count == 0)
            {
                MessageBox.Show("فرمول را وارد کنید", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                txtBaseColor.Focus();
                return;
            }
            if (lstBaseColor.Items.Count != lstWeight.Items.Count)
            {
                MessageBox.Show("تعداد مادر رنگها و وزن های وارد شده برابر نیست", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                return;
            }

            using (SqlConnection dbConnection = DbHelper.GetConnection())
            {

                SqlCommand com = dbConnection.CreateCommand();

                com.CommandText = "InsertColor";
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@carid",
                    cmbMake.SelectedValue.ToString() == "1" ? cmbCompany.SelectedValue : cmbMake.SelectedValue);

                com.Parameters.AddWithValue("@typeid", cmbColorGroup.SelectedValue);
                com.Parameters.AddWithValue("@code", txtColorCode.Text.Trim());
                com.Parameters.AddWithValue("@comment", txtColorDesc.Text.Trim());
                com.Parameters.AddWithValue("@UnitId", cmbUnit.SelectedValue);
                com.Parameters.AddWithValue("@BaseId", cmbBase.SelectedValue);

                com.Parameters.AddWithValue("@usage", txtUsage.Text.Trim());
                
                com.Parameters.Add("@newid", SqlDbType.Int);
                com.Parameters["@newid"].Direction = ParameterDirection.Output;

                try
                {
                    com.ExecuteNonQuery();
                    string colorId = com.Parameters["@newid"].Value.ToString();
                    com.CommandText = "InsertFormul";
                    for (int i = 0; i < lstBaseColor.Items.Count; i++)
                    {
                        com.Parameters.Clear();
                        com.Parameters.AddWithValue("@ColorID", colorId);
                        com.Parameters.AddWithValue("@code", lstBaseColor.Items[i].ToString());
                        com.Parameters.AddWithValue("@weight", lstWeight.Items[i]);

                        com.ExecuteNonQuery();
                    }

                    MessageBox.Show("فرمول جدید با موفقیت ذخیره شد", "فرمول جدید", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطا" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void txtBaseColor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtWeight.Focus();
        }

        private void txtWeight_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtBaseColor.Text != string.Empty)
                {
                    try
                    {
                        float.Parse(txtWeight.Text);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("وزن وارد شده صحیح نیست", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtWeight.Focus();
                        return;
                    }

                    lstBaseColor.Items.Add(txtBaseColor.Text);
                    lstWeight.Items.Add(txtWeight.Text);
                    lblTotal.Text = (float.Parse(txtWeight.Text) + float.Parse(lblTotal.Text)).ToString();
                    txtBaseColor.Text = txtWeight.Text = string.Empty;

                    txtBaseColor.Focus();
                }
                else
                {
                    MessageBox.Show("ابتدا مادر رنگ را وارد کنید", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBaseColor.Focus();

                }
            }
        }

        private void lstWeight_MouseUp(object sender, MouseEventArgs e)
        {
            if (lstWeight.SelectedIndex != -1)
            {
                if (txtBaseColor.Text == string.Empty && txtWeight.Text == string.Empty)
                {
                    int index = lstWeight.SelectedIndex;
                    txtWeight.Text = lstWeight.SelectedItem.ToString();
                    txtBaseColor.Text = lstBaseColor.Items[index].ToString();
                    lstWeight.Items.RemoveAt(index);
                    lstBaseColor.Items.RemoveAt(index);

                    lblTotal.Text = (float.Parse(lblTotal.Text) - (float.Parse(txtWeight.Text))).ToString();
                    txtBaseColor.Focus();
                }
            }

        }

        private void lstBaseColor_MouseUp(object sender, MouseEventArgs e)
        {
            if (lstBaseColor.SelectedIndex != -1)
            {
                if (txtBaseColor.Text == string.Empty && txtWeight.Text == string.Empty)
                {
                    int index = lstBaseColor.SelectedIndex;
                    txtBaseColor.Text = lstBaseColor.SelectedItem.ToString();
                    txtWeight.Text = lstWeight.Items[index].ToString();
                    lstBaseColor.Items.RemoveAt(index);
                    lstWeight.Items.RemoveAt(index);
                    lblTotal.Text = (float.Parse(lblTotal.Text) - (float.Parse(txtWeight.Text))).ToString();
                    txtBaseColor.Focus();
                }
            }
        }

        private void cmbMake_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cmbCompany.Focus();
        }

        private void cmbColorGroup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtColorCode.Focus();
        }

        private void txtColorCode_Enter(object sender, EventArgs e)
        {
            txtColorCode.Select(0, txtColorCode.Text.Length);
        }

        private void txtBaseColor_Enter(object sender, EventArgs e)
        {
            txtBaseColor.Select(0, txtBaseColor.Text.Length);
        }

        private void txtWeight_Enter(object sender, EventArgs e)
        {
            txtWeight.Select(0, txtWeight.Text.Length);
        }

        private void txtColorCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtBaseColor.Focus();
        }

        private void cmbCompany_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cmbColorGroup.Focus();
        }

    }
}
